using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossplatformLab4
{
    internal class Lab1
    {
        public static void Main(string input , string output)
        {
            double s;
            double k1;
            double k2;
            double m;
            double x;
            double l1 = 0;
            double l2 = 0;
            double res1;
            double res2;
            double resk1;
            double resk2;
            string readText;
            string input2 = input;
            string output2 = output;
            using (StreamReader readtext = new StreamReader(input2))
            {
                readText = readtext.ReadLine();
            }
            string[] numlist = readText.Split(" ");

            s = Convert.ToDouble(numlist[0]);
            k1 = Convert.ToDouble(numlist[1]);
            k2 = Convert.ToDouble(numlist[2]);
            m = Convert.ToDouble(numlist[3]);
            double k3 = s - k1;
            double k4 = s - k2;


            x = (s - k1) + (s - k2) - 1;

            for (int l = 0; k3 <= x; k3 += 1)
            {

                l1 += (Factorial(x)) / (Factorial(k3) * Factorial(x - k3));

            }
            res1 = l1 / (Math.Pow(2, x));

            for (int l = 0; k4 <= x; k4 += 1)
            {

                l2 += (Factorial(x)) / (Factorial(k4) * Factorial(x - k4));

            }
            res2 = l1 / (Math.Pow(2, x));

            resk1 = res1 * m;
            resk2 = m - resk1;
            Console.WriteLine("result petya: " + resk1);
            Console.WriteLine("result vasia: " + resk2);
            using (StreamWriter writetext = new StreamWriter(output2))
            {
                writetext.WriteLine(resk1 + " " + resk2);
            }
            static double Factorial(double t)
            {
                if (t == 0)
                {
                    return 1;
                }
                else
                {
                    return t * Factorial(t - 1);
                }
            }
        }
    }
}
