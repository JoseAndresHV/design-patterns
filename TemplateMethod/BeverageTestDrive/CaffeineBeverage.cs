using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageTestDrive
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }
        
        public void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }

        public abstract void Brew();
        
        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup...");
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public abstract void AddCondiments();
    }
}
