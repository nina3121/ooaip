using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class HighTechSofa : ISofa
    {
        public string Material {  get; set; }
        public int Size { get; set; }
        public HighTechSofa(string material, int size)
        {
            Material = material;
            Size = size;
        }
        public void GetSofa() { }
        public ISofa Clone()
        {
            return new HighTechSofa(Material, Size);
        }
    }
}
