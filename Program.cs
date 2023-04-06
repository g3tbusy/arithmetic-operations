using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace арифметические_операции
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите значение a1: ");
            double a1 = double.Parse(Console.ReadLine());

            double result1 = Math.Pow(a, 3) - 3 * Math.Pow(a, 2) * b + 3 * a * Math.Pow(b, 2) - Math.Pow(b, 3);
            double result2 = Math.Pow(a, 3) + 3 * Math.Pow(a, 2) * b + 3 * a * Math.Pow(b, 2) + Math.Pow(b, 3);
            double result3 = (a + b) * (Math.Pow(a, 2) - a * b + Math.Pow(b, 2));
            double result4 = (a - b) * (Math.Pow(a, 2) + a * b + Math.Pow(b, 2));
            double result5 = (a - b) * (a + b);
            double result6 = Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2);
            double result7 = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
            double result8 = ((Math.Pow(a, 2) - 4 * b * c) / (a - a1 / 2 - a * c) - Math.Pow(a * b * c, 3)) / (Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2)); // на 4

            Console.WriteLine($"({a}+{b})^3={result1} при a={a}, b={b}");
            Console.WriteLine($"({a}+{b})^3={result2} при a={a}, b={b}");
            Console.WriteLine($"({a}+{b})({a}^2-{a}*{b}+{b}^2)={result3} при a={a}, b={b}");
            Console.WriteLine($"({a}-{b})({a}^2+{a}*{b}+{b}^2)={result4} при a={a}, b={b}");
            Console.WriteLine($"({a}-{b})({a}+{b})={result5} при a={a}, b={b}");
            Console.WriteLine($"({a}-{b})^2={result6} при a={a}, b={b}");
            Console.WriteLine($"({a}+{b})^2={result7} при a={a}, b={b}");
            Console.WriteLine($"(({a}^2-4*{b}*{c})/({a}-{a1}/2-{a}*{c})-({a}*{b}*{c})^3)/({a}^2-2*{a}*{b}+{b}^2)={result8} при a={a}, b={b}, c={c}"); // на 4
            Console.ReadKey();
        }
    }
}
