using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PraktikaBilet25
{
    internal class Program
    {
        public static List<Pill> pillList = new List<Pill>();

        static void Main(string[] args)
        {
            string path = @"C:\Users\user\Desktop\Учеба\test.txt";

            StreamReader streamReader = new StreamReader(path);
            string text  = streamReader.ReadToEnd();
            string[] lines = text.Split('\n');

            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line)) return;
                Pill newPill = new Pill();
                for (int i = 0; i < 6; i++)
                {
                    if (i == 0)
                    {
                        string s = line.Split(';')[i].ToString();
                        newPill.preaparatName = s;
                    }

                    if (i == 1)
                    {
                        string s = line.Split(';')[i].ToString();
                        newPill.diseaseName = s.Substring(1);
                    }

                    if (i == 2)
                    {
                        string s = line.Split(';')[i].ToString();
                        newPill.calculationType = s.Substring(1);
                    }

                    if (i == 3)
                    {
                        string s = line.Split(';')[i].ToString();
                        s = s.Substring(1);
                        newPill.countPills = int.Parse(s);
                    }

                    if (i == 4)
                    {
                        string s = line.Split(';')[i].ToString();
                        s = s.Substring(1);
                        newPill.ageMin = int.Parse(s);
                    }

                    if (i == 5)
                    {
                        string s = line.Split(';')[i].ToString();
                        s = s.Substring(1);
                        newPill.ageMax = int.Parse(s);
                    }

                    if (i == 6)
                    {
                        string s = line.Split(';')[i].ToString();
                        s = s.Substring(1);
                        newPill.countML = int.Parse(s);
                    }
                }
                pillList.Add(newPill);
            }
            Console.WriteLine(pillList[2].countML);

            Pill pill = new Pill();

            Console.WriteLine("Введите название препарата");
            pill.preaparatName = Console.ReadLine();

            Console.WriteLine("Введите название болезни");
            pill.diseaseName = Console.ReadLine();
            
            REG_MARK rEG_MARK = new REG_MARK();
            rEG_MARK.GetCountPill(pill);
        }
    }
}
