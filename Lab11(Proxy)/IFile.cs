using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Proxy_
{
    public interface IFile : IDisposable
    {
        public double GetSize();
        public string GetPath();
        public byte[] Show();
    }
}
