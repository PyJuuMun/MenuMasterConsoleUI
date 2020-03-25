﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Food
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public Food()
        { 
            
        }

        public Food(string name, double price, string desc)
        {
            this.Name = name;
            this.Price = price;
            this.Description = desc;
        }
    }
}
