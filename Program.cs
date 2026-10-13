using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program73
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите первое число: ");
            if (!double.TryParse(Console.ReadLine(), out double a)) { Console.WriteLine("Ошибка ввода."); return; }

            Console.Write("Введите второе число: ");
            if (!double.TryParse(Console.ReadLine(), out double b)) { Console.WriteLine("Ошибка ввода."); return; }

            Console.Write("Введите третье число: ");
            if (!double.TryParse(Console.ReadLine(), out double c)) { Console.WriteLine("Ошибка ввода."); return; }

            // Находим минимальное, среднее и максимальное
            double min, mid, max;

            if (a <= b && a <= c)
            {
                min = a;
                if (b <= c) { mid = b; max = c; }
                else { mid = c; max = b; }
            }
            else if (b <= a && b <= c)
            {
                min = b;
                if (a <= c) { mid = a; max = c; }
                else { mid = c; max = a; }
            }
            else // c — минимальное
            {
                min = c;
                if (a <= b) { mid = a; max = b; }
                else { mid = b; max = a; }
            }

            Console.WriteLine($"Числа по возрастанию: {min}, {mid}, {max}");
        }
    }
}