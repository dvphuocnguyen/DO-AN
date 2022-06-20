namespace LoginForm
{
    partial class Questions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LvCb = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.QuestText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Quiz = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuestionDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ResetBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AnswerTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Op4Tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Op3Tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Op2Tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.Op1Tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.QuestionTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(369, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // LvCb
            // 
            this.LvCb.FormattingEnabled = true;
            this.LvCb.Location = new System.Drawing.Point(1619, 35);
            this.LvCb.Name = "LvCb";
            this.LvCb.Size = new System.Drawing.Size(114, 28);
            this.LvCb.TabIndex = 7;
            this.LvCb.Text = "Levels";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(406, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 3);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1240, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Members";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // QuestText
            // 
            this.QuestText.AutoSize = true;
            this.QuestText.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestText.Location = new System.Drawing.Point(828, 496);
            this.QuestText.Name = "QuestText";
            this.QuestText.Size = new System.Drawing.Size(150, 26);
            this.QuestText.TabIndex = 2;
            this.QuestText.Text = "Question Bank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Questions";
            // 
            // Quiz
            // 
            this.Quiz.AutoSize = true;
            this.Quiz.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quiz.Location = new System.Drawing.Point(15, 9);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(129, 26);
            this.Quiz.TabIndex = 2;
            this.Quiz.Text = "English Quiz";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1798, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(126, 999);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(820, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Levels";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.QuestionDGV);
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.AnswerTb);
            this.panel1.Controls.Add(this.Op4Tb);
            this.panel1.Controls.Add(this.Op3Tb);
            this.panel1.Controls.Add(this.Op2Tb);
            this.panel1.Controls.Add(this.Op1Tb);
            this.panel1.Controls.Add(this.QuestionTb);
            this.panel1.Controls.Add(this.LvCb);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.QuestText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Quiz);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 999);
            this.panel1.TabIndex = 2;
            // 
            // QuestionDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.QuestionDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.QuestionDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.QuestionDGV.BackgroundColor = System.Drawing.Color.White;
            this.QuestionDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuestionDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.QuestionDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.QuestionDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.QuestionDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuestionDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.QuestionDGV.EnableHeadersVisualStyles = false;
            this.QuestionDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.QuestionDGV.Location = new System.Drawing.Point(12, 561);
            this.QuestionDGV.Name = "QuestionDGV";
            this.QuestionDGV.RowHeadersVisible = false;
            this.QuestionDGV.RowHeadersWidth = 62;
            this.QuestionDGV.RowTemplate.Height = 28;
            this.QuestionDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.QuestionDGV.Size = new System.Drawing.Size(1770, 426);
            this.QuestionDGV.TabIndex = 10;
            this.QuestionDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.QuestionDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.QuestionDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.QuestionDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.QuestionDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.QuestionDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.QuestionDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.QuestionDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.QuestionDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.QuestionDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.QuestionDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.QuestionDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.QuestionDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.QuestionDGV.ThemeStyle.ReadOnly = false;
            this.QuestionDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.QuestionDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.QuestionDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.QuestionDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.QuestionDGV.ThemeStyle.RowsStyle.Height = 28;
            this.QuestionDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.QuestionDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.QuestionDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuestionDGV_CellContentClick);
            // 
            // ResetBtn
            // 
            this.ResetBtn.ActiveBorderThickness = 1;
            this.ResetBtn.ActiveCornerRadius = 20;
            this.ResetBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ResetBtn.ActiveForecolor = System.Drawing.Color.White;
            this.ResetBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ResetBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ResetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResetBtn.BackgroundImage")));
            this.ResetBtn.ButtonText = "Reset";
            this.ResetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.ResetBtn.IdleBorderThickness = 1;
            this.ResetBtn.IdleCornerRadius = 20;
            this.ResetBtn.IdleFillColor = System.Drawing.Color.White;
            this.ResetBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ResetBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ResetBtn.Location = new System.Drawing.Point(1246, 371);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(122, 39);
            this.ResetBtn.TabIndex = 9;
            this.ResetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.ActiveBorderThickness = 1;
            this.EditBtn.ActiveCornerRadius = 20;
            this.EditBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EditBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.ButtonText = "Edit";
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleCornerRadius = 20;
            this.EditBtn.IdleFillColor = System.Drawing.Color.White;
            this.EditBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.EditBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.Location = new System.Drawing.Point(826, 371);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(122, 39);
            this.EditBtn.TabIndex = 9;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.ActiveBorderThickness = 1;
            this.SaveBtn.ActiveCornerRadius = 20;
            this.SaveBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SaveBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.ButtonText = "Save";
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.IdleBorderThickness = 1;
            this.SaveBtn.IdleCornerRadius = 20;
            this.SaveBtn.IdleFillColor = System.Drawing.Color.White;
            this.SaveBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.Location = new System.Drawing.Point(406, 371);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(122, 39);
            this.SaveBtn.TabIndex = 9;
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AnswerTb
            // 
            this.AnswerTb.BackColor = System.Drawing.SystemColors.Window;
            this.AnswerTb.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.AnswerTb.BorderThickness = 2;
            this.AnswerTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AnswerTb.DefaultText = "";
            this.AnswerTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AnswerTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AnswerTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AnswerTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AnswerTb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AnswerTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnswerTb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTb.ForeColor = System.Drawing.Color.Red;
            this.AnswerTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AnswerTb.Location = new System.Drawing.Point(1236, 295);
            this.AnswerTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AnswerTb.Name = "AnswerTb";
            this.AnswerTb.PasswordChar = '\0';
            this.AnswerTb.PlaceholderForeColor = System.Drawing.Color.White;
            this.AnswerTb.PlaceholderText = "Answer";
            this.AnswerTb.SelectedText = "";
            this.AnswerTb.Size = new System.Drawing.Size(156, 31);
            this.AnswerTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.AnswerTb.TabIndex = 8;
            // 
            // Op4Tb
            // 
            this.Op4Tb.BackColor = System.Drawing.SystemColors.Window;
            this.Op4Tb.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.Op4Tb.BorderThickness = 2;
            this.Op4Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Op4Tb.DefaultText = "";
            this.Op4Tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Op4Tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Op4Tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op4Tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op4Tb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Op4Tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op4Tb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Op4Tb.ForeColor = System.Drawing.Color.Red;
            this.Op4Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op4Tb.Location = new System.Drawing.Point(833, 284);
            this.Op4Tb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Op4Tb.Name = "Op4Tb";
            this.Op4Tb.PasswordChar = '\0';
            this.Op4Tb.PlaceholderForeColor = System.Drawing.Color.White;
            this.Op4Tb.PlaceholderText = "Option 4";
            this.Op4Tb.SelectedText = "";
            this.Op4Tb.Size = new System.Drawing.Size(156, 31);
            this.Op4Tb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Op4Tb.TabIndex = 8;
            // 
            // Op3Tb
            // 
            this.Op3Tb.BackColor = System.Drawing.SystemColors.Window;
            this.Op3Tb.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.Op3Tb.BorderThickness = 2;
            this.Op3Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Op3Tb.DefaultText = "";
            this.Op3Tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Op3Tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Op3Tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op3Tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op3Tb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Op3Tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op3Tb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Op3Tb.ForeColor = System.Drawing.Color.Red;
            this.Op3Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op3Tb.Location = new System.Drawing.Point(406, 274);
            this.Op3Tb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Op3Tb.Name = "Op3Tb";
            this.Op3Tb.PasswordChar = '\0';
            this.Op3Tb.PlaceholderForeColor = System.Drawing.Color.White;
            this.Op3Tb.PlaceholderText = "Option 3";
            this.Op3Tb.SelectedText = "";
            this.Op3Tb.Size = new System.Drawing.Size(156, 31);
            this.Op3Tb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Op3Tb.TabIndex = 8;
            // 
            // Op2Tb
            // 
            this.Op2Tb.BackColor = System.Drawing.SystemColors.Window;
            this.Op2Tb.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.Op2Tb.BorderThickness = 2;
            this.Op2Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Op2Tb.DefaultText = "";
            this.Op2Tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Op2Tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Op2Tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op2Tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op2Tb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Op2Tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op2Tb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Op2Tb.ForeColor = System.Drawing.Color.Red;
            this.Op2Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op2Tb.Location = new System.Drawing.Point(1236, 116);
            this.Op2Tb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Op2Tb.Name = "Op2Tb";
            this.Op2Tb.PasswordChar = '\0';
            this.Op2Tb.PlaceholderForeColor = System.Drawing.Color.White;
            this.Op2Tb.PlaceholderText = "Option 2";
            this.Op2Tb.SelectedText = "";
            this.Op2Tb.Size = new System.Drawing.Size(156, 31);
            this.Op2Tb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Op2Tb.TabIndex = 8;
            // 
            // Op1Tb
            // 
            this.Op1Tb.BackColor = System.Drawing.SystemColors.Window;
            this.Op1Tb.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.Op1Tb.BorderThickness = 2;
            this.Op1Tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Op1Tb.DefaultText = "";
            this.Op1Tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Op1Tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Op1Tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op1Tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Op1Tb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Op1Tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op1Tb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Op1Tb.ForeColor = System.Drawing.Color.Red;
            this.Op1Tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Op1Tb.Location = new System.Drawing.Point(833, 116);
            this.Op1Tb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Op1Tb.Name = "Op1Tb";
            this.Op1Tb.PasswordChar = '\0';
            this.Op1Tb.PlaceholderForeColor = System.Drawing.Color.White;
            this.Op1Tb.PlaceholderText = "Option 1";
            this.Op1Tb.SelectedText = "";
            this.Op1Tb.Size = new System.Drawing.Size(156, 31);
            this.Op1Tb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Op1Tb.TabIndex = 8;
            // 
            // QuestionTb
            // 
            this.QuestionTb.BackColor = System.Drawing.SystemColors.Window;
            this.QuestionTb.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.QuestionTb.BorderThickness = 2;
            this.QuestionTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QuestionTb.DefaultText = "";
            this.QuestionTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QuestionTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QuestionTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuestionTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QuestionTb.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.QuestionTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuestionTb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTb.ForeColor = System.Drawing.Color.Red;
            this.QuestionTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QuestionTb.Location = new System.Drawing.Point(406, 116);
            this.QuestionTb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.QuestionTb.Name = "QuestionTb";
            this.QuestionTb.PasswordChar = '\0';
            this.QuestionTb.PlaceholderForeColor = System.Drawing.Color.White;
            this.QuestionTb.PlaceholderText = "Questions";
            this.QuestionTb.SelectedText = "";
            this.QuestionTb.Size = new System.Drawing.Size(156, 31);
            this.QuestionTb.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.QuestionTb.TabIndex = 8;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 999);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox LvCb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label QuestText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Quiz;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox QuestionTb;
        private Guna.UI2.WinForms.Guna2TextBox AnswerTb;
        private Guna.UI2.WinForms.Guna2TextBox Op4Tb;
        private Guna.UI2.WinForms.Guna2TextBox Op3Tb;
        private Guna.UI2.WinForms.Guna2TextBox Op2Tb;
        private Guna.UI2.WinForms.Guna2TextBox Op1Tb;
        private Bunifu.Framework.UI.BunifuThinButton2 ResetBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBtn;
        private Guna.UI2.WinForms.Guna2DataGridView QuestionDGV;
    }
}