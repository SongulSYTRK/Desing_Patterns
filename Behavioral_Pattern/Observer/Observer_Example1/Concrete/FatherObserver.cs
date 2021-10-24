using Behavioral_Pattern.Observer.Observer_Example1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern.Observer.Observer_Example1.Concrete
{
   public  class FatherObserver : IObserver
    {
        public string Update() => "Your childs exam announced. We gave information to father ";
    }
}
