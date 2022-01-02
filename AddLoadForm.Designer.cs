namespace FinalCoursework
{
    partial class AddLoadForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.teachersList = new System.Windows.Forms.ComboBox();
            this.groupsList = new System.Windows.Forms.ComboBox();
            this.hoursCount = new System.Windows.Forms.TextBox();
            this.lessontype = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.teachersList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupsList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.hoursCount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lessontype, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 216);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Преподаватель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(4, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Количество часов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(4, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Тип занятия";
            // 
            // teachersList
            // 
            this.teachersList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teachersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teachersList.FormattingEnabled = true;
            this.teachersList.Location = new System.Drawing.Point(348, 4);
            this.teachersList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teachersList.Name = "teachersList";
            this.teachersList.Size = new System.Drawing.Size(336, 24);
            this.teachersList.TabIndex = 6;
            // 
            // groupsList
            // 
            this.groupsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsList.FormattingEnabled = true;
            this.groupsList.Location = new System.Drawing.Point(348, 36);
            this.groupsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupsList.Name = "groupsList";
            this.groupsList.Size = new System.Drawing.Size(336, 24);
            this.groupsList.TabIndex = 7;
            // 
            // hoursCount
            // 
            this.hoursCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hoursCount.Location = new System.Drawing.Point(348, 68);
            this.hoursCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hoursCount.Name = "hoursCount";
            this.hoursCount.Size = new System.Drawing.Size(336, 22);
            this.hoursCount.TabIndex = 8;
            // 
            // lessontype
            // 
            this.lessontype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lessontype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessontype.FormattingEnabled = true;
            this.lessontype.Items.AddRange(new object[] {
            "Лекция",
            "Семинар",
            "Лабораторная"});
            this.lessontype.Location = new System.Drawing.Point(348, 98);
            this.lessontype.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lessontype.Name = "lessontype";
            this.lessontype.Size = new System.Drawing.Size(336, 24);
            this.lessontype.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(584, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 82);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 216);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddLoadForm";
            this.Text = "Добавление нагрузки";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox teachersList;
        private System.Windows.Forms.ComboBox groupsList;
        private System.Windows.Forms.TextBox hoursCount;
        private System.Windows.Forms.ComboBox lessontype;
        private System.Windows.Forms.Button button1;
    }
}