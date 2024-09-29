using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class HighTechChair : IChair 
    {
        public string Material { get; set; }
        public int Size { get; set; }
        public HighTechChair(string material, int size)
        {
            Material = material;
            Size = size;
        }
        public void GetChair() { }
        public IChair Clone()
        {
            return new HighTechChair(Material, Size);
        }
    }
}
