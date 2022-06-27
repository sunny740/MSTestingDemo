using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestingDemo
{
    public class StarBucksStore
    {
        public readonly IMAKECoffee service;
        public StarBucksStore(IMAKECoffee coffee)
        {
            this.service = coffee;
        }
        public string OrderCoffee(int sugerPerSpoon, int coffeePack)
        {
            if (service.CheckIngredientAvailability())
            {
                return service.CoffeeMaking(sugerPerSpoon, coffeePack);
            }
            return "Sorry! Coffee Is Not Available";
        }
    }
}