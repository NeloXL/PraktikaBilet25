using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaBilet25
{
    internal class REG_MARK
    {
        public double GetCountPill(Pill pill)
        {
            int weight = 0;
            int age = 0;

            List<Pill> pillList = Program.pillList;
            if (!pillList.Select(x => x.preaparatName).Contains(pill.preaparatName))
            {
                Console.WriteLine("Такого препарата не существует!");
            }

            pillList = pillList.Where(x => x.preaparatName == pill.preaparatName).ToList();

            if (!pillList.Select(x => x.diseaseName).Contains(pill.diseaseName))
            {
                Console.WriteLine("Этот препарат не применяется к данной болезни!");
            }

            pillList = pillList.Where(x => x.diseaseName == pill.diseaseName).ToList();

            if (pillList.Select(x => x.calculationType).Contains("по весу"))
            {
                Console.Write("Укажите свой вес (целое число):");
                weight = int.Parse(Console.ReadLine());
            }

            if (pillList.Select(x => x.calculationType).Contains("по возрасту"))
            {
                Console.WriteLine("Укажите свой возраст (целое число):");
                age = int.Parse(Console.ReadLine());
            }

            if (age != 0)
            {
                if(pillList.Select(x => x.ageMax).Where(x => age < x) == null)
                {
                    Console.WriteLine("Нет лекарства, которое подходит вам по возрасту (вы слишком взрослый)!");
                    return 0;
                }

                if (pillList.Select(x => x.ageMin).Where(x => age > x) == null)
                {
                    Console.WriteLine("Нет лекарства, которое подходит вам по возрасту (вы слишком молодой)!");
                    return 0;
                }

                Console.WriteLine(pillList.Where(x => x.ageMin <= age && x.ageMax >= age).First().countML);
            }

            return .5;
        }
    }
}
