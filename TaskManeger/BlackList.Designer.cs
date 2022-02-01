namespace TaskManeger
{
    partial class BlackList
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BlckList = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtBoxItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(316, 412);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BlckList
            // 
            this.BlckList.FormattingEnabled = true;
            this.BlckList.Location = new System.Drawing.Point(13, 34);
            this.BlckList.Name = "BlckList";
            this.BlckList.Size = new System.Drawing.Size(459, 368);
            this.BlckList.TabIndex = 7;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(397, 412);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtBoxItem
            // 
            this.TxtBoxItem.Location = new System.Drawing.Point(13, 414);
            this.TxtBoxItem.Name = "TxtBoxItem";
            this.TxtBoxItem.Size = new System.Drawing.Size(297, 20);
            this.TxtBoxItem.TabIndex = 8;
            // 
            // BlackList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 441);
            this.Controls.Add(this.TxtBoxItem);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BlckList);
            this.Controls.Add(this.BtnDelete);
            this.MaximumSize = new System.Drawing.Size(500, 480);
            this.MinimumSize = new System.Drawing.Size(500, 480);
            this.Name = "BlackList";
            this.Text = "BlackList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox BlckList;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtBoxItem;
    }
}