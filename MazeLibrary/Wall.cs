using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadilovProject
{
    public class Wall : IMapSite
    {
        public virtual void Enter()
        {
            Console.WriteLine("Вы уткнулись в стену");
        }

        public virtual IMapSite Clone()
        {
            return new Wall();
        }
    }
}
