//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Simplecs.Views;
//using Simplecs;

//namespace Undine.Simplecs
//{
//    public sealed class View<T1, T2, T3, T4> : IView<ViewRow<T1, T2, T3, T4>>
//        where T1 : struct
//        where T2 : struct
//        where T3 : struct
//        where T4 : struct
//    {
//        private readonly ViewPredicate _predicate;

//        internal readonly ComponentTable<T1> Table1;
//        internal readonly ComponentTable<T2> Table2;
//        internal readonly ComponentTable<T3> Table3;
//        internal readonly ComponentTable<T4> Table4;

//        internal View(ComponentTable<T1> table1, ComponentTable<T2> table2, ComponentTable<T3> table3, ComponentTable<T4> table4, ViewPredicate predicate) => (_predicate, Table1, Table2, Table3, Table4) = (predicate, table1, table2, table3, table4);

//        bool IView<ViewRow<T1, T2, T3, T4>>.TryBindRow(Entity entity, out ViewRow<T1, T2, T3, T4> row)
//        {
//            row = default(ViewRow<T1, T2, T3, T4>);
//            int index1 = Table1.IndexOf(entity);
//            if (index1 == -1) return false;
//            int index2 = Table2.IndexOf(entity);
//            if (index2 == -1) return false;
//            int index3 = Table3.IndexOf(entity);
//            if (index3 == -1) return false;
//            int index4 = Table4.IndexOf(entity);
//            if (index4 == -1) return false;
//            row = new ViewRow<T1, T2, T3, T4>(this, entity, index1, index2, index3, index4);
//            return _predicate.IsAllowed(entity);
//        }

//        ViewEnumerator<ViewRow<T1, T2, T3, T4>> IView<ViewRow<T1, T2, T3, T4>>.GetEnumerator() => new ViewEnumerator<ViewRow<T1, T2, T3, T4>>(this, ViewUtility.SmallestTable(SmallestTable(), _predicate.SmallestTable()));

//        private IComponentTable SmallestTable()
//        {
//            if (Table2.Count < Table1.Count && Table2.Count < Table3.Count) return Table2;
//            if (Table3.Count < Table1.Count && Table3.Count < Table2.Count) return Table3;
//            return Table1;
//        }
//    }
//}