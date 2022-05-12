using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit.Net;

namespace MailForm
{
    public partial class ReceiveMailForm : Form
    {
        public ReceiveMailForm()
        {
            InitializeComponent();
            lstMail.Columns.Add("Email", 135);
            lstMail.Columns.Add("From", 200);
            lstMail.Columns.Add("Time", 130);
            lstMail.View = View.Details;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (ImapClient rcvMail= new ImapClient())
            {
                try
                {
                     rcvMail.Connect("imap.gmail.com",993,true);
                     rcvMail.Authenticate(tbEmail.Text,tbPassword.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    tbEmail.Clear();
                    tbPassword.Clear();
                    return;
                }
                var inbox = rcvMail.Inbox;
                inbox.Open(MailKit.FolderAccess.ReadOnly);
                lbTotalMail.Text=inbox.Count.ToString();
                lbRecentMail.Text=inbox.Count.ToString();

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message=inbox.GetMessage(i);

                    ListViewItem name= new ListViewItem(message.Subject);
                //    ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                    ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.ToString());
                    name.SubItems.Add(message.From.ToString());
                    name.SubItems.Add(date);
                    
                    lstMail.Items.Add(name);

                }

                rcvMail.Disconnect(true);
                
            }
        }

      
    }
}
