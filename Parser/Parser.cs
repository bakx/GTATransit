using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Parser
{
    public class Parser<T> where T : class, new()
    {
        public static Dictionary<string, int> Configure(string columns)
        {
            //
            List<string> dataFields = columns.Split(',').ToList();

            // Create new type for T to be able to use reflection
            T t = new T();

            Type type = t.GetType();

            IEnumerable<string> variables = type.GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Where(v => v.Name.StartsWith("get_"))
                .Select(n => n.Name.Remove(0, 4));

            return variables.Select(variable => Utilities<T>
                    .GetDataMemberName(t, variable))
                .ToDictionary(
                    fieldName => fieldName,
                    fieldName => dataFields.IndexOf(fieldName)
                );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="config"></param>
        /// <param name="readLine"></param>
        /// <returns></returns>
        public static T Process(Dictionary<string, int> config, string readLine)
        {
            string[] p = readLine.Split(",");

            // Create new T
            T t = new T();
            
            // Loop through items
            for (int i = 0; i < p.Length; i++)
            {
                // Get the key
                (string key, _) = config.SingleOrDefault(c => c.Value == i);

                // If the key does not exists, it's not part of the standards
                if (key == null)
                {
                    continue;
                }

                PropertyInfo propInfo =
                    (from property in typeof(T).GetProperties()
                        let attributes = property
                            .GetCustomAttributes(typeof(DataMemberAttribute), false)
                            .OfType<DataMemberAttribute>()
                        where attributes.Any(a => a.Name == key)
                        select property).FirstOrDefault();

                if (propInfo != null)
                {
                    propInfo.SetValue(t, p[i]);
                }
            }

            return t;
        }
    }
}