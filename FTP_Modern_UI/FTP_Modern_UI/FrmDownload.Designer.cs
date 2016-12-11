namespace FTP_Modern_UI
{
    partial class FrmDownload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDownload));
            this.pnlDownload = new System.Windows.Forms.Panel();
            this.txtStatus = new DevExpress.XtraEditors.TextEdit();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblDownloadDir = new System.Windows.Forms.Label();
            this.txtDownloadDir = new DevExpress.XtraEditors.TextEdit();
            this.txtFileName = new DevExpress.XtraEditors.TextEdit();
            this.lblFileName = new System.Windows.Forms.Label();
            this.pnlBotDesign_4 = new System.Windows.Forms.Panel();
            this.pnlBotDesign_3 = new System.Windows.Forms.Panel();
            this.pnlBotDesign_2 = new System.Windows.Forms.Panel();
            this.pnlBotDesign_1 = new System.Windows.Forms.Panel();
            this.btnControl = new DevExpress.XtraEditors.SimpleButton();
            this.pgbDownload = new CircularProgressBar.CircularProgressBar();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDownloadDir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDownload
            // 
            this.pnlDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlDownload.Controls.Add(this.txtStatus);
            this.pnlDownload.Controls.Add(this.lblStatusTitle);
            this.pnlDownload.Controls.Add(this.lblDownloadDir);
            this.pnlDownload.Controls.Add(this.txtDownloadDir);
            this.pnlDownload.Controls.Add(this.txtFileName);
            this.pnlDownload.Controls.Add(this.lblFileName);
            this.pnlDownload.Controls.Add(this.pnlBotDesign_4);
            this.pnlDownload.Controls.Add(this.pnlBotDesign_3);
            this.pnlDownload.Controls.Add(this.pnlBotDesign_2);
            this.pnlDownload.Controls.Add(this.pnlBotDesign_1);
            this.pnlDownload.Controls.Add(this.btnControl);
            this.pnlDownload.Controls.Add(this.pgbDownload);
            this.pnlDownload.Controls.Add(this.pnlBot);
            this.pnlDownload.Controls.Add(this.pnlTop);
            this.pnlDownload.Location = new System.Drawing.Point(0, 63);
            this.pnlDownload.Name = "pnlDownload";
            this.pnlDownload.Size = new System.Drawing.Size(569, 203);
            this.pnlDownload.TabIndex = 1;
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
            this.lblStatusTitle.Size = new System.Drawing.Size(119, 15);
            this.lblStatusTitle.TabIndex = 27;
            this.lblStatusTitle.Text = "Download Status:";
            // 
            // lblDownloadDir
            // 
            this.lblDownloadDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDownloadDir.AutoSize = true;
            this.lblDownloadDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownloadDir.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDownloadDir.Location = new System.Drawing.Point(223, 39);
            this.lblDownloadDir.Name = "lblDownloadDir";
            this.lblDownloadDir.Size = new System.Drawing.Size(98, 15);
            this.lblDownloadDir.TabIndex = 26;
            this.lblDownloadDir.Text = "Download Dir:";
            // 
            // txtDownloadDir
            // 
            this.txtDownloadDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadDir.EditValue = "";
            this.txtDownloadDir.Location = new System.Drawing.Point(327, 36);
            this.txtDownloadDir.Name = "txtDownloadDir";
            this.txtDownloadDir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtDownloadDir.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDownloadDir.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtDownloadDir.Properties.Appearance.Options.UseBackColor = true;
            this.txtDownloadDir.Properties.Appearance.Options.UseFont = true;
            this.txtDownloadDir.Properties.Appearance.Options.UseForeColor = true;
            this.txtDownloadDir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txtDownloadDir.Properties.ReadOnly = true;
            this.txtDownloadDir.Size = new System.Drawing.Size(239, 20);
            this.txtDownloadDir.TabIndex = 25;
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
            // pgbDownload
            // 
            this.pgbDownload.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("pgbDownload.AnimationFunction")));
            this.pgbDownload.AnimationSpeed = 50;
            this.pgbDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pgbDownload.Dock = System.Windows.Forms.DockStyle.Left;
            this.pgbDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgbDownload.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pgbDownload.InnerColor = System.Drawing.Color.SkyBlue;
            this.pgbDownload.InnerMargin = 2;
            this.pgbDownload.InnerWidth = -1;
            this.pgbDownload.Location = new System.Drawing.Point(0, 2);
            this.pgbDownload.MarqueeAnimationSpeed = 2000;
            this.pgbDownload.Name = "pgbDownload";
            this.pgbDownload.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pgbDownload.OuterMargin = -25;
            this.pgbDownload.OuterWidth = 26;
            this.pgbDownload.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.pgbDownload.ProgressWidth = 25;
            this.pgbDownload.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pgbDownload.Size = new System.Drawing.Size(199, 199);
            this.pgbDownload.StartAngle = 270;
            this.pgbDownload.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pgbDownload.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pgbDownload.SubscriptText = "";
            this.pgbDownload.SuperscriptColor = System.Drawing.SystemColors.Desktop;
            this.pgbDownload.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pgbDownload.SuperscriptText = "%";
            this.pgbDownload.TabIndex = 2;
            this.pgbDownload.Text = "0";
            this.pgbDownload.TextMargin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.pgbDownload.Value = 68;
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
            // FrmDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 289);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDownload);
            this.MaximumSize = new System.Drawing.Size(569, 289);
            this.MinimumSize = new System.Drawing.Size(569, 289);
            this.Name = "FrmDownload";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Download Process";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Activated += new System.EventHandler(this.FrmDownload_Activated);
            this.Load += new System.EventHandler(this.FrmDownload_Load);
            this.pnlDownload.ResumeLayout(false);
            this.pnlDownload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDownloadDir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDownload;
        private DevExpress.XtraEditors.TextEdit txtStatus;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblDownloadDir;
        private DevExpress.XtraEditors.TextEdit txtDownloadDir;
        private DevExpress.XtraEditors.TextEdit txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Panel pnlBotDesign_4;
        private System.Windows.Forms.Panel pnlBotDesign_3;
        private System.Windows.Forms.Panel pnlBotDesign_2;
        private System.Windows.Forms.Panel pnlBotDesign_1;
        private DevExpress.XtraEditors.SimpleButton btnControl;
        private CircularProgressBar.CircularProgressBar pgbDownload;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Panel pnlTop;
    }
}