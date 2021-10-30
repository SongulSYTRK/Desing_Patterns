using Behavioral_Pattern.Mediator.Mediator_Example2.Mediator.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Mediator.Mediator_Example2.Business.Abstract
{
    public abstract class BaseChatUser
    {
        public BaseChatUser(string name )
       
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public ConcreteMediator ConcreteMediator { get; set; }
        public void SentMessage(string sender  , string message )
        {
            ConcreteMediator.SendMessage(sender, Name, message);
        }

        public abstract void ReceiveMessage(string receiver, string message);
      

    }
}
