using Creational_Pattern.Factory.Factory_Example2.Abstract;
using Creational_Pattern.Factory.Factory_Example2.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Pattern.Factory.Factory_Example2.Decorator.Concrete
{
    public class AddColor : BaseFurnitureDecorator
    {
        private BaseFurniture _baseFurniture;
        public AddColor(BaseFurniture baseFurniture) : base(baseFurniture)
        {
            this._baseFurniture = baseFurniture;
        }
        public string NewColor() => "=> Added new color ";
        public override string ShipForm() => "We decored in Turkey" +  NewColor();
        
    }
}
