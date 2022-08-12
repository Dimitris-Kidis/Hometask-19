using System;


// 1. Implement Proxy pattern ✅
// 2. Implement Decorator pattern ✅
// 3. Implement Facade pattern ✅
// 4. Law of Demeter ✅


namespace App
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 3.
            Singleton s = Singleton.Instance;
        }
    }
}

