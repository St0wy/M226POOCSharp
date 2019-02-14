using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAventuriers
{
    public partial class FrmAventuriers : Form
    {
        AdventurerGroup ap;
        public FrmAventuriers()
        {
            InitializeComponent();
            ap = new AdventurerGroup();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            ap = new AdventurerGroup();
            UpdateView();
        }

        private void BtnGameOver_Click(object sender, EventArgs e)
        {
            ap.GameOver();
            UpdateView();
        }

        private void UpdateView()
        {
            tbxWarrior.Text = ap.Warrior.Name;
            tbxArcher.Text = ap.Archer.Name;
            tbxMagician.Text = ap.Magician.Name;
            tbxPriest.Text = ap.Priest.Name;

            pgbArcher.Value = ap.Archer.Life;
            pgbWarrior.Value = ap.Warrior.Life;
            pgbPriest.Value = ap.Priest.Life;
            pgbMagician.Value = ap.Magician.Life;
        }
    }
}
