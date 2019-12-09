using System;

namespace Zahlenplateau.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxValue, randomNumber, counter = 0, maxCounter = 0, savedNumber = 0, savedIndex = 0;
            Random random = new Random();

            Console.WriteLine("Zahlenplateu");
            Console.Write("Bitte Obergrenze eingeben: ");
            maxValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zufallszahlenbereich: 1..");
            Console.WriteLine(maxValue);
 
            for(int i = 0; i < 100; i++)
            {    
                randomNumber = random.Next(1, maxValue + 1);
                
                if (i == 0)
                {
                    savedNumber = randomNumber;
                }
                else if(savedNumber == randomNumber)
                {
                    counter++;
                }
                else
                {
                    counter = 0;
                }

                Console.Write("{0}, ",randomNumber);
                
                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    savedNumber = randomNumber;
                    savedIndex = i;
                }
            }

            Console.WriteLine("\n");

            if (maxCounter == 0)
            {
                Console.WriteLine("Es wurde kein Plateau gefunden.");
            }
            else
            {
                Console.WriteLine("Längstes Plateau  : {0,3}", maxCounter);
                Console.WriteLine("Aufgebaut aus Zahl: {0,3}", savedNumber);
                Console.WriteLine("Endet an Stelle   : {0,3}", savedIndex + 1);
            }
        }
    }
}
