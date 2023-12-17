using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_Template_method_
{
    public abstract class DrinkBehavior
    {
        public void Make()
        {
            BoilWater();
            PourIntoMug();
            Brew();
            if (HasAdditionalComponents())
            {
                AddComponents();
            }
        }
        public void BoilWater()
        {
            Console.WriteLine("Вскепетили воду");
        }
        public void PourIntoMug()
        {
            Console.WriteLine("Налили воду в кружку");
        }
        protected abstract void Brew();
        protected abstract void AddComponents();
        protected virtual bool HasAdditionalComponents()
        {
            return false;
        }
    }
}
