using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
   public class Singleton
    {
        private static Singleton instance = null;
        private int counter=0;
        private Singleton()
        {
            counter++;
            Console.WriteLine(counter + "instance created");
        }

        /// <summary>
        /// instance of Singleton class is created here
        /// </summary>
        /// <returns>instance</returns>

        public static Singleton GetInstance()
        {
            
                if (instance == null)
                {
                    instance = new Singleton();
                  
                }
            
            return instance;
        }

        public void print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
