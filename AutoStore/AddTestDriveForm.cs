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
    public partial class AddTestDriveForm : Form
    {
        DataBase dataBase = new DataBase();

        public AddTestDriveForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void autoid_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            int autoid;
            int clientid;
            int employeeid;
            var date = date1_textBox.Text;

            if(int.TryParse(autoid1_textBox.Text, out autoid) )
            { 
                if(int.TryParse(clientid1_textBox.Text, out clientid) )
                {
                    if(int.TryParse(employeeid1_textBox.Text, out employeeid) )
                    {
                        var addQuery = $"INSERT INTO ЗапросыНаТестДрайв (ID_Автомобиля, ID_Клиента, ID_Сотрудника, Дата_запроса)" +
                            $"VALUES ('{autoid}','{clientid}','{employeeid}','{date}')";

                        var command = new SqlCommand(addQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();
                        MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
            this.Hide();
        }
    }
}
