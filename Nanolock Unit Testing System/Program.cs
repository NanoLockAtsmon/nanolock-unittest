using Nanolock_Unit_Testing_System.Test_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanolock_Unit_Testing_System
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonReader reader = new JsonReader("TSL.json");
            Variables testVars = reader.getVariables();
            Console.WriteLine(testVars);
        }
    }
}