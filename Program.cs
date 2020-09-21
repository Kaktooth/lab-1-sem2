using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTriangle
{
    class Program
    {
        protected static int ASide;
        protected static int BSide;
        protected static int CSide;

    
      public static int GetASide(int ASide)
        {
            return ASide;
        }
       public static void SetASide(int value)
        {
           ASide = value;
        }
        public static int GetBSide(int BSide)
        {
            return BSide;
        }
        public static void SetBSide(int value)
        {
            BSide = value;
        }
        public static int GetCSide(int CSide)
        {
            return CSide;
        }
        public static void SetCSide(int value)
        {
            CSide = value;
        }
        public static void Triangle(int ASideValue, int BSideValue, int CSideValue)
        {
            ASide = ASideValue;
            BSide = BSideValue;
            CSide = CSideValue;
            if (ASide + BSide > CSide && ASide  +CSide > BSide && BSide + CSide >ASide)
            {
                Console.WriteLine("Трикутник Існує");
               // a + b > c, a + c > b, b + c > a
            }
         else
            {
                Console.WriteLine("Трикутника не існує, тому значення сторін буде скинуто");
                ASide = 0;
                BSide = 0;
                CSide = 0;
            }
        }
        public static int PSum()
        {
            return ASide + BSide + CSide;
        }
        public static double Herons()
        {
            int s = PSum() / 2;
            return Math.Sqrt(s * (s - ASide) * (s - BSide) * (s - CSide));
        }
        static void Main(string[] args)
        {

            SetASide(3);

            SetCSide(20);
            Triangle(21,23,26);
            Console.WriteLine(GetASide(ASide) +" "+ GetCSide(CSide)+" "+PSum()+" "+Herons());
            Console.ReadLine();

        }
    }
}
