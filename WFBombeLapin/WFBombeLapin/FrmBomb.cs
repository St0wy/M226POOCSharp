using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBombeLapin
{
    public partial class FrmBomb : Form
    {
        //Fields
        Rebbit rabbit;

        //Constructors
        public FrmBomb()
        {
            InitializeComponent();
            rabbit = new Rebbit(300, 300, this);
            this.Paint += rabbit.Paint;
        }

        //Methods
        private void FrmBomb_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    rabbit.GoUp();
                    break;
                case Keys.Down:
                    rabbit.GoDown();
                    break;
                case Keys.Right:
                    rabbit.GoRight();
                    break;
                case Keys.Left:
                    rabbit.GoLeft();
                    break;
                case Keys.Space:
                    rabbit.PutBomb();
                    break;
                default:
                    break;
            }
        }

        private void tmrInvalidate_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
