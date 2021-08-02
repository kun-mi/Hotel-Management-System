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
    public partial class loadsms : Form
    {
        public loadsms()
        {
            InitializeComponent();
        }

        USER user = new USER();
        WORKER worker = new WORKER();

        private void loadsms_Load(object sender, EventArgs e)
        {

            DataTable messages = worker.retrieveMsg(GLOBAL.GlobalUserId, 0);

            smslist.DataSource = messages;
            smslist.DisplayMember = "messsage";
            smslist.ValueMember = "mid";

        }

        private void msgdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            DataTable messages = worker.retrieveMsg(GLOBAL.GlobalUserId, 0);

            smslist.DataSource = messages;
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showallsms_Click(object sender, EventArgs e)
        {
            DataTable messages = worker.retrieveMsg(GLOBAL.GlobalUserId);

            smslist.DataSource = messages;
        }

        private void smslist_MouseClick(object sender, MouseEventArgs e)
        {
            showmsg.Text = smslist.Text.ToString();
            worker.UpdateMsg(Convert.ToInt32(smslist.SelectedValue.ToString()));
        }
    }
}
