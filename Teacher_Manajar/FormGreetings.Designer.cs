
namespace Teacher_Manajar
{
    partial class Form_Greetings
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCustom_Login = new Custom.ButtonCustom();
            this.buttonCustom_Registration = new Custom.ButtonCustom();
            this.panel13 = new System.Windows.Forms.Panel();
            this.buttonCustom_minimize = new Custom.ButtonCustom();
            this.buttonCustom_Exit = new Custom.ButtonCustom();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel13);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 550);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCustom_Login);
            this.panel3.Controls.Add(this.buttonCustom_Registration);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(0, 470);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(500, 80);
            this.panel3.TabIndex = 1;
            // 
            // buttonCustom_Login
            // 
            this.buttonCustom_Login.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_Login.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_Login.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_Login.BorderRadius = 40;
            this.buttonCustom_Login.BorderSize = 0;
            this.buttonCustom_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_Login.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCustom_Login.FlatAppearance.BorderSize = 0;
            this.buttonCustom_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_Login.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_Login.Location = new System.Drawing.Point(335, 15);
            this.buttonCustom_Login.Name = "buttonCustom_Login";
            this.buttonCustom_Login.Size = new System.Drawing.Size(150, 50);
            this.buttonCustom_Login.TabIndex = 1;
            this.buttonCustom_Login.Text = "Вхід";
            this.buttonCustom_Login.TextColor = System.Drawing.Color.White;
            this.buttonCustom_Login.UseVisualStyleBackColor = false;
            this.buttonCustom_Login.Click += new System.EventHandler(this.ButtonCustom_Login_Click);
            // 
            // buttonCustom_Registration
            // 
            this.buttonCustom_Registration.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_Registration.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_Registration.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_Registration.BorderRadius = 40;
            this.buttonCustom_Registration.BorderSize = 0;
            this.buttonCustom_Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_Registration.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCustom_Registration.FlatAppearance.BorderSize = 0;
            this.buttonCustom_Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_Registration.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_Registration.Location = new System.Drawing.Point(15, 15);
            this.buttonCustom_Registration.Name = "buttonCustom_Registration";
            this.buttonCustom_Registration.Size = new System.Drawing.Size(185, 50);
            this.buttonCustom_Registration.TabIndex = 0;
            this.buttonCustom_Registration.Text = "Реєстрація";
            this.buttonCustom_Registration.TextColor = System.Drawing.Color.White;
            this.buttonCustom_Registration.UseVisualStyleBackColor = false;
            this.buttonCustom_Registration.Click += new System.EventHandler(this.ButtonCustom_Registration_Click);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.buttonCustom_minimize);
            this.panel13.Controls.Add(this.buttonCustom_Exit);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel13.Size = new System.Drawing.Size(500, 32);
            this.panel13.TabIndex = 4;
            this.panel13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_moveShape_MouseDown);
            // 
            // buttonCustom_minimize
            // 
            this.buttonCustom_minimize.BackColor = System.Drawing.Color.Blue;
            this.buttonCustom_minimize.BackgroundColor = System.Drawing.Color.Blue;
            this.buttonCustom_minimize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_minimize.BorderRadius = 0;
            this.buttonCustom_minimize.BorderSize = 0;
            this.buttonCustom_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCustom_minimize.FlatAppearance.BorderSize = 0;
            this.buttonCustom_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_minimize.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCustom_minimize.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_minimize.Location = new System.Drawing.Point(390, 0);
            this.buttonCustom_minimize.Name = "buttonCustom_minimize";
            this.buttonCustom_minimize.Size = new System.Drawing.Size(55, 32);
            this.buttonCustom_minimize.TabIndex = 1;
            this.buttonCustom_minimize.Text = "-";
            this.buttonCustom_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCustom_minimize.TextColor = System.Drawing.Color.White;
            this.buttonCustom_minimize.UseVisualStyleBackColor = false;
            this.buttonCustom_minimize.Click += new System.EventHandler(this.ButtonCustom_minimize_Click);
            // 
            // buttonCustom_Exit
            // 
            this.buttonCustom_Exit.BackColor = System.Drawing.Color.Red;
            this.buttonCustom_Exit.BackgroundColor = System.Drawing.Color.Red;
            this.buttonCustom_Exit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_Exit.BorderRadius = 0;
            this.buttonCustom_Exit.BorderSize = 0;
            this.buttonCustom_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCustom_Exit.FlatAppearance.BorderSize = 0;
            this.buttonCustom_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_Exit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCustom_Exit.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_Exit.Location = new System.Drawing.Point(445, 0);
            this.buttonCustom_Exit.Name = "buttonCustom_Exit";
            this.buttonCustom_Exit.Size = new System.Drawing.Size(55, 32);
            this.buttonCustom_Exit.TabIndex = 0;
            this.buttonCustom_Exit.Text = "X";
            this.buttonCustom_Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCustom_Exit.TextColor = System.Drawing.Color.White;
            this.buttonCustom_Exit.UseVisualStyleBackColor = false;
            this.buttonCustom_Exit.Click += new System.EventHandler(this.ButtonCustom_Exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 42F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ласкаво просимо";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 132);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.panel4.Size = new System.Drawing.Size(500, 332);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Greetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 550);
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "Form_Greetings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Custom.ButtonCustom buttonCustom_Login;
        private Custom.ButtonCustom buttonCustom_Registration;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel13;
        private Custom.ButtonCustom buttonCustom_minimize;
        private Custom.ButtonCustom buttonCustom_Exit;
    }
}

