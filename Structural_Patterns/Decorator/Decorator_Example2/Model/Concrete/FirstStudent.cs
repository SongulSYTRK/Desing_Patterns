using Structural_Patterns.Decorator.Decorator_Example2.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Decorator.Decorator_Example2.Model.Concrete
{
    public class FirstStudent : BaseStudent
    {
        public override decimal RecordAmount { get; set; }
    }
}
