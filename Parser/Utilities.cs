using System;
using System.Reflection;
using System.Runtime.Serialization;

namespace Parser
{
    public static class Utilities<T>
    {
        public static string GetDataMemberName(T t, string thePropertyName)
        {
            PropertyInfo propertyInfo = t.GetType().GetProperty(thePropertyName);
            if (propertyInfo == null)
            {
                throw new ApplicationException($"{t.GetType().Name}.{thePropertyName} does not exist");
            }

            if (!(propertyInfo.GetCustomAttribute(typeof(DataMemberAttribute), true) is DataMemberAttribute
                dataMemberAttribute))
            {
                throw new ApplicationException(
                    $"{t.GetType().Name}.{thePropertyName} does not have DataMember Attribute"); // or return thePropertyName?
            }

            return dataMemberAttribute.Name;
        }
    }
}