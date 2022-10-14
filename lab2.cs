using System.Security.Cryptography.X509Certificates;


namespace crossplatformLab2
{

    class Program
    {

        static void Main(string[] args)
        {
            double x;
            double resk1;
            string readText;
            

            using (StreamReader readtext = new StreamReader("C:\\Users\\sofy2\\source\\repos\\crossplatformLab2\\crossplatformLab2\\Put1.txt"))
            {
                readText = readtext.ReadLine();
            }
            //string[] numlist = readText.Split(" ");

            //x = Convert.ToDouble(Console.ReadLine());
            //x = Convert.ToDouble(numlist[0]);
            x = Convert.ToDouble(readText);





            resk1 = Funk(x);
            
            Console.WriteLine("result: " + resk1);
            
            using (StreamWriter writetext = new StreamWriter("C:\\Users\\sofy2\\source\\repos\\crossplatformLab2\\crossplatformLab2\\Result1.txt"))
            {
                writetext.WriteLine(resk1);
            }


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
