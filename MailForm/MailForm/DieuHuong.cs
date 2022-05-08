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
    public partial class DieuHuong : Form
    {
        public DieuHuong()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMailForm sendm= new SendMailForm();
            sendm.Show();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            ReceiveMailForm receivem= new ReceiveMailForm();
            receivem.Show();
        }
    }
}
