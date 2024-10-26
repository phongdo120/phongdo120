using static System.Formats.Asn1.AsnWriter;

namespace TracuuSV
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> studentScores = new Dictionary<string, double>
        {
            { "SV001", 8.5 },
            { "SV002", 7.8 },
            { "SV003", 9.2 },
            { "SV004", 6.5 }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTracuu_click(object sender, EventArgs e)
        {
            string studentID = txtMasinhvien.Text.Trim();

            // Kiểm tra mã sinh viên có trong danh sách hay không
            if (studentScores.ContainsKey(studentID))
            {
                double score = studentScores[studentID];
                MessageBox.Show($"Mã sinh viên {studentID}, {score}" , "Thông báo");
            }
            else
            {
                MessageBox.Show("Mã sinh viên không tồn tại!" , "Thông báo");
            }
        }

        private void btnExit_click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMasinhvien_click(object sender, EventArgs e)
        {

        }

        private void btnMasinhvien_click(object sender, EventArgs e)
        {

        }
    }
}
