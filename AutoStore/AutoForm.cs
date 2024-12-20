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

    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }


    public partial class AutoForm : Form
    {

        DataBase dataBase = new DataBase();

        int selectedRow;

        public AutoForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("ID_Автомобиля", "ID");
            dataGridView1.Columns.Add("Марка", "Марка");
            dataGridView1.Columns.Add("Модель", "Модель");
            dataGridView1.Columns.Add("Год_выпуска", "Год выпуска");
            dataGridView1.Columns.Add("Цвет", "Цвет");
            dataGridView1.Columns.Add("Цена", "Цена");
            dataGridView1.Columns.Add("Пробег", "Пробег");
            dataGridView1.Columns.Add("ID_Поставщика", "Поставщик");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), 
                record.GetString(4), record.GetInt32(5), record.GetInt32(6), record.GetInt32(7), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dgw)
        { 
            dgw.Rows.Clear();

            string queryString = $"SELECT * FROM Автомобили";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            { 
                ReadSingleRow(dgw, reader);
            }
            reader.Close();

        }

        private void AutoForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void auto_label_Click(object sender, EventArgs e)
        {

        }

        private void find_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void new_record_Click(object sender, EventArgs e)
        {
            AddAutoForm addf = new AddAutoForm();
            addf.Show();
        }

        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var marka = marka_textBox.Text;
            var model = model_textBox.Text;
            int year;
            int price;
            int km;
            int provider;
            var color = color_textBox.Text;

            if (dataGridView1.Rows[selectedRowIndex].Cells[1].Value.ToString() != String.Empty)
            {
                if (int.TryParse(year_textBox.Text, out year))
                {
                    if (int.TryParse(price_textBox.Text, out price))
                    {
                        if (int.TryParse(km_textBox.Text, out km))
                        {
                            if (int.TryParse(provider_textBox.Text, out provider))
                            {
                                dataGridView1.Rows[selectedRowIndex].Cells[1].Value = (marka);
                                dataGridView1.Rows[selectedRowIndex].Cells[2].Value = (model);
                                dataGridView1.Rows[selectedRowIndex].Cells[3].Value = (year);
                                dataGridView1.Rows[selectedRowIndex].Cells[4].Value = (color);
                                dataGridView1.Rows[selectedRowIndex].Cells[5].Value = (price);
                                dataGridView1.Rows[selectedRowIndex].Cells[6].Value = (km);
                                dataGridView1.Rows[selectedRowIndex].Cells[7].Value = (provider);
                                dataGridView1.Rows[selectedRowIndex].Cells[8].Value = RowState.Modified;
                            }
                            else
                            {
                                MessageBox.Show("Неверные данные!");
                            }
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


        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;


            dataGridView1.Rows[index].Cells[8].Value = RowState.Deleted;
            return;

        }

        private void Updatee()
        {
            dataBase.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[8].Value;

                if (rowState == RowState.Existed) 
                { 
                    continue;
                }
                if (rowState == RowState.Deleted)
                { 
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);



                    var deleteQuery = $"DELETE FROM Автомобили WHERE ID_Автомобиля = '{id}'";

                         


                    var command = new SqlCommand(deleteQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();
                }

                if(rowState == RowState.Modified)
                {
                    var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                    var marka = dataGridView1.Rows[index].Cells[1].Value.ToString();
                    var model = dataGridView1.Rows[index].Cells[2].Value.ToString();
                    var year = dataGridView1.Rows[index].Cells[3].Value.ToString();
                    var color = dataGridView1.Rows[index].Cells[4].Value.ToString();
                    var price = dataGridView1.Rows[index].Cells[5].Value.ToString();
                    var km = dataGridView1.Rows[index].Cells[6].Value.ToString();
                    var provider = dataGridView1.Rows[index].Cells[7].Value.ToString();

                    var changeQuery = $"UPDATE Автомобили SET Марка = '{marka}', Модель = '{model}', Год_выпуска = {year}, Цвет = '{color}', " +
                        $"Цена = '{price}', Пробег = {km}, ID_Поставщика = '{provider}' WHERE ID_Автомобиля = '{id}'";

                    var command = new SqlCommand (changeQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();


                }

                    

            }

            dataBase.closeConnection();
        }
        private void delete_Click(object sender, EventArgs e)
        {

            deleteRow();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            this.Hide();
            mainf.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if(e.RowIndex >= 0 )
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                marka_textBox.Text = row.Cells[1].Value.ToString();
                model_textBox.Text = row.Cells[2].Value.ToString();
                year_textBox.Text = row.Cells[3].Value.ToString();
                color_textBox.Text = row.Cells[4].Value.ToString();
                price_textBox.Text = row.Cells[5].Value.ToString();
                km_textBox.Text = row.Cells[6].Value.ToString();
                provider_textBox.Text = row.Cells[7].Value.ToString();
                
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = "SELECT * FROM Автомобили WHERE CONCAT " +
                "   (ID_Автомобиля, Марка, Модель, Год_выпуска, Цвет, Цена, Пробег, ID_Поставщика) LIKE '%" + search_textbox.Text + "%'";
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

        private void organize_label_Click(object sender, EventArgs e)
        {

        }

        private void price_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void km_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void color_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void year_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void model_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void marka_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void km_label_Click(object sender, EventArgs e)
        {

        }

        private void price_label_Click(object sender, EventArgs e)
        {

        }

        private void color_label_Click(object sender, EventArgs e)
        {

        }

        private void year_label_Click(object sender, EventArgs e)
        {

        }

        private void model_label_Click(object sender, EventArgs e)
        {

        }

        private void add_label_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void provider_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
