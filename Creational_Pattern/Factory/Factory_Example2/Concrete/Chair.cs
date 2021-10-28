using Creational_Pattern.Factory.Factory_Example2.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Factory.Factory_Example2.Concrete
{
    public class Chair : BaseFurniture
    {
        public override string ShipForm() => "Made in Germen ";
       
    }
}
