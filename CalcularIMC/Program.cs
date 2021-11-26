using System;

namespace CalcularIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado, altura, peso;
            Console.WriteLine("Calcular IMC");

            Console.WriteLine("Ingrese el peso de la persona");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura de la persona");
            altura = double.Parse(Console.ReadLine());
            resultado= peso /(altura * altura);
            Console.WriteLine("El resultado del IMC es:");
            if (resultado <16)
	            Console.WriteLine("Delgadez severa");
            if (resultado >=16 && resultado < 17 )
                Console.WriteLine("Delgadez moderada");
            if (resultado >=17 && resultado < 18.5)
                Console.WriteLine("Delgadez aceptable");
            if (resultado >=18.5 && resultado < 25 )
                Console.WriteLine("Sobrepeso");
            if (resultado >=25 && resultado < 30 )
                Console.WriteLine("Delgadez moderada");
            if (resultado >=30 && resultado < 35 )
                Console.WriteLine("Obesidad tipo I");
            if (resultado >=35 && resultado < 40 )
                Console.WriteLine("Obesidad tipo II");
            if (resultado >=40 && resultado <= 50 )
                Console.WriteLine("Obesidad tipo III o mórbida");
            if (resultado <50)
                Console.WriteLine("Obesidad tipo IV o extrema");
        }
    }
}
