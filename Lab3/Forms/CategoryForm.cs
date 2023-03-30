using Lab3.Models;
using Lab3.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3.Forms
{
    public partial class CategoryForm : Form
    {
        private DataGridViewRow dataGrid;
        private IRepository<Category> repository;
        private bool isEdit = false;

        public CategoryForm()
        {
            repository = new CategoryRepository();
            InitializeComponent();
            tbID.Enabled = false;
            btnUsun.Visible = false;
        }

        public CategoryForm(DataGridViewRow dataGrid)
        {
            repository = new CategoryRepository();
            InitializeComponent();
            this.dataGrid = dataGrid;

            lblDodajKategorie.Text = "Zarządzaj kategoria:";
            btnDodajKategorie.Text = "Edytuj Kategorie";

            tbID.Text = dataGrid.Cells[0].Value.ToString();
            tbCategoryName.Text = dataGrid.Cells[1].Value.ToString();
            tbDesc.Text = dataGrid.Cells[2].Value.ToString();

            isEdit = true;

        }

        public void InsertData()
        {
            if (validateTextForm(tbCategoryName.Text) &&
                validateTextForm(tbDesc.Text))
            {
                if (!isEdit)
                    repository.Insert(new Category(tbCategoryName.Text, tbDesc.Text));
                else
                {
                    repository.Update(new Category(
                        int.Parse(tbID.Text),
                        tbCategoryName.Text,
                        tbDesc.Text));
                }
            } 
        }

        private bool validateTextForm(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        private void btnDodajKategorie_Click(object sender, EventArgs e)
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
