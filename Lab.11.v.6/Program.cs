using System;

namespace Lab
{
    class Program
    {
        static void Main()
        {
            double s = 0; // очищаем значение суммы
            int n = 1; // задаем начальное значение n
            double x = 1.7; // задаем значение для переменной
            double e = 0.001; // задаем необходимую точность
            do // начало цикла
            {
                x = (Math.Pow(x, 2 * n + 1) / (2 * n + 3)); // вычисление значения х
                s += x; // сумма членов ряда
                n++;
            }
            while (Math.Abs(x) > e); // выполнение цикла, пока выполняется условие
            Console.WriteLine($"Сумма членов ряда с заданной точностью = " + s);  //вывод результата на экран
            Console.ReadKey();
        }
    }
}