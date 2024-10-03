using System;
using System.Windows.Forms;



namespace BettingRecordApp
{
    public partial class MainForm : Form
    {
        // --- Fields ---

        // --- Init ---

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = $"BettingRecordApp (v{CommonConstant.VERSION})";
        }



        // --- Actions ---

        // --- Other
    }
}
