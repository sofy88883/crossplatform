
using System;
using crossplatformLab4;
using McMaster.Extensions.CommandLineUtils;

namespace lab4
{
    class Program
    {
        public static int Main(string[] args)
        {
            var app = new CommandLineApplication
            {
                Name = "lab4",
                Description = "Console app",
            };
            app.HelpOption(inherited: true);
            app.Command("labs", configCmd =>
            {
                configCmd.OnExecute(() =>
                {
                    Console.WriteLine("Specify a lab to execute");
                    return 1;
                });
                configCmd.Command("lab1", setCmd =>
                {

                    setCmd.Description = "execute lab1";                   
                    var input = setCmd.Option("--input", "input file", CommandOptionType.SingleValue);
                    var output = setCmd.Option("--output", "output file", CommandOptionType.SingleValue);                   
//lab1 --input "C:\\Users\\sofy2\\source\\repos\\crossplatformLab4\\crossplatformLab1\\get.txt" --output "C:\\Users\\sofy2\\source\\repos\\crossplatformLab4\\crossplatformLab1\\result.txt"
                    setCmd.OnExecute(() =>
                    {

                        Lab1.Main(input.Value(), output.Value());

                    });
                });

                configCmd.Command("lab2", setCmd =>
                {
                    
                    setCmd.Description = "execute lab2";
                    var input = setCmd.Option("--input","input file",CommandOptionType.SingleValue);
                    var output = setCmd.Option("--output", "output file", CommandOptionType.SingleValue);
//lab2 --input "C:\\Users\\sofy2\\source\\repos\\crossplatformLab4\\crossplatformLab2\\Put1.txt" --output "C:\\Users\\sofy2\\source\\repos\\crossplatformLab4\\crossplatformLab2\\Result1.txt"                
                    setCmd.OnExecute(() =>
                    {
                       
                        Lab2.Main(input.Value(), output.Value());

                    });
                });

                configCmd.Command("lab3", setCmd =>
                    {

                        setCmd.Description = "execute lab3";
                        var input = setCmd.Option("--input", "input file", CommandOptionType.SingleValue);
                        var output = setCmd.Option("--output", "output file", CommandOptionType.SingleValue);

//lab3 --input "C:\\Users\\sofy2\\source\\repos\\crossplatformLab4\\crossplatformLab3\\Put to lab 3.txt" --output "C:\\Users\\sofy2\\source\\repos\\crossplatformLab4\\crossplatformLab3\\Result to lab 3.txt"
                        setCmd.OnExecute(() =>
                        {
                            Lab3.Main(input.Value(), output.Value());

                        });
                    });
            });

            app.OnExecute(() =>
            {
                
               // app.ShowHelp();
                return 1;
            });

            return app.Execute(args);
        }
    }
}