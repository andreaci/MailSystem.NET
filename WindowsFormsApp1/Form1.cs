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

            string tenantId = "APP TENANTID";
            string client_id = "APP CLIENTID";
            string client_secret = "APP SECRET";

            await mailRep.LoginOAuth2("lyrahelpcc@softeam.it", tenantId, client_id, client_secret);
            mailRep.ActivateMailBox("INBOX");

        }
    }
}
