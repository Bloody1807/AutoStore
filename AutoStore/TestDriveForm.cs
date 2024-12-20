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
using System.Diagnostics;
using System.Reflection;

namespace AutoStore
{
    public partial class TestDriveForm : Form
    {

        DataBase dataBase = new DataBase();
        int selectedRow;

        public TestDriveForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView4.Columns.Add("ID_Запроса", "ID");
            dataGridView4.Columns.Add("ID_Автомобиля", "ID Автомобиля");
            dataGridView4.Columns.Add("ID_Клиента", "ID Клиента");
            dataGridView4.Columns.Add("ID_Сотрудника", "ID Сотрудника");
            dataGridView4.Columns.Add("Дата_запроса", "Дата запроса");
            dataGridView4.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3),
                record.GetDateTime(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM ЗапросыНаТестДрайв";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }

        private void new_Click(object sender, EventArgs e)
        {
            AddTestDriveForm addf = new AddTestDriveForm();
            addf.Show();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView4.CurrentCell.RowIndex;

            int autoid;
            int clientid;
            int employeeid;
            var date = date_textBox.Text;


            if (dataGridView4.Rows[selectedRowIndex].Cells[1].Value.ToString() != String.Empty)
            {
                if (int.TryParse(autoid_textBox.Text, out autoid))
                {
                    if (int.TryParse(clientid_textBox.Text, out clientid))
                    {
                        if (int.TryParse(employeeid_textBox.Text, out employeeid))
                        {
                            dataGridView4.Rows[selectedRowIndex].Cells[1].Value = (autoid);
                            dataGridView4.Rows[selectedRowIndex].Cells[2].Value = (clientid);
                            dataGridView4.Rows[selectedRowIndex].Cells[3].Value = (employeeid);
                            dataGridView4.Rows[selectedRowIndex].Cells[4].Value = (date);
                            dataGridView4.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                        }
                        else
                        {
                            MessageBox.Show("Неверные данные!");
                        }
                    }
                }
            }
        }

        private void refactor_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Updatee();
        }

        private void DeleteRow()
        {
            int index = dataGridView4.CurrentCell.RowIndex;

            dataGridView4.Rows[index].Visible = false;


            dataGridView4.Rows[index].Cells[5].Value = RowState.Deleted;
            return;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void Updatee()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView4.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView4.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView4.Rows[index].Cells[0].Value);



                    var deleteQuery = $"DELETE FROM ЗапросыНаТестДрайв WHERE ID_Запроса = '{id}'";




                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView4.Rows[index].Cells[0].Value.ToString();
                    var autoid = dataGridView4.Rows[index].Cells[1].Value.ToString();
                    var clientid = dataGridView4.Rows[index].Cells[2].Value.ToString();
                    var employeeid = dataGridView4.Rows[index].Cells[3].Value.ToString();
                    var date = dataGridView4.Rows[index].Cells[4].Value.ToString();

                    var changeQuery = $"UPDATE ЗапросыНаТестДрайв SET ID_Автомобиля = '{autoid}', ID_Клиента = '{clientid}', ID_Сотрудника = {employeeid}, Дата_запроса = '{date}'" +
                        $"WHERE ID_Запроса = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();


                }



            }

            dataBase.closeConnection();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView4);
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            this.Hide();
            mainf.ShowDialog();
        }

        private void dgw_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView4.Rows[selectedRow];

                autoid_textBox.Text = row.Cells[1].Value.ToString();
                clientid_textBox.Text = row.Cells[2].Value.ToString();
                employeeid_textBox.Text = row.Cells[3].Value.ToString();
                date_textBox.Text = row.Cells[4].Value.ToString();

            }
        }

        private void TestDriveForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView4);
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = "SELECT * FROM ЗапросыНаТестДрайв WHERE CONCAT " +
                "   (ID_Запроса, ID_Автомобиля, ID_Клиента, ID_Сотрудника, Дата_запроса) LIKE '%" + search_textbox.Text + "%'";
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
            Search(dataGridView4);
        }
    }
}
