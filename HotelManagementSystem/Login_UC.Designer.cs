namespace HotelManagementSystem
{
    partial class Login_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_UC));
            this.exitButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.newMsgNoti = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.inbox = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dateTimeDisplay = new Bunifu.UI.WinForms.BunifuLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.usernameDisp = new System.Windows.Forms.TableLayoutPanel();
            this.usernameText = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.userPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.usernameDisp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BorderColor = System.Drawing.Color.Transparent;
            this.exitButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.CustomImages.Parent = this.exitButton;
            this.exitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.exitButton.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.HoverState.ForeColor = System.Drawing.Color.Gray;
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Location = new System.Drawing.Point(341, 74);
            this.exitButton.Name = "exitButton";
            this.exitButton.ShadowDecoration.BorderRadius = 5;
            this.exitButton.ShadowDecoration.Depth = 20;
            this.exitButton.ShadowDecoration.Enabled = true;
            this.exitButton.ShadowDecoration.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(37, 26);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newMsgNoti
            // 
            this.newMsgNoti.BorderColor = System.Drawing.Color.Transparent;
            this.newMsgNoti.BorderThickness = 0;
            this.newMsgNoti.FillColor = System.Drawing.Color.PeachPuff;
            this.newMsgNoti.ForeColor = System.Drawing.Color.PeachPuff;
            this.newMsgNoti.Location = new System.Drawing.Point(5, 4);
            this.newMsgNoti.Size = new System.Drawing.Size(8, 8);
            this.newMsgNoti.TargetControl = this.inbox;
            this.newMsgNoti.Text = "o";
            this.newMsgNoti.Visible = false;
            // 
            // inbox
            // 
            this.inbox.BackColor = System.Drawing.Color.Transparent;
            this.inbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.inbox.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.inbox.CheckedState.Parent = this.inbox;
            this.inbox.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("inbox.HoverState.Image")));
            this.inbox.HoverState.ImageSize = new System.Drawing.Size(23, 23);
            this.inbox.HoverState.Parent = this.inbox;
            this.inbox.Image = ((System.Drawing.Image)(resources.GetObject("inbox.Image")));
            this.inbox.ImageRotate = 0F;
            this.inbox.ImageSize = new System.Drawing.Size(20, 20);
            this.inbox.IndicateFocus = true;
            this.inbox.Location = new System.Drawing.Point(279, 38);
            this.inbox.Name = "inbox";
            this.inbox.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.inbox.PressedState.Parent = this.inbox;
            this.inbox.Size = new System.Drawing.Size(34, 30);
            this.inbox.TabIndex = 6;
            this.inbox.UseTransparentBackground = true;
            this.inbox.Click += new System.EventHandler(this.inbox_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            // 
            // dateTimeDisplay
            // 
            this.dateTimeDisplay.AutoEllipsis = false;
            this.dateTimeDisplay.CursorType = null;
            this.dateTimeDisplay.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.dateTimeDisplay.ForeColor = System.Drawing.Color.White;
            this.dateTimeDisplay.Location = new System.Drawing.Point(141, 73);
            this.dateTimeDisplay.Name = "dateTimeDisplay";
            this.dateTimeDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimeDisplay.Size = new System.Drawing.Size(104, 21);
            this.dateTimeDisplay.TabIndex = 8;
            this.dateTimeDisplay.Text = "bunifuLabel2";
            this.dateTimeDisplay.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.dateTimeDisplay.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // usernameDisp
            // 
            this.usernameDisp.AutoSize = true;
            this.usernameDisp.ColumnCount = 1;
            this.usernameDisp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.usernameDisp.Controls.Add(this.usernameText, 0, 0);
            this.usernameDisp.ForeColor = System.Drawing.Color.White;
            this.usernameDisp.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.usernameDisp.Location = new System.Drawing.Point(220, 5);
            this.usernameDisp.Name = "usernameDisp";
            this.usernameDisp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernameDisp.RowCount = 1;
            this.usernameDisp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.usernameDisp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.usernameDisp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.usernameDisp.Size = new System.Drawing.Size(93, 27);
            this.usernameDisp.TabIndex = 9;
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.ForeColor = System.Drawing.Color.White;
            this.usernameText.Location = new System.Drawing.Point(41, 0);
            this.usernameText.Name = "usernameText";
            this.usernameText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.usernameText.Size = new System.Drawing.Size(49, 16);
            this.usernameText.TabIndex = 10;
            this.usernameText.Text = "label1";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.Color.Transparent;
            this.userPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userPicture.Image = ((System.Drawing.Image)(resources.GetObject("userPicture.Image")));
            this.userPicture.Location = new System.Drawing.Point(322, 0);
            this.userPicture.Name = "userPicture";
            this.userPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userPicture.ShadowDecoration.Parent = this.userPicture;
            this.userPicture.Size = new System.Drawing.Size(68, 63);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 10;
            this.userPicture.TabStop = false;
            // 
            // Login_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.usernameDisp);
            this.Controls.Add(this.dateTimeDisplay);
            this.Controls.Add(this.inbox);
            this.Controls.Add(this.exitButton);
            this.Name = "Login_UC";
            this.Size = new System.Drawing.Size(390, 99);
            this.Load += new System.EventHandler(this.Login_UC_Load);
            this.usernameDisp.ResumeLayout(false);
            this.usernameDisp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton exitButton;
        private Guna.UI2.WinForms.Guna2NotificationPaint newMsgNoti;
        private Guna.UI2.WinForms.Guna2ImageButton inbox;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Bunifu.UI.WinForms.BunifuLabel dateTimeDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel usernameDisp;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPicture;
    }
}
