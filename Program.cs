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
            if (op.KeyChar == 53 || op.KeyChar == 101) //выбирается клавиша 5 с клавиатуры или с нампада.
            {
                Example5();
                goto vibor;
            }
            if (op.KeyChar == 54 || op.KeyChar == 102) //выбирается клавиша 6 с клавиатуры или с нампада.
            {
                Example6();
                goto vibor;
            }
            if (op.KeyChar == 55 || op.KeyChar == 103) //выбирается клавиша 7 с клавиатуры или с нампада.
            {
                Example7();
                goto vibor;
            }
            if (op.KeyChar == 56 || op.KeyChar == 104) //выбирается клавиша 8 с клавиатуры или с нампада.
            {
                Example8();
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
        public static void Example5()
        {
            Console.Clear();
            Console.WriteLine("Задание 5: Найти количество високосных лет на отрезке [a, b] не используя циклы.");
            Console.WriteLine("данный алгоритм работает только с нашей эрой, поэтому вводите только положительные целые числа");
            int a = Vvodint("Введите число a и нажмите Enter");
            int b = Vvodint("Введите число и и нажмите Enter");
            //рассчет количества годов делящихся на 400
            double x2 = Convert.ToDouble(a) / 400;
            int x1 = Convert.ToInt32(Math.Ceiling (x2));
            int x = 1 - x1 + b/400 ;
            //рассчет количества годов делящихся на 100
            double y2 = Convert.ToDouble(a) / 100;
            int y1 = Convert.ToInt32(Math.Ceiling(y2));
            int y = 1 - y1 + b / 100;
            //рассчет количества годов делящихся на 4
            double z2 = Convert.ToDouble(a) / 4;
            int z1 = Convert.ToInt32(Math.Ceiling(z2));
            int z = 1 - z1 + b / 4;
            int q = z - y + x;
            Console.WriteLine("\n\nКоличесво високосных лет в интервале между {0} и {1} годами = {2}", a, b, q);
            Console.WriteLine("\n\nДля продолжения нажмите любую клавишу... ");
            Console.ReadKey();
            return;
        }
        /// <summary>
        /// Возвращает число типа double, преобразованное из введенной строки, с обработкой ощибки перевода
        /// </summary>
        /// <param name="text">Текст, выводимый на экран перед вводом</param>
        /// <returns></returns>
        public static double Vvoddouble(string text)
        {
        s:
            Console.WriteLine("\n{0}", text);
            bool f = Double.TryParse(Console.ReadLine(), out double vvod);
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
        public static void Example6()
        {
            Console.Clear();
            Console.WriteLine("Задание 6: Посчитать расстояние от точки до прямой, заданной двумя разными точками.");
            double x1 = Vvoddouble("Введите координату Х первой точки прямой и нажмите Enter");
            double y1 = Vvoddouble("Введите координату Y первой точки прямой и нажмите Enter");
            double x2 = Vvoddouble("Введите координату Х второй точки прямой и нажмите Enter");
            double y2 = Vvoddouble("Введите координату Y второй точки прямой и нажмите Enter");
            double x3 = Vvoddouble("Введите координату Х точки, от которой необходимо посчитать расстояние до прямой и нажмите Enter");
            double y3 = Vvoddouble("Введите координату Y точки, от которой необходимо посчитать расстояние до прямой и нажмите Enter");
            //Рассчет длин сторон треугольника, образуемого точками
            double a = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));
            double b = Math.Sqrt(Math.Pow(y2 - y3, 2) + Math.Pow(x2 - x3, 2));
            double c = Math.Sqrt(Math.Pow(y1 - y3, 2) + Math.Pow(x1 - x3, 2));
            double p = (a + b + c) / 2; //полупериметр треугольника
            double h = Math.Sqrt(p*(p-a)*(p-b)*(p-c)) * 2 / a; //рассчет высоты треугольника, она же и есть расстояние от точки до прямой
            Console.WriteLine("\n\nРасстояние от точки до прямой равно {0}", h);
            Console.WriteLine("\n\nДля продолжения нажмите любую клавишу... ");
            Console.ReadKey();
            return;
        }
        public static void Example7()
        {
            Console.Clear();
            Console.WriteLine("Задание 7: Найти вектор, параллельный прямой. Перпендикулярный прямой. Прямая задана коэффициентами уравнения прямой.");
            Console.WriteLine("\nПрямая L задана уравнением: Ax+By+C=0");
            double A = Vvoddouble("Введите коэффициент А уравнения прямой и нажмите Enter");
            double B = Vvoddouble("Введите коэффициент B уравнения прямой и нажмите Enter");
            double C = Vvoddouble("Введите коэффициент C уравнения прямой и нажмите Enter");
            Console.WriteLine("\n\nНаправляющий (параллельный) вектор - \u0100 прямой L будет следующим: ({0}, {1})", -B, A);
            Console.WriteLine("\nНормальный вектор (перпендикулярный) N прямой L будет следующим: ({0}, {1})", A, B);
            Console.WriteLine("\n\nДля продолжения нажмите любую клавишу... ");
            Console.ReadKey();
            return;
        }
        public static void Example8()
        {
            Console.Clear();
            Console.WriteLine("Задание 8: Дана прямая L и точка A. Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A. Можете считать, что прямая задана либо двумя точками, либо коэффициентами уравнения прямой — как вам удобнее.");
            Console.WriteLine("\nПрямая L задана уравнением: Ax+By+C=0");
            double A = Vvoddouble("Введите коэффициент А уравнения прямой и нажмите Enter");
            double B = Vvoddouble("Введите коэффициент B уравнения прямой и нажмите Enter");
            double C = Vvoddouble("Введите коэффициент C уравнения прямой и нажмите Enter");
            Console.WriteLine("\nТочка А задана двумя координатами.");
            double x1 = Vvoddouble("Введите координату Х точки A и нажмите Enter");
            double y1 = Vvoddouble("Введите координату Y точки A и нажмите Enter");
            //Рассчет координат по специально расчитанным формалам из математики
            double x = (B*B*x1-A*B*y1-C*A)/(A*A+B*B);
            double y = y1-B*x1/A+B*((B*B*x1-A*B*y1-C*A)/(A*A+B*B))/A;
            Console.WriteLine("\n\nКоординаты точки пересечения: {0} , {1}", x, y);
            Console.WriteLine("\n\nДля продолжения нажмите любую клавишу... ");
            Console.ReadKey();
            return;
        }
    }
}
