﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Striker:FootballPlayer
    {
      public  Striker(string name, int number, int age, double height) : base(name, number, age, height)
        {
            Name = name;
            Number = number;
            Age = age;
            Height = height;
        }
    }
}
