    class Program
    {
        static void Main(string[] args)
        {

            //Usando CultureInfo

            string prod1 = "Computador";
            string prod2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: ");
            Console.WriteLine("Computador, cujo preço é $ {0}",preco1.ToString("F2"));
            Console.WriteLine("{0}, cujo preço é $ {1}", prod2, preco2.ToString("F2"));
            Console.WriteLine("Registro: {0} anos de idade, código {1}, e gênero: {2}", idade, codigo, genero);

            Console.WriteLine("Medida com oito casas decimais: ", medida.ToString("F8"));
            Console.WriteLine("Arredondado (três casas deciamais): {0}", medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: {0}", medida.ToString(CultureInfo.InvariantCulture));
      




        }
    }