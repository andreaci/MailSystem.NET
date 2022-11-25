using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ActiveUp.Net.Mail;

namespace WindowsFormsApp1
{
    public class MailRepository
    {
        private Imap4Client _client = null;

        public MailRepository(string mailServer, int port, bool ssl)
        {
            if (ssl)
                Client.ConnectSsl(mailServer, port);
            else
                Client.Connect(mailServer, port);
        }

        public async Task<string> LoginOAuth2(string user, string tenantId, string clientId, string clientSecret)
        {
            return await Client.LoginOAuth2(user, tenantId, clientId, clientSecret);
        }

        public IEnumerable<Message> GetAllMails(string mailBox)
        {
            return GetMails(mailBox, "ALL").Cast<Message>();
        }

        public IEnumerable<Message> GetUnreadMails(string mailBox)
        {
            return GetMails(mailBox, "UNSEEN").Cast<Message>();
        }

        protected Imap4Client Client
        {
            get
            {
                if (_client == null)
                    _client = new Imap4Client();
                return _client;
            }
        }

        private MessageCollection GetMails(string mailBox, string searchPhrase)
        {
            Mailbox mails = Client.SelectMailbox(mailBox);
            MessageCollection messages = mails.SearchParse(searchPhrase);
            return messages;
        }

        Mailbox _mb;
        public void ActivateMailBox(string mailBox)
        { //var test = Client.Mailboxes;
          //foreach (Mailbox folder in Client.Mailboxes)
          //{
          // //Console.WriteLine("[folder] {0}", folder.);
          //}
            Client.SubFolders = false;
            _mb = Client.SelectMailbox(mailBox);

            for (int x = _mb.MessageCount; x > 0; x--)
            {
                Message email = GetMessage(x);
                System.Diagnostics.Debug.WriteLine(email.Subject);
            }
        }
        internal Message GetMessage(int index)
        {
            return _mb.Fetch.MessageObject(index);
        }
    }
}