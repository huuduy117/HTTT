using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class MaHoaDoiXungNhan : Form
    {
        public MaHoaDoiXungNhan()
        {
            InitializeComponent();
            CenterToScreen();
            rdo_MaHoa.Checked = true;
        }
        //Tim nghich dao cua k
        private int ModularInverse(int k, int mod)
        {
            for (int i = 1; i < mod; i++)
            {
                if ((k * i) % mod == 1)
                    return i;
            }
            throw new Exception($"Không tồn tại nghịch đảo modular cho khóa {k}!");
        }

        private char maHoaKyTu(char c, int k)
        {
            if (Char.IsLetter(c))
            {
                int modBase = Char.IsUpper(c) ? 'A' : 'a';
                return (char)(((c - modBase) * k) % 26 + modBase);
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


        //private void LoadDataToComboBox()
        //{
        //    string connectionString = "User Id=huuduybaomat;Password=123;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=orcl5)))";

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

        


        private void rdo_MaHoa_CheckedChanged(object sender, EventArgs e)
        {

            btn_Run.Text = "Mã hóa";
        }

        private void rdo_GiaiMa_CheckedChanged(object sender, EventArgs e)
        {

            btn_Run.Text = "Giải mã";

        }

        private void MaHoaDoiXungNhan_Load(object sender, EventArgs e)
        {
            //LoadDataToComboBox();
        }

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
                try
                {
                    k = ModularInverse(k, 26);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}");
                    return;
                }
            }
            maHoaMessage(msg, k);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            MaHoa formMain = new MaHoa();
            formMain.Show();
            this.Hide();
        }
    }
}
