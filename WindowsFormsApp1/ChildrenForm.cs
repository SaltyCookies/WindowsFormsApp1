using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.CommonMethods;
using WindowsFormsApp1.Context;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class ChildrenForm : Form
    {
        Methods apply = new Methods();
        DataContext db;
        Employee parent;
        Form1 baseForm;
        public ChildrenForm(Employee employee, DataContext acceptedDb, Form1 _baseForm)
        {            
            db = acceptedDb;
            parent = employee;
            baseForm =  _baseForm;
            InitializeComponent();
            db.Children.Load();
            dataGridView1.DataSource = db.Employers.Find(parent.Id).Children?.ToList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ManipulateForm childForm = new ManipulateForm("child");
            DialogResult result = childForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Child child = new Child { FirstName = childForm.FirstNameTextBox.Text, 
                                      LastName = childForm.LastNameTextBox.Text, 
                                      Surname = childForm.SurnameTextBox.Text,
                                      BirthTime = childForm.BirthTimePicker.Value
            };

            apply.AddMethod(db,parent,child);

            baseForm.Refresh();
            dataGridView1.DataSource = db.Employers.Find(parent.Id).Children.ToList();
            MessageBox.Show("Добавлен ребенок");

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool converted;
                int id = apply.GetAndValidateIndex(dataGridView1, out converted);
                if (converted == false)
                    return;

                Child child = db.Children.Find(id);

                ManipulateForm childAddForm = new ManipulateForm("child");

                childAddForm.FirstNameTextBox.Text = child.FirstName;
                childAddForm.LastNameTextBox.Text = child.LastName;
                childAddForm.SurnameTextBox.Text = child.Surname;
                childAddForm.BirthTimePicker.Value = child.BirthTime;

                DialogResult result = childAddForm.ShowDialog(this);

                if (result == DialogResult.Cancel)
                    return;

                child.FirstName = childAddForm.FirstNameTextBox.Text;
                child.LastName = childAddForm.LastNameTextBox.Text;
                child.Surname = childAddForm.SurnameTextBox.Text;
                child.BirthTime = childAddForm.BirthTimePicker.Value;
                db.SaveChanges();
                baseForm.Refresh();
                dataGridView1.DataSource = db.Employers.Find(parent.Id).Children.ToList();
                MessageBox.Show("Рабочий обновлен");

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                bool converted;
                int id = apply.GetAndValidateIndex(dataGridView1, out converted);
                if (converted == false)
                    return;

                apply.DeleteMethod(db, id, parent);

                baseForm.Refresh();
                dataGridView1.DataSource = db.Employers.Find(parent.Id).Children.ToList();

                MessageBox.Show("Объект удален");
            }

        }
    }
}
