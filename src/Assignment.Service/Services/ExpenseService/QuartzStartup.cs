using Quartz.Impl;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Assignment.Infrastructure;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;
using Assignment.Api.Interfaces;
using Assignment.Api;
using Quartz.Impl.Calendar;

namespace Assignment.Service.Services.ExpenseService
{
    public class EmailJob : IJob
    {
        private readonly RaidenDBContext raidenDBContext;
        public EmailJob(RaidenDBContext raidenDBContext)
        {
            this.raidenDBContext = raidenDBContext;

        }
        public async Task Execute(IJobExecutionContext context)
        {
            Debug.WriteLine("Sending email at midnight...");
            var users = await raidenDBContext.ExpenseUsers.ToListAsync();
            foreach (var user in users)
            {
                var Ledger = await raidenDBContext.BudgetLedgers.Where(b => b.UserId == user.UserId && b.Type == "Monthly").OrderBy(c => c.CreatedAt).FirstOrDefaultAsync();
                if (Ledger == null) {
                    continue;
                }
                var category = await raidenDBContext.Categories.Where(c => c.LedgerId == Ledger.LedgerId && c.Name == "Fixed Expenses").FirstOrDefaultAsync();
                var fixedExpenses = await raidenDBContext.Expenses.Where(e => e.CategoryId == category.CategoryId && e.Type == "Fixed").ToListAsync();
                await SendMail(user.Email, "Monthly expenses Payment Remainder", fixedExpenses);
            }
        }

        private async Task SendMail(string toAdd,string subject,List<Expense> expenses) {
            string body = "Payemnts due this month are : ";
            foreach(var expense in expenses)
            {
                body += $"{expense.Name} : Rs. {expense.Amount} ";
            }
            MailMessage message = new MailMessage(Environment.GetEnvironmentVariable("PAVAN_EMAIL"), toAdd);
            message.Subject = subject;
            message.Body = body;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential(Environment.GetEnvironmentVariable("PAVAN_EMAIL"), Environment.GetEnvironmentVariable("PAVAN_EMAIL_PASS"));
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;
            client.Send(message);
            Debug.WriteLine("Sent email");
        }
    }
}
