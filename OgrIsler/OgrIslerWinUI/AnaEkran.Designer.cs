namespace OgrIslerWinUI
{
    partial class AnaEkran
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
            this.öğrenciİşleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derslerNotlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğrenciİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.bölümProgramİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.listelemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtlıÖğrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşleriToolStripMenuItem,
            this.dersToolStripMenuItem,
            this.derslerNotlarToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1175, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciİşleriToolStripMenuItem
            // 
            this.öğrenciİşleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öğrenciİşlemleriToolStripMenuItem,
            this.toolStripMenuItem1,
            this.bölümProgramİşlemleriToolStripMenuItem,
            this.toolStripMenuItem2,
            this.listelemelerToolStripMenuItem});
            this.öğrenciİşleriToolStripMenuItem.Name = "öğrenciİşleriToolStripMenuItem";
            this.öğrenciİşleriToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.öğrenciİşleriToolStripMenuItem.Text = "Öğrenci İşleri";
            // 
            // dersToolStripMenuItem
            // 
            this.dersToolStripMenuItem.Name = "dersToolStripMenuItem";
            this.dersToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.dersToolStripMenuItem.Text = "Danışman İşleri";
            // 
            // derslerNotlarToolStripMenuItem
            // 
            this.derslerNotlarToolStripMenuItem.Name = "derslerNotlarToolStripMenuItem";
            this.derslerNotlarToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.derslerNotlarToolStripMenuItem.Text = "Dersler && Notlar";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // öğrenciİşlemleriToolStripMenuItem
            // 
            this.öğrenciİşlemleriToolStripMenuItem.Name = "öğrenciİşlemleriToolStripMenuItem";
            this.öğrenciİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.öğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(215, 6);
            // 
            // bölümProgramİşlemleriToolStripMenuItem
            // 
            this.bölümProgramİşlemleriToolStripMenuItem.Name = "bölümProgramİşlemleriToolStripMenuItem";
            this.bölümProgramİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.bölümProgramİşlemleriToolStripMenuItem.Text = "Bölüm && Program İşlemleri";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(215, 6);
            // 
            // listelemelerToolStripMenuItem
            // 
            this.listelemelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtlıÖğrenciListesiToolStripMenuItem});
            this.listelemelerToolStripMenuItem.Name = "listelemelerToolStripMenuItem";
            this.listelemelerToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.listelemelerToolStripMenuItem.Text = "Listelemeler";
            // 
            // kayıtlıÖğrenciListesiToolStripMenuItem
            // 
            this.kayıtlıÖğrenciListesiToolStripMenuItem.Name = "kayıtlıÖğrenciListesiToolStripMenuItem";
            this.kayıtlıÖğrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.kayıtlıÖğrenciListesiToolStripMenuItem.Text = "Kayıtlı Öğrenci Listesi";
            this.kayıtlıÖğrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.kayıtlıÖğrenciListesiToolStripMenuItem_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 643);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaEkran";
            this.Text = "Öğrenci İşleri Otomasyonu Ver. 2025";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaEkran_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem öğrenciİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bölümProgramİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem listelemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtlıÖğrenciListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derslerNotlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
    }
}