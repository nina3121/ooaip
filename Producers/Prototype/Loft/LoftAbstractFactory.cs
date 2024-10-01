using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class LoftAbstractFactory : IAbstractFactory
    {
        private IChair _chairPrototype;
        private ISofa _sofaPrototype;
        private IWardrobe _wardrobePrototype;
        public void SetChair(IChair prototype)
        {
            _chairPrototype = prototype;
        }
        public void SetSofa(ISofa prototype)
        {
            _sofaPrototype = prototype;
        }
        public void SetWardrobe(IWardrobe prototype)
        {
            _wardrobePrototype = prototype;
        }
        public IChair CreateChair()
        {
            if (_chairPrototype == null)
            {
                throw new InvalidOperationException();
            }
            return _chairPrototype.Clone();
        }
        public ISofa CreateSofa()
        {
            if (_sofaPrototype == null)
            {
                throw new InvalidOperationException();
            }
            return _sofaPrototype.Clone();
        }
        public IWardrobe CreateWardrobe()
        {
            if (_wardrobePrototype == null)
            {
                throw new InvalidOperationException();
            }
            return _wardrobePrototype.Clone();
        }
    }
}
