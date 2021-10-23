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
   public  class MilkCoffee :BaseDecorator
    {
        public MilkCoffee(ICoffee coffee) : base(coffee) { }
        private void AddMilk()
        {
            MessageBox.Show("Added milk into coffee");

        }
        public  void Hot()
        {
            base.Hot();
            AddMilk();
        }
       
    }
}
