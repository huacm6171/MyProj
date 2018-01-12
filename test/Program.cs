using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo(@"D:\vedio");
            foreach (FileInfo fi in di.GetFiles())
            {
                Console.Write(fi.Name+'\n');
            }

            return;
//                 
//             DirectoryInfo di = new  DirectoryInfo(strVideoDir);
//             foreach (FileInfo fi in di.GetFiles("*.flv"))
//             {
//                 ListViewItem item = new ListViewItem(fi.Name);
//                 item.SubItems.Add(fi.Name.Substring(9, 6));
//                 videoList.Items.Add(item);
//             }
        }
    }
}
