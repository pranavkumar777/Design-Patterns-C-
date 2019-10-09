

using System;

namespace ProxyPattern
{
    abstract class InterestCalculation
    {
       public abstract void CalculateInterest(double principal, double n, double r);
    }

    class SimpleInterest : InterestCalculation
    {
        public override void  CalculateInterest(double principal, double n, double r)
        {
            Console.WriteLine("Interest=" + ((principal * n * r) / 100));
        }
    }

    class Proxy : InterestCalculation
    {
        SimpleInterest simpleInterest = new SimpleInterest();

        public override void CalculateInterest(double principal, double n , double r)
        {
            simpleInterest.CalculateInterest( principal,  n, r);
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
           
            Proxy proxy = new Proxy();
            proxy.CalculateInterest(5000, 2, 15);
            Console.ReadLine();
        }
    }
}
