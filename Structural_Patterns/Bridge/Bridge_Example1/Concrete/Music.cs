using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Bridge.Bridge_Example1.Concrete
{
   public  class Music
    {
        public string  Name  { get; set; }
        public string Sound { get; set; }
        public Music(string Name, string Sound)
        {
            this.Name = Name;
            this.Sound = Sound;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
