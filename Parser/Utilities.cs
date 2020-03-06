using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace Parser
{
    public static class Utilities<T>
    {
        public static string GetDataMemberName(T t, string thePropertyName)
        {
            PropertyInfo pi = t.GetType().GetProperty(thePropertyName);
            if (pi == null)
                throw new ApplicationException($"{t.GetType().Name}.{thePropertyName} does not exist");

            if (!(pi.GetCustomAttribute(typeof(DataMemberAttribute), true) is DataMemberAttribute ca))
                throw new ApplicationException($"{t.GetType().Name}.{thePropertyName} does not have DataMember Attribute"); // or return thePropertyName?

            return ca.Name;
        }
    }
}