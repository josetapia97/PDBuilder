using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBurger
{
    public class ClassicBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger = new Burger();

        public void AddBread()
        {
            _burger.Bread = "Sesame bread";
        }

        public void AddCheese()
        {
            _burger.Cheese = "Chedar";
        }

        public void AddDressing()
        {
            _burger.Dressing = "All";
        }

        public void AddLettuce()
        {
            _burger.Lettuce = true;
        }

        public void AddMeat()
        {
            _burger.Meat = "Pork";
        }

        public void AddTomato()
        {
            _burger.Tomato = true;
        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
