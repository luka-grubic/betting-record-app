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
            this.Text = $"BettingRecordApp (v{CommonConstants.VERSION})";
        }



        // --- Actions ---

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TO DO
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TO DO
        }

        private void saveAndExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TO DO
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // --- Other
    }
}
