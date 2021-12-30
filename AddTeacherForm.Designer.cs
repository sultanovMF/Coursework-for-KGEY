namespace FinalCoursework
{
    partial class AddTeacherForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.surnametb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.middlenametb = new System.Windows.Forms.TextBox();
            this.numbertb = new System.Windows.Forms.TextBox();
            this.experiencetb = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.surnametb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nametb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.middlenametb, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numbertb, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.experiencetb, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 162);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Стаж";
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AddButton.Location = new System.Drawing.Point(422, 133);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 26);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // surnametb
            // 
            this.surnametb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.surnametb.Location = new System.Drawing.Point(253, 3);
            this.surnametb.Name = "surnametb";
            this.surnametb.Size = new System.Drawing.Size(244, 20);
            this.surnametb.TabIndex = 6;
            // 
            // nametb
            // 
            this.nametb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nametb.Location = new System.Drawing.Point(253, 29);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(244, 20);
            this.nametb.TabIndex = 7;
            // 
            // middlenametb
            // 
            this.middlenametb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlenametb.Location = new System.Drawing.Point(253, 55);
            this.middlenametb.Name = "middlenametb";
            this.middlenametb.Size = new System.Drawing.Size(244, 20);
            this.middlenametb.TabIndex = 8;
            // 
            // numbertb
            // 
            this.numbertb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numbertb.Location = new System.Drawing.Point(253, 81);
            this.numbertb.Name = "numbertb";
            this.numbertb.Size = new System.Drawing.Size(244, 20);
            this.numbertb.TabIndex = 9;
            // 
            // experiencetb
            // 
            this.experiencetb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.experiencetb.Location = new System.Drawing.Point(253, 107);
            this.experiencetb.Name = "experiencetb";
            this.experiencetb.Size = new System.Drawing.Size(244, 20);
            this.experiencetb.TabIndex = 10;
            // 
            // AddTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 162);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddTeacherForm";
            this.Text = "Добавление преподователя";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox surnametb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox middlenametb;
        private System.Windows.Forms.TextBox numbertb;
        private System.Windows.Forms.TextBox experiencetb;
    }
}