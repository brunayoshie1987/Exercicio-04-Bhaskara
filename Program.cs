using System;

namespace Exercicio_4___Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- Baskara ----------------");
            //exemplo: a = 2, b = 3, c = - 15
            //https://www.matematica.pt/util/calculadora-equacao-2-grau.php

            Console.WriteLine("Informe o valor de A");

            var a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor de B");

            var b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor de C");

            var c = Convert.ToDouble(Console.ReadLine());

            var delta = b * b - (4 * a * c);

            var raizDelta = Math.Sqrt(delta);

            var s1 = (-(b) + raizDelta) / (2.0 * a);
            var s2 = (-(b) - raizDelta) / (2.0 * a);

            Console.WriteLine("S = {" + s1 + ", " + s2 + "}");

            Console.ReadKey();
        }
    }
}
