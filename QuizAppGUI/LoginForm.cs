using System;
using System.Windows.Forms;

namespace QuizAppGUI
{
    public partial class LoginForm : Form
    {
        public string UserRole { get; private set; } = "user";
        public string UserName { get; private set; } = "";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "admin")
            {
                UserRole = "admin";
                UserName = txtUser.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (!string.IsNullOrWhiteSpace(txtUser.Text))
            {
                UserRole = "user";
                UserName = txtUser.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Date de autentificare incorecte!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
