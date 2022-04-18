
/// Контрольная работа №2 РЕАЛИЗОВАТЬ МЕТОДЫ
/// Вариант 
/// Задача № 4
/// Автор (на русском): Румянцев Даниил
using static System.Console;
using static MyMath.MyFunc;

namespace task4
{ 
    class Task4
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i <= 99)
            {
            if (Task4(i) != 0) 
                {
                    WriteLine(Task4(i));
                }
                i++;
            }
            ReadKey();
        }
    }
}

