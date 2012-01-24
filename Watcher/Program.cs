using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine;

namespace Develapp.Watcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            ICommandLineParser parser = new CommandLineParser(new CommandLineParserSettings(Console.Error));
            if (!parser.ParseArguments(args, options))
                Environment.Exit(1);

            //for testing only
            options.Targets = new List<string>() { @"C:\Test1\", @"C:\Test2" };

            Watcher watcher = new Watcher(options);

            foreach (string s in watcher.CompareTargets())
            {
                Console.WriteLine(s);
            }
            

            Environment.Exit(0);
        }
    }
}
