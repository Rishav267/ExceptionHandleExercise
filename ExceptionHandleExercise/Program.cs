using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            try
            {
                array[10] = 10;
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Please enter in valid index range");
            }
        }
    }
    
}
