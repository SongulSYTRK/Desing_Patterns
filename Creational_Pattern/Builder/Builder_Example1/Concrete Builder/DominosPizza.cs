using Creational_Pattern.Builder.Abstract_Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Builder.Concrete_Builder
{
    public class DominosPizza : PizzaBuilder
    {
        public DominosPizza() => _pizza = new Product_Pizza { PizzaType = "DominosPizza" };
        
        public override void GetDough() => _pizza.Dough = "be thin dough";

        public override void GetSos() => _pizza.Sos = "spicy, garlic, ketchup";
        
    }
}
