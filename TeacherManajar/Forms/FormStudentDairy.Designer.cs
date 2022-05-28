
namespace TeacherManajar.Forms
{
    partial class FormStudentDairy
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
            this.tableLayoutPanelDairyCalendar = new System.Windows.Forms.TableLayoutPanel();
            this.panelPeriod = new System.Windows.Forms.Panel();
            this.iconButtonPreviousWeek = new FontAwesome.Sharp.IconButton();
            this.iconButtonNextWeek = new FontAwesome.Sharp.IconButton();
            this.rjDatePickerEnd = new RJCodeAdvance.RJControls.RJDatePicker();
            this.rjDatePickerStart = new RJCodeAdvance.RJControls.RJDatePicker();
            this.tableLayoutPanelWeek = new System.Windows.Forms.TableLayoutPanel();
            this.panelWork = new System.Windows.Forms.Panel();
            this.tableLayoutPanelHomeWork = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTableTitleDay = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitleDay = new System.Windows.Forms.Label();
            this.panelButtonTools = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanelDairyCalendar.SuspendLayout();
            this.panelPeriod.SuspendLayout();
            this.panelWork.SuspendLayout();
            this.tableLayoutPanelHomeWork.SuspendLayout();
            this.panelTableTitleDay.SuspendLayout();
            this.panelButtonTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelDairyCalendar
            // 
            this.tableLayoutPanelDairyCalendar.ColumnCount = 1;
            this.tableLayoutPanelDairyCalendar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDairyCalendar.Controls.Add(this.tableLayoutPanelWeek, 0, 1);
            this.tableLayoutPanelDairyCalendar.Controls.Add(this.panelPeriod, 0, 0);
            this.tableLayoutPanelDairyCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelDairyCalendar.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanelDairyCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelDairyCalendar.Name = "tableLayoutPanelDairyCalendar";
            this.tableLayoutPanelDairyCalendar.RowCount = 2;
            this.tableLayoutPanelDairyCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelDairyCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDairyCalendar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDairyCalendar.Size = new System.Drawing.Size(984, 245);
            this.tableLayoutPanelDairyCalendar.TabIndex = 0;
            // 
            // panelPeriod
            // 
            this.panelPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(145)))));
            this.panelPeriod.Controls.Add(this.iconButtonPreviousWeek);
            this.panelPeriod.Controls.Add(this.iconButtonNextWeek);
            this.panelPeriod.Controls.Add(this.rjDatePickerEnd);
            this.panelPeriod.Controls.Add(this.rjDatePickerStart);
            this.panelPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPeriod.Location = new System.Drawing.Point(0, 0);
            this.panelPeriod.Margin = new System.Windows.Forms.Padding(0);
            this.panelPeriod.Name = "panelPeriod";
            this.panelPeriod.Size = new System.Drawing.Size(984, 35);
            this.panelPeriod.TabIndex = 1;
            // 
            // iconButtonPreviousWeek
            // 
            this.iconButtonPreviousWeek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonPreviousWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonPreviousWeek.FlatAppearance.BorderSize = 0;
            this.iconButtonPreviousWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPreviousWeek.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.iconButtonPreviousWeek.IconColor = System.Drawing.Color.White;
            this.iconButtonPreviousWeek.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPreviousWeek.IconSize = 35;
            this.iconButtonPreviousWeek.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonPreviousWeek.Location = new System.Drawing.Point(284, 0);
            this.iconButtonPreviousWeek.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconButtonPreviousWeek.Name = "iconButtonPreviousWeek";
            this.iconButtonPreviousWeek.Size = new System.Drawing.Size(35, 35);
            this.iconButtonPreviousWeek.TabIndex = 4;
            this.iconButtonPreviousWeek.UseVisualStyleBackColor = true;
            // 
            // iconButtonNextWeek
            // 
            this.iconButtonNextWeek.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonNextWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonNextWeek.FlatAppearance.BorderSize = 0;
            this.iconButtonNextWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonNextWeek.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            this.iconButtonNextWeek.IconColor = System.Drawing.Color.White;
            this.iconButtonNextWeek.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonNextWeek.IconSize = 35;
            this.iconButtonNextWeek.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButtonNextWeek.Location = new System.Drawing.Point(629, 0);
            this.iconButtonNextWeek.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.iconButtonNextWeek.Name = "iconButtonNextWeek";
            this.iconButtonNextWeek.Size = new System.Drawing.Size(35, 35);
            this.iconButtonNextWeek.TabIndex = 3;
            this.iconButtonNextWeek.UseVisualStyleBackColor = true;
            // 
            // rjDatePickerEnd
            // 
            this.rjDatePickerEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjDatePickerEnd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePickerEnd.BorderSize = 0;
            this.rjDatePickerEnd.CustomFormat = "dd.MM.yyyy";
            this.rjDatePickerEnd.Enabled = false;
            this.rjDatePickerEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjDatePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rjDatePickerEnd.Location = new System.Drawing.Point(479, 0);
            this.rjDatePickerEnd.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rjDatePickerEnd.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePickerEnd.Name = "rjDatePickerEnd";
            this.rjDatePickerEnd.Size = new System.Drawing.Size(140, 35);
            this.rjDatePickerEnd.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.rjDatePickerEnd.TabIndex = 1;
            this.rjDatePickerEnd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(111)))), ((int)(((byte)(244)))));
            // 
            // rjDatePickerStart
            // 
            this.rjDatePickerStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rjDatePickerStart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjDatePickerStart.BorderSize = 0;
            this.rjDatePickerStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rjDatePickerStart.CustomFormat = "dd.MM.yyyy";
            this.rjDatePickerStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjDatePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rjDatePickerStart.Location = new System.Drawing.Point(329, 0);
            this.rjDatePickerStart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rjDatePickerStart.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePickerStart.Name = "rjDatePickerStart";
            this.rjDatePickerStart.Size = new System.Drawing.Size(140, 35);
            this.rjDatePickerStart.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.rjDatePickerStart.TabIndex = 0;
            this.rjDatePickerStart.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(111)))), ((int)(((byte)(244)))));
            this.rjDatePickerStart.ValueChanged += new System.EventHandler(this.RjDatePickerStart_ValueChanged);
            // 
            // tableLayoutPanelWeek
            // 
            this.tableLayoutPanelWeek.ColumnCount = 7;
            this.tableLayoutPanelWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanelWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanelWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanelWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.3F));
            this.tableLayoutPanelWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.29F));
            this.tableLayoutPanelWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanelWeek.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.tableLayoutPanelWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWeek.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanelWeek.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.tableLayoutPanelWeek.Name = "tableLayoutPanelWeek";
            this.tableLayoutPanelWeek.RowCount = 2;
            this.tableLayoutPanelWeek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelWeek.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWeek.Size = new System.Drawing.Size(984, 205);
            this.tableLayoutPanelWeek.TabIndex = 3;
            // 
            // panelWork
            // 
            this.panelWork.Controls.Add(this.tableLayoutPanelHomeWork);
            this.panelWork.Controls.Add(this.panelTableTitleDay);
            this.panelWork.Controls.Add(this.panel2);
            this.panelWork.Controls.Add(this.labelTitleDay);
            this.panelWork.Controls.Add(this.panelButtonTools);
            this.panelWork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWork.Location = new System.Drawing.Point(5, 250);
            this.panelWork.Margin = new System.Windows.Forms.Padding(0);
            this.panelWork.Name = "panelWork";
            this.panelWork.Size = new System.Drawing.Size(984, 405);
            this.panelWork.TabIndex = 9;
            this.panelWork.Visible = false;
            // 
            // tableLayoutPanelHomeWork
            // 
            this.tableLayoutPanelHomeWork.AutoScroll = true;
            this.tableLayoutPanelHomeWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tableLayoutPanelHomeWork.ColumnCount = 2;
            this.tableLayoutPanelHomeWork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanelHomeWork.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHomeWork.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelHomeWork.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanelHomeWork.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelHomeWork.Location = new System.Drawing.Point(0, 145);
            this.tableLayoutPanelHomeWork.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelHomeWork.Name = "tableLayoutPanelHomeWork";
            this.tableLayoutPanelHomeWork.RowCount = 1;
            this.tableLayoutPanelHomeWork.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelHomeWork.Size = new System.Drawing.Size(984, 65);
            this.tableLayoutPanelHomeWork.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(145)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва предмету";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(145)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(205, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(779, 60);
            this.label2.TabIndex = 1;
            this.label2.Text = "Лабораторна №3. По 10 об\'єктів. Передтим як додати нову колонку в таблицю, вимкну" +
    "ти редагування";
            // 
            // panelTableTitleDay
            // 
            this.panelTableTitleDay.Controls.Add(this.label9);
            this.panelTableTitleDay.Controls.Add(this.panel1);
            this.panelTableTitleDay.Controls.Add(this.label8);
            this.panelTableTitleDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTableTitleDay.Location = new System.Drawing.Point(0, 95);
            this.panelTableTitleDay.Margin = new System.Windows.Forms.Padding(0);
            this.panelTableTitleDay.Name = "panelTableTitleDay";
            this.panelTableTitleDay.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelTableTitleDay.Size = new System.Drawing.Size(984, 50);
            this.panelTableTitleDay.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(145)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(205, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(779, 45);
            this.label9.TabIndex = 3;
            this.label9.Text = "Домашнє завдання";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 45);
            this.panel1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(145)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 45);
            this.label8.TabIndex = 0;
            this.label8.Text = "Предмет";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 5);
            this.panel2.TabIndex = 14;
            // 
            // labelTitleDay
            // 
            this.labelTitleDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(145)))));
            this.labelTitleDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTitleDay.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleDay.ForeColor = System.Drawing.Color.White;
            this.labelTitleDay.Location = new System.Drawing.Point(0, 45);
            this.labelTitleDay.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleDay.Name = "labelTitleDay";
            this.labelTitleDay.Size = new System.Drawing.Size(984, 45);
            this.labelTitleDay.TabIndex = 13;
            this.labelTitleDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButtonTools
            // 
            this.panelButtonTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelButtonTools.Controls.Add(this.panel5);
            this.panelButtonTools.Controls.Add(this.iconButton3);
            this.panelButtonTools.Controls.Add(this.panel3);
            this.panelButtonTools.Controls.Add(this.iconButton2);
            this.panelButtonTools.Controls.Add(this.panel4);
            this.panelButtonTools.Controls.Add(this.iconButton1);
            this.panelButtonTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonTools.Location = new System.Drawing.Point(0, 0);
            this.panelButtonTools.Name = "panelButtonTools";
            this.panelButtonTools.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelButtonTools.Size = new System.Drawing.Size(984, 45);
            this.panelButtonTools.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(380, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 40);
            this.panel5.TabIndex = 5;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Red;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 40;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(250, 0);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(130, 40);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Не виконано";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(245, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 40);
            this.panel3.TabIndex = 3;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Yellow;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(120, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(125, 40);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Не закінчено";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(115, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 40);
            this.panel4.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Green;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CheckSquare;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 40;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(115, 40);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Виконано";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // FormStudentDairy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(994, 660);
            this.Controls.Add(this.panelWork);
            this.Controls.Add(this.tableLayoutPanelDairyCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStudentDairy";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Щоденник";
            this.tableLayoutPanelDairyCalendar.ResumeLayout(false);
            this.panelPeriod.ResumeLayout(false);
            this.panelWork.ResumeLayout(false);
            this.tableLayoutPanelHomeWork.ResumeLayout(false);
            this.panelTableTitleDay.ResumeLayout(false);
            this.panelButtonTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDairyCalendar;
        private System.Windows.Forms.Panel panelPeriod;
        private FontAwesome.Sharp.IconButton iconButtonPreviousWeek;
        private FontAwesome.Sharp.IconButton iconButtonNextWeek;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePickerEnd;
        private RJCodeAdvance.RJControls.RJDatePicker rjDatePickerStart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWeek;
        private System.Windows.Forms.Panel panelWork;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHomeWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTableTitleDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTitleDay;
        private System.Windows.Forms.Panel panelButtonTools;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}