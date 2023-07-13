using Moq;
using Undine.Core;
using Undine.Simplecs.Tests.Components;
using Undine.Simplecs;

using Undine.Simplecs.Tests.Components;

namespace Undine.Simplecs.Tests
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
            var mock = new Mock<UnifiedSystem<AComponent>>();
            container.AddSystem(mock.Object);
            container.Init();
            var entity = (SimplecsEntity)container.CreateNewEntity();
            entity.AddComponent(new AComponent());
            container.Run();//LazyECS updates components on the next frame
            ref var component = ref entity.GetComponent<AComponent>();
            Assert.IsNotNull(component);
        }//
    }
}