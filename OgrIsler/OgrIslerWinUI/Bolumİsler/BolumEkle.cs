using OgrIslerWinUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrIslerWinUI.Bolumİsler
{
    public partial class BolumEkle : Form
    {
        public BolumEkle()
        {
            InitializeComponent();
        }
        OgrIslerDbEntities db = new OgrIslerDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            var bolum = db.Bolumler.Where(b=>b.BAdi.ToUpper()== textBox1.Text.ToUpper()).FirstOrDefault();
            if (bolum!=null)
            {
                MessageBox.Show("Bu Bölüm Daha Önceden Eklenmiş", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.SelectAll();
            }
            else
            {
                               Bolum yeniBolum = new Bolum();
                yeniBolum.BAdi = textBox1.Text;
                db.Bolumler.Add(yeniBolum);
                db.SaveChanges();
                MessageBox.Show("Bölüm Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
