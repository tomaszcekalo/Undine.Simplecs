using Simplecs;
using Undine.Core;
using Undine.Core.Struct;

namespace Undine.Simplecs.Struct
{
    public class SimplecsSystem<T> : ISystem
        where T : struct
    {
        public IUnifiedSystem<T> System { get; init; }
        public World World { get; init; }

        public void ProcessAll()
        {
            var view = World.CreateView().Select<T>();
            var list = view.ToList();
            foreach (var item in view)
            {
                System.ProcessSingleEntity(0, ref item.Component);
            }
        }
    }

    public class SimplecsSystem<A, B> : ISystem
        where A : struct
        where B : struct
    {
        public IUnifiedSystem<A, B> System { get; init; }
        public World World { get; init; }

        public void ProcessAll()
        {
            var view = World.CreateView().Select<A, B>();
            foreach (var item in view)
            {
                System.ProcessSingleEntity(0, ref item.Component1, ref item.Component2);
            }
        }
    }

    public class SimplecsSystem<A, B, C> : ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        public IUnifiedSystem<A, B, C> System { get; init; }
        public World World { get; init; }

        public void ProcessAll()
        {
            var view = World.CreateView().Select<A, B, C>();
            foreach (var item in view)
            {
                System.ProcessSingleEntity(0, ref item.Component1, ref item.Component2, ref item.Component3);
            }
        }
    }

    public class SimplecsSystem<A, B, C, D> : ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        public IUnifiedSystem<A, B, C, D> System { get; init; }
        public World World { get; init; }

        public void ProcessAll()
        {
            //throw new NotImplementedException();
            var view = World.CreateView().Select<A, B, C, D>();
            foreach (var item in view)
            {
                System.ProcessSingleEntity(0, ref item.Component1, ref item.Component2, ref item.Component3, ref item.Component4);
            }
        }
    }
}