using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_State_
{
    public partial class CandyMashine
    {
        protected class Sold : IState
        {
            private CandyMashine _mashine;
            public Sold(CandyMashine candy)
            {
                _mashine = candy;
            }

            public void EjectQuarter()
            {
                Console.WriteLine("Ничего не произошло");
            }

            public void InsertQuarter()
            {
                Console.WriteLine("Ничего не произошло");
            }

            public void TurnCrank()
            {
                Console.WriteLine("Ничего не произошло");
            }
            public void Dispense()
            {
                Console.WriteLine("Конфета выдана");
                _mashine.SetState(_mashine.CandyLeft > 0 ? new No_quarters(_mashine) : new Sold_out(_mashine));
            }
        }
    }
}
