using System;

namespace SingletonPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Only one instance of Singleton class is created. 

            Singleton developer = Singleton.GetInstance();
            developer.print("developer");
            Singleton tester = Singleton.GetInstance();
            tester.print("tester");
            Console.ReadLine();
        }
    }
}
