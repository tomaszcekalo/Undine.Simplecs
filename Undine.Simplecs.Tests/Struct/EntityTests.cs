using NSubstitute;
using Undine.Core.Struct;
using Undine.Simplecs.Struct;
using Undine.Simplecs.Tests.Struct.Components;

namespace Undine.Simplecs.Tests.Struct
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