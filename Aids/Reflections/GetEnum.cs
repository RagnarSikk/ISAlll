﻿using isa3.Aids.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isa3.Aids.Reflections
{
    public static class GetEnum
    {
        public static int Count<T>() => Count(typeof(T));

        public static T Value<T>(int i)
            => Safe.Run(() => (T)Value(typeof(T), i), default(T));

        public static int Count(Type type)
            => Safe.Run(() => Enum.GetValues(type).Length, -1);

        public static object Value(Type type, int i)
            => Safe.Run(() => {
                var v = Enum.GetValues(type);

                return v.GetValue(i);
            }, null);
    }
}