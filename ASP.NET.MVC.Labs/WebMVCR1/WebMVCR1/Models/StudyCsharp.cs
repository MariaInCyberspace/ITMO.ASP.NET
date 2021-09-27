using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCR1.Models
{
    public enum AccountType
    {
        Checking, 
        Deposit 
    }

    public struct BankAccount 
    { 
        public long accNo; 
        public decimal accBal; 
        public AccountType accType;

        public override string ToString() 
        { 
            string res = $"Account number {accNo}, balance {accBal}, type {accType}"; 
            return res; 
        }
    }
    public class StudyCsharp
    {
        public static string ExeEnum()
        {
            AccountType goldAccount = AccountType.Checking;
            AccountType platinumAccount = AccountType.Deposit;
            string res1 = String.Format("Account type {0}", goldAccount);
            string res2 = String.Format("Account type {0}", platinumAccount);
            return res1 + "<p>" + res2;
        }

        public static string ExeStruct()
        {
            BankAccount goldBankAccount;
            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accNo = 123;
            // string res = String.Format("Account number {0}, balance {1}, type {2}", goldBankAccount.accNo, goldBankAccount.accBal, goldBankAccount.accType);
            string res = String.Format("Bank account information: {0}", goldBankAccount);
            return res;
        }
    }
}