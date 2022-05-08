using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
