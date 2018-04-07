using System;

namespace Sample.NetCoreNorthwind.Extensions
{
    public static class FunctionalExtensions
    {
        public static T With<T>(this T self, Action<T> act)
        {
            act?.Invoke(self);
            return self;
        }
    }
}
