﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car1
    {
        public Car1(string model, int year, string type, int numb, bool active)
        {
            Model = model;
            Year = Year;
            Type = type;
            Numb = numb;
            Active = active;
        }

        public string Model { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public int Numb { get; set; }
        public bool Active { get; set; }
        public Dictionary<string, int>  component { get; set; }

        
        public override string ToString()
        {
            if (Active) Console.ForegroundColor = ConsoleColor.Red;
            else Console.ForegroundColor = ConsoleColor.Green;

            return string.Format("{0}", Model);
        }

    }
}
