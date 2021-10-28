using Structural_Patterns.Decorator.Decorator_Example2.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Decorator.Decorator_Example2.Business.Abstract
{
   public abstract  class BaseDecoratorStudent:BaseStudent 
    {
        private BaseStudent _baseStudent;
        public BaseDecoratorStudent(BaseStudent baseStudent)
        {
            this._baseStudent = baseStudent;
        }
    }
}
