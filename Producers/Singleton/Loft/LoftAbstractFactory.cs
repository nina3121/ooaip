using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class LoftAbstractFactory : IAbstractFactory
    {
        private LoftAbstractFactory() { }
        private static LoftAbstractFactory _instance;
        public static LoftAbstractFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoftAbstractFactory();
                }
                return _instance;
            }
        }
        public IChair CreateChair()
        {
            return new LoftChair();
        }
        public ISofa CreateSofa()
        {
            return new LoftSofa();
        }
        public IWardrobe CreateWardrobe()
        {
            return new LoftWardrobe();
        }
    }
}
