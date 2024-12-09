using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class MyFile : IMyFile
    {
        private string _path;

        public MyFile(string path)
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
            using (FileStream file = File.OpenRead(_path))
            {
                byte[] textInBytes = new byte[file.Length];
                file.Read(textInBytes, 0, textInBytes.Length);
                return textInBytes;
            }
        }

        public long Size()
        {
            using (FileStream file = new FileStream(_path, FileMode.Open, FileAccess.Read))
            {
                return file.Length;
            }
        }
    }
}
