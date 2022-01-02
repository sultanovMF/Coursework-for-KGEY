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
        const int MathPayment = 1000;
        const int EngPayment = 1200;
        const int InfPayment = 1400;
        const int PhysPayment = 1400;
        const int ProgPayment = 1400;
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
            if (
                this.teachersList.Text.Length > 0 &&
                this.groupsList.Text.Length > 0 &&
                this.hoursCount.Text.Length > 0 &&
                this.lessontype.Text.Length > 0 &&
                Regex.IsMatch(this.hoursCount.Text, @"^\d+$"))
            {
                string subject = ((Teacher)this.teachersList.SelectedItem).Subject;
                int hours_count = Convert.ToInt32(this.hoursCount.Text);
                int payment = 1000;
                switch (subject)
                {
                    case "Математика":
                        payment = MathPayment * hours_count;
                        break;
                    case "Программирование":
                        payment = ProgPayment * hours_count;
                        break;
                    case "Информатика":
                        payment = InfPayment * hours_count;
                        break;
                    case "Английский язык":
                        payment = EngPayment * hours_count;
                        break;
                    case "Физика":
                        payment = PhysPayment * hours_count;
                        break;
                    default:
                        break;
                }
                if (subject == "Математика")
                {
                    payment = MathPayment * hours_count;
                }
                _Load = new Load((Teacher)this.teachersList.SelectedItem, (Group)this.groupsList.SelectedItem, Convert.ToInt32(this.hoursCount.Text), subject, this.lessontype.Text, payment);
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
