//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Simplecs;

//namespace Undine.Simplecs
//{
//    public static class ViewBuilderExtensions
//    {
//        private ComponentTable<T> Table<T>() where T : struct => _world.GetTable<T>();
//        public static View<T1, T2, T3, T4> Select<T1, T2, T3, T4>(this ViewBuilder viewBuilder) where T1 : struct where T2 : struct where T3 : struct where T4 : struct => new View<T1, T2, T3, T4>(Table<T1>(), Table<T2>(), Table<T3>(), Table<T4>(), Predicate());
//    }
//}