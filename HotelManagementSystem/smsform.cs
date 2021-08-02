using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class smsform : Form
    {
        public smsform()
        {
            InitializeComponent();
        }

        USER user = new USER();
        WORKER worker = new WORKER();

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void smsform_Load(object sender, EventArgs e)
        {
            DataTable unReadMessages = worker.retrieveMsg(GLOBAL.GlobalUserId, 0);
            loadmessages.DataSource = unReadMessages;
            loadmessages.DisplayMember = "messsage";
            loadmessages.ValueMember = "mid";
        }

        private void loadmessages_MouseClick(object sender, MouseEventArgs e)
        {
            dispsms.Text = loadmessages.Text.ToString();
            worker.UpdateMsg(Convert.ToInt32(loadmessages.SelectedValue.ToString()));
        }

        private void refreshSms_Click(object sender, EventArgs e)
        {
            DataTable unReadMessages = worker.retrieveMsg(GLOBAL.GlobalUserId, 0);
            loadmessages.DataSource = unReadMessages;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            DataTable allMessages = worker.retrieveMsg(GLOBAL.GlobalUserId);

            loadmessages.DataSource = allMessages;

        }

        
    }
}
