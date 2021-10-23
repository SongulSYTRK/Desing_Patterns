using Structural_Patterns.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structural_Patterns.Decorator.Decorator_Example1.Abstract
{
    public abstract class BaseDecorator : ICoffee  // Tüm decoratorler concrete classımızı kullanır.Aynı zamanda tüm dekoratörler object'mizin methodlarını kullanmak zorundadir(Interface implement edildi)
    {
        protected ICoffee _coffee;     // Bu yolla bir decorator başka bir decorator ile dekor edilebilir hale getirdik 
        public BaseDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }
        public void Hot() => _coffee.Hot();


    }
}
