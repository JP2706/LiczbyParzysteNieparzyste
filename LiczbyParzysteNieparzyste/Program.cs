using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
           
                Console.WriteLine("Program sprawdzający czy liczba jest parzysta czy nieparzysta.");
                Console.Write("Podaj liczbę: ");
                var userNumber = GetNumber();

                if (userNumber % 2 == 0)
                {

                    Console.WriteLine("Liczba jest parzysta");

                }
                else
                {

                    Console.WriteLine("Liczba jest nieparzysta");

                }

                 Console.Write("Czy chcesz sprawidzić kolejną liczbę(jeśli nie to wpisz nie)?");
         
                if (Console.ReadLine() == "nie")
                    break;
                        
                

            }
        }

        private static int GetNumber()
        {
            while (true)
            {


                if (!int.TryParse(Console.ReadLine(), out int userNumber))
                {
                    Console.Write("Błędne dane\nPodaj liczbe jescze raz:");
                    continue;
                }

                return userNumber;
            }


        }
    }
}
