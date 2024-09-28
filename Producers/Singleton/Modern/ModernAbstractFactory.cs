using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ModernAbstractFactory : IAbstractFactory
    {
        private ModernAbstractFactory() { }
        private static ModernAbstractFactory _instance;
        public static ModernAbstractFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ModernAbstractFactory();
                }
                return _instance;
            }
        }
        public IChair CreateChair()
        {
            return new ModernChair();
        }
        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
        public IWardrobe CreateWardrobe() 
        {
            return new ModernWardrobe();
        }
    }
}
