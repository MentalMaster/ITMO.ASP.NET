﻿using Lab01.ex02_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.ex02_MVC.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string hel)
        {
            string res = ExeCircle();
            return res;
        }
        public string ExeEnum()
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            string res1 = String.Format("Тип банковского счета {0}",
                goldAccount);
            string res2 = String.Format("Тип банковского счета {0}",
                platinumAccount);
            string res = res1 + "<p>" + res2;
            return res;
           
        } 
        public string ExeStruct()
        {
            BankAccount goldBankAccount;

            goldBankAccount.accType = AccountType.Checking;
            goldBankAccount.accBal = (decimal)3200.00;
            goldBankAccount.accNo = 123;         
            string res = String.Format("Информация о банковском счете: {0}", 
                goldBankAccount);
            return res;
        }
        public string ExeFactorial(int x)
        {
            int f; 
            bool ok = StudyCsharp.Factorial(x, out f);
            if (ok) 
                return String.Format("Факториал числа {0} равен {1} ", x, f); 
            else
                return "Невозможно вычислить факториал";
        }
        public string ExeTriangle()
        {
            Triangle tr1 = new Triangle(3, 5, 6);
            string sq1 = String.Format("Площадь фигуры {0} равна: {1:0.##}",
                tr1.Name, tr1.Area);
            return sq1;
        }
        public string ExeCircle() 
        {
            Circle cir1 = new Circle(3);
            string sq = String.Format("Площадь фигуры {0} равна: {1:0.##}", 
            cir1.Name, cir1.Area);
            return sq;
        }

    } 
}
