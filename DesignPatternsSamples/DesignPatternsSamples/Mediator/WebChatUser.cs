using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Mediator
{
    public class WebChatUser : ChatUser
    {
        public WebChatUser(IChatMediator chatMediator) : base(chatMediator)
        {
        }

        public override void Recive(string msg)
        {
            Console.WriteLine($"{Nickname} recived message: [{msg}]");
        }
    }
}
