using MailKit.Net.Smtp;
using MimeKit;
using Umbraco.Cms.Web.Common.Controllers;

namespace ICM.WebSites.Cms.Controllers;

public class EmailController(IWebHostEnvironment _hostEnvironment) : UmbracoApiController
{
    //private readonly IWebHostEnvironment _hostEnvironment = hostEnvironment;

    public string Send(string email, string name, string phone)
    {
        // var emailMessage = new MimeMessage();
        //
        // emailMessage.From.Add(new MailboxAddress("Your Name", "your-email@example.com"));
        // emailMessage.To.Add(new MailboxAddress("", "info.gr@icmsolutions.gr"));
        // emailMessage.Subject = "Contact request from the www.icmsolutions.gr website";
        //
        // var path = Path.Combine(_hostEnvironment.ContentRootPath, "assets/icmsolutions/templates/contact-us.html");
        // var template = await System.IO.File.ReadAllTextAsync(path);
        //
        //
        //
        // var bodyBuilder = new BodyBuilder
        // {
        //     HtmlBody = @"<p><strong>Contact request from the www.icmsolutions.gr website</strong></p>
        //          <p>Name: " + name + @"</p>
        //          <p>Email: " + email + @"</p>
        //          <p>Phone: " + phone + @"</p>"
        // };
        //
        // emailMessage.Body = bodyBuilder.ToMessageBody();
        //
        // using (var client = new SmtpClient())
        // {
        //     await client.ConnectAsync("smtp.example.com", 587, false);
        //     await client.AuthenticateAsync("your-email@example.com", "your-password");
        //     await client.SendAsync(emailMessage);
        //
        //     await client.DisconnectAsync(true);
        // }
        //
        // await Task.Delay(3000);

        
        return "success";
    }
}