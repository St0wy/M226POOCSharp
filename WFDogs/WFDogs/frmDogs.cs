using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFDogs
{
    public partial class frmDogs : Form
    {
        Random rnd;
        Dog myDog;
        public frmDogs()
        {
            InitializeComponent();
            rnd = new Random();
            myDog = new Dog();
        }

        private void BtnCreateNewDog_Click(object sender, EventArgs e)
        {
            string dogName = tbxNameDog.Text;
            myDog = new Dog(dogName, rnd.Next(20, 201));

            tbxNameDog.Text = String.Empty;
            UpdateView();
        }

        private void UpdateView()
        {
            lblDogName.Text = $"Nom: {myDog.Name}";
            lblDogSize.Text = $"Taille: {myDog.Size}";
        }

        private void BtnBark_Click(object sender, EventArgs e)
        {
            lblBark.Text = myDog.Bark();
        }

        private void tbxNameDog_TextChanged(object sender, EventArgs e)
        {
            if (tbxNameDog.Text == String.Empty)
            {
                btnCreateNewDog.Enabled = false;
            }
            else
            {
                btnCreateNewDog.Enabled = true;
            }
        }
    }
}
