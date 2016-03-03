using Newtonsoft.Json;
using System;
using System.Reflection;

namespace ExtensionMethods
{
    public static class ObjectExtensions
    {
        public static string ToJsonString(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T GetPrivateVariableFromObject<S, T>(this object obj, string nameOfVariable)
        {
            var fieldInfo = typeof(S).GetField(nameOfVariable, BindingFlags.Instance | BindingFlags.NonPublic);
            return (T)fieldInfo.GetValue(obj);
        }
    }
}
