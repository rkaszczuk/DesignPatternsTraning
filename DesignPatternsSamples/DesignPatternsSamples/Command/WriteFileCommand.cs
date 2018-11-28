using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsSamples.Command
{
    public class WriteFileCommand : ICommandExecutor
    {
        private IFileOperations fileOperations;
        public string FileName { get; set; }
        public WriteFileCommand(IFileOperations fileOperations)
        {
            this.fileOperations = fileOperations;
        }

        public void Execute()
        {
            this.fileOperations.WriteFile();
        }
    }
}
