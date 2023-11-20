using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBurger
{
    public class Burger
    {
        public string Bread { get; set; }
        public string Cheese { get; set; }
        public bool Lettuce { get; set; }
        public string Meat { get; set; }
        public string Dressing { get; set; }
        public bool Tomato { get; set; }

        public void DisplayBurgerInfo()
        {
            Console.WriteLine("The info of your burger is");
            Console.WriteLine($"Bread: {Bread}");
            Console.WriteLine($"Cheese: {Cheese}");
            Console.WriteLine($"Lettuce: {Lettuce}");
            Console.WriteLine($"Meat: {Meat}");
            Console.WriteLine($"Dressing: {Dressing}");
            Console.WriteLine($"Tomato: {Tomato}");
        }
    }
}
