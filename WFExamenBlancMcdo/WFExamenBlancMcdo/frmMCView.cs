/**
 * WFExamenBlancMcdo
 * Fabian Huber
 * 07.03.219
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFExamenBlancMcdo
{
    public partial class frmMCView : Form
    {
        //Fields
        MCModel model;

        //Properties
        private MCModel Model { get => model; set => model = value; }

        //Constructors
        public frmMCView()
        {
            InitializeComponent();
            Model = new MCModel();
        }

        //Methods
        /// <summary>
        /// Updates the view with the good items and good amount of calories.
        /// </summary>
        private void UpdateView()
        {
            int idMainCourse = cbxMainCourse.SelectedIndex;
            int idSideOrder = cbxSideOrder.SelectedIndex;
            int idDrink = cbxDrink.SelectedIndex;
            int totalCal = Model.GetCalories(idMainCourse, idSideOrder, idDrink);
            lblMealKCal.Text = Model.ToString();
            lblTotalKCal.Text = totalCal.ToString();
        }

        private void FrmMCView_Load(object sender, EventArgs e)
        {
            foreach (Meal meal in Model.MainCourses)
            {
                cbxMainCourse.Items.Add(meal);
            }
            foreach (Meal meal in Model.SideOrders)
            {
                cbxSideOrder.Items.Add(meal);
            }
            foreach (Meal meal in Model.Drinks)
            {
                cbxDrink.Items.Add(meal);
            }

        }

        private void BtnCalculateFat_Click(object sender, EventArgs e)
        {
            UpdateView();
        }
    }
}
