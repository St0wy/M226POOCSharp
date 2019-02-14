using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAnimal
{
    public partial class frmAnimal : Form
    {
        Random rnd;
        Animal myAnimal;
        public frmAnimal()
        {
            InitializeComponent();
            rnd = new Random();
            myAnimal = new Animal("toto", rnd.Next(10, 101));
        }

        private void FrmAnimal_Load(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            string name = tbxName.Text;
            myAnimal.Name = name;
            UpdateView();
        }

        private void UpdateView()
        {
            lblAnimalName.Text = $"L'animal dans ce projet s'appelle: {myAnimal.Name}";
            lblWeight.Text = $"Son poid est de: {myAnimal.Weight}";
        }
    }
}
