using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Parser
{
    public static class Parser<T> where T : class, new()
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

        public static void Process(Dictionary<string, int> config, string readLine)
        {
            var p = readLine.Split(",");

           // config.SelectMany(c => c.Value)
           for (int i = 0; i < p.Length; i++)
           {
               Console.WriteLine($"{config.Keys.ToList().IndexOf(null, i)} = {p[i]}" );
           }
          

//            Console.WriteLine(readLine);
        }
    }

   
}
