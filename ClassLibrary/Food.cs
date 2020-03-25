using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Food
    {
        public string Name;
        public double Price;
        public string Description;

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
