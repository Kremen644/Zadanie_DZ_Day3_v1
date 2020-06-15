using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_DZ_Day3_v1
{
    public class Tank
    {
        private string _name;
        private string _armor;
        private string _maneuverability;
        private string _ammunition;
        public string Armor { get { return _armor; }}
        public string Maneuverability { get { return _maneuverability; } }
        public string Ammunition { get { return _ammunition; } }
        public string Name { get { return _name; } set { _name = value; } }

        public Tank(string n, string armor, string maneuverability, string ammunition)
        {
            _name = n;
            _armor = armor;
            _maneuverability = maneuverability;
            _ammunition = ammunition;
        }

        public static Tank operator *(Tank c1, Tank c2)
        {
            int win1 = 0;
            int win2 = 0;
            if (Int16.Parse(c1.Armor) > Int16.Parse(c2.Armor))
                win1++;
            else
            {
                if (Int16.Parse(c1.Armor) < Int16.Parse(c2.Armor))
                    win2++;
            }
            if (Int16.Parse(c1.Maneuverability) > Int16.Parse(c2.Maneuverability))
                win1++;
            else
                if (Int16.Parse(c1.Maneuverability) < Int16.Parse(c2.Maneuverability))
                win2++;
            if (Int16.Parse(c1.Ammunition) > Int16.Parse(c2.Ammunition))
                win1++;
            else
                if (Int16.Parse(c1.Ammunition) < Int16.Parse(c2.Ammunition))
                win2++;
            if (win1 > win2)
                return c1;
            if (win1 < win2)
                return c2;
            if (win1 == win2)
            {
                if (Int16.Parse(c1.Armor) > Int16.Parse(c2.Armor))
                    return c1;
                if (Int16.Parse(c1.Armor) < Int16.Parse(c2.Armor))
                    return c2;

            }
            c1.Name = "Okay, we're tied.";
            c2.Name = "Okay, we're tied.";
            return c1;
        }

    }
}

