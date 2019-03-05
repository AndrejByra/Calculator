using System;
using System.IO;

namespace Calc
{
    class Calculator
    {

        private int a;
        private String b;
        private int c;
        


        public Calculator(int a, String b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        


        public void calc()
        {
            switch (b)
            {
                case "-":
                    Console.WriteLine(a - c);
                    break;
                case "+":
                    Console.WriteLine(a + c);
                    break;
                case "/":
                    check(a,c);
                    break;
                case "*":
                    Console.WriteLine(a * c);
                    break;


            }
        }
        public void check(int a, int c) {
            if (c == 0)
            {
                Exception zero = new Exception("nulov sa neda delit");
                
                string filePath = @"C:\skola\err.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    while (zero != null)
                    {
                        writer.WriteLine(zero.GetType().FullName);
                        writer.WriteLine("Message : " + zero.Message);
                       

                        zero = zero.InnerException;
                    }
                }
                throw zero;
            }
            else
            {
                Console.WriteLine( a / c);
            }
        }

}


        }






