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

namespace AutoStore
{
    enum RowState1
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted,
    }

    public partial class ServicesForm : Form
    {

        DataBase dataBase = new DataBase();

        int selectedRow;

        public ServicesForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView2.Columns.Add("ID_Обслуживания", "ID");
            dataGridView2.Columns.Add("ID_Автомобиля", "ID Авто");
            dataGridView2.Columns.Add("Дата_обслуживания", "Дата");
            dataGridView2.Columns.Add("Описание_работ", "Описание");
            dataGridView2.Columns.Add("Стоимость", "Стоимость");
            dataGridView2.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetDateTime(2), record.GetString(3), record.GetInt32(4), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM СервисноеОбслуживание";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }


        private void ServicesForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView2);
        }

        private void autoid_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backmenu_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            this.Hide();
            mainf.ShowDialog();
        }

        private void new_record_Button_Click(object sender, EventArgs e)
        {
            AddServices addf = new AddServices();
            addf.Show();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView2.CurrentCell.RowIndex;

            int autoid;
            var date = data_textBox.Text;
            var opis = opis_textBox.Text;
            int price;

            if (dataGridView2.Rows[selectedRowIndex].Cells[1].Value.ToString() != String.Empty)
            {
                if (int.TryParse(autoid_textBox.Text, out autoid))
                {
                    if (int.TryParse(price_textBox.Text, out price))
                    {
                        dataGridView2.Rows[selectedRowIndex].Cells[1].Value = (autoid);
                        dataGridView2.Rows[selectedRowIndex].Cells[2].Value = (date);
                        dataGridView2.Rows[selectedRowIndex].Cells[3].Value = (opis);
                        dataGridView2.Rows[selectedRowIndex].Cells[4].Value = (price);
                        dataGridView2.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                    }
                }
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

            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView2.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView2.Rows[index].Cells[0].Value);



                    var deleteQuery = $"DELETE FROM СервисноеОбслуживание WHERE ID_Обслуживания = '{id}'";




                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var id = dataGridView2.Rows[index].Cells[0].Value.ToString();
                    var autoid = dataGridView2.Rows[index].Cells[1].Value.ToString();
                    var date = dataGridView2.Rows[index].Cells[2].Value.ToString();
                    var opis = dataGridView2.Rows[index].Cells[3].Value.ToString();
                    var price = dataGridView2.Rows[index].Cells[4].Value.ToString();


                    var changeQuery = $"UPDATE СервисноеОбслуживание SET ID_Автомобиля = '{autoid}', Дата_обслуживания = '{date}', Описание_работ = '{opis}', Стоимость = '{price}' WHERE ID_Обслуживания = '{id}'"; 

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

        private void delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView2);
        }

        private void deleteRow()
        {
            int index = dataGridView2.CurrentCell.RowIndex;

            dataGridView2.Rows[index].Visible = false;


            dataGridView2.Rows[index].Cells[5].Value = RowState.Deleted;
            return;

        }

        private void dgw2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[selectedRow];

                autoid_textBox.Text = row.Cells[1].Value.ToString();
                data_textBox.Text = row.Cells[2].Value.ToString();
                opis_textBox.Text = row.Cells[3].Value.ToString();
                price_textBox.Text = row.Cells[4].Value.ToString();

            }
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = "SELECT * FROM СервисноеОбслуживание WHERE CONCAT " +
                "   (ID_Обслуживания, ID_Автомобиля, Дата_обслуживания, Описание_работ, Стоимость) LIKE '%" + search_textbox.Text + "%'";
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
            Search(dataGridView2);
        }

        private void marka_label_Click(object sender, EventArgs e)
        {

        }
    }
}
