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
            if (op.KeyChar == 50 || op.KeyChar == 98) //выбирается клавиша 2 с клавиатуры или с нампада.
            {
                Example2();
                goto vibor;
            }
            if (op.KeyChar == 51 || op.KeyChar == 99) //выбирается клавиша 3 с клавиатуры или с нампада.
            {
                Example3();
                goto vibor;
            }
            if (op.KeyChar == 52 || op.KeyChar == 100) //выбирается клавиша 4 с клавиатуры или с нампада.
            {
                Example4();
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
            Console.WriteLine("Задание 1: Значения двух переменных меняются местами, без использования третьей переменной.");
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
        public static void Example2()
        {
            Console.Clear();
            Console.WriteLine("Задание 2: Задается натуральное трехзначное число (гарантируется, что трехзначное). Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.");
            Console.WriteLine("\nВведите трехзначное число и нажмите Enter");
            string Chislo = Console.ReadLine(); //Получаем строку число
            String a = Char.ToString(Chislo[0]); // Преобразуем каждый введенный символ в отдельную строку
            String b = Char.ToString(Chislo[1]);
            String c = Char.ToString(Chislo[2]);
            //int obchislo = int.Parse(c + b + a);
            Console.WriteLine("\nПеревернутое число получится: {0}", int.Parse(c + b + a)); // преобразуем в инт сумму строк
            Console.WriteLine("\n\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
            return;
        }
        public static void Example3()
        {
            Console.Clear();
            Console.WriteLine("Задание 3: Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.");
            Console.WriteLine("\nСудя по примерам в задании имеется ввиду именно острый угол между минутной стрелкой и часовой");
            Console.WriteLine("\nВведите число от 0 до 23 и нажмите Enter");
            bool f = Int32.TryParse(Console.ReadLine(), out int chas);
            if (f && chas >=0 && chas<=23)
            {
                int ugol = 0;
                if (chas >= 0 && chas < 12)
                {
                    if (chas >= 0 && chas <= 6)
                    {
                        ugol = chas * 30;
                    }
                    else
                    {
                        ugol = (12 - chas) * 30;
                    }
                }
                else
                {
                    if (chas >= 12 && chas <= 18)
                    {
                        ugol = (chas - 12) * 30;
                    }
                    else
                    {
                        ugol = (24 - chas) * 30;
                    }
                }
                Console.WriteLine("\nУгол в градусах между часовой и минутной стрелкой будет равен: {0}", ugol); 
            }
            else
            {
                Console.WriteLine("\nНеверный ввод, введите целое число от 0 до 23");
            }
            Console.WriteLine("\n\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
            return;
        }
        public static void Example4()
        {
            Console.Clear();
            Console.WriteLine("Задание 4: Найти количество чисел меньших N, которые имеют простые делители X или Y.");
            int N = Vvodint("Введите целое положительное число N и нажмите Enter");
            int X = Vvodint("Введите целое положительное число X и нажмите Enter");
            int Y = Vvodint("Введите целое положительное число Y и нажмите Enter");
            int a = N / X;
            int b = N / Y;
            int c = N / (X * Y);
            if (N == X)
            {
                a = 0;
            }
            if (N == Y)
            {
                b = 0;
            }
            Console.WriteLine("\n\nКоличество чисел кратных {0} или {1}, в диапазоне от 0 до {2} равно {3}", X, Y, N, a+b-c);
            Console.WriteLine("\n\nДля продолжения нажмите любую клавишу... ");
            Console.ReadKey();
            return;
        }
        /// <summary>
        /// Преобразует введенное число в INT, с обработкой ошибки преобразования и выводит перед вводом числа заданный текст
        /// </summary>
        /// <param name="text">Передаваемый текст, для выввода перед вводом числа</param>
        /// <returns></returns>
        public static int Vvodint(string text)
        {
            s:
            Console.WriteLine("\n{0}", text);
            bool f = Int32.TryParse(Console.ReadLine(), out int vvod);
            if (!f)
            {
                Console.WriteLine("\nНеверный ввод");
                goto s;
            }
            else
            {
                return vvod;
            }
        }

    }
}
