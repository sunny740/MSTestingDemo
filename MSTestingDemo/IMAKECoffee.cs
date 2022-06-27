using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestingDemo
{
    public interface IMAKECoffee
    {
        bool CheckIngredientAvailability();
        string CoffeeMaking(int sugarPerSpoon, int coffeePack);
    }
}
