namespace Calculator.Forms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSo1 = new Label();
            lblSo2 = new Label();
            lblKetQua = new Label();
            txtSo1 = new TextBox();
            txtSo2 = new TextBox();
            txtKetQua = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnDel = new Button();
            SuspendLayout();
            // 
            // lblSo1
            // 
            lblSo1.Location = new Point(30, 50);
            lblSo1.Name = "lblSo1";
            lblSo1.Size = new Size(100, 23);
            lblSo1.TabIndex = 0;
            lblSo1.Text = "Số thứ nhất";
            // 
            // lblSo2
            // 
            lblSo2.Location = new Point(30, 110);
            lblSo2.Name = "lblSo2";
            lblSo2.Size = new Size(100, 23);
            lblSo2.TabIndex = 2;
            lblSo2.Text = "Số thứ hai";
            // 
            // lblKetQua
            // 
            lblKetQua.Location = new Point(30, 250);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(100, 23);
            lblKetQua.TabIndex = 9;
            lblKetQua.Text = "Kết quả";
            // 
            // txtSo1
            // 
            txtSo1.Location = new Point(170, 50);
            txtSo1.Name = "txtSo1";
            txtSo1.Size = new Size(250, 39);
            txtSo1.TabIndex = 1;
            // 
            // txtSo2
            // 
            txtSo2.Location = new Point(170, 110);
            txtSo2.Name = "txtSo2";
            txtSo2.Size = new Size(250, 39);
            txtSo2.TabIndex = 3;
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(170, 250);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.Size = new Size(250, 39);
            txtKetQua.TabIndex = 10;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(30, 170);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(75, 23);
            btnCong.TabIndex = 4;
            btnCong.Text = "+";
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(90, 170);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(75, 23);
            btnTru.TabIndex = 5;
            btnTru.Text = "-";
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(150, 170);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(75, 23);
            btnNhan.TabIndex = 6;
            btnNhan.Text = "*";
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(210, 170);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(75, 23);
            btnChia.TabIndex = 7;
            btnChia.Text = "/";
            btnChia.Click += btnChia_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(280, 170);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 23);
            btnDel.TabIndex = 8;
            btnDel.Text = "Del";
            btnDel.Click += btnDel_Click;
            // 
            // Form1
            // 
            BackColor = Color.Gainsboro;
            ClientSize = new Size(691, 504);
            Controls.Add(lblSo1);
            Controls.Add(txtSo1);
            Controls.Add(lblSo2);
            Controls.Add(txtSo2);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Controls.Add(btnDel);
            Controls.Add(lblKetQua);
            Controls.Add(txtKetQua);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblSo1;
        private System.Windows.Forms.Label lblSo2;
        private System.Windows.Forms.Label lblKetQua;

        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKetQua;

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnDel;
    }
}