using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFBombeLapin
{
    class Rebbit
    {
        //Constants
        const int TIME_TILL_MOVE_IN_MS = 500;
        const int STATE_IMAGE_ONE = 0;
        const int STATE_IMAGE_TWO = 1;
        const int MOUVEMENT_SPEED = 20;

        //Fields
        int x;
        int y;
        int imageState;
        Form parentForm;
        Bitmap image;
        Stopwatch sw;

        //Properties
        public long TPercent
        {
            get
            {
                if (sw.ElapsedMilliseconds >= TIME_TILL_MOVE_IN_MS)
                {
                    return 100;
                }
                else
                {
                    return 100 * sw.ElapsedMilliseconds / TIME_TILL_MOVE_IN_MS;
                }
            }
        }

        //Constructors
        public Rebbit() : this(0, 0, new Form())
        {

        }

        public Rebbit(int x, int y, Form parentForm)
        {
            this.x = x;
            this.y = y;
            this.parentForm = parentForm;
            imageState = STATE_IMAGE_ONE;
            image = Properties.Resources.lapin1;
            sw = new Stopwatch();
            sw.Start();
        }

        //Methods
        public void GoUp()
        {
            y -= MOUVEMENT_SPEED;
        }

        public void GoDown()
        {
            y += MOUVEMENT_SPEED;
        }

        public void GoRight()
        {
            x += MOUVEMENT_SPEED;
        }

        public void GoLeft()
        {
            x -= MOUVEMENT_SPEED;
        }

        public void PutBomb()
        {
            Bomb b = new Bomb(x, y, 500);
            parentForm.Paint += b.Paint;
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, x, y, 100, 100);
            if(sw.ElapsedMilliseconds >= 500)
            {
                sw.Restart();
                if(imageState == STATE_IMAGE_ONE)
                {
                    image = Properties.Resources.lapin2;
                    imageState = STATE_IMAGE_TWO;
                }
                else if(imageState == STATE_IMAGE_TWO)
                {
                    image = Properties.Resources.lapin1;
                    imageState = STATE_IMAGE_ONE;
                }
            }
        }
    }
}
