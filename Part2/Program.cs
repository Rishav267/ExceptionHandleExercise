using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Part2
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
                Console.WriteLine("Please enter values within valid index");
                StackTrace st = new StackTrace();
                for(int i=0;i<st.FrameCount;i++)
                {
                    StackFrame sf = st.GetFrame(i);
                    Console.WriteLine("{0}", sf.GetMethod());
                    Console.WriteLine("{0}", sf.GetFileLineNumber());
                }
            }

        }
    }
}
