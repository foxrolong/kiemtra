using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                double toan = Convert.ToDouble(txtDiemToan.Text);
                double ly = Convert.ToDouble(txtDiemLy.Text);
                double hoa = Convert.ToDouble(txtDiemHoa.Text);
                double anh = Convert.ToDouble(txtDiemTiengAnh.Text);

                if (toan< 0||toan >  10 || ly < 0  || ly > 10 ||  hoa < 0 ||  hoa> 10 || anh< 0 ||anh > 10)
                {
                    MessageBox.Show("điểm các môn 0 -> 10", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // điểm trung bình
                double diemTB = (toan + ly + hoa + anh) / 4;

                // làm tròn 2 trữ số thập phân
                diemTB = Math.Round(diemTB, 2);

                // xếp loại thang điểm học tập
                string xeploai = "";
                if (diemTB >= 8.0)
                {
                    xeploai = "Gioi";
                }
                else if (diemTB >= 6.5)
                {
                    xeploai = "Khá";
                }
                else if (diemTB >= 5.0)
                {
                    xeploai = "Trung bình";
                }
                else
                {
                    xeploai = "Yếu";
                }

                txtDiemTrungBinh.Text = diemTB.ToString();
                txtXepLoai.Text = xeploai;
            }
            catch (FormatException)
            {
                MessageBox.Show("vui lofng nhâp đúng định  dạng","lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("bạn muốn thoát ứng  dun khong?","xac nhận thoast",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txtDiemHoa.Clear();
            txtDiemLy.Clear();
            txtDiemToan.Clear();
            txtDiemTiengAnh.Clear();
            txtDiemTrungBinh.Clear();
            txtXepLoai.Clear();
            txtDiemToan.Focus();
        }
    }
}
