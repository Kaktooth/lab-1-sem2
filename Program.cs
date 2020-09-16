using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of n");
            int n = int.Parse(Console.ReadLine());

            int[,] matrixX = new int[n, n];
            int[,] matrixY = new int[n, n];
            int[,] numarray = new int[n, n];
            int[,] sortedarray = new int[n, n];
            int savednum = 0;
            int savedarray = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    matrixX[i, j] = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine("matrix X");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write(matrixX[i, j]);

                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrixY[i, j] = matrixX[j, i];
                    Console.Write(matrixX[j, i]);


                }
                Console.WriteLine();
            }
            Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    numarray[i, j] = matrixY[n - i - 1, j];



                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write(numarray[i, j]);


                }
                Console.WriteLine();
            }
            Console.ReadLine();
            //clearing array
            for (int i = 0; i < n; i++)
            {
                
                    if (numarray[i, 0] == 0)
                    {
                        Array.Clear(numarray, i, n);
                       
                        Console.WriteLine("Index " + i + " cleared");
                    }

                    if (numarray[i, 0] >= savednum)
                    {
                        savednum = numarray[i, 0];
                      
                            for (int j = 0; j < n; j++)
                            {

                                sortedarray[i, j] = numarray[i, j];
                            }
                        

                    }


                

            }
            Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                
                if (numarray[i, 0] < savednum)
                {


                }

            }

        }
    }
}
