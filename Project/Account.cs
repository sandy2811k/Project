using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Account
    {
        private long A_num;
        private string A_type;
        private int Balance;
        private static int HomeLone = 8;


        public Account()
        {
            this.A_num = 0;
            this.A_type = "Saving";
            this.Balance = 0;

        }
        public Account(long anum, string atype, int baln)
        {
            this.A_num = anum;
            this.A_type = atype;
            this.Balance = baln;

        }

        public static int getHomeLone()
        {
            return HomeLone;

        }
        public string show()
        {
            return $"Account No:-{A_num} ,Type={A_type} ,Balance={Balance} ";
        }
        public string WithdrawMoney(int amount)

        {
            string msg = "Eroor";
            if (Balance > amount)
            {
                Balance = Balance - amount;
                msg = $"Balance After Withdrawing Money={Balance}\n";
            }
            return msg;
        }
        public string DepositeMoney(int amount)
        {
            Balance = Balance + amount;
            return $"Balance after Depositing Money ={Balance}\n";
        }
    }
}
        
    

   

    
