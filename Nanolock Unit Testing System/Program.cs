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
            //looking for file in bin/Debug
            //maybe we should change to read from Tests folder in project
            JsonReader reader = new JsonReader("Tests/TSL.json");
            Variables testVars = reader.getVariables();
            Console.WriteLine(testVars);
        }
    }
}