using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab13._1
{
    class UDEDiskInfo
    {
        public static void DiskInfo()
        {
            try
            {
                DriveInfo[] allDrives = DriveInfo.GetDrives();

                foreach (DriveInfo d in allDrives)
                {
                    Console.WriteLine("Диск {0}", d.Name);
                    Console.WriteLine("  Тип диска: {0}", d.DriveType);
                    if (d.IsReady == true)
                    {
                        Console.WriteLine("  Метка тома: {0}", d.VolumeLabel);
                        Console.WriteLine("  Файловая сис-ма: {0}", d.DriveFormat);
                        Console.WriteLine("  Доступный объем:      {0, 15} байтов", d.AvailableFreeSpace);
                        Console.WriteLine("  Всего доступно памяти:{0, 15} байтов", d.TotalFreeSpace);
                        Console.WriteLine("  Общий объем памяти:   {0, 15} байтов", d.TotalSize);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Выполнение прервано: {0}", e.ToString());
            }
        }
    }
}



