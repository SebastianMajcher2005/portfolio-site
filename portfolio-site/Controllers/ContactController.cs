using FluentEmail.Core;
using FluentEmail.Smtp;
using Microsoft.AspNetCore.Mvc;
using portfolio_site.Models;
using System.Net;
using System.Net.Mail;

namespace portfolio_site.Controllers
{
    public class ContactController : Controller
    {
        [Route("contact")]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> SendEmail(Mail mail)
        {
            var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
            {
                UseDefaultCredentials = false,
                Port = 587,
                Credentials = new NetworkCredential("sebastianmajcher2005@gmail.com", "fpyewhbthwypxpsu"),
                EnableSsl = true,
            });

            Email.DefaultSender = sender;
            if(ModelState.IsValid)
            {
                var email = Email
               .From("sebastianmajcher2005@gmail.com", mail.Name)
               .To("sebastianmajcher2005@gmail.com", "Sebastian")
               .Subject(mail.Email)
               .Body(mail.Message);

                await email.SendAsync();

                return RedirectToAction("Index", "Contact");
            }       
            else
            {
                return View("Index");
            }
        }
    }
}
