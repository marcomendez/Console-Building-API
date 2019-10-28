using Commands;
using System;
using System.Collections.Generic;

namespace Util
{
    public static class Parser
    {

        public static bool VerifyArgs(this List<Command> commandList, string[] args, string rootCommandName)
        {
            if (commandList == null)
            {
                throw new ArgumentNullException(nameof(commandList));
            }
            if (args[0].ToLower() != rootCommandName.ToLower())
            {
                return false;
            }
            else
            {
                for (int index = 1; index < args.Length; index++)
                {
                    if (!commandList.Exists(item => item.GetName().ToLower().Equals(args[index].ToLower())))
                    {
                        return false;
                    }
                }
                return true;
            }
        }

    }
}
