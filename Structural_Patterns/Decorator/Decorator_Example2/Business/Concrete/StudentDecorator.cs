using Structural_Patterns.Decorator.Decorator_Example2.Business.Abstract;
using Structural_Patterns.Decorator.Decorator_Example2.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Decorator.Decorator_Example2.Business.Concrete
{
    public class StudentDecorator : BaseDecoratorStudent
    {
        private BaseStudent _baseStudent;
        public StudentDecorator(BaseStudent baseStudent) :base(baseStudent)
        {
            this._baseStudent = baseStudent;
        }
        public decimal Discount;
        public override decimal RecordAmount 
        { 
            get => _baseStudent.RecordAmount*Discount/100;
            set { } 
        }
    }
}
