using Facade.FacadeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facede
{
    public class Client
    {
        public void GetButton()
        {
            Design design = new Design();
            Backend backend = new Backend();
            Frontend frontend = new Frontend();

            ManagerFacade manager = new ManagerFacade(design, backend, frontend);
            manager.AddButton();
            manager.FixUI();
            manager.FixCalculations();
        }
    }
}