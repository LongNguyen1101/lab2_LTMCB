namespace LAB2
{
    partial class Task2Form
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
            this.btnRead = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbFileName = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbLineCount = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.Label();
            this.lbWordsCount = new System.Windows.Forms.Label();
            this.lbCharacterCounts = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.txtWordsCount = new System.Windows.Forms.TextBox();
            this.txtCharacterCount = new System.Windows.Forms.TextBox();
            this.rtxtShow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(39, 48);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(600, 90);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read from file";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(39, 799);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(600, 90);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbFileName
            // 
            this.lbFileName.AutoSize = true;
            this.lbFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFileName.Location = new System.Drawing.Point(33, 219);
            this.lbFileName.Name = "lbFileName";
            this.lbFileName.Size = new System.Drawing.Size(148, 36);
            this.lbFileName.TabIndex = 2;
            this.lbFileName.Text = "File Name";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(33, 307);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(73, 36);
            this.lbSize.TabIndex = 3;
            this.lbSize.Text = "Size";
            // 
            // lbLineCount
            // 
            this.lbLineCount.AutoSize = true;
            this.lbLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLineCount.Location = new System.Drawing.Point(33, 488);
            this.lbLineCount.Name = "lbLineCount";
            this.lbLineCount.Size = new System.Drawing.Size(154, 36);
            this.lbLineCount.TabIndex = 4;
            this.lbLineCount.Text = "Line count";
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbURL.Location = new System.Drawing.Point(33, 395);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(76, 36);
            this.lbURL.TabIndex = 5;
            this.lbURL.Text = "URL";
            // 
            // lbWordsCount
            // 
            this.lbWordsCount.AutoSize = true;
            this.lbWordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWordsCount.Location = new System.Drawing.Point(33, 588);
            this.lbWordsCount.Name = "lbWordsCount";
            this.lbWordsCount.Size = new System.Drawing.Size(185, 36);
            this.lbWordsCount.TabIndex = 6;
            this.lbWordsCount.Text = "Words count";
            // 
            // lbCharacterCounts
            // 
            this.lbCharacterCounts.AutoSize = true;
            this.lbCharacterCounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCharacterCounts.Location = new System.Drawing.Point(33, 687);
            this.lbCharacterCounts.Name = "lbCharacterCounts";
            this.lbCharacterCounts.Size = new System.Drawing.Size(226, 36);
            this.lbCharacterCounts.TabIndex = 7;
            this.lbCharacterCounts.Text = "Character count";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(310, 214);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(329, 41);
            this.txtFileName.TabIndex = 8;
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(310, 302);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(329, 41);
            this.txtSize.TabIndex = 9;
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURL.Location = new System.Drawing.Point(310, 390);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(329, 41);
            this.txtURL.TabIndex = 10;
            // 
            // txtLineCount
            // 
            this.txtLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLineCount.Location = new System.Drawing.Point(310, 483);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.Size = new System.Drawing.Size(329, 41);
            this.txtLineCount.TabIndex = 11;
            // 
            // txtWordsCount
            // 
            this.txtWordsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWordsCount.Location = new System.Drawing.Point(310, 583);
            this.txtWordsCount.Name = "txtWordsCount";
            this.txtWordsCount.Size = new System.Drawing.Size(329, 41);
            this.txtWordsCount.TabIndex = 12;
            // 
            // txtCharacterCount
            // 
            this.txtCharacterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacterCount.Location = new System.Drawing.Point(310, 682);
            this.txtCharacterCount.Name = "txtCharacterCount";
            this.txtCharacterCount.Size = new System.Drawing.Size(329, 41);
            this.txtCharacterCount.TabIndex = 13;
            // 
            // rtxtShow
            // 
            this.rtxtShow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtxtShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtShow.Location = new System.Drawing.Point(689, 48);
            this.rtxtShow.Name = "rtxtShow";
            this.rtxtShow.Size = new System.Drawing.Size(1135, 841);
            this.rtxtShow.TabIndex = 14;
            this.rtxtShow.Text = "";
            // 
            // Task2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1858, 945);
            this.Controls.Add(this.rtxtShow);
            this.Controls.Add(this.txtCharacterCount);
            this.Controls.Add(this.txtWordsCount);
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lbCharacterCounts);
            this.Controls.Add(this.lbWordsCount);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.lbLineCount);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbFileName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRead);
            this.Name = "Task2Form";
            this.Text = "Task 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbFileName;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbLineCount;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Label lbWordsCount;
        private System.Windows.Forms.Label lbCharacterCounts;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtLineCount;
        private System.Windows.Forms.TextBox txtWordsCount;
        private System.Windows.Forms.TextBox txtCharacterCount;
        private System.Windows.Forms.RichTextBox rtxtShow;
    }
}