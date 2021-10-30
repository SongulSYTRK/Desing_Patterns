using Behavioral_Pattern.Mediator.Mediator_Example2.Business.Abstract;
using Behavioral_Pattern.Mediator.Mediator_Example2.Business.Concrete;
using Behavioral_Pattern.Mediator.Mediator_Example2.Mediator.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behavioral_Pattern.Mediator.Mediator_Example2
{
    public partial class Mediator2Form : Form
    {
        public Mediator2Form()
        {
            InitializeComponent();
        }

        private void btnChatRoom_Click(object sender, EventArgs e)
        {
            ConcreteMediator chatroom = new ConcreteMediator();

            BaseChatUser User1 = new ChatUser1("User1");
            BaseChatUser User2 = new ChatUser1("User2");
            BaseChatUser User3 = new ChatUser1("User3");
            BaseChatUser User4 = new ChatUser2("User4");
            BaseChatUser User5 = new ChatUser2("User5");
            BaseChatUser User6 = new ChatUser2("User6");

            chatroom.Register(User1);
            chatroom.Register(User2);
            chatroom.Register(User3);
            chatroom.Register(User4);
            chatroom.Register(User5);
            chatroom.Register(User6);

            User1.SentMessage("User3", "hello !!! whatshapp ???");
        }
    }
}
