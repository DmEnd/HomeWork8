using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 3.    Вручную подготовьте текстовый файл с фрагментом текста. Напишите программу, которая выводит статистику 
             * по файлу - количество символов, строк и слов в тексте.
             */

            string path = "text.txt", str = "";
            int n, l,s;
            n = l =s= 0;

            using (StreamReader sr = new StreamReader(path))
            {
                //Получение количества строк
                while (!sr.EndOfStream)
                {
                    str = str + sr.ReadLine() + "\n";
                    n++;                                
                }  
            }

            Console.WriteLine("В тексте:\n\n{0}", str);

            //Получение количества символов
            str = Regex.Replace(str, "[\n]", "");
            l = str.Length;

            //Получение количества слов
            str = Regex.Replace(str, "[-.?!)(,:;'[0-9\\]/*]", "");
            string[] strArray = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            s = strArray.Length;

            Console.WriteLine("Количество строк = {0}\nКоличество символов(включая пробелы) = {1}\nКоличество слов = {2}", n,l,s);

            Console.ReadKey();
        }
    }
}
