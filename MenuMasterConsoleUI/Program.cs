using System;
using MenuMasterLibrary;
namespace MenuMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza myPizza = new Pizza();
            myPizza.name = "Cheese-pizza";

            Console.WriteLine($"Pizza's name: {myPizza.name}");

            //Vaihtoehtoinen tapa käyttää ObjektiNimeä verrattuna ylempään vaihoehtoon
            Pasta myPasta = new Pasta
            {
                name = "Shaghetti & Meatballs"
            };

            Console.WriteLine($"Pasta's name: {myPasta.name}");
            
        }
    }
}
