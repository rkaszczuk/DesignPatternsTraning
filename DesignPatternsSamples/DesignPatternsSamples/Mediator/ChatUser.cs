using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Mediator
{
    public abstract class ChatUser
    {
        private IChatMediator chatMediator;
        public string Nickname { get; set; }
        protected ChatUser(IChatMediator chatMediator)
        {
            this.chatMediator = chatMediator;
        }
        public void Send(string msg)
        {
            chatMediator.Send(msg, this);
        }
        public IChatMediator GetMediator()
        {
            return chatMediator;
        }
        public abstract void Recive(string msg);
    }
}
