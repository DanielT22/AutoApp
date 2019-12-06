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
            //Initialize the startup method so we can plug in whatever we needon the main method.
            var initialize = new AutoApp();
            initialize.Startup(args);
        }
        void Startup(string[] args)
        {
            //Initializing the classes
            var help = new Help();
            var setup = new Setup();
            var fileSystem = new FileSystem();

            //We tell the user to run the setup here first if they haven't done it yet, otherwise they won't be able to update their apps.
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

            //The help menu takes precedence over all other commands and provides information for any arguments entered.
            if (args.Contains<string>("-h") || args.Contains<string>("-help"))
            {
                Console.WriteLine(help.HelpInfo(args));
            }

            //We check each argument entered. Right now we only really use one argument at a time, so this might need more planning.
            foreach (var arg in args)
            {
                if (arg == "-s" || arg == "-setup")
                {
                    if (setup.CheckIfSetupDone(SetupDone) == true)
                    {
                        //Need a way to clear the app settings.
                        Console.WriteLine("You've already setup at least one application, do you want to clear your config?");
                    }
                    setup.AddApplicationName();
                }

                if (arg == "-u" || arg == "-update")
                {
                    //We need a way to copy one app or all apps configured.
                    fileSystem.CopyFolderLocally(args[1]);
                }

                if (arg == "-a" || arg == "-add")
                {
                    //We can add an app using -a followed by the AppName. We need a check to confirm -a is followed by an app name.
                    //This checks if it already has a config.
                    setup.DoesSettingExist(arg);
                    var updateApp = Properties.Settings.Default.Properties;
                    setup.AddApplicationName();
                }

                if (arg == "-i" || arg == "-info")
                {
                    help.HelpInfo(args);
                    //Call the information class. We need this provide information to the user.
                }

                else
                {
                    //Just a catch for unknown parameters.
                    Console.WriteLine("Unknown parameters. Type '-h' for a list of commands.");
                }
            }
        }
    }
}
