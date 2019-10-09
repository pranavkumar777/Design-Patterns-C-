using System;


namespace ChainOfResponsibilityPattern
{

    abstract class Approver
    {
        abstract public void deduct(int amount);

        protected Approver successor;

        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }
    }

    class DeductionLessAmount : Approver
    {
        public override void deduct(int amount)
        {
            if (amount < 2000)
            {
                Console.WriteLine("success");
            }
            else if (successor != null)
            {
                successor.deduct(amount);
            }
        }
    }

    class DeductionHighAmount : Approver
    {
        public override void deduct(int amount)
        {
            Console.WriteLine("enter pin");
            string x = Console.ReadLine();
            Console.WriteLine("success");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            DeductionLessAmount dl = new DeductionLessAmount();
            DeductionHighAmount dh = new DeductionHighAmount();
            dl.SetSuccessor(dh);
            dl.deduct(1500);
            dl.deduct(5000);   
            Console.ReadLine();
        }
    }
}
