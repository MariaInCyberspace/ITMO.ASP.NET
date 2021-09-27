﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public static string SetStatus(int age)
        {
            string status = "junior developer";
            if ((age > 2) && (age < 7))
                status = "middle developer";
            else if ((age >= 7) && (age < 15))
                status = "senior developer";
            else if ((age >= 15))
                status = "sensei";
            return status;
        }

        public static string ExeSwitch(string status)
        {
            string res;
            switch (status)
            {
                case "junior developer":
                    res = "You need to learn more!";
                    break;
                case "middle developer":
                    res = "You need to practice more!";
                    break;
                case "senior developer":
                    res = "You need to lead others!";
                    break;
                case "sensei":
                    res = "You need to teach others!";
                    break;
                default:
                    res = "I don't know what to do with you...";
                    break;
            }
            return res;
        }

        public static string GetFunction(double x1, double x2)
        {
            StringBuilder str = new StringBuilder();
            double x = x1;
            do
            {
                str.AppendFormat("x = {0:0.##} : y = {1:0.##}; <br>", x, Math.Pow(x, 3));
                x = x + 0.5;
            }
            while (x <= x2);
            return str.ToString();
        }

        public static bool GetFactorial(int n, out int answer)
        {
            int k;
            int f = 1;
            bool ok = true;

            try
            {
                checked
                {
                    for (k = 2; k <= n; k++)
                    {
                        f = f * k;
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }

        public static string ExeFactorial(int x)
        {
            int f;
            bool ok = StudyCsharp.GetFactorial(x, out f);
            if (ok)
            {
                return String.Format("The factorial of {0} is {1}", x, f);
            }
            else
            {
                return String.Format("Couldn't calculate the factorial of {0}", x);
            }
        }

        
    }
}