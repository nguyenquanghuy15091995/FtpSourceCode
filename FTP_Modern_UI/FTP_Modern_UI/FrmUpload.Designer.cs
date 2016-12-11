namespace FTP_Modern_UI
{
    partial class FrmUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpload));
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.txtStatus = new DevExpress.XtraEditors.TextEdit();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblUploadDir = new System.Windows.Forms.Label();
            this.txtUploadDir = new DevExpress.XtraEditors.TextEdit();
            this.txtFileName = new DevExpress.XtraEditors.TextEdit();
            this.lblFileName = new System.Windows.Forms.Label();
            this.pnlBotDesign_4 = new System.Windows.Forms.Panel();
            this.pnlBotDesign_3 = new System.Windows.Forms.Panel();
            this.pnlBotDesign_2 = new System.Windows.Forms.Panel();
            this.pnlBotDesign_1 = new System.Windows.Forms.Panel();
            this.btnControl = new DevExpress.XtraEditors.SimpleButton();
            this.pgbUpload = new CircularProgressBar.CircularProgressBar();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUploadDir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUpload
            // 
            this.pnlUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlUpload.Controls.Add(this.txtStatus);
            this.pnlUpload.Controls.Add(this.lblStatusTitle);
            this.pnlUpload.Controls.Add(this.lblUploadDir);
            this.pnlUpload.Controls.Add(this.txtUploadDir);
            this.pnlUpload.Controls.Add(this.txtFileName);
            this.pnlUpload.Controls.Add(this.lblFileName);
            this.pnlUpload.Controls.Add(this.pnlBotDesign_4);
            this.pnlUpload.Controls.Add(this.pnlBotDesign_3);
            this.pnlUpload.Controls.Add(this.pnlBotDesign_2);
            this.pnlUpload.Controls.Add(this.pnlBotDesign_1);
            this.pnlUpload.Controls.Add(this.btnControl);
            this.pnlUpload.Controls.Add(this.pgbUpload);
            this.pnlUpload.Controls.Add(this.pnlBot);
            this.pnlUpload.Controls.Add(this.pnlTop);
            this.pnlUpload.Location = new System.Drawing.Point(0, 63);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(569, 203);
            this.pnlUpload.TabIndex = 0;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.EditValue = "";
            this.txtStatus.Location = new System.Drawing.Point(239, 108);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtStatus.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtStatus.Properties.Appearance.Options.UseBackColor = true;
            this.txtStatus.Properties.Appearance.Options.UseFont = true;
            this.txtStatus.Properties.Appearance.Options.UseForeColor = true;
            this.txtStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtStatus.Properties.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(327, 22);
            this.txtStatus.TabIndex = 28;
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStatusTitle.Location = new System.Drawing.Point(236, 75);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(101, 15);
            this.lblStatusTitle.TabIndex = 27;
            this.lblStatusTitle.Text = "Upload Status:";
            // 
            // lblUploadDir
            // 
            this.lblUploadDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUploadDir.AutoSize = true;
            this.lblUploadDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadDir.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUploadDir.Location = new System.Drawing.Point(223, 39);
            this.lblUploadDir.Name = "lblUploadDir";
            this.lblUploadDir.Size = new System.Drawing.Size(80, 15);
            this.lblUploadDir.TabIndex = 26;
            this.lblUploadDir.Text = "Upload Dir:";
            // 
            // txtUploadDir
            // 
            this.txtUploadDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUploadDir.EditValue = "";
            this.txtUploadDir.Location = new System.Drawing.Point(309, 36);
            this.txtUploadDir.Name = "txtUploadDir";
            this.txtUploadDir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtUploadDir.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUploadDir.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtUploadDir.Properties.Appearance.Options.UseBackColor = true;
            this.txtUploadDir.Properties.Appearance.Options.UseFont = true;
            this.txtUploadDir.Properties.Appearance.Options.UseForeColor = true;
            this.txtUploadDir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtUploadDir.Properties.ReadOnly = true;
            this.txtUploadDir.Size = new System.Drawing.Size(257, 20);
            this.txtUploadDir.TabIndex = 25;
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.EditValue = "";
            this.txtFileName.Location = new System.Drawing.Point(291, 8);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtFileName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFileName.Properties.Appearance.Options.UseBackColor = true;
            this.txtFileName.Properties.Appearance.Options.UseFont = true;
            this.txtFileName.Properties.Appearance.Options.UseForeColor = true;
            this.txtFileName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtFileName.Properties.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(275, 20);
            this.txtFileName.TabIndex = 23;
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileName.Location = new System.Drawing.Point(208, 11);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(77, 15);
            this.lblFileName.TabIndex = 24;
            this.lblFileName.Text = "File Name:";
            // 
            // pnlBotDesign_4
            // 
            this.pnlBotDesign_4.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBotDesign_4.Location = new System.Drawing.Point(231, 161);
            this.pnlBotDesign_4.Name = "pnlBotDesign_4";
            this.pnlBotDesign_4.Size = new System.Drawing.Size(165, 4);
            this.pnlBotDesign_4.TabIndex = 21;
            // 
            // pnlBotDesign_3
            // 
            this.pnlBotDesign_3.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBotDesign_3.Location = new System.Drawing.Point(226, 171);
            this.pnlBotDesign_3.Name = "pnlBotDesign_3";
            this.pnlBotDesign_3.Size = new System.Drawing.Size(170, 4);
            this.pnlBotDesign_3.TabIndex = 22;
            // 
            // pnlBotDesign_2
            // 
            this.pnlBotDesign_2.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBotDesign_2.Location = new System.Drawing.Point(216, 181);
            this.pnlBotDesign_2.Name = "pnlBotDesign_2";
            this.pnlBotDesign_2.Size = new System.Drawing.Size(180, 4);
            this.pnlBotDesign_2.TabIndex = 21;
            // 
            // pnlBotDesign_1
            // 
            this.pnlBotDesign_1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBotDesign_1.Location = new System.Drawing.Point(206, 191);
            this.pnlBotDesign_1.Name = "pnlBotDesign_1";
            this.pnlBotDesign_1.Size = new System.Drawing.Size(190, 4);
            this.pnlBotDesign_1.TabIndex = 20;
            // 
            // btnControl
            // 
            this.btnControl.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnControl.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnControl.Appearance.Options.UseBackColor = true;
            this.btnControl.Appearance.Options.UseFont = true;
            this.btnControl.Appearance.Options.UseForeColor = true;
            this.btnControl.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnControl.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnControl.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnControl.AppearanceHovered.Options.UseBackColor = true;
            this.btnControl.AppearanceHovered.Options.UseFont = true;
            this.btnControl.AppearanceHovered.Options.UseForeColor = true;
            this.btnControl.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnControl.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnControl.AppearancePressed.Options.UseBackColor = true;
            this.btnControl.AppearancePressed.Options.UseFont = true;
            this.btnControl.AppearancePressed.Options.UseForeColor = true;
            this.btnControl.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnControl.Location = new System.Drawing.Point(402, 158);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(167, 42);
            this.btnControl.TabIndex = 19;
            this.btnControl.Text = "Cancel";
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // pgbUpload
            // 
            this.pgbUpload.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("pgbUpload.AnimationFunction")));
            this.pgbUpload.AnimationSpeed = 50;
            this.pgbUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pgbUpload.Dock = System.Windows.Forms.DockStyle.Left;
            this.pgbUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgbUpload.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pgbUpload.InnerColor = System.Drawing.Color.SkyBlue;
            this.pgbUpload.InnerMargin = 2;
            this.pgbUpload.InnerWidth = -1;
            this.pgbUpload.Location = new System.Drawing.Point(0, 2);
            this.pgbUpload.MarqueeAnimationSpeed = 1000;
            this.pgbUpload.Name = "pgbUpload";
            this.pgbUpload.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pgbUpload.OuterMargin = -25;
            this.pgbUpload.OuterWidth = 26;
            this.pgbUpload.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.pgbUpload.ProgressWidth = 25;
            this.pgbUpload.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgbUpload.Size = new System.Drawing.Size(199, 199);
            this.pgbUpload.StartAngle = 270;
            this.pgbUpload.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pgbUpload.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pgbUpload.SubscriptText = "";
            this.pgbUpload.SuperscriptColor = System.Drawing.SystemColors.Desktop;
            this.pgbUpload.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pgbUpload.SuperscriptText = "%";
            this.pgbUpload.TabIndex = 2;
            this.pgbUpload.Text = "0";
            this.pgbUpload.TextMargin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pgbUpload.Value = 68;
            // 
            // pnlBot
            // 
            this.pnlBot.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 201);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(569, 2);
            this.pnlBot.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(569, 2);
            this.pnlTop.TabIndex = 0;
            // 
            // FrmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 289);
            this.ControlBox = false;
            this.Controls.Add(this.pnlUpload);
            this.MaximumSize = new System.Drawing.Size(569, 289);
            this.MinimumSize = new System.Drawing.Size(569, 289);
            this.Name = "FrmUpload";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Upload Process";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Activated += new System.EventHandler(this.FrmUpload_Activated);
            this.Load += new System.EventHandler(this.FrmUpload_Load);
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUploadDir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Panel pnlTop;
        private CircularProgressBar.CircularProgressBar pgbUpload;
        private DevExpress.XtraEditors.SimpleButton btnControl;
        private System.Windows.Forms.Panel pnlBotDesign_1;
        private System.Windows.Forms.Panel pnlBotDesign_4;
        private System.Windows.Forms.Panel pnlBotDesign_3;
        private System.Windows.Forms.Panel pnlBotDesign_2;
        private System.Windows.Forms.Label lblUploadDir;
        private DevExpress.XtraEditors.TextEdit txtUploadDir;
        private DevExpress.XtraEditors.TextEdit txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private DevExpress.XtraEditors.TextEdit txtStatus;
        private System.Windows.Forms.Label lblStatusTitle;
    }
}