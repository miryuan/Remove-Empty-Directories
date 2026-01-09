using System;
using System.Windows.Forms;

namespace RED2
{
    public partial class DeletionError : Form
    {
        public DeletionError()
        {
            InitializeComponent();
        }

        private void DeletionError_Load(object sender, EventArgs e)
        {

        }

        internal void SetPath(string path)
        {
            this.tbPath.Text = path;
        }

        internal void SetErrorMessage(string msg)
        {
            this.tbErrorMessage.Text = msg;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
