using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiemtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            BAI1.Form1 bai1Form = new BAI1.Form1();
            bai1Form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BAI2.Form1 bai2Form = new BAI2.Form1();
            bai2Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAI3.Form1 bai3Form = new BAI3.Form1();
            bai3Form.Show();
        }
    }
}
