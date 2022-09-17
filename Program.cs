using System;
using System.Numerics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {





            Rectangle rec = new Rectangle(4, 5);
            Console.WriteLine(rec.Area);
            double area = rec.Area;
            Console.WriteLine(area);


            Rectangle[] rectangles = new Rectangle[]
            {
                new Rectangle(3, 5),
                new Rectangle(24, 5),
                new Rectangle(3, 5),
                new Rectangle(5, 5),
                new Rectangle(34, 7),
                new Rectangle(3, 10),
                new Rectangle(45, 5),
                new Rectangle(11, 14),
            };


            foreach (Rectangle item in rectangles)
            {

                Console.WriteLine($"{item.Width} {item.Height}");
                Console.WriteLine(item.Area);

            }






            Worker[] peple = new Worker[]
            {

                new Worker("aa", "AaA", 64, 500, true),
                new Worker("b", "BbB", 23, 1700, true),
                new Worker("abo", "Abo", 40, 200, false),
                new Worker("aboba", "Amogus", 1000, 15000, true),
                new Worker("AAA", "BBB", 10, 100, false),
            };


            //foreach (Worker item in peple)
            //{
            //    Worker.ToString(item);

            //}

            foreach (Worker item in peple)
            {
                if (item.Age >= 18)
                {
                    Console.WriteLine("$ {peple.name}");
                }

            }



























        }
    }
}
