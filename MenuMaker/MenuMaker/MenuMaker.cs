using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuMaker
{
    class MenuMaker
    {
        public Random Randomizer;
        string[] Meats = {"Roast Beef", "Salami", "Turkey", "Ham", "Pastrami"};
        string[] Condiments = {"yellow mustard", "brown mustrard", "honey mustard", "mayo", "relish", "french dressing"};
        string[] Breads = {"rye", "white", "wheat", "pumpernickel", "italian", "roll"};

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat + " with " + randomCondiment + " on " + randomBreads;
        }
    }
}