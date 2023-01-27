
using System;
namespace Övning_5._3._1
{
    class program
    {
        static void Main(string[] args)
        {
            string[] frågor = { "Vem har störst?", "vem är the G.O.A.T?", "Är jag vit?", "what color is your...?" };
            string[] svar = { "Lionel Messi", "Messi", "Ja", "Bugatti" };
            bool start = true;

            while (start = true)
            {
                Console.WriteLine();
                Console.Write("Välj frågor mellan 1-4:");
                int val = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(frågor[val - 1]);
                string val2 = Console.ReadLine();

                if (val2 == svar[val - 1])
                {
                    Console.WriteLine("Rättt svar");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Fel svar");
                }

                Console.WriteLine("Vill du fortsätta y/n?");
                string fortsätta = Console.ReadLine();
                Console.WriteLine("Så du kallade mig snögubbe?!");
                if (fortsätta == "y")
                {

                }
                else
                {
                    break;
                }

            }
            start = false;
        }
    }
}