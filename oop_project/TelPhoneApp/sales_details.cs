using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelPhoneApp
    {
    public partial class sales_details : Form
    {
        DataTable table1 = new DataTable();
        public sales_details()
        {
            InitializeComponent();
            dataGridView2.DataSource = table1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void calbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("판매 내역창으로 이동합니다.");
            sales_details sd = new sales_details();
            sd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메인 홈으로 이동합니다.");
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
