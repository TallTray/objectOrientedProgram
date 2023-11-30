using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Facade_
{
    public class DVD
    {
        public void In()
        {
            Console.WriteLine("Плеер заберает диск");
        }
        public void Out()
        {
            Console.WriteLine("Плеер отдает диск");
        }
        public void Play()
        {
            Console.WriteLine("Плеер воспроизводит содержимое диска");
        }
    }
}
