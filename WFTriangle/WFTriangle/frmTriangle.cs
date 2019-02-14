using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFTriangle
{
    public partial class frmTriangle : Form
    {
        
        public frmTriangle()
        {
            InitializeComponent();
        }

        private void BtnInfoTriangle_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(tbxSideA.Text);
            int s2 = Convert.ToInt32(tbxSideB.Text);
            int s3 = Convert.ToInt32(tbxSideC.Text);
            Triangle triangle = new Triangle(s1, s2, s3);

            string result = "";
            result += $"This triangle is {triangle.Classify()}{Environment.NewLine}";
            result += $"Its perimeter is {triangle.GetPerimeter()}{Environment.NewLine}";
            result += $"Its area is {triangle.GetArea().ToString("0.##")}{Environment.NewLine}";

            tbxResult.Text = result;
        }
    }
}
