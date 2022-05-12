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
            //lstMail.Columns.Add("Email", 135);
            //lstMail.Columns.Add("From", 200);
            //lstMail.Columns.Add("Time", 130);
            //lstMail.View = View.Details;
            
        }
        ImapClient rcvMail;
        List<MailData> MailList;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using ( rcvMail= new ImapClient())
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
                MailList= new List<MailData>();

                for (int i = 0; i < inbox.Count; i++)
                {
                    MailList.Add(new MailData() {Email=inbox.GetMessage(i).Subject, From=inbox.GetMessage(i).From.ToString(),Date= inbox.GetMessage(i).Date.ToString(),ID=i ,content= inbox.GetMessage(i).TextBody.ToString() });
                    

                    ListViewItem name= new ListViewItem(MailList[i].ID.ToString());
                    //    ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                    //    ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.ToString());
                    name.SubItems.Add(MailList[i].Email);
                    name.SubItems.Add(MailList[i].From);
                    name.SubItems.Add(MailList[i].Date);
                    
                    lstMail.Items.Add(name);

                }

               // rcvMail.Disconnect(true);
                
            }
        }

      

      

      

        private void lstMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(MailList[(Convert.ToInt16(lstMail.SelectedItems[0].SubItems[0].Text))].content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
    public class MailData
    {
        public string Email   { get; set; }
        public string From    { get; set; }
        public string Date    { get; set; }
        public int    ID      { get; set; }
        public string content { get; set; }
    }
}
