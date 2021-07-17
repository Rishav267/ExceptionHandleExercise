using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
                    
            
                try
                {
                    //Console.WriteLine("Enter the element : ");
                    //for (int i=0;i<array.Length;i++)
                    //{
                    //    int num = int.Parse(Console.ReadLine());
                    //    array[i] = num;
                    //}
                    
                    int fno, sno;
                    Console.WriteLine("Enter two number for division ");
                    Console.WriteLine("enter first number : ");
                    fno = int.Parse(Console.ReadLine());

                    Console.WriteLine("enter the second number : ");
                    sno = int.Parse(Console.ReadLine());

                    double res = fno / sno;

                    Console.WriteLine($"the result of division is {res}");

                }
                catch(IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Index crosses the maximum size of 10");
                    Console.WriteLine("please keep data within the index range");
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine("Denominator can not be 0");
                }
                
        }
    }
}
