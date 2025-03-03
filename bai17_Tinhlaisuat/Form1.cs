using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai17_Tinhlaisuat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double sotien = double.Parse(txtTien.Text);
            double ls = double.Parse(txtLai.Text.Replace("%", "")) / 100;
            int nam = Convert.ToInt32(txtNam.Text);
            double tienlai = 0;

            lstKq.Items.Clear();

            for (int i = 1; i <= nam; i++)
            {
                tienlai = sotien * ls;
                lstKq.Items.Add("năm " + i + ": vốn = " + string.Format("{0:N0}", sotien) + " - tiền lãi: " + string.Format("{0:N2}", tienlai));
                sotien += tienlai;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTien.Text = "100000000";
            txtLai.Text = "7.5%";
            txtNam.Text = "10";
        }
    }
}
