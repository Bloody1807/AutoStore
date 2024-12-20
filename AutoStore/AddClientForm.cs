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

    public partial class AddClientForm : Form
    {

        DataBase dataBase = new DataBase();

        public AddClientForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var lastname = last1_textBox.Text;
            var firstname = first1_textBox.Text;
            var middlename = middle1_textBox.Text;
            var address = adress1_textBox.Text;
            var phone = number1_textBox.Text;
            var email = email1_textBox.Text;

            if (string.IsNullOrWhiteSpace(lastname)) 
            {
                if (string.IsNullOrWhiteSpace(firstname))
                {
                    MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Hide();
                }

            }
            else

            {
                var addQuery = $"INSERT INTO Клиенты (Фамилия, Имя, Отчество, Адрес, Телефон, Почта)" +
                $"  VALUES ('{lastname}','{firstname}','{middlename}','{address}','{phone}','{email}')";
                var command = new SqlCommand(addQuery, dataBase.getConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();


            }

        }
    }
}
