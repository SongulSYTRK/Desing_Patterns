using Structural_Patterns.Bridge.Bridge_Example1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Bridge.Bridge_Example1.Interface.Interface_Concert
{
    public class Fizy:IPlayMusicDevice
    {


        public string PlayMusic(Music music) => "play music with fizy";
      
    }
}
