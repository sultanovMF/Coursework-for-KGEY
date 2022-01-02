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
    public partial class AddTeacherForm : Form
    {
        public Teacher Teacher { get; set; }
        public AddTeacherForm()
        {
            
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (this.experiencetb.Text.Length > 0 && this.numbertb.Text.Length > 0 && this.middlenametb.Text.Length > 0 && this.nametb.Text.Length > 0 && this.surnametb.Text.Length > 0 && Regex.IsMatch(this.experiencetb.Text, @"^\d+$") && Regex.IsMatch(this.numbertb.Text, @"^(\+7|7|8)?[\s\-]?\(?[489][0-9]{2}\)?[\s\-]?[0-9]{3}[\s\-]?[0-9]{2}[\s\-]?[0-9]{2}$"))
            {
                Teacher = new Teacher(this.nametb.Text, this.surnametb.Text, this.middlenametb.Text, this.numbertb.Text, Convert.ToInt32(this.experiencetb.Text), this.subjectChoice.Text);
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
