using System;
namespace lab3_sharp_GUI
{
    internal class Complex_number
    {
        private double x;
        private double y;

        public int pr = 1;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public Complex_number(double x, double y) //конструктор с параметрами
        {
            this.x = x;
            this.y = y;

            
        }
        
        public Complex_number()//конструктор без параметров
        {

        }

        public static Complex_number operator +(Complex_number a, Complex_number b)
        {
            return new Complex_number(a.x + b.x, a.y + b.y);
        }

      public override string ToString()
        {
            if (pr == 1)
                return $"{x} + {y}i";
            else return $"{Math.Sqrt(x*x + y*y)}(cos{Math.Atan(y/x)} + sin{Math.Atan(y/x)}i\n";
        }
    }
}
