using System;
using CommandLine;

namespace Scheduler.Database.ConsoleApp
{
    public class Options
    {
        [Option('d', "drop", Required = false, HelpText = "Drop database model.")]
        public bool DropDatabase { get; set; }

        [Option('c', "create", Required = false, HelpText = "Create database model.")]
        public bool CreateDatabase { get; set; }

        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }
    }
}
