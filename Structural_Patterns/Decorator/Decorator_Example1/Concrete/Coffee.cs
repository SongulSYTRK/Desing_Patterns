using Structural_Patterns.Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Structural_Patterns.Decorator.Abstract
{
    public class Coffee : ICoffee  // çekirdek nesnemizi oluşturduk bunun üzerinde eklemeler süslememeler yapağız
    {
        private string  CoffeeName { get; set; }
        
        private CoffeeSize CoffeeSize { get; set; }
        public Coffee()
        {

            this.CoffeeName = CoffeeName;
            this.CoffeeSize = CoffeeSize.Large;
           
        }
        public void Hot() => MessageBox.Show( "We have only hot coffee");
       
    }
}
