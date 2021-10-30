using Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2.Concrete
{
    public class MP4Player : Player
    {
        private MP4Player() { }
        private static MP4Player _mP4Player;
        public static MP4Player GetMp4Player() // singleton design pattern
        {
            if (_mP4Player != null)
            {
                _mP4Player = new MP4Player();
            }
            return _mP4Player;
        }
        public override void Handler(string filetype)
        {
            if (filetype.EndsWith(".mp4"))
            {
                MessageBox.Show($"{filetype} playing ");
            }
            else
            {
                if (_nextplayer != null)
                {
                    _nextplayer.Handler(filetype);
                }
            }

        }

    }
}
