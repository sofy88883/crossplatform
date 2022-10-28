using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossplatformLab4
{
    internal class Lab2
    {
        public static void Main(string input , string output)
        {
            double x;
            double resk1;
            string readText;
            string input2 = input;
            string output2 = output;
            using (StreamReader readtext = new StreamReader(input2))
            {
                readText = readtext.ReadLine();
            }

            x = Convert.ToDouble(readText);

            resk1 = Funk(x);

            Console.WriteLine("result: " + resk1);

            using (StreamWriter writetext = new StreamWriter(output2))
            {
                writetext.WriteLine(resk1);
            }
            static double Funk(double t)
            {
                if (t == 0)
                {
                    return 1;
                }
                else if (t == 2)
                {
                    return 3;
                }
                else
                {
                    return 4 * Funk(t - 2) - Funk(t - 4);
                }
            }
        }
    }
}
