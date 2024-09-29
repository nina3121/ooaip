﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Modern
{
    public class ModernAbstractFactory : IAbstractFactory
    {
        private IChair _chairPrototype;
        private ISofa _sofaPrototype;
        private IWardrobe _wardrobePrototype;
        public void SetChairPrototype(IChair prototype)
        {
            _chairPrototype = prototype;
        }
        public void SetSofaPrototype(ISofa prototype)
        {
            _sofaPrototype = prototype;
        }
        public void SetWardrobePrototype(IWardrobe prototype)
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