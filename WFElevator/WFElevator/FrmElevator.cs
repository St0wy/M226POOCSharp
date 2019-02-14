using System;
using System.Windows.Forms;

namespace WFElevator
{
    public partial class FrmElevator : Form
    {
        Elevator elev;
        int lblSize;
        public FrmElevator()
        {
            InitializeComponent();
            elev = new Elevator();
            lblSize = this.Size.Height / elev.GetNbFloor();
        }

        private void FrmElevator_Load(object sender, EventArgs e)
        {

        }

        private void BtnCreateElevator_Click(object sender, EventArgs e)
        {
            if (tbxMaxFloor.Text.Length > 0 && tbxMinFloor.Text.Length > 0)
            {
                int maxFloor = Convert.ToInt32(tbxMaxFloor.Text);
                int minFloor = Convert.ToInt32(tbxMinFloor.Text);
                if (maxFloor > 0 && minFloor < 0)
                {
                    btnCreateElevator.Enabled = false;
                    elev.MaxFloor = maxFloor;
                    elev.MinFloor = minFloor;
                    GenerateLabel();
                }
            }
        }

        private void GenerateLabel()
        {

        }

        private void TbxMaxFloor_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                btnCreateElevator.Enabled = true;
            }
        }

        private void BtnElevatorUp_Click(object sender, EventArgs e)
        {
            elev.GoUp();
        }

        private void BtnElevatorDown_Click(object sender, EventArgs e)
        {
            elev.GoDown();
        }

        private void BtnAddPerson_Click(object sender, EventArgs e)
        {
            int nbPerson = Convert.ToInt32(nudPerson.Value);
            elev.NbPerson += nbPerson;
        }

        private void BtnRemovePerson_Click(object sender, EventArgs e)
        {
            int nbPerson = Convert.ToInt32(nudPerson.Value);
            elev.NbPerson -= nbPerson;
        }
    }
}