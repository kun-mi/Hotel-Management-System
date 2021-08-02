namespace HotelManagementSystem
{
    partial class smsform
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
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(smsform));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.viewPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.dispsms = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.loadPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.loadmessages = new System.Windows.Forms.ListBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.refreshSms = new Guna.UI2.WinForms.Guna2ImageButton();
            this.exitButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.showAllBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.viewPanel.SuspendLayout();
            this.loadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.viewPanel;
            // 
            // viewPanel
            // 
            this.viewPanel.BackColor = System.Drawing.Color.Snow;
            this.viewPanel.Controls.Add(this.dispsms);
            this.viewPanel.Location = new System.Drawing.Point(12, 12);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.ShadowDecoration.Parent = this.viewPanel;
            this.viewPanel.Size = new System.Drawing.Size(254, 378);
            this.viewPanel.TabIndex = 0;
            // 
            // dispsms
            // 
            this.dispsms.AcceptsReturn = false;
            this.dispsms.AcceptsTab = false;
            this.dispsms.AnimationSpeed = 200;
            this.dispsms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.dispsms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.dispsms.BackColor = System.Drawing.Color.Transparent;
            this.dispsms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dispsms.BackgroundImage")));
            this.dispsms.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.dispsms.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dispsms.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.dispsms.BorderColorIdle = System.Drawing.Color.Snow;
            this.dispsms.BorderRadius = 1;
            this.dispsms.BorderThickness = 0;
            this.dispsms.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.dispsms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dispsms.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.dispsms.DefaultText = "";
            this.dispsms.FillColor = System.Drawing.Color.Snow;
            this.dispsms.HideSelection = true;
            this.dispsms.IconLeft = null;
            this.dispsms.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.dispsms.IconPadding = 10;
            this.dispsms.IconRight = null;
            this.dispsms.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.dispsms.Lines = new string[0];
            this.dispsms.Location = new System.Drawing.Point(14, 21);
            this.dispsms.MaxLength = 32767;
            this.dispsms.MinimumSize = new System.Drawing.Size(100, 35);
            this.dispsms.Modified = false;
            this.dispsms.Multiline = true;
            this.dispsms.Name = "dispsms";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.dispsms.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.dispsms.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.dispsms.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Snow;
            stateProperties4.FillColor = System.Drawing.Color.Snow;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.dispsms.OnIdleState = stateProperties4;
            this.dispsms.PasswordChar = '\0';
            this.dispsms.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.dispsms.PlaceholderText = "";
            this.dispsms.ReadOnly = false;
            this.dispsms.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dispsms.SelectedText = "";
            this.dispsms.SelectionLength = 0;
            this.dispsms.SelectionStart = 0;
            this.dispsms.ShortcutsEnabled = true;
            this.dispsms.Size = new System.Drawing.Size(226, 341);
            this.dispsms.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.dispsms.TabIndex = 0;
            this.dispsms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dispsms.TextMarginBottom = 0;
            this.dispsms.TextMarginLeft = 5;
            this.dispsms.TextMarginTop = 0;
            this.dispsms.TextPlaceholder = "";
            this.dispsms.UseSystemPasswordChar = false;
            this.dispsms.WordWrap = true;
            // 
            // loadPanel
            // 
            this.loadPanel.BackColor = System.Drawing.Color.Snow;
            this.loadPanel.Controls.Add(this.loadmessages);
            this.loadPanel.Location = new System.Drawing.Point(284, 150);
            this.loadPanel.Name = "loadPanel";
            this.loadPanel.ShadowDecoration.Parent = this.loadPanel;
            this.loadPanel.Size = new System.Drawing.Size(200, 240);
            this.loadPanel.TabIndex = 1;
            // 
            // loadmessages
            // 
            this.loadmessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loadmessages.FormattingEnabled = true;
            this.loadmessages.Location = new System.Drawing.Point(3, 12);
            this.loadmessages.Name = "loadmessages";
            this.loadmessages.Size = new System.Drawing.Size(194, 221);
            this.loadmessages.TabIndex = 0;
            this.loadmessages.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loadmessages_MouseClick);
            this.loadmessages.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.loadPanel;
            // 
            // refreshSms
            // 
            this.refreshSms.BackColor = System.Drawing.Color.Transparent;
            this.refreshSms.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.refreshSms.CheckedState.Parent = this.refreshSms;
            this.refreshSms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshSms.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("refreshSms.HoverState.Image")));
            this.refreshSms.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.refreshSms.HoverState.Parent = this.refreshSms;
            this.refreshSms.Image = ((System.Drawing.Image)(resources.GetObject("refreshSms.Image")));
            this.refreshSms.ImageRotate = 0F;
            this.refreshSms.ImageSize = new System.Drawing.Size(30, 30);
            this.refreshSms.Location = new System.Drawing.Point(284, 106);
            this.refreshSms.Name = "refreshSms";
            this.refreshSms.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("refreshSms.PressedState.Image")));
            this.refreshSms.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.refreshSms.PressedState.Parent = this.refreshSms;
            this.refreshSms.Size = new System.Drawing.Size(33, 38);
            this.refreshSms.TabIndex = 2;
            this.refreshSms.UseTransparentBackground = true;
            this.refreshSms.Click += new System.EventHandler(this.refreshSms_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exitButton.CheckedState.Parent = this.exitButton;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.HoverState.Image")));
            this.exitButton.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.exitButton.HoverState.Parent = this.exitButton;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageRotate = 0F;
            this.exitButton.ImageSize = new System.Drawing.Size(25, 25);
            this.exitButton.Location = new System.Drawing.Point(451, 106);
            this.exitButton.Name = "exitButton";
            this.exitButton.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.PressedState.Image")));
            this.exitButton.PressedState.ImageSize = new System.Drawing.Size(15, 15);
            this.exitButton.PressedState.Parent = this.exitButton;
            this.exitButton.Size = new System.Drawing.Size(33, 38);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseTransparentBackground = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // showAllBtn
            // 
            this.showAllBtn.Active = false;
            this.showAllBtn.Activecolor = System.Drawing.Color.Transparent;
            this.showAllBtn.BackColor = System.Drawing.Color.Transparent;
            this.showAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showAllBtn.BorderRadius = 0;
            this.showAllBtn.ButtonText = "Show All";
            this.showAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllBtn.DisabledColor = System.Drawing.Color.Gray;
            this.showAllBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.showAllBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("showAllBtn.Iconimage")));
            this.showAllBtn.Iconimage_right = null;
            this.showAllBtn.Iconimage_right_Selected = null;
            this.showAllBtn.Iconimage_Selected = null;
            this.showAllBtn.IconMarginLeft = 0;
            this.showAllBtn.IconMarginRight = 0;
            this.showAllBtn.IconRightVisible = true;
            this.showAllBtn.IconRightZoom = 0D;
            this.showAllBtn.IconVisible = true;
            this.showAllBtn.IconZoom = 90D;
            this.showAllBtn.IsTab = false;
            this.showAllBtn.Location = new System.Drawing.Point(323, 106);
            this.showAllBtn.Name = "showAllBtn";
            this.showAllBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.showAllBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.showAllBtn.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.showAllBtn.selected = false;
            this.showAllBtn.Size = new System.Drawing.Size(110, 38);
            this.showAllBtn.TabIndex = 4;
            this.showAllBtn.Text = "Show All";
            this.showAllBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showAllBtn.Textcolor = System.Drawing.Color.White;
            this.showAllBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllBtn.Click += new System.EventHandler(this.showAllBtn_Click);
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.loadPanel;
            // 
            // smsform
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(497, 402);
            this.Controls.Add(this.showAllBtn);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshSms);
            this.Controls.Add(this.loadPanel);
            this.Controls.Add(this.viewPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "smsform";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "smsform";
            this.Load += new System.EventHandler(this.smsform_Load);
            this.viewPanel.ResumeLayout(false);
            this.loadPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2Panel loadPanel;
        private Guna.UI2.WinForms.Guna2Panel viewPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.ListBox loadmessages;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox dispsms;
        private Guna.UI2.WinForms.Guna2ImageButton exitButton;
        private Guna.UI2.WinForms.Guna2ImageButton refreshSms;
        private Bunifu.Framework.UI.BunifuFlatButton showAllBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;

    }
}