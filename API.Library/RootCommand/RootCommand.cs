using Base;
using Commands;
using System.Collections.Generic;

namespace Root
{
    /// <summary>
    /// Root Command.
    /// Main Class to execute command API.
    /// </summary>
    public class RootCommand : BaseAPI
    {
        public List<Command> commandList;

        /// <summary>
        ///  Constructor.
        /// </summary>
        /// <param name="name"></param>
        public RootCommand(string name) : base(name)
        {
            commandList = new List<Command>();
        }

        /// <summary>
        /// Adds a Command.
        /// </summary>
        /// <param name="command">Command to add as child.</param>
        public void AddChild(Command command)
        {
            commandList.Add(command);
        }

        /// <summary>
        /// Execite a  command line from console.
        /// </summary>
        /// <param name="commandLine">Command line to execute.</param>
        /// <returns> True if the command line is correct, False otherwise.</returns>
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

        /// <summary>
        /// Verify if Command exist in Command list.
        /// </summary>
        /// <param name="commandLines">Array Command line string.</param>
        /// <param name="index">Index to find command in array.</param>
        /// <returns>True if command exist in Command list.</returns>
        private bool ExistCommand(string[] commandLines, int index)
        {
            return commandList.Exists(command => command.GetName().Equals(commandLines[index]));
        }
    }
}
