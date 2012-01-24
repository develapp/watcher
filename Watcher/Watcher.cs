using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Develapp.Watcher
{
    public class Watcher
    {
        public Options Options { get; private set; }

        public Watcher(Options options)
        {
            Options = options;
        }

        public List<string> CompareTargets()
        {
            //use options.Targets and list all matching files
            throw new NotImplementedException();
        }
        
    }
}
