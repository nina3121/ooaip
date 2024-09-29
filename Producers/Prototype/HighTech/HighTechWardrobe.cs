using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class HighTechWardrobe : IWardrobe
    {
        public string Material {  get; set; }
        public int Size { get; set; }
        public HighTechWardrobe(string material, int size)
        {
            Material = material;
            Size = size;
        }
        public void GetWardrobe() { }
        public IWardrobe Clone()
        {
            return new HighTechWardrobe(Material, Size);
        }
    }
}
