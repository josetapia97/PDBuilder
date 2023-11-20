
using BuilderBurger;

BurgerDirector chef = new BurgerDirector();

//en este caso el builder tiene la informacion, no es necesario pasarsela al chef
ClassicBurgerBuilder cbb = new ClassicBurgerBuilder();  
chef.MakeBurger(cbb);
Burger clasicBurger= cbb.GetBurger();
clasicBurger.DisplayBurgerInfo();

//ejemplo vegan

VeganBurgerBuilder vbb = new VeganBurgerBuilder();
chef.MakeBurger(vbb);
Burger vegieBurger = vbb.GetBurger();
vegieBurger.DisplayBurgerInfo();