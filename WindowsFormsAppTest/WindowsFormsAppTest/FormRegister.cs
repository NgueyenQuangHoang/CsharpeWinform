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
    public partial class FormRegister : Form
    {
        private readonly UserService _userService = new UserService();

        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Kiểm tra xác nhận mật khẩu
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Mật khẩu xác nhận không khớp!";
                return;
            }

            string error = _userService.Register(
                txtUsername.Text.Trim(),
                txtPassword.Text,
                txtFullName.Text.Trim()
            );

            if (error != null)
            {
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = error;
            }
            else
            {
                MessageBox.Show("Đăng ký thành công! Bạn có thể đăng nhập.",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // đóng form đăng ký, quay về form đăng nhập
            }
        }
    }
}
