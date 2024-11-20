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
    public partial class MaHoa : Form
    {
        public MaHoa()
        {
            InitializeComponent();
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            MaHoaDoiXungCong formCong = new MaHoaDoiXungCong();
            formCong.Show(); 
            this.Hide();  
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            MaHoaDoiXungNhan formNhan = new MaHoaDoiXungNhan();
            formNhan.Show(); 
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
