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
using System.Reflection;

namespace AutoStore
{
    public partial class UsersForm : Form
    {

        DataBase dataBase = new DataBase();

        int selectedRow;

        public UsersForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_Пользователя", "ID");
            dataGridView1.Columns.Add("Логин", "Логин");
            dataGridView1.Columns.Add("Пароль ", "Пароль");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Пользователи";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var login = login_textBox.Text;
            var password = password_textBox.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString() != String.Empty)
            {
                dataGridView1.Rows[selectedRowIndex].Cells[1].Value = (login);
                dataGridView1.Rows[selectedRowIndex].Cells[2].Value = (password);
                dataGridView1.Rows[selectedRowIndex].Cells[3].Value = RowState.Modified;
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }

        private void new_Click(object sender, EventArgs e)
        {
            AddUsersForm addf = new AddUsersForm();
            addf.Show();
        }

        private void refactor_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Updatee();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;


            dataGridView1.Rows[index].Cells[3].Value = RowState.Deleted;
            return;

        }

        private void Updatee()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[3].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);



                    var deleteQuery = $"DELETE FROM Пользователи WHERE ID_Пользователя = '{id}'";




                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var login = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var password = dataGridView1.Rows[index].Cells[2].Value.ToString();


                    var changeQuery = $"UPDATE Пользователи SET Логин = '{login}', Пароль = '{password}' WHERE ID_Пользователя = '{id}'";

                    var command = new SqlCommand(changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();


                }



            }

            dataBase.closeConnection();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            this.Hide();
            mainf.ShowDialog();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dgv_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                login_textBox.Text = row.Cells[1].Value.ToString();
                password_textBox.Text = row.Cells[2].Value.ToString();
            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = "SELECT * FROM Пользователи WHERE CONCAT " +
                "   (ID_Пользователя, Логин, Пароль) LIKE '%" + search_textbox.Text + "%'";
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
            Search(dataGridView1);
        }
    }
}
