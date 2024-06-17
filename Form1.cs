using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

 namespace CSharp_TinhLaiNganHang
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

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double tienlai;
            double sotien = double.Parse(txtSotien.Text);
            double laisuat = double.Parse(txtlaisuat.Text.Replace("%", "")) / 100;
            int sonam = int.Parse(txtSonam.Text);
            for (int i = 1;i <= 20; i++)
            {
                tienlai = sotien * laisuat;
                lsbkq.Items.Add("Năm: "+i+" số tiền là: "+tienlai);
                sotien += tienlai;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            }

        private void lsbkq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

