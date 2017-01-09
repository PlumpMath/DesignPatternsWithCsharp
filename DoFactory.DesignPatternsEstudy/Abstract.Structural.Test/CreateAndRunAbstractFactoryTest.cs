using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abstract.Structural.Test
{
    [TestClass]
    public class CreateAndRunAbstractFactoryTest
    {
        [TestMethod]
        public void CreateAndRunAbstractFactory()
        {
            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            var client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            var factory2 = new ConcreteFactory2();
            var client2 = new Client(factory2);
            client2.Run();
        }
    }
}
