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

namespace OgrIslerWinUI
{
    public partial class KullaniciGiris : Form
    {
        public KullaniciGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;
            string sifre = textBox2.Text;
            if ((string.IsNullOrEmpty(kadi))||(string.IsNullOrEmpty(sifre)))
            {
               MessageBox.Show("Kullanıcı Adı yada Şifre Boş Geçilemez.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
               using (OgrIslerDbEntities db = new OgrIslerDbEntities())
               {
                   Kullanici kullanici = db.Kullanicilar.Where(x => x.KullaniciAdi == kadi && x.Sifre == sifre).FirstOrDefault();
                   if (kullanici == null)
                   {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   else
                   {
                       MessageBox.Show($"Giriş Başarılı\nGiriş Yapan Kullanıcı: {kullanici.Adi} {kullanici.Soyadi}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AnaEkran anaEkran = new AnaEkran();
                        this.Hide();
                        anaEkran.ShowDialog();

                    }
                }
            }
        }
    }
}
