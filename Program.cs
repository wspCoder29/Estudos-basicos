using System;

namespace Test60
{
    class Program
    {

        static int validador(int num)
        {
            if (num >= 1000 && num <= 9999)
            {
                return num;
            }
            return -1;
        }


        static void Main(string[] args)
        {
            bool control = false;
            int test = 0;
            int cont = 0;
            
            do
            {
                Console.Write("Indique num: ");
                test = int.Parse(Console.ReadLine());

                while (validador(test)==-1)
                {
                    Console.Write("Num entre 1000 e 9999: ");
                    test = int.Parse(Console.ReadLine());
                }

                for (int i = test; i <= 9999; i++)
                {
                    if (i % 2 == 0)
                    {
                        cont++;
                    }

                    if (i==9999)
                    {
                        control = true;
                    }
                }

            } while (control != true);

            Console.WriteLine("Total de pares entre {0} e 9999: {1} ",test, cont);

        }
    }
}
