
namespace Teacher_Manajar
{
    partial class FormAddStudent
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
            this.Timer_AddStudent = new System.Windows.Forms.Timer(this.components);
            this.panel_FrontColor = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group_Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel15 = new System.Windows.Forms.Panel();
            this.buttonCustom_DeleteData = new Custom.ButtonCustom();
            this.buttonCustom_СreatGroup = new Custom.ButtonCustom();
            this.panel14 = new System.Windows.Forms.Panel();
            this.buttonCustom_AddStudent = new Custom.ButtonCustom();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label_warningIdentifier = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MyTextBox_Identifier = new Custom.MyTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Background = new System.Windows.Forms.Panel();
            this.Panel_moveShape.SuspendLayout();
            this.panel_FrontColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_Background.SuspendLayout();
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
            this.Panel_moveShape.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Panel_moveShape.Size = new System.Drawing.Size(630, 32);
            this.Panel_moveShape.TabIndex = 8;
            this.Panel_moveShape.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_moveShape_MouseDown);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Додати студента";
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
            this.ButtonCustom_minimize.Location = new System.Drawing.Point(520, 0);
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
            this.ButtonCustom_Exit.Location = new System.Drawing.Point(575, 0);
            this.ButtonCustom_Exit.Name = "ButtonCustom_Exit";
            this.ButtonCustom_Exit.Size = new System.Drawing.Size(55, 32);
            this.ButtonCustom_Exit.TabIndex = 0;
            this.ButtonCustom_Exit.Text = "X";
            this.ButtonCustom_Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCustom_Exit.TextColor = System.Drawing.Color.White;
            this.ButtonCustom_Exit.UseVisualStyleBackColor = false;
            this.ButtonCustom_Exit.Click += new System.EventHandler(this.ButtonCustom_Exit_Click);
            // 
            // Timer_AddStudent
            // 
            this.Timer_AddStudent.Interval = 500;
            this.Timer_AddStudent.Tick += new System.EventHandler(this.Timer_AddStudent_Tick);
            // 
            // panel_FrontColor
            // 
            this.panel_FrontColor.Controls.Add(this.dataGridView1);
            this.panel_FrontColor.Controls.Add(this.panel15);
            this.panel_FrontColor.Controls.Add(this.panel14);
            this.panel_FrontColor.Controls.Add(this.panel7);
            this.panel_FrontColor.Controls.Add(this.panel2);
            this.panel_FrontColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FrontColor.Location = new System.Drawing.Point(5, 5);
            this.panel_FrontColor.Name = "panel_FrontColor";
            this.panel_FrontColor.Size = new System.Drawing.Size(620, 258);
            this.panel_FrontColor.TabIndex = 14;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(620, 60);
            this.dataGridView1.TabIndex = 16;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 25;
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
            this.panel15.Location = new System.Drawing.Point(0, 199);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(75, 11, 75, 11);
            this.panel15.Size = new System.Drawing.Size(620, 59);
            this.panel15.TabIndex = 15;
            // 
            // buttonCustom_DeleteData
            // 
            this.buttonCustom_DeleteData.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_DeleteData.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_DeleteData.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_DeleteData.BorderRadius = 37;
            this.buttonCustom_DeleteData.BorderSize = 0;
            this.buttonCustom_DeleteData.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCustom_DeleteData.FlatAppearance.BorderSize = 0;
            this.buttonCustom_DeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_DeleteData.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_DeleteData.Location = new System.Drawing.Point(75, 11);
            this.buttonCustom_DeleteData.Name = "buttonCustom_DeleteData";
            this.buttonCustom_DeleteData.Size = new System.Drawing.Size(175, 37);
            this.buttonCustom_DeleteData.TabIndex = 1;
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
            this.buttonCustom_СreatGroup.Location = new System.Drawing.Point(324, 11);
            this.buttonCustom_СreatGroup.Name = "buttonCustom_СreatGroup";
            this.buttonCustom_СreatGroup.Size = new System.Drawing.Size(221, 37);
            this.buttonCustom_СreatGroup.TabIndex = 0;
            this.buttonCustom_СreatGroup.Text = "Додати до основної групи";
            this.buttonCustom_СreatGroup.TextColor = System.Drawing.Color.White;
            this.buttonCustom_СreatGroup.UseVisualStyleBackColor = false;
            this.buttonCustom_СreatGroup.Click += new System.EventHandler(this.ButtonCustom_СreatGroup_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.buttonCustom_AddStudent);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel14.Location = new System.Drawing.Point(0, 82);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(200, 11, 200, 11);
            this.panel14.Size = new System.Drawing.Size(620, 57);
            this.panel14.TabIndex = 12;
            // 
            // buttonCustom_AddStudent
            // 
            this.buttonCustom_AddStudent.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_AddStudent.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_AddStudent.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_AddStudent.BorderRadius = 33;
            this.buttonCustom_AddStudent.BorderSize = 0;
            this.buttonCustom_AddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_AddStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCustom_AddStudent.FlatAppearance.BorderSize = 0;
            this.buttonCustom_AddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_AddStudent.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_AddStudent.Location = new System.Drawing.Point(200, 11);
            this.buttonCustom_AddStudent.Name = "buttonCustom_AddStudent";
            this.buttonCustom_AddStudent.Size = new System.Drawing.Size(220, 35);
            this.buttonCustom_AddStudent.TabIndex = 0;
            this.buttonCustom_AddStudent.Text = "Додати студента за ID";
            this.buttonCustom_AddStudent.TextColor = System.Drawing.Color.White;
            this.buttonCustom_AddStudent.UseVisualStyleBackColor = false;
            this.buttonCustom_AddStudent.Click += new System.EventHandler(this.ButtonCustom_AddStudent_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label_warningIdentifier);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel7.Location = new System.Drawing.Point(0, 50);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(225, 0, 0, 0);
            this.panel7.Size = new System.Drawing.Size(620, 32);
            this.panel7.TabIndex = 11;
            // 
            // label_warningIdentifier
            // 
            this.label_warningIdentifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_warningIdentifier.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_warningIdentifier.ForeColor = System.Drawing.Color.Red;
            this.label_warningIdentifier.Location = new System.Drawing.Point(225, 0);
            this.label_warningIdentifier.Name = "label_warningIdentifier";
            this.label_warningIdentifier.Size = new System.Drawing.Size(395, 32);
            this.label_warningIdentifier.TabIndex = 0;
            this.label_warningIdentifier.Text = "Дане поле потрібно заповнити";
            this.label_warningIdentifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel2.Size = new System.Drawing.Size(620, 50);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.MyTextBox_Identifier);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel4.Location = new System.Drawing.Point(210, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.panel4.Size = new System.Drawing.Size(400, 50);
            this.panel4.TabIndex = 1;
            // 
            // MyTextBox_Identifier
            // 
            this.MyTextBox_Identifier.BackColor = System.Drawing.SystemColors.Window;
            this.MyTextBox_Identifier.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.MyTextBox_Identifier.BorderFocusColor = System.Drawing.Color.Green;
            this.MyTextBox_Identifier.BorderRadius = 10;
            this.MyTextBox_Identifier.BorderSize = 2;
            this.MyTextBox_Identifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTextBox_Identifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyTextBox_Identifier.ForeColor = System.Drawing.Color.DimGray;
            this.MyTextBox_Identifier.Location = new System.Drawing.Point(0, 13);
            this.MyTextBox_Identifier.Margin = new System.Windows.Forms.Padding(4);
            this.MyTextBox_Identifier.Multiline = false;
            this.MyTextBox_Identifier.Name = "MyTextBox_Identifier";
            this.MyTextBox_Identifier.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.MyTextBox_Identifier.PasswordChar = false;
            this.MyTextBox_Identifier.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.MyTextBox_Identifier.PlaceholderText = "Введіть повний індентифікатор студента";
            this.MyTextBox_Identifier.Size = new System.Drawing.Size(400, 27);
            this.MyTextBox_Identifier.TabIndex = 0;
            this.MyTextBox_Identifier.Texts = "";
            this.MyTextBox_Identifier.UnderlinedStyle = false;
            this.MyTextBox_Identifier._TextChanger += new System.EventHandler(this.MyTextBox_Identifier__TextChanger);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(10, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 50);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Georgia", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ідентифікатор";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Background
            // 
            this.panel_Background.Controls.Add(this.panel_FrontColor);
            this.panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Background.Location = new System.Drawing.Point(0, 32);
            this.panel_Background.Name = "panel_Background";
            this.panel_Background.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Background.Size = new System.Drawing.Size(630, 268);
            this.panel_Background.TabIndex = 15;
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 300);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Background);
            this.Controls.Add(this.Panel_moveShape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(630, 300);
            this.MinimumSize = new System.Drawing.Size(630, 300);
            this.Name = "FormAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Panel_moveShape.ResumeLayout(false);
            this.panel_FrontColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_Background.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_moveShape;
        private System.Windows.Forms.Label label4;
        private Custom.ButtonCustom ButtonCustom_minimize;
        private Custom.ButtonCustom ButtonCustom_Exit;
        private System.Windows.Forms.Timer Timer_AddStudent;
        private System.Windows.Forms.Panel panel_FrontColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group_Course;
        private System.Windows.Forms.Panel panel15;
        private Custom.ButtonCustom buttonCustom_DeleteData;
        private Custom.ButtonCustom buttonCustom_СreatGroup;
        private System.Windows.Forms.Panel panel14;
        private Custom.ButtonCustom buttonCustom_AddStudent;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label_warningIdentifier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private Custom.MyTextBox MyTextBox_Identifier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Background;
    }
}