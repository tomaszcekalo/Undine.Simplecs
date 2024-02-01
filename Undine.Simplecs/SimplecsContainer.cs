using Simplecs;
using Undine.Core;

namespace Undine.Simplecs
{
    public class SimplecsContainer : EcsContainer
    {
        private World _world = new World();
        private List<ISystem> Systems = new List<ISystem>();

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            base.RegisterComponentType<A>();
            Systems.Add(new SimplecsSystem<A>()
            {
                System = system,
                World = _world
            });
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            base.RegisterComponentType<A>();
            base.RegisterComponentType<B>();
            Systems.Add(new SimplecsSystem<A, B>()
            {
                System = system,
                World = _world
            });
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            base.RegisterComponentType<A>();
            base.RegisterComponentType<B>();
            base.RegisterComponentType<C>();
            Systems.Add(new SimplecsSystem<A, B, C>()
            {
                System = system,
                World = _world
            });
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            base.RegisterComponentType<A>();
            base.RegisterComponentType<B>();
            base.RegisterComponentType<C>();
            base.RegisterComponentType<D>();
            Systems.Add(new SimplecsSystem<A, B, C, D>()
            {
                System = system,
                World = _world
            });
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            return new SimplecsEntity(_world);
        }

        public override void DeleteEntity(IUnifiedEntity entity)
        {
            var entityToDelete = entity as SimplecsEntity;
            if(entityToDelete is not null)
            {

            }
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            base.RegisterComponentType<A>();

            return new SimplecsSystem<A>()
            {
                System = system,
                World = _world
            };
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            base.RegisterComponentType<A>();
            base.RegisterComponentType<B>();

            return new SimplecsSystem<A, B>()
            {
                System = system,
                World = _world
            };
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            base.RegisterComponentType<A>();
            base.RegisterComponentType<B>();
            base.RegisterComponentType<C>();

            return new SimplecsSystem<A, B, C>()
            {
                System = system,
                World = _world
            };
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            base.RegisterComponentType<A>();
            base.RegisterComponentType<B>();
            base.RegisterComponentType<C>();
            base.RegisterComponentType<D>();

            return new SimplecsSystem<A, B, C, D>()
            {
                System = system,
                World = _world
            };
        }

        public override void Run()
        {
            foreach (var item in Systems)
            {
                item.ProcessAll();
            }
        }
    }
}