using System;
using System.Windows.Forms;

namespace TelPhoneApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (ID.Text == "bse1" && Password.Text == "0822")
            {
                MessageBox.Show("로그인 성공");
                this.Hide();

                MainForm mainform1 = new MainForm();
                mainform1.Show();
            }
            else MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (ID.Text == "bse1" && Password.Text == "0822")
            {
                MessageBox.Show("로그인 성공");
                this.Hide();

                MainForm mainform1 = new MainForm();
                mainform1.Show();
            }
            else if(ID.Text != "bse1" || Password.Text !="0822") MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
            else MessageBox.Show("아이디 또는 비밀번호를 입력해주세요.");
        }
    }
}
