﻿using Newtonsoft.Json.Linq;
using System;


namespace Nanolock_Unit_Testing_System.Test_Components
{
    public class Registers
    {
        public JObject Response { get; set; }
        public int Result { get; set; }

        public Registers(JObject obj)
        {
            //TODO
        }
    }
}
