using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace Nanolock_Unit_Testing_System.Test_Components
{
    public class Categories
    {

        public List<CategoryType> Cats { get; set; }

        public Categories(List<CategoryType> cats)
        {
            Cats = cats;
        }

        /* 
         * Debating whether this should be implemented here  
         * or in the JsonReader class, where there is an
         * easy way to detect if this JObject contains
         * the correct values in order to parse them into Categories.
         * The same goes for the other test components.
         */
        public Categories(JToken tkn)
        { 
            string[] rawCats = tkn.ToObject<string[]>();

            Cats = new List<CategoryType>();

            foreach (string rawCat in rawCats)
            {
                Enum.TryParse(rawCat, out CategoryType cat);
                Cats.Add(cat);
            }
        }
    }
}
