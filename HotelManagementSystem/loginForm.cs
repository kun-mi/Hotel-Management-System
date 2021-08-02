using System;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }


        WORKER worker = new WORKER();
        USER user = new USER();


        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            blankname.Visible = false;
            blankpassword.Visible = false;
            wrongusernamedisp.Visible = false;


            if (usernameBox.Text.Trim() != "")
            {
                if ( passwordBox.Text.Trim() != "")
                {
                    if (adminCheck.Checked == true)
                    {

                        MessageBox.Show("Admin has been disabled!");
                        /*if (worker.verifUser(usernameBox.Text.Trim(), passwordBox.Text.Trim(), 1))
                        {
                           
                            this.Hide();
                            homeScreen hms = new homeScreen();
                            hms.Show();
                        }
                        else
                        {
                            wrongusernamedisp.Visible = true;
                            wrongusernamedisp.BringToFront();
                            usernameBox.Clear();
                            usernameBox.Focus();
                            passwordBox.Clear();

                        }*/
                    }
                    else
                    {
                        if (worker.verifUser(usernameBox.Text.Trim(), passwordBox.Text.Trim(), 0))
                        {
                         
                            this.Hide();
                            homeScreen hms = new homeScreen();
                            hms.Show();
                        }
                        else
                        {
                            wrongusernamedisp.Visible = true;
                            wrongusernamedisp.BringToFront();
                            usernameBox.Clear();
                            usernameBox.Focus();
                            passwordBox.Clear();

                        }
                    }
                }
                else
                {
                    blankpassword.Visible = true;
                    blankpassword.BringToFront();
                    passwordBox.Focus();
                }
            }
            else
            {
                blankname.Visible = true;
                usernameBox.Focus();
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                blankname.Visible = false;
                blankpassword.Visible = false;
                wrongusernamedisp.Visible = false;


                if (usernameBox.Text.Trim() != "")
                {
                    if (passwordBox.Text.Trim() != "")
                    {
                        if (adminCheck.Checked == true)
                        {
                            if (worker.verifUser(usernameBox.Text.Trim(), passwordBox.Text.Trim(), 1))
                            {

                                this.Hide();
                                homeScreen hms = new homeScreen();
                                hms.Show();
                            }
                            else
                            {
                                wrongusernamedisp.Visible = true;
                                wrongusernamedisp.BringToFront();
                                usernameBox.Clear();
                                usernameBox.Focus();
                                passwordBox.Clear();

                            }
                        }
                        else
                        {
                            if (worker.verifUser(usernameBox.Text.Trim(), passwordBox.Text.Trim(), 0))
                            {

                                this.Hide();
                                homeScreen hms = new homeScreen();
                                hms.Show();
                            }
                            else
                            {
                                wrongusernamedisp.Visible = true;
                                wrongusernamedisp.BringToFront();
                                usernameBox.Clear();
                                usernameBox.Focus();
                                passwordBox.Clear();

                            }
                        }
                    }
                    else
                    {
                        blankpassword.Visible = true;
                        blankpassword.BringToFront();
                        passwordBox.Focus();
                    }
                }
                else
                {
                    blankname.Visible = true;
                    usernameBox.Focus();
                }
            }
        }

        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                passwordBox.Focus();
            }
        }

    }
}
