
namespace TeacherManajar.Forms
{
    partial class FormNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotes));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.panelInstrument = new System.Windows.Forms.Panel();
            this.iconButtonCreateNote = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.panelOpenNotesText = new System.Windows.Forms.Panel();
            this.iconButtonOpenNotesText = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.tableLayoutPanelNotesText = new System.Windows.Forms.TableLayoutPanel();
            this.panelOpenNotesListCheck = new System.Windows.Forms.Panel();
            this.iconButtonOpenListCheck = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.tableLayoutPanelNotesListCheck = new System.Windows.Forms.TableLayoutPanel();
            this.panelFont = new System.Windows.Forms.Panel();
            this.iconPictureBoxWithoutNotes = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.labelWithoutNotes = new System.Windows.Forms.Label();
            this.bunifuToolTip = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panelInstrument.SuspendLayout();
            this.panelOpenNotesText.SuspendLayout();
            this.panelOpenNotesListCheck.SuspendLayout();
            this.panelFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxWithoutNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInstrument
            // 
            this.panelInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelInstrument.Controls.Add(this.iconButtonCreateNote);
            this.panelInstrument.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInstrument.Location = new System.Drawing.Point(5, 5);
            this.panelInstrument.Name = "panelInstrument";
            this.panelInstrument.Padding = new System.Windows.Forms.Padding(5);
            this.panelInstrument.Size = new System.Drawing.Size(982, 65);
            this.panelInstrument.TabIndex = 1;
            this.bunifuToolTip.SetToolTip(this.panelInstrument, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelInstrument, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelInstrument, "");
            // 
            // iconButtonCreateNote
            // 
            this.iconButtonCreateNote.AllowAnimations = true;
            this.iconButtonCreateNote.AllowMouseEffects = true;
            this.iconButtonCreateNote.AllowToggling = false;
            this.iconButtonCreateNote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonCreateNote.AnimationSpeed = 200;
            this.iconButtonCreateNote.AutoGenerateColors = false;
            this.iconButtonCreateNote.AutoRoundBorders = false;
            this.iconButtonCreateNote.AutoSizeLeftIcon = true;
            this.iconButtonCreateNote.AutoSizeRightIcon = true;
            this.iconButtonCreateNote.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonCreateNote.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconButtonCreateNote.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconButtonCreateNote.BackgroundImage")));
            this.iconButtonCreateNote.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonCreateNote.ButtonText = "Створити нотатку";
            this.iconButtonCreateNote.ButtonTextMarginLeft = 0;
            this.iconButtonCreateNote.ColorContrastOnClick = 45;
            this.iconButtonCreateNote.ColorContrastOnHover = 45;
            this.iconButtonCreateNote.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.iconButtonCreateNote.CustomizableEdges = borderEdges4;
            this.iconButtonCreateNote.DialogResult = System.Windows.Forms.DialogResult.None;
            this.iconButtonCreateNote.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.iconButtonCreateNote.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.iconButtonCreateNote.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.iconButtonCreateNote.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.iconButtonCreateNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonCreateNote.ForeColor = System.Drawing.Color.White;
            this.iconButtonCreateNote.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCreateNote.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonCreateNote.IconLeftPadding = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.iconButtonCreateNote.IconMarginLeft = 11;
            this.iconButtonCreateNote.IconPadding = 5;
            this.iconButtonCreateNote.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonCreateNote.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonCreateNote.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.iconButtonCreateNote.IconSize = 25;
            this.iconButtonCreateNote.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconButtonCreateNote.IdleBorderRadius = 15;
            this.iconButtonCreateNote.IdleBorderThickness = 1;
            this.iconButtonCreateNote.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconButtonCreateNote.IdleIconLeftImage = global::TeacherManajar.Properties.Resources.create_40px;
            this.iconButtonCreateNote.IdleIconRightImage = null;
            this.iconButtonCreateNote.IndicateFocus = false;
            this.iconButtonCreateNote.Location = new System.Drawing.Point(383, 5);
            this.iconButtonCreateNote.Name = "iconButtonCreateNote";
            this.iconButtonCreateNote.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.iconButtonCreateNote.OnDisabledState.BorderRadius = 15;
            this.iconButtonCreateNote.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonCreateNote.OnDisabledState.BorderThickness = 1;
            this.iconButtonCreateNote.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.iconButtonCreateNote.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.iconButtonCreateNote.OnDisabledState.IconLeftImage = null;
            this.iconButtonCreateNote.OnDisabledState.IconRightImage = null;
            this.iconButtonCreateNote.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.iconButtonCreateNote.onHoverState.BorderRadius = 15;
            this.iconButtonCreateNote.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonCreateNote.onHoverState.BorderThickness = 1;
            this.iconButtonCreateNote.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.iconButtonCreateNote.onHoverState.ForeColor = System.Drawing.Color.White;
            this.iconButtonCreateNote.onHoverState.IconLeftImage = null;
            this.iconButtonCreateNote.onHoverState.IconRightImage = null;
            this.iconButtonCreateNote.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconButtonCreateNote.OnIdleState.BorderRadius = 15;
            this.iconButtonCreateNote.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonCreateNote.OnIdleState.BorderThickness = 1;
            this.iconButtonCreateNote.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.iconButtonCreateNote.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.iconButtonCreateNote.OnIdleState.IconLeftImage = global::TeacherManajar.Properties.Resources.create_40px;
            this.iconButtonCreateNote.OnIdleState.IconRightImage = null;
            this.iconButtonCreateNote.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.iconButtonCreateNote.OnPressedState.BorderRadius = 15;
            this.iconButtonCreateNote.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonCreateNote.OnPressedState.BorderThickness = 1;
            this.iconButtonCreateNote.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.iconButtonCreateNote.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.iconButtonCreateNote.OnPressedState.IconLeftImage = null;
            this.iconButtonCreateNote.OnPressedState.IconRightImage = null;
            this.iconButtonCreateNote.Size = new System.Drawing.Size(210, 55);
            this.iconButtonCreateNote.TabIndex = 1;
            this.iconButtonCreateNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.iconButtonCreateNote.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.iconButtonCreateNote.TextMarginLeft = 0;
            this.iconButtonCreateNote.TextPadding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.bunifuToolTip.SetToolTip(this.iconButtonCreateNote, "Натисніть, щоб створити нову нотатку або список справ");
            this.bunifuToolTip.SetToolTipIcon(this.iconButtonCreateNote, null);
            this.bunifuToolTip.SetToolTipTitle(this.iconButtonCreateNote, "");
            this.iconButtonCreateNote.UseDefaultRadiusAndThickness = true;
            // 
            // panelOpenNotesText
            // 
            this.panelOpenNotesText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(201)))));
            this.panelOpenNotesText.Controls.Add(this.iconButtonOpenNotesText);
            this.panelOpenNotesText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpenNotesText.Location = new System.Drawing.Point(5, 70);
            this.panelOpenNotesText.Margin = new System.Windows.Forms.Padding(0);
            this.panelOpenNotesText.Name = "panelOpenNotesText";
            this.panelOpenNotesText.Padding = new System.Windows.Forms.Padding(45, 5, 5, 5);
            this.panelOpenNotesText.Size = new System.Drawing.Size(982, 50);
            this.panelOpenNotesText.TabIndex = 6;
            this.bunifuToolTip.SetToolTip(this.panelOpenNotesText, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelOpenNotesText, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelOpenNotesText, "");
            this.panelOpenNotesText.Visible = false;
            // 
            // iconButtonOpenNotesText
            // 
            this.iconButtonOpenNotesText.AllowAnimations = true;
            this.iconButtonOpenNotesText.AllowMouseEffects = true;
            this.iconButtonOpenNotesText.AllowToggling = false;
            this.iconButtonOpenNotesText.AnimationSpeed = 200;
            this.iconButtonOpenNotesText.AutoGenerateColors = false;
            this.iconButtonOpenNotesText.AutoRoundBorders = false;
            this.iconButtonOpenNotesText.AutoSizeLeftIcon = true;
            this.iconButtonOpenNotesText.AutoSizeRightIcon = true;
            this.iconButtonOpenNotesText.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonOpenNotesText.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.iconButtonOpenNotesText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconButtonOpenNotesText.BackgroundImage")));
            this.iconButtonOpenNotesText.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonOpenNotesText.ButtonText = "Нотатки";
            this.iconButtonOpenNotesText.ButtonTextMarginLeft = 0;
            this.iconButtonOpenNotesText.ColorContrastOnClick = 45;
            this.iconButtonOpenNotesText.ColorContrastOnHover = 45;
            this.iconButtonOpenNotesText.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.iconButtonOpenNotesText.CustomizableEdges = borderEdges5;
            this.iconButtonOpenNotesText.DialogResult = System.Windows.Forms.DialogResult.None;
            this.iconButtonOpenNotesText.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.iconButtonOpenNotesText.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.iconButtonOpenNotesText.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.iconButtonOpenNotesText.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonOpenNotesText.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.iconButtonOpenNotesText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonOpenNotesText.ForeColor = System.Drawing.Color.White;
            this.iconButtonOpenNotesText.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOpenNotesText.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonOpenNotesText.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.iconButtonOpenNotesText.IconMarginLeft = 11;
            this.iconButtonOpenNotesText.IconPadding = 5;
            this.iconButtonOpenNotesText.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonOpenNotesText.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonOpenNotesText.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.iconButtonOpenNotesText.IconSize = 25;
            this.iconButtonOpenNotesText.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.iconButtonOpenNotesText.IdleBorderRadius = 20;
            this.iconButtonOpenNotesText.IdleBorderThickness = 1;
            this.iconButtonOpenNotesText.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.iconButtonOpenNotesText.IdleIconLeftImage = global::TeacherManajar.Properties.Resources.notebook_with_decorative_cover_48px;
            this.iconButtonOpenNotesText.IdleIconRightImage = null;
            this.iconButtonOpenNotesText.IndicateFocus = false;
            this.iconButtonOpenNotesText.Location = new System.Drawing.Point(45, 5);
            this.iconButtonOpenNotesText.Name = "iconButtonOpenNotesText";
            this.iconButtonOpenNotesText.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.iconButtonOpenNotesText.OnDisabledState.BorderRadius = 20;
            this.iconButtonOpenNotesText.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonOpenNotesText.OnDisabledState.BorderThickness = 1;
            this.iconButtonOpenNotesText.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.iconButtonOpenNotesText.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.iconButtonOpenNotesText.OnDisabledState.IconLeftImage = null;
            this.iconButtonOpenNotesText.OnDisabledState.IconRightImage = null;
            this.iconButtonOpenNotesText.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.iconButtonOpenNotesText.onHoverState.BorderRadius = 20;
            this.iconButtonOpenNotesText.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonOpenNotesText.onHoverState.BorderThickness = 1;
            this.iconButtonOpenNotesText.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.iconButtonOpenNotesText.onHoverState.ForeColor = System.Drawing.Color.White;
            this.iconButtonOpenNotesText.onHoverState.IconLeftImage = null;
            this.iconButtonOpenNotesText.onHoverState.IconRightImage = null;
            this.iconButtonOpenNotesText.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.iconButtonOpenNotesText.OnIdleState.BorderRadius = 20;
            this.iconButtonOpenNotesText.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonOpenNotesText.OnIdleState.BorderThickness = 1;
            this.iconButtonOpenNotesText.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.iconButtonOpenNotesText.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.iconButtonOpenNotesText.OnIdleState.IconLeftImage = global::TeacherManajar.Properties.Resources.notebook_with_decorative_cover_48px;
            this.iconButtonOpenNotesText.OnIdleState.IconRightImage = null;
            this.iconButtonOpenNotesText.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.iconButtonOpenNotesText.OnPressedState.BorderRadius = 20;
            this.iconButtonOpenNotesText.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonOpenNotesText.OnPressedState.BorderThickness = 1;
            this.iconButtonOpenNotesText.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.iconButtonOpenNotesText.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.iconButtonOpenNotesText.OnPressedState.IconLeftImage = null;
            this.iconButtonOpenNotesText.OnPressedState.IconRightImage = null;
            this.iconButtonOpenNotesText.Size = new System.Drawing.Size(170, 40);
            this.iconButtonOpenNotesText.TabIndex = 2;
            this.iconButtonOpenNotesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.iconButtonOpenNotesText.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.iconButtonOpenNotesText.TextMarginLeft = 0;
            this.iconButtonOpenNotesText.TextPadding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bunifuToolTip.SetToolTip(this.iconButtonOpenNotesText, "Згорнути/розгорнути ваші нотатки");
            this.bunifuToolTip.SetToolTipIcon(this.iconButtonOpenNotesText, null);
            this.bunifuToolTip.SetToolTipTitle(this.iconButtonOpenNotesText, "");
            this.iconButtonOpenNotesText.UseDefaultRadiusAndThickness = true;
            // 
            // tableLayoutPanelNotesText
            // 
            this.tableLayoutPanelNotesText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelNotesText.ColumnCount = 3;
            this.tableLayoutPanelNotesText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelNotesText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanelNotesText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelNotesText.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelNotesText.Location = new System.Drawing.Point(5, 120);
            this.tableLayoutPanelNotesText.Name = "tableLayoutPanelNotesText";
            this.tableLayoutPanelNotesText.RowCount = 1;
            this.tableLayoutPanelNotesText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanelNotesText.Size = new System.Drawing.Size(982, 0);
            this.tableLayoutPanelNotesText.TabIndex = 7;
            this.bunifuToolTip.SetToolTip(this.tableLayoutPanelNotesText, "");
            this.bunifuToolTip.SetToolTipIcon(this.tableLayoutPanelNotesText, null);
            this.bunifuToolTip.SetToolTipTitle(this.tableLayoutPanelNotesText, "");
            // 
            // panelOpenNotesListCheck
            // 
            this.panelOpenNotesListCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(201)))));
            this.panelOpenNotesListCheck.Controls.Add(this.iconButtonOpenListCheck);
            this.panelOpenNotesListCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOpenNotesListCheck.Location = new System.Drawing.Point(5, 120);
            this.panelOpenNotesListCheck.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelOpenNotesListCheck.Name = "panelOpenNotesListCheck";
            this.panelOpenNotesListCheck.Padding = new System.Windows.Forms.Padding(45, 5, 5, 5);
            this.panelOpenNotesListCheck.Size = new System.Drawing.Size(982, 50);
            this.panelOpenNotesListCheck.TabIndex = 8;
            this.bunifuToolTip.SetToolTip(this.panelOpenNotesListCheck, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelOpenNotesListCheck, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelOpenNotesListCheck, "");
            this.panelOpenNotesListCheck.Visible = false;
            // 
            // iconButtonOpenListCheck
            // 
            this.iconButtonOpenListCheck.AllowAnimations = true;
            this.iconButtonOpenListCheck.AllowMouseEffects = true;
            this.iconButtonOpenListCheck.AllowToggling = false;
            this.iconButtonOpenListCheck.AnimationSpeed = 200;
            this.iconButtonOpenListCheck.AutoGenerateColors = false;
            this.iconButtonOpenListCheck.AutoRoundBorders = false;
            this.iconButtonOpenListCheck.AutoSizeLeftIcon = true;
            this.iconButtonOpenListCheck.AutoSizeRightIcon = true;
            this.iconButtonOpenListCheck.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonOpenListCheck.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.iconButtonOpenListCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconButtonOpenListCheck.BackgroundImage")));
            this.iconButtonOpenListCheck.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonOpenListCheck.ButtonText = "Список справ";
            this.iconButtonOpenListCheck.ButtonTextMarginLeft = 0;
            this.iconButtonOpenListCheck.ColorContrastOnClick = 45;
            this.iconButtonOpenListCheck.ColorContrastOnHover = 45;
            this.iconButtonOpenListCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.iconButtonOpenListCheck.CustomizableEdges = borderEdges6;
            this.iconButtonOpenListCheck.DialogResult = System.Windows.Forms.DialogResult.None;
            this.iconButtonOpenListCheck.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.iconButtonOpenListCheck.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.iconButtonOpenListCheck.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.iconButtonOpenListCheck.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButtonOpenListCheck.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.iconButtonOpenListCheck.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonOpenListCheck.ForeColor = System.Drawing.Color.White;
            this.iconButtonOpenListCheck.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOpenListCheck.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonOpenListCheck.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.iconButtonOpenListCheck.IconMarginLeft = 11;
            this.iconButtonOpenListCheck.IconPadding = 5;
            this.iconButtonOpenListCheck.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonOpenListCheck.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.iconButtonOpenListCheck.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.iconButtonOpenListCheck.IconSize = 25;
            this.iconButtonOpenListCheck.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.iconButtonOpenListCheck.IdleBorderRadius = 20;
            this.iconButtonOpenListCheck.IdleBorderThickness = 1;
            this.iconButtonOpenListCheck.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.iconButtonOpenListCheck.IdleIconLeftImage = global::TeacherManajar.Properties.Resources.checklist_48px;
            this.iconButtonOpenListCheck.IdleIconRightImage = null;
            this.iconButtonOpenListCheck.IndicateFocus = false;
            this.iconButtonOpenListCheck.Location = new System.Drawing.Point(45, 5);
            this.iconButtonOpenListCheck.Name = "iconButtonOpenListCheck";
            this.iconButtonOpenListCheck.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.iconButtonOpenListCheck.OnDisabledState.BorderRadius = 20;
            this.iconButtonOpenListCheck.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonOpenListCheck.OnDisabledState.BorderThickness = 1;
            this.iconButtonOpenListCheck.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.iconButtonOpenListCheck.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.iconButtonOpenListCheck.OnDisabledState.IconLeftImage = null;
            this.iconButtonOpenListCheck.OnDisabledState.IconRightImage = null;
            this.iconButtonOpenListCheck.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.iconButtonOpenListCheck.onHoverState.BorderRadius = 20;
            this.iconButtonOpenListCheck.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonOpenListCheck.onHoverState.BorderThickness = 1;
            this.iconButtonOpenListCheck.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.iconButtonOpenListCheck.onHoverState.ForeColor = System.Drawing.Color.White;
            this.iconButtonOpenListCheck.onHoverState.IconLeftImage = null;
            this.iconButtonOpenListCheck.onHoverState.IconRightImage = null;
            this.iconButtonOpenListCheck.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.iconButtonOpenListCheck.OnIdleState.BorderRadius = 20;
            this.iconButtonOpenListCheck.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonOpenListCheck.OnIdleState.BorderThickness = 1;
            this.iconButtonOpenListCheck.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(155)))), ((int)(((byte)(215)))));
            this.iconButtonOpenListCheck.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.iconButtonOpenListCheck.OnIdleState.IconLeftImage = global::TeacherManajar.Properties.Resources.checklist_48px;
            this.iconButtonOpenListCheck.OnIdleState.IconRightImage = null;
            this.iconButtonOpenListCheck.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.iconButtonOpenListCheck.OnPressedState.BorderRadius = 20;
            this.iconButtonOpenListCheck.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.iconButtonOpenListCheck.OnPressedState.BorderThickness = 1;
            this.iconButtonOpenListCheck.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.iconButtonOpenListCheck.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.iconButtonOpenListCheck.OnPressedState.IconLeftImage = null;
            this.iconButtonOpenListCheck.OnPressedState.IconRightImage = null;
            this.iconButtonOpenListCheck.Size = new System.Drawing.Size(220, 40);
            this.iconButtonOpenListCheck.TabIndex = 3;
            this.iconButtonOpenListCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.iconButtonOpenListCheck.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.iconButtonOpenListCheck.TextMarginLeft = 0;
            this.iconButtonOpenListCheck.TextPadding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.bunifuToolTip.SetToolTip(this.iconButtonOpenListCheck, "Згорнути/розгорнути ваші списки справ");
            this.bunifuToolTip.SetToolTipIcon(this.iconButtonOpenListCheck, null);
            this.bunifuToolTip.SetToolTipTitle(this.iconButtonOpenListCheck, "");
            this.iconButtonOpenListCheck.UseDefaultRadiusAndThickness = true;
            // 
            // tableLayoutPanelNotesListCheck
            // 
            this.tableLayoutPanelNotesListCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.tableLayoutPanelNotesListCheck.ColumnCount = 3;
            this.tableLayoutPanelNotesListCheck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelNotesListCheck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanelNotesListCheck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanelNotesListCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelNotesListCheck.Location = new System.Drawing.Point(5, 170);
            this.tableLayoutPanelNotesListCheck.Name = "tableLayoutPanelNotesListCheck";
            this.tableLayoutPanelNotesListCheck.RowCount = 1;
            this.tableLayoutPanelNotesListCheck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanelNotesListCheck.Size = new System.Drawing.Size(982, 0);
            this.tableLayoutPanelNotesListCheck.TabIndex = 9;
            this.bunifuToolTip.SetToolTip(this.tableLayoutPanelNotesListCheck, "");
            this.bunifuToolTip.SetToolTipIcon(this.tableLayoutPanelNotesListCheck, null);
            this.bunifuToolTip.SetToolTipTitle(this.tableLayoutPanelNotesListCheck, "");
            // 
            // panelFont
            // 
            this.panelFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelFont.Controls.Add(this.iconPictureBoxWithoutNotes);
            this.panelFont.Controls.Add(this.labelWithoutNotes);
            this.panelFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFont.Location = new System.Drawing.Point(5, 170);
            this.panelFont.Name = "panelFont";
            this.panelFont.Size = new System.Drawing.Size(982, 493);
            this.panelFont.TabIndex = 10;
            this.bunifuToolTip.SetToolTip(this.panelFont, "");
            this.bunifuToolTip.SetToolTipIcon(this.panelFont, null);
            this.bunifuToolTip.SetToolTipTitle(this.panelFont, "");
            // 
            // iconPictureBoxWithoutNotes
            // 
            this.iconPictureBoxWithoutNotes.AllowFocused = false;
            this.iconPictureBoxWithoutNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBoxWithoutNotes.AutoSizeHeight = true;
            this.iconPictureBoxWithoutNotes.BorderRadius = 0;
            this.iconPictureBoxWithoutNotes.Image = global::TeacherManajar.Properties.Resources.notebook_with_decorative_cover_48px;
            this.iconPictureBoxWithoutNotes.IsCircle = true;
            this.iconPictureBoxWithoutNotes.Location = new System.Drawing.Point(440, 152);
            this.iconPictureBoxWithoutNotes.Name = "iconPictureBoxWithoutNotes";
            this.iconPictureBoxWithoutNotes.Size = new System.Drawing.Size(104, 104);
            this.iconPictureBoxWithoutNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBoxWithoutNotes.TabIndex = 2;
            this.iconPictureBoxWithoutNotes.TabStop = false;
            this.bunifuToolTip.SetToolTip(this.iconPictureBoxWithoutNotes, "");
            this.bunifuToolTip.SetToolTipIcon(this.iconPictureBoxWithoutNotes, null);
            this.bunifuToolTip.SetToolTipTitle(this.iconPictureBoxWithoutNotes, "");
            this.iconPictureBoxWithoutNotes.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // labelWithoutNotes
            // 
            this.labelWithoutNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelWithoutNotes.Font = new System.Drawing.Font("Gabriola", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWithoutNotes.ForeColor = System.Drawing.Color.DimGray;
            this.labelWithoutNotes.Location = new System.Drawing.Point(309, 240);
            this.labelWithoutNotes.Name = "labelWithoutNotes";
            this.labelWithoutNotes.Size = new System.Drawing.Size(375, 90);
            this.labelWithoutNotes.TabIndex = 1;
            this.labelWithoutNotes.Text = "Нотатки відсутні";
            this.labelWithoutNotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuToolTip.SetToolTip(this.labelWithoutNotes, "");
            this.bunifuToolTip.SetToolTipIcon(this.labelWithoutNotes, null);
            this.bunifuToolTip.SetToolTipTitle(this.labelWithoutNotes, "");
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
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(992, 668);
            this.Controls.Add(this.panelFont);
            this.Controls.Add(this.tableLayoutPanelNotesListCheck);
            this.Controls.Add(this.panelOpenNotesListCheck);
            this.Controls.Add(this.tableLayoutPanelNotesText);
            this.Controls.Add(this.panelOpenNotesText);
            this.Controls.Add(this.panelInstrument);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNotes";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Нотатки";
            this.panelInstrument.ResumeLayout(false);
            this.panelOpenNotesText.ResumeLayout(false);
            this.panelOpenNotesListCheck.ResumeLayout(false);
            this.panelFont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxWithoutNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInstrument;
        private System.Windows.Forms.Panel panelOpenNotesText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNotesText;
        private System.Windows.Forms.Panel panelOpenNotesListCheck;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNotesListCheck;
        private System.Windows.Forms.Panel panelFont;
        private System.Windows.Forms.Label labelWithoutNotes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 iconButtonCreateNote;
        private Bunifu.UI.WinForms.BunifuPictureBox iconPictureBoxWithoutNotes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 iconButtonOpenNotesText;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 iconButtonOpenListCheck;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip;
    }
}