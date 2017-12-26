using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab13._1
{
    class UDEFileInfo
    {

        public static void FileInfo(string a)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(a);
                string fullPath = Path.GetFullPath(a);
                Console.WriteLine("Полный путь:      " + fullPath + 
                                "\nПолное имя:       " + fileInfo.FullName +
                                "\nТип:              " + fileInfo.Extension + 
                                "\nРазмер:           " + fileInfo.Length + " байт " + 
                                "\nВремя создания:   " + File.GetCreationTime(a));
            }
            catch (Exception e)
            {
                Console.WriteLine("Выполнение прервано: {0}", e.ToString());
            }
        }

    }
}
