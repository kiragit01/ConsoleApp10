using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.CursorVisible = false;
                Console.Title = "Шеленков Кирилл - Практикум 12";


                //1. Вычислить значение функции для целых аргументов двумя способами (1-й способ: полный условный оператор; 2-й способ: тернарная операция):

                Console.Write("x = ");
                int x = int.Parse(Console.ReadLine());
                double y = x > 0 ? Math.Pow(Math.Sin(x), 2) * x : 1 - 2 * Math.Sin(Math.Pow(x, 2));; // тернарный
                if (x > 0)                                                                           //Полный усл.
                    y = Math.Pow(Math.Sin(x), 2) * x;
                else
                    y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
                Console.WriteLine(y);


                //2. Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.

                Random random = new Random();
                int num = random.Next(10, 99);
                Console.Write(num);
                string even = (num % 2 == 0) ? " - чётное" : " - нечётное";
                Console.WriteLine(even);


                //3. Даны три целых положительных числа. Если все они четные, каждое число увеличить на 1;
                //если хотя бы одно из них четное, уменьшить на 1; если четных чисел нет, каждое число увеличить в 2 раза.

                Console.Write("a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                int b = int.Parse(Console.ReadLine());
                Console.Write("c = ");
                int c = int.Parse(Console.ReadLine());
                if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
                {
                    a++; b++; c++;
                }
                else if (a % 2 == 0 || b % 2 == 0 || c % 2 == 0)
                {
                    a--; b--; c--;
                }
                else
                {
                    a *= 2; 
                    b *= 2; 
                    c *= 2;
                }
                Console.WriteLine($"{a} \n{b} \n{c}");


                //4. По введенному номеру месяца выводится название поры года (зима, весна, лето, осень) и сообщение: сессия, каникулы, 1 семестр, 2 семестр
                Console.WriteLine("Введите номер месяца: ");
                int month = int.Parse(Console.ReadLine());
                switch (month)
                {
                    case 1:
                        Console.WriteLine("Зима. Каникулы, 2 семестр."); break;
                    case 2:
                        Console.WriteLine("Зима. 2 семестр."); break;
                    case 3: case 4: case 5:
                        Console.WriteLine("Весна. 2 семестр."); break;
                    case 6:
                        Console.WriteLine("Лето. Сессия. 2 семестр."); break;
                    case 7: case 8:
                        Console.WriteLine("Лето. Каникулы."); break;
                    case 9: case 10: case 11:
                        Console.WriteLine("Осень. 1 семестр."); break;
                    case 12:
                        Console.WriteLine("Зима. Сессия. 1 семестр."); break;
                }

            }
            catch(Exception ex) {
                Console.WriteLine($"Исключение: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
