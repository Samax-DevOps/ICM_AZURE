using MailKit.Net.Smtp;
using MimeKit;
using Umbraco.Cms.Web.Common.Controllers;

namespace ICM.WebSites.Cms.Controllers;

public class EmailController : UmbracoApiController
{
    public async Task<string> Send(string email, string name, string phone)
    {
        var emailMessage = new MimeMessage();

        emailMessage.From.Add(new MailboxAddress("Your Name", "your-email@example.com"));
        emailMessage.To.Add(new MailboxAddress("", email));
        emailMessage.Subject = "Contact request from the www.icmsolutions.gr website";
        emailMessage.Body = new TextPart("plain") 
            { Text = "message" };

        using (var client = new SmtpClient())
        {
            await client.ConnectAsync("smtp.example.com", 587, false);
            await client.AuthenticateAsync("your-email@example.com", "your-password");
            await client.SendAsync(emailMessage);

            await client.DisconnectAsync(true);
        }

        await Task.Delay(3000);
        // Send email
        
        return "success";
    }
}