using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPlanets
{
    public partial class frmPlanets : Form
    {
        Planet p;
        int planetSize;
        string planetName;
        Color planetColor;
        public frmPlanets()
        {
            InitializeComponent();
            p = new Planet();
            planetSize = 0;
            planetName = "";
            planetColor = new Color();
        }

        private void FrmPlanets_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void BtnCreatePlanet_Click(object sender, EventArgs e)
        {
            planetSize = Convert.ToInt32(nudSize.Value);
            planetName = tbxName.Text;

            p = new Planet(planetSize, planetName, planetColor);
            UpdateView();
        }

        private void UpdateView()
        {
            lblPlanetName.Text = p.Name;
            lblPlanet.Font = new Font("Webdings", Convert.ToSingle(p.Size));
            lblPlanet.ForeColor = p.MyColor;
        }
    }
}
