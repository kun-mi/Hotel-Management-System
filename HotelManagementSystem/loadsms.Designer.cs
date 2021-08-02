namespace HotelManagementSystem
{
    partial class loadsms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadsms));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.displaysmsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.allsmsPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.smsmainpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.showmsg = new Guna.UI2.WinForms.Guna2TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.refresh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.showallsms = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.messagesTableAdapter1 = new HotelManagementSystem.hotelDataSetTableAdapters.messagesTableAdapter();
            this.smslist = new System.Windows.Forms.ListBox();
            this.displaysmsPanel.SuspendLayout();
            this.allsmsPanel.SuspendLayout();
            this.smsmainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 35;
            this.guna2Elipse2.TargetControl = this.allsmsPanel;
            // 
            // displaysmsPanel
            // 
            this.displaysmsPanel.BackColor = System.Drawing.Color.Azure;
            this.displaysmsPanel.Controls.Add(this.showallsms);
            this.displaysmsPanel.Controls.Add(this.showmsg);
            this.displaysmsPanel.Controls.Add(this.allsmsPanel);
            this.displaysmsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displaysmsPanel.Location = new System.Drawing.Point(0, 0);
            this.displaysmsPanel.Name = "displaysmsPanel";
            this.displaysmsPanel.ShadowDecoration.Parent = this.displaysmsPanel;
            this.displaysmsPanel.Size = new System.Drawing.Size(543, 328);
            this.displaysmsPanel.TabIndex = 1;
            // 
            // allsmsPanel
            // 
            this.allsmsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.allsmsPanel.Controls.Add(this.smslist);
            this.allsmsPanel.Controls.Add(this.guna2ImageButton1);
            this.allsmsPanel.Controls.Add(this.refresh);
            this.allsmsPanel.Location = new System.Drawing.Point(365, 3);
            this.allsmsPanel.Name = "allsmsPanel";
            this.allsmsPanel.ShadowDecoration.Parent = this.allsmsPanel;
            this.allsmsPanel.Size = new System.Drawing.Size(175, 322);
            this.allsmsPanel.TabIndex = 0;
            // 
            // smsmainpanel
            // 
            this.smsmainpanel.BackColor = System.Drawing.Color.Azure;
            this.smsmainpanel.Controls.Add(this.displaysmsPanel);
            this.smsmainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smsmainpanel.Location = new System.Drawing.Point(0, 0);
            this.smsmainpanel.Name = "smsmainpanel";
            this.smsmainpanel.ShadowDecoration.Parent = this.smsmainpanel;
            this.smsmainpanel.Size = new System.Drawing.Size(543, 328);
            this.smsmainpanel.TabIndex = 0;
            // 
            // showmsg
            // 
            this.showmsg.Animated = true;
            this.showmsg.BorderRadius = 18;
            this.showmsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.showmsg.DefaultText = "";
            this.showmsg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.showmsg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.showmsg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.showmsg.DisabledState.Parent = this.showmsg;
            this.showmsg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.showmsg.Enabled = false;
            this.showmsg.FillColor = System.Drawing.Color.Gainsboro;
            this.showmsg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showmsg.FocusedState.Parent = this.showmsg;
            this.showmsg.Font = new System.Drawing.Font("TechnicBold", 9.749999F);
            this.showmsg.ForeColor = System.Drawing.Color.Black;
            this.showmsg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showmsg.HoverState.Parent = this.showmsg;
            this.showmsg.Location = new System.Drawing.Point(4, 7);
            this.showmsg.Multiline = true;
            this.showmsg.Name = "showmsg";
            this.showmsg.PasswordChar = '\0';
            this.showmsg.PlaceholderText = "";
            this.showmsg.SelectedText = "";
            this.showmsg.ShadowDecoration.Parent = this.showmsg;
            this.showmsg.Size = new System.Drawing.Size(356, 267);
            this.showmsg.TabIndex = 6;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this.smslist;
            // 
            // refresh
            // 
            this.refresh.AnimatedGIF = true;
            this.refresh.BackColor = System.Drawing.Color.Transparent;
            this.refresh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.refresh.CheckedState.Parent = this.refresh;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image1")));
            this.refresh.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.refresh.HoverState.Parent = this.refresh;
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageRotate = 0F;
            this.refresh.ImageSize = new System.Drawing.Size(22, 22);
            this.refresh.Location = new System.Drawing.Point(4, 283);
            this.refresh.Name = "refresh";
            this.refresh.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.PressedState.Image1")));
            this.refresh.PressedState.ImageSize = new System.Drawing.Size(19, 19);
            this.refresh.PressedState.Parent = this.refresh;
            this.refresh.Size = new System.Drawing.Size(28, 33);
            this.refresh.TabIndex = 7;
            this.refresh.UseTransparentBackground = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.AnimatedGIF = true;
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(22, 22);
            this.guna2ImageButton1.Location = new System.Drawing.Point(141, 283);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.PressedState.Image")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(19, 19);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(28, 33);
            this.guna2ImageButton1.TabIndex = 8;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // showallsms
            // 
            this.showallsms.Active = false;
            this.showallsms.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.showallsms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.showallsms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showallsms.BorderRadius = 0;
            this.showallsms.ButtonText = "Show All";
            this.showallsms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showallsms.DisabledColor = System.Drawing.Color.Gray;
            this.showallsms.Iconcolor = System.Drawing.Color.Transparent;
            this.showallsms.Iconimage = ((System.Drawing.Image)(resources.GetObject("showallsms.Iconimage")));
            this.showallsms.Iconimage_right = null;
            this.showallsms.Iconimage_right_Selected = null;
            this.showallsms.Iconimage_Selected = null;
            this.showallsms.IconMarginLeft = 0;
            this.showallsms.IconMarginRight = 0;
            this.showallsms.IconRightVisible = true;
            this.showallsms.IconRightZoom = 0D;
            this.showallsms.IconVisible = true;
            this.showallsms.IconZoom = 90D;
            this.showallsms.IsTab = false;
            this.showallsms.Location = new System.Drawing.Point(257, 286);
            this.showallsms.Name = "showallsms";
            this.showallsms.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.showallsms.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.showallsms.OnHoverTextColor = System.Drawing.Color.White;
            this.showallsms.selected = false;
            this.showallsms.Size = new System.Drawing.Size(102, 30);
            this.showallsms.TabIndex = 8;
            this.showallsms.Text = "Show All";
            this.showallsms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showallsms.Textcolor = System.Drawing.Color.White;
            this.showallsms.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showallsms.Click += new System.EventHandler(this.showallsms_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 25;
            this.bunifuElipse2.TargetControl = this.showallsms;
            // 
            // messagesTableAdapter1
            // 
            this.messagesTableAdapter1.ClearBeforeFill = true;
            // 
            // smslist
            // 
            this.smslist.BackColor = System.Drawing.Color.Silver;
            this.smslist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.smslist.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smslist.FormattingEnabled = true;
            this.smslist.ItemHeight = 17;
            this.smslist.Location = new System.Drawing.Point(4, 4);
            this.smslist.Name = "smslist";
            this.smslist.Size = new System.Drawing.Size(152, 225);
            this.smslist.Sorted = true;
            this.smslist.TabIndex = 9;
            this.smslist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.smslist_MouseClick);
            // 
            // loadsms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(543, 328);
            this.Controls.Add(this.smsmainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loadsms";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "loadsms";
            this.Load += new System.EventHandler(this.loadsms_Load);
            this.displaysmsPanel.ResumeLayout(false);
            this.allsmsPanel.ResumeLayout(false);
            this.smsmainpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel smsmainpanel;
        private Guna.UI2.WinForms.Guna2Panel displaysmsPanel;
        private Guna.UI2.WinForms.Guna2Panel allsmsPanel;
        private Guna.UI2.WinForms.Guna2TextBox showmsg;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2ImageButton refresh;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Bunifu.Framework.UI.BunifuFlatButton showallsms;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private hotelDataSetTableAdapters.messagesTableAdapter messagesTableAdapter1;
        private System.Windows.Forms.ListBox smslist;
    }
}