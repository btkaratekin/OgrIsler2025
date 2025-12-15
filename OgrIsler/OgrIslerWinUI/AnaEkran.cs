using OgrIslerWinUI;
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
            
        }

        private void AnaEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
