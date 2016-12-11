namespace FTP_Modern_UI
{
    partial class FrmNewFolder
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
            this.pnlNewFolder = new System.Windows.Forms.Panel();
            this.pnlMiddleBot = new System.Windows.Forms.Panel();
            this.pnlMiddleTop = new System.Windows.Forms.Panel();
            this.pnlMiddle = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblCurrDir = new System.Windows.Forms.Label();
            this.txtFileName = new DevExpress.XtraEditors.TextEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.txtCurrDir = new DevExpress.XtraEditors.TextEdit();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlNewFolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrDir.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNewFolder
            // 
            this.pnlNewFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNewFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlNewFolder.Controls.Add(this.pnlMiddleBot);
            this.pnlNewFolder.Controls.Add(this.pnlMiddleTop);
            this.pnlNewFolder.Controls.Add(this.pnlMiddle);
            this.pnlNewFolder.Controls.Add(this.lblFileName);
            this.pnlNewFolder.Controls.Add(this.lblCurrDir);
            this.pnlNewFolder.Controls.Add(this.txtFileName);
            this.pnlNewFolder.Controls.Add(this.btnClose);
            this.pnlNewFolder.Controls.Add(this.btnCreate);
            this.pnlNewFolder.Controls.Add(this.txtCurrDir);
            this.pnlNewFolder.Controls.Add(this.pnlBot);
            this.pnlNewFolder.Controls.Add(this.pnlTop);
            this.pnlNewFolder.Location = new System.Drawing.Point(0, 63);
            this.pnlNewFolder.Name = "pnlNewFolder";
            this.pnlNewFolder.Size = new System.Drawing.Size(419, 100);
            this.pnlNewFolder.TabIndex = 2;
            // 
            // pnlMiddleBot
            // 
            this.pnlMiddleBot.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMiddleBot.Location = new System.Drawing.Point(211, 88);
            this.pnlMiddleBot.Name = "pnlMiddleBot";
            this.pnlMiddleBot.Size = new System.Drawing.Size(110, 4);
            this.pnlMiddleBot.TabIndex = 24;
            // 
            // pnlMiddleTop
            // 
            this.pnlMiddleTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMiddleTop.Location = new System.Drawing.Point(211, 8);
            this.pnlMiddleTop.Name = "pnlMiddleTop";
            this.pnlMiddleTop.Size = new System.Drawing.Size(110, 4);
            this.pnlMiddleTop.TabIndex = 23;
            // 
            // pnlMiddle
            // 
            this.pnlMiddle.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlMiddle.Location = new System.Drawing.Point(152, 48);
            this.pnlMiddle.Name = "pnlMiddle";
            this.pnlMiddle.Size = new System.Drawing.Size(169, 4);
            this.pnlMiddle.TabIndex = 22;
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileName.Location = new System.Drawing.Point(10, 61);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(94, 20);
            this.lblFileName.TabIndex = 11;
            this.lblFileName.Text = "File Name:";
            // 
            // lblCurrDir
            // 
            this.lblCurrDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrDir.AutoSize = true;
            this.lblCurrDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrDir.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCurrDir.Location = new System.Drawing.Point(18, 19);
            this.lblCurrDir.Name = "lblCurrDir";
            this.lblCurrDir.Size = new System.Drawing.Size(86, 20);
            this.lblCurrDir.TabIndex = 10;
            this.lblCurrDir.Text = "Directory:";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.EditValue = "New Folder";
            this.txtFileName.Location = new System.Drawing.Point(110, 59);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtFileName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFileName.Properties.Appearance.Options.UseBackColor = true;
            this.txtFileName.Properties.Appearance.Options.UseFont = true;
            this.txtFileName.Properties.Appearance.Options.UseForeColor = true;
            this.txtFileName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtFileName.Size = new System.Drawing.Size(200, 24);
            this.txtFileName.TabIndex = 5;
            this.txtFileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFileName_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnClose.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnClose.AppearanceHovered.Options.UseBackColor = true;
            this.btnClose.AppearanceHovered.Options.UseFont = true;
            this.btnClose.AppearanceHovered.Options.UseForeColor = true;
            this.btnClose.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClose.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnClose.AppearancePressed.Options.UseBackColor = true;
            this.btnClose.AppearancePressed.Options.UseFont = true;
            this.btnClose.AppearancePressed.Options.UseForeColor = true;
            this.btnClose.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnClose.Location = new System.Drawing.Point(324, 52);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 40);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Cancel";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Appearance.Options.UseBackColor = true;
            this.btnCreate.Appearance.Options.UseFont = true;
            this.btnCreate.Appearance.Options.UseForeColor = true;
            this.btnCreate.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnCreate.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnCreate.AppearanceHovered.Options.UseBackColor = true;
            this.btnCreate.AppearanceHovered.Options.UseFont = true;
            this.btnCreate.AppearanceHovered.Options.UseForeColor = true;
            this.btnCreate.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCreate.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnCreate.AppearancePressed.Options.UseBackColor = true;
            this.btnCreate.AppearancePressed.Options.UseFont = true;
            this.btnCreate.AppearancePressed.Options.UseForeColor = true;
            this.btnCreate.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnCreate.Location = new System.Drawing.Point(324, 8);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 40);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCurrDir
            // 
            this.txtCurrDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrDir.EditValue = "";
            this.txtCurrDir.Location = new System.Drawing.Point(110, 17);
            this.txtCurrDir.Name = "txtCurrDir";
            this.txtCurrDir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtCurrDir.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrDir.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCurrDir.Properties.Appearance.Options.UseBackColor = true;
            this.txtCurrDir.Properties.Appearance.Options.UseFont = true;
            this.txtCurrDir.Properties.Appearance.Options.UseForeColor = true;
            this.txtCurrDir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCurrDir.Properties.ReadOnly = true;
            this.txtCurrDir.Size = new System.Drawing.Size(200, 24);
            this.txtCurrDir.TabIndex = 9;
            // 
            // pnlBot
            // 
            this.pnlBot.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 98);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(419, 2);
            this.pnlBot.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(419, 2);
            this.pnlTop.TabIndex = 0;
            // 
            // FrmNewFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 186);
            this.Controls.Add(this.pnlNewFolder);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewFolder";
            this.Text = "Create New Folder";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pnlNewFolder.ResumeLayout(false);
            this.pnlNewFolder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrDir.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNewFolder;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Panel pnlTop;
        private DevExpress.XtraEditors.TextEdit txtCurrDir;
        private DevExpress.XtraEditors.TextEdit txtFileName;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private System.Windows.Forms.Label lblCurrDir;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Panel pnlMiddle;
        private System.Windows.Forms.Panel pnlMiddleTop;
        private System.Windows.Forms.Panel pnlMiddleBot;
    }
}