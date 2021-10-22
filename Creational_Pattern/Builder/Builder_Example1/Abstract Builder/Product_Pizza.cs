using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Builder.Abstract_Builder
{
   public  class Product_Pizza
    {
        public string PizzaType { get; set; }
        public string Dough { get; set; }
        public string Sos { get; set; }

        public override string ToString()
        {
            return String.Format("  Pizzatype=> {0}   Dough=> {1}    Sos=>{2}", PizzaType, Dough, Sos);
        }
    }
}
