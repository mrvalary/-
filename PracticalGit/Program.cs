using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сложение");
            Console.Write("Введите первое слогаемое: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе слагаемое: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a + b;
            Console.WriteLine("Сумма: "+c);
            Console.Write("Введите уменьшаемое: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вычитаемое: ");
            double e = Convert.ToDouble(Console.ReadLine());
            double f = d - e;
            Console.Write("Введите уменьшаемое: ");

            Console.WriteLine("Разность: " + f);
            Console.WriteLine("Разность: " + f);
            Console.Write("Введите уменьшаемое: ");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вычитаемое: ");
            double e = Convert.ToDouble(Console.ReadLine());
            double f = d - e;
            Console.WriteLine("Разность: " + f);
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();

        }
    }
}
