using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Facade_
{
    public class HomeCinema
    {
        private TV tv;
        private AudioSystem audio;
        private DVD dvd;
        public HomeCinema()
        {
            tv = new TV();
            audio = new AudioSystem();
            dvd = new DVD();
        }
        public void TurnOn()
        {
            tv.TurnOn();
            audio.TurnOn();
            dvd.In();
            dvd.Play();
        }
        public void TurnOff()
        {
            dvd.Out();
            audio.TurnOff();
            tv.TurnOff();
        }
    }
}
