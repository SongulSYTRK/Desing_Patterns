using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Builder.Abstract_Builder
{
   public abstract class PizzaBuilder
    {
        protected Product_Pizza _pizza;
        public Product_Pizza Product_Pizza
        {
            get => _pizza;
            set => _pizza = value;
        }



        public abstract void GetDough();
        public abstract void GetSos();

    }
}
