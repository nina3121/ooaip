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
        protected IFly _fly;
        protected ISwim _swim;
        protected ICrack _crack;

        public Duck(IFly fly, ISwim swim, ICrack crack)
        {
            _fly = fly == null ? throw new ArgumentNullException() : fly;
            _swim = swim == null ? throw new ArgumentNullException() : swim;
            _crack = crack == null ? throw new ArgumentNullException() : crack;
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

        public void SetFly(IFly fly)
        {
            _fly = fly;
        }

        public void SetSwim(ISwim swim)
        {
            _swim = swim;
        }

        public void SetCrack(ICrack crack)
        {
            _crack = crack;
        }
    }
}
