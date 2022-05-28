
namespace Teacher_Manajar
{
    partial class FormChooseData
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCustom_Close = new Custom.ButtonCustom();
            this.buttonCustom_Next = new Custom.ButtonCustom();
            this.panel3 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel_Background.SuspendLayout();
            this.panel_FrontColor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Background
            // 
            this.panel_Background.Controls.Add(this.panel_FrontColor);
            this.panel_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Background.Location = new System.Drawing.Point(0, 0);
            this.panel_Background.Name = "panel_Background";
            this.panel_Background.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Background.Size = new System.Drawing.Size(313, 315);
            this.panel_Background.TabIndex = 4;
            // 
            // panel_FrontColor
            // 
            this.panel_FrontColor.Controls.Add(this.panel3);
            this.panel_FrontColor.Controls.Add(this.panel2);
            this.panel_FrontColor.Controls.Add(this.panel1);
            this.panel_FrontColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FrontColor.Location = new System.Drawing.Point(5, 5);
            this.panel_FrontColor.Name = "panel_FrontColor";
            this.panel_FrontColor.Size = new System.Drawing.Size(303, 305);
            this.panel_FrontColor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 57);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виберіть дату";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCustom_Close);
            this.panel2.Controls.Add(this.buttonCustom_Next);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 230);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(25, 15, 25, 15);
            this.panel2.Size = new System.Drawing.Size(303, 75);
            this.panel2.TabIndex = 4;
            // 
            // buttonCustom_Close
            // 
            this.buttonCustom_Close.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_Close.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_Close.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_Close.BorderRadius = 40;
            this.buttonCustom_Close.BorderSize = 0;
            this.buttonCustom_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_Close.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCustom_Close.FlatAppearance.BorderSize = 0;
            this.buttonCustom_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_Close.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_Close.Location = new System.Drawing.Point(25, 15);
            this.buttonCustom_Close.Name = "buttonCustom_Close";
            this.buttonCustom_Close.Size = new System.Drawing.Size(100, 45);
            this.buttonCustom_Close.TabIndex = 2;
            this.buttonCustom_Close.Text = "Отмена";
            this.buttonCustom_Close.TextColor = System.Drawing.Color.White;
            this.buttonCustom_Close.UseVisualStyleBackColor = false;
            this.buttonCustom_Close.Click += new System.EventHandler(this.ButtonCustom_Close_Click);
            // 
            // buttonCustom_Next
            // 
            this.buttonCustom_Next.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_Next.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_Next.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_Next.BorderRadius = 40;
            this.buttonCustom_Next.BorderSize = 0;
            this.buttonCustom_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_Next.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCustom_Next.FlatAppearance.BorderSize = 0;
            this.buttonCustom_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_Next.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_Next.Location = new System.Drawing.Point(178, 15);
            this.buttonCustom_Next.Name = "buttonCustom_Next";
            this.buttonCustom_Next.Size = new System.Drawing.Size(100, 45);
            this.buttonCustom_Next.TabIndex = 1;
            this.buttonCustom_Next.Text = "Далі";
            this.buttonCustom_Next.TextColor = System.Drawing.Color.White;
            this.buttonCustom_Next.UseVisualStyleBackColor = false;
            this.buttonCustom_Next.Click += new System.EventHandler(this.ButtonCustom_Next_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.monthCalendar1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(303, 173);
            this.panel3.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(72, 9);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // Choose_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 309);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(313, 315);
            this.MinimumSize = new System.Drawing.Size(313, 315);
            this.Name = "Choose_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_Background.ResumeLayout(false);
            this.panel_FrontColor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Background;
        private System.Windows.Forms.Panel panel_FrontColor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel2;
        private Custom.ButtonCustom buttonCustom_Close;
        private Custom.ButtonCustom buttonCustom_Next;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}