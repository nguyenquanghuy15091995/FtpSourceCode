namespace FTP_Modern_UI
{
    partial class FrmLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.radStatus = new System.Windows.Forms.RadioButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnDisconnect = new DevExpress.XtraEditors.SimpleButton();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new DevExpress.XtraEditors.TextEdit();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtServer = new DevExpress.XtraEditors.TextEdit();
            this.lblServer = new System.Windows.Forms.Label();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlLogin.Controls.Add(this.radStatus);
            this.pnlLogin.Controls.Add(this.btnClose);
            this.pnlLogin.Controls.Add(this.btnDisconnect);
            this.pnlLogin.Controls.Add(this.btnConnect);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.txtServer);
            this.pnlLogin.Controls.Add(this.lblServer);
            this.pnlLogin.Controls.Add(this.picLogin);
            this.pnlLogin.Location = new System.Drawing.Point(0, 63);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(505, 211);
            this.pnlLogin.TabIndex = 0;
            // 
            // radStatus
            // 
            this.radStatus.AutoCheck = false;
            this.radStatus.AutoSize = true;
            this.radStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.radStatus.Location = new System.Drawing.Point(224, 180);
            this.radStatus.Name = "radStatus";
            this.radStatus.Size = new System.Drawing.Size(97, 17);
            this.radStatus.TabIndex = 20;
            this.radStatus.TabStop = true;
            this.radStatus.Text = "Not Connected";
            this.radStatus.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnClose.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnClose.AppearanceHovered.Options.UseBackColor = true;
            this.btnClose.AppearanceHovered.Options.UseFont = true;
            this.btnClose.AppearanceHovered.Options.UseForeColor = true;
            this.btnClose.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClose.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnClose.AppearancePressed.Options.UseBackColor = true;
            this.btnClose.AppearancePressed.Options.UseFont = true;
            this.btnClose.AppearancePressed.Options.UseForeColor = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnClose.Location = new System.Drawing.Point(354, 139);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 35);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDisconnect.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Appearance.Options.UseBackColor = true;
            this.btnDisconnect.Appearance.Options.UseFont = true;
            this.btnDisconnect.Appearance.Options.UseForeColor = true;
            this.btnDisconnect.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDisconnect.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnDisconnect.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.AppearanceHovered.Options.UseBackColor = true;
            this.btnDisconnect.AppearanceHovered.Options.UseFont = true;
            this.btnDisconnect.AppearanceHovered.Options.UseForeColor = true;
            this.btnDisconnect.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDisconnect.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.AppearancePressed.Options.UseBackColor = true;
            this.btnDisconnect.AppearancePressed.Options.UseFont = true;
            this.btnDisconnect.AppearancePressed.Options.UseForeColor = true;
            this.btnDisconnect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnDisconnect.Location = new System.Drawing.Point(354, 101);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(127, 35);
            this.btnDisconnect.TabIndex = 18;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConnect.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Appearance.Options.UseBackColor = true;
            this.btnConnect.Appearance.Options.UseFont = true;
            this.btnConnect.Appearance.Options.UseForeColor = true;
            this.btnConnect.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConnect.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnConnect.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnConnect.AppearanceHovered.Options.UseBackColor = true;
            this.btnConnect.AppearanceHovered.Options.UseFont = true;
            this.btnConnect.AppearanceHovered.Options.UseForeColor = true;
            this.btnConnect.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConnect.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnConnect.AppearancePressed.Options.UseBackColor = true;
            this.btnConnect.AppearancePressed.Options.UseFont = true;
            this.btnConnect.AppearancePressed.Options.UseForeColor = true;
            this.btnConnect.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnConnect.Location = new System.Drawing.Point(224, 101);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(127, 73);
            this.btnConnect.TabIndex = 17;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(307, 71);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtPassword.Properties.Appearance.Options.UseBackColor = true;
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Appearance.Options.UseForeColor = true;
            this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtPassword.Properties.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(176, 24);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Location = new System.Drawing.Point(227, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 15);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.EditValue = "";
            this.txtUsername.Location = new System.Drawing.Point(307, 41);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtUsername.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtUsername.Properties.Appearance.Options.UseBackColor = true;
            this.txtUsername.Properties.Appearance.Options.UseFont = true;
            this.txtUsername.Properties.Appearance.Options.UseForeColor = true;
            this.txtUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtUsername.Size = new System.Drawing.Size(176, 24);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyDown);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(223, 46);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username:";
            // 
            // txtServer
            // 
            this.txtServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServer.EditValue = "";
            this.txtServer.Location = new System.Drawing.Point(307, 11);
            this.txtServer.Name = "txtServer";
            this.txtServer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtServer.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtServer.Properties.Appearance.Options.UseBackColor = true;
            this.txtServer.Properties.Appearance.Options.UseFont = true;
            this.txtServer.Properties.Appearance.Options.UseForeColor = true;
            this.txtServer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtServer.Size = new System.Drawing.Size(176, 24);
            this.txtServer.TabIndex = 11;
            this.txtServer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyDown);
            // 
            // lblServer
            // 
            this.lblServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblServer.Location = new System.Drawing.Point(248, 16);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(52, 15);
            this.lblServer.TabIndex = 12;
            this.lblServer.Text = "Server:";
            // 
            // picLogin
            // 
            this.picLogin.BackgroundImage = global::FTP_Modern_UI.Properties.Resources.ftp_Login_png;
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogin.Location = new System.Drawing.Point(22, 14);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(185, 183);
            this.picLogin.TabIndex = 0;
            this.picLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 313);
            this.Controls.Add(this.pnlLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(505, 313);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(505, 313);
            this.Name = "FrmLogin";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Choose Server";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.PictureBox picLogin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private DevExpress.XtraEditors.TextEdit txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private DevExpress.XtraEditors.TextEdit txtServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.RadioButton radStatus;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnDisconnect;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
    }
}