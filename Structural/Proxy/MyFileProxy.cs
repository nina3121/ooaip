using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class MyFileProxy : IMyFile
    {
        private string _path;
        private MyFile? _myFile;

        public MyFileProxy (string path)
        {
            if (String.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException("string was empty");
            }
            _path = path;
        }

        public string GetPath()
        {
            return _path;
        }

        public byte[] ReadAll()
        {
            if (_myFile == null)
            {
                _myFile = new MyFile(_path);
            }
            return _myFile.ReadAll();
        }

        public long Size()
        {
            if (_myFile == null)
            {
                FileInfo file = new FileInfo(_path);
                return file.Length;
            }
            else
            {
                return _myFile.Size();
            }
        }
    }
}
