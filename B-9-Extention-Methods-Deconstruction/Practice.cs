using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_Lesson_9.Extensions;


namespace Base_Lesson_9.Practice
{
    public static class Practice
    {
        /// <summary>
        /// L9-P-EX-1/2
        /// Создать структуру Coordinates (трехмерных). 
        /// Добавить экземплярный метод деконструкции значений координат.
        /// Вывести на консоль длину вектора по координатам.
        /// </summary>
        public static void L9_P_EX_1_from_2()
        {
            var coord1 = new Coordinates {a = 1, b = 2, c = 3 };
            var (_, _, _, result) = coord1;
            Console.WriteLine(result);
        }

        public struct Coordinates
        {
            public int a, b, c;
            public void Deconstruct(out int a, out int b, out int c, out double vector)
            {
                a = this.a;
                b = this.b;
                c = this.c;
                vector = Math.Sqrt(a^2 + b^2 + c^2);
            }
        }

        /// <summary>
        /// L9-P-EX-2/2. 
        /// Создать деконструктор для обьекта DateTime 
        /// (год, месяц, день, час, минуты, секунды). 
        /// Получить и вывести на консоль текущее время.
        /// Использовать пустые параметры.
        /// </summary>
        public static void L9_P_EX_2_from_2()
        {
            var tmpDateTime = DateTime.Now;

            var (_, _, _, h, min, sec) = tmpDateTime;
            Console.WriteLine($"Current time {h:d2}:{min:d2}:{sec:d2}");
        }
    }
}
