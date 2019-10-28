using Commands;
using System.Collections.Generic;

namespace Base
{
    /// <summary>
    /// Base class that contains methods and attributes commons.
    /// </summary>
    public abstract class BaseCommand
    {
        private readonly string name;
        public List<Command> commandList;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Value to set Base Name.</param>
        public BaseCommand(string name)
        {
            this.name = name.ToLower();
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
        /// Get name value.
        /// </summary>
        /// <returns>string with name value.</returns>
        public string GetName()
        {
            return name;
        }
    }
}
