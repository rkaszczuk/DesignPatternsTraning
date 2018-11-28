using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeasingSystemToRefactor.Parser
{
    public interface ISerializer
    {
        string Parse<T>(T obj);
    }
}
