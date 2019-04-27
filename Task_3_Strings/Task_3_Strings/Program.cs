using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВЕДИТЕ СТРОКУ");
            string stroka = Console.ReadLine();
            Console.WriteLine("Вы ввели - " + stroka);

            Console.WriteLine("ВВЕДИТЕ подстроку");
            string podstroka = Console.ReadLine();
            Console.WriteLine("Вы ввели - " + podstroka);

            // ПРОВЕРКА ДЛИНЫ
            if (stroka.Length < podstroka.Length)
                Console.WriteLine("строка на может быть меньше подстроки");

            else
            {
                if (stroka.Contains(podstroka))
                    Console.WriteLine("Строка {0} содержит подстроку {1}", stroka, podstroka);
                else
                    Console.WriteLine("Строка {0} НЕ содержит подстроку {1}", stroka, podstroka);
            }

            Console.ReadKey();
        }
    }
}
