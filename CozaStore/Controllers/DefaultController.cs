using CozaStore.Models;
using CozaStore.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;
using MailKit.Net.Smtp;
using MimeKit;
using System.Xml.Linq;


namespace CozaStore.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IProductService _productService;

        public DefaultController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DetailComponent(string id)
        {
            return ViewComponent("_DefaultProductDetailComponent", new { id = id });
        }

        [HttpGet]
        public PartialViewResult _FooterPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult _FooterPartial(AdminMailViewModel model)
        {
            model.Subject = "Coza Store | Haber Bülteni Aboneliğiniz Onaylandı";

            var discountCupon = "X9L2K7MB";
            var discountRate = 25;

            model.DiscountCupon = discountCupon;

            model.Message =
            $@"Merhaba,

            Coza Store'un özel kampanyalarından ve en yeni ürünlerinden haberdar olmanız için haber bültenimize başarıyla abone oldunuz.

            🎁 Size özel bir indirim kuponumuz var!

            Kupon Kodu: {model.DiscountCupon}
            İndirim: %{discountRate}
            Geçerlilik: Tüm ürünlerde geçerlidir

            Kuponunuzu hemen kullanarak alışverişin keyfini çıkarın! 👉 https://www.cozastore.com

            Eğer herhangi bir sorunuz varsa, bizimle iletişime geçmekten çekinmeyin.

            Keyifli alışverişler dileriz!

            Sevgilerle,  
            Coza Store Ekibi";


            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("Coza Store Admin", "karakulakcevdet@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = model.Message;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = model.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
            client.Authenticate("karakulakcevdet@gmail.com", "ctdf eteu wcil nloi");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return RedirectToAction("Index");
        }
    }
}
