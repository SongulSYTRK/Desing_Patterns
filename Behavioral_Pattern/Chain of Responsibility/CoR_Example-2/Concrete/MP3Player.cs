using Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2.Concrete;
using Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2.Abstract
{
    public class MP3Player : Player
    {
        private MP3Player() { }
        private static MP3Player _mP3Player;
        public static MP3Player GetMp3Player() // singleton design pattern
        {
            if(_mP3Player != null)
            {
                _mP3Player = new MP3Player();
            }
            return _mP3Player;
        }

        public override void Handler(string filetype)
        {
            if(filetype.EndsWith( ".mp3"))
            {
                
                MessageBox.Show($"{filetype} playing ");
            }
            else
            {
                if(_nextplayer != null )
                {
                    _nextplayer.Handler(filetype);
                }
                
            }
        }

       
    }
}
