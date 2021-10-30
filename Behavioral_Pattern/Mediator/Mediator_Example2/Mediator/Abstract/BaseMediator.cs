using Behavioral_Pattern.Mediator.Mediator_Example2.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_Pattern.Mediator.Mediator_Example2.Mediator.Abstract
{
 public abstract   class BaseMediator
    {
        public abstract void Register(BaseChatUser baseChatUser);
        public abstract void SendMessage(string receiver, string sender , string message );
    }
}
