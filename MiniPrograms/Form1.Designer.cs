namespace MiniPrograms
{
  partial class MainForm
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.tsmiMenu = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiNote = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiInsertTime = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsmiNoteSave = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiNoteLoad = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.btnChangeFromTo = new System.Windows.Forms.Button();
      this.btnConvert = new System.Windows.Forms.Button();
      this.tbxTo = new System.Windows.Forms.TextBox();
      this.tbxFrom = new System.Windows.Forms.TextBox();
      this.cbxTo = new System.Windows.Forms.ComboBox();
      this.cbxFrom = new System.Windows.Forms.ComboBox();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.tbxPassword = new System.Windows.Forms.TextBox();
      this.btnPassCreate = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.nudPassLength = new System.Windows.Forms.NumericUpDown();
      this.chlbPassword = new System.Windows.Forms.CheckedListBox();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.tbxNote = new System.Windows.Forms.RichTextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.chbxRandomChar = new System.Windows.Forms.CheckBox();
      this.chbxRandom = new System.Windows.Forms.CheckBox();
      this.btnRdmCopy = new System.Windows.Forms.Button();
      this.btnRndClear = new System.Windows.Forms.Button();
      this.tbx_Random = new System.Windows.Forms.TextBox();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblRandom = new System.Windows.Forms.Label();
      this.btnRandom = new System.Windows.Forms.Button();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.lblCount = new System.Windows.Forms.Label();
      this.btnReset = new System.Windows.Forms.Button();
      this.btnMinus = new System.Windows.Forms.Button();
      this.btnPlus = new System.Windows.Forms.Button();
      this.cbx_Metrica = new System.Windows.Forms.ComboBox();
      this.menuStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage5.SuspendLayout();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).BeginInit();
      this.tabPage3.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.tabPage1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenu,
            this.tsmiNote,
            this.tsmiHelp});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(261, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // tsmiMenu
      // 
      this.tsmiMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
      this.tsmiMenu.Name = "tsmiMenu";
      this.tsmiMenu.Size = new System.Drawing.Size(48, 20);
      this.tsmiMenu.Text = "Файл";
      // 
      // tsmiExit
      // 
      this.tsmiExit.Name = "tsmiExit";
      this.tsmiExit.Size = new System.Drawing.Size(108, 22);
      this.tsmiExit.Text = "Выход";
      this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
      // 
      // tsmiNote
      // 
      this.tsmiNote.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiInsertTime,
            this.toolStripMenuItem1,
            this.tsmiNoteSave,
            this.tsmiNoteLoad});
      this.tsmiNote.Name = "tsmiNote";
      this.tsmiNote.Size = new System.Drawing.Size(65, 20);
      this.tsmiNote.Text = "Блокнот";
      // 
      // tsmiInsertDate
      // 
      this.tsmiInsertDate.Name = "tsmiInsertDate";
      this.tsmiInsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
      this.tsmiInsertDate.Size = new System.Drawing.Size(232, 22);
      this.tsmiInsertDate.Text = "Вставить дату";
      this.tsmiInsertDate.Click += new System.EventHandler(this.tsmiInsertDate_Click);
      // 
      // tsmiInsertTime
      // 
      this.tsmiInsertTime.Name = "tsmiInsertTime";
      this.tsmiInsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
      this.tsmiInsertTime.Size = new System.Drawing.Size(232, 22);
      this.tsmiInsertTime.Text = "Вставить время";
      this.tsmiInsertTime.Click += new System.EventHandler(this.tsmiInsertTime_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
      // 
      // tsmiNoteSave
      // 
      this.tsmiNoteSave.Name = "tsmiNoteSave";
      this.tsmiNoteSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.tsmiNoteSave.Size = new System.Drawing.Size(232, 22);
      this.tsmiNoteSave.Text = "Созранить";
      this.tsmiNoteSave.Click += new System.EventHandler(this.tsmiNoteSave_Click);
      // 
      // tsmiNoteLoad
      // 
      this.tsmiNoteLoad.Name = "tsmiNoteLoad";
      this.tsmiNoteLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
      this.tsmiNoteLoad.Size = new System.Drawing.Size(232, 22);
      this.tsmiNoteLoad.Text = "Загрузить";
      this.tsmiNoteLoad.Click += new System.EventHandler(this.tsmiNoteLoad_Click);
      // 
      // tsmiHelp
      // 
      this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
      this.tsmiHelp.Name = "tsmiHelp";
      this.tsmiHelp.Size = new System.Drawing.Size(68, 20);
      this.tsmiHelp.Text = "Помощь";
      // 
      // tsmiAbout
      // 
      this.tsmiAbout.Name = "tsmiAbout";
      this.tsmiAbout.Size = new System.Drawing.Size(149, 22);
      this.tsmiAbout.Text = "О программе";
      this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage5);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 24);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(261, 191);
      this.tabControl1.TabIndex = 1;
      // 
      // tabPage5
      // 
      this.tabPage5.Controls.Add(this.cbx_Metrica);
      this.tabPage5.Controls.Add(this.btnChangeFromTo);
      this.tabPage5.Controls.Add(this.btnConvert);
      this.tabPage5.Controls.Add(this.tbxTo);
      this.tabPage5.Controls.Add(this.tbxFrom);
      this.tabPage5.Controls.Add(this.cbxTo);
      this.tabPage5.Controls.Add(this.cbxFrom);
      this.tabPage5.Location = new System.Drawing.Point(4, 22);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage5.Size = new System.Drawing.Size(253, 165);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "Конвертер";
      this.tabPage5.UseVisualStyleBackColor = true;
      // 
      // btnChangeFromTo
      // 
      this.btnChangeFromTo.Location = new System.Drawing.Point(89, 47);
      this.btnChangeFromTo.Name = "btnChangeFromTo";
      this.btnChangeFromTo.Size = new System.Drawing.Size(75, 20);
      this.btnChangeFromTo.TabIndex = 5;
      this.btnChangeFromTo.Text = "<-->";
      this.btnChangeFromTo.UseVisualStyleBackColor = true;
      this.btnChangeFromTo.Click += new System.EventHandler(this.btnChangeFromTo_Click);
      // 
      // btnConvert
      // 
      this.btnConvert.Location = new System.Drawing.Point(89, 73);
      this.btnConvert.Name = "btnConvert";
      this.btnConvert.Size = new System.Drawing.Size(75, 20);
      this.btnConvert.TabIndex = 4;
      this.btnConvert.Text = "Конвертировать";
      this.btnConvert.UseVisualStyleBackColor = true;
      this.btnConvert.Click += new System.EventHandler(this.converting);
      // 
      // tbxTo
      // 
      this.tbxTo.Location = new System.Drawing.Point(170, 73);
      this.tbxTo.Name = "tbxTo";
      this.tbxTo.ReadOnly = true;
      this.tbxTo.Size = new System.Drawing.Size(64, 20);
      this.tbxTo.TabIndex = 3;
      // 
      // tbxFrom
      // 
      this.tbxFrom.Location = new System.Drawing.Point(19, 73);
      this.tbxFrom.Name = "tbxFrom";
      this.tbxFrom.Size = new System.Drawing.Size(64, 20);
      this.tbxFrom.TabIndex = 2;
      this.tbxFrom.Text = "1";
      this.tbxFrom.TextChanged += new System.EventHandler(this.converting);
      // 
      // cbxTo
      // 
      this.cbxTo.FormattingEnabled = true;
      this.cbxTo.Items.AddRange(new object[] {
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "милли"});
      this.cbxTo.Location = new System.Drawing.Point(170, 46);
      this.cbxTo.Name = "cbxTo";
      this.cbxTo.Size = new System.Drawing.Size(64, 21);
      this.cbxTo.TabIndex = 1;
      this.cbxTo.Text = "мм";
      this.cbxTo.TextChanged += new System.EventHandler(this.converting);
      // 
      // cbxFrom
      // 
      this.cbxFrom.FormattingEnabled = true;
      this.cbxFrom.Items.AddRange(new object[] {
            "мм",
            "см",
            "дм",
            "м",
            "км",
            "милли"});
      this.cbxFrom.Location = new System.Drawing.Point(19, 46);
      this.cbxFrom.Name = "cbxFrom";
      this.cbxFrom.Size = new System.Drawing.Size(64, 21);
      this.cbxFrom.TabIndex = 0;
      this.cbxFrom.Text = "мм";
      this.cbxFrom.TextChanged += new System.EventHandler(this.converting);
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.tbxPassword);
      this.tabPage4.Controls.Add(this.btnPassCreate);
      this.tabPage4.Controls.Add(this.label1);
      this.tabPage4.Controls.Add(this.nudPassLength);
      this.tabPage4.Controls.Add(this.chlbPassword);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Size = new System.Drawing.Size(253, 165);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "Пароли";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // tbxPassword
      // 
      this.tbxPassword.Location = new System.Drawing.Point(8, 131);
      this.tbxPassword.Name = "tbxPassword";
      this.tbxPassword.Size = new System.Drawing.Size(237, 20);
      this.tbxPassword.TabIndex = 4;
      // 
      // btnPassCreate
      // 
      this.btnPassCreate.Location = new System.Drawing.Point(8, 102);
      this.btnPassCreate.Name = "btnPassCreate";
      this.btnPassCreate.Size = new System.Drawing.Size(129, 23);
      this.btnPassCreate.TabIndex = 3;
      this.btnPassCreate.Text = "Создать пароль";
      this.btnPassCreate.UseVisualStyleBackColor = true;
      this.btnPassCreate.Click += new System.EventHandler(this.btnPassCreate_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(5, 75);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(79, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Длина пароля";
      // 
      // nudPassLength
      // 
      this.nudPassLength.Location = new System.Drawing.Point(93, 73);
      this.nudPassLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
      this.nudPassLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudPassLength.Name = "nudPassLength";
      this.nudPassLength.Size = new System.Drawing.Size(44, 20);
      this.nudPassLength.TabIndex = 1;
      this.nudPassLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
      // 
      // chlbPassword
      // 
      this.chlbPassword.CheckOnClick = true;
      this.chlbPassword.FormattingEnabled = true;
      this.chlbPassword.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы"});
      this.chlbPassword.Location = new System.Drawing.Point(3, 3);
      this.chlbPassword.Name = "chlbPassword";
      this.chlbPassword.Size = new System.Drawing.Size(242, 64);
      this.chlbPassword.TabIndex = 0;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.tbxNote);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(253, 165);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Блокнот";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // tbxNote
      // 
      this.tbxNote.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbxNote.Location = new System.Drawing.Point(3, 3);
      this.tbxNote.Name = "tbxNote";
      this.tbxNote.Size = new System.Drawing.Size(247, 159);
      this.tbxNote.TabIndex = 0;
      this.tbxNote.Text = "";
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.chbxRandomChar);
      this.tabPage2.Controls.Add(this.chbxRandom);
      this.tabPage2.Controls.Add(this.btnRdmCopy);
      this.tabPage2.Controls.Add(this.btnRndClear);
      this.tabPage2.Controls.Add(this.tbx_Random);
      this.tabPage2.Controls.Add(this.numericUpDown2);
      this.tabPage2.Controls.Add(this.numericUpDown1);
      this.tabPage2.Controls.Add(this.label3);
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Controls.Add(this.lblRandom);
      this.tabPage2.Controls.Add(this.btnRandom);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(253, 165);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Генератор";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // chbxRandomChar
      // 
      this.chbxRandomChar.AutoSize = true;
      this.chbxRandomChar.Location = new System.Drawing.Point(9, 140);
      this.chbxRandomChar.Name = "chbxRandomChar";
      this.chbxRandomChar.Size = new System.Drawing.Size(73, 17);
      this.chbxRandomChar.TabIndex = 10;
      this.chbxRandomChar.Text = "Символы";
      this.chbxRandomChar.UseVisualStyleBackColor = true;
      // 
      // chbxRandom
      // 
      this.chbxRandom.AutoSize = true;
      this.chbxRandom.Location = new System.Drawing.Point(9, 118);
      this.chbxRandom.Name = "chbxRandom";
      this.chbxRandom.Size = new System.Drawing.Size(107, 17);
      this.chbxRandom.TabIndex = 9;
      this.chbxRandom.Text = "Без повторений";
      this.chbxRandom.UseVisualStyleBackColor = true;
      // 
      // btnRdmCopy
      // 
      this.btnRdmCopy.Location = new System.Drawing.Point(9, 89);
      this.btnRdmCopy.Name = "btnRdmCopy";
      this.btnRdmCopy.Size = new System.Drawing.Size(107, 23);
      this.btnRdmCopy.TabIndex = 8;
      this.btnRdmCopy.Text = "Скопировать";
      this.btnRdmCopy.UseVisualStyleBackColor = true;
      this.btnRdmCopy.Click += new System.EventHandler(this.btnRdmCopy_Click);
      // 
      // btnRndClear
      // 
      this.btnRndClear.Location = new System.Drawing.Point(9, 60);
      this.btnRndClear.Name = "btnRndClear";
      this.btnRndClear.Size = new System.Drawing.Size(107, 23);
      this.btnRndClear.TabIndex = 7;
      this.btnRndClear.Text = "Очистить";
      this.btnRndClear.UseVisualStyleBackColor = true;
      this.btnRndClear.Click += new System.EventHandler(this.btnRndClear_Click);
      // 
      // tbx_Random
      // 
      this.tbx_Random.Location = new System.Drawing.Point(123, 52);
      this.tbx_Random.Multiline = true;
      this.tbx_Random.Name = "tbx_Random";
      this.tbx_Random.ReadOnly = true;
      this.tbx_Random.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.tbx_Random.Size = new System.Drawing.Size(93, 107);
      this.tbx_Random.TabIndex = 6;
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Location = new System.Drawing.Point(51, 34);
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(64, 20);
      this.numericUpDown2.TabIndex = 5;
      this.numericUpDown2.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(51, 8);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
      this.numericUpDown1.TabIndex = 4;
      this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 36);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(22, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "До";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 10);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(20, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "От";
      // 
      // lblRandom
      // 
      this.lblRandom.AutoSize = true;
      this.lblRandom.Location = new System.Drawing.Point(121, 36);
      this.lblRandom.Name = "lblRandom";
      this.lblRandom.Size = new System.Drawing.Size(13, 13);
      this.lblRandom.TabIndex = 1;
      this.lblRandom.Text = "0";
      // 
      // btnRandom
      // 
      this.btnRandom.Location = new System.Drawing.Point(121, 8);
      this.btnRandom.Name = "btnRandom";
      this.btnRandom.Size = new System.Drawing.Size(95, 20);
      this.btnRandom.TabIndex = 0;
      this.btnRandom.Text = "Задать";
      this.btnRandom.UseVisualStyleBackColor = true;
      this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.lblCount);
      this.tabPage1.Controls.Add(this.btnReset);
      this.tabPage1.Controls.Add(this.btnMinus);
      this.tabPage1.Controls.Add(this.btnPlus);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(253, 165);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Счётчик";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // lblCount
      // 
      this.lblCount.AutoSize = true;
      this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lblCount.Location = new System.Drawing.Point(116, 51);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(20, 24);
      this.lblCount.TabIndex = 3;
      this.lblCount.Text = "0";
      // 
      // btnReset
      // 
      this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnReset.Location = new System.Drawing.Point(8, 46);
      this.btnReset.Name = "btnReset";
      this.btnReset.Size = new System.Drawing.Size(81, 34);
      this.btnReset.TabIndex = 2;
      this.btnReset.Text = "Сброс";
      this.btnReset.UseVisualStyleBackColor = true;
      this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
      // 
      // btnMinus
      // 
      this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnMinus.Location = new System.Drawing.Point(120, 78);
      this.btnMinus.Name = "btnMinus";
      this.btnMinus.Size = new System.Drawing.Size(81, 34);
      this.btnMinus.TabIndex = 1;
      this.btnMinus.Text = "-";
      this.btnMinus.UseVisualStyleBackColor = true;
      this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
      // 
      // btnPlus
      // 
      this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btnPlus.Location = new System.Drawing.Point(120, 14);
      this.btnPlus.Name = "btnPlus";
      this.btnPlus.Size = new System.Drawing.Size(81, 34);
      this.btnPlus.TabIndex = 0;
      this.btnPlus.Text = "+";
      this.btnPlus.UseVisualStyleBackColor = true;
      this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
      // 
      // cbx_Metrica
      // 
      this.cbx_Metrica.AutoCompleteCustomSource.AddRange(new string[] {
            "Длина",
            "Вес"});
      this.cbx_Metrica.FormattingEnabled = true;
      this.cbx_Metrica.Items.AddRange(new object[] {
            "Длина",
            "Вес"});
      this.cbx_Metrica.Location = new System.Drawing.Point(89, 20);
      this.cbx_Metrica.Name = "cbx_Metrica";
      this.cbx_Metrica.Size = new System.Drawing.Size(75, 21);
      this.cbx_Metrica.TabIndex = 6;
      this.cbx_Metrica.SelectedIndexChanged += new System.EventHandler(this.cbx_Metrica_SelectedIndexChanged);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(261, 215);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "Мои утилиты";
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage5.ResumeLayout(false);
      this.tabPage5.PerformLayout();
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudPassLength)).EndInit();
      this.tabPage3.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem tsmiMenu;
    private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
    private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnMinus;
    private System.Windows.Forms.Button btnPlus;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblRandom;
    private System.Windows.Forms.Button btnRandom;
    private System.Windows.Forms.TextBox tbx_Random;
    private System.Windows.Forms.Button btnRndClear;
    private System.Windows.Forms.Button btnRdmCopy;
    private System.Windows.Forms.CheckBox chbxRandom;
    private System.Windows.Forms.ToolStripMenuItem tsmiNote;
    private System.Windows.Forms.ToolStripMenuItem tsmiInsertDate;
    private System.Windows.Forms.ToolStripMenuItem tsmiInsertTime;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.RichTextBox tbxNote;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem tsmiNoteSave;
    private System.Windows.Forms.ToolStripMenuItem tsmiNoteLoad;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.CheckedListBox chlbPassword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown nudPassLength;
    private System.Windows.Forms.TextBox tbxPassword;
    private System.Windows.Forms.Button btnPassCreate;
    private System.Windows.Forms.CheckBox chbxRandomChar;
    private System.Windows.Forms.TabPage tabPage5;
    private System.Windows.Forms.Button btnConvert;
    private System.Windows.Forms.TextBox tbxTo;
    private System.Windows.Forms.TextBox tbxFrom;
    private System.Windows.Forms.ComboBox cbxTo;
    private System.Windows.Forms.ComboBox cbxFrom;
    private System.Windows.Forms.Button btnChangeFromTo;
    private System.Windows.Forms.ComboBox cbx_Metrica;
  }
}

