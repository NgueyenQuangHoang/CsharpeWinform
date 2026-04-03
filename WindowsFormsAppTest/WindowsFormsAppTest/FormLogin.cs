using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class FormLogin : Form
    {
        private readonly UserService _userService = new UserService();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _userService.Login(txtUsername.Text.Trim(), txtPassword.Text);

            if (user != null)
            {
                MessageBox.Show($"Xin chào, {user.FullName}!", "Đăng nhập thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mở form chính sau khi đăng nhập
                // var main = new FormMain(user);
                // main.Show();
                // this.Hide();
            }
            else
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Sai tên đăng nhập hoặc mật khẩu!";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            {
                var registerForm = new FormRegister();
                registerForm.ShowDialog(); // mở form đăng ký dạng popup
            }
        }
    }
}
