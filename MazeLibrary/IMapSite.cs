using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadilovProject
{
    public interface IMapSite 
    {
        public void Enter();
        public IMapSite Clone();
    }
}
