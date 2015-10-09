using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.WebSockets;
using System.Net;
using System.Threading;
using System.Web.Script.Serialization;
using System.IO;
using SteamKit2;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        ClientWebSocket webSocket = null;
        delegate void SetTextCallback(string text);
        PictureBox PlaneIcon = new PictureBox();
        ServerClasses.StatusDataJson StatusData = new ServerClasses.StatusDataJson();
        ServerClasses.PlaneData[] PlaneDataArray = new ServerClasses.PlaneData[0];
        SteamClient client;
        CallbackManager manager;
        SteamUser user;
        string ServerUrl = "";
        bool isRunning = false;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           

        }

        public void LoadIcons()
        {
            PlaneIcon.Load("http://map.playrust.io/img/plane.png");
            PlaneIcon.BackColor = Color.Transparent;
            PlaneIcon.Parent = MapImage;
            
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ConnectButton.Text == "Connect")
                {
                    Connect("ws://" + ServerIPBox.Text + ":" + ServerPortBox.Text + "/ms");
                    ConnectButton.Text = "Disconnect";
                }
            else
                {
                    ConnectButton.Text = "Connect";
                }
        }
       
        public void UpdateOutPut(string UpdateText)
        {
            OutPut.AppendText(UpdateText);
        }

        public void OnConnected(SteamClient.ConnectedCallback callback)
        {
            if (callback.Result != EResult.OK)
            {
                this.SetText("Error connecting to Steam: " + callback.Result);
                isRunning = false;
            }
            else
            {

                this.SetText("Connected to Steam Network.");
                if (SteamAuthCode.Text != "")
                {
                    user.LogOn(new SteamUser.LogOnDetails
                    {
                        Username = SteamUserName.Text,
                        Password = SteamPassword.Text,
                        AuthCode = SteamAuthCode.Text
                    });
                }
                else
                {
                    user.LogOn(new SteamUser.LogOnDetails
                    {
                        Username = SteamUserName.Text,
                        Password = SteamPassword.Text
                    });
                }
            }
        }

        public void OnLoggedOn(SteamUser.LoggedOnCallback callback)
        {
            if (callback.Result == EResult.AccountLogonDenied)
            {
                this.SetText("This account is SteamGuard protected.");

            }
            else
            {
                if (callback.Result != EResult.OK)
                {
                    this.SetText("Unable to login to Steam " + callback.Result);
                }
                else
                {
                    this.SetText("successfully logged in as " + user);
                }
            }

            isRunning = false;
        }

        public void OnDisconnected(SteamClient.DisconnectedCallback callback)
        {
            this.SetText("Disconnected from Steam Network");
            isRunning = false;
        }

        public async Task Connect(string uri)
        {

            //connect to steam account

            client = new SteamClient();

            manager = new CallbackManager(client);

            user = client.GetHandler<SteamUser>();

            new Callback<SteamClient.ConnectedCallback>(OnConnected, manager);

            new Callback<SteamUser.LoggedOnCallback>(OnLoggedOn, manager);

            new Callback<SteamClient.DisconnectedCallback>(OnDisconnected, manager);

            client.Connect();

            isRunning = true;

            while (isRunning)
            {
                manager.RunWaitCallbacks(TimeSpan.FromSeconds(1));
            }

            //Override jpg for map.

            if (MapOverrrideBox.Checked)
            {
                MapImage.LoadAsync(MapOverRideUrlBox.Text);
            }
            else
            {
                MapImage.LoadAsync("http://" + ServerIPBox.Text + ":" + ServerPortBox.Text + "/map.jpg");
            }


            //connect to WS chat server
            try
            {
                webSocket = new ClientWebSocket();
                await webSocket.ConnectAsync(new Uri(uri), CancellationToken.None);
                await Task.WhenAll(Receive(webSocket), Send(webSocket, ""));
            }
            catch (Exception ex)
            {
                this.SetText("Error: " + ex.Message );
            }
            finally
            {
                if (webSocket != null)
                    webSocket.Dispose();

            }
        }

        public async Task Send(ClientWebSocket webSocket, string stringToSend)
        {
            
            while (webSocket.State == WebSocketState.Open)
            {
               
                Encoding econder = null;

                byte[] buffer = econder.GetBytes(stringToSend);
                await webSocket.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Binary, false, CancellationToken.None);
                this.SetText("In: " + stringToSend);
                
                await Task.Delay(1000);
            }
        }

        public async Task Receive(ClientWebSocket webSocket)
        {
            byte[] buffer = new byte[1024];
            string TempString = "";
            while (webSocket.State == WebSocketState.Open)
            {
                
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                if (result.MessageType == WebSocketMessageType.Close)
                {
                    await webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);

                }
                else
                {
                    TempString = Encoding.UTF8.GetString(buffer);
                    TempString = TempString.Remove(result.Count);
                    if (TempString.Substring(TempString.Length - 1, 1) == "}" || TempString == "hello")
                    {
                        DecodeServerPacket(TempString);
                        TempString = "";
                    }
 
                }
                
                
            }
        }
        public void GetStatusData(string IP, string Port)
        {
            var url = "http://"+IP+":"+Port+"/status.json";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var response = (HttpWebResponse)request.GetResponse();
            

            var encoding = ASCIIEncoding.ASCII;
            string responseText = "";
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
            {
                responseText = reader.ReadToEnd();
            }

            JavaScriptSerializer oJS = new JavaScriptSerializer();
            ServerClasses.StatusDataJson ServerStatus = new ServerClasses.StatusDataJson();
            ServerStatus = oJS.Deserialize<ServerClasses.StatusDataJson>(responseText);

            headerimage.LoadAsync(ServerStatus.headerimage);
            ServerUrl = ServerStatus.url;
            descriptionBox.AppendText(ServerStatus.description);
                
            this.Text = ServerStatus.hostname;
            
            StatusLabelServerInfo.Text = "CurrentTime: " + ServerStatus.env.time + "   Players: " + ServerStatus.players + " / " + ServerStatus.maxplayers + "  Sleepers: " + ServerStatus.sleepers + "   Level:" + ServerStatus.level + " World Size: " + ServerStatus.world.size + "   World Seed:" + ServerStatus.world.seed;


        }

        public void DecodeServerPacket(string Packet)
        {
            //hello
            //player.chat {"name":"ChaosCode","message":"I see u"}
            //
            if (Packet == "hello")
            {
                Send(webSocket, "hello");   
                //GetStatusData(ServerIPBox.Text, ServerPortBox.Text);
                UpdateTimer.Enabled = true;
                this.SetText("Connected" + Environment.NewLine);
            }
            else
            {
                string[] PacketArray = Packet.Split('{');
                string[] ServerObjectArray = PacketArray[0].Split('.');

                try
                {
                    JavaScriptSerializer json_serializer = new JavaScriptSerializer();
                    dynamic item = json_serializer.Deserialize<object>("{" + PacketArray[1]);
                    switch (ServerObjectArray[0])
                    {
                        case "player":
                            PlayerObject(ServerObjectArray, "{" + PacketArray[1]);
                            break;
                        case "p ":
                            //plane data
                            //need to convert to center cords. where center of image is 0,0
 
                            UpdatePlane(item["x"].ToString(), item["z"].ToString(), (int)item["id"]);
                            //PlaneIcon.Location = new Point(xi, yi);
                            //this.SetText("Plane Data: " + Packet + Environment.NewLine);

                            break;
                        default:
                            this.SetText("Unknown: " + Packet);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    this.SetText("Error: " + ex.Message);
                }

                
            }
            
        }

        public void UpdatePlane (string x, string y, int id)
        {
            ServerClasses.PlaneData CurrentPlane = PlaneDataArray.FirstOrDefault(n => n.id == id);
            if (CurrentPlane == null)
            {
               
                Double xd = Convert.ToDouble(x);
                Double yd = Convert.ToDouble(y);
                Double xr = xd * 0.05;
                Double yr = yd * 0.05;

                int xi = (int)(xr + (MapImage.Width / 2));
                int yi = (int)(yr + (MapImage.Height / 2));
                ServerClasses.PlaneData NewPlane = new ServerClasses.PlaneData();
                NewPlane.id = id;
                NewPlane.x = xi;
                NewPlane.y = yi;
                NewPlane.Image = PlaneIcon;
            }
            else
            {
                Double xd = Convert.ToDouble(x);
                Double yd = Convert.ToDouble(y);
                Double xr = xd * 0.05;
                Double yr = yd * 0.05;

                int xi = (int)(xr + (MapImage.Width / 2));
                int yi = (int)(yr + (MapImage.Height / 2));

                CurrentPlane.x = xi;
                CurrentPlane.y = yi;
            }
        }
        public void PlayerObject(string[] ServerObjectArray, string PacketData)
        {
            try
            {
                JavaScriptSerializer json_serializer = new JavaScriptSerializer();
                dynamic item = json_serializer.Deserialize<object>(PacketData);
                switch (ServerObjectArray[1].TrimEnd(' '))
                {
                    case "chat":
                        this.SetText(item["name"] + ": " + item["message"]);
                        break;
                    case "death":
                        this.SetText(item["name"] + " died from " + item["name"]);
                        break;
                    default:
                        this.SetText("Unknown: " + PacketData);
                        break;
                }
            }
            catch (Exception ex)
            {
                this.SetText("Error: " + ex.Message);
            }
                   
            
        }

        public void SetText(string text)
        {
            if (this.OutPut.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.OutPut.AppendText(text + Environment.NewLine);
                this.OutPut.SelectionStart = OutPut.Text.Length;
                this.OutPut.ScrollToCaret();
            }
        }

        private void SendTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        public void SendTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect("ws://" + ServerIPBox.Text + ":" + ServerPortBox.Text + "/ms");
            
        }

        private void headerimage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ServerUrl))
            {
                System.Diagnostics.Process.Start(ServerUrl);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (UpdateTimer.Interval == 1)
            {
                UpdateTimer.Interval = 60000;
            }
            GetStatusData(ServerIPBox.Text, ServerPortBox.Text);
        }

        private void tabPage2_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
