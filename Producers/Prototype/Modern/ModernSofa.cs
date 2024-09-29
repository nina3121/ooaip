using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Modern
{
    public class ModernSofa : ISofa
    {
        public string Material { get; set; }
        public int Size { get; set; }
        public ModernSofa(string material, int size)
        {
            Material = material;
            Size = size;
        }
        public void GetSofa() { }
        public ISofa Clone()
        {
            return new ModernSofa(Material, Size);
        }
    }
}
