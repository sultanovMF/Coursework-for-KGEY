namespace FinalCoursework
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.GroupTab = new System.Windows.Forms.TabPage();
            this.GroupData = new System.Windows.Forms.DataGridView();
            this.Specialization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TeachersTab = new System.Windows.Forms.TabPage();
            this.TeachersData = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Experience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadsTab = new System.Windows.Forms.TabPage();
            this.LoadData = new System.Windows.Forms.DataGridView();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoursCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LessonType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTabs.SuspendLayout();
            this.GroupTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupData)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.TeachersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersData)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.LoadsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.AccessibleName = "";
            this.MainTabs.Controls.Add(this.GroupTab);
            this.MainTabs.Controls.Add(this.TeachersTab);
            this.MainTabs.Controls.Add(this.LoadsTab);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 0);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.RightToLeftLayout = true;
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(800, 450);
            this.MainTabs.TabIndex = 0;
            // 
            // GroupTab
            // 
            this.GroupTab.Controls.Add(this.GroupData);
            this.GroupTab.Controls.Add(this.menuStrip1);
            this.GroupTab.Location = new System.Drawing.Point(4, 22);
            this.GroupTab.Name = "GroupTab";
            this.GroupTab.Padding = new System.Windows.Forms.Padding(3);
            this.GroupTab.Size = new System.Drawing.Size(792, 424);
            this.GroupTab.TabIndex = 0;
            this.GroupTab.Text = "Группы";
            this.GroupTab.UseVisualStyleBackColor = true;
            // 
            // GroupData
            // 
            this.GroupData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GroupData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GroupData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Specialization,
            this.Department,
            this.StudentCount});
            this.GroupData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupData.Location = new System.Drawing.Point(3, 27);
            this.GroupData.Name = "GroupData";
            this.GroupData.RowHeadersVisible = false;
            this.GroupData.Size = new System.Drawing.Size(786, 394);
            this.GroupData.TabIndex = 0;
            this.GroupData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupData_CellContentClick);
            this.GroupData.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupData_RowLeave);
            this.GroupData.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.GroupData_RowValidated);
            this.GroupData.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.GroupData_RowValidating);
            // 
            // Specialization
            // 
            this.Specialization.HeaderText = "Специальность";
            this.Specialization.Name = "Specialization";
            this.Specialization.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.HeaderText = "Отделение";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // StudentCount
            // 
            this.StudentCount.HeaderText = "Количество студентов";
            this.StudentCount.Name = "StudentCount";
            this.StudentCount.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddGroupButton);
            // 
            // TeachersTab
            // 
            this.TeachersTab.Controls.Add(this.TeachersData);
            this.TeachersTab.Controls.Add(this.menuStrip2);
            this.TeachersTab.Location = new System.Drawing.Point(4, 22);
            this.TeachersTab.Name = "TeachersTab";
            this.TeachersTab.Padding = new System.Windows.Forms.Padding(3);
            this.TeachersTab.Size = new System.Drawing.Size(792, 424);
            this.TeachersTab.TabIndex = 1;
            this.TeachersTab.Text = "Преподаватели";
            this.TeachersTab.UseVisualStyleBackColor = true;
            // 
            // TeachersData
            // 
            this.TeachersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeachersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.NameTxt,
            this.MiddleName,
            this.Number,
            this.Experience});
            this.TeachersData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeachersData.Location = new System.Drawing.Point(3, 27);
            this.TeachersData.Name = "TeachersData";
            this.TeachersData.RowHeadersVisible = false;
            this.TeachersData.Size = new System.Drawing.Size(786, 394);
            this.TeachersData.TabIndex = 0;
            this.TeachersData.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.TeacherValidation);
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // NameTxt
            // 
            this.NameTxt.HeaderText = "Имя";
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Отчество";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.HeaderText = "Телефон";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Experience
            // 
            this.Experience.HeaderText = "Стаж";
            this.Experience.Name = "Experience";
            this.Experience.ReadOnly = true;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(786, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.AddTeacherButton);
            // 
            // LoadsTab
            // 
            this.LoadsTab.Controls.Add(this.LoadData);
            this.LoadsTab.Controls.Add(this.menuStrip3);
            this.LoadsTab.Location = new System.Drawing.Point(4, 22);
            this.LoadsTab.Name = "LoadsTab";
            this.LoadsTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoadsTab.Size = new System.Drawing.Size(792, 424);
            this.LoadsTab.TabIndex = 2;
            this.LoadsTab.Text = "Нагрузка";
            this.LoadsTab.UseVisualStyleBackColor = true;
            // 
            // LoadData
            // 
            this.LoadData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LoadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Teacher,
            this.Group,
            this.HoursCount,
            this.Subject,
            this.LessonType,
            this.Payment});
            this.LoadData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadData.Location = new System.Drawing.Point(3, 27);
            this.LoadData.Name = "LoadData";
            this.LoadData.RowHeadersVisible = false;
            this.LoadData.Size = new System.Drawing.Size(786, 394);
            this.LoadData.TabIndex = 0;
            // 
            // Teacher
            // 
            this.Teacher.HeaderText = "Преподаватель";
            this.Teacher.Name = "Teacher";
            // 
            // Group
            // 
            this.Group.HeaderText = "Группа";
            this.Group.Name = "Group";
            // 
            // HoursCount
            // 
            this.HoursCount.HeaderText = "Количество часов";
            this.HoursCount.Name = "HoursCount";
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Предмет";
            this.Subject.Name = "Subject";
            // 
            // LessonType
            // 
            this.LessonType.HeaderText = "Тип занятия";
            this.LessonType.Name = "LessonType";
            this.LessonType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LessonType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Оплата";
            this.Payment.Name = "Payment";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2});
            this.menuStrip3.Location = new System.Drawing.Point(3, 3);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(786, 24);
            this.menuStrip3.TabIndex = 1;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(71, 20);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.AddLoadButton);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTabs);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Курсы повышения квалификации";
            this.MainTabs.ResumeLayout(false);
            this.GroupTab.ResumeLayout(false);
            this.GroupTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupData)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TeachersTab.ResumeLayout(false);
            this.TeachersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersData)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.LoadsTab.ResumeLayout(false);
            this.LoadsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadData)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage GroupTab;
        private System.Windows.Forms.TabPage TeachersTab;
        private System.Windows.Forms.TabPage LoadsTab;
        private System.Windows.Forms.DataGridView GroupData;
        private System.Windows.Forms.DataGridView TeachersData;
        private System.Windows.Forms.DataGridView LoadData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialization;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Experience;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoursCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn LessonType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
    }
}

