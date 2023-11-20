using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderBurger
{
    //en este caso el director no sabe de tipos de hamburguesas
    //es mejor practica inyectar la dependencia, caso robot
    public class BurgerDirector
    {
        public void MakeBurger(IBurgerBuilder burgerBuilder)
        {
            burgerBuilder.AddBread();
            burgerBuilder.AddMeat();
            burgerBuilder.AddCheese();
            burgerBuilder.AddDressing();
            burgerBuilder.AddLettuce();
            burgerBuilder.AddTomato();
        }
    }
}
