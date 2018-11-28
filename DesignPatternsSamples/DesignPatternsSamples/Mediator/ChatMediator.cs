using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Mediator
{
    public class ChatMediator : IChatMediator
    {
        private List<ChatUser> users = new List<ChatUser>();
        public void AddUser(ChatUser user)
        {
            users.Add(user);
        }
        public void Send(string msg, ChatUser sender)
        {
            Console.WriteLine($"{sender.Nickname} SENT {msg}");
            foreach(var user in users)
            {
                if (user != sender)
                {
                    user.Recive(msg);
                }
            }
        }
    }
}
