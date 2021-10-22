using Creational_Pattern.Builder.Abstract_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Builder.Director
{
   public  class Director_Customer
    {
       public void GetPizza(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.GetSos();
            pizzaBuilder.GetDough();
        }
    }
}
