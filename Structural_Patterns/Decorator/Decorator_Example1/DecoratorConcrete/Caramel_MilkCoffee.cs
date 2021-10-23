using Structural_Patterns.Decorator.Decorator_Example1.Abstract;
using Structural_Patterns.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structural_Patterns.Decorator.Decorator_Example1.DecoratorConcrete
{
   public  class Caramel_MilkCoffee:BaseDecorator
    {
        public Caramel_MilkCoffee(ICoffee coffee) : base(coffee) { }
        private void AddCaramel() 
        {
            MessageBox.Show(" Added Caramel into coffee");
        }
        private void AddMilk()
        {
            MessageBox.Show("Added milk into coffee");

        }
        public void Hot()
        {
            base.Hot();
            AddMilk();
            AddCaramel();
        }
    }
}
