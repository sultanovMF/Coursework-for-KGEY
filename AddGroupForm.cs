using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCoursework
{
    public partial class AddGroupForm : Form
    {
        public Group Group { get; set; }
        public AddGroupForm()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.SpecTextBox.Text.Length > 0 && this.DepartTextBox.Text.Length > 0 && this.HourCountTextBox.Text.Length > 0 && Regex.IsMatch(this.HourCountTextBox.Text, @"^\d+$"))
            {
                Group = new Group(this.SpecTextBox.Text, this.DepartTextBox.Text, Convert.ToInt32(this.HourCountTextBox.Text));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Проверьте правильность набор данных и попробуйте заново!", "Ошибка!",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
