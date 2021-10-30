using Behavioral_Pattern.Mediator.Mediator_Example2.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Mediator.Mediator_Example2.Business.Concrete
{
   public class ChatUser2:BaseChatUser
    {
        public ChatUser2(string name ): base(name)
        {

        }

        public override void ReceiveMessage(string receiver, string message)
        {
            MessageBox.Show($" {Name} taken {message } from {receiver}");
        }
    }
}
