namespace HotelManagementSystem
{
    partial class homeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeScreen));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.login_UC1 = new HotelManagementSystem.Login_UC();
            this.leftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.roomsBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DatabaseBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.manageButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.roomsButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.roomsH1 = new HotelManagementSystem.roomsH();
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.topPanel.Controls.Add(this.login_UC1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.ShadowDecoration.Parent = this.topPanel;
            this.topPanel.Size = new System.Drawing.Size(1187, 105);
            this.topPanel.TabIndex = 0;
            // 
            // login_UC1
            // 
            this.login_UC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.login_UC1.Location = new System.Drawing.Point(785, 6);
            this.login_UC1.Name = "login_UC1";
            this.login_UC1.Size = new System.Drawing.Size(390, 99);
            this.login_UC1.TabIndex = 8;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(68)))));
            this.leftPanel.Controls.Add(this.roomsBtn);
            this.leftPanel.Controls.Add(this.DatabaseBtn);
            this.leftPanel.Controls.Add(this.bunifuButton1);
            this.leftPanel.Controls.Add(this.guna2ImageButton1);
            this.leftPanel.Controls.Add(this.manageButton);
            this.leftPanel.Controls.Add(this.roomsButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 105);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.ShadowDecoration.Parent = this.leftPanel;
            this.leftPanel.Size = new System.Drawing.Size(194, 468);
            this.leftPanel.TabIndex = 1;
            // 
            // roomsBtn
            // 
            this.roomsBtn.AllowToggling = false;
            this.roomsBtn.AnimationSpeed = 200;
            this.roomsBtn.AutoGenerateColors = false;
            this.roomsBtn.BackColor = System.Drawing.Color.Transparent;
            this.roomsBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.roomsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roomsBtn.BackgroundImage")));
            this.roomsBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.roomsBtn.ButtonText = "Rooms";
            this.roomsBtn.ButtonTextMarginLeft = 0;
            this.roomsBtn.ColorContrastOnClick = 45;
            this.roomsBtn.ColorContrastOnHover = 45;
            this.roomsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.roomsBtn.CustomizableEdges = borderEdges1;
            this.roomsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.roomsBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.roomsBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.roomsBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.roomsBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.roomsBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.roomsBtn.ForeColor = System.Drawing.Color.White;
            this.roomsBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.roomsBtn.IconMarginLeft = 11;
            this.roomsBtn.IconPadding = 10;
            this.roomsBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.roomsBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.roomsBtn.IdleBorderRadius = 3;
            this.roomsBtn.IdleBorderThickness = 1;
            this.roomsBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.roomsBtn.IdleIconLeftImage = null;
            this.roomsBtn.IdleIconRightImage = null;
            this.roomsBtn.IndicateFocus = false;
            this.roomsBtn.Location = new System.Drawing.Point(50, 118);
            this.roomsBtn.Name = "roomsBtn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.roomsBtn.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.roomsBtn.OnPressedState = stateProperties2;
            this.roomsBtn.Size = new System.Drawing.Size(131, 38);
            this.roomsBtn.TabIndex = 10;
            this.roomsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roomsBtn.TextMarginLeft = 0;
            this.roomsBtn.UseDefaultRadiusAndThickness = true;
            this.roomsBtn.Click += new System.EventHandler(this.RoomsBtn_Click);
            // 
            // DatabaseBtn
            // 
            this.DatabaseBtn.AllowToggling = false;
            this.DatabaseBtn.AnimationSpeed = 200;
            this.DatabaseBtn.AutoGenerateColors = false;
            this.DatabaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.DatabaseBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.DatabaseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DatabaseBtn.BackgroundImage")));
            this.DatabaseBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DatabaseBtn.ButtonText = "Database";
            this.DatabaseBtn.ButtonTextMarginLeft = 0;
            this.DatabaseBtn.ColorContrastOnClick = 45;
            this.DatabaseBtn.ColorContrastOnHover = 45;
            this.DatabaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.DatabaseBtn.CustomizableEdges = borderEdges2;
            this.DatabaseBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DatabaseBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.DatabaseBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DatabaseBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DatabaseBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.DatabaseBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.DatabaseBtn.ForeColor = System.Drawing.Color.White;
            this.DatabaseBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.DatabaseBtn.IconMarginLeft = 11;
            this.DatabaseBtn.IconPadding = 10;
            this.DatabaseBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.DatabaseBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.DatabaseBtn.IdleBorderRadius = 3;
            this.DatabaseBtn.IdleBorderThickness = 1;
            this.DatabaseBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.DatabaseBtn.IdleIconLeftImage = null;
            this.DatabaseBtn.IdleIconRightImage = null;
            this.DatabaseBtn.IndicateFocus = false;
            this.DatabaseBtn.Location = new System.Drawing.Point(54, 212);
            this.DatabaseBtn.Name = "DatabaseBtn";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.BorderRadius = 3;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.DatabaseBtn.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.BorderRadius = 3;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.DatabaseBtn.OnPressedState = stateProperties4;
            this.DatabaseBtn.Size = new System.Drawing.Size(131, 38);
            this.DatabaseBtn.TabIndex = 9;
            this.DatabaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DatabaseBtn.TextMarginLeft = 0;
            this.DatabaseBtn.UseDefaultRadiusAndThickness = true;
            this.DatabaseBtn.Click += new System.EventHandler(this.BunifuButton1_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "New Order";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges3;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.Empty;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 3;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(54, 22);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.BorderRadius = 3;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 1;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.BorderRadius = 3;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.bunifuButton1.OnPressedState = stateProperties6;
            this.bunifuButton1.Size = new System.Drawing.Size(131, 38);
            this.bunifuButton1.TabIndex = 9;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.BunifuButton1_Click);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Enabled = false;
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Location = new System.Drawing.Point(5, 20);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.PressedState.Image")));
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.TabIndex = 1;
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // manageButton
            // 
            this.manageButton.AnimatedGIF = true;
            this.manageButton.BackColor = System.Drawing.Color.Transparent;
            this.manageButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.manageButton.CheckedState.Parent = this.manageButton;
            this.manageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageButton.Enabled = false;
            this.manageButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("manageButton.HoverState.Image")));
            this.manageButton.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.manageButton.HoverState.Parent = this.manageButton;
            this.manageButton.Image = ((System.Drawing.Image)(resources.GetObject("manageButton.Image")));
            this.manageButton.ImageRotate = 0F;
            this.manageButton.ImageSize = new System.Drawing.Size(40, 40);
            this.manageButton.Location = new System.Drawing.Point(3, 209);
            this.manageButton.Name = "manageButton";
            this.manageButton.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("manageButton.PressedState.Image")));
            this.manageButton.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.manageButton.PressedState.Parent = this.manageButton;
            this.manageButton.Size = new System.Drawing.Size(40, 40);
            this.manageButton.TabIndex = 0;
            this.manageButton.UseTransparentBackground = true;
            this.manageButton.Click += new System.EventHandler(this.ManageButton_Click);
            // 
            // roomsButton
            // 
            this.roomsButton.AnimatedGIF = true;
            this.roomsButton.BackColor = System.Drawing.Color.Transparent;
            this.roomsButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.roomsButton.CheckedState.Parent = this.roomsButton;
            this.roomsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roomsButton.Enabled = false;
            this.roomsButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("roomsButton.HoverState.Image")));
            this.roomsButton.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.roomsButton.HoverState.Parent = this.roomsButton;
            this.roomsButton.Image = ((System.Drawing.Image)(resources.GetObject("roomsButton.Image")));
            this.roomsButton.ImageRotate = 0F;
            this.roomsButton.ImageSize = new System.Drawing.Size(40, 40);
            this.roomsButton.Location = new System.Drawing.Point(3, 115);
            this.roomsButton.Name = "roomsButton";
            this.roomsButton.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("roomsButton.PressedState.Image")));
            this.roomsButton.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.roomsButton.PressedState.Parent = this.roomsButton;
            this.roomsButton.Size = new System.Drawing.Size(41, 46);
            this.roomsButton.TabIndex = 0;
            this.roomsButton.UseTransparentBackground = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.roomsH1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(194, 105);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(993, 468);
            this.mainPanel.TabIndex = 2;
            // 
            // roomsH1
            // 
            this.roomsH1.BackColor = System.Drawing.Color.AliceBlue;
            this.roomsH1.Enabled = false;
            this.roomsH1.Location = new System.Drawing.Point(0, 0);
            this.roomsH1.Name = "roomsH1";
            this.roomsH1.Size = new System.Drawing.Size(993, 468);
            this.roomsH1.TabIndex = 1;
            this.roomsH1.Visible = false;
            // 
            // homeScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 573);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.homeScreen_Load);
            this.topPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel leftPanel;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Login_UC login_UC1;
        private Guna.UI2.WinForms.Guna2ImageButton manageButton;
        private Guna.UI2.WinForms.Guna2ImageButton roomsButton;
        private CheckIn_UC checkIn_UC1;
        private CheckIn_UC checkIn_UC2;
        private CheckIn_UC customerAdds;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private CheckIn_UC checkIn_UC3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DatabaseBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton roomsBtn;
        private roomsH roomsH1;
    }
}

