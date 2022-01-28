namespace B13_14
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brojKnjigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poKategorijamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poAutorimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.brojKnjigaToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.knjigeToolStripMenuItem,
            this.autoriToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            this.knjigeToolStripMenuItem.Click += new System.EventHandler(this.KnjigeToolStripMenuItem_Click);
            // 
            // autoriToolStripMenuItem
            // 
            this.autoriToolStripMenuItem.Name = "autoriToolStripMenuItem";
            this.autoriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoriToolStripMenuItem.Text = "Autori";
            // 
            // brojKnjigaToolStripMenuItem
            // 
            this.brojKnjigaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poKategorijamaToolStripMenuItem,
            this.poAutorimaToolStripMenuItem});
            this.brojKnjigaToolStripMenuItem.Name = "brojKnjigaToolStripMenuItem";
            this.brojKnjigaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.brojKnjigaToolStripMenuItem.Text = "Broj knjiga";
            // 
            // poKategorijamaToolStripMenuItem
            // 
            this.poKategorijamaToolStripMenuItem.Name = "poKategorijamaToolStripMenuItem";
            this.poKategorijamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poKategorijamaToolStripMenuItem.Text = "Po kategorijama";
            this.poKategorijamaToolStripMenuItem.Click += new System.EventHandler(this.PoKategorijamaToolStripMenuItem_Click);
            // 
            // poAutorimaToolStripMenuItem
            // 
            this.poAutorimaToolStripMenuItem.Name = "poAutorimaToolStripMenuItem";
            this.poAutorimaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.poAutorimaToolStripMenuItem.Text = "Po autorima";
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.IzlazToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brojKnjigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poKategorijamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poAutorimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

