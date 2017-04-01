﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Generics_Events
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory<Horse> factory = new AnimalFactory<Horse>();
            var horse = factory.Create();
        }
    }
}
