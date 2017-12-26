using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab13._1
{
    class UDELog
    {

        public static void Login()
        {

            using (StreamWriter output = new StreamWriter(@"D:\VisualStudioCPP\Labs\3-d Sem\Lab13.1\Lab13.1\udelogfile.txt", true))
            {
                for (int i = 0; i < 3; i++)
                {
                    output.WriteLine(i + " " + DateTime.Now + " внесено изменение");
                    output.WriteLine(i + " " + DateTime.Now + " внесено изменение");
                    output.WriteLine(i + " " + DateTime.Now + " внесено изменение");
                }
                output.Close();
            }
        }

        public static void Rewrite(int a)
        {

            string[] readText = File.ReadAllLines(@"D:\VisualStudioCPP\Labs\3-d Sem\Lab13.1\Lab13.1\udelogfile.txt");
            using (StreamWriter file = new StreamWriter(@"D:\VisualStudioCPP\Labs\3-d Sem\Lab13.1\Lab13.1\udelogfile.txt", false))
            {
                for (int i = 0; i < readText.Length; i++)
                {
                    if (i != a)
                        file.WriteLine(readText[i]);
                }
            }
        }

        public static void DeleteTime(string a)
        {
            string[] readText = File.ReadAllLines(@"D:\VisualStudioCPP\Labs\3-d Sem\Lab13.1\Lab13.1\udelogfile.txt");
            using (StreamWriter file = new StreamWriter(@"D:\VisualStudioCPP\Labs\3-d Sem\Lab13.1\Lab13.1\udelogfile.txt", false))
            {
                for (int i = 0; i < readText.Length; i++)
                {
                    if (!readText[i].Contains(a))
                    {
                        file.WriteLine(readText[i]);
                    }
                }
            }
        }
    }
}
