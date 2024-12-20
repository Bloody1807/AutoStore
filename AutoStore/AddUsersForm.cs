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
    public partial class AddUsersForm : Form
    {

        DataBase dataBase = new DataBase();

        public AddUsersForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var login = login1_textBox.Text;
            var password = password1_textBox.Text;

            if (login != String.Empty && password != String.Empty)
            {
                    var addQuery = $"INSERT INTO Пользователи (Логин, Пароль)" +
                        $"VALUES ('{login}','{password}') ";

                    var command = new SqlCommand(addQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

            }
            else
            {
                MessageBox.Show("Неверный тип данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
        }
    }
}
