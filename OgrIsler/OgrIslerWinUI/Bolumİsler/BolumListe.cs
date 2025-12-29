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
    public partial class BolumListe : Form
    {
        public BolumListe()
        {
            InitializeComponent();
        }
        OgrIslerDbEntities db = new OgrIslerDbEntities();
        private void BolumListe_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Programlar.Select(bp => new
            {
                BKodu = bp.BKodu,
                BAdi = bp.Bolumler.BAdi,
                PKodu = bp.PKodu,
                PAdi = bp.PAdi
            }).OrderBy(p=>p.BKodu).ThenBy(p=>p.PKodu).ToList(); ;
        }
    }
}
