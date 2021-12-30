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
    public partial class AddLoadForm : Form
    {
        public Load _Load { get; set; }
        public Teacher Teacher { get; set; }
        public Group Group { get; set; }
        public AddLoadForm(List<Group> groups, List<Teacher> teachers)
        {
            
            InitializeComponent();

            foreach (var teacher in teachers)
            {
              
                this.teachersList.Items.Add(teacher);
            }

            foreach (var group in groups)
            {
                this.groupsList.Items.Add(group);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.payment.Text.Length > 0 &&
                this.teachersList.Text.Length > 0 &&
                this.groupsList.Text.Length > 0 &&
                this.hoursCount.Text.Length > 0 &&
                this.lessontype.Text.Length > 0 &&
                this.subject.Text.Length > 0 &&
                Regex.IsMatch(this.payment.Text, @"^\d+$") &&
                Regex.IsMatch(this.hoursCount.Text, @"^\d+$"))
            {
                _Load = new Load((Teacher)this.teachersList.SelectedItem, (Group)this.groupsList.SelectedItem, Convert.ToInt32(this.hoursCount.Text), this.subject.Text, this.lessontype.Text, Convert.ToInt32(this.payment.Text));
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
