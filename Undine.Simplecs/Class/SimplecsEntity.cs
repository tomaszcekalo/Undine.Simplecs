using Simplecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.Core;
using Undine.Core.Class;

namespace Undine.Simplecs.Class
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

        public void AddComponent<A>(in A component) where A : class
        {
            _entityBuilder.Attach(new SimplecsComponentWrapper<A>()
            {
                Component=component
            });
        }

        public ref A GetComponent<A>() where A : class
        {
            return ref _world.GetComponent<SimplecsComponentWrapper<A>>(_entityBuilder.Entity).Component;
        }
    }
}
