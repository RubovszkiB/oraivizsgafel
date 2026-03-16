using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Models
{
    public class Hos
    {
        public string Name { get; private set; }
        public string Title { get; private set; }
        public string Category { get; private set; }
        public string Tag { get; private set; }
        public double HP { get; private set; }
        public double Attackdamage { get; private set; }
        public double Attackdamagelevel { get; private set; }




        public Hos(string sor) {
            string[] str = sor.Split(';');
            Name = str[0];
            Title = str[1];
            Category = str[2];
            Tag = str[3];
            HP = double.Parse(str[4]);
            Attackdamage = double.Parse(str[5]);
            Attackdamagelevel = double.Parse(str[6]);
        }
    

    public double ADlevel(int level)
        {
            if (18 >= level && level >= 1)
            {
                return Attackdamage += Attackdamagelevel * (level - 1);
            }
            else return -1;
        }
    }
}