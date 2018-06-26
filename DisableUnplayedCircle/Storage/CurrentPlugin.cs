using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectrum.API.Configuration;
using Spectrum.API.Logging;

namespace Distance.Translator
{
    public static class CurrentPlugin
    {
        public static void initialize()
        {
            Log = new Logger("DisableUnplayedCircle.log");
            Log.WriteToConsole = true;
        }

        public static Logger Log;
    }
}
