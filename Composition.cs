using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace
{
    class Composition
    {
        public class MainClass
        {
            void Main()
            {
                var dbMigrator = new DBMigrator(new Logger());
                var logger = new Logger();
                var installer = new Installer(logger);
                dbMigrator.Migrate();
                installer.Install();
            }
        }

        public class Installer
        {
            private Logger logger;

            public Installer(Logger logger)
            {
                this.logger = logger;
            }
            public void Install()
            {
                logger.Log("Installing the app");
            }
        }

        public class Logger
        {

            public void Log(string message)
            {
                Console.WriteLine("Your message is " + message);
            }
        }

        public class DBMigrator
        {
            private Logger logger;

            public DBMigrator(Logger logger)
            {
                this.logger = logger;
            }

            public void Migrate()
            {
                logger.Log("we are migrating");
            }
        }
    }
}
