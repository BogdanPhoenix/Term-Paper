
namespace Teacher_Manajar
{
    partial class FormCalendarPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_moveShape = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.ButtonCustom_minimize = new Custom.ButtonCustom();
            this.ButtonCustom_Exit = new Custom.ButtonCustom();
            this.panel_Background = new System.Windows.Forms.Panel();
            this.panel_FrontColor = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Record = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_MagazineNameTitle = new System.Windows.Forms.Label();
            this.Panel_moveShape.SuspendLayout();
            this.panel_Background.SuspendLayout();
            this.panel_FrontColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.Panel_moveShape.Size = new System.Drawing.Size(945, 30);
            this.Panel_moveShape.TabIndex = 7;
            this.Panel_moveShape.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_moveShape_MouseDown);
            // 
            // label_Title
            // 
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Title.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_Title.Location = new System.Drawing.Point(20, 0);
            this.label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(214, 30);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "Календарний план";
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
            this.ButtonCustom_minimize.Location = new System.Drawing.Point(835, 0);
            this.ButtonCustom_minimize.Margin = new System.Windows.Forms.Padding(4);
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
            this.ButtonCustom_Exit.Location = new System.Drawing.Point(890, 0);
            this.ButtonCustom_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCustom_Exit.Name = "ButtonCustom_Exit";
            this.ButtonCustom_Exit.Size = new System.Drawing.Size(55, 30);
            this.ButtonCustom_Exit.TabIndex = 0;
            this.ButtonCustom_Exit.Text = "X";
            this.ButtonCustom_Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonCustom_Exit.TextColor = System.Drawing.Color.White;
            this.ButtonCustom_Exit.UseVisualStyleBackColor = false;
            this.ButtonCustom_Exit.Click += new System.EventHandler(this.ButtonCustom_Exit_Click);
            // 
            // panel_Background
            // 
            this.panel_Background.Controls.Add(this.panel_FrontColor);
            this.panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Background.Location = new System.Drawing.Point(0, 30);
            this.panel_Background.Name = "panel_Background";
            this.panel_Background.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Background.Size = new System.Drawing.Size(945, 630);
            this.panel_Background.TabIndex = 13;
            // 
            // panel_FrontColor
            // 
            this.panel_FrontColor.Controls.Add(this.dataGridView1);
            this.panel_FrontColor.Controls.Add(this.panel4);
            this.panel_FrontColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FrontColor.Location = new System.Drawing.Point(5, 5);
            this.panel_FrontColor.Name = "panel_FrontColor";
            this.panel_FrontColor.Size = new System.Drawing.Size(935, 620);
            this.panel_FrontColor.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Date,
            this.Record});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(935, 583);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Number.DefaultCellStyle = dataGridViewCellStyle1;
            this.Number.Frozen = true;
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Number.ToolTipText = "Номер заняття";
            this.Number.Width = 49;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Date.Frozen = true;
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 100;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Date.ToolTipText = "Дата проведення заняття";
            // 
            // Record
            // 
            this.Record.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.NullValue = null;
            this.Record.DefaultCellStyle = dataGridViewCellStyle3;
            this.Record.HeaderText = "Запис";
            this.Record.MinimumWidth = 100;
            this.Record.Name = "Record";
            this.Record.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Record.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Record.ToolTipText = "Запис того, що було розглянуто на занятті";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_MagazineNameTitle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.panel4.Size = new System.Drawing.Size(935, 37);
            this.panel4.TabIndex = 14;
            // 
            // label_MagazineNameTitle
            // 
            this.label_MagazineNameTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_MagazineNameTitle.Location = new System.Drawing.Point(30, 0);
            this.label_MagazineNameTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MagazineNameTitle.Name = "label_MagazineNameTitle";
            this.label_MagazineNameTitle.Size = new System.Drawing.Size(875, 37);
            this.label_MagazineNameTitle.TabIndex = 0;
            this.label_MagazineNameTitle.Text = "Журнал: ";
            this.label_MagazineNameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calendar_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 660);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Background);
            this.Controls.Add(this.Panel_moveShape);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(945, 660);
            this.MinimumSize = new System.Drawing.Size(945, 660);
            this.Name = "Calendar_Plan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Panel_moveShape.ResumeLayout(false);
            this.panel_Background.ResumeLayout(false);
            this.panel_FrontColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_moveShape;
        private System.Windows.Forms.Label label_Title;
        private Custom.ButtonCustom ButtonCustom_minimize;
        private Custom.ButtonCustom ButtonCustom_Exit;
        private System.Windows.Forms.Panel panel_Background;
        private System.Windows.Forms.Panel panel_FrontColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Record;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_MagazineNameTitle;
    }
}