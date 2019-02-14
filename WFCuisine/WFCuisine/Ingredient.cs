using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCuisine
{
    class Ingredient
    {
        //Constants
        const int DEFAULT_POS_X = 0;
        const int DEFAULT_POS_Y = 0;
        const int DEFAULT_SIZE_X = 0;
        const int DEFAULT_SIZE_Y = 0;

        //Fields
        private int posX;
        private int posY;
        private int width;
        private int height;
        private Bitmap picture;

        //Properties

        //Constructors
        public Ingredient(int posX, int posY, int width, int height)
        {
            this.posX = posX;
            this.posY = posY;
            this.width = width;
            this.height = height;
        }

        public Ingredient() : this(DEFAULT_POS_X, DEFAULT_POS_Y, DEFAULT_SIZE_X, DEFAULT_SIZE_Y)
        {

        }

        public Ingredient(int posX, int posY) : this (posX, posY, DEFAULT_SIZE_X, DEFAULT_SIZE_Y)
        {
            
        }   

        //Methods

        public void Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(picture, posX, posY, width, height);
        }
    }
}
