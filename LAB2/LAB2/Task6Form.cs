using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2
{
    public partial class Task6Form : Form
    {
        public Task6Form()
        {
            InitializeComponent();
            populateTreeView();
            pictureBoxShow.Visible = false;
            rtxtShowContent.ReadOnly = true;
        }

        private void populateTreeView()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady == true)
                {
                    DirectoryInfo infor = new DirectoryInfo(drive.Name);
                    if (infor.Exists)
                    {
                        TreeNode node = new TreeNode(infor.Name, 0, 1);
                        node.Tag = infor;
                        node.Text = $"{drive.VolumeLabel} {drive.Name}";
                        treeViewExplorer.Nodes.Add(node);
                        GetDirectories(infor, node);
                    }
                }
            }
        }

        private void GetDirectories(DirectoryInfo directory, TreeNode nodeToAddTo)
        {
            try
            {
                foreach (DirectoryInfo subDir in directory.GetDirectories())
                {
                    TreeNode subDirectory = new TreeNode(subDir.Name, 0, 1);
                    subDirectory.Tag = subDir;
                    GetDirectories(subDir, subDirectory);
                    nodeToAddTo.Nodes.Add(subDirectory);
                }
            }
            catch { }

            foreach (FileInfo file in directory.GetFiles())
            {
                TreeNode fileNode = new TreeNode(file.Name, 2, 2);
                fileNode.Tag = file;
                nodeToAddTo.Nodes.Add(fileNode);
            }
        }

        private bool isImageFile(FileInfo file)
        {
            string[] imageExtensions = {".jpg", ".jpeg", ".png", ".bmp", ".gif" };
            return imageExtensions.Contains(file.Extension.ToLower());
        }

        private bool isTxtFile(FileInfo file)
        {
            return file.Extension == ".txt";
        }

        private void treeViewExplorer_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag is FileInfo)
            {
                FileInfo fileinfor = (FileInfo)e.Node.Tag;

                try
                {
                    if (isImageFile(fileinfor))
                    {
                        pictureBoxShow.Visible = true;
                        pictureBoxShow.Image = Image.FromFile(fileinfor.FullName);
                    }
                    else
                    {
                        if (isTxtFile(fileinfor))
                        {
                            pictureBoxShow.Visible = false;
                            string[] content = File.ReadAllLines(fileinfor.FullName);
                            rtxtShowContent.Clear();
                            foreach (string contentItem in content)
                                rtxtShowContent.Text += contentItem + Environment.NewLine;
                        }
                        else
                        {
                            MessageBox.Show("Cannot read this file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
