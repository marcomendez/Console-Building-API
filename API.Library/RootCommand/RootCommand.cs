using Base;
using Commands;
using System.Collections.Generic;

namespace Root
{
    public class RootCommand : BaseAPI
    {
        public List<Command> commandList;
        public RootCommand(string name) : base(name)
        {
            commandList = new List<Command>();
        }

        public void AddCommand(Command addCommand)
        {
            commandList.Add(addCommand);
        }

        public bool Run(string commandLine)
        {
            var commandLines = commandLine.ToLower().Split(' ');

            if(commandLines[0].ToLower() == this.GetName().ToLower())
            {
                for (int index = 1; index < commandLines.Length; index++)
                {
                    if (!ExistCommand(commandLines, index))
                    {
                        return false;
                    }

                }
                return true;
               
            }
            return false;  
        }

        private bool ExistCommand(string[] commandLines, int index)
        {
            return commandList.Exists(command => command.GetName().Equals(commandLines[index]));
        }
    }
}
