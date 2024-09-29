using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Modern
{
    public class ModernWardrobe : IWardrobe
    {
        public string Material { get; set; }
        public int Size { get; set; }
        public ModernWardrobe(string material, int size)
        {
            Material = material;
            Size = size;
        }
        public void GetWardrobe() { }
        public IWardrobe Clone()
        {
            return new ModernWardrobe(Material, Size);
        }
    }
}
