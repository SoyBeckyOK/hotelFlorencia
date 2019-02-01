using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace hotelFlorencia.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmailSendPage : ContentPage
	{
		public EmailSendPage ()
		{
			InitializeComponent ();
		}

        private async void ButtonSend_Clicked(object sender, EventArgs e)
        {
            List<string> recipients = new List<string>
            {
                EntryRecipients.Text
            };

         await  SendEmail(EntrySubject.Text, EntryBody.Text, recipients);
        }
        public async Task SendEmail(string subject, string body, List<string> recipients)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    To = recipients,
                    //Cc = ccRecipients,
                    //Bcc = bccRecipients
                };
                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException fbsEx)
            {
                // Email is not supported on this device
            }
            catch (Exception ex)
            {
                // Some other exception occurred
            }
        }
    }
}
