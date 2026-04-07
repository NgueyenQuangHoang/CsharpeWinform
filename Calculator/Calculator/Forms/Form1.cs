using System;
using System.Windows.Forms;
using Calculator.Services;

namespace Calculator.Forms
{
    public partial class Form1 : Form
    {
        private CalculatorService service = new CalculatorService();

        public Form1()
        {
            InitializeComponent();
        }

        private bool LayHaiSo(out double a, out double b)
        {
            if (!double.TryParse(txtSo1.Text, out a))
            {
                MessageBox.Show("Số thứ nhất không hợp lệ!");
                txtSo1.Focus();
                b = 0;
                return false;
            }

            if (!double.TryParse(txtSo2.Text, out b))
            {
                MessageBox.Show("Số thứ hai không hợp lệ!");
                txtSo2.Focus();
                return false;
            }

            return true;
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (LayHaiSo(out double a, out double b))
                txtKetQua.Text = service.Cong(a, b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (LayHaiSo(out double a, out double b))
                txtKetQua.Text = service.Tru(a, b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (LayHaiSo(out double a, out double b))
                txtKetQua.Text = service.Nhan(a, b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (LayHaiSo(out double a, out double b))
            {
                try
                {
                    txtKetQua.Text = service.Chia(a, b).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKetQua.Clear();
            txtSo1.Focus();
        }
    }
}