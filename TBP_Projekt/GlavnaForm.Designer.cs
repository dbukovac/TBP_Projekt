namespace TBP_Projekt
{
    partial class GlavnaForm
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
            this.robaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radniNalogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robaToolStripMenuItem,
            this.narudžbeToolStripMenuItem,
            this.proizvodToolStripMenuItem,
            this.radniNalogToolStripMenuItem,
            this.dobavljacToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // robaToolStripMenuItem
            // 
            this.robaToolStripMenuItem.Name = "robaToolStripMenuItem";
            this.robaToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.robaToolStripMenuItem.Text = "Roba";
            this.robaToolStripMenuItem.Click += new System.EventHandler(this.robaToolStripMenuItem_Click);
            // 
            // narudžbeToolStripMenuItem
            // 
            this.narudžbeToolStripMenuItem.Name = "narudžbeToolStripMenuItem";
            this.narudžbeToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.narudžbeToolStripMenuItem.Text = "Narudžbe";
            this.narudžbeToolStripMenuItem.Click += new System.EventHandler(this.narudžbeToolStripMenuItem_Click);
            // 
            // proizvodToolStripMenuItem
            // 
            this.proizvodToolStripMenuItem.Name = "proizvodToolStripMenuItem";
            this.proizvodToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.proizvodToolStripMenuItem.Text = "Proizvod";
            this.proizvodToolStripMenuItem.Click += new System.EventHandler(this.proizvodToolStripMenuItem_Click);
            // 
            // radniNalogToolStripMenuItem
            // 
            this.radniNalogToolStripMenuItem.Name = "radniNalogToolStripMenuItem";
            this.radniNalogToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.radniNalogToolStripMenuItem.Text = "Radni nalog";
            this.radniNalogToolStripMenuItem.Click += new System.EventHandler(this.radniNalogToolStripMenuItem_Click);
            // 
            // dobavljacToolStripMenuItem
            // 
            this.dobavljacToolStripMenuItem.Name = "dobavljacToolStripMenuItem";
            this.dobavljacToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.dobavljacToolStripMenuItem.Text = "Dobavljac";
            this.dobavljacToolStripMenuItem.Click += new System.EventHandler(this.dobavljacToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            this.korisniciToolStripMenuItem.Visible = false;
            this.korisniciToolStripMenuItem.Click += new System.EventHandler(this.korisniciToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // GlavnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "GlavnaForm";
            this.Text = "GlavnaForm";
            this.Load += new System.EventHandler(this.GlavnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radniNalogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljacToolStripMenuItem;
    }
}