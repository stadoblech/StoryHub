﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryHubServicesSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestClass();
            Console.WriteLine(a.Name + " " + a.Surename);
            Console.ReadKey();

        }
    }
}
