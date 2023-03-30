using Lab3.Models;
using Lab3.Repositories;
using System;
using System.Windows.Forms;

namespace Lab3.Forms
{
    public partial class EmployeeForm : Form
    {

        private DataGridViewRow dataGrid;
        private IRepository<Employee> repository;
        private bool isEdit = false;
        public EmployeeForm()
        {
            repository = new EmployeeRepository();
            InitializeComponent();
            tbID.Enabled = false;
            btnUsun.Visible = false;
        }
        public EmployeeForm(DataGridViewRow dataGrid)
        {
            repository = new EmployeeRepository();
            InitializeComponent();
            this.dataGrid = dataGrid;

            lblDodajPracownika.Text = "Zarządzaj Pracownikiem:";
            btnDodajPracownika.Text = "Edytuj Pracownika";
            isEdit = true;

            tbID.Text = dataGrid.Cells[0].Value.ToString();
            tbFirstName.Text = dataGrid.Cells[1].Value.ToString();
            tbNazwisko.Text = dataGrid.Cells[2].Value.ToString();
            tbAdres.Text = dataGrid.Cells[3].Value.ToString();


        }

        public void InsertData()
        {
            if(validateTextForm(tbAdres.Text) &&
                validateTextForm(tbFirstName.Text) &&
                validateTextForm(tbNazwisko.Text))
            {
                if (!isEdit)
                    repository
                        .Insert(new Employee(
                            tbFirstName.Text, 
                            tbNazwisko.Text, 
                            tbAdres.Text
                                ));
                else
                {
                    repository
                         .Update(new Employee(
                              int.Parse(tbID.Text),
                              tbFirstName.Text,
                              tbNazwisko.Text,
                              tbAdres.Text
                                ));
                }
            }
        }

        private bool validateTextForm(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        private void btnDodajPracownika_Click(object sender, EventArgs e)
        {
            InsertData();
            this.Close();
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            repository.Delete(int.Parse(tbID.Text));
            this.Close();
        }
    }
}
