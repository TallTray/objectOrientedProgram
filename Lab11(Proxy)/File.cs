using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Proxy_
{
    public class File : IFile
    {
        private string _path;
        private StreamReader _reader;

        public File(string path)
        {
            _path = path ?? throw new ArgumentNullException(nameof(path));
            _reader = new StreamReader(_path);
        }
        public double GetSize()
        {
            return new FileInfo(_path).Length;
        }
        public string GetPath()
        {
            return _path;
        }
        public byte[] Show()
        {
            return System.IO.File.ReadAllBytes(_path);
        }

        public void Dispose()
        {
            _reader.Dispose();
        }
    }
}
