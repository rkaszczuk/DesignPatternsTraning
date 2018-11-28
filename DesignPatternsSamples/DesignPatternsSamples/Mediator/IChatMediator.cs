using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Mediator
{
    public interface IChatMediator
    {
        void Send(string msg, ChatUser sender);
    }
}
