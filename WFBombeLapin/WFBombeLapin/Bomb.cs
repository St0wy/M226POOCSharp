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
    class Bomb
    {
        //Fields
        enum State {ignited, exploding, ded};

        readonly long x;
        readonly long y;
        readonly long timeToExplodeInMs;
        int currentState;
        Bitmap image;
        Stopwatch sw;

        //Properties
        public int CurrentState { get => currentState; set => currentState = value; }

        public long TimeUntilExplodeInPercent
        {
            get
            {
                if (sw.ElapsedMilliseconds >= timeToExplodeInMs)
                {
                    Explode();
                    return 100;
                }
                else
                {
                    return 100 * sw.ElapsedMilliseconds / timeToExplodeInMs;
                }
            }
        }

        //Constructors
        public Bomb() : this(10, 10, 3000)
        {

        }

        public Bomb(long x, long y, long timeToExplodeInMs)
        {
            this.x = x;
            this.y = y;
            this.timeToExplodeInMs = timeToExplodeInMs;
            this.CurrentState = (int)State.ignited;
            image = Properties.Resources.bomb1;
            sw = new Stopwatch();
            sw.Start();
        }

        //Methods
        public void Explode()
        {
            CurrentState = (int)State.exploding;
            sw.Restart();

        }

        public void Ignite()
        {
            CurrentState = (int)State.ignited;
            sw.Start();
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            if(CurrentState != (int)State.ded)
            {
                if (CurrentState == (int)State.ignited)
                {
                    if (this.TimeUntilExplodeInPercent <= 50)
                    {
                        image = Properties.Resources.bomb1;
                    }
                    else if (this.TimeUntilExplodeInPercent <= 100)
                    {
                        image = Properties.Resources.bomb2;
                    }
                }
                else if (CurrentState == (int)State.exploding)
                {
                    if (sw.ElapsedMilliseconds <= 125)
                    {
                        image = Properties.Resources.explosion1;
                    }
                    else if (sw.ElapsedMilliseconds <= 250)
                    {
                        image = Properties.Resources.explosion2;
                    }
                    else if (sw.ElapsedMilliseconds <= 375)
                    {
                        image = Properties.Resources.explosion3;
                    }
                    else if (sw.ElapsedMilliseconds <= 500)
                    {
                        image = Properties.Resources.explosion4;
                    }
                    else if (sw.ElapsedMilliseconds > 500)
                    {
                        CurrentState = (int)State.ded;
                    }
                }

                e.Graphics.DrawImage(image, x, y, 50, 50);
            }
        }
    }
}
