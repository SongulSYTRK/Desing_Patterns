using Creational_Pattern.Factory.Factory_Example2.Abstract;
using Creational_Pattern.Factory.Factory_Example2.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Factory.Factory_Example2.Factory
{
   public  class FactoryFurniture
    {
        public BaseFurniture Factoryfurniture(decimal amount)
        {
            if (amount <= 1000 && amount >= 100)
                return new Seat();

            else if (amount <= 10000 && amount > 1000)
                return new Bakery();
            else
                return new Chair();
            
        }
        
    }
}
