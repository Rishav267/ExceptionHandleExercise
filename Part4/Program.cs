using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] array = new int[10];
                Console.WriteLine("enter the number");
                array[10] = int.Parse(Console.ReadLine());

                int fno, sno;
                Console.WriteLine("enter two number for division");
                fno = int.Parse(Console.ReadLine());
                sno = int.Parse(Console.ReadLine());

                Console.WriteLine(fno / sno);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
