using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Collections.Specialized.BitVector32;
using System.Diagnostics;

namespace student_data_from_a_text_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string filePath = "D:\\mphasis\\problem statement\\simply learn projects\\section 6 ,1.14/student_data.txt";

                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                Console.WriteLine("Rainbow School Students Data:");

                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
