namespace FTP_Modern_UI
{
    /// <summary>
    /// Form Information extend metro form.
    ///  </summary>
    public partial class FrmInfo : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public FrmInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button close click event.
        /// </summary>
        /// <param name="sender"/>
        /// <param name="e"/>
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
