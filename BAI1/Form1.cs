using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            try
            {
                double soLuong = Convert.ToDouble(txtSoLuong.Text);
                double dongia = Convert.ToDouble(txtDonGia.Text);

                // thành tiền
                double thanhtien = soLuong *dongia;

                // thành tiền
                double giamgia=0;
                if (rdoKhachThanThiet.Checked)
                {
                    giamgia= thanhtien * 0.08;
                }

                // thuế 10%
                double vat= (thanhtien -giamgia)* 0.10;

                // tổng
                double tongcong= (thanhtien - giamgia) + vat;

                txtThanhTien.Text= thanhtien.ToString()  ;
                txtGiamGia.Text= giamgia.ToString();
                txtThue.Text =vat.ToString();
                txtTong.Text = tongcong.ToString() ;
            }
            catch (FormatException)
            {
                MessageBox.Show("vui long nhap đúng đin dạng","lỗi định dạng",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // bắt các lỗi khác
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
                txtMaHang.Clear();
                txtSoLuong.Clear();
                txtDonGia.Clear();
                txtThanhTien.Clear();
                txtGiamGia.Clear();
                txtThue.Clear();
                txtTong.Clear();
                rdoKhachThanThiet.Checked= false;
                txtMaHang.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult thoat = MessageBox.Show("ban có chac muon thoat ko?","Xác nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (thoat == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
