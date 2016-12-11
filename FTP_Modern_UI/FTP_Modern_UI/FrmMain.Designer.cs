namespace FTP_Modern_UI
{
    partial class FrmMain
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
            this.pnlMainControl = new System.Windows.Forms.Panel();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.txtCurrDir = new DevExpress.XtraEditors.TextEdit();
            this.lblRemoteSite = new System.Windows.Forms.Label();
            this.lblRoot = new System.Windows.Forms.Label();
            this.gclServer = new DevExpress.XtraGrid.GridControl();
            this.gvwServer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlRightBot = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClearMessage = new DevExpress.XtraEditors.SimpleButton();
            this.gclMessage = new DevExpress.XtraGrid.GridControl();
            this.gvwMessage = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlRightTop = new System.Windows.Forms.Panel();
            this.btnNewFolder = new DevExpress.XtraEditors.SimpleButton();
            this.lblFileInfo = new System.Windows.Forms.Label();
            this.txtFileSize = new DevExpress.XtraEditors.TextEdit();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.txtFileDate = new DevExpress.XtraEditors.TextEdit();
            this.lblFileDate = new System.Windows.Forms.Label();
            this.txtFileType = new DevExpress.XtraEditors.TextEdit();
            this.lblFileType = new System.Windows.Forms.Label();
            this.txtFileName = new DevExpress.XtraEditors.TextEdit();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnRename = new DevExpress.XtraEditors.SimpleButton();
            this.btnDownload = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpload = new DevExpress.XtraEditors.SimpleButton();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.btnInfo = new DevExpress.XtraEditors.SimpleButton();
            this.btnChooseServer = new DevExpress.XtraEditors.SimpleButton();
            this.txtCurrServer = new DevExpress.XtraEditors.TextEdit();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMainControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrDir.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwServer)).BeginInit();
            this.pnlRightBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwMessage)).BeginInit();
            this.pnlRightTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrServer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainControl
            // 
            this.pnlMainControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlMainControl.Controls.Add(this.btnRefresh);
            this.pnlMainControl.Controls.Add(this.btnBack);
            this.pnlMainControl.Controls.Add(this.txtCurrDir);
            this.pnlMainControl.Controls.Add(this.lblRemoteSite);
            this.pnlMainControl.Controls.Add(this.lblRoot);
            this.pnlMainControl.Controls.Add(this.gclServer);
            this.pnlMainControl.Controls.Add(this.pnlRightBot);
            this.pnlMainControl.Controls.Add(this.pnlRightTop);
            this.pnlMainControl.Controls.Add(this.pnlLeft);
            this.pnlMainControl.Controls.Add(this.pnlBot);
            this.pnlMainControl.Controls.Add(this.pnlTop);
            this.pnlMainControl.Location = new System.Drawing.Point(0, 63);
            this.pnlMainControl.Name = "pnlMainControl";
            this.pnlMainControl.Size = new System.Drawing.Size(1004, 561);
            this.pnlMainControl.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Appearance.Options.UseBackColor = true;
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Appearance.Options.UseForeColor = true;
            this.btnRefresh.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRefresh.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnRefresh.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.AppearanceHovered.Options.UseBackColor = true;
            this.btnRefresh.AppearanceHovered.Options.UseFont = true;
            this.btnRefresh.AppearanceHovered.Options.UseForeColor = true;
            this.btnRefresh.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.AppearancePressed.Options.UseBackColor = true;
            this.btnRefresh.AppearancePressed.Options.UseFont = true;
            this.btnRefresh.AppearancePressed.Options.UseForeColor = true;
            this.btnRefresh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(919, 146);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 24);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnBack.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnBack.AppearanceHovered.Options.UseBackColor = true;
            this.btnBack.AppearanceHovered.Options.UseFont = true;
            this.btnBack.AppearanceHovered.Options.UseForeColor = true;
            this.btnBack.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnBack.AppearancePressed.Options.UseBackColor = true;
            this.btnBack.AppearancePressed.Options.UseFont = true;
            this.btnBack.AppearancePressed.Options.UseForeColor = true;
            this.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnBack.Enabled = false;
            this.btnBack.Location = new System.Drawing.Point(833, 146);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 24);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtCurrDir
            // 
            this.txtCurrDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrDir.EditValue = "";
            this.txtCurrDir.Location = new System.Drawing.Point(376, 147);
            this.txtCurrDir.Name = "txtCurrDir";
            this.txtCurrDir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtCurrDir.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrDir.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCurrDir.Properties.Appearance.Options.UseBackColor = true;
            this.txtCurrDir.Properties.Appearance.Options.UseFont = true;
            this.txtCurrDir.Properties.Appearance.Options.UseForeColor = true;
            this.txtCurrDir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCurrDir.Properties.ReadOnly = true;
            this.txtCurrDir.Size = new System.Drawing.Size(455, 22);
            this.txtCurrDir.TabIndex = 14;
            // 
            // lblRemoteSite
            // 
            this.lblRemoteSite.AutoSize = true;
            this.lblRemoteSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemoteSite.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRemoteSite.Location = new System.Drawing.Point(197, 146);
            this.lblRemoteSite.Name = "lblRemoteSite";
            this.lblRemoteSite.Size = new System.Drawing.Size(134, 24);
            this.lblRemoteSite.TabIndex = 15;
            this.lblRemoteSite.Text = "Remote Site |";
            // 
            // lblRoot
            // 
            this.lblRoot.AutoSize = true;
            this.lblRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoot.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRoot.Location = new System.Drawing.Point(337, 150);
            this.lblRoot.Name = "lblRoot";
            this.lblRoot.Size = new System.Drawing.Size(36, 15);
            this.lblRoot.TabIndex = 14;
            this.lblRoot.Text = ".root";
            // 
            // gclServer
            // 
            this.gclServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gclServer.Location = new System.Drawing.Point(197, 176);
            this.gclServer.MainView = this.gvwServer;
            this.gclServer.Name = "gclServer";
            this.gclServer.Size = new System.Drawing.Size(806, 207);
            this.gclServer.TabIndex = 5;
            this.gclServer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwServer});
            // 
            // gvwServer
            // 
            this.gvwServer.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvwServer.GridControl = this.gclServer;
            this.gvwServer.Name = "gvwServer";
            this.gvwServer.OptionsBehavior.Editable = false;
            this.gvwServer.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwServer.OptionsView.ShowGroupPanel = false;
            this.gvwServer.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvwServer_RowClick);
            this.gvwServer.EndSorting += new System.EventHandler(this.gvwServer_EndSorting);
            this.gvwServer.DoubleClick += new System.EventHandler(this.gvwServer_DoubleClick);
            // 
            // pnlRightBot
            // 
            this.pnlRightBot.Controls.Add(this.lblMessage);
            this.pnlRightBot.Controls.Add(this.btnClearMessage);
            this.pnlRightBot.Controls.Add(this.gclMessage);
            this.pnlRightBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRightBot.Location = new System.Drawing.Point(194, 389);
            this.pnlRightBot.Name = "pnlRightBot";
            this.pnlRightBot.Size = new System.Drawing.Size(810, 167);
            this.pnlRightBot.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMessage.Location = new System.Drawing.Point(6, 2);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(94, 24);
            this.lblMessage.TabIndex = 17;
            this.lblMessage.Text = "Message";
            // 
            // btnClearMessage
            // 
            this.btnClearMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearMessage.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClearMessage.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMessage.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnClearMessage.Appearance.Options.UseBackColor = true;
            this.btnClearMessage.Appearance.Options.UseFont = true;
            this.btnClearMessage.Appearance.Options.UseForeColor = true;
            this.btnClearMessage.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClearMessage.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMessage.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnClearMessage.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnClearMessage.AppearanceHovered.Options.UseBackColor = true;
            this.btnClearMessage.AppearanceHovered.Options.UseFont = true;
            this.btnClearMessage.AppearanceHovered.Options.UseForeColor = true;
            this.btnClearMessage.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClearMessage.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMessage.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnClearMessage.AppearancePressed.Options.UseBackColor = true;
            this.btnClearMessage.AppearancePressed.Options.UseFont = true;
            this.btnClearMessage.AppearancePressed.Options.UseForeColor = true;
            this.btnClearMessage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnClearMessage.Location = new System.Drawing.Point(638, 3);
            this.btnClearMessage.Name = "btnClearMessage";
            this.btnClearMessage.Size = new System.Drawing.Size(171, 24);
            this.btnClearMessage.TabIndex = 15;
            this.btnClearMessage.Text = "Clear Message";
            this.btnClearMessage.Click += new System.EventHandler(this.btnClearMessage_Click);
            // 
            // gclMessage
            // 
            this.gclMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gclMessage.Location = new System.Drawing.Point(3, 30);
            this.gclMessage.MainView = this.gvwMessage;
            this.gclMessage.Name = "gclMessage";
            this.gclMessage.Size = new System.Drawing.Size(806, 133);
            this.gclMessage.TabIndex = 0;
            this.gclMessage.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvwMessage});
            // 
            // gvwMessage
            // 
            this.gvwMessage.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gvwMessage.GridControl = this.gclMessage;
            this.gvwMessage.Name = "gvwMessage";
            this.gvwMessage.OptionsBehavior.Editable = false;
            this.gvwMessage.OptionsFind.AllowFindPanel = false;
            this.gvwMessage.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvwMessage.OptionsView.ShowGroupPanel = false;
            // 
            // pnlRightTop
            // 
            this.pnlRightTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.pnlRightTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRightTop.Controls.Add(this.btnNewFolder);
            this.pnlRightTop.Controls.Add(this.lblFileInfo);
            this.pnlRightTop.Controls.Add(this.txtFileSize);
            this.pnlRightTop.Controls.Add(this.lblFileSize);
            this.pnlRightTop.Controls.Add(this.txtFileDate);
            this.pnlRightTop.Controls.Add(this.lblFileDate);
            this.pnlRightTop.Controls.Add(this.txtFileType);
            this.pnlRightTop.Controls.Add(this.lblFileType);
            this.pnlRightTop.Controls.Add(this.txtFileName);
            this.pnlRightTop.Controls.Add(this.lblFileName);
            this.pnlRightTop.Controls.Add(this.btnDelete);
            this.pnlRightTop.Controls.Add(this.btnRename);
            this.pnlRightTop.Controls.Add(this.btnDownload);
            this.pnlRightTop.Controls.Add(this.btnUpload);
            this.pnlRightTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRightTop.Enabled = false;
            this.pnlRightTop.Location = new System.Drawing.Point(194, 5);
            this.pnlRightTop.Name = "pnlRightTop";
            this.pnlRightTop.Size = new System.Drawing.Size(810, 135);
            this.pnlRightTop.TabIndex = 3;
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewFolder.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFolder.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNewFolder.Appearance.Options.UseBackColor = true;
            this.btnNewFolder.Appearance.Options.UseFont = true;
            this.btnNewFolder.Appearance.Options.UseForeColor = true;
            this.btnNewFolder.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewFolder.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFolder.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnNewFolder.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnNewFolder.AppearanceHovered.Options.UseBackColor = true;
            this.btnNewFolder.AppearanceHovered.Options.UseFont = true;
            this.btnNewFolder.AppearanceHovered.Options.UseForeColor = true;
            this.btnNewFolder.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNewFolder.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFolder.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnNewFolder.AppearancePressed.Options.UseBackColor = true;
            this.btnNewFolder.AppearancePressed.Options.UseFont = true;
            this.btnNewFolder.AppearancePressed.Options.UseForeColor = true;
            this.btnNewFolder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnNewFolder.Location = new System.Drawing.Point(405, 12);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(127, 109);
            this.btnNewFolder.TabIndex = 14;
            this.btnNewFolder.Text = "New Folder";
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // lblFileInfo
            // 
            this.lblFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileInfo.AutoSize = true;
            this.lblFileInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileInfo.Location = new System.Drawing.Point(665, 3);
            this.lblFileInfo.Name = "lblFileInfo";
            this.lblFileInfo.Size = new System.Drawing.Size(90, 15);
            this.lblFileInfo.TabIndex = 13;
            this.lblFileInfo.Text = "-File Details-";
            // 
            // txtFileSize
            // 
            this.txtFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileSize.EditValue = "...";
            this.txtFileSize.Location = new System.Drawing.Point(617, 96);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtFileSize.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileSize.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFileSize.Properties.Appearance.Options.UseBackColor = true;
            this.txtFileSize.Properties.Appearance.Options.UseFont = true;
            this.txtFileSize.Properties.Appearance.Options.UseForeColor = true;
            this.txtFileSize.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtFileSize.Properties.ReadOnly = true;
            this.txtFileSize.Size = new System.Drawing.Size(188, 22);
            this.txtFileSize.TabIndex = 11;
            // 
            // lblFileSize
            // 
            this.lblFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSize.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileSize.Location = new System.Drawing.Point(572, 99);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(39, 15);
            this.lblFileSize.TabIndex = 12;
            this.lblFileSize.Text = "Size:";
            // 
            // txtFileDate
            // 
            this.txtFileDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileDate.EditValue = "...";
            this.txtFileDate.Location = new System.Drawing.Point(617, 72);
            this.txtFileDate.Name = "txtFileDate";
            this.txtFileDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtFileDate.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileDate.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFileDate.Properties.Appearance.Options.UseBackColor = true;
            this.txtFileDate.Properties.Appearance.Options.UseFont = true;
            this.txtFileDate.Properties.Appearance.Options.UseForeColor = true;
            this.txtFileDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtFileDate.Properties.ReadOnly = true;
            this.txtFileDate.Size = new System.Drawing.Size(188, 22);
            this.txtFileDate.TabIndex = 9;
            // 
            // lblFileDate
            // 
            this.lblFileDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileDate.AutoSize = true;
            this.lblFileDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileDate.Location = new System.Drawing.Point(570, 75);
            this.lblFileDate.Name = "lblFileDate";
            this.lblFileDate.Size = new System.Drawing.Size(41, 15);
            this.lblFileDate.TabIndex = 10;
            this.lblFileDate.Text = "Date:";
            // 
            // txtFileType
            // 
            this.txtFileType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileType.EditValue = "";
            this.txtFileType.Location = new System.Drawing.Point(617, 48);
            this.txtFileType.Name = "txtFileType";
            this.txtFileType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtFileType.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileType.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFileType.Properties.Appearance.Options.UseBackColor = true;
            this.txtFileType.Properties.Appearance.Options.UseFont = true;
            this.txtFileType.Properties.Appearance.Options.UseForeColor = true;
            this.txtFileType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtFileType.Properties.ReadOnly = true;
            this.txtFileType.Size = new System.Drawing.Size(188, 22);
            this.txtFileType.TabIndex = 7;
            // 
            // lblFileType
            // 
            this.lblFileType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileType.AutoSize = true;
            this.lblFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileType.Location = new System.Drawing.Point(570, 51);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(41, 15);
            this.lblFileType.TabIndex = 8;
            this.lblFileType.Text = "Type:";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.EditValue = "...";
            this.txtFileName.Location = new System.Drawing.Point(617, 24);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.txtFileName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFileName.Properties.Appearance.Options.UseBackColor = true;
            this.txtFileName.Properties.Appearance.Options.UseFont = true;
            this.txtFileName.Properties.Appearance.Options.UseForeColor = true;
            this.txtFileName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtFileName.Properties.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(188, 22);
            this.txtFileName.TabIndex = 4;
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFileName.Location = new System.Drawing.Point(562, 27);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(49, 15);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnDelete.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnDelete.AppearanceHovered.Options.UseBackColor = true;
            this.btnDelete.AppearanceHovered.Options.UseFont = true;
            this.btnDelete.AppearanceHovered.Options.UseForeColor = true;
            this.btnDelete.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnDelete.AppearancePressed.Options.UseBackColor = true;
            this.btnDelete.AppearancePressed.Options.UseFont = true;
            this.btnDelete.AppearancePressed.Options.UseForeColor = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnDelete.Location = new System.Drawing.Point(275, 68);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 53);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRename
            // 
            this.btnRename.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRename.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnRename.Appearance.Options.UseBackColor = true;
            this.btnRename.Appearance.Options.UseFont = true;
            this.btnRename.Appearance.Options.UseForeColor = true;
            this.btnRename.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRename.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnRename.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnRename.AppearanceHovered.Options.UseBackColor = true;
            this.btnRename.AppearanceHovered.Options.UseFont = true;
            this.btnRename.AppearanceHovered.Options.UseForeColor = true;
            this.btnRename.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRename.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRename.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnRename.AppearancePressed.Options.UseBackColor = true;
            this.btnRename.AppearancePressed.Options.UseFont = true;
            this.btnRename.AppearancePressed.Options.UseForeColor = true;
            this.btnRename.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnRename.Location = new System.Drawing.Point(275, 12);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(127, 53);
            this.btnRename.TabIndex = 4;
            this.btnRename.Text = "Rename";
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDownload.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Appearance.Options.UseBackColor = true;
            this.btnDownload.Appearance.Options.UseFont = true;
            this.btnDownload.Appearance.Options.UseForeColor = true;
            this.btnDownload.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDownload.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnDownload.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnDownload.AppearanceHovered.Options.UseBackColor = true;
            this.btnDownload.AppearanceHovered.Options.UseFont = true;
            this.btnDownload.AppearanceHovered.Options.UseForeColor = true;
            this.btnDownload.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDownload.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnDownload.AppearancePressed.Options.UseBackColor = true;
            this.btnDownload.AppearancePressed.Options.UseFont = true;
            this.btnDownload.AppearancePressed.Options.UseForeColor = true;
            this.btnDownload.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnDownload.Location = new System.Drawing.Point(145, 12);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(127, 109);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpload.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Appearance.Options.UseBackColor = true;
            this.btnUpload.Appearance.Options.UseFont = true;
            this.btnUpload.Appearance.Options.UseForeColor = true;
            this.btnUpload.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpload.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnUpload.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnUpload.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpload.AppearanceHovered.Options.UseFont = true;
            this.btnUpload.AppearanceHovered.Options.UseForeColor = true;
            this.btnUpload.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpload.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnUpload.AppearancePressed.Options.UseBackColor = true;
            this.btnUpload.AppearancePressed.Options.UseFont = true;
            this.btnUpload.AppearancePressed.Options.UseForeColor = true;
            this.btnUpload.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnUpload.Location = new System.Drawing.Point(19, 12);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(123, 109);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.btnQuit);
            this.pnlLeft.Controls.Add(this.btnInfo);
            this.pnlLeft.Controls.Add(this.btnChooseServer);
            this.pnlLeft.Controls.Add(this.txtCurrServer);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 5);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(194, 551);
            this.pnlLeft.TabIndex = 2;
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuit.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Appearance.Options.UseBackColor = true;
            this.btnQuit.Appearance.Options.UseFont = true;
            this.btnQuit.Appearance.Options.UseForeColor = true;
            this.btnQuit.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuit.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnQuit.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnQuit.AppearanceHovered.Options.UseBackColor = true;
            this.btnQuit.AppearanceHovered.Options.UseFont = true;
            this.btnQuit.AppearanceHovered.Options.UseForeColor = true;
            this.btnQuit.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnQuit.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnQuit.AppearancePressed.Options.UseBackColor = true;
            this.btnQuit.AppearancePressed.Options.UseFont = true;
            this.btnQuit.AppearancePressed.Options.UseForeColor = true;
            this.btnQuit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnQuit.Location = new System.Drawing.Point(3, 479);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(186, 66);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfo.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInfo.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Appearance.Options.UseBackColor = true;
            this.btnInfo.Appearance.Options.UseFont = true;
            this.btnInfo.Appearance.Options.UseForeColor = true;
            this.btnInfo.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInfo.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnInfo.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnInfo.AppearanceHovered.Options.UseBackColor = true;
            this.btnInfo.AppearanceHovered.Options.UseFont = true;
            this.btnInfo.AppearanceHovered.Options.UseForeColor = true;
            this.btnInfo.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInfo.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnInfo.AppearancePressed.Options.UseBackColor = true;
            this.btnInfo.AppearancePressed.Options.UseFont = true;
            this.btnInfo.AppearancePressed.Options.UseForeColor = true;
            this.btnInfo.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnInfo.Location = new System.Drawing.Point(3, 105);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(186, 66);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "Information";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnChooseServer
            // 
            this.btnChooseServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseServer.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseServer.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseServer.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnChooseServer.Appearance.Options.UseBackColor = true;
            this.btnChooseServer.Appearance.Options.UseFont = true;
            this.btnChooseServer.Appearance.Options.UseForeColor = true;
            this.btnChooseServer.AppearanceHovered.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnChooseServer.AppearanceHovered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseServer.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.btnChooseServer.AppearanceHovered.ForeColor = System.Drawing.Color.White;
            this.btnChooseServer.AppearanceHovered.Options.UseBackColor = true;
            this.btnChooseServer.AppearanceHovered.Options.UseFont = true;
            this.btnChooseServer.AppearanceHovered.Options.UseForeColor = true;
            this.btnChooseServer.AppearancePressed.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnChooseServer.AppearancePressed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseServer.AppearancePressed.ForeColor = System.Drawing.Color.White;
            this.btnChooseServer.AppearancePressed.Options.UseBackColor = true;
            this.btnChooseServer.AppearancePressed.Options.UseFont = true;
            this.btnChooseServer.AppearancePressed.Options.UseForeColor = true;
            this.btnChooseServer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnChooseServer.Location = new System.Drawing.Point(3, 36);
            this.btnChooseServer.Name = "btnChooseServer";
            this.btnChooseServer.Size = new System.Drawing.Size(186, 66);
            this.btnChooseServer.TabIndex = 0;
            this.btnChooseServer.Text = "Choose Server";
            this.btnChooseServer.Click += new System.EventHandler(this.btnChooseServer_Click);
            // 
            // txtCurrServer
            // 
            this.txtCurrServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrServer.Location = new System.Drawing.Point(3, 6);
            this.txtCurrServer.Name = "txtCurrServer";
            this.txtCurrServer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtCurrServer.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrServer.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCurrServer.Properties.Appearance.Options.UseBackColor = true;
            this.txtCurrServer.Properties.Appearance.Options.UseFont = true;
            this.txtCurrServer.Properties.Appearance.Options.UseForeColor = true;
            this.txtCurrServer.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCurrServer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCurrServer.Properties.ReadOnly = true;
            this.txtCurrServer.Size = new System.Drawing.Size(186, 24);
            this.txtCurrServer.TabIndex = 1;
            // 
            // pnlBot
            // 
            this.pnlBot.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 556);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(1004, 5);
            this.pnlBot.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1004, 5);
            this.pnlTop.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 647);
            this.Controls.Add(this.pnlMainControl);
            this.Name = "FrmMain";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "FTP Application";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.pnlMainControl.ResumeLayout(false);
            this.pnlMainControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrDir.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gclServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwServer)).EndInit();
            this.pnlRightBot.ResumeLayout(false);
            this.pnlRightBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gclMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwMessage)).EndInit();
            this.pnlRightTop.ResumeLayout(false);
            this.pnlRightTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrServer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainControl;
        private System.Windows.Forms.Panel pnlLeft;
        private DevExpress.XtraEditors.TextEdit txtCurrServer;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Panel pnlTop;
        private DevExpress.XtraEditors.SimpleButton btnChooseServer;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private DevExpress.XtraEditors.SimpleButton btnInfo;
        private System.Windows.Forms.Panel pnlRightTop;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnRename;
        private DevExpress.XtraEditors.SimpleButton btnDownload;
        private DevExpress.XtraEditors.SimpleButton btnUpload;
        private System.Windows.Forms.Panel pnlRightBot;
        private DevExpress.XtraGrid.GridControl gclMessage;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwMessage;
        private DevExpress.XtraGrid.GridControl gclServer;
        private DevExpress.XtraGrid.Views.Grid.GridView gvwServer;
        private System.Windows.Forms.Label lblFileInfo;
        private DevExpress.XtraEditors.TextEdit txtFileSize;
        private System.Windows.Forms.Label lblFileSize;
        private DevExpress.XtraEditors.TextEdit txtFileDate;
        private System.Windows.Forms.Label lblFileDate;
        private DevExpress.XtraEditors.TextEdit txtFileType;
        private System.Windows.Forms.Label lblFileType;
        private DevExpress.XtraEditors.TextEdit txtFileName;
        private System.Windows.Forms.Label lblFileName;
        private DevExpress.XtraEditors.TextEdit txtCurrDir;
        private System.Windows.Forms.Label lblRemoteSite;
        private System.Windows.Forms.Label lblRoot;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private DevExpress.XtraEditors.SimpleButton btnClearMessage;
        private System.Windows.Forms.Label lblMessage;
        private DevExpress.XtraEditors.SimpleButton btnNewFolder;
    }
}

