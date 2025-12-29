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
    public partial class OgrenciListe : Form
    {
        public OgrenciListe()
        {
            InitializeComponent();
        }
        OgrIslerDbEntities db = new OgrIslerDbEntities();
        private void OgrenciListe_Load(object sender, EventArgs e)
        {

            var liste = db.Ogrenciler.Select(o => new { 
            OgrNo=o.OgrNo,
            AdiSoyadi=o.KisiselBilgiler.Adi+" "+o.KisiselBilgiler.Soyadi,
            Bolum=o.Programlar.Bolumler.BAdi,
            Program=o.Programlar.PAdi,
            Sinif=o.Sinif,
            DanismanBilgi=o.Danismanlar.DAdi+" "+o.Danismanlar.DSoyadi
            }).ToList();
            dataGridView1.DataSource= liste;
            dataGridView1.Refresh();
            label2.Text = liste.Count().ToString();

            List<Bolum> Bolumler = db.Bolumler.ToList();
            comboBox1.DataSource = Bolumler;
            comboBox1.DisplayMember = "Badi";
            comboBox1.ValueMember = "BKodu";
            
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            var liste = db.Ogrenciler.Select(o => new {
                OgrNo = o.OgrNo,
                AdiSoyadi = o.KisiselBilgiler.Adi + " " + o.KisiselBilgiler.Soyadi,
                Bolum = o.Programlar.Bolumler.BAdi,
                Program = o.Programlar.PAdi,
                Sinif = o.Sinif,
                DanismanBilgi = o.Danismanlar.DAdi + " " + o.Danismanlar.DSoyadi
            }).ToList();
            var yeniliste = liste.Where(o => o.OgrNo.StartsWith(maskedTextBox1.Text)).ToList();
            dataGridView1.DataSource = yeniliste;
            dataGridView1.Refresh();
            label2.Text = yeniliste.Count().ToString();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            var liste = db.Ogrenciler.Select(o => new {
                OgrNo = o.OgrNo,
                AdiSoyadi = o.KisiselBilgiler.Adi + " " + o.KisiselBilgiler.Soyadi,
                Bolum = o.Programlar.Bolumler.BAdi,
                Program = o.Programlar.PAdi,
                Sinif = o.Sinif,
                DanismanBilgi = o.Danismanlar.DAdi + " " + o.Danismanlar.DSoyadi
            }).ToList();
            var yeniliste = liste.Where(o => o.OgrNo.ToString().Contains(maskedTextBox2.Text)).ToList();
            dataGridView1.DataSource = yeniliste;
            dataGridView1.Refresh();
            label2.Text = yeniliste.Count().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox1.Focus();
        }

       
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue==null)
            {
                comboBox2.DataSource = null;
            }
            else
            {
                List<Models.Program> Programlar = db.Programlar.Where(p => p.BKodu == (int)comboBox1.SelectedValue).ToList();
                comboBox2.DataSource = Programlar;
                comboBox2.DisplayMember = "PAdi";
                comboBox2.ValueMember = "PKodu";

                var Danismanlar = db.Danismanlar.Where(d => d.BKodu == (int)comboBox1.SelectedValue).Select(bd => new
                {
                    DanismanKodu=bd.DKodu,
                    DanismanAdiSoyadi=bd.DAdi+" "+bd.DSoyadi
                }).ToList();
                listBox1.DataSource = Danismanlar;
                listBox1.DisplayMember = "DanismanAdiSoyadi";
                listBox1.ValueMember = "DanismanKodu";
            }
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var liste = db.Ogrenciler.Where(o=>o.Programlar.PKodu==comboBox2.SelectedValue.ToString()).Select(o => new {
                OgrNo = o.OgrNo,
                AdiSoyadi = o.KisiselBilgiler.Adi + " " + o.KisiselBilgiler.Soyadi,
                Bolum = o.Programlar.Bolumler.BAdi,
                Program = o.Programlar.PAdi,
                Sinif = o.Sinif,
                DanismanBilgi = o.Danismanlar.DAdi + " " + o.Danismanlar.DSoyadi
            }).ToList();
            
            dataGridView1.DataSource = liste;
            dataGridView1.Refresh();
            label2.Text = liste.Count().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var liste = db.Ogrenciler.Where(o => o.Danismanlar.DKodu == (int)listBox1.SelectedValue).Select(o => new {
                OgrNo = o.OgrNo,
                AdiSoyadi = o.KisiselBilgiler.Adi + " " + o.KisiselBilgiler.Soyadi,
                Bolum = o.Programlar.Bolumler.BAdi,
                Program = o.Programlar.PAdi,
                Sinif = o.Sinif,
                DanismanBilgi = o.Danismanlar.DAdi + " " + o.Danismanlar.DSoyadi
            }).ToList();

            dataGridView1.DataSource = liste;
            dataGridView1.Refresh();
            label2.Text = liste.Count().ToString();
        }
    }
}
