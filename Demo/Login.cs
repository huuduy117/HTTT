using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }
        bool Check_Textbox(string host, string port, string sid, string user, string pass)
        {
            if (host == "")
            {
                MessageBox.Show("Chưa điền thông tin Host");
                txt_Host.Focus();
                return false;
            }
            else if (port == "")
            {
                MessageBox.Show("Chưa điền thông tin Post");
                txt_Port.Focus();
                return false;
            }
            else if (sid == "")
            {
                MessageBox.Show("Chưa điền thông tin Sid");
                txt_Sid.Focus();
                return false;
            }
            else if (user == "")
            {
                MessageBox.Show("Chưa điền thông tin User");
                txt_Username.Focus();
                return false;
            }
            else if (pass == "")
            {
                MessageBox.Show("Chưa điền thông tin Password");
                txt_Password.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string host = txt_Host.Text;
            string post = txt_Port.Text;
            string sid = txt_Sid.Text;
            string user = txt_Username.Text;
            string pass = txt_Password.Text;

            if (Check_Textbox(host, post, sid, user, pass))
            {
                Database.Set_Database(host, post, sid, user, pass);
                if (Database.Connect())
                {
                    OracleConnection c = Database.Get_Connect();
                    MessageBox.Show("Đăng nhập thành công\nServerVersion: " + c.ServerVersion);
                    //MaHoaDoiXungCong mh = new MaHoaDoiXungCong();
                    MaHoaDoiXungNhan mh = new MaHoaDoiXungNhan();
                    mh.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
        }
    }
}
