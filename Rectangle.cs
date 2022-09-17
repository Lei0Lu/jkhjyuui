using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Rectangle
    {

        public double Width { get; set; }
        public double Height { get; set; }

        public double Area
        {
            get
            {
                Console.WriteLine("Get area");
                return Width * Height;
            }



        }





        public Rectangle(double wingth, double height)
        {

            Width = wingth;

            Height = height;
        }

       






    }
}
