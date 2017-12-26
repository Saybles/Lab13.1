using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Lab13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Информация о файловой системе: ");
            UDEDiskInfo.DiskInfo();
            Console.WriteLine();
            Console.WriteLine("Информация о файле udelogfile.txt: ");
            UDEFileInfo.FileInfo(@"D:\VisualStudioCPP\Labs\3-d Sem\Lab13.1\Lab13.1\udelogfile.txt");
            Console.WriteLine();
            Console.WriteLine("Информация о директории D:\\Games\\Skyrim: ");
            UDEDirInfo.DirectoryInfo(@"D:\Games\Skyrim");
            Console.WriteLine();
           // UDEFileManager.First();
            //Console.WriteLine();
            //UDEFileManager.Second();
            UDELog.Login();

            //UDELog.Rewrite(4);
            UDELog.DeleteTime("20:41:35");
        }
    }
}
