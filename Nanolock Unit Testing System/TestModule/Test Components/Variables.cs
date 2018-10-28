using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Nanolock_Unit_Testing_System.Test_Components
{
    public class Variables
    {
        private Dictionary<string, Object> Vars { get; set; }

        public Variables(Dictionary<string, Object> vars)
        {
            Vars = vars;
        }

        /* 
         Variables objects should be returned from the JsonReader static functions as mentioned in the plan,
         the static function should parse to the dictionary and return the variables object with the parsed dictionary.
         It should be done for every object using JsonReader for Initialization.
        */
        public Variables(JToken obj)
        {
            Vars = new Dictionary<string, Object>();

            foreach (JProperty rawVar in obj.Children<JProperty>())
            {
                Vars[rawVar.Name] = rawVar.Value;
            }
        }

        public T GetVar<T>(string key)
        {
            return (T)Vars[key];
        }

        public void SetVar(string key, object val)
        {
            Vars[key] = val;
        }
    }
}
