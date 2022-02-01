namespace TaskManeger
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
            this.BtnStartPrc = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnEndTask = new System.Windows.Forms.Button();
            this.PrcList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStartPrc
            // 
            this.BtnStartPrc.Location = new System.Drawing.Point(316, 406);
            this.BtnStartPrc.Name = "BtnStartPrc";
            this.BtnStartPrc.Size = new System.Drawing.Size(75, 23);
            this.BtnStartPrc.TabIndex = 0;
            this.BtnStartPrc.Text = "Start Prc";
            this.BtnStartPrc.UseVisualStyleBackColor = true;
            this.BtnStartPrc.Click += new System.EventHandler(this.BtnStartPrc_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackListToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // blackListToolStripMenuItem
            // 
            this.blackListToolStripMenuItem.Name = "blackListToolStripMenuItem";
            this.blackListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blackListToolStripMenuItem.Text = "Black List";
            this.blackListToolStripMenuItem.Click += new System.EventHandler(this.blackListToolStripMenuItem_Click);
            // 
            // BtnEndTask
            // 
            this.BtnEndTask.Location = new System.Drawing.Point(397, 406);
            this.BtnEndTask.Name = "BtnEndTask";
            this.BtnEndTask.Size = new System.Drawing.Size(75, 23);
            this.BtnEndTask.TabIndex = 2;
            this.BtnEndTask.Text = "End Task";
            this.BtnEndTask.UseVisualStyleBackColor = true;
            this.BtnEndTask.Click += new System.EventHandler(this.BtnEndTask_Click);
            // 
            // PrcList
            // 
            this.PrcList.FormattingEnabled = true;
            this.PrcList.Location = new System.Drawing.Point(13, 28);
            this.PrcList.Name = "PrcList";
            this.PrcList.Size = new System.Drawing.Size(459, 368);
            this.PrcList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 441);
            this.Controls.Add(this.PrcList);
            this.Controls.Add(this.BtnEndTask);
            this.Controls.Add(this.BtnStartPrc);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(500, 480);
            this.MinimumSize = new System.Drawing.Size(500, 480);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartPrc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackListToolStripMenuItem;
        private System.Windows.Forms.Button BtnEndTask;
        private System.Windows.Forms.ListBox PrcList;
    }
}

