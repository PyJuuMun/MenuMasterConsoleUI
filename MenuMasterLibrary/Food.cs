using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Food
    {
        public string name { get; set; }
        public double price { get; set; }        

        public Food()
        { 
            
        }

        public Food(string name, double price)
        {
            this.name = name;
            this.price = price;     
        }
    }
}
