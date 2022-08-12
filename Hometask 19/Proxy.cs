using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    interface IDatabase
    {
        public void run();
    }

    class RealProject : IDatabase
    {
        private string _db;

        public RealProject(string db)
        {
            _db = db;
            load();
        }

        public void load()
        {
            Console.WriteLine("Loading data from " + _db + " Database...");
        }

        public void run()
        {
            Console.WriteLine("Running data from " + _db + " Database...\n");
        }
    }


    class ProxyProject : IDatabase
    {
        private string _password = "1234";
        private string _db;
        private RealProject realProject;

        public ProxyProject(string db)
        {
            _db = db;
        }

        public void run()
        {
            string line;
            Console.WriteLine("Enter the password to DB: ");
            while(true)
            {
                try
                {
                    line = Console.ReadLine();
                }
                catch (Exception)
                {
                    throw new Exception("An error occurred...");
                }
                if (!line.Equals(_password))
                {
                    Console.WriteLine("The password is wrong. Try one more time...");
                    continue;
                }
                break;
            }
            if (realProject == null)
            {
                realProject = new RealProject(_db);
            }
            realProject.run();
        }
    }
}
