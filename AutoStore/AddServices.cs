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
    public partial class AddServices : Form
    {

        DataBase dataBase = new DataBase();

        public AddServices()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void autoid1_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_buttonClick(object sender, EventArgs e)
        {

            dataBase.openConnection();


            int autoid;
            var date = data1_textBox.Text;
            var opis = opis1_textBox.Text;
            int price;

            if (int.TryParse(autoid1_textBox.Text, out autoid))
            {
                if (int.TryParse(price1_textBox.Text, out price)) 
                {
                    var addQuery = $"INSERT INTO СервисноеОбслуживание (ID_Автомобиля, Дата_обслуживания, Описание_работ, Стоимость) " +
                        $"  VALUES ('{autoid}','{date}','{opis}','{price}')";

                    var command = new SqlCommand(addQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Неверный тип данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
            this.Hide();

        }
    }
}