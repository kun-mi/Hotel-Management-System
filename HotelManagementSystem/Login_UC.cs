using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HotelManagementSystem
{
    public partial class Login_UC : UserControl
    {
        public Login_UC()
        {
            InitializeComponent();
        }

        WORKER worker = new WORKER();

        private void Login_UC_Load(object sender, EventArgs e)
        {
            dateTimeDisplay.Text = DateTime.Now.ToString();
            DataTable userTable = worker.retrieveUser(GLOBAL.GlobalUserId);
            usernameText.Text = userTable.Rows[0][0].ToString();
            usernameDisp.Show();
            byte[] loadPicture = (byte[])userTable.Rows[0][1];
            MemoryStream dp = new MemoryStream(loadPicture);
            try
            {
                userPicture.Image = Image.FromStream(dp);
            }
            catch (Exception)
            {
                userPicture.Image = userPicture.ErrorImage;    
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimeDisplay.Text = DateTime.Now.ToString();
        }

        private void inbox_Click(object sender, EventArgs e)
        {
            newMsgNoti.Visible = false;
            smsform smsf = new smsform();
            smsf.ShowDialog();
        }
             
        private void timer2_Tick(object sender, EventArgs e)
        {
            DataTable unreadSms = worker.retrieveMsg(GLOBAL.GlobalUserId, 0);
            if (unreadSms.Rows.Count > 0)
            {
                newMsgNoti.Visible = true;
            }
            else
            {
                newMsgNoti.Visible = false;
            }
        }
    }
}
