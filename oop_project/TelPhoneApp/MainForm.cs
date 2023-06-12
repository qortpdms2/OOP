using System;
using System.Data;
using System.Windows.Forms;



namespace TelPhoneApp {
    public partial class MainForm : Form {
        DataTable table = new DataTable();

        public MainForm() {
            InitializeComponent();
            table.Columns.Add("Name",typeof(string));
            table.Columns.Add("Price", typeof(string));
            table.Columns.Add("Count", typeof(string));
            table.Columns.Add("Total", typeof(string));

            dataGridView1.DataSource = table;
            countbox.Value = 1;

        }
        private void UpdateDisplay(People lt) {
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            if(menubox.Text == "" || pricebox.Text == "")
            {
                MessageBox.Show("항목을 정확이 입력해주세요");
                menubox.Clear();
                pricebox.Clear();
            }
            else
            {
                decimal price = decimal.Parse(pricebox.Text);
                decimal count = countbox.Value;
                decimal total = price * count;

                table.Rows.Add(menubox.Text, pricebox.Text,countbox.Value,total);
                dataGridView1.DataSource = table;

                menubox.Clear();
                pricebox.Clear();
                countbox.Value = 1;

                decimal all = 0;
                for(int i=0; i < dataGridView1.Rows.Count; ++i)
                {
                    all += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
                }
                sumbox.Text = all.ToString();

            }
        }
        private void btnSearch_Click(object sender, EventArgs e) {
        }
        private void btnRemove_Click(object sender, EventArgs e) {          
            foreach(DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }

            decimal all = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                all += Convert.ToDecimal(dataGridView1.Rows[i].Cells[3].Value);
            }

            sumbox.Text = all.ToString();
        }
        private void btnPrint_Click(object sender, EventArgs e) {}

        private void txtPhone_TextChanged(object sender, EventArgs e){}

        private void label3_Click(object sender, EventArgs e){}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bse1 사장님 환영합니다!");
        }

        private void menubox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void countbox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sumbox.Text + "원 계산되었습니다.");
            int rowCount = dataGridView1.Rows.Count;
            for(int n = 0; n < rowCount; n++)
            {
                if (dataGridView1.Rows[0].IsNewRow == false) dataGridView1.Rows.RemoveAt(0);
            }
            sumbox.Text = "";
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sales_details s = new sales_details();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            stock s = new stock();
            s.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }
    }
}
