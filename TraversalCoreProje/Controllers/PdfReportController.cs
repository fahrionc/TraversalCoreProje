using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");

            document.Add(paragraph);

            document.Close();
            return File("/pdfreports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");

            pdfPTable.AddCell("Sıla");
            pdfPTable.AddCell("Koçyiğit");
            pdfPTable.AddCell("11111111111");

            pdfPTable.AddCell("Ahmet Fahri");
            pdfPTable.AddCell("Öncü");
            pdfPTable.AddCell("22222222222");

            pdfPTable.AddCell("Ibo");
            pdfPTable.AddCell("Kaymak");
            pdfPTable.AddCell("33333333333");

            document.Add(pdfPTable);

            document.Close();
            return File("/pdfreports/dosya2.pdf", "application/pdf", "dosya2.pdf");
        }
    }
}

















//ITextSharp'ta UTF-8 Encoding desteği yok o yüzden kendi Arial fontumuzu (ya da istediğimiz bilgisayarımızda bulunan bir fontu) tanımlayıp onu kullandığımız dökümana implemente etmek gerekiyor.

//örnek : 
////Arial Font'unun Bilgisayarda Bulunduğu Yeri String Olarak Alıyoruz.
//string Arial_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "Arial.ttf");

////iTextSharp için bir BaseFont örneği oluşturuyoruz.
//BaseFont bf = BaseFont.CreateFont(Arial_TFF, BaseFont.IDENTITY_H, true);

////Yine dökümanda kullanabilmek için bu sefer ana font örneği oluşturuyoruz. Bu örneklemede font büyüklüğünü
////ve diğer attributelerini de değiştirebilirsiniz.
//Font f = new Font(bf, 12, Font.NORMAL);

////Döküman için başlık paragrafı oluşturuyoruz, paragrafın sonuna bir f yani Font overloadı ekleyerek
////Türkçe karakter desteklemesini ve istediğimiz fontu kullanmasını sağlıyoruz.
//Paragraph paragraph = new Paragraph("Traversal - Statik Müşteri Raporu\n\n", f);

//PdfPTable pdfPTable = new PdfPTable(3);

////Burada ise AddCell overloadında direkt olarak string ve font belirlenmediğinden
////new Phrase diyerek bunun bir font alabilmesini sağlıyoruz.
//pdfPTable.AddCell(new Phrase("Müşteri Adı", f));
//pdfPTable.AddCell(new Phrase("Müşteri Soyadı", f));
//pdfPTable.AddCell(new Phrase("Müşteri TC Kimlik", f));

////Bunu tüm tablodaki elementlere uygulamak lazım. Ben burada
////bir döngü de kullanabilirdim ama amaç temel mantığı
////anlatmak olduğundan onun için ekstra bir şey yapmadım.
//pdfPTable.AddCell(new Phrase("İsim", f));
//pdfPTable.AddCell(new Phrase("Soyisim", f));
//pdfPTable.AddCell(new Phrase("1234567890", f));