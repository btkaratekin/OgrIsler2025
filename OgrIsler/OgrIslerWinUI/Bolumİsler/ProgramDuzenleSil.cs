using OgrIslerWinUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrIslerWinUI.Bolumİsler
{
    public partial class ProgramDuzenleSil : Form
    {
        public ProgramDuzenleSil()
        {
            InitializeComponent();
        }
        OgrIslerDbEntities db = new OgrIslerDbEntities();
        Models.Program secilenProgram;
        private void ProgramDuzenleSil_Load(object sender, EventArgs e)
        {
            var bolumListe = db.Bolumler.ToList();
            comboBox1.DataSource = bolumListe;
            comboBox1.DisplayMember = "BAdi";
            comboBox1.ValueMember = "BKodu";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var programListe = db.Programlar.Where(p => p.BKodu == (int)comboBox1.SelectedValue).ToList();  
            comboBox2.DataSource = programListe;
            comboBox2.DisplayMember = "PAdi";
            comboBox2.ValueMember = "PKodu";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue!=null)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;   
                secilenProgram = db.Programlar.Where(p => p.PKodu == comboBox2.SelectedValue.ToString()).FirstOrDefault();
                maskedTextBox1.Text = secilenProgram.PKodu;
                maskedTextBox2.Text = secilenProgram.PAdi;
                var bolumListe= db.Bolumler.ToList();
                comboBox3.DataSource = bolumListe;
                comboBox3.DisplayMember = "BAdi";
                comboBox3.ValueMember = "BKodu";
                comboBox3.SelectedValue = secilenProgram.BKodu;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                DialogResult tus= MessageBox.Show("Yaptığınız Program Değişikliklerini Onaylıyor musunuz?", "Güncelleme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (tus==DialogResult.Yes)
                {
                    secilenProgram.PKodu = maskedTextBox1.Text;
                    secilenProgram.PAdi = maskedTextBox2.Text;
                    secilenProgram.BKodu = (int)comboBox3.SelectedValue;
                    db.Programlar.AddOrUpdate(secilenProgram);
                    db.SaveChanges();
                    Temizle();
                }
            }
        }
        void Temizle()
        {
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.DataSource = null;
            comboBox3.DataSource = null;
            comboBox1.SelectedIndex= -1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secilenProgram!=null)
            {
                DialogResult tus = MessageBox.Show("Seçilen Programı Programlardan Silmek İstiyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (tus==DialogResult.Yes)
                {
                    db.Programlar.Remove(secilenProgram);
                    db.SaveChanges();
                    Temizle();
                }
            }
        }
    }
}
