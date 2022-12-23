namespace sanatoriy
{
    public partial class LoginForm : Form
    {
        string userLogin;
        string userpassword;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            userLogin = login.Text;
        }
    }
}