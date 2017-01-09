using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abstract.RealWorld.Test
{
    [TestClass]
    public class CreateAndRunAnimalTest
    {
        [TestMethod]
        public void TestCreateAndRunAnimal()
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the American animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
        }
    }
}
