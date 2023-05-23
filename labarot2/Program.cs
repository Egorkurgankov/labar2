using System;

namespace Conditional
{
    class SwitchCase
    {
        public static void Main(string[] args)
        {
            char op;
            double first, second;

            Console.Write("Введите первое число: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите оператор (+, -, *, /): ");
            op = (char)Console.Read();

            switch (op)
            {
                case '+':
                    Console.WriteLine(first + second);
                    break;

                case '-':
                    Console.WriteLine(first - second);
                    break;

                case '*':
                    zad3(first,second);
                    break;

                case '/':
                    Console.WriteLine(first / second);
                    break;

                default:
                    Console.WriteLine("Недопустимый оператор");
                    break;

            }
        }
        public static void zad3(double first, double second)
        {
            Console.WriteLine("Результат умножения: ");
            Console.WriteLine(first * second);
        }
    }
}