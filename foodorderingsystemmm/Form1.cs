
using System;
using System.Windows.Forms;
namespace foodorderingsystemmm
{
    public partial class frm_front : Form
    {
        public frm_front()
        {
            InitializeComponent();
        }

        private void btn_ordernow_Click(object sender, EventArgs e)
        {

            Form items = new frm_items();
            items.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("confirm you want to exit this system",
                "ordering system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
