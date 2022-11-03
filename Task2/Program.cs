using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*2.    Обязательная задача*. Программно создайте текстовый файл и запишите в него 10 случайных чисел.
             * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
            */
            string path = "Log.txt";
            
            Random random = new Random();

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(-10, 10));
                }
            }
            int s = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    s += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
