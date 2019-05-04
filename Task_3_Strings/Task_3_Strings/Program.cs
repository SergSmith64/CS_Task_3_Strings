using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ЗАДАНИЕ-3:
// Дана строка, вывести только те слова, которые встречаются в ней только один раз.

namespace Task_3_Strings_var3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> list_slov = new Dictionary<string, int>();
            int countSlov = 0;

            Console.WriteLine("Допустим мы вводим строку: ");
            //string str = Console.ReadLine();
            string str = "33 11 YYY 33 6666 11 6666 33 11 88";
            Console.WriteLine(str);

            //ПРЕОБРАЗОВЫВАЕМ
            string[] split = str.Split(new Char[] { ' ' });

            int x;
            // В ЗАДАНИИ НУЖНО НАЙТИ СЛОВА, ВСТРЕЧАЮЩИЕСЯ ОДИН РАЗ. ЗДЕСЬ МОЖНО ЗАДАТЬ ДРУГОЕ ЗНАЧЕНИЕ
            // int n = int.Parse(Console.ReadLine());
            int n = 1;
            Console.Write($"\nБудем искать слова которые встречаются {n} раз \n");


            for (int i = 0; i < split.Length; i++)
            {
                x = 0;
                for (int j = 0; j < split.Length; j++)
                {
                    // УБРАТЬ ВЫВОД
                    //Console.Write($"\n массив split[i] = {split[i]} ");
                    //Console.Write($"\n массив split[j] = {split[j]} ");

                    if (split[i] == split[j])
                    {
                        x++;
                    }
                }
                //Console.WriteLine("\n\n _____делаю вывод__ ");
                //Console.WriteLine($"\n x РАВНО = {x} , массив SPLIT = {split[i]} , n повторений задано = {n}");

                if (x == n)
                {
                    if (!list_slov.ContainsKey(split[i]))
                    {
                        countSlov = 0;
                        countSlov++;
                        list_slov.Add(split[i], countSlov);
                    }
                    else
                    {
                        countSlov = list_slov[split[i]];
                        countSlov++;
                        list_slov[split[i]] = countSlov;
                    }
                }
            }

            Console.WriteLine("\n\n__ВЫВОЖУ РЕЗУЛЬТАТ__ \n");
            foreach (var element in list_slov)
            {
                Console.WriteLine(element.Key);
            }
            Console.ReadLine();
        }
    }
}