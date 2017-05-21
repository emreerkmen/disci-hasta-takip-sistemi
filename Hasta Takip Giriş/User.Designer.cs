namespace Hasta_Takip_Giriş
{
    partial class User
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
            this.görüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doktorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hastaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uygulamaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görüntüleToolStripMenuItem,
            this.findToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // görüntüleToolStripMenuItem
            // 
            this.görüntüleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem,
            this.hastaToolStripMenuItem,
            this.uygulamaToolStripMenuItem});
            this.görüntüleToolStripMenuItem.Name = "görüntüleToolStripMenuItem";
            this.görüntüleToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.görüntüleToolStripMenuItem.Text = "Show";
            // 
            // doktorToolStripMenuItem
            // 
            this.doktorToolStripMenuItem.Name = "doktorToolStripMenuItem";
            this.doktorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.doktorToolStripMenuItem.Text = "Doktor";
            this.doktorToolStripMenuItem.Click += new System.EventHandler(this.doktorToolStripMenuItem_Click);
            // 
            // hastaToolStripMenuItem
            // 
            this.hastaToolStripMenuItem.Name = "hastaToolStripMenuItem";
            this.hastaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.hastaToolStripMenuItem.Text = "Hasta";
            this.hastaToolStripMenuItem.Click += new System.EventHandler(this.hastaToolStripMenuItem_Click);
            // 
            // uygulamaToolStripMenuItem
            // 
            this.uygulamaToolStripMenuItem.Name = "uygulamaToolStripMenuItem";
            this.uygulamaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.uygulamaToolStripMenuItem.Text = "Uygulama";
            this.uygulamaToolStripMenuItem.Click += new System.EventHandler(this.uygulamaToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doktorToolStripMenuItem1,
            this.hastaToolStripMenuItem1,
            this.uygulamaToolStripMenuItem1});
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // doktorToolStripMenuItem1
            // 
            this.doktorToolStripMenuItem1.Name = "doktorToolStripMenuItem1";
            this.doktorToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.doktorToolStripMenuItem1.Text = "Doktor";
            this.doktorToolStripMenuItem1.Click += new System.EventHandler(this.doktorToolStripMenuItem1_Click);
            // 
            // hastaToolStripMenuItem1
            // 
            this.hastaToolStripMenuItem1.Name = "hastaToolStripMenuItem1";
            this.hastaToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.hastaToolStripMenuItem1.Text = "Hasta";
            this.hastaToolStripMenuItem1.Click += new System.EventHandler(this.hastaToolStripMenuItem1_Click);
            // 
            // uygulamaToolStripMenuItem1
            // 
            this.uygulamaToolStripMenuItem1.Name = "uygulamaToolStripMenuItem1";
            this.uygulamaToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.uygulamaToolStripMenuItem1.Text = "Uygulama";
            this.uygulamaToolStripMenuItem1.Click += new System.EventHandler(this.uygulamaToolStripMenuItem1_Click);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 409);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem görüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uygulamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doktorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hastaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uygulamaToolStripMenuItem1;
    }
}