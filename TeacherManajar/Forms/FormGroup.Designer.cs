
namespace TeacherManajar.Forms
{
    partial class FormGroup
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
            this.tableLayoutPanelGroups = new System.Windows.Forms.TableLayoutPanel();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.labelNoGroups = new System.Windows.Forms.Label();
            this.iconPictureBoxNoGroups = new FontAwesome.Sharp.IconPictureBox();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxNoGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelGroups
            // 
            this.tableLayoutPanelGroups.ColumnCount = 3;
            this.tableLayoutPanelGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanelGroups.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelGroups.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanelGroups.Name = "tableLayoutPanelGroups";
            this.tableLayoutPanelGroups.RowCount = 1;
            this.tableLayoutPanelGroups.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanelGroups.Size = new System.Drawing.Size(991, 5);
            this.tableLayoutPanelGroups.TabIndex = 4;
            // 
            // panelBackground
            // 
            this.panelBackground.Controls.Add(this.labelNoGroups);
            this.panelBackground.Controls.Add(this.iconPictureBoxNoGroups);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(5, 10);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(991, 651);
            this.panelBackground.TabIndex = 5;
            // 
            // labelNoGroups
            // 
            this.labelNoGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNoGroups.AutoSize = true;
            this.labelNoGroups.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoGroups.ForeColor = System.Drawing.Color.DimGray;
            this.labelNoGroups.Location = new System.Drawing.Point(377, 375);
            this.labelNoGroups.Name = "labelNoGroups";
            this.labelNoGroups.Size = new System.Drawing.Size(247, 40);
            this.labelNoGroups.TabIndex = 1;
            this.labelNoGroups.Text = "Групи відсутні";
            // 
            // iconPictureBoxNoGroups
            // 
            this.iconPictureBoxNoGroups.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBoxNoGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBoxNoGroups.ForeColor = System.Drawing.Color.DimGray;
            this.iconPictureBoxNoGroups.IconChar = FontAwesome.Sharp.IconChar.UsersSlash;
            this.iconPictureBoxNoGroups.IconColor = System.Drawing.Color.DimGray;
            this.iconPictureBoxNoGroups.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxNoGroups.IconSize = 225;
            this.iconPictureBoxNoGroups.Location = new System.Drawing.Point(383, 147);
            this.iconPictureBoxNoGroups.Name = "iconPictureBoxNoGroups";
            this.iconPictureBoxNoGroups.Size = new System.Drawing.Size(235, 225);
            this.iconPictureBoxNoGroups.TabIndex = 0;
            this.iconPictureBoxNoGroups.TabStop = false;
            this.iconPictureBoxNoGroups.UseGdi = true;
            // 
            // FormGroup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(996, 661);
            this.ControlBox = false;
            this.Controls.Add(this.panelBackground);
            this.Controls.Add(this.tableLayoutPanelGroups);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGroup";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.ShowIcon = false;
            this.Text = "Журнали";
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxNoGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGroups;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelNoGroups;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxNoGroups;
    }
}