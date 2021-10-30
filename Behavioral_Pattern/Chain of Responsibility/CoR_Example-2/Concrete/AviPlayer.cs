using Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Chain_of_Responsibility.CoR_Example_2.Concrete
{ 
        public class AviPlayer : Player
    {
        private AviPlayer() { }
        private static AviPlayer _aViPlayer;
        public static AviPlayer GetAviPlayer() // singleton design pattern
        {
            if (_aViPlayer != null)
            {
                _aViPlayer = new AviPlayer();
            }
            return _aViPlayer;
        }
        public override void Handler(string filetype)
         {
               if(filetype.EndsWith(".avi"))
               {
                   MessageBox.Show($"{filetype} playing ");
              
               }
               else
               {
                       MessageBox.Show("you write wrong filetype");
               }
         }
    }
}
