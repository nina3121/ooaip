using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Client
    {
        private FurnitureCreator _furnitureCreator; 
        public Client(FurnitureCreator furnitureCreator)
        {
            _furnitureCreator = furnitureCreator;
        }
        public void DoSomeOperation()
        {
            string sofa = _furnitureCreator.CreateSofaFurniture();
            string chair = _furnitureCreator.CreateChairFurniture();
            string wardeobe = _furnitureCreator.CreateWardrobeFurniture();
        }
    }
}
