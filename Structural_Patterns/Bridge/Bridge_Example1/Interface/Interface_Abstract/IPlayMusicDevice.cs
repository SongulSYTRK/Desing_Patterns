using Structural_Patterns.Bridge.Bridge_Example1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Bridge.Bridge_Example1.Interface
{
    public interface IPlayMusicDevice
    {
        string PlayMusic(Music music);
    }
}
