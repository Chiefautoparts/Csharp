using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BankofDojo.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace BankofDojo.Controllers
{
    public class TransactionController : Controller
    {
        private AccountContext _context;
        public TransactionController(AccountContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Account/{TransactionNum}")]
        public IActionResult Index(int TransactionNum)
        {
            if(TransactionNum != (int)HttpContext.Session.GetInt32("userID"))
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Login", "Register");
            }
               List<Transaction> UserTransactions = _context.Transactions.Where(transaction => transaction.userID == TransactionNum).OrderByDescending(Transaction => Transaction.CreatedAt).ToList();ViewBag.UserTransactions = UserTransactions;
               Console.WriteLine(ViewBag.UserTransactions.Count);
               ViewBag.Balance = 0;
               foreach (Transaction instance in UserTransactions)
               {
                   ViewBag.Balance += instance.Amount;
               }
               if (ViewBag.Balance <= 0)
               {
                   ViewBag.Minimim = 0;
               }
               else
               {
                   ViewBag.Minimum = 0 - ViewBag.Balance;
               }
               ViewBag.AccountUser = _context.Users.SingleOrDefault(user => user.userID == TransactionNum).FirstName;
               return View();
        }
        //[HttpPost]
        //[Route("")]
    }
}