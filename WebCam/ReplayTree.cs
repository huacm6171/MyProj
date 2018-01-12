using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace WebCam
{
    public partial class ReplayTree : Form
    {
        private string strVideo;
        public ReplayTree()
        {
            InitializeComponent();
            XmlDocument xml = new XmlDocument();
            xml.Load(@"Config.xml");
            XmlElement root = xml.DocumentElement;
            strVideo = root.SelectSingleNode(@"/config/videopath").InnerText;
        }
        private void insertNote(string strPath, TreeNode tn)
        {
            DirectoryInfo di = new DirectoryInfo(strPath);
            DirectoryInfo[] dirs = di.GetDirectories();
            foreach (DirectoryInfo diNext in dirs)
            {
                if (diNext.Name == "." || diNext.Name == "..")
                    continue;

                TreeNode node = new TreeNode();
                node.Text = diNext.Name;
                tn.Nodes.Add(node);
                insertNote(strPath + "\\" + diNext.Name, node);
            }
            //添加当前目录下的文件
            foreach (FileInfo fi in di.GetFiles("*.flv"))
            {
                TreeNode filenode = new TreeNode();
                filenode.Text = fi.Name;
                tn.Nodes.Add(filenode);
            }
        }
        private void ReplayTree_Load(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////
//             videoList.Columns.Add("文件名", 100, HorizontalAlignment.Left);
//             videoList.Columns.Add("开始时间", 50, HorizontalAlignment.Left);
// 
//             DirectoryInfo di = new DirectoryInfo(strVideoDir);
//             foreach (FileInfo fi in di.GetFiles("*.flv"))
//             {
//                 ListViewItem item = new ListViewItem(fi.Name);
//                 item.SubItems.Add(fi.Name.Substring(9, 6));
//                 videoList.Items.Add(item);
//             }

            //////////////////////////////////////////////////////////
            DirectoryInfo di = new DirectoryInfo(strVideo);
            foreach (DirectoryInfo diNext in di.GetDirectories())
            {
                if (diNext.Name == "." || diNext.Name == "..")
                    continue;

                TreeNode node = new TreeNode();
                node.Text = diNext.Name;
                filesTree.Nodes.Add(node);
                insertNote(strVideo + "\\" + diNext.Name, node);
            }
        }

        private void filesTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode curNode = filesTree.SelectedNode;
            string strFilePath = curNode.Text;
            while (curNode.Parent != null)
            {
                strFilePath = curNode.Parent.Text + "\\" + strFilePath;
                curNode = curNode.Parent;
            }
            if (strVideo[strVideo.Length - 1] != '\\')
                strVideo += "\\";
            strFilePath = strVideo  +  strFilePath;

            int itemId = axVLCRT.playlist.add(@"file:///" + strFilePath);
            axVLCRT.playlist.playItem(itemId);
        }
    }
}
