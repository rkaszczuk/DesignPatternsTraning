using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Command
{
    public interface IFileOperations
    {
        void ReadFile();
        void WriteFile();
    }
}
