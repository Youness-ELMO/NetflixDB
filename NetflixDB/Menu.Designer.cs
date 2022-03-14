namespace NetflixDB
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serieToolStripMenuItem,
            this.serieToolStripMenuItem1,
            this.tpToolStripMenuItem});
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.genreToolStripMenuItem.Text = "Menu";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // serieToolStripMenuItem
            // 
            this.serieToolStripMenuItem.Name = "serieToolStripMenuItem";
            this.serieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serieToolStripMenuItem.Text = "Genre";
            this.serieToolStripMenuItem.Click += new System.EventHandler(this.serieToolStripMenuItem_Click);
            // 
            // serieToolStripMenuItem1
            // 
            this.serieToolStripMenuItem1.Name = "serieToolStripMenuItem1";
            this.serieToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.serieToolStripMenuItem1.Text = "Serie";
            this.serieToolStripMenuItem1.Click += new System.EventHandler(this.serieToolStripMenuItem1_Click);
            // 
            // tpToolStripMenuItem
            // 
            this.tpToolStripMenuItem.Name = "tpToolStripMenuItem";
            this.tpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tpToolStripMenuItem.Text = "Tp";
            this.tpToolStripMenuItem.Click += new System.EventHandler(this.tpToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tpToolStripMenuItem;
    }
}