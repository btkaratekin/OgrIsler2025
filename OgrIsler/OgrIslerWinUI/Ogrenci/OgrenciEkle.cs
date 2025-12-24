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

namespace OgrIslerWinUI.Ogrenci
{
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }
        OgrIslerDbEntities db = new OgrIslerDbEntities();
        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            var BolumListesi = db.Bolumler.ToList();
            comboBox1.DataSource = BolumListesi;
            comboBox1.DisplayMember = "BAdi";
            comboBox1.ValueMember = "BKodu";
            comboBox2.Enabled = false;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var ProgramListesi = db.Programlar.Where(p => p.BKodu == (int)comboBox1.SelectedValue).ToList();
            if (ProgramListesi.Count>0)
            {
                comboBox2.DataSource = ProgramListesi;
                comboBox2.DisplayMember = "PAdi";
                comboBox2.ValueMember = "PKodu";
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.DataSource = null;
                comboBox2.Enabled = false;
            }

            var DanismanListesi = db.Danismanlar.Where(d=>d.BKodu == (int)comboBox1.SelectedValue).Select(bd => new
            {
                DanismanKodu=bd.DKodu,
                DanismanAdiSoyadi=bd.DAdi+" "+bd.DSoyadi
            }).ToList();
            if (DanismanListesi.Count>0)
            {
                listBox1.DataSource = DanismanListesi;
                listBox1.DisplayMember = "DanismanAdiSoyadi";
                listBox1.ValueMember = "DanismanKodu";
                listBox1.Enabled = true;
            }
            else
            {
                listBox1.DataSource = null;
                listBox1.Enabled = false;
                
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string OgrenciNo = maskedTextBox1.Text;
            string TcKimlik=maskedTextBox2.Text;
            string Adi= maskedTextBox3.Text;
            string Soyadi = maskedTextBox4.Text;
            string Cinsiyet = radioButton1.Checked ? "E" : "K";
            DateTime DogumTarihi = dateTimePicker1.Value;
            /*-----------------------------------------------------*/
            string ProgramKodu=comboBox2.Enabled ? comboBox2.SelectedValue.ToString() : null;
            int DanismanKodu = listBox1.Enabled ? (int)listBox1.SelectedValue : 0;
            int Sinif =radioButton3.Checked ? 1:2;

            KisiselBilgi kisi = db.KisiselBilgiler.Where(k => k.OgrNo == OgrenciNo).FirstOrDefault();
            if (kisi!=null)
            {
                MessageBox.Show(OgrenciNo + " Öğrenci Numarası ile Daha Önce Bir Kayıt Eklenmiş Lütfen Kontrol Edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox1.Focus();
                maskedTextBox1.SelectAll();
            }
            else
            {
                KisiselBilgi YeniOgrenci = new KisiselBilgi()
                {
                    OgrNo = OgrenciNo,
                    Adi = Adi,
                    Soyadi = Soyadi,
                    Cinsiyet = Cinsiyet,
                    DTarih = DogumTarihi,
                    TcKimlik = TcKimlik,
                    Ogrenciler = new Models.Ogrenci()
                    {
                        OgrNo = OgrenciNo,
                        PKodu = ProgramKodu,
                        Sinif = Sinif,
                        DKodu = DanismanKodu
                    }

                };
                db.KisiselBilgiler.Add(YeniOgrenci);
                int ks = db.SaveChanges();
                if (ks>0)
                {
                    MessageBox.Show("Öğrenci Başarıyla Kaydedildi", "Öğrenci Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    maskedTextBox1.Focus();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
            maskedTextBox1.Focus();
        }
        void Temizle()
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox3.Clear();
            maskedTextBox4.Clear();
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = true;
            radioButton3.Checked = true;
            comboBox1.SelectedIndex = 0;
            listBox1.DataSource = null;
        }
    }
}
