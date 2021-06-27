using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1.Context;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.CommonMethods
{
    public class Methods
    {
        // Delete methods. 
        public void DeleteMethod(DataContext db, int id)
        // Delete data from Employers table. 
        {
            Employee employee = db.Employers.Find(id);
            db.Employers.Remove(employee);
            db.SaveChanges();

            MessageBox.Show("Объект удален");
        }
        public void DeleteMethod(DataContext db, int id, Employee parent)
        // Delete data from Children table. 
        {
            var childrenCount = parent.ChildrenCount - 1;

            Child child = db.Children.Find(id);
            parent.ChildrenCount = childrenCount;
            child.Employees.Remove(parent);
            db.Children.Remove(child);
            db.SaveChanges();
        }
        // Add methods. (bool)
        public void AddMethod(DataContext db, Employee employee)
        // Add data to Employers table. 
        {
            db.Employers.Add(employee);
            db.SaveChanges();
        }
        public void AddMethod(DataContext db, Employee parent, Child child)
        // Add data to Children table. 
        {
            var childrenCount = parent.ChildrenCount + 1;
            child.Employees.Add(parent);
            parent.ChildrenCount = childrenCount;
            db.Children.Add(child);
            db.SaveChanges();
        }
        // Get and validate index.
        public int GetAndValidateIndex(DataGridView grid, out bool converted)
        {
            int index = grid.SelectedRows[0].Index;
            int id = 0;
            converted = Int32.TryParse(grid[0, index].Value.ToString(), out id);
            return id;
        }
    }
}
