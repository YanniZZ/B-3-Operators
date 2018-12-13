using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
        public static void B3_P1_9_NumbersAddition()
        {
            int x, y, z;
            Console.WriteLine("Введите первое число: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
            Console.WriteLine("Сумма: " + z);
        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
            int x, y, z;
            int check;
            Console.Write("Введите первое число: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
            Console.Write("Введите предполагаемый ответ:");
            check = Convert.ToInt32(Console.ReadLine());
            if (check == z)
            {
                Console.WriteLine("Ответ верный!");
            }
            else
            {
                Console.WriteLine("Ответ неверный. Верный ответ:" + z);
            }
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
            int x, y, z;
            int check;
            Console.Write("Введите первое число: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = Convert.ToInt32(Console.ReadLine());
            z = x + y;
            do
            {
                Console.Write("Введите предполагаемый ответ:");
                check = Convert.ToInt32(Console.ReadLine());
                if (check != z)
                {
                    if (check < z)
                    {
                        Console.WriteLine("Введенное число меньше ответа. Попробуйте снова! ");
                    }
                    else
                    {
                        Console.WriteLine("Введенное число больше ответа. Попробуйте снова! ");
                    }
                }
                else
                {
                    Console.WriteLine("Ответ верный!");
                }
            } while (check != z);

        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
            int x, y, z;
            int check;
            char a = 'A';
            Console.Write("Введите первое число: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Складываем или вычитаем? ");
            a = Convert.ToChar(Console.ReadLine());
            z = a == '+' ? x + y : x - y;
            do
            {
                Console.Write("Введите предполагаемый ответ:");
                check = Convert.ToInt32(Console.ReadLine());
                if (check != z)
                {
                    if (check < z)
                    {
                        Console.WriteLine("Введенное число меньше ответа. Попробуйте снова! ");
                    }
                    else
                    {
                        Console.WriteLine("Введенное число больше ответа. Попробуйте снова! ");
                    }
                }
                else
                {
                    Console.WriteLine("Ответ верный!");
                }
            } while (check != z);
        }

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            int x, y, z;
            int check = 0;
            int i = 2;
            char a = ' ';
            Console.Write("Введите первое число: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Складываем или вычитаем? ");
            a = Convert.ToChar(Console.ReadLine());
            z = a == '+' ? x + y : x - y;
            Console.Write($"Введите предполагаемый ответ (у вас всего 3 попытки!): ");
            do
            {
                do
                {
                    check = Convert.ToInt32(Console.ReadLine());
                    if (check == z) break;
                        if (check < z)
                        {
                            Console.Write("Введенное число меньше ответа. Осталось попыток:" + i + "." + "Попробуйте снова: ");
                        }
                        else
                        {
                            Console.Write("Введенное число больше ответа. Осталось попыток:" +i+"."+"Попробуйте снова: ");
                        }

                    i--;
                } while (i == 0);
            } while (check!= z);
            Console.WriteLine("Ответ верный!");
            //if (i == 0) break;
            //Console.WriteLine("Вы привысили кол-во попыток! Верный ответ: " + z);
        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {

        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {

        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {

        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {

        }
    }
}
