using ICM.WebSites.Cms.Settings;
using MailKit.Net.Smtp;
using MimeKit;
using Umbraco.Cms.Web.Common.Controllers;

namespace ICM.WebSites.Cms.Controllers;

public class EmailController(IWebHostEnvironment hostEnvironment, IConfiguration configuration) : UmbracoApiController
{
    public async Task<string> Send(string email, string name, string phone)
    {
        var emailSettings = new Dictionary<string, string>();        
        configuration.GetSection("ICM:EmailSettings").Bind(emailSettings);

        var smtpSettings = new SmtpSettings();
        configuration.GetSection("ICM:SmtpSettings").Bind(smtpSettings);
        
        var emailMessage = new MimeMessage();

        emailMessage.From.Add(new MailboxAddress("www.icmsolutions.gr", emailSettings["www.icmsolutions.gr"]));
        emailMessage.To.Add(new MailboxAddress("www.icmsolutions.gr", emailSettings["www.icmsolutions.gr"]));
        emailMessage.Subject = "Contact request from the www.icmsolutions.gr website";

        var templatePath = Path.Combine(hostEnvironment.ContentRootPath, "wwwroot/assets/icmsolutions/templates/contact-us.html");
        var templateBody = await System.IO.File.ReadAllTextAsync(templatePath);
        var messageBody = templateBody.Replace("{name}", name).Replace("{email}", email).Replace("{phone}", phone);
        
        var bodyBuilder = new BodyBuilder
        {
            HtmlBody = messageBody
        };
        emailMessage.Body = bodyBuilder.ToMessageBody();

        using var client = new SmtpClient();
        await client.ConnectAsync(smtpSettings.Host, smtpSettings.Port, smtpSettings.UseSsl);
        if (!string.IsNullOrWhiteSpace(smtpSettings.Username))
        {
            await client.AuthenticateAsync(smtpSettings.Username, smtpSettings.Password);
        }
        await client.SendAsync(emailMessage);
        await client.DisconnectAsync(true);

        return "success";
    }
}