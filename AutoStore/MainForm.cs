using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutoStore
{
    public partial class MainForm : Form
    {

        DataBase dataBase = new DataBase();

        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void auto_btn_Click(object sender, EventArgs e)
        {
            AutoForm autof = new AutoForm();
            this.Hide();
            autof.ShowDialog();
        }

        private void test_dr_btn_Click(object sender, EventArgs e)
        {
            TestDriveForm testf = new TestDriveForm();
            this.Hide();
            testf.ShowDialog();
        }

        private void client_btn_Click(object sender, EventArgs e)
        {
            ClientForm clientf = new ClientForm();
            this.Hide();
            clientf.ShowDialog();
        }

        private void fb_btn_Click(object sender, EventArgs e)
        {
            FeedbackForm feedf = new FeedbackForm();
            this.Hide();
            feedf.ShowDialog();
        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            UsersForm usersf = new UsersForm();
            this.Hide();
            usersf.ShowDialog();
        }

        private void provider_btn_Click(object sender, EventArgs e)
        {
            ProviderForm providerf = new ProviderForm();
            this.Hide();
            providerf.ShowDialog();
        }

        private void sale_btn_Click(object sender, EventArgs e)
        {
            SalesForm salesf = new SalesForm();
            this.Hide();
            salesf.ShowDialog();
        }

        private void services_btn_Click(object sender, EventArgs e)
        {
            ServicesForm servicesf = new ServicesForm();
            this.Hide();
            servicesf.ShowDialog();
        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesf = new EmployeesForm();
            this.Hide();
            employeesf.ShowDialog();
        }

        private void exit_sign_in_btn_Click(object sender, EventArgs e)
        {
            Sign_in_Form signf = new Sign_in_Form();
            this.Hide();
            signf.ShowDialog();
        }
    }
}
