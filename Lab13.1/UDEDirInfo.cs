using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab13._1
{
    class UDEDirInfo
    {
        public static void DirectoryInfo(string a)
        {
            try
            {
                string[] dirs = Directory.GetFiles(a);
                Console.WriteLine("Кол-во файлов: " + dirs.Length + ", Время создания: " + Directory.GetCreationTime(a));
                string[] tmp = Directory.GetDirectories(a);
                Console.WriteLine("Поддиректории: ");
                foreach (string s in tmp)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("Родительская директория: ");
                Console.WriteLine(Directory.GetParent(a));
                Console.WriteLine("Содержимое(файлы): ");
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Выполнение прервано: {0}", e.ToString());
            }
        }
    }
}
