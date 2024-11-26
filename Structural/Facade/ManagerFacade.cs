using Facede.FacadeClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facede
{
    public class ManagerFacade
    {
        protected Design _designer;
        protected Backend _backender;
        protected Frontend _frontender; 

        public ManagerFacade(Design design, Backend backend, Frontend frontend)
        {

            _designer = design == null ? throw new ArgumentNullException() : design;
            _backender = backend == null ? throw new ArgumentNullException() : backend;
            _frontender = frontend == null ? throw new ArgumentNullException() : frontend;
        }

        public void AddButton()
        {
            _designer.Draw();
            _frontender.Develop();
            _backender.Develop();
        }

        public void FixUI()
        {
            _designer.Redraw(); 
            _frontender.Fix();
        }

        public void FixCalculations()
        {
            _backender.Fix();
        }
    }
}
