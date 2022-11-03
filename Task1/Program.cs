using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Обязательная задача*.Выберите любую папку на своем компьютере, имеющую вложенные директории.
             * Выведите на консоль ее содержимое и содержимое всех подкаталогов.
             */
            string path = @"C:\8.3_Самостоятельная работа 8. Работа с файловой системой";
            string[] files=Directory.GetFiles(path,".",SearchOption.AllDirectories );
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
