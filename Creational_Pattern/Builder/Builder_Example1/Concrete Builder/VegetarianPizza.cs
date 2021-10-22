using Creational_Pattern.Builder.Abstract_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Builder.Concrete_Builder
{
    public class VegetarianPizza : PizzaBuilder
    {
        public VegetarianPizza()=> _pizza = new Product_Pizza { PizzaType = "Vegetarian Pizza" };
        
        public override void GetDough()=> _pizza.Dough = "thin dough";
      

        public override void GetSos()=>  _pizza.Sos = "painless,pepper";

    }
}
