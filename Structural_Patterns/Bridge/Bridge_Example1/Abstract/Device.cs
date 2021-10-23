using Structural_Patterns.Bridge.Bridge_Example1.Concrete;
using Structural_Patterns.Bridge.Bridge_Example1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Bridge.Bridge_Example1.Abstract
{
  public abstract   class Device
    {
        public  IPlaySoundDevice playSounddevice;
        public IPlayMusicDevice playMusicdevice;
        public Device()
        {

        }
        public Device(IPlaySoundDevice playSounddevice, IPlayMusicDevice playMusicdevice)
        {
            this.playMusicdevice = playMusicdevice;
            this.playSounddevice = playSounddevice;

        }
        public abstract string PlayMusic(Music music);
        
    }
}
