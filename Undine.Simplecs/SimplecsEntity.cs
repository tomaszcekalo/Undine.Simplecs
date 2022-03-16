using Simplecs;
using Undine.Core;

namespace Undine.Simplecs
{
    public class SimplecsEntity : IUnifiedEntity
    {
        private World _world;
        private EntityBuilder _entityBuilder;

        public SimplecsEntity(World world)
        {
            _world = world;
            _entityBuilder = _world.CreateEntity();
        }

        public void AddComponent<A>(in A component) where A : struct
        {
            _entityBuilder.Attach(component);
        }

        public ref A GetComponent<A>() where A : struct
        {
            return ref _world.GetComponent<A>(_entityBuilder.Entity);
        }
    }
}