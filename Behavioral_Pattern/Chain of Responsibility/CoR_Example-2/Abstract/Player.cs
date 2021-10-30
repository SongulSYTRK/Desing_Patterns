using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2.Interface
{
   public  abstract class Player
    {
        protected Player _nextplayer;
        public Player NextPlayer { set => _nextplayer = value; }
        public abstract void Handler(string filetype);
           
    }
}
