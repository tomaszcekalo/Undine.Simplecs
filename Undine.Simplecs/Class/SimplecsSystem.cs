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
    public class SimplecsSystem<T> : ISystem
        where T : class
    {
        public IUnifiedSystem<T> System { get; init; }
        public World World { get; init; }

        public void ProcessAll()
        {
            var view = World.CreateView().Select<SimplecsComponentWrapper<T>>();
            var list = view.ToList();
            foreach (var item in view)
            {
                System.ProcessSingleEntity(0, ref item.Component.Component);
            }
        }
    }

    public class SimplecsSystem<A, B> : ISystem
        where A : class
        where B : class
    {
        public IUnifiedSystem<A, B> System { get; init; }
        public World World { get; init; }

        public void ProcessAll()
        {
            var view = World.CreateView().Select<SimplecsComponentWrapper<A>, SimplecsComponentWrapper<B>>();
            foreach (var item in view)
            {
                System.ProcessSingleEntity(0, ref item.Component1.Component, ref item.Component2.Component);
            }
        }
    }

    public class SimplecsSystem<A, B, C> : ISystem
        where A : class
        where B : class
        where C : class
    {
        public IUnifiedSystem<A, B, C> System { get; init; }
        public World World { get; init; }

        public void ProcessAll()
        {
            var view = World.CreateView()
                .Select<SimplecsComponentWrapper<A>, SimplecsComponentWrapper<B>, SimplecsComponentWrapper<C>>();
            foreach (var item in view)
            {
                System.ProcessSingleEntity(0, 
                    ref item.Component1.Component, 
                    ref item.Component2.Component, 
                    ref item.Component3.Component);
            }
        }
    }

    public class SimplecsSystem<A, B, C, D> : ISystem
        where A : class
        where B : class
        where C : class
        where D : class
    {
        public IUnifiedSystem<A, B, C, D> System { get; init; }
        public World World { get; init; }

        public void ProcessAll()
        {
            //throw new NotImplementedException();
            var view = World.CreateView().Select<SimplecsComponentWrapper<A>, SimplecsComponentWrapper<B>, SimplecsComponentWrapper<C>, SimplecsComponentWrapper<D>>();
            foreach (var item in view)
            {
                System.ProcessSingleEntity(0, 
                    ref item.Component1.Component, 
                    ref item.Component2.Component, 
                    ref item.Component3.Component, 
                    ref item.Component4.Component);
            }
        }
    }
}
