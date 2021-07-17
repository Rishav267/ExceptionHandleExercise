using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Part5
{
    class Program
    {
        static void Write(string filename, string message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(filename);
                sw.WriteLine(message);


            }
            catch (IOException ex)
            {

            }
            finally
            {
                sw.Close();
                Console.WriteLine("Finally block executed successfully");
            }

        }
        static void Main(string[] args)
        {
            Write("data.txt", "Good Morning!");
            
        }
    }

   
}
