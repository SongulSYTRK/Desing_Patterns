using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Decorator.Decorator_Example2.Model.Abstract
{
   public abstract  class BaseStudent
    {
        public int StudentId { get; set; }
        public string  Fullname  { get; set; }
        public string  Departmant { get; set; }
        public abstract  decimal RecordAmount { get; set; }
    }
}
