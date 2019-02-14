using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCuisine
{
    public partial class FrmCuisine : Form
    {
        public FrmCuisine()
        {
            InitializeComponent();
        }

        private void tmrInvalidate_Tick(object sender, EventArgs e)
        {
            //33 ticks for 30 FPS
            Invalidate();
        }
    }
}
