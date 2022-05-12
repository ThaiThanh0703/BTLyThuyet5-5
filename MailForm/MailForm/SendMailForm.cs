using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace MailForm
{
    public partial class SendMailForm : Form
    {
        public SendMailForm()
        {
            InitializeComponent();
        }
        Attachment attch = null;
        private void btnAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                attch=new Attachment( ofd.FileName);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            attch = null;
           

            Guimail(tbFromEmail.Text, tbToEmail.Text, tbSubject.Text, rbBody.Text);

        }
        void Guimail(string from, string to, string subject, string message, Attachment file = null)
        {

            MailMessage mess = new MailMessage(from, to, subject, message);
            if (attch != null)
            {
                mess.Attachments.Add(attch);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            try 
            {
                client.Credentials = new NetworkCredential(tbFromEmail.Text, tbPassword.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            client.Send(mess);
        }

    }
}
