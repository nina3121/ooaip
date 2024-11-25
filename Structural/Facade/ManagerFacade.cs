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

        public ManagerFacade (Design design, Backend backend, Frontend frontend)
        {
            this._designer = design;
            this._backender = backend;
            this._frontender = frontend;
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
