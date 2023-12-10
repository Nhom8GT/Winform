using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoSoKhachHang
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Length == 0 && txtPass.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống");
            }
            else if (txtUser.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản không được bỏ trống");
            }
            else if (txtPass.Text.Length == 0)
            {
                MessageBox.Show("Mật khẩu không được bỏ trống");
            }
            else
            {
                if (txtUser.Text == "admin01" && txtPass.Text == "12345")
                {
                    this.Hide();
                    Home f1 = new Home();
                    f1.ShowDialog();
                    this.Close();
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Tài khoản không hợp lệ");
                }
            }
        }
    }
}
