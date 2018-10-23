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
         * Not really a thing.
         * If I recall correctly this is not read from the Json file
         * and is the same for each test for a certain extent.
         * 
        public Registers GetRegisters()
        {
            return null;
        }
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
