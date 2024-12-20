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
    public partial class FeedbackForm : Form
    {

        DataBase dataBase = new DataBase();

        int selectedRow;

        public FeedbackForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_Отзыва", "ID");
            dataGridView1.Columns.Add("ID_Клиента", "ID Клиента");
            dataGridView1.Columns.Add("ID_Автомобиля", "ID Автомобиля");
            dataGridView1.Columns.Add("Текст_отзыва", "Отзыв");
            dataGridView1.Columns.Add("Дата_отзыва", "Дата");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetInt32(2),
                record.GetString(3), record.GetDateTime(4));
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Отзывы";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }

        private void dgv_cellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            this.Hide();
            mainf.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = "SELECT * FROM Отзывы WHERE CONCAT " +
                "   (ID_Отзыва, ID_Клиента, ID_Автомобиля, Текст_отзыва, Дата_отзыва) LIKE '%" + search_textbox.Text + "%'";
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
