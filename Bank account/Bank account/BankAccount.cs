using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    internal class BankAccount
    {
        //encapsulation: can't directly access from out side the class
        private const decimal MAX_AMOUNT = 1000; //constant value
        private readonly string accountnumber; //private: can only access with the same class (encapsulation)
        private decimal Balance;
        public decimal getBalance() //to recovery the value of balance using get
        {
            return Balance;
        }
        public string AccountNumber
        {

            get { return accountnumber; }
        }
        public BankAccount(string accountnumber)
        {
            this.accountnumber = accountnumber;

        }

        public void deposite(decimal amount)
        {    // adding to the Balance 
            if (amount <= 0) //can't add (-) value in amount
            {
                log($"invalid you Can't add {amount} to your Bank account");
                return;
            }
            Balance += amount;
            log($"successfull operation you add {amount} to your account");
        }
        public void withdraw(decimal amount)
        {
            if (amount <= 0) //can't withdraw nigative amount
            {
                log($"invalid operation you can't with Draw with negative amount");
                return;
            }
            if (amount > MAX_AMOUNT) //can't take out more than the maximum amount
            {
                log($"invalid Operation you Can't exceed your Maximum withDraw amount ");
                return;
            }
            if (amount > Balance) //can't take out more than the balance
            {
                log($"invalid operation you Can't withdraw {amount} from your account");
                return;
            }
            Balance -= amount; //it will subtract from baalance when the operation comes true
            log($"successful operation you have withdraw {amount} from your account");

        }

        public void log(string message) //to log a massage give account number, balance and the current time
        {
            string Timestamp = DateTime.Now.ToString(" yyyy-mm-dd  hh-mm "); //function to get the current time
            Console.WriteLine($" [{Timestamp}]  {message} ");
            Console.WriteLine($"your account number is {accountnumber} with balance is {Balance}");

        }


    }
}
