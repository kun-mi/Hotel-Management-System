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
    public partial class homeScreen : Form
    {
        public homeScreen()
        {
            InitializeComponent();
        }

        

        private void homeScreen_Load(object sender, EventArgs e)
        {

            
            
        }

        private void time_Tick(object sender, EventArgs e)
        {
            
        }

        private void checkInButton_Click(object sender, EventArgs e)
        {
            


        }

        private void ManageButton_Click(object sender, EventArgs e)
        {

        }

        private void NewCustomer_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            checkIn_UC3.Enabled = true;
            checkIn_UC3.Visible = true;
            roomsH1.SendToBack();
            checkIn_UC3.BringToFront();
            roomsH1.Visible = false;
            roomsH1.Enabled = false;
        }


        private void CheckIn_UC3_Load(object sender, EventArgs e)
        {

        }

        private void RoomsBtn_Click(object sender, EventArgs e)
        {
            roomsH1.Visible = true;
            roomsH1.Enabled = true;
            checkIn_UC3.SendToBack();
            roomsH1.BringToFront();
            checkIn_UC3.Enabled = false;
            checkIn_UC3.Visible = false;

        }
    }
}
