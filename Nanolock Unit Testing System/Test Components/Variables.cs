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
         * Debating whether this should be implemented here  
         * or in the JsonReader class, where there is an
         * easy way to detect if this JObject contains
         * the correct values in order to parse them into Variables.
         * The same goes for the other test components.
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
    }
}
