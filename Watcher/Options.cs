using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine;
using CommandLine.Text;

namespace Develapp.Watcher
{
    public sealed class Options
    {
        [Option("t", "test", HelpText = "Perform all the actions in a test mode without changing any files")]
        public bool Test { get; set; }
        [Option("x", "execute", HelpText = "Execute. Sync changes in watched files")]
        public bool Execute { get; set; }
        [Option("l", "list", HelpText = "List matching files")]
        public bool List { get; set; }

        [OptionList("t", "targets", ';', HelpText="Watched locations separated by ;")]
        public List<string> Targets { get;set;}

        public Options()
        {
            Test = true;
            Execute = false;
            List = false;
            Targets = new List<string>();
        }

        [HelpOption(HelpText = "Dispaly this help text.")]
        public string GetUsage()
        {
            var help = new HelpText("watcher", "0.1");
            help.AdditionalNewLineAfterOption = true;
            help.Copyright = new CopyrightInfo("Develapp", 2012, 2012);
            help.AddPreOptionsLine("This is free software. You may redistribute copies of it under the terms of");
            help.AddPreOptionsLine("the MIT License <http://www.opensource.org/licenses/MIT>.");
            help.AddPreOptionsLine("Usage: SampleApp -rMyData.in -wMyData.out --calculate");
            help.AddPreOptionsLine(string.Format("       SampleApp -rMyData.in -i -j{0} file0.def file1.def", 9.7));
            help.AddPreOptionsLine("       SampleApp -rMath.xml -wReport.bin -o *;/;+;-");
            help.AddOptions(this);
            

            return help;
        }

    }
}
