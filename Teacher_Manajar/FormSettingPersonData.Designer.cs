
namespace Teacher_Manajar
{
    partial class FormSettingPersonData
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
            this.panel_moveShape = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCustom_minimize = new Custom.ButtonCustom();
            this.buttonCustom_Exit = new Custom.ButtonCustom();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel_SystemBackgroundColor = new System.Windows.Forms.Panel();
            this.panel_SystemFrontColor = new System.Windows.Forms.Panel();
            this.panel40 = new System.Windows.Forms.Panel();
            this.label_warningOldPassword = new System.Windows.Forms.Label();
            this.panel32 = new System.Windows.Forms.Panel();
            this.myTextBox_NewPassword = new Custom.MyTextBox();
            this.panel34 = new System.Windows.Forms.Panel();
            this.label_warningRepeatNewPassword = new System.Windows.Forms.Label();
            this.panel41 = new System.Windows.Forms.Panel();
            this.myTextBox_RepeatNewPassword = new Custom.MyTextBox();
            this.panel39 = new System.Windows.Forms.Panel();
            this.myTextBox_OldPassword = new Custom.MyTextBox();
            this.panel31 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCustom_SaveLogin = new Custom.ButtonCustom();
            this.panel30 = new System.Windows.Forms.Panel();
            this.myTextBox_Login = new Custom.MyTextBox();
            this.panel29 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel37 = new System.Windows.Forms.Panel();
            this.buttonCustom_SavePassword = new Custom.ButtonCustom();
            this.panel_moveShape.SuspendLayout();
            this.panel_SystemBackgroundColor.SuspendLayout();
            this.panel_SystemFrontColor.SuspendLayout();
            this.panel40.SuspendLayout();
            this.panel32.SuspendLayout();
            this.panel34.SuspendLayout();
            this.panel41.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel30.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel37.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_moveShape
            // 
            this.panel_moveShape.BackColor = System.Drawing.Color.White;
            this.panel_moveShape.Controls.Add(this.label3);
            this.panel_moveShape.Controls.Add(this.buttonCustom_minimize);
            this.panel_moveShape.Controls.Add(this.buttonCustom_Exit);
            this.panel_moveShape.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_moveShape.Location = new System.Drawing.Point(0, 0);
            this.panel_moveShape.Name = "panel_moveShape";
            this.panel_moveShape.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_moveShape.Size = new System.Drawing.Size(335, 30);
            this.panel_moveShape.TabIndex = 6;
            this.panel_moveShape.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_moveShape_MouseDown);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "Налаштування";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.buttonCustom_minimize.Location = new System.Drawing.Point(225, 0);
            this.buttonCustom_minimize.Name = "buttonCustom_minimize";
            this.buttonCustom_minimize.Size = new System.Drawing.Size(55, 30);
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
            this.buttonCustom_Exit.Location = new System.Drawing.Point(280, 0);
            this.buttonCustom_Exit.Name = "buttonCustom_Exit";
            this.buttonCustom_Exit.Size = new System.Drawing.Size(55, 30);
            this.buttonCustom_Exit.TabIndex = 0;
            this.buttonCustom_Exit.Text = "X";
            this.buttonCustom_Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCustom_Exit.TextColor = System.Drawing.Color.White;
            this.buttonCustom_Exit.UseVisualStyleBackColor = false;
            this.buttonCustom_Exit.Click += new System.EventHandler(this.ButtonCustom_Exit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel_SystemBackgroundColor
            // 
            this.panel_SystemBackgroundColor.BackColor = System.Drawing.Color.White;
            this.panel_SystemBackgroundColor.Controls.Add(this.panel_SystemFrontColor);
            this.panel_SystemBackgroundColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SystemBackgroundColor.Location = new System.Drawing.Point(0, 30);
            this.panel_SystemBackgroundColor.Name = "panel_SystemBackgroundColor";
            this.panel_SystemBackgroundColor.Padding = new System.Windows.Forms.Padding(5);
            this.panel_SystemBackgroundColor.Size = new System.Drawing.Size(335, 440);
            this.panel_SystemBackgroundColor.TabIndex = 10;
            // 
            // panel_SystemFrontColor
            // 
            this.panel_SystemFrontColor.BackColor = System.Drawing.Color.White;
            this.panel_SystemFrontColor.Controls.Add(this.panel40);
            this.panel_SystemFrontColor.Controls.Add(this.panel32);
            this.panel_SystemFrontColor.Controls.Add(this.panel34);
            this.panel_SystemFrontColor.Controls.Add(this.panel41);
            this.panel_SystemFrontColor.Controls.Add(this.panel39);
            this.panel_SystemFrontColor.Controls.Add(this.panel31);
            this.panel_SystemFrontColor.Controls.Add(this.panel2);
            this.panel_SystemFrontColor.Controls.Add(this.panel30);
            this.panel_SystemFrontColor.Controls.Add(this.panel29);
            this.panel_SystemFrontColor.Controls.Add(this.panel37);
            this.panel_SystemFrontColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SystemFrontColor.Location = new System.Drawing.Point(5, 5);
            this.panel_SystemFrontColor.Name = "panel_SystemFrontColor";
            this.panel_SystemFrontColor.Size = new System.Drawing.Size(325, 430);
            this.panel_SystemFrontColor.TabIndex = 25;
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.label_warningOldPassword);
            this.panel40.Enabled = false;
            this.panel40.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel40.ForeColor = System.Drawing.Color.Red;
            this.panel40.Location = new System.Drawing.Point(0, 229);
            this.panel40.Name = "panel40";
            this.panel40.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel40.Size = new System.Drawing.Size(326, 30);
            this.panel40.TabIndex = 23;
            // 
            // label_warningOldPassword
            // 
            this.label_warningOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_warningOldPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_warningOldPassword.ForeColor = System.Drawing.Color.Red;
            this.label_warningOldPassword.Location = new System.Drawing.Point(20, 0);
            this.label_warningOldPassword.Name = "label_warningOldPassword";
            this.label_warningOldPassword.Size = new System.Drawing.Size(306, 30);
            this.label_warningOldPassword.TabIndex = 0;
            this.label_warningOldPassword.Text = "Введений вами пароль не співпадає з існуючим";
            this.label_warningOldPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_warningOldPassword.Visible = false;
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.myTextBox_NewPassword);
            this.panel32.Location = new System.Drawing.Point(0, 262);
            this.panel32.Name = "panel32";
            this.panel32.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.panel32.Size = new System.Drawing.Size(326, 40);
            this.panel32.TabIndex = 32;
            // 
            // myTextBox_NewPassword
            // 
            this.myTextBox_NewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.myTextBox_NewPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.myTextBox_NewPassword.BorderFocusColor = System.Drawing.Color.Green;
            this.myTextBox_NewPassword.BorderRadius = 12;
            this.myTextBox_NewPassword.BorderSize = 2;
            this.myTextBox_NewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTextBox_NewPassword.Enabled = false;
            this.myTextBox_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myTextBox_NewPassword.ForeColor = System.Drawing.Color.DimGray;
            this.myTextBox_NewPassword.Location = new System.Drawing.Point(15, 5);
            this.myTextBox_NewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.myTextBox_NewPassword.Multiline = false;
            this.myTextBox_NewPassword.Name = "myTextBox_NewPassword";
            this.myTextBox_NewPassword.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.myTextBox_NewPassword.PasswordChar = true;
            this.myTextBox_NewPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.myTextBox_NewPassword.PlaceholderText = "Введить новий пароль";
            this.myTextBox_NewPassword.Size = new System.Drawing.Size(296, 27);
            this.myTextBox_NewPassword.TabIndex = 1;
            this.myTextBox_NewPassword.Texts = "";
            this.myTextBox_NewPassword.UnderlinedStyle = false;
            this.myTextBox_NewPassword._TextChanger += new System.EventHandler(this.MyTextBox_NewPassword__TextChanger);
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.label_warningRepeatNewPassword);
            this.panel34.Enabled = false;
            this.panel34.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel34.ForeColor = System.Drawing.Color.Red;
            this.panel34.Location = new System.Drawing.Point(0, 340);
            this.panel34.Name = "panel34";
            this.panel34.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel34.Size = new System.Drawing.Size(326, 30);
            this.panel34.TabIndex = 26;
            // 
            // label_warningRepeatNewPassword
            // 
            this.label_warningRepeatNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_warningRepeatNewPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_warningRepeatNewPassword.ForeColor = System.Drawing.Color.Red;
            this.label_warningRepeatNewPassword.Location = new System.Drawing.Point(20, 0);
            this.label_warningRepeatNewPassword.Name = "label_warningRepeatNewPassword";
            this.label_warningRepeatNewPassword.Size = new System.Drawing.Size(306, 30);
            this.label_warningRepeatNewPassword.TabIndex = 34;
            this.label_warningRepeatNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_warningRepeatNewPassword.Visible = false;
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.myTextBox_RepeatNewPassword);
            this.panel41.Location = new System.Drawing.Point(0, 301);
            this.panel41.Name = "panel41";
            this.panel41.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.panel41.Size = new System.Drawing.Size(326, 40);
            this.panel41.TabIndex = 33;
            // 
            // myTextBox_RepeatNewPassword
            // 
            this.myTextBox_RepeatNewPassword.BackColor = System.Drawing.SystemColors.Window;
            this.myTextBox_RepeatNewPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.myTextBox_RepeatNewPassword.BorderFocusColor = System.Drawing.Color.Green;
            this.myTextBox_RepeatNewPassword.BorderRadius = 12;
            this.myTextBox_RepeatNewPassword.BorderSize = 2;
            this.myTextBox_RepeatNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTextBox_RepeatNewPassword.Enabled = false;
            this.myTextBox_RepeatNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myTextBox_RepeatNewPassword.ForeColor = System.Drawing.Color.DimGray;
            this.myTextBox_RepeatNewPassword.Location = new System.Drawing.Point(15, 5);
            this.myTextBox_RepeatNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.myTextBox_RepeatNewPassword.Multiline = false;
            this.myTextBox_RepeatNewPassword.Name = "myTextBox_RepeatNewPassword";
            this.myTextBox_RepeatNewPassword.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.myTextBox_RepeatNewPassword.PasswordChar = true;
            this.myTextBox_RepeatNewPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.myTextBox_RepeatNewPassword.PlaceholderText = "Повторить новий пароль іще раз";
            this.myTextBox_RepeatNewPassword.Size = new System.Drawing.Size(296, 27);
            this.myTextBox_RepeatNewPassword.TabIndex = 1;
            this.myTextBox_RepeatNewPassword.Texts = "";
            this.myTextBox_RepeatNewPassword.UnderlinedStyle = false;
            this.myTextBox_RepeatNewPassword._TextChanger += new System.EventHandler(this.MyTextBox_RepeatNewPassword__TextChanger);
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.myTextBox_OldPassword);
            this.panel39.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel39.Location = new System.Drawing.Point(0, 190);
            this.panel39.Name = "panel39";
            this.panel39.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.panel39.Size = new System.Drawing.Size(325, 40);
            this.panel39.TabIndex = 31;
            // 
            // myTextBox_OldPassword
            // 
            this.myTextBox_OldPassword.BackColor = System.Drawing.SystemColors.Window;
            this.myTextBox_OldPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.myTextBox_OldPassword.BorderFocusColor = System.Drawing.Color.Green;
            this.myTextBox_OldPassword.BorderRadius = 12;
            this.myTextBox_OldPassword.BorderSize = 2;
            this.myTextBox_OldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTextBox_OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myTextBox_OldPassword.ForeColor = System.Drawing.Color.DimGray;
            this.myTextBox_OldPassword.Location = new System.Drawing.Point(15, 5);
            this.myTextBox_OldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.myTextBox_OldPassword.Multiline = false;
            this.myTextBox_OldPassword.Name = "myTextBox_OldPassword";
            this.myTextBox_OldPassword.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.myTextBox_OldPassword.PasswordChar = true;
            this.myTextBox_OldPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.myTextBox_OldPassword.PlaceholderText = "Введить старий пароль";
            this.myTextBox_OldPassword.Size = new System.Drawing.Size(295, 27);
            this.myTextBox_OldPassword.TabIndex = 0;
            this.myTextBox_OldPassword.Texts = "";
            this.myTextBox_OldPassword.UnderlinedStyle = false;
            this.myTextBox_OldPassword._TextChanger += new System.EventHandler(this.MyTextBox_OldPassword__TextChanger);
            // 
            // panel31
            // 
            this.panel31.Controls.Add(this.label16);
            this.panel31.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel31.Location = new System.Drawing.Point(0, 135);
            this.panel31.Name = "panel31";
            this.panel31.Padding = new System.Windows.Forms.Padding(0, 20, 0, 5);
            this.panel31.Size = new System.Drawing.Size(325, 55);
            this.panel31.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(0, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(325, 30);
            this.label16.TabIndex = 1;
            this.label16.Text = "Змінити пароль";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCustom_SaveLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(68, 5, 68, 5);
            this.panel2.Size = new System.Drawing.Size(325, 60);
            this.panel2.TabIndex = 30;
            // 
            // buttonCustom_SaveLogin
            // 
            this.buttonCustom_SaveLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_SaveLogin.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_SaveLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_SaveLogin.BorderRadius = 40;
            this.buttonCustom_SaveLogin.BorderSize = 0;
            this.buttonCustom_SaveLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_SaveLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCustom_SaveLogin.Enabled = false;
            this.buttonCustom_SaveLogin.FlatAppearance.BorderSize = 0;
            this.buttonCustom_SaveLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_SaveLogin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonCustom_SaveLogin.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_SaveLogin.Location = new System.Drawing.Point(68, 5);
            this.buttonCustom_SaveLogin.Name = "buttonCustom_SaveLogin";
            this.buttonCustom_SaveLogin.Size = new System.Drawing.Size(189, 50);
            this.buttonCustom_SaveLogin.TabIndex = 1;
            this.buttonCustom_SaveLogin.Text = "Зберегти логін";
            this.buttonCustom_SaveLogin.TextColor = System.Drawing.Color.White;
            this.buttonCustom_SaveLogin.UseVisualStyleBackColor = false;
            this.buttonCustom_SaveLogin.Click += new System.EventHandler(this.ButtonCustom_SaveLogin_Click);
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.myTextBox_Login);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel30.Location = new System.Drawing.Point(0, 35);
            this.panel30.Name = "panel30";
            this.panel30.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.panel30.Size = new System.Drawing.Size(325, 40);
            this.panel30.TabIndex = 27;
            // 
            // myTextBox_Login
            // 
            this.myTextBox_Login.BackColor = System.Drawing.SystemColors.Window;
            this.myTextBox_Login.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.myTextBox_Login.BorderFocusColor = System.Drawing.Color.Green;
            this.myTextBox_Login.BorderRadius = 12;
            this.myTextBox_Login.BorderSize = 2;
            this.myTextBox_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTextBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myTextBox_Login.ForeColor = System.Drawing.Color.DimGray;
            this.myTextBox_Login.Location = new System.Drawing.Point(15, 5);
            this.myTextBox_Login.Margin = new System.Windows.Forms.Padding(4);
            this.myTextBox_Login.Multiline = false;
            this.myTextBox_Login.Name = "myTextBox_Login";
            this.myTextBox_Login.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.myTextBox_Login.PasswordChar = false;
            this.myTextBox_Login.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.myTextBox_Login.PlaceholderText = "Введить новий логін";
            this.myTextBox_Login.Size = new System.Drawing.Size(295, 27);
            this.myTextBox_Login.TabIndex = 0;
            this.myTextBox_Login.Texts = "";
            this.myTextBox_Login.UnderlinedStyle = false;
            this.myTextBox_Login._TextChanger += new System.EventHandler(this.MyTextBox_Login__TextChanger);
            // 
            // panel29
            // 
            this.panel29.Controls.Add(this.label14);
            this.panel29.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel29.Location = new System.Drawing.Point(0, 0);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(325, 35);
            this.panel29.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(325, 35);
            this.label14.TabIndex = 1;
            this.label14.Text = "Змінити логін";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.buttonCustom_SavePassword);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel37.Location = new System.Drawing.Point(0, 370);
            this.panel37.Name = "panel37";
            this.panel37.Padding = new System.Windows.Forms.Padding(68, 5, 68, 5);
            this.panel37.Size = new System.Drawing.Size(325, 60);
            this.panel37.TabIndex = 28;
            // 
            // buttonCustom_SavePassword
            // 
            this.buttonCustom_SavePassword.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_SavePassword.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonCustom_SavePassword.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonCustom_SavePassword.BorderRadius = 40;
            this.buttonCustom_SavePassword.BorderSize = 0;
            this.buttonCustom_SavePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCustom_SavePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCustom_SavePassword.Enabled = false;
            this.buttonCustom_SavePassword.FlatAppearance.BorderSize = 0;
            this.buttonCustom_SavePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustom_SavePassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonCustom_SavePassword.ForeColor = System.Drawing.Color.White;
            this.buttonCustom_SavePassword.Location = new System.Drawing.Point(68, 5);
            this.buttonCustom_SavePassword.Name = "buttonCustom_SavePassword";
            this.buttonCustom_SavePassword.Size = new System.Drawing.Size(189, 50);
            this.buttonCustom_SavePassword.TabIndex = 1;
            this.buttonCustom_SavePassword.Text = "Зберегти пароль";
            this.buttonCustom_SavePassword.TextColor = System.Drawing.Color.White;
            this.buttonCustom_SavePassword.UseVisualStyleBackColor = false;
            this.buttonCustom_SavePassword.Click += new System.EventHandler(this.ButtonCustom_SavePassword_Click);
            // 
            // FormSettingPersonData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 470);
            this.ControlBox = false;
            this.Controls.Add(this.panel_SystemBackgroundColor);
            this.Controls.Add(this.panel_moveShape);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1310, 1640);
            this.Name = "FormSettingPersonData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_moveShape.ResumeLayout(false);
            this.panel_SystemBackgroundColor.ResumeLayout(false);
            this.panel_SystemFrontColor.ResumeLayout(false);
            this.panel40.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.panel41.ResumeLayout(false);
            this.panel39.ResumeLayout(false);
            this.panel31.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.panel29.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_moveShape;
        private System.Windows.Forms.Label label3;
        private Custom.ButtonCustom buttonCustom_minimize;
        private Custom.ButtonCustom buttonCustom_Exit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel_SystemBackgroundColor;
        private Custom.MyTextBox myTextBox_RepeatNewPassword;
        private Custom.MyTextBox myTextBox_NewPassword;
        private Custom.MyTextBox myTextBox_OldPassword;
        private System.Windows.Forms.Panel panel_SystemFrontColor;
        private Custom.MyTextBox myTextBox_Login;
        private System.Windows.Forms.Panel panel37;
        private Custom.ButtonCustom buttonCustom_SavePassword;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Panel panel41;
        private System.Windows.Forms.Panel panel32;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private Custom.ButtonCustom buttonCustom_SaveLogin;
        private System.Windows.Forms.Panel panel30;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Label label_warningOldPassword;
        private System.Windows.Forms.Label label_warningRepeatNewPassword;
    }
}