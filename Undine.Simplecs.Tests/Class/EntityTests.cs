using NSubstitute;
using Undine.Core.Class;
using Undine.Simplecs.Class;
using Undine.Simplecs.Tests.Class.Components;

namespace Undine.Simplecs.Tests.Class
{
    [TestClass]
    public class EntityTests
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        public void ComponentCanBeAdded()
        {
            var container = new SimplecsContainer();
            container.Init();
            var entity = container.CreateNewEntity();
            entity.AddComponent(new AComponent());
        }

        [TestMethod]
        public void ComponentCanBeRetrieved()
        {
            var container = new SimplecsContainer();
            var mock = Substitute.For<UnifiedSystem<AComponent>>();
            container.AddSystem(mock);
            container.Init();
            var entity = (SimplecsEntity)container.CreateNewEntity();
            entity.AddComponent(new AComponent());
            container.Run();
            ref var component = ref entity.GetComponent<AComponent>();
            Assert.IsNotNull(component);
        }//
    }
}