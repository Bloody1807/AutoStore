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
    public partial class AddAutoForm : Form
    {

        DataBase dataBase = new DataBase();

        public AddAutoForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var marka = marka_textBox1.Text;
            var model = model_textBox1.Text;
            int year;
            int price;
            int km;
            int provider;
            var color = color_textBox1.Text;


            if (int.TryParse(year_textBox1.Text, out year))
            {
                if (int.TryParse(price_textBox1.Text, out price))
                {
                    if (int.TryParse(km_textBox1.Text, out km))
                    {
                        if (int.TryParse(provider_textBox1.Text, out provider))
                        {
                            var addQuery = $"INSERT INTO Автомобили (Марка, Модель, " +
                                 $"  Год_выпуска, Цвет, Цена, Пробег, ID_Поставщика)" +
                                 $"  VALUES ('{marka}', '{model}', '{year}', '{color}', '{price}', '{km}', '{provider}')";

                            var command = new SqlCommand(addQuery, dataBase.getConnection());
                            command.ExecuteNonQuery();
                            MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
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
