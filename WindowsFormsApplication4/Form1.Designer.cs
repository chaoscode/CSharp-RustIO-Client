namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabelServerInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.OutPut = new System.Windows.Forms.RichTextBox();
            this.MapImage = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SteamAuthCode = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SteamPassword = new System.Windows.Forms.RichTextBox();
            this.SteamUserName = new System.Windows.Forms.RichTextBox();
            this.MapOverrrideBox = new System.Windows.Forms.CheckBox();
            this.MapOverRideUrlBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.RichTextBox();
            this.headerimage = new System.Windows.Forms.PictureBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ServerPortBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServerIPBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerimage)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.statusStrip1);
            this.tabPage2.Controls.Add(this.OutPut);
            this.tabPage2.Controls.Add(this.MapImage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(913, 686);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Map";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.SizeChanged += new System.EventHandler(this.tabPage2_SizeChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelServerInfo});
            this.statusStrip1.Location = new System.Drawing.Point(3, 661);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(907, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabelServerInfo
            // 
            this.StatusLabelServerInfo.Name = "StatusLabelServerInfo";
            this.StatusLabelServerInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // OutPut
            // 
            this.OutPut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutPut.Location = new System.Drawing.Point(0, 533);
            this.OutPut.Name = "OutPut";
            this.OutPut.Size = new System.Drawing.Size(913, 125);
            this.OutPut.TabIndex = 15;
            this.OutPut.Text = "";
            // 
            // MapImage
            // 
            this.MapImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MapImage.Location = new System.Drawing.Point(198, 0);
            this.MapImage.Name = "MapImage";
            this.MapImage.Size = new System.Drawing.Size(535, 535);
            this.MapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapImage.TabIndex = 14;
            this.MapImage.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SteamAuthCode);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SteamPassword);
            this.tabPage1.Controls.Add(this.SteamUserName);
            this.tabPage1.Controls.Add(this.MapOverrrideBox);
            this.tabPage1.Controls.Add(this.MapOverRideUrlBox);
            this.tabPage1.Controls.Add(this.descriptionBox);
            this.tabPage1.Controls.Add(this.headerimage);
            this.tabPage1.Controls.Add(this.ConnectButton);
            this.tabPage1.Controls.Add(this.ServerPortBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.ServerIPBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(913, 686);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SteamAuthCode
            // 
            this.SteamAuthCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SteamAuthCode.Location = new System.Drawing.Point(78, 90);
            this.SteamAuthCode.Name = "SteamAuthCode";
            this.SteamAuthCode.Size = new System.Drawing.Size(123, 24);
            this.SteamAuthCode.TabIndex = 21;
            this.SteamAuthCode.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Steam Guard:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Steam Login:";
            // 
            // SteamPassword
            // 
            this.SteamPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SteamPassword.Location = new System.Drawing.Point(216, 60);
            this.SteamPassword.Name = "SteamPassword";
            this.SteamPassword.Size = new System.Drawing.Size(123, 24);
            this.SteamPassword.TabIndex = 18;
            this.SteamPassword.Text = "";
            // 
            // SteamUserName
            // 
            this.SteamUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SteamUserName.Location = new System.Drawing.Point(78, 60);
            this.SteamUserName.Name = "SteamUserName";
            this.SteamUserName.Size = new System.Drawing.Size(123, 24);
            this.SteamUserName.TabIndex = 17;
            this.SteamUserName.Text = "ch40sc0d3";
            this.SteamUserName.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // MapOverrrideBox
            // 
            this.MapOverrrideBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MapOverrrideBox.AutoSize = true;
            this.MapOverrrideBox.Location = new System.Drawing.Point(435, 9);
            this.MapOverrrideBox.Name = "MapOverrrideBox";
            this.MapOverrrideBox.Size = new System.Drawing.Size(98, 17);
            this.MapOverrrideBox.TabIndex = 16;
            this.MapOverrrideBox.Text = "Over Ride Map";
            this.MapOverrrideBox.UseVisualStyleBackColor = true;
            // 
            // MapOverRideUrlBox
            // 
            this.MapOverRideUrlBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MapOverRideUrlBox.Location = new System.Drawing.Point(539, 7);
            this.MapOverRideUrlBox.Name = "MapOverRideUrlBox";
            this.MapOverRideUrlBox.Size = new System.Drawing.Size(366, 20);
            this.MapOverRideUrlBox.TabIndex = 15;
            this.MapOverRideUrlBox.Text = "http://188.165.250.22/dl/rustfactions/rustfactions.jpg";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionBox.Location = new System.Drawing.Point(0, 306);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(913, 167);
            this.descriptionBox.TabIndex = 14;
            this.descriptionBox.Text = "";
            // 
            // headerimage
            // 
            this.headerimage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerimage.Location = new System.Drawing.Point(0, 120);
            this.headerimage.Name = "headerimage";
            this.headerimage.Size = new System.Drawing.Size(913, 180);
            this.headerimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headerimage.TabIndex = 13;
            this.headerimage.TabStop = false;
            this.headerimage.Click += new System.EventHandler(this.headerimage_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ConnectButton.Location = new System.Drawing.Point(325, 6);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 12;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Visible = false;
            // 
            // ServerPortBox
            // 
            this.ServerPortBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ServerPortBox.Location = new System.Drawing.Point(216, 12);
            this.ServerPortBox.Name = "ServerPortBox";
            this.ServerPortBox.Size = new System.Drawing.Size(80, 20);
            this.ServerPortBox.TabIndex = 10;
            this.ServerPortBox.Text = "28015";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Server Info:";
            // 
            // ServerIPBox
            // 
            this.ServerIPBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ServerIPBox.Location = new System.Drawing.Point(74, 12);
            this.ServerIPBox.Name = "ServerIPBox";
            this.ServerIPBox.Size = new System.Drawing.Size(123, 20);
            this.ServerIPBox.TabIndex = 7;
            this.ServerIPBox.Text = "Us.Rustfactions.Net";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(921, 712);
            this.tabControl1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Interval = 1;
            this.UpdateTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 740);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Not Connected";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapImage)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerimage)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox MapImage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.TextBox ServerPortBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerIPBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox OutPut;
        private System.Windows.Forms.PictureBox headerimage;
        private System.Windows.Forms.RichTextBox descriptionBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelServerInfo;
        private System.Windows.Forms.CheckBox MapOverrrideBox;
        private System.Windows.Forms.TextBox MapOverRideUrlBox;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.RichTextBox SteamUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox SteamPassword;
        private System.Windows.Forms.RichTextBox SteamAuthCode;
        private System.Windows.Forms.Label label4;

    }
}

