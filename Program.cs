using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulearn___1_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решения заданий для семминара после первой лекции курса по программированию на сайте Ulearn.me");
            Console.WriteLine("Автор - Жихарев И.Д.");
            Console.WriteLine("Для продолжения нажмите любую клавишу");
            Console.ReadKey();
            Console.Clear();
            NomerZad();

        }
        /// <summary>
        /// Выбор задания 1-8
        /// </summary>
        public static void NomerZad()
        {
        vibor:
            Console.Clear();
            Console.WriteLine("Всего 8 заданий. \nЧтобы посмотреть решение конкретного задания - нажмите на клавиатуре соотвествующую цифру (1-8).  \nДля закрытия приложения нажмите на клавиатуре Esc");
        Key:
            ConsoleKeyInfo op;
            op = Console.ReadKey();
            if (op.KeyChar == 49 || op.KeyChar == 97) //выбирается клавиша 1 с клавиатуры или с нампада.
            {
                Example1();
                goto vibor;
            }
            if (op.KeyChar == 27) //выбирается клавиша ESC.
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Выбран не верный символ. Попробуйте снова."); //ожидание ввода нового символа.
                goto Key;
            }           
        }
        /// <summary>
        /// Первое задание
        /// </summary>
        public static void Example1()
        {
            Console.Clear();
            Console.WriteLine("Задание1: Значения двух переменных меняются местами, без использования третьей переменной.");
            Console.WriteLine("Введите первую переменную (А) и нажмите Enter");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную (В) и нажмите Enter");
            double b = Convert.ToDouble(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("\nПосле замены А={0}, B={1}", a, b);
            Console.WriteLine("Решение следующее: \na = a + b; \nb = a - b; \na = a - b;");
            Console.WriteLine("\n\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
            return;
        }
    }
}
