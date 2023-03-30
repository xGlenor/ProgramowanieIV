using Lab3.Forms;
using Lab3.Models;
using Lab3.Repositories;
using Lab3.Storage;
using System;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainForm : Form
    {
        private static Database database;
        private IRepository<Category> categoryRepo;
        private IRepository<Employee> employeeRepo;


        public MainForm()
        {
            database = Program.GetDatabase();

            InitializeComponent();
        }
   
        public static Database getDatabase()
        {
            return database;
        }

        private void cBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cBoxTables.SelectedIndex)
            {
                case 0:
                    employeeRepo = new EmployeeRepository();
                    dgvData.DataSource = employeeRepo.All();
                    sekcja.Text = "Pracownicy";
                    break;
                case 1:
                    categoryRepo = new CategoryRepository();
                    dgvData.DataSource = categoryRepo.All();
                    sekcja.Text = "Kategorie";
                    break;
                default:
                    break;

            }

            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvData.Columns[dgvData.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxTables.Items.Add("Pracownicy");
            cBoxTables.Items.Add("Kategorie");
            cBoxTables.SelectedIndex = 0;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            switch (cBoxTables.SelectedIndex)
            {
                case 0:
                    EmployeeForm ef = new EmployeeForm();
                    ef.Show();
                    break;
                case 1:
                    CategoryForm cf = new CategoryForm();
                    cf.Show();
                    break;
                default:
                    break;

            }
        }

        private void dgvData_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvData.CurrentRow.Selected = true;
            switch (cBoxTables.SelectedIndex)
            {
                case 0:
                    EmployeeForm ef = new EmployeeForm(dgvData.Rows[e.RowIndex]);
                    ef.Show();
                    break;
                case 1:
                    CategoryForm cf = new CategoryForm(dgvData.Rows[e.RowIndex]);
                    cf.Show();
                    break;
                default:
                    break;

            }
        }
    }
}
