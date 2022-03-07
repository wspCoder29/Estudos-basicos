using System;
using System.Globalization;

namespace Test84_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Diferença entre duas datas: Dias, Horas, Minutos

            string dtInicial = "01/01/2021 11:00";
            DateTime dt = DateTime.ParseExact(dtInicial, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            string dtFinal = "01/02/2021 15:05";
            DateTime dt2 = DateTime.ParseExact(dtFinal, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            TimeSpan tp = dt2.Subtract(dt);

            Console.WriteLine("Entre as datas "+dtInicial+" e "+dtFinal);
            Console.WriteLine("Dias: "+tp.Days);
            Console.WriteLine("Horas: "+tp.Hours);
            Console.WriteLine("Minutos: "+tp.Minutes);
       

        }
    }
}
