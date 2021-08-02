using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class CheckIn_UC : UserControl
    {
        public CheckIn_UC() => InitializeComponent();


        WORKER worker = new WORKER();

        private void CheckIn_UC_Load(object sender, EventArgs e)
        {
            checkInDate.Value = DateTime.Now;
            checkOutDate.Value = DateTime.Now;

            firstnameBox.Focus();
            errorText.Visible = false;
            receiptBindingSource.DataSource = new List<Receipt>();

            roomType.DataSource = worker.getRoomTypes();
            roomType.DisplayMember = "roomtype";
            roomType.ValueMember = "id";

            roomAllocate.DataSource = worker.getRooms(GLOBAL.GlobalRoomId, 0);
            roomAllocate.DisplayMember = "room";
            roomAllocate.ValueMember = "room";
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void proceedToCheckout_Click(object sender, EventArgs e)
        {

            string paymentType = "Cash";

            if (cashPayment.Checked == true)
            {
                paymentType = "Cash";
            }
            else if (crptPayment.Checked == true)
            {
                paymentType = "Crypto";
            }
            else if (ePayment.Checked == true)
            {
                paymentType = "POS";
            }

            if (firstnameBox.Text.Trim() != "" && lastnameBox.Text.Trim() != "" && telephoneBox.Text.Trim() != "" && NOKBox.Text.Trim() != "" && residentsBox.Text.Trim() != "" && billDisplay.Text.Trim() != "")
            {
                if (worker.AddCustomer(firstnameBox.Text.Trim(),
                    lastnameBox.Text.Trim(),
                    telephoneBox.Text.Trim(),
                    NOKBox.Text.Trim(),
                    roomAllocate.SelectedValue.ToString(),
                    checkInDate.Value.ToShortDateString(),
                    checkOutDate.Value.ToShortDateString(),
                    Convert.ToInt32(residentsBox.Text.Trim().ToString()),
                    paymentType))
                {


                    Receipt receipt = new Receipt() { id = 123, pType = paymentType, roomType = roomType.SelectedValue.ToString() };
                    receiptBindingSource.Add(receipt);
                    using (printReceipt print = new printReceipt(receiptBindingSource.DataSource as List<Receipt>, billDisplay.Text.Trim(), DateTime.Now.ToShortDateString()))
                    {
                        print.ShowDialog();
                    }

                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                errorText.Visible = true;
            }
        }

        private void roomType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GLOBAL.setRoomId(Convert.ToInt32(roomType.SelectedValue.ToString()));
            roomAllocate.DataSource = worker.getRooms(GLOBAL.GlobalRoomId, 0);
            roomAllocate.DisplayMember = "room";
            roomAllocate.ValueMember = "room";
            billDisplay.Text = calculateBill().ToString();
            timer1.Enabled = true;
        }

       



        public int calculateBill()
        {
            int charge = 0;
            int bill;

            if (roomType.SelectedValue.ToString() == "1")
            {
                charge = 22470;
            }
            else if (roomType.SelectedValue.ToString() == "2")
            {
                charge = 43520;
            }
            else if (roomType.SelectedValue.ToString() == "3")
            {
                charge = 65120;
            }
            else if (roomType.SelectedValue.ToString() == "4")
            {
                charge = 28860;
            }
            else if (roomType.SelectedValue.ToString() == "5")
            {
                charge = 49000;
            }

            int days = Convert.ToInt32(checkOutDate.Value.DayOfYear.ToString()) - Convert.ToInt32(checkInDate.Value.DayOfYear.ToString());


            return bill = charge * days;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            billDisplay.Text = calculateBill().ToString();
        }

        

        
    }

        
}
