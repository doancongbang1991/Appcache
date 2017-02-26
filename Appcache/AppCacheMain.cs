using System;
using System.IO;
using System.Windows.Forms;

namespace Appcache
{
    public partial class AppCacheMain : Form
    {
        public AppCacheMain()
        {
            InitializeComponent();
        }
        //COnfig default value
        public static string strfilename = "";
        public static string thepath = "";
        public static string android_path = "android";
        public static string ios_path = "iosproj";
        public static string appcache_filename = "offline.appcache";
        //End of config

        private void bt_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Default folder
            openFileDialog.InitialDirectory = "D:\\";
            // Default filter
            openFileDialog.Filter = "HTML File (*.html)|*.html|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strfilename = openFileDialog.FileName;
                thepath = Path.GetDirectoryName(strfilename);
                tb_lnk.Text = strfilename;
                ListDirectory(treeview_open, thepath);
            }
        }
        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));

            return directoryNode;
        }

        private void bt_crt_Click(object sender, EventArgs e)
        {
            string[] filenames = Directory.GetFiles(thepath, "*", SearchOption.AllDirectories);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(thepath + @"\" + appcache_filename))
            {
                file.WriteLine(@"CACHE MANIFEST");
                foreach (string filename in filenames)
                {
                    string filename_tmp = filename.Remove(0, thepath.Length + 1);
                    string filename_tmpnew = filename_tmp.Replace(@"\", @"/");
                    string filename_tmpnew1 = filename_tmpnew.Replace(@" ", @"%20");
                    //remove android & ios subfoler source code from appcache
                    if (filename_tmpnew1.Contains(android_path + @"/") || filename_tmpnew1.Contains(ios_path + @"/"))
                        continue;
                    file.WriteLine(filename_tmpnew1);
                }
                file.WriteLine(@"FALLBACK:");
                //Default offline using html file
                file.WriteLine(@"/ /offline.html");
                file.WriteLine(@"NETWORK:");
                file.WriteLine(@"*");
            }
        }
    }
}
