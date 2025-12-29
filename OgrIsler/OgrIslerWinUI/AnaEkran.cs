using OgrIslerWinUI;
using OgrIslerWinUI.Bolumİsler;
using OgrIslerWinUI.Ogrenci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrIslerWinUI
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void kayıtlıÖğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListe ogrenciListe = new OgrenciListe();
            ogrenciListe.MdiParent = this;
            ogrenciListe.WindowState = FormWindowState.Maximized;
            ogrenciListe.Show();
        }

        private void AnaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.MdiParent = this;
            ogrenciEkle.WindowState = FormWindowState.Maximized;
            ogrenciEkle.Show();
        }

        private void sistemeKayıtlıBölümVeProgramlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BolumListe bolumliste = new BolumListe();
            bolumliste.MdiParent= this; 
            bolumliste.WindowState=FormWindowState.Maximized;
            bolumliste.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BolumEkle bolumEkle = new BolumEkle();
            bolumEkle.MdiParent = this;
            bolumEkle.WindowState = FormWindowState.Maximized;
            bolumEkle.Show();

        }
    }
}
