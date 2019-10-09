using System;

namespace BridgePattern
{
   
         // abstract class
        abstract class InterestCalculation
        {
            public  ICalculationImplementor implementor;
            public abstract void calculate();
            public double principal;
            public double n;
            public double r;
        }

    //redefined abstraction
        class RedefinedAbstraction : InterestCalculation
        {
            public override void calculate()
            {

                implementor.CalculateInterest(principal, n, r);
              
            }

        }

    //interface - Implementor
        interface ICalculationImplementor
        {
            void CalculateInterest(double principal, double n, double r);
          
        }

    //Concrete Implementor1
    class SimpleInterestCalculation : ICalculationImplementor
    {
        public void CalculateInterest(double principal, double n, double r)
        {
            Console.WriteLine("Simple Interest=" + ((principal * n * r) / 100));
        }      
    }

    //concrete implementor2
    class CompoundInterestCalculation : ICalculationImplementor
    {
        public void CalculateInterest(double principal, double n, double r)
        {
            Console.WriteLine("Compound Interest=" + principal * (Math.Pow((1 + r / 100), n) - 1));
        
        }
    }

   
     
    class Program
    {
        static void Main(string[] args)
        {
            RedefinedAbstraction interestCalculation = new RedefinedAbstraction();
            interestCalculation.principal = 5000;
            interestCalculation.n = 3;
            interestCalculation.r = 10;

            interestCalculation.implementor = new SimpleInterestCalculation();
            interestCalculation.calculate();

            interestCalculation.implementor = new CompoundInterestCalculation();
            interestCalculation.calculate();
            Console.Read();



        }
    }
}
