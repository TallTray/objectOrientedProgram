using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_Proxy_
{
    public class FileProxy : IFile
    {
        private string _path;
        private File? _file;

        public FileProxy(string path)
        {
            _path = path ?? throw new ArgumentNullException(nameof(path));
            StreamReader readerCheck = new(_path);
            readerCheck.Dispose();
        }
        public double GetSize()
        {
            return _file == null ? new FileInfo(_path).Length : _file.GetSize();
        }
        public string GetPath()
        {
            return _file == null ? _path : _file.GetPath();
        }
        public byte[] Show()
        {
            _file ??= new File(_path);
            return _file.Show();
        }
        public void Dispose()
        {
            _file?.Dispose();
        }
    }
}
