using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MailRepository temp = new MailRepository("outlook.office365.com", 993, true, "****@****.it", "****");
            //MailRepository temp = new MailRepository("outlook.office365.com", 993, true, "*****@*****.it", "*********");
        }

        private async void simpleButton1_Click(object sender, EventArgs e)
        {
            MailRepository mailRep = new MailRepository("outlook.office365.com", 993, true);

            string tenantId = "**********************";
            string client_id = "**********************";
            string client_secret = "**********************";

            mailRep.Authenticated += MailRep_Authenticated;
            mailRep.Authenticating += MailRep_Authenticating;

            bool res = await mailRep.LoginOAuth2("lyrahelpcc@softeam.it", tenantId, client_id, client_secret);
            if (res)
            {
              mailRep.ActivateMailBox("INBOX");
            }
        }

        private void MailRep_Authenticating(object sender, ActiveUp.Net.Mail.AuthenticatingEventArgsBase e)
        {
            this.Invoke(new Action(() =>
            {
                memoEdit1.Text += e.Message + Environment.NewLine;
            }));
        }

        private void MailRep_Authenticated(object sender, ActiveUp.Net.Mail.AuthenticatedEventArgsBase e)
        {
            this.Invoke(new Action(() =>
            {
                memoEdit1.Text += e.Message + Environment.NewLine; ;
            }));
        }
    }
}
