using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public class ServerClasses
    {
        public class PlayerChatPacketClass
        {
            public string name { get; set; }
            public string message { get; set; }
        }

        public class PlayerDeathPacket
        {
            public string id { get; set; }
            public string name { get; set; }
            public string lastDamage { get; set; }
        }

        public class World
        {
            public int size { get; set; }
            public int seed { get; set; }
        }

        public class Env
        {
            public double time { get; set; }
        }

        public class Version
        {
            public int network { get; set; }
            public int save { get; set; }
            public string io { get; set; }
        }

        public class StatusDataJson
        {
            public string hostname { get; set; }
            public string level { get; set; }
            public World world { get; set; }
            public Env env { get; set; }
            public int players { get; set; }
            public int maxplayers { get; set; }
            public int sleepers { get; set; }
            public string headerimage { get; set; }
            public string url { get; set; }
            public string description { get; set; }
            public Version version { get; set; }
        }

        public class DeathDataJson
        {
            public int x { get; set; }
            public int z { get; set; }
            public string cause { get; set; }
        }

        public class PlaneData
        {
            public int id { get; set; }
            public int x { get; set; }
            public int y { get; set; }
            public PictureBox Image { get; set; }
        }
    }
}
