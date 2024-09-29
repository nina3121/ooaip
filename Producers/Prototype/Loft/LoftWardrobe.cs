using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class LoftWardrobe : IWardrobe
    {
        public string Material { get; set; }
        public int Size { get; set; }
        public LoftWardrobe(string material, int size)
        {
            Material = material;
            Size = size;
        }
        public void GetWardrobe() { }
        public IWardrobe Clone()
        {
            return new LoftWardrobe(Material, Size);
        }
    }
}
