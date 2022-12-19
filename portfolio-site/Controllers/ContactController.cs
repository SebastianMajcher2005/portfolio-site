using FluentEmail.Core;
using FluentEmail.Smtp;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IActionResult> SendEmail()
        {
            var sender = new SmtpSender(() => new SmtpClient("smtp.gmail.com")
            {
                UseDefaultCredentials = false,
                Port = 587,
                Credentials = new NetworkCredential("sebastianmajcher2005@gmail.com", "fpyewhbthwypxpsu"),
                EnableSsl = true,
            });

            Email.DefaultSender = sender;

            var email = Email
                .From("sebastianmajcher2005@gmail.com", "sebus")
                .To("sebastianmajcher2005@gmail.com", "Seba")
                .Subject("Thanks!")
                .Body("hahahha");

            await email.SendAsync();

            return RedirectToAction("Index", "Contact");
        }
    }
}
