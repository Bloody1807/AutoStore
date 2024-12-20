using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoStore
{
    public partial class Sign_in_Form : Form
    {

        DataBase dataBase = new DataBase();  

        public Sign_in_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_in_Load(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            loginTextBox.MaxLength = 50;
            passwordTextBox.MaxLength = 50;

        }


        private void btn_sign_in(object sender, EventArgs e)
        {
            var loginUser = loginTextBox.Text;
            var passwordUser = passwordTextBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT * FROM Пользователи WHERE Логин = '{loginUser}' and Пароль = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainf = new MainForm();
                this.Hide();
                mainf.ShowDialog();

            }
            else
            {
                MessageBox.Show("Повторите попытку!", "Не успешно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
