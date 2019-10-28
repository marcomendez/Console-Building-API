using Base;
using System;
using Util;

namespace Root
{
    /// <summary>
    /// Root Command.
    /// Main Class to execute command API.
    /// </summary>
    public class RootCommand : BaseCommand
    {
        public RootCommand(string name) : base(name)
        {
        }

        /// <summary>
        /// Execite a  command line from console.
        /// </summary>
        /// <param name="args">Command line to execute.</param>
        /// <returns> True if the command line is correct, False otherwise.</returns>
        public bool Run(string args)
        {
            var commandLines = args.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            return commandList.VerifyArgs(commandLines, GetName());
        }

        /// <summary>
        /// Execite a command line from console.
        /// </summary>
        /// <param name="args">Command line to execute.</param>
        /// <returns> True if the command line is correct, False otherwise.</returns>
        public bool Run(string[] args)
        {
            return commandList.VerifyArgs(args, GetName());
        }   
    }
}
