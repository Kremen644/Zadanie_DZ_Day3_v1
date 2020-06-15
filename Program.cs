using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_DZ_Day3_v1
{
    class Program
    {
        public const int MaxV = 5;
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int winT34 = 0;
            int winPant = 0;
            Tank []tankWin = new Tank[MaxV];
            Tank []tankT34 = new Tank[MaxV];
            Tank []tankPantera = new Tank[MaxV];
            for (int i = 0; i < MaxV; i++)
            {
                tankT34[i] = new Tank($"Tank T34-{i+1}", rnd.Next(0, 100).ToString(), rnd.Next(0, 100).ToString(), rnd.Next(0, 100).ToString());
                tankPantera[i] = new Tank($"Tank Pantera-{i+1}", rnd.Next(0, 100).ToString(), rnd.Next(0, 100).ToString(), rnd.Next(0, 100).ToString());
            }
            for (int i = 0; i < MaxV; i++)
            {
                Console.WriteLine($"T34-{i + 1} Ar: {tankT34[i].Armor}");
                Console.WriteLine($"T34-{i + 1} Ma: {tankT34[i].Maneuverability}");
                Console.WriteLine($"T34-{i + 1} Am: {tankT34[i].Ammunition}");

                Console.WriteLine($"Pantera-{i + 1} Ar: {tankPantera[i].Armor}");
                Console.WriteLine($"Pantera-{i + 1} Ma: {tankPantera[i].Maneuverability}");
                Console.WriteLine($"Pantera-{i + 1} Am: {tankPantera[i].Ammunition}");
                tankWin[i] = tankT34[i] * tankPantera[i];
                Console.WriteLine($"Win Tank: {tankWin[i].Name}");
                Console.WriteLine();
                if (tankWin[i].Name == tankT34[i].Name)
                    winT34++;
                if (tankWin[i].Name == tankPantera[i].Name)
                    winPant++;
            }
            if (winT34> winPant)
                Console.WriteLine("Win Tank: T34");
            if (winT34 < winPant)
                Console.WriteLine("Win Tank: Pantera");
            if (winT34 == winPant)
                Console.WriteLine("Win Tank: Okay, we're tied.");
        }
    }
}
