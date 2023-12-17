using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20_Template_method_
{
    public class Coffe : DrinkBehavior
    {
        private bool _hasAdditionalComponents;
        public Coffe(bool hasAdditionalComponents)
        {
            _hasAdditionalComponents = hasAdditionalComponents;
        }
        protected override void Brew()
        {
            Console.WriteLine("Заварили кофе");
        }
        protected override void AddComponents()
        {
            Console.WriteLine("Добавили ложку сахара");
        }
        protected override bool HasAdditionalComponents()
        {
            return _hasAdditionalComponents;
        }
    }
}
