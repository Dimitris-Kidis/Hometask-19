using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Singleton
    {
        private static volatile Singleton _instance = null;
        private static readonly object _padlock = new object();

        private Singleton()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Singleton has been created!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Init();
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                        return _instance;
                    }
                }
                return _instance;
            }
        }

        public static void Init()
        {
            // 1.
            Console.ForegroundColor = ConsoleColor.Green;
            IDatabase project = new ProxyProject("https://database.com/appHello.db");
            project.run();
            Console.ForegroundColor = ConsoleColor.White;

            // 2.
            Console.ForegroundColor = ConsoleColor.Cyan;
            IDress mannequins = new Mannequins();
            mannequins = new Clothes(mannequins);
            Clothes clothes = new Clothes(mannequins);
            clothes.GetDressed();
            Console.ForegroundColor = ConsoleColor.White;



        }
    }
}
