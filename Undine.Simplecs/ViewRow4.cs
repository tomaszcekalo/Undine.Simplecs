//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Simplecs;

//namespace Undine.Simplecs
//{
//    public readonly struct ViewRow<T1, T2, T3, T4>
//        where T1 : struct
//        where T2 : struct
//        where T3 : struct
//        where T4 : struct
//    {
//        private readonly View<T1, T2, T3, T4> _view;
//        private readonly int _index1, _index2, _index3, _index4;

//        /// <summary>Entity of current row.</summary>
//        public Entity Entity { get; }

//        /// <summary>First component of current row.</summary>
//        public ref T1 Component1 => ref _view.Table1.ReferenceAt(Entity, _index1);

//        /// <summary>Second component of current row.</summary>
//        public ref T2 Component2 => ref _view.Table2.ReferenceAt(Entity, _index2);

//        /// <summary>Third component of current row.</summary>
//        public ref T3 Component3 => ref _view.Table3.ReferenceAt(Entity, _index3);

//        /// <summary>Fourth component of current row.</summary>
//        public ref T4 Component4 => ref _view.Table4.ReferenceAt(Entity, _index4);

//        internal ViewRow(View<T1, T2, T3, T4> view, Entity entity, int index1, int index2, int index3, int index4) => (_view, Entity, _index1, _index2, _index3, _index4) = (view, entity, index1, index2, index3, index4);
//    }
//}