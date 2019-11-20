using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Square
    {
        private int height;
        private int width;

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    value = -value;
                }
                height = value;
            }
        }
        public int Width
        {

            get
            {
                return width;
            }
            set
            {
                if (value <= 0)
                {
                    value = -value;
                }
                width = value;
            }

        }

        public double Area()
        {
            return height * width;
        }
    }
}

