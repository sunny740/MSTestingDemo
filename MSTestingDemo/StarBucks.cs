namespace MSTestingDemo
{
    public class StarBucks : IMAKECoffee //moq
    {
        public bool CheckIngredientAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int coffeePack)
        {
            throw new NotImplementedException();
        }
    }
    public class StubStarBucks : IMAKECoffee
    {
        public bool CheckIngredientAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int coffeePack)
        {
            return "Your order is recieved";
        }
    }
    public class FakeStarBucks : IMAKECoffee
    {
        public bool CheckIngredientAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugarPerSpoon, int coffeePack)
        {
            return "Your order is recieved";
        }
    }
}