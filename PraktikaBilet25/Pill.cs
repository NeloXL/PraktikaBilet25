using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaBilet25
{
    internal class Pill
    {
        public string preaparatName { get; set; }
        public string diseaseName { get;set; }
        public string calculationType { get; set; }
        public int countPills { get; set; }
        public int ageMin { get; set; }
        public int ageMax { get; set; }
        public int countML { get; set; }

        public Pill(string preaparatName, string diseaseName, string calculationType, int countPills, int ageMin, int ageMax, int countML)
        {
            this.preaparatName = preaparatName;
            this.diseaseName = diseaseName;
            this.calculationType = calculationType;
            this.countPills = countPills;
            this.ageMin = ageMin;
            this.ageMax = ageMax;
            this.countML = countML;
        }

        public Pill()
        {

        }
    }
}
