
namespace TeacherManajar.Forms.Manajar
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
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendarPlan));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.panelMoveShape = new System.Windows.Forms.Panel();
            this.labelAutoSave = new System.Windows.Forms.Label();
            this.bunifuIconButtonBack = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTable = new System.Windows.Forms.Panel();
            this.bunifuDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.IdCalendarPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalendarText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuVScrollBar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.bunifuIconButtonSave = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panelMoveShape.SuspendLayout();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMoveShape
            // 
            this.panelMoveShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelMoveShape.Controls.Add(this.labelAutoSave);
            this.panelMoveShape.Controls.Add(this.bunifuIconButtonBack);
            this.panelMoveShape.Location = new System.Drawing.Point(5, 5);
            this.panelMoveShape.Margin = new System.Windows.Forms.Padding(0);
            this.panelMoveShape.Name = "panelMoveShape";
            this.panelMoveShape.Size = new System.Drawing.Size(795, 50);
            this.panelMoveShape.TabIndex = 0;
            this.bunifuToolTip.SetToolTip(this.panelMoveShape, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelMoveShape, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelMoveShape, "");
            this.panelMoveShape.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMoveShape_MouseDown);
            // 
            // labelAutoSave
            // 
            this.labelAutoSave.AutoSize = true;
            this.labelAutoSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAutoSave.Location = new System.Drawing.Point(241, 19);
            this.labelAutoSave.Name = "labelAutoSave";
            this.labelAutoSave.Size = new System.Drawing.Size(224, 21);
            this.labelAutoSave.TabIndex = 9;
            this.labelAutoSave.Text = "Автоматичне збереження: ";
            this.bunifuToolTip.SetToolTip(this.labelAutoSave, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelAutoSave, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelAutoSave, "");
            // 
            // bunifuIconButtonBack
            // 
            this.bunifuIconButtonBack.AllowAnimations = true;
            this.bunifuIconButtonBack.AllowBorderColorChanges = true;
            this.bunifuIconButtonBack.AllowMouseEffects = true;
            this.bunifuIconButtonBack.AnimationSpeed = 200;
            this.bunifuIconButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButtonBack.BackgroundColor = System.Drawing.Color.Azure;
            this.bunifuIconButtonBack.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButtonBack.BorderRadius = 1;
            this.bunifuIconButtonBack.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButtonBack.BorderThickness = 1;
            this.bunifuIconButtonBack.ColorContrastOnClick = 30;
            this.bunifuIconButtonBack.ColorContrastOnHover = 30;
            this.bunifuIconButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuIconButtonBack.CustomizableEdges = borderEdges1;
            this.bunifuIconButtonBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButtonBack.Image = global::TeacherManajar.Properties.Resources.back_to_64px;
            this.bunifuIconButtonBack.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButtonBack.Location = new System.Drawing.Point(20, 0);
            this.bunifuIconButtonBack.Name = "bunifuIconButtonBack";
            this.bunifuIconButtonBack.RoundBorders = true;
            this.bunifuIconButtonBack.ShowBorders = true;
            this.bunifuIconButtonBack.Size = new System.Drawing.Size(50, 50);
            this.bunifuIconButtonBack.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButtonBack.TabIndex = 8;
            this.bunifuToolTip.SetToolTip(this.bunifuIconButtonBack, "Повернутися назад");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuIconButtonBack, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuIconButtonBack, "");
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(795, 35);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Календарний план";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.labelTitle, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelTitle, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelTitle, "");
            // 
            // panelTable
            // 
            this.panelTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTable.Controls.Add(this.bunifuDataGridView);
            this.panelTable.Location = new System.Drawing.Point(5, 100);
            this.panelTable.Margin = new System.Windows.Forms.Padding(0);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(795, 605);
            this.panelTable.TabIndex = 3;
            this.bunifuToolTip.SetToolTip(this.panelTable, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelTable, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelTable, "");
            // 
            // bunifuDataGridView
            // 
            this.bunifuDataGridView.AllowCustomTheming = false;
            this.bunifuDataGridView.AllowUserToAddRows = false;
            this.bunifuDataGridView.AllowUserToDeleteRows = false;
            this.bunifuDataGridView.AllowUserToOrderColumns = true;
            this.bunifuDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.bunifuDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView.ColumnHeadersHeight = 40;
            this.bunifuDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCalendarPlan,
            this.Date,
            this.CalendarText});
            this.bunifuDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.bunifuDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.bunifuDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.bunifuDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.bunifuDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.bunifuDataGridView.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView.CurrentTheme.Name = null;
            this.bunifuDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bunifuDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.bunifuDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuDataGridView.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.bunifuDataGridView.HeaderBackColor = System.Drawing.Color.Teal;
            this.bunifuDataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView.Location = new System.Drawing.Point(0, 0);
            this.bunifuDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuDataGridView.Name = "bunifuDataGridView";
            this.bunifuDataGridView.RowHeadersVisible = false;
            this.bunifuDataGridView.RowHeadersWidth = 80;
            this.bunifuDataGridView.RowTemplate.Height = 40;
            this.bunifuDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView.Size = new System.Drawing.Size(795, 605);
            this.bunifuDataGridView.TabIndex = 6;
            this.bunifuDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            this.bunifuToolTip.SetToolTip(this.bunifuDataGridView, "");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuDataGridView, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuDataGridView, "");
            this.bunifuDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DataGridView_RowsAdded);
            this.bunifuDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView_RowsRemoved);
            // 
            // IdCalendarPlan
            // 
            this.IdCalendarPlan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdCalendarPlan.DefaultCellStyle = dataGridViewCellStyle3;
            this.IdCalendarPlan.FillWeight = 40F;
            this.IdCalendarPlan.Frozen = true;
            this.IdCalendarPlan.HeaderText = "№";
            this.IdCalendarPlan.Name = "IdCalendarPlan";
            this.IdCalendarPlan.ReadOnly = true;
            this.IdCalendarPlan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IdCalendarPlan.ToolTipText = "Номер в журналі";
            this.IdCalendarPlan.Width = 40;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Date.DefaultCellStyle = dataGridViewCellStyle4;
            this.Date.FillWeight = 123.8579F;
            this.Date.Frozen = true;
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 85;
            // 
            // CalendarText
            // 
            this.CalendarText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CalendarText.HeaderText = "Опис";
            this.CalendarText.MaxInputLength = 355;
            this.CalendarText.Name = "CalendarText";
            // 
            // bunifuVScrollBar
            // 
            this.bunifuVScrollBar.AllowCursorChanges = true;
            this.bunifuVScrollBar.AllowHomeEndKeysDetection = false;
            this.bunifuVScrollBar.AllowIncrementalClickMoves = true;
            this.bunifuVScrollBar.AllowMouseDownEffects = true;
            this.bunifuVScrollBar.AllowMouseHoverEffects = true;
            this.bunifuVScrollBar.AllowScrollingAnimations = true;
            this.bunifuVScrollBar.AllowScrollKeysDetection = true;
            this.bunifuVScrollBar.AllowScrollOptionsMenu = true;
            this.bunifuVScrollBar.AllowShrinkingOnFocusLost = false;
            this.bunifuVScrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuVScrollBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.bunifuVScrollBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuVScrollBar.BackgroundImage")));
            this.bunifuVScrollBar.BindingContainer = null;
            this.bunifuVScrollBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(145)))));
            this.bunifuVScrollBar.BorderRadius = 15;
            this.bunifuVScrollBar.BorderThickness = 1;
            this.bunifuVScrollBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuVScrollBar.DurationBeforeShrink = 2000;
            this.bunifuVScrollBar.LargeChange = 5;
            this.bunifuVScrollBar.Location = new System.Drawing.Point(785, 140);
            this.bunifuVScrollBar.Maximum = 100;
            this.bunifuVScrollBar.Minimum = 0;
            this.bunifuVScrollBar.MinimumThumbLength = 18;
            this.bunifuVScrollBar.Name = "bunifuVScrollBar";
            this.bunifuVScrollBar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.bunifuVScrollBar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.bunifuVScrollBar.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(64)))), ((int)(((byte)(145)))));
            this.bunifuVScrollBar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(89)))), ((int)(((byte)(168)))));
            this.bunifuVScrollBar.ShrinkSizeLimit = 3;
            this.bunifuVScrollBar.Size = new System.Drawing.Size(15, 565);
            this.bunifuVScrollBar.SmallChange = 1;
            this.bunifuVScrollBar.TabIndex = 7;
            this.bunifuVScrollBar.ThumbColor = System.Drawing.Color.Gray;
            this.bunifuVScrollBar.ThumbLength = 27;
            this.bunifuVScrollBar.ThumbMargin = 1;
            this.bunifuVScrollBar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.bunifuToolTip.SetToolTip(this.bunifuVScrollBar, "");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuVScrollBar, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuVScrollBar, "");
            this.bunifuVScrollBar.Value = 0;
            this.bunifuVScrollBar.Scroll += new System.EventHandler<Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs>(this.VScrollBar_Scroll);
            // 
            // bunifuIconButtonSave
            // 
            this.bunifuIconButtonSave.AllowAnimations = true;
            this.bunifuIconButtonSave.AllowBorderColorChanges = true;
            this.bunifuIconButtonSave.AllowMouseEffects = true;
            this.bunifuIconButtonSave.AnimationSpeed = 200;
            this.bunifuIconButtonSave.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButtonSave.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButtonSave.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButtonSave.BorderRadius = 1;
            this.bunifuIconButtonSave.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButtonSave.BorderThickness = 1;
            this.bunifuIconButtonSave.ColorContrastOnClick = 30;
            this.bunifuIconButtonSave.ColorContrastOnHover = 30;
            this.bunifuIconButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuIconButtonSave.CustomizableEdges = borderEdges2;
            this.bunifuIconButtonSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButtonSave.Image = global::TeacherManajar.Properties.Resources.save_35px;
            this.bunifuIconButtonSave.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButtonSave.Location = new System.Drawing.Point(20, 0);
            this.bunifuIconButtonSave.Name = "bunifuIconButtonSave";
            this.bunifuIconButtonSave.RoundBorders = true;
            this.bunifuIconButtonSave.ShowBorders = true;
            this.bunifuIconButtonSave.Size = new System.Drawing.Size(35, 35);
            this.bunifuIconButtonSave.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButtonSave.TabIndex = 8;
            this.bunifuToolTip.SetToolTip(this.bunifuIconButtonSave, "Зберегти зміни");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuIconButtonSave, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuIconButtonSave, "");
            this.bunifuIconButtonSave.Visible = false;
            this.bunifuIconButtonSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.bunifuIconButtonSave);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Location = new System.Drawing.Point(5, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 35);
            this.panel1.TabIndex = 8;
            this.bunifuToolTip.SetToolTip(this.panel1, "");
            this.bunifuToolTip.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip.SetToolTipTitle(this.panel1, "");
            // 
            // bunifuToolTip
            // 
            this.bunifuToolTip.Active = true;
            this.bunifuToolTip.AlignTextWithTitle = false;
            this.bunifuToolTip.AllowAutoClose = false;
            this.bunifuToolTip.AllowFading = true;
            this.bunifuToolTip.AutoCloseDuration = 5000;
            this.bunifuToolTip.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip.ClickToShowDisplayControl = false;
            this.bunifuToolTip.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip.DisplayControl = null;
            this.bunifuToolTip.EntryAnimationSpeed = 350;
            this.bunifuToolTip.ExitAnimationSpeed = 200;
            this.bunifuToolTip.GenerateAutoCloseDuration = false;
            this.bunifuToolTip.IconMargin = 6;
            this.bunifuToolTip.InitialDelay = 0;
            this.bunifuToolTip.Name = "bunifuToolTip";
            this.bunifuToolTip.Opacity = 1D;
            this.bunifuToolTip.OverrideToolTipTitles = false;
            this.bunifuToolTip.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip.ReshowDelay = 100;
            this.bunifuToolTip.ShowAlways = true;
            this.bunifuToolTip.ShowBorders = false;
            this.bunifuToolTip.ShowIcons = true;
            this.bunifuToolTip.ShowShadows = true;
            this.bunifuToolTip.Tag = null;
            this.bunifuToolTip.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip.TextMargin = 2;
            this.bunifuToolTip.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip.ToolTipTitle = null;
            // 
            // FormCalendarPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(805, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuVScrollBar);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelMoveShape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(805, 710);
            this.MinimumSize = new System.Drawing.Size(805, 710);
            this.Name = "FormCalendarPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalendarPlan";
            this.panelMoveShape.ResumeLayout(false);
            this.panelMoveShape.PerformLayout();
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMoveShape;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelTable;
        private Bunifu.UI.WinForms.BunifuVScrollBar bunifuVScrollBar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButtonBack;
        private System.Windows.Forms.Label labelAutoSave;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButtonSave;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCalendarPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalendarText;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip;
        private System.Windows.Forms.Panel panel1;
    }
}