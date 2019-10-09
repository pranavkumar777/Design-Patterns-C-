using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{

    //Subsystem1
    class CheckBalance
    {
        UserModel userModel = UserModel.GetInstance();
        public void displayBalance()
        {
            Console.WriteLine(userModel.amount);
        }

        public static bool availability(int x)
        {
            UserModel userModel = UserModel.GetInstance();
            if (userModel.amount >= x)
                return true;
            return false;
        }

    }

    //Subsystem2
    class AddCash
    {
        public void add()
        {
            UserModel userModel = UserModel.GetInstance();
            Console.WriteLine("enter amount");
            int x = Convert.ToInt32(Console.ReadLine());
            userModel.amount += x;
                  
        }
    }

    //Subsystem3
    class DeductCash
    {
        public void deduct()
        {
            UserModel userModel = UserModel.GetInstance();
            Console.WriteLine("enter amount");
            int x = Convert.ToInt32(Console.ReadLine());
            if(CheckBalance.availability(x))
            {
                userModel.amount -= x;
            }

        }
    }

    
    // Simplified interface for the client hiding the complex subsystem
    interface IATM
    {
        void WithdrawCash();
        void Deposit();
    }


    class ATM : IATM
    {
        CheckBalance checkBalance;
        AddCash addCash;
        DeductCash deductCash;

        public ATM()
        {
            checkBalance = new CheckBalance();
            addCash = new AddCash();
            deductCash = new DeductCash();
            }

        public void Deposit()
        {
            addCash.add();
            Console.WriteLine("DO you want to display balance 1. YES 2.NO");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y == 1)
            {
                checkBalance.displayBalance();
            }
        }

        public void WithdrawCash()
        {
            deductCash.deduct();
            Console.WriteLine("DO you want to display balance 1. YES 2.NO");
            int y = Convert.ToInt32(Console.ReadLine());
            if (y == 1)
            {
                checkBalance.displayBalance();
            }
        }
    }

    //Model Class
    public class UserModel
    {
        private static UserModel instance = null;
        public int amount { get; set; } = 5000;

        private UserModel()
        {

        }

        public static UserModel GetInstance()
        {
            if (instance == null)
            {
                instance = new UserModel();
            }
            return instance;
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {

            ATM atm = new ATM();
            atm.Deposit();
            atm.WithdrawCash();
            Console.Read();
        }
    }
}
