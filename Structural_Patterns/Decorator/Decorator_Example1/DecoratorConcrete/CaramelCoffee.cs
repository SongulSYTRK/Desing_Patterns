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
    public class CaramelCoffee : BaseDecorator
    {
        public CaramelCoffee(ICoffee coffee) : base(coffee) { }
        private void AddCaramel()  //caramel ekleme methodu yazılır 
        {
            MessageBox.Show(" Added Caramel into coffee");
        }
        public   void Hot()
        {
            
            base.Hot();
            AddCaramel();
        }
    }
}

