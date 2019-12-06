using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApp
{
    class Help
    {
        //Just a help class that displays information on switches provided.
        public string HelpInfo(string[] args)
        {
            var helpInfo = "";

            foreach (var arg in args)
            {
                if (arg == "-s" || arg == "-setup")
                {
                    helpInfo = "Use this to setup a local directory for your application";
                }

                if (arg == "-u" || arg == "-update")
                {
                    helpInfo = "Use this to update all of the applications you have setup.";
                }
            }

            return helpInfo;
        }
    }
}
