using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            //Göndericek Kişinin Bilgileri
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin", "ahmetfahrioncu25@gmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);

            //Alıcak olan kişinin bilgileri
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", mailRequest.ReceiverMail);

            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body= bodyBuilder.ToMessageBody();

            mimeMessage.Subject = mailRequest.Subject;

            SmtpClient client = new SmtpClient();

            client.Connect("smtp.gmail.com",587,false);

            client.Authenticate("ahmetfahrioncu26@gmail.com", "msyv ozmn pkdm acgu");

            client.Send(mimeMessage);

            client.Disconnect(true);

            return View();
        }
    }
}
