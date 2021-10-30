using Behavioral_Pattern.Mediator.Mediator_Example2.Business.Abstract;
using Behavioral_Pattern.Mediator.Mediator_Example2.Mediator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern.Mediator.Mediator_Example2.Mediator.Concrete
{
    public class ConcreteMediator : BaseMediator
    {
        private Dictionary<string, BaseChatUser> baseChatUsers = new Dictionary<string, BaseChatUser>();
        public override void Register(BaseChatUser baseChatUser)
        {
            if(baseChatUsers.ContainsValue(baseChatUser)==false)
            {
                baseChatUsers[baseChatUser.Name] = baseChatUser;
            }
            baseChatUser.ConcreteMediator = this;
            
        }

        public override void SendMessage(string receiver, string sender, string message)
        {
            BaseChatUser baseChatUser = baseChatUsers[sender];
            if(baseChatUser!= null)
            {
                baseChatUser.ReceiveMessage(receiver, message);
            }
        }
    }
}
