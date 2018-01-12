using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WebCam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //get livestream uri
            XmlDocument xml = new XmlDocument();
            xml.Load("Config.xml");
            XmlElement root = xml.DocumentElement;
            string strUri = root.SelectSingleNode(@"/config/liveuri").InnerText;
            axVLCPlayer.playlist.add(strUri);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = !btnStart.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
           
            axVLCPlayer.playlist.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = !btnStart.Enabled;
            btnStop.Enabled = !btnStop.Enabled;
            axVLCPlayer.playlist.stop();
        }

        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            axVLCPlayer.video.takeSnapshot();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = !btnStart.Enabled;
            axVLCPlayer.playlist.pause();
        }

        private void btnReplay_Click(object sender, EventArgs e)
        {
            ReplayTree WinReplay = new ReplayTree();
            WinReplay.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReplayTree WinReplayTree = new ReplayTree();
            WinReplayTree.Show();
        }
    }
}
