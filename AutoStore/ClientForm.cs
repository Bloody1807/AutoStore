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
using System.Net.Sockets;

namespace AutoStore
{
    public partial class ClientForm : Form
    {

        DataBase dataBase = new DataBase();

        int selectedRow;

        public ClientForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView3.Columns.Add("ID_Клиента", "ID");
            dataGridView3.Columns.Add("Фамилия", "Фамилия");
            dataGridView3.Columns.Add("Имя", "Имя");
            dataGridView3.Columns.Add("Отчество", "Отчество");
            dataGridView3.Columns.Add("Адрес", "Адрес");
            dataGridView3.Columns.Add("Телефон", "Телефон");
            dataGridView3.Columns.Add("Почта", "Почта");
            dataGridView3.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3),
                record.GetString(4), record.GetString(5), record.GetString(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Клиенты"; 

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void new_record_Click(object sender, EventArgs e)
        {
            AddClientForm addf = new AddClientForm(); 
            addf.Show();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView3.CurrentCell.RowIndex;

            var lastName = last_textBox.Text; 
            var firstName = first_textBox.Text; 
            var middleName = middle_textBox.Text; 
            var phone = number_textBox.Text; 
            var email = email_textBox.Text;
            var address = adress_textBox.Text;

            if (dataGridView3.Rows[selectedRowIndex].Cells[1].Value.ToString() != String.Empty)
            {
                dataGridView3.Rows[selectedRowIndex].Cells[1].Value = lastName;
                dataGridView3.Rows[selectedRowIndex].Cells[2].Value = firstName;
                dataGridView3.Rows[selectedRowIndex].Cells[3].Value = middleName;
                dataGridView3.Rows[selectedRowIndex].Cells[4].Value = address;
                dataGridView3.Rows[selectedRowIndex].Cells[5].Value = phone;
                dataGridView3.Rows[selectedRowIndex].Cells[6].Value = email;
                dataGridView3.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified; 
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }

        private void refactor_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void Updatee()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView3.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView3.Rows[index].Cells[7].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView3.Rows[index].Cells[0].Value);



                    var deleteQuery = $"DELETE FROM Клиенты WHERE ID_Клиента = '{id}'";




                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView3.Rows[index].Cells[0].Value.ToString();
                    var lastname = dataGridView3.Rows[index].Cells[1].Value.ToString();
                    var firstname = dataGridView3.Rows[index].Cells[2].Value.ToString();
                    var middlename = dataGridView3.Rows[index].Cells[3].Value.ToString();
                    var address = dataGridView3.Rows[index].Cells[4].Value.ToString();
                    var phone = dataGridView3.Rows[index].Cells[5].Value.ToString();
                    var email = dataGridView3.Rows[index].Cells[6].Value.ToString();

                    var changeQuery = $"UPDATE Клиенты SET Фамилия = '{lastname}', Имя = '{firstname}', Отчество = '{middlename}', Адрес = '{address}', " +
                        $"Телефон = '{phone}', Почта = '{email}' WHERE ID_Клиента = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();


                }



            }

            dataBase.closeConnection();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Updatee();
        }

        private void deleteRow()
        {
            int index = dataGridView3.CurrentCell.RowIndex;

            dataGridView3.Rows[index].Visible = false;


            dataGridView3.Rows[index].Cells[7].Value = RowState.Deleted;
            return;

        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView3);
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            this.Hide();
            mainf.ShowDialog();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView3);
        }

        private void dgw_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView3.Rows[selectedRow];

                last_textBox.Text = row.Cells[1].Value.ToString();
                first_textBox.Text = row.Cells[2].Value.ToString();
                middle_textBox.Text = row.Cells[3].Value.ToString();
                adress_textBox.Text = row.Cells[4].Value.ToString();
                number_textBox.Text = row.Cells[5].Value.ToString();
                email_textBox.Text = row.Cells[6].Value.ToString();

            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = "SELECT * FROM Клиенты WHERE CONCAT " +
                "   (ID_Клиента, Фамилия, Имя, Отчество, Адрес, Телефон, Почта) LIKE '%" + search_textbox.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }

            read.Close();


        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView3);
        }
    }
}
