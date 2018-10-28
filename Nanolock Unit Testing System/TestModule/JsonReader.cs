using Nanolock_Unit_Testing_System.Test_Components;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanolock_Unit_Testing_System
{
    public class JsonReader
    {
        private dynamic Root { get; set; }

        public JsonReader(string filename) : this(JObject.Parse(File.ReadAllText(filename))) { }

        public JsonReader(JObject root)
        {
            Root = root;
        }

        /* 
         * This should not be read from the file
         * The variables inside are static and are accessible only through instructions 
        */

        public Variables getVariables()
        {
            try
            {
                return new Variables(Root.Variables.ToObject<JToken>());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return new Variables(new Dictionary<string, Object>());
            }
        } 

        public List<Instruction> GetInstructions()
        {
            return null;
        }

        public Categories GetCategories()
        {
            try
            {
                return new Categories(Root.Categories.ToObject<JToken>());
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
                return new Categories(new List<CategoryType>());
            }
        }
    }
}
