using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class HighTechAbstractFactory : IAbstractFactory
    {
        private IChair _chairPrototype;
        private ISofa _sofaPrototype;
        private IWardrobe _wardrobePrototype;
        public HighTechAbstractFactory(HighTechChair chair, HighTechSofa sofa, HighTechWardrobe wardrobe)
        {
            _chairPrototype = chair == null ? throw new ArgumentNullException() : chair; 
            _sofaPrototype = sofa == null ? throw new ArgumentNullException() : sofa;
            _wardrobePrototype = wardrobe == null ? throw new ArgumentNullException() : wardrobe;
        }
        public IChair CreateChair()
        {
            return _chairPrototype.Clone();
        }
        public ISofa CreateSofa()
        {
            return _sofaPrototype.Clone();
        }
        public IWardrobe CreateWardrobe()
        {
            return _wardrobePrototype.Clone();
        }
    }
}
