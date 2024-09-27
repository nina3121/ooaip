using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Burger
    {
        private readonly List<string> _ingredients;
        public Burger()
        {
            _ingredients = new List<string>();
        }
        public void AddIngredient(string ingredient)
        {
            _ingredients.Add(ingredient);
        }
        public List<string> GetIngredients()
        {
            return _ingredients;
        }
    }
}
