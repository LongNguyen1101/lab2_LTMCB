namespace LAB2
{
    partial class Task6Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task6Form));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeViewExplorer = new System.Windows.Forms.TreeView();
            this.imgFolder_Document = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.rtxtShowContent = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeViewExplorer);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pictureBoxShow);
            this.splitContainer.Panel2.Controls.Add(this.rtxtShowContent);
            this.splitContainer.Size = new System.Drawing.Size(1634, 982);
            this.splitContainer.SplitterDistance = 544;
            this.splitContainer.TabIndex = 0;
            // 
            // treeViewExplorer
            // 
            this.treeViewExplorer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeViewExplorer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewExplorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewExplorer.ImageIndex = 0;
            this.treeViewExplorer.ImageList = this.imgFolder_Document;
            this.treeViewExplorer.Location = new System.Drawing.Point(0, 0);
            this.treeViewExplorer.Name = "treeViewExplorer";
            this.treeViewExplorer.SelectedImageIndex = 0;
            this.treeViewExplorer.Size = new System.Drawing.Size(544, 982);
            this.treeViewExplorer.TabIndex = 0;
            this.treeViewExplorer.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewExplorer_NodeMouseDoubleClick);
            // 
            // imgFolder_Document
            // 
            this.imgFolder_Document.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgFolder_Document.ImageStream")));
            this.imgFolder_Document.TransparentColor = System.Drawing.Color.Transparent;
            this.imgFolder_Document.Images.SetKeyName(0, "folder.png");
            this.imgFolder_Document.Images.SetKeyName(1, "open-folder.png");
            this.imgFolder_Document.Images.SetKeyName(2, "document.png");
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBoxShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxShow.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(1086, 982);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxShow.TabIndex = 1;
            this.pictureBoxShow.TabStop = false;
            // 
            // rtxtShowContent
            // 
            this.rtxtShowContent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtxtShowContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtShowContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtShowContent.Location = new System.Drawing.Point(0, 0);
            this.rtxtShowContent.Name = "rtxtShowContent";
            this.rtxtShowContent.Size = new System.Drawing.Size(1086, 982);
            this.rtxtShowContent.TabIndex = 2;
            this.rtxtShowContent.Text = "";
            // 
            // Task6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 982);
            this.Controls.Add(this.splitContainer);
            this.Name = "Task6Form";
            this.Text = "Task 6";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.TreeView treeViewExplorer;
        private System.Windows.Forms.ImageList imgFolder_Document;
        private System.Windows.Forms.PictureBox pictureBoxShow;
        private System.Windows.Forms.RichTextBox rtxtShowContent;
    }
}