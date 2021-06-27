using System;
using System.Data.Entity;
using System.Windows.Forms;
using WindowsFormsApp1.CommonMethods;
using WindowsFormsApp1.Context;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Methods apply = new Methods();
        DataContext db;
        public Form1()
        {

            InitializeComponent();
            //update Code-First db for various tests
            Database.SetInitializer<DataContext>(new DropCreateDatabaseIfModelChanges<DataContext>());
            db = new DataContext();
            db.Employers.Load();

            dataGridView1.DataSource = db.Employers.Local.ToBindingList();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //Getting and validating index
                bool converted;
                int id = apply.GetAndValidateIndex(dataGridView1, out converted);
                if (converted == false)
                    return;
                //Delete from table
                apply.DeleteMethod(db,id);                
            }

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool converted;
                int id = apply.GetAndValidateIndex(dataGridView1, out converted);
                if (converted == false)
                    return;

                Employee employee = db.Employers.Find(id);

                ManipulateForm manForm = new ManipulateForm("parent");

                manForm.FirstNameTextBox.Text = employee.FirstName;
                manForm.LastNameTextBox.Text = employee.LastName;
                manForm.SurnameTextBox.Text = employee.Surname;
                manForm.BirthTimePicker.Value = employee.BirthTime;
                manForm.PositionComboBox.SelectedItem = employee.Position;

                DialogResult result = manForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                employee.FirstName = manForm.FirstNameTextBox.Text;
                employee.LastName = manForm.LastNameTextBox.Text;
                employee.Surname = manForm.SurnameTextBox.Text;
                employee.BirthTime = manForm.BirthTimePicker.Value;
                employee.Position = manForm.PositionComboBox.SelectedItem.ToString();

                db.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Рабочий обновлен");

            }

        }
        
        private void AddButton_Click(object sender, EventArgs e)
        {
            ManipulateForm manForm = new ManipulateForm("parent");

            DialogResult result = manForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Employee employee = new Employee
            {
                FirstName = manForm.FirstNameTextBox.Text,
                LastName = manForm.LastNameTextBox.Text,
                Surname = manForm.SurnameTextBox.Text,
                BirthTime = manForm.BirthTimePicker.Value,
                Position = manForm.PositionComboBox.SelectedItem.ToString()
            };

            apply.AddMethod(db, employee);           

            MessageBox.Show("Добавлен рабочий");

        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            bool converted;
            int id = apply.GetAndValidateIndex(dataGridView1, out converted);
            if (converted == false)
                return;

            ChildrenForm childrenForm = new ChildrenForm(db.Employers.Find(id), db, this);

            DialogResult result = childrenForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;
        }
    }
}
