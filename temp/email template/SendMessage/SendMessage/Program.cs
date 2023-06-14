// See https://aka.ms/new-console-template for more information

using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

var message = new MimeMessage ();
message.From.Add (new MailboxAddress ("Vit Mihaescu", "vitalii.mihaescu@icmcapital.co.uk"));
message.To.Add (new MailboxAddress ("Vit Mihaescu", "vit.mihaescu@gmail.com"));
message.To.Add (new MailboxAddress ("Vit Mihaescu", "vitalii.mihaescu@icmcapital.co.uk"));
message.Subject = "Email Template Test";

message.Body = new TextPart ("html") {
    Text = File.ReadAllText(args[0])
};

using var client = new SmtpClient ();
await client.ConnectAsync("mail.icmcapital.co.uk", 25, SecureSocketOptions.None);
await client.AuthenticateAsync("vitalii.mihaescu@icmcapital.co.uk", "wxYgql4YlWTv6zb2yDZL");

await client.SendAsync(message);
await client.DisconnectAsync(true);
