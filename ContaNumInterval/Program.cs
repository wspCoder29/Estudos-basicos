using System;
using System.Collections.Generic;
using System.Linq;


namespace ContaNumIntervalo
{
    internal class Program
    {

        static int ini = 0;
        static int end = 0;
        static int search = 0;
        static List<int> li = new List<int>();

        static void Main(string[] args)
        {

            
            Input();

            li = GeraIntervalo(ini, end);

            ContaDentroVetor(li, search);
            


        }


        public static void Input()
        {
            Console.Write("Indique o início da sequência numérica: ");
            ini = int.Parse(Console.ReadLine());

            Console.Write("Indique o fim da sequência numérica: ");
            end = int.Parse(Console.ReadLine());

            while (end < ini)
            {
                Console.Write($"Fim da sequência > início | atual {end}: ");
                end = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Indique o número a ser contado: ");
            search = int.Parse(Console.ReadLine());
        }


        public static void ContaDentroVetor(List<int> input, int search)
        {
            int somaSearch = 0;

            for (int j = 0; j < input.Count; j++)
            {

                int test = input[j];

                string x = test.ToString();

                char[] c = x.ToCharArray();

                int[] v = new int[c.Length];

                for (int i = 0; i < v.Length; i++)
                {
                    v[i] = Int32.Parse(c[i].ToString());
                }

                int contSearch = v.Where(x => x == search).Count();
                somaSearch += contSearch;

            }

            if (somaSearch == 1)
            {
                Console.WriteLine($"O número {search} aparece {somaSearch} vez");

            }
            else
            {
                Console.WriteLine($"O número {search} aparece {somaSearch} vezes");
            }
        }


        public static List<int> GeraIntervalo(int ini, int end)
        {
            List<int> li = new List<int>();
            for (int i = ini; i <= end; i++)
            {
                li.Add(i);
            }
            Console.WriteLine(String.Join(' ', li));
            return li;
        }







    }
}
