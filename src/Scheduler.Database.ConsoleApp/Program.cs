using System;
using CommandLine;
using Scheduler.Database.Core;

namespace Scheduler.Database.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SchedulerDbContext();

            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
                {
                    if (o.Verbose)
                    {
                           Console.WriteLine($"Verbose output enabled. Current Arguments: -v {o.Verbose}");
                           Console.WriteLine("Quick Start Example! App is in Verbose mode!");
                    }
                    else
                    {
                        Console.WriteLine($"Current Arguments: -v {o.Verbose}");
                        Console.WriteLine("Quick Start Example!");
                    }
                    if (o.DropDatabase)
                    {
                        context.Database.EnsureDeleted();
                    }
                    if (o.CreateDatabase)
                    {
                        context.Database.EnsureCreated();
                    }

                });
        }
    }
}
