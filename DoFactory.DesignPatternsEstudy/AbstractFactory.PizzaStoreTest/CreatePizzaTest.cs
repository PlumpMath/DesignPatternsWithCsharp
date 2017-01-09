using System;
using HeadFirstDesignPatterns.AbstractFactory.PizzaStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AbstractFactory.PizzaStoreTest
{
    [TestClass]
    public class CreatePizzaTest
    {
        [TestMethod]
        public void CreateCheesePizza()
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            var pizzaDetails = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine(pizzaDetails.Name + pizzaDetails.Bake() + 
                pizzaDetails.Box() + pizzaDetails.Cut() + pizzaDetails.Prepare());
        }
    }
}
