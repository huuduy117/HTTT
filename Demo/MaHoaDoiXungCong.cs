using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class MaHoaDoiXungCong : Form
    {
        public MaHoaDoiXungCong()
        {
            InitializeComponent();
            CenterToScreen();
            rdo_MaHoa.Checked = true;
        }

        private char maHoaKyTu(char c, int k)
        {
            if (Char.IsLetter(c))
            {
                if (Char.IsUpper(c)) 
                {
                    return (char)((c - 'A' + k) % 26 + 'A');
                }
                else 
                {
                    return (char)((c - 'a' + k) % 26 + 'a');
                }
            }
            return c; 
        }

        private void maHoaMessage(string msg, int k)
        {
            string result = "";
            txt_Result.Text = "";
            foreach (char c in msg)
            {
                result += maHoaKyTu(c, k);
            }
            txt_Result.Text = result;
        }

        private void rdo_MaHoa_CheckedChanged(object sender, EventArgs e)
        {
            btn_Run.Text = "Mã hóa";
        }

        private void rdo_GiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            btn_Run.Text = "Giải mã";
        }

        //private void LoadDataToComboBox()
        //{
        //    string connectionString = "User Id=huuduybaomat;Password=123;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl)))";

        //    string query = "SELECT noidung FROM DuLieu";

        //    try
        //    {
        //        using (OracleConnection connection = new OracleConnection(connectionString))
        //        {
        //            connection.Open();
        //            using (OracleCommand command = new OracleCommand(query, connection))
        //            {
        //                using (OracleDataReader reader = command.ExecuteReader())
        //                {
        //                    while (reader.Read())
        //                    {
        //                        string noidung = reader["noidung"].ToString();
        //                        Console.WriteLine(noidung);
        //                        cbb_noidung.Items.Add(noidung);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}\n{ex.StackTrace}");
        //    }
        //}

        private void btn_Run_Click(object sender, EventArgs e)
        {
            string msg = cbb_noidung.Text;
            if (string.IsNullOrEmpty(msg))
            {
                MessageBox.Show("Vui lòng chọn nội dung từ ComboBox!");
                return;
            }

            int k = (int)mr_Key.Value;
            if (rdo_GiaiMa.Checked)
            {
                k = 26 - k;
            }
            maHoaMessage(msg, k);
        }

        private void MaHoaDoiXungCong_Load(object sender, EventArgs e)
        {
            //LoadDataToComboBox();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MaHoa formMain = new MaHoa();
            formMain.Show();
            this.Hide();
        }
    }
}
