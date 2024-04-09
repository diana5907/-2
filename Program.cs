using System;
using System.Text;

namespace FunctionCalculation
{
    class Program
    {
        static void Main()
        {
            double a = 1.25;  // Початкове значення x
            double b = 6.75;  // Кінцеве значення x
            double dx = 0.25; // Крок зміни x

            Console.WriteLine("Результати обчислення функції y = √x * 4 на проміжку [{0}, {1}] з кроком {2}", a, b, dx);
            Console.WriteLine("x\t\t| y");
            Console.WriteLine("--------------------");

            // Початок оператора циклу з передумовою
            for (double x = a; x <= b; x += dx)
            {
                double y = Math.Sqrt(x) * 4; // Обчислення значення функції y = √x * 4
                y = Math.Round(y, 2); // Округлення значення до двох знаків після коми

                Console.WriteLine("{0}\t\t| {1}", Math.Round(x, 2), y); // Округлення x та виведення значень
            }
            // Кінець оператора циклу з передумовою

            Console.ReadLine(); // Чекаємо на натискання Enter перед завершенням програми
        }
    }
}
