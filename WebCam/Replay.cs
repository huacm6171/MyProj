using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace WebCam
{
    public partial class Replay : Form
    {
        string strVideoDir;
        public Replay()
        {
            InitializeComponent();
//             DirectoryInfo di = new DirectoryInfo(@"D:\vedio");
//             foreach (FileInfo dFile in di.GetFiles("*.flv"))
//             {
//                // if (!videoList.Items.Contains(dFile.Name))
//                     videoList.Items.Add(dFile.Name);
//             }
            XmlDocument xml = new XmlDocument();
            xml.Load("Config.xml");
            XmlElement root = xml.DocumentElement;
            strVideoDir = root.SelectSingleNode(@"/config/videopath").InnerText;
        }

        private void videoList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Replay_Load(object sender, EventArgs e)
        {
            //load file
            videoList.Columns.Add("文件名", 100, HorizontalAlignment.Left);
            videoList.Columns.Add("开始时间", 50, HorizontalAlignment.Left);

            DirectoryInfo di = new  DirectoryInfo(strVideoDir);
            foreach (FileInfo fi in di.GetFiles("*.flv"))
            {
                ListViewItem item = new ListViewItem(fi.Name);
                item.SubItems.Add(fi.Name.Substring(9, 6));
                videoList.Items.Add(item);
            }
        }

        private void videoList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = videoList.SelectedItems[0];
            string strFileName = selectedItem.SubItems[0].Text;
            string strFilePath = @"file:///"+strVideoDir + strFileName;
            int iCurFile = axVLCReplay.playlist.add(strFilePath);
            axVLCReplay.playlist.playItem(iCurFile);

        }
    }
}
