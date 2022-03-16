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
            Systems.Add(new SimplecsSystem<A>()
            {
                System = system
            });
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            Systems.Add(new SimplecsSystem<A, B>()
            {
                System = system
            });
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            Systems.Add(new SimplecsSystem<A, B, C>()
            {
                System = system
            });
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            Systems.Add(new SimplecsSystem<A, B, C, D>()
            {
                System = system
            });
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            return new SimplecsEntity(_world);
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            return new SimplecsSystem<A>()
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            return new SimplecsSystem<A, B>()
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            return new SimplecsSystem<A, B, C>()
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            return new SimplecsSystem<A, B, C, D>()
            {
                System = system
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