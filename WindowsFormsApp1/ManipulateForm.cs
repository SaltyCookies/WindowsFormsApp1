
using System.Windows.Forms;
using WindowsFormsApp1.CommonMethods;

namespace WindowsFormsApp1
{
    public partial class ManipulateForm : Form
    {
        Methods apply = new Methods();
        public ManipulateForm(string state)
        {
            InitializeComponent();
            if (state == "child")
            {
                label5.Hide();
                PositionComboBox.Hide();
            }
            else 
            {
                PositionComboBox.SelectedIndex = 0;
            }
            
        }
    }
}
