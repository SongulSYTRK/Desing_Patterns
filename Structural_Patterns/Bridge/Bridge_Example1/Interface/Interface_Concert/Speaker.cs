using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Bridge.Bridge_Example1.Interface.Interface_Concert
{
    public class Speaker: IPlaySoundDevice
    {
        public string Playsound() => "you are listening with Headphone";
    }
}
