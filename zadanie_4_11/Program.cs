using System;

namespace zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            bool liczbaParzysta = false;
            try
            {
                Console.WriteLine("Podaj liczbę");
                do
                {
                    if (float.TryParse(Console.ReadLine(), out float wynik))
                    {
                        if (wynik % 2 == 0)
                        {
                            Console.WriteLine("Liczba parzysta");
                            liczbaParzysta = true;

                        }
                        else
                        {
                            Console.WriteLine("Liczba nieparzysta, podaj inna liczbę");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Podałeś niepoprawne dane. Spróbuj jeszcze raz");
                    }
                }

                while (!liczbaParzysta);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
