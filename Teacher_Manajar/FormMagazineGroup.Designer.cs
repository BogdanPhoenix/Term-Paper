
namespace Teacher_Manajar
{
    partial class FormMagazineGroup
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
            this.panel_Background = new System.Windows.Forms.Panel();
            this.panel_FrontColor = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_TeacherRole = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCustom_DeleteMagazine = new Custom.ButtonCustom();
            this.panel10 = new System.Windows.Forms.Panel();
            this.buttonCustom_addStudent = new Custom.ButtonCustom();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonCustom_CalendarPlan = new Custom.ButtonCustom();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ButtonCustom_addClasses = new Custom.ButtonCustom();
            this.ButtonCustom_goBack = new Custom.ButtonCustom();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_MagazineNameTitle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonCustom_Save = new Custom.ButtonCustom();
            this.Panel_moveShape = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.ButtonCustom_minimize = new Custom.ButtonCustom();
            this.ButtonCustom_Exit = new Custom.ButtonCustom();
            this.panel_Background.SuspendLayout();
            this.panel_FrontColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel_TeacherRole.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.Panel_moveShape.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Background
            // 
            this.panel_Background.Controls.Add(this.panel_FrontColor);
            this.panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Background.Location = new System.Drawing.Point(0, 30);
            this.panel_Background.Name = "panel_Background";
            this.panel_Background.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Background.Size = new System.Drawing.Size(1180, 815);
            this.panel_Background.TabIndex = 0;
            // 
            // panel_FrontColor
            // 
            this.panel_FrontColor.Controls.Add(this.dataGridView1);
            this.panel_FrontColor.Controls.Add(this.panel2);
            this.panel_FrontColor.Controls.Add(this.panel4);
            this.panel_FrontColor.Controls.Add(this.panel5);
            this.panel_FrontColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FrontColor.Location = new System.Drawing.Point(5, 5);
            this.panel_FrontColor.Name = "panel_FrontColor";
            this.panel_FrontColor.Size = new System.Drawing.Size(1170, 805);
            this.panel_FrontColor.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Full_Name});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1170, 642);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.Width = 50;
            // 
            // Full_Name
            // 
            this.Full_Name.HeaderText = "ПІБ";
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.ReadOnly = true;
            this.Full_Name.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_TeacherRole);
            this.panel2.Controls.Add(this.ButtonCustom_goBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 702);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20);
            this.panel2.Size = new System.Drawing.Size(1170, 103);
            this.panel2.TabIndex = 12;
            // 
            // panel_TeacherRole
            // 
            this.panel_TeacherRole.Controls.Add(this.panel3);
            this.panel_TeacherRole.Controls.Add(this.panel10);
            this.panel_TeacherRole.Controls.Add(this.panel9);
            this.panel_TeacherRole.Controls.Add(this.panel8);
            this.panel_TeacherRole.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_TeacherRole.Location = new System.Drawing.Point(440, 20);
            this.panel_TeacherRole.Name = "panel_TeacherRole";
            this.panel_TeacherRole.Size = new System.Drawing.Size(710, 63);
            this.panel_TeacherRole.TabIndex = 7;
            this.panel_TeacherRole.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCustom_DeleteMagazine);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(5, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel3.Size = new System.Drawing.Size(185, 63);
            this.panel3.TabIndex = 3;
            // 
            // buttonCustom_DeleteMagazine
            // 
            this.buttonCustom_DeleteMagazine.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_DeleteMagazine.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_DeleteMagazine.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_DeleteMagazine.BorderRadius = 40;
            this.buttonCustom_DeleteMagazine.BorderSize = 0;
            this.buttonCustom_DeleteMagazine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_DeleteMagazine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCustom_DeleteMagazine.FlatAppearance.BorderSize = 0;
            this.buttonCustom_DeleteMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_DeleteMagazine.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_DeleteMagazine.Location = new System.Drawing.Point(10, 0);
            this.buttonCustom_DeleteMagazine.Name = "buttonCustom_DeleteMagazine";
            this.buttonCustom_DeleteMagazine.Size = new System.Drawing.Size(165, 63);
            this.buttonCustom_DeleteMagazine.TabIndex = 0;
            this.buttonCustom_DeleteMagazine.Text = "Видалити журнал";
            this.buttonCustom_DeleteMagazine.TextColor = System.Drawing.Color.White;
            this.buttonCustom_DeleteMagazine.UseVisualStyleBackColor = false;
            this.buttonCustom_DeleteMagazine.Click += new System.EventHandler(this.ButtonCustom_DeleteMagazine_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.buttonCustom_addStudent);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(190, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel10.Size = new System.Drawing.Size(170, 63);
            this.panel10.TabIndex = 2;
            // 
            // buttonCustom_addStudent
            // 
            this.buttonCustom_addStudent.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_addStudent.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_addStudent.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_addStudent.BorderRadius = 40;
            this.buttonCustom_addStudent.BorderSize = 0;
            this.buttonCustom_addStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_addStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCustom_addStudent.FlatAppearance.BorderSize = 0;
            this.buttonCustom_addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_addStudent.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_addStudent.Location = new System.Drawing.Point(10, 0);
            this.buttonCustom_addStudent.Name = "buttonCustom_addStudent";
            this.buttonCustom_addStudent.Size = new System.Drawing.Size(150, 63);
            this.buttonCustom_addStudent.TabIndex = 0;
            this.buttonCustom_addStudent.Text = "Додати студента";
            this.buttonCustom_addStudent.TextColor = System.Drawing.Color.White;
            this.buttonCustom_addStudent.UseVisualStyleBackColor = false;
            this.buttonCustom_addStudent.Click += new System.EventHandler(this.ButtonCustom_addStudent_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.buttonCustom_CalendarPlan);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(360, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel9.Size = new System.Drawing.Size(190, 63);
            this.panel9.TabIndex = 1;
            // 
            // buttonCustom_CalendarPlan
            // 
            this.buttonCustom_CalendarPlan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_CalendarPlan.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_CalendarPlan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_CalendarPlan.BorderRadius = 40;
            this.buttonCustom_CalendarPlan.BorderSize = 0;
            this.buttonCustom_CalendarPlan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_CalendarPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCustom_CalendarPlan.FlatAppearance.BorderSize = 0;
            this.buttonCustom_CalendarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_CalendarPlan.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_CalendarPlan.Location = new System.Drawing.Point(10, 0);
            this.buttonCustom_CalendarPlan.Name = "buttonCustom_CalendarPlan";
            this.buttonCustom_CalendarPlan.Size = new System.Drawing.Size(170, 63);
            this.buttonCustom_CalendarPlan.TabIndex = 4;
            this.buttonCustom_CalendarPlan.Text = "Календарний план";
            this.buttonCustom_CalendarPlan.TextColor = System.Drawing.Color.White;
            this.buttonCustom_CalendarPlan.UseVisualStyleBackColor = false;
            this.buttonCustom_CalendarPlan.Click += new System.EventHandler(this.ButtonCustom_CalendarPlan_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ButtonCustom_addClasses);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(550, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel8.Size = new System.Drawing.Size(160, 63);
            this.panel8.TabIndex = 0;
            // 
            // ButtonCustom_addClasses
            // 
            this.ButtonCustom_addClasses.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonCustom_addClasses.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonCustom_addClasses.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCustom_addClasses.BorderRadius = 40;
            this.ButtonCustom_addClasses.BorderSize = 0;
            this.ButtonCustom_addClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCustom_addClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCustom_addClasses.FlatAppearance.BorderSize = 0;
            this.ButtonCustom_addClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCustom_addClasses.ForeColor = System.Drawing.Color.White;
            this.ButtonCustom_addClasses.Location = new System.Drawing.Point(10, 0);
            this.ButtonCustom_addClasses.Name = "ButtonCustom_addClasses";
            this.ButtonCustom_addClasses.Size = new System.Drawing.Size(150, 63);
            this.ButtonCustom_addClasses.TabIndex = 3;
            this.ButtonCustom_addClasses.Text = "Додати заняття";
            this.ButtonCustom_addClasses.TextColor = System.Drawing.Color.White;
            this.ButtonCustom_addClasses.UseVisualStyleBackColor = false;
            this.ButtonCustom_addClasses.Click += new System.EventHandler(this.ButtonCustom_addClasses_Click);
            // 
            // ButtonCustom_goBack
            // 
            this.ButtonCustom_goBack.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonCustom_goBack.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonCustom_goBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCustom_goBack.BorderRadius = 40;
            this.ButtonCustom_goBack.BorderSize = 0;
            this.ButtonCustom_goBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCustom_goBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonCustom_goBack.FlatAppearance.BorderSize = 0;
            this.ButtonCustom_goBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCustom_goBack.ForeColor = System.Drawing.Color.White;
            this.ButtonCustom_goBack.Location = new System.Drawing.Point(20, 20);
            this.ButtonCustom_goBack.Name = "ButtonCustom_goBack";
            this.ButtonCustom_goBack.Size = new System.Drawing.Size(173, 63);
            this.ButtonCustom_goBack.TabIndex = 2;
            this.ButtonCustom_goBack.Text = "Повернутися назад";
            this.ButtonCustom_goBack.TextColor = System.Drawing.Color.White;
            this.ButtonCustom_goBack.UseVisualStyleBackColor = false;
            this.ButtonCustom_goBack.Click += new System.EventHandler(this.ButtonCustom_goBack_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_MagazineNameTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 35);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel4.Size = new System.Drawing.Size(1170, 25);
            this.panel4.TabIndex = 11;
            // 
            // label_MagazineNameTitle
            // 
            this.label_MagazineNameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_MagazineNameTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_MagazineNameTitle.Location = new System.Drawing.Point(20, 0);
            this.label_MagazineNameTitle.Name = "label_MagazineNameTitle";
            this.label_MagazineNameTitle.Size = new System.Drawing.Size(1130, 25);
            this.label_MagazineNameTitle.TabIndex = 0;
            this.label_MagazineNameTitle.Text = "Журнал: ";
            this.label_MagazineNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonCustom_Save);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel5.Size = new System.Drawing.Size(1170, 35);
            this.panel5.TabIndex = 8;
            // 
            // buttonCustom_Save
            // 
            this.buttonCustom_Save.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_Save.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_Save.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_Save.BorderRadius = 30;
            this.buttonCustom_Save.BorderSize = 0;
            this.buttonCustom_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_Save.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCustom_Save.FlatAppearance.BorderSize = 0;
            this.buttonCustom_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_Save.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCustom_Save.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_Save.Location = new System.Drawing.Point(10, 0);
            this.buttonCustom_Save.Name = "buttonCustom_Save";
            this.buttonCustom_Save.Size = new System.Drawing.Size(122, 35);
            this.buttonCustom_Save.TabIndex = 0;
            this.buttonCustom_Save.Text = "Зберегти дані";
            this.buttonCustom_Save.TextColor = System.Drawing.Color.White;
            this.buttonCustom_Save.UseVisualStyleBackColor = false;
            this.buttonCustom_Save.Click += new System.EventHandler(this.buttonCustom_Save_Click);
            // 
            // Panel_moveShape
            // 
            this.Panel_moveShape.BackColor = System.Drawing.Color.White;
            this.Panel_moveShape.Controls.Add(this.label_Title);
            this.Panel_moveShape.Controls.Add(this.ButtonCustom_minimize);
            this.Panel_moveShape.Controls.Add(this.ButtonCustom_Exit);
            this.Panel_moveShape.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_moveShape.Location = new System.Drawing.Point(0, 0);
            this.Panel_moveShape.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_moveShape.Name = "Panel_moveShape";
            this.Panel_moveShape.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Panel_moveShape.Size = new System.Drawing.Size(1180, 30);
            this.Panel_moveShape.TabIndex = 6;
            this.Panel_moveShape.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_moveShape_MouseDown);
            // 
            // label_Title
            // 
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Title.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Title.Location = new System.Drawing.Point(20, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(86, 30);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "Журнал ";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ButtonCustom_minimize.Location = new System.Drawing.Point(1070, 0);
            this.ButtonCustom_minimize.Name = "ButtonCustom_minimize";
            this.ButtonCustom_minimize.Size = new System.Drawing.Size(55, 30);
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
            this.ButtonCustom_Exit.Location = new System.Drawing.Point(1125, 0);
            this.ButtonCustom_Exit.Name = "ButtonCustom_Exit";
            this.ButtonCustom_Exit.Size = new System.Drawing.Size(55, 30);
            this.ButtonCustom_Exit.TabIndex = 0;
            this.ButtonCustom_Exit.Text = "X";
            this.ButtonCustom_Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCustom_Exit.TextColor = System.Drawing.Color.White;
            this.ButtonCustom_Exit.UseVisualStyleBackColor = false;
            this.ButtonCustom_Exit.Click += new System.EventHandler(this.ButtonCustom_Exit_Click);
            // 
            // Form_Magazine_Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 845);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Background);
            this.Controls.Add(this.Panel_moveShape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 845);
            this.MinimumSize = new System.Drawing.Size(1180, 845);
            this.Name = "Form_Magazine_Group";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_Background.ResumeLayout(false);
            this.panel_FrontColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel_TeacherRole.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.Panel_moveShape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Background;
        private System.Windows.Forms.Panel Panel_moveShape;
        private System.Windows.Forms.Label label_Title;
        private Custom.ButtonCustom ButtonCustom_minimize;
        private Custom.ButtonCustom ButtonCustom_Exit;
        private System.Windows.Forms.Panel panel_FrontColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_TeacherRole;
        private System.Windows.Forms.Panel panel3;
        private Custom.ButtonCustom buttonCustom_DeleteMagazine;
        private System.Windows.Forms.Panel panel10;
        private Custom.ButtonCustom buttonCustom_addStudent;
        private System.Windows.Forms.Panel panel9;
        private Custom.ButtonCustom buttonCustom_CalendarPlan;
        private System.Windows.Forms.Panel panel8;
        private Custom.ButtonCustom ButtonCustom_addClasses;
        private Custom.ButtonCustom ButtonCustom_goBack;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_MagazineNameTitle;
        private System.Windows.Forms.Panel panel5;
        private Custom.ButtonCustom buttonCustom_Save;
    }
}