using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_Deconstruction_
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Program.L9_P_EX_1();
            //Program.L9_P_EX_2();
            Console.ReadLine();
        }
        public struct Coordinates
        {
            public double x;
            public double y;
            public double z;

            public Coordinates(double x = 0.0, double y = 0.0, double z = 0.0)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public void Deconstruct(out double x, out double y, out double z)
            {
                x = this.x;
                y = this.y;
                z = this.z;
            }
        }

        static Coordinates coord = new Coordinates(10, 15, 20);

        public static void L9_P_EX_1()
        {
            var (x, y, z) = coord;
            double vector = Math.Sqrt(x * x + y * y + z * z);
            Console.WriteLine(vector);
        }



        public static void L9_P_EX_2()
        {
            DateTime date = new DateTime();
            var (_, _, _, hrs, min, sec) = date;
            Console.WriteLine($"{hrs} {min} {sec}");
        }

        public static void Deconstruct(this DateTime dateTime, out int year, out int month, out int day,
            out int hrs, out int min, out int sec)
        {
            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            day = DateTime.Now.Day;
            hrs = DateTime.Now.Hour;
            min = DateTime.Now.Minute;
            sec = DateTime.Now.Second;
        }

    }
}
