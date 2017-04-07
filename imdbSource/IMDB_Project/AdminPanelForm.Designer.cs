namespace IMDB_Project
{
    partial class AdminPanelForm
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
            this.filmEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmEkleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oyuncuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oyuncuEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmEkleToolStripMenuItem,
            this.oyuncuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmEkleToolStripMenuItem
            // 
            this.filmEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmEkleToolStripMenuItem1});
            this.filmEkleToolStripMenuItem.Name = "filmEkleToolStripMenuItem";
            this.filmEkleToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filmEkleToolStripMenuItem.Text = "Film";
            // 
            // filmEkleToolStripMenuItem1
            // 
            this.filmEkleToolStripMenuItem1.Name = "filmEkleToolStripMenuItem1";
            this.filmEkleToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.filmEkleToolStripMenuItem1.Text = "Film Ekle";
            this.filmEkleToolStripMenuItem1.Click += new System.EventHandler(this.filmEkleToolStripMenuItem1_Click);
            // 
            // oyuncuToolStripMenuItem
            // 
            this.oyuncuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyuncuEkleToolStripMenuItem});
            this.oyuncuToolStripMenuItem.Name = "oyuncuToolStripMenuItem";
            this.oyuncuToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.oyuncuToolStripMenuItem.Text = "Oyuncu";
            // 
            // oyuncuEkleToolStripMenuItem
            // 
            this.oyuncuEkleToolStripMenuItem.Name = "oyuncuEkleToolStripMenuItem";
            this.oyuncuEkleToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.oyuncuEkleToolStripMenuItem.Text = "Oyuncu Ekle";
            this.oyuncuEkleToolStripMenuItem.Click += new System.EventHandler(this.oyuncuEkleToolStripMenuItem_Click);
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 511);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanelForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmEkleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oyuncuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oyuncuEkleToolStripMenuItem;
    }
}