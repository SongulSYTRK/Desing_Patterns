using Structural_Patterns.Bridge.Bridge_Example1.Abstract;
using Structural_Patterns.Bridge.Bridge_Example1.Interface;
using Structural_Patterns.Bridge.Bridge_Example1.Interface.Interface_Concert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns.Bridge.Bridge_Example1.Concrete
{
    public class ComputerHF:Device
    {
        public ComputerHF() // kullanlıkla ve fizzy uygulamasıyla çalışan bir nesne ürettik .İstedğimiz şekilde concrete sınıflar oluşturabilir
        {
            playSounddevice = new Headphone();
            playMusicdevice = new Fizy();

        }

        public override string PlayMusic(Music music)
        {
            {
                string Music_Sound = playMusicdevice.PlayMusic(music) + playSounddevice.Playsound();
                return Music_Sound;

            }
        }
    }
}
