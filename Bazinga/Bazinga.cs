using System;
using System.Linq;


namespace Test86
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int qtd = -1;

            while (qtd < 0 || qtd > 100)
            {
                Console.Write("Indique a quantidade de jogadas: ");
                qtd = int.Parse(Console.ReadLine());
                if (qtd < 0 || qtd > 100)
                {
                    Console.WriteLine("Digite novamente");
                }
            }

            for (int i = 1; i <= qtd; i++)
            {

                Console.Write("Caso [#{0}]: ", i);
                string input = Console.ReadLine();

                if (Jogada(input))
                {
                    Console.WriteLine("Denovo");
                }
            }
        }


        public static bool Jogada(string input)
        {

            int t1 = 0;
            string p1 = ".";
            string p2 = "";
            p1 = input.Substring(0, input.IndexOf(" "));
            p2 = input.Substring(input.IndexOf(" ") + 1);

            if (p1 == p2)
            {
                return true;
            }
            else
            {
                if (p1 == "tesoura")
                {
                    if (p2 == "papel" || p2 == "lagarto")
                    {
                        t1++;
                    }
                }

                if (p1 == "papel")
                {
                    if (p2 == "pedra" || p2 == "spock")
                    {
                        t1++;
                    }
                }

                if (p1 == "pedra")
                {
                    if (p2 == "lagarto" || p2 == "tesoura")
                    {
                        t1++;
                    }
                }

                if (p1 == "lagarto")
                {
                    if (p2 == "spock" || p2 == "papel")
                    {
                        t1++;
                    }
                }

                if (p1 == "spock")
                {
                    if (p2 == "tesoura" || p2 == "pedra")
                    {
                        t1++;
                    }
                }

                if (t1 > 0)
                {
                    Console.WriteLine("Bazinga!");
                }
                else
                {
                    Console.WriteLine("Raj trapaceou!");
                }
            }
            return false;
        }
    }

        



}
