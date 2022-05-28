
namespace Teacher_Manajar
{
    partial class FormCreatGroup
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
            this.components = new System.ComponentModel.Container();
            this.Panel_moveShape = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonCustom_minimize = new Custom.ButtonCustom();
            this.ButtonCustom_Exit = new Custom.ButtonCustom();
            this.panel_BackgroundColor = new System.Windows.Forms.Panel();
            this.panel_FrontColor = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group_Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel15 = new System.Windows.Forms.Panel();
            this.buttonCustom_DeleteData = new Custom.ButtonCustom();
            this.buttonCustom_СreatGroup = new Custom.ButtonCustom();
            this.panel14 = new System.Windows.Forms.Panel();
            this.buttonCustom_FindStudentsAll = new Custom.ButtonCustom();
            this.buttonCustom_AddStudent = new Custom.ButtonCustom();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label_warningCourse = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.MaskedTextBox_Course = new System.Windows.Forms.MaskedTextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_warningGroup = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.MyTextBox_Group = new Custom.MyTextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_warningName_Subject = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MyTextBox_Name_Subject = new Custom.MyTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer_CheckButton = new System.Windows.Forms.Timer(this.components);
            this.Panel_moveShape.SuspendLayout();
            this.panel_BackgroundColor.SuspendLayout();
            this.panel_FrontColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_moveShape
            // 
            this.Panel_moveShape.BackColor = System.Drawing.Color.White;
            this.Panel_moveShape.Controls.Add(this.label4);
            this.Panel_moveShape.Controls.Add(this.ButtonCustom_minimize);
            this.Panel_moveShape.Controls.Add(this.ButtonCustom_Exit);
            this.Panel_moveShape.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_moveShape.Location = new System.Drawing.Point(0, 0);
            this.Panel_moveShape.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_moveShape.Name = "Panel_moveShape";
            this.Panel_moveShape.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Panel_moveShape.Size = new System.Drawing.Size(680, 32);
            this.Panel_moveShape.TabIndex = 7;
            this.Panel_moveShape.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_moveShape_MouseDown);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Додати студентів";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonCustom_minimize
            // 
            this.ButtonCustom_minimize.BackColor = System.Drawing.Color.Blue;
            this.ButtonCustom_minimize.BackgroundColor = System.Drawing.Color.Blue;
            this.ButtonCustom_minimize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCustom_minimize.BorderRadius = 0;
            this.ButtonCustom_minimize.BorderSize = 0;
            this.ButtonCustom_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCustom_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonCustom_minimize.FlatAppearance.BorderSize = 0;
            this.ButtonCustom_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCustom_minimize.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCustom_minimize.ForeColor = System.Drawing.Color.White;
            this.ButtonCustom_minimize.Location = new System.Drawing.Point(570, 0);
            this.ButtonCustom_minimize.Name = "ButtonCustom_minimize";
            this.ButtonCustom_minimize.Size = new System.Drawing.Size(55, 32);
            this.ButtonCustom_minimize.TabIndex = 1;
            this.ButtonCustom_minimize.Text = "-";
            this.ButtonCustom_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCustom_minimize.TextColor = System.Drawing.Color.White;
            this.ButtonCustom_minimize.UseVisualStyleBackColor = false;
            this.ButtonCustom_minimize.Click += new System.EventHandler(this.ButtonCustom_minimize_Click);
            // 
            // ButtonCustom_Exit
            // 
            this.ButtonCustom_Exit.BackColor = System.Drawing.Color.Red;
            this.ButtonCustom_Exit.BackgroundColor = System.Drawing.Color.Red;
            this.ButtonCustom_Exit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCustom_Exit.BorderRadius = 0;
            this.ButtonCustom_Exit.BorderSize = 0;
            this.ButtonCustom_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCustom_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonCustom_Exit.FlatAppearance.BorderSize = 0;
            this.ButtonCustom_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCustom_Exit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCustom_Exit.ForeColor = System.Drawing.Color.White;
            this.ButtonCustom_Exit.Location = new System.Drawing.Point(625, 0);
            this.ButtonCustom_Exit.Name = "ButtonCustom_Exit";
            this.ButtonCustom_Exit.Size = new System.Drawing.Size(55, 32);
            this.ButtonCustom_Exit.TabIndex = 0;
            this.ButtonCustom_Exit.Text = "X";
            this.ButtonCustom_Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCustom_Exit.TextColor = System.Drawing.Color.White;
            this.ButtonCustom_Exit.UseVisualStyleBackColor = false;
            this.ButtonCustom_Exit.Click += new System.EventHandler(this.ButtonCustom_Exit_Click);
            // 
            // panel_BackgroundColor
            // 
            this.panel_BackgroundColor.Controls.Add(this.panel_FrontColor);
            this.panel_BackgroundColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BackgroundColor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_BackgroundColor.Location = new System.Drawing.Point(0, 32);
            this.panel_BackgroundColor.Name = "panel_BackgroundColor";
            this.panel_BackgroundColor.Padding = new System.Windows.Forms.Padding(5);
            this.panel_BackgroundColor.Size = new System.Drawing.Size(680, 573);
            this.panel_BackgroundColor.TabIndex = 12;
            // 
            // panel_FrontColor
            // 
            this.panel_FrontColor.Controls.Add(this.dataGridView1);
            this.panel_FrontColor.Controls.Add(this.panel15);
            this.panel_FrontColor.Controls.Add(this.panel14);
            this.panel_FrontColor.Controls.Add(this.panel10);
            this.panel_FrontColor.Controls.Add(this.panel11);
            this.panel_FrontColor.Controls.Add(this.panel5);
            this.panel_FrontColor.Controls.Add(this.panel6);
            this.panel_FrontColor.Controls.Add(this.panel7);
            this.panel_FrontColor.Controls.Add(this.panel2);
            this.panel_FrontColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FrontColor.Location = new System.Drawing.Point(5, 5);
            this.panel_FrontColor.Name = "panel_FrontColor";
            this.panel_FrontColor.Padding = new System.Windows.Forms.Padding(5);
            this.panel_FrontColor.Size = new System.Drawing.Size(670, 563);
            this.panel_FrontColor.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Full_Name,
            this.Group_Course});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 293);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(660, 206);
            this.dataGridView1.TabIndex = 13;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 75;
            // 
            // Full_Name
            // 
            this.Full_Name.HeaderText = "ПІБ студента";
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            this.Full_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Full_Name.Width = 350;
            // 
            // Group_Course
            // 
            this.Group_Course.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Group_Course.HeaderText = "Група + Курс";
            this.Group_Course.Name = "Group_Course";
            this.Group_Course.ReadOnly = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.buttonCustom_DeleteData);
            this.panel15.Controls.Add(this.buttonCustom_СreatGroup);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel15.Location = new System.Drawing.Point(5, 499);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(75, 11, 75, 11);
            this.panel15.Size = new System.Drawing.Size(660, 59);
            this.panel15.TabIndex = 13;
            // 
            // buttonCustom_DeleteData
            // 
            this.buttonCustom_DeleteData.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_DeleteData.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_DeleteData.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_DeleteData.BorderRadius = 37;
            this.buttonCustom_DeleteData.BorderSize = 0;
            this.buttonCustom_DeleteData.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCustom_DeleteData.Enabled = false;
            this.buttonCustom_DeleteData.FlatAppearance.BorderSize = 0;
            this.buttonCustom_DeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_DeleteData.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_DeleteData.Location = new System.Drawing.Point(75, 11);
            this.buttonCustom_DeleteData.Name = "buttonCustom_DeleteData";
            this.buttonCustom_DeleteData.Size = new System.Drawing.Size(175, 37);
            this.buttonCustom_DeleteData.TabIndex = 2;
            this.buttonCustom_DeleteData.Text = "Очистити дані таблиці";
            this.buttonCustom_DeleteData.TextColor = System.Drawing.Color.White;
            this.buttonCustom_DeleteData.UseVisualStyleBackColor = false;
            this.buttonCustom_DeleteData.Click += new System.EventHandler(this.ButtonCustom_DeleteData_Click);
            // 
            // buttonCustom_СreatGroup
            // 
            this.buttonCustom_СreatGroup.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_СreatGroup.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_СreatGroup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_СreatGroup.BorderRadius = 35;
            this.buttonCustom_СreatGroup.BorderSize = 0;
            this.buttonCustom_СreatGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_СreatGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCustom_СreatGroup.Enabled = false;
            this.buttonCustom_СreatGroup.FlatAppearance.BorderSize = 0;
            this.buttonCustom_СreatGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_СreatGroup.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_СreatGroup.Location = new System.Drawing.Point(390, 11);
            this.buttonCustom_СreatGroup.Name = "buttonCustom_СreatGroup";
            this.buttonCustom_СreatGroup.Size = new System.Drawing.Size(195, 37);
            this.buttonCustom_СreatGroup.TabIndex = 0;
            this.buttonCustom_СreatGroup.Text = "Створити групу";
            this.buttonCustom_СreatGroup.TextColor = System.Drawing.Color.White;
            this.buttonCustom_СreatGroup.UseVisualStyleBackColor = false;
            this.buttonCustom_СreatGroup.Click += new System.EventHandler(this.ButtonCustom_СreatGroup_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.buttonCustom_FindStudentsAll);
            this.panel14.Controls.Add(this.buttonCustom_AddStudent);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel14.Location = new System.Drawing.Point(5, 236);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(75, 11, 75, 11);
            this.panel14.Size = new System.Drawing.Size(660, 57);
            this.panel14.TabIndex = 14;
            // 
            // buttonCustom_FindStudentsAll
            // 
            this.buttonCustom_FindStudentsAll.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_FindStudentsAll.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_FindStudentsAll.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_FindStudentsAll.BorderRadius = 33;
            this.buttonCustom_FindStudentsAll.BorderSize = 0;
            this.buttonCustom_FindStudentsAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_FindStudentsAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCustom_FindStudentsAll.Enabled = false;
            this.buttonCustom_FindStudentsAll.FlatAppearance.BorderSize = 0;
            this.buttonCustom_FindStudentsAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_FindStudentsAll.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_FindStudentsAll.Location = new System.Drawing.Point(425, 11);
            this.buttonCustom_FindStudentsAll.Name = "buttonCustom_FindStudentsAll";
            this.buttonCustom_FindStudentsAll.Size = new System.Drawing.Size(160, 35);
            this.buttonCustom_FindStudentsAll.TabIndex = 1;
            this.buttonCustom_FindStudentsAll.Text = "Пошук студентів";
            this.buttonCustom_FindStudentsAll.TextColor = System.Drawing.Color.White;
            this.buttonCustom_FindStudentsAll.UseVisualStyleBackColor = false;
            this.buttonCustom_FindStudentsAll.Click += new System.EventHandler(this.ButtonCustom_FindStudentsAll_Click);
            // 
            // buttonCustom_AddStudent
            // 
            this.buttonCustom_AddStudent.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_AddStudent.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_AddStudent.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_AddStudent.BorderRadius = 33;
            this.buttonCustom_AddStudent.BorderSize = 0;
            this.buttonCustom_AddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_AddStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCustom_AddStudent.FlatAppearance.BorderSize = 0;
            this.buttonCustom_AddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_AddStudent.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_AddStudent.Location = new System.Drawing.Point(75, 11);
            this.buttonCustom_AddStudent.Name = "buttonCustom_AddStudent";
            this.buttonCustom_AddStudent.Size = new System.Drawing.Size(170, 35);
            this.buttonCustom_AddStudent.TabIndex = 0;
            this.buttonCustom_AddStudent.Text = "Додати студента за ID";
            this.buttonCustom_AddStudent.TextColor = System.Drawing.Color.White;
            this.buttonCustom_AddStudent.UseVisualStyleBackColor = false;
            this.buttonCustom_AddStudent.Click += new System.EventHandler(this.ButtonCustom_AddStudent_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label_warningCourse);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel10.Location = new System.Drawing.Point(5, 204);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(270, 0, 0, 0);
            this.panel10.Size = new System.Drawing.Size(660, 32);
            this.panel10.TabIndex = 17;
            // 
            // label_warningCourse
            // 
            this.label_warningCourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_warningCourse.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_warningCourse.ForeColor = System.Drawing.Color.Red;
            this.label_warningCourse.Location = new System.Drawing.Point(270, 0);
            this.label_warningCourse.Name = "label_warningCourse";
            this.label_warningCourse.Size = new System.Drawing.Size(390, 32);
            this.label_warningCourse.TabIndex = 0;
            this.label_warningCourse.Text = "Дане поле потрібно заповнити";
            this.label_warningCourse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(5, 159);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel11.Size = new System.Drawing.Size(660, 45);
            this.panel11.TabIndex = 16;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.MaskedTextBox_Course);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel12.Location = new System.Drawing.Point(250, 0);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(20, 8, 0, 0);
            this.panel12.Size = new System.Drawing.Size(400, 45);
            this.panel12.TabIndex = 1;
            // 
            // MaskedTextBox_Course
            // 
            this.MaskedTextBox_Course.Dock = System.Windows.Forms.DockStyle.Left;
            this.MaskedTextBox_Course.Enabled = false;
            this.MaskedTextBox_Course.Location = new System.Drawing.Point(20, 8);
            this.MaskedTextBox_Course.Mask = "0";
            this.MaskedTextBox_Course.Name = "MaskedTextBox_Course";
            this.MaskedTextBox_Course.Size = new System.Drawing.Size(15, 26);
            this.MaskedTextBox_Course.TabIndex = 0;
            this.MaskedTextBox_Course.TextChanged += new System.EventHandler(this.MaskedTextBox_Course_TextChanged);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label6);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(10, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(248, 45);
            this.panel13.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Georgia", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "Курс";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label_warningGroup);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel5.Location = new System.Drawing.Point(5, 127);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(270, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(660, 32);
            this.panel5.TabIndex = 15;
            // 
            // label_warningGroup
            // 
            this.label_warningGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_warningGroup.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_warningGroup.ForeColor = System.Drawing.Color.Red;
            this.label_warningGroup.Location = new System.Drawing.Point(270, 0);
            this.label_warningGroup.Name = "label_warningGroup";
            this.label_warningGroup.Size = new System.Drawing.Size(390, 32);
            this.label_warningGroup.TabIndex = 0;
            this.label_warningGroup.Text = "Дане поле потрібно заповнити";
            this.label_warningGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(5, 82);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel6.Size = new System.Drawing.Size(660, 45);
            this.panel6.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.MyTextBox_Group);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel8.Location = new System.Drawing.Point(250, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panel8.Size = new System.Drawing.Size(400, 45);
            this.panel8.TabIndex = 1;
            // 
            // MyTextBox_Group
            // 
            this.MyTextBox_Group.BackColor = System.Drawing.SystemColors.Window;
            this.MyTextBox_Group.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.MyTextBox_Group.BorderFocusColor = System.Drawing.Color.Green;
            this.MyTextBox_Group.BorderRadius = 10;
            this.MyTextBox_Group.BorderSize = 2;
            this.MyTextBox_Group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTextBox_Group.Enabled = false;
            this.MyTextBox_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyTextBox_Group.ForeColor = System.Drawing.Color.DimGray;
            this.MyTextBox_Group.Location = new System.Drawing.Point(0, 8);
            this.MyTextBox_Group.Margin = new System.Windows.Forms.Padding(4);
            this.MyTextBox_Group.Multiline = false;
            this.MyTextBox_Group.Name = "MyTextBox_Group";
            this.MyTextBox_Group.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.MyTextBox_Group.PasswordChar = false;
            this.MyTextBox_Group.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.MyTextBox_Group.PlaceholderText = "Введить повну назву групи";
            this.MyTextBox_Group.Size = new System.Drawing.Size(400, 31);
            this.MyTextBox_Group.TabIndex = 0;
            this.MyTextBox_Group.Texts = "";
            this.MyTextBox_Group.UnderlinedStyle = false;
            this.MyTextBox_Group._TextChanger += new System.EventHandler(this.MyTextBox_Group__TextChanger);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(10, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(248, 45);
            this.panel9.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Georgia", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Група";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label_warningName_Subject);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel7.Location = new System.Drawing.Point(5, 50);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(270, 0, 0, 0);
            this.panel7.Size = new System.Drawing.Size(660, 32);
            this.panel7.TabIndex = 13;
            // 
            // label_warningName_Subject
            // 
            this.label_warningName_Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_warningName_Subject.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_warningName_Subject.ForeColor = System.Drawing.Color.Red;
            this.label_warningName_Subject.Location = new System.Drawing.Point(270, 0);
            this.label_warningName_Subject.Name = "label_warningName_Subject";
            this.label_warningName_Subject.Size = new System.Drawing.Size(390, 32);
            this.label_warningName_Subject.TabIndex = 0;
            this.label_warningName_Subject.Text = "Дане поле потрібно заповнити";
            this.label_warningName_Subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel2.Size = new System.Drawing.Size(660, 45);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.MyTextBox_Name_Subject);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(250, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.panel4.Size = new System.Drawing.Size(400, 45);
            this.panel4.TabIndex = 1;
            // 
            // MyTextBox_Name_Subject
            // 
            this.MyTextBox_Name_Subject.BackColor = System.Drawing.SystemColors.Window;
            this.MyTextBox_Name_Subject.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.MyTextBox_Name_Subject.BorderFocusColor = System.Drawing.Color.Green;
            this.MyTextBox_Name_Subject.BorderRadius = 10;
            this.MyTextBox_Name_Subject.BorderSize = 2;
            this.MyTextBox_Name_Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTextBox_Name_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyTextBox_Name_Subject.ForeColor = System.Drawing.Color.DimGray;
            this.MyTextBox_Name_Subject.Location = new System.Drawing.Point(0, 8);
            this.MyTextBox_Name_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.MyTextBox_Name_Subject.Multiline = false;
            this.MyTextBox_Name_Subject.Name = "MyTextBox_Name_Subject";
            this.MyTextBox_Name_Subject.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.MyTextBox_Name_Subject.PasswordChar = false;
            this.MyTextBox_Name_Subject.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.MyTextBox_Name_Subject.PlaceholderText = "Введіть повну назву дисципліни";
            this.MyTextBox_Name_Subject.Size = new System.Drawing.Size(400, 31);
            this.MyTextBox_Name_Subject.TabIndex = 0;
            this.MyTextBox_Name_Subject.Texts = "";
            this.MyTextBox_Name_Subject.UnderlinedStyle = false;
            this.MyTextBox_Name_Subject._TextChanger += new System.EventHandler(this.MyTextBox_Name_Subject__TextChanger);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 45);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва дисципліни";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_CheckButton
            // 
            this.Timer_CheckButton.Interval = 500;
            this.Timer_CheckButton.Tick += new System.EventHandler(this.Timer_CheckButton_Tick);
            // 
            // FormCreatGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 605);
            this.ControlBox = false;
            this.Controls.Add(this.panel_BackgroundColor);
            this.Controls.Add(this.Panel_moveShape);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(680, 605);
            this.MinimumSize = new System.Drawing.Size(680, 605);
            this.Name = "FormCreatGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Panel_moveShape.ResumeLayout(false);
            this.panel_BackgroundColor.ResumeLayout(false);
            this.panel_FrontColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_moveShape;
        private System.Windows.Forms.Label label4;
        private Custom.ButtonCustom ButtonCustom_minimize;
        private Custom.ButtonCustom ButtonCustom_Exit;
        private System.Windows.Forms.Panel panel_BackgroundColor;
        private System.Windows.Forms.Timer Timer_CheckButton;
        private System.Windows.Forms.Panel panel_FrontColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel15;
        private Custom.ButtonCustom buttonCustom_DeleteData;
        private Custom.ButtonCustom buttonCustom_СreatGroup;
        private System.Windows.Forms.Panel panel14;
        private Custom.ButtonCustom buttonCustom_FindStudentsAll;
        private Custom.ButtonCustom buttonCustom_AddStudent;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label_warningCourse;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.MaskedTextBox MaskedTextBox_Course;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label_warningGroup;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private Custom.MyTextBox MyTextBox_Group;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_warningName_Subject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Custom.MyTextBox MyTextBox_Name_Subject;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group_Course;
    }
}