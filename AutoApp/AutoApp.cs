using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoApp
{
    class AutoApp
    {
        //public Help HelpInit;
        //public Setup setup;
        //public AutoApp autoApp;

        public bool SetupDone { get; set; }

        //void Initialize()
        //{
        //   // _help = var autoApp = new Setup();
        //   _help =  new Help();
        //}


        static void Main(string[] args)
        {
            var initialize = new AutoApp();
            initialize.Startup(args);
        }
        void Startup(string[] args)
        {
            var help = new Help();
            var setup = new Setup();

            if (setup.CheckIfSetupDone(SetupDone) == false)
            {
                Console.WriteLine("You have not setup any applications yet. You can do this using -setup.");
            }
            else
            {
                Console.WriteLine("You're already setup. You may add another application by using -add.");
                //Maybe add an option to clear your configuration.
            }

            if (args.Length == 0)
            {
                Console.WriteLine("Type '-h' for a list of commands.");
                return;
            }

            if (args.Contains<string>("-h") || args.Contains<string>("-help"))
            {
                Console.WriteLine(help.HelpInfo(args));
            }

            foreach (var arg in args)
            {
                if (arg == "-s" || arg == "-setup")
                {
                    if (setup.CheckIfSetupDone(SetupDone) == true)
                    {
                        Console.WriteLine("You've already setup at least one application, do you want to clear your config?");
                    }
                    //Call the setup class
                }

                if (arg == "-u" || arg == "-update")
                {
                    //Call the update class
                }

                if (arg == "-a" || arg == "-add")
                {
                    setup.AddApplicationName();
                    //Call the add application class
                }

                if (arg == "-i" || arg == "-info")
                {
                    help.HelpInfo(args);
                    //Call the information class
                }

                else
                {
                    Console.WriteLine("Unknown parameters. Type '-h' for a list of commands.");
                }
            }
        }
    }
}
