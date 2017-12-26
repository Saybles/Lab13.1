using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab13._1
{
    class UDEFileManager
    {

        public static void First()
        {
            string[] dirs = Directory.GetFiles(@"D:\");
            Console.WriteLine("Количество файлов {0}.", dirs.Length);
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
            string[] tmp = Directory.GetDirectories(@"D:\");
            Console.WriteLine();
            Console.WriteLine("Количество папок {0}.", tmp.Length);
            foreach (string s in tmp)
            {
                Console.WriteLine(s);
            }

            Directory.CreateDirectory(@"D:\UDEInspect");

            FileStream file = new FileStream(@"D:\UDEInspect\udedirinfo.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
            using (StreamWriter output = new StreamWriter(file))
            {
                output.WriteLine("Количество папок {0}.", tmp.Length);
                for (int i = 0; i < tmp.Length; i++)
                {
                    output.WriteLine(tmp[i]);
                }
                output.WriteLine("Количество файлов {0}.", dirs.Length);
                for (int i = 0; i < dirs.Length; i++)
                {
                    output.WriteLine(dirs[i]);
                }

                output.Close();
            }
            file.Close();
            if (File.Exists(file.Name)) { File.Copy(file.Name, @"D:\UDEInspect\COPY.txt"); }
            File.Delete(@"D:\UDEInspect\udedirinfo.txt");
        }

        public static void Second()
        {
            DirectoryInfo inf1 = Directory.CreateDirectory(@"D:\UDEFiles");
            DirectoryInfo inf2 = new DirectoryInfo(@"D:\UDEInspect");

            foreach (var item in inf2.GetFiles())
            {
                if (item.FullName.Contains(".txt"))
                {
                    item.CopyTo(@"D:\UDEFiles\" + item.Name, true);
                }
            }
            inf1.MoveTo(@"D:\UDEInspect\UDEFiles");
        }
    }
}
