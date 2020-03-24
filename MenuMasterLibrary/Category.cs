using System;
using System.Collections.Generic;
using System.Text;

namespace MenuMasterLibrary
{
    public class Category
    {
        public List<Pizza> pizzas = new List<Pizza>();
        public List<Pasta> pastas = new List<Pasta>();       

        
    }

    public class Pizza
    {
        public string typename { get; set; }
        public int typeid { get; set; }

        public Pizza(Food dish)
        {

        }
    }

    public class Pasta
    {

        public string typename { get; set; }
        public int typeid { get; set; }

        public Pasta(Food dish)
        {

        }
    }
}
