using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Strategy.Ducks;
using Strategy.IStrategy;

namespace Strategy
{
    public abstract class Duck
    {
        private IFly _fly;
        private ISwim _swim;
        private ICrack _crack;

        public Duck(IFly fly, ISwim swim, ICrack crack)
        {
            _fly = fly == null ? throw new ArgumentNullException(nameof(fly)) : fly;
            _swim = swim == null ? throw new ArgumentNullException(nameof(swim)) : swim;
            _crack = crack == null ? throw new ArgumentNullException(nameof(crack)) : crack;
        }

        public string ToFly()
        {
            return _fly.Fly();
        }

        public string ToSwim()
        {
            return _swim.Swim();
        }

        public string ToCrack()
        {
            return _crack.Crack();
        }
    }
}
