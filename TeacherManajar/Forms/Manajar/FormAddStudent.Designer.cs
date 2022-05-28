
namespace TeacherManajar.Forms.Manajar
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
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddStudent));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDropdownVariantSearch = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.bunifuIconButtonHelp = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.bunifuTextBoxSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuButtonAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButtonClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Додати студента";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.label1, "");
            this.bunifuToolTip.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip.SetToolTipTitle(this.label1, "");
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(66, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Варіант пошуку";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.label3, "");
            this.bunifuToolTip.SetToolTipIcon(this.label3, null);
            this.bunifuToolTip.SetToolTipTitle(this.label3, "");
            // 
            // bunifuDropdownVariantSearch
            // 
            this.bunifuDropdownVariantSearch.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdownVariantSearch.BackgroundColor = System.Drawing.Color.White;
            this.bunifuDropdownVariantSearch.BorderColor = System.Drawing.Color.Silver;
            this.bunifuDropdownVariantSearch.BorderRadius = 1;
            this.bunifuDropdownVariantSearch.Color = System.Drawing.Color.Silver;
            this.bunifuDropdownVariantSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuDropdownVariantSearch.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdownVariantSearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdownVariantSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuDropdownVariantSearch.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bunifuDropdownVariantSearch.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bunifuDropdownVariantSearch.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdownVariantSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdownVariantSearch.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.bunifuDropdownVariantSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdownVariantSearch.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdownVariantSearch.FillDropDown = true;
            this.bunifuDropdownVariantSearch.FillIndicator = false;
            this.bunifuDropdownVariantSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdownVariantSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuDropdownVariantSearch.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownVariantSearch.FormattingEnabled = true;
            this.bunifuDropdownVariantSearch.Icon = null;
            this.bunifuDropdownVariantSearch.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdownVariantSearch.IndicatorColor = System.Drawing.Color.DarkGray;
            this.bunifuDropdownVariantSearch.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdownVariantSearch.IndicatorThickness = 2;
            this.bunifuDropdownVariantSearch.IsDropdownOpened = false;
            this.bunifuDropdownVariantSearch.ItemBackColor = System.Drawing.Color.White;
            this.bunifuDropdownVariantSearch.ItemBorderColor = System.Drawing.Color.White;
            this.bunifuDropdownVariantSearch.ItemForeColor = System.Drawing.Color.Black;
            this.bunifuDropdownVariantSearch.ItemHeight = 30;
            this.bunifuDropdownVariantSearch.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDropdownVariantSearch.ItemHighLightForeColor = System.Drawing.Color.White;
            this.bunifuDropdownVariantSearch.Items.AddRange(new object[] {
            "За ідентифікатором",
            "За повним ПІБ"});
            this.bunifuDropdownVariantSearch.ItemTopMargin = 3;
            this.bunifuDropdownVariantSearch.Location = new System.Drawing.Point(274, 69);
            this.bunifuDropdownVariantSearch.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuDropdownVariantSearch.Name = "bunifuDropdownVariantSearch";
            this.bunifuDropdownVariantSearch.Size = new System.Drawing.Size(278, 36);
            this.bunifuDropdownVariantSearch.TabIndex = 7;
            this.bunifuDropdownVariantSearch.Text = "За ідентифікатором";
            this.bunifuDropdownVariantSearch.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdownVariantSearch.TextLeftMargin = 5;
            this.bunifuToolTip.SetToolTip(this.bunifuDropdownVariantSearch, "Натисніть для вибору варіанту пошуку");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuDropdownVariantSearch, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuDropdownVariantSearch, "");
            this.bunifuDropdownVariantSearch.SelectedIndexChanged += new System.EventHandler(this.DropdownVariantSearch_SelectedIndexChanged);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дані студента";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.label2, "");
            this.bunifuToolTip.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip.SetToolTipTitle(this.label2, "");
            // 
            // labelResult
            // 
            this.labelResult.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.DimGray;
            this.labelResult.Location = new System.Drawing.Point(20, 220);
            this.labelResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(550, 32);
            this.labelResult.TabIndex = 11;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip.SetToolTip(this.labelResult, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelResult, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelResult, "");
            // 
            // bunifuIconButtonHelp
            // 
            this.bunifuIconButtonHelp.AllowAnimations = true;
            this.bunifuIconButtonHelp.AllowBorderColorChanges = true;
            this.bunifuIconButtonHelp.AllowMouseEffects = true;
            this.bunifuIconButtonHelp.AnimationSpeed = 200;
            this.bunifuIconButtonHelp.BackColor = System.Drawing.Color.Transparent;
            this.bunifuIconButtonHelp.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButtonHelp.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuIconButtonHelp.BorderRadius = 1;
            this.bunifuIconButtonHelp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.bunifuIconButtonHelp.BorderThickness = 1;
            this.bunifuIconButtonHelp.ColorContrastOnClick = 30;
            this.bunifuIconButtonHelp.ColorContrastOnHover = 30;
            this.bunifuIconButtonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuIconButtonHelp.CustomizableEdges = borderEdges1;
            this.bunifuIconButtonHelp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuIconButtonHelp.Image = global::TeacherManajar.Properties.Resources.help_35px;
            this.bunifuIconButtonHelp.ImageMargin = new System.Windows.Forms.Padding(0);
            this.bunifuIconButtonHelp.Location = new System.Drawing.Point(540, 5);
            this.bunifuIconButtonHelp.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuIconButtonHelp.Name = "bunifuIconButtonHelp";
            this.bunifuIconButtonHelp.RoundBorders = true;
            this.bunifuIconButtonHelp.ShowBorders = true;
            this.bunifuIconButtonHelp.Size = new System.Drawing.Size(45, 45);
            this.bunifuIconButtonHelp.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.bunifuIconButtonHelp.TabIndex = 8;
            this.bunifuToolTip.SetToolTip(this.bunifuIconButtonHelp, "Натисніть щоб дізнатися інформацію про те, як здійснювати пошук студента");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuIconButtonHelp, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuIconButtonHelp, "");
            this.bunifuIconButtonHelp.Click += new System.EventHandler(this.Help_Click);
            // 
            // bunifuTextBoxSearch
            // 
            this.bunifuTextBoxSearch.AcceptsReturn = false;
            this.bunifuTextBoxSearch.AcceptsTab = false;
            this.bunifuTextBoxSearch.AnimationSpeed = 200;
            this.bunifuTextBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBoxSearch.AutoSizeHeight = true;
            this.bunifuTextBoxSearch.BackColor = System.Drawing.Color.White;
            this.bunifuTextBoxSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBoxSearch.BackgroundImage")));
            this.bunifuTextBoxSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBoxSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBoxSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBoxSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.bunifuTextBoxSearch.BorderRadius = 1;
            this.bunifuTextBoxSearch.BorderThickness = 1;
            this.bunifuTextBoxSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuTextBoxSearch.DefaultText = "";
            this.bunifuTextBoxSearch.FillColor = System.Drawing.Color.White;
            this.bunifuTextBoxSearch.HideSelection = true;
            this.bunifuTextBoxSearch.IconLeft = null;
            this.bunifuTextBoxSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBoxSearch.IconPadding = 10;
            this.bunifuTextBoxSearch.IconRight = global::TeacherManajar.Properties.Resources.search_64px;
            this.bunifuTextBoxSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTextBoxSearch.Lines = new string[0];
            this.bunifuTextBoxSearch.Location = new System.Drawing.Point(24, 115);
            this.bunifuTextBoxSearch.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuTextBoxSearch.MaxLength = 32767;
            this.bunifuTextBoxSearch.MinimumSize = new System.Drawing.Size(2, 2);
            this.bunifuTextBoxSearch.Modified = false;
            this.bunifuTextBoxSearch.Multiline = false;
            this.bunifuTextBoxSearch.Name = "bunifuTextBoxSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBoxSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBoxSearch.OnIdleState = stateProperties4;
            this.bunifuTextBoxSearch.Padding = new System.Windows.Forms.Padding(5);
            this.bunifuTextBoxSearch.PasswordChar = '\0';
            this.bunifuTextBoxSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBoxSearch.PlaceholderText = "Введіть дані";
            this.bunifuTextBoxSearch.ReadOnly = false;
            this.bunifuTextBoxSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBoxSearch.SelectedText = "";
            this.bunifuTextBoxSearch.SelectionLength = 0;
            this.bunifuTextBoxSearch.SelectionStart = 0;
            this.bunifuTextBoxSearch.ShortcutsEnabled = true;
            this.bunifuTextBoxSearch.Size = new System.Drawing.Size(528, 50);
            this.bunifuTextBoxSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBoxSearch.TabIndex = 2;
            this.bunifuTextBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBoxSearch.TextMarginBottom = 0;
            this.bunifuTextBoxSearch.TextMarginLeft = 3;
            this.bunifuTextBoxSearch.TextMarginTop = 1;
            this.bunifuTextBoxSearch.TextPlaceholder = "Введіть дані";
            this.bunifuToolTip.SetToolTip(this.bunifuTextBoxSearch, "Введіть дані та натисніть кнопку для пошуку");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuTextBoxSearch, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuTextBoxSearch, "");
            this.bunifuTextBoxSearch.UseSystemPasswordChar = false;
            this.bunifuTextBoxSearch.WordWrap = true;
            this.bunifuTextBoxSearch.OnIconRightClick += new System.EventHandler(this.Search_OnIconRightClick);
            // 
            // bunifuButtonAdd
            // 
            this.bunifuButtonAdd.AllowAnimations = true;
            this.bunifuButtonAdd.AllowMouseEffects = true;
            this.bunifuButtonAdd.AllowToggling = false;
            this.bunifuButtonAdd.AnimationSpeed = 200;
            this.bunifuButtonAdd.AutoGenerateColors = false;
            this.bunifuButtonAdd.AutoRoundBorders = false;
            this.bunifuButtonAdd.AutoSizeLeftIcon = true;
            this.bunifuButtonAdd.AutoSizeRightIcon = true;
            this.bunifuButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonAdd.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButtonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonAdd.BackgroundImage")));
            this.bunifuButtonAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonAdd.ButtonText = "Додати";
            this.bunifuButtonAdd.ButtonTextMarginLeft = 0;
            this.bunifuButtonAdd.ColorContrastOnClick = 45;
            this.bunifuButtonAdd.ColorContrastOnHover = 45;
            this.bunifuButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.bunifuButtonAdd.CustomizableEdges = borderEdges2;
            this.bunifuButtonAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonAdd.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButtonAdd.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButtonAdd.Enabled = false;
            this.bunifuButtonAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuButtonAdd.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonAdd.IconLeft = null;
            this.bunifuButtonAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonAdd.IconMarginLeft = 11;
            this.bunifuButtonAdd.IconPadding = 10;
            this.bunifuButtonAdd.IconRight = null;
            this.bunifuButtonAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonAdd.IconSize = 25;
            this.bunifuButtonAdd.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButtonAdd.IdleBorderRadius = 0;
            this.bunifuButtonAdd.IdleBorderThickness = 0;
            this.bunifuButtonAdd.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButtonAdd.IdleIconLeftImage = null;
            this.bunifuButtonAdd.IdleIconRightImage = null;
            this.bunifuButtonAdd.IndicateFocus = false;
            this.bunifuButtonAdd.Location = new System.Drawing.Point(347, 270);
            this.bunifuButtonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuButtonAdd.Name = "bunifuButtonAdd";
            this.bunifuButtonAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonAdd.OnDisabledState.BorderRadius = 1;
            this.bunifuButtonAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonAdd.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonAdd.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonAdd.OnDisabledState.IconRightImage = null;
            this.bunifuButtonAdd.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButtonAdd.onHoverState.BorderRadius = 1;
            this.bunifuButtonAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonAdd.onHoverState.BorderThickness = 1;
            this.bunifuButtonAdd.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButtonAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonAdd.onHoverState.IconLeftImage = null;
            this.bunifuButtonAdd.onHoverState.IconRightImage = null;
            this.bunifuButtonAdd.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonAdd.OnIdleState.BorderRadius = 1;
            this.bunifuButtonAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonAdd.OnIdleState.BorderThickness = 1;
            this.bunifuButtonAdd.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonAdd.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonAdd.OnIdleState.IconLeftImage = null;
            this.bunifuButtonAdd.OnIdleState.IconRightImage = null;
            this.bunifuButtonAdd.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonAdd.OnPressedState.BorderRadius = 1;
            this.bunifuButtonAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonAdd.OnPressedState.BorderThickness = 1;
            this.bunifuButtonAdd.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonAdd.OnPressedState.IconLeftImage = null;
            this.bunifuButtonAdd.OnPressedState.IconRightImage = null;
            this.bunifuButtonAdd.Size = new System.Drawing.Size(205, 60);
            this.bunifuButtonAdd.TabIndex = 12;
            this.bunifuButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonAdd.TextMarginLeft = 0;
            this.bunifuButtonAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip.SetToolTip(this.bunifuButtonAdd, "");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuButtonAdd, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuButtonAdd, "");
            this.bunifuButtonAdd.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuButtonClose
            // 
            this.bunifuButtonClose.AllowAnimations = true;
            this.bunifuButtonClose.AllowMouseEffects = true;
            this.bunifuButtonClose.AllowToggling = false;
            this.bunifuButtonClose.AnimationSpeed = 200;
            this.bunifuButtonClose.AutoGenerateColors = false;
            this.bunifuButtonClose.AutoRoundBorders = false;
            this.bunifuButtonClose.AutoSizeLeftIcon = true;
            this.bunifuButtonClose.AutoSizeRightIcon = true;
            this.bunifuButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButtonClose.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButtonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButtonClose.BackgroundImage")));
            this.bunifuButtonClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonClose.ButtonText = "Відмінна";
            this.bunifuButtonClose.ButtonTextMarginLeft = 0;
            this.bunifuButtonClose.ColorContrastOnClick = 45;
            this.bunifuButtonClose.ColorContrastOnHover = 45;
            this.bunifuButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButtonClose.CustomizableEdges = borderEdges3;
            this.bunifuButtonClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButtonClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonClose.DisabledFillColor = System.Drawing.Color.Empty;
            this.bunifuButtonClose.DisabledForecolor = System.Drawing.Color.Empty;
            this.bunifuButtonClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButtonClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuButtonClose.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonClose.IconLeft = null;
            this.bunifuButtonClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButtonClose.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonClose.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButtonClose.IconMarginLeft = 11;
            this.bunifuButtonClose.IconPadding = 10;
            this.bunifuButtonClose.IconRight = null;
            this.bunifuButtonClose.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButtonClose.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButtonClose.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButtonClose.IconSize = 25;
            this.bunifuButtonClose.IdleBorderColor = System.Drawing.Color.Empty;
            this.bunifuButtonClose.IdleBorderRadius = 0;
            this.bunifuButtonClose.IdleBorderThickness = 0;
            this.bunifuButtonClose.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButtonClose.IdleIconLeftImage = null;
            this.bunifuButtonClose.IdleIconRightImage = null;
            this.bunifuButtonClose.IndicateFocus = false;
            this.bunifuButtonClose.Location = new System.Drawing.Point(24, 270);
            this.bunifuButtonClose.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuButtonClose.Name = "bunifuButtonClose";
            this.bunifuButtonClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButtonClose.OnDisabledState.BorderRadius = 1;
            this.bunifuButtonClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonClose.OnDisabledState.BorderThickness = 1;
            this.bunifuButtonClose.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButtonClose.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButtonClose.OnDisabledState.IconLeftImage = null;
            this.bunifuButtonClose.OnDisabledState.IconRightImage = null;
            this.bunifuButtonClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButtonClose.onHoverState.BorderRadius = 1;
            this.bunifuButtonClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonClose.onHoverState.BorderThickness = 1;
            this.bunifuButtonClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.bunifuButtonClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonClose.onHoverState.IconLeftImage = null;
            this.bunifuButtonClose.onHoverState.IconRightImage = null;
            this.bunifuButtonClose.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonClose.OnIdleState.BorderRadius = 1;
            this.bunifuButtonClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonClose.OnIdleState.BorderThickness = 1;
            this.bunifuButtonClose.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButtonClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonClose.OnIdleState.IconLeftImage = null;
            this.bunifuButtonClose.OnIdleState.IconRightImage = null;
            this.bunifuButtonClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonClose.OnPressedState.BorderRadius = 1;
            this.bunifuButtonClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButtonClose.OnPressedState.BorderThickness = 1;
            this.bunifuButtonClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButtonClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButtonClose.OnPressedState.IconLeftImage = null;
            this.bunifuButtonClose.OnPressedState.IconRightImage = null;
            this.bunifuButtonClose.Size = new System.Drawing.Size(205, 60);
            this.bunifuButtonClose.TabIndex = 13;
            this.bunifuButtonClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButtonClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButtonClose.TextMarginLeft = 0;
            this.bunifuButtonClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip.SetToolTip(this.bunifuButtonClose, "");
            this.bunifuToolTip.SetToolTipIcon(this.bunifuButtonClose, null);
            this.bunifuToolTip.SetToolTipTitle(this.bunifuButtonClose, "");
            this.bunifuButtonClose.UseDefaultRadiusAndThickness = true;
            this.bunifuButtonClose.Click += new System.EventHandler(this.Close_Click);
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(590, 340);
            this.Controls.Add(this.bunifuButtonClose);
            this.Controls.Add(this.bunifuButtonAdd);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuIconButtonHelp);
            this.Controls.Add(this.bunifuDropdownVariantSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuTextBoxSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAddStudent";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddStudent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBoxSearch;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdownVariantSearch;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton bunifuIconButtonHelp;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonAdd;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButtonClose;
    }
}