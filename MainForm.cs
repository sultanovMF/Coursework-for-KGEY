using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCoursework
{
    public partial class MainForm : Form
    {
        bool isError = false;
        string errorMessage;
        List<Group> groups = new List<Group>();
        List<Teacher> teachers = new List<Teacher>();
        List<Load> loads = new List<Load>();
        public MainForm()
        {
            
            InitializeComponent();
        }

        private void TeacherValidation(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //Console.WriteLine("adasd");
        }

        private void GroupData_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("enter");
        }

        private void GroupData_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("leave");
        }

        private void GroupData_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            Console.WriteLine("start validating");
            //if (GroupData[0, e.RowIndex].Value == null || (string) GroupData[0, e.RowIndex].Value.ToString() == "") {
            //    isError = true;
            //    errorMessage = "Нобходимо ввести название специальности!";
            //    return;
            //}
            ////if (!(GroupData[2, e.RowIndex].Value is int))
            ////{
            ////    isError = true;
            ////    errorMessage = "Нобходимо ввести числовое значение в ячейку количества студентов!";
            ////    return;
            ////}
            //try
            //{
            //    Group group = new Group((string)GroupData[0, e.RowIndex].Value, (string)GroupData[1, e.RowIndex].Value, Convert.ToUInt16(GroupData[1, e.RowIndex].Value.ToString()));
            //}
            //catch
            //{

            //}
            //groups.Add(group);
          
        }

        private void GroupData_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (isError)
            {
                MessageBox.Show(errorMessage, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isError = false;
            }
        }

        private void AddGroupButton(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new AddGroupForm();
            var result = addGroupForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                groups.Add(addGroupForm.Group);
                DataGridViewRow row = (DataGridViewRow) GroupData.Rows[0].Clone();
                row.Cells[0].Value = addGroupForm.Group.Specialization;
                row.Cells[1].Value = addGroupForm.Group.Department;
                row.Cells[2].Value = addGroupForm.Group.StudentCount;
                this.GroupData.Rows.Add(row);
            }
        }

        private void AddTeacherButton(object sender, EventArgs e)
        {
            AddTeacherForm addTeacherForm = new AddTeacherForm();
            var result = addTeacherForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                teachers.Add(addTeacherForm.Teacher);
                DataGridViewRow row = (DataGridViewRow)TeachersData.Rows[0].Clone();
                row.Cells[0].Value = addTeacherForm.Teacher.Surname;
                row.Cells[1].Value = addTeacherForm.Teacher.Name;
                row.Cells[2].Value = addTeacherForm.Teacher.MiddleName;
                row.Cells[3].Value = addTeacherForm.Teacher.Number;
                row.Cells[4].Value = addTeacherForm.Teacher.Experience;
                this.TeachersData.Rows.Add(row);
            }
        }

        private void AddLoadButton(object sender, EventArgs e)
        {
            AddLoadForm addLoadForm = new AddLoadForm(this.groups, this.teachers);
            var result = addLoadForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                loads.Add(addLoadForm._Load);
                DataGridViewRow row = (DataGridViewRow)LoadData.Rows[0].Clone();
                row.Cells[0].Value = addLoadForm._Load.Teacher.ToString();
                row.Cells[1].Value = addLoadForm._Load.Group.ToString();
                row.Cells[2].Value = addLoadForm._Load.HourCount;
                row.Cells[3].Value = addLoadForm._Load.Subject;
                row.Cells[4].Value = addLoadForm._Load.LessonType;
                row.Cells[5].Value = addLoadForm._Load.Payment;
                this.LoadData.Rows.Add(row);
            }
        }

        private void GroupData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
