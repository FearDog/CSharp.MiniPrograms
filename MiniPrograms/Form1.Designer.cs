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
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
      this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_About = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.chbx_Random = new System.Windows.Forms.CheckBox();
      this.btn_RdmCopy = new System.Windows.Forms.Button();
      this.btn_RndClear = new System.Windows.Forms.Button();
      this.tbx_Random = new System.Windows.Forms.TextBox();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbl_Random = new System.Windows.Forms.Label();
      this.btn_Random = new System.Windows.Forms.Button();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.lbl_Count = new System.Windows.Forms.Label();
      this.btn_Reset = new System.Windows.Forms.Button();
      this.btn_Minus = new System.Windows.Forms.Button();
      this.btn_Plus = new System.Windows.Forms.Button();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.tbx_Note = new System.Windows.Forms.RichTextBox();
      this.tsmi_Note = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_InsertDate = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_InsertTime = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsmi_NoteSave = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_NoteLoad = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.tabPage1.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.tsmi_Note,
            this.помощьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(261, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Exit});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // tsmi_Exit
      // 
      this.tsmi_Exit.Name = "tsmi_Exit";
      this.tsmi_Exit.Size = new System.Drawing.Size(108, 22);
      this.tsmi_Exit.Text = "Выход";
      this.tsmi_Exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
      // 
      // помощьToolStripMenuItem
      // 
      this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_About});
      this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
      this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
      this.помощьToolStripMenuItem.Text = "Помощь";
      // 
      // tsmi_About
      // 
      this.tsmi_About.Name = "tsmi_About";
      this.tsmi_About.Size = new System.Drawing.Size(149, 22);
      this.tsmi_About.Text = "О программе";
      this.tsmi_About.Click += new System.EventHandler(this.tsmi_About_Click);
      // 
      // tabControl1
      // 
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
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.chbx_Random);
      this.tabPage2.Controls.Add(this.btn_RdmCopy);
      this.tabPage2.Controls.Add(this.btn_RndClear);
      this.tabPage2.Controls.Add(this.tbx_Random);
      this.tabPage2.Controls.Add(this.numericUpDown2);
      this.tabPage2.Controls.Add(this.numericUpDown1);
      this.tabPage2.Controls.Add(this.label3);
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Controls.Add(this.lbl_Random);
      this.tabPage2.Controls.Add(this.btn_Random);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(253, 165);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Генератор";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // chbx_Random
      // 
      this.chbx_Random.AutoSize = true;
      this.chbx_Random.Location = new System.Drawing.Point(9, 118);
      this.chbx_Random.Name = "chbx_Random";
      this.chbx_Random.Size = new System.Drawing.Size(107, 17);
      this.chbx_Random.TabIndex = 9;
      this.chbx_Random.Text = "Без повторений";
      this.chbx_Random.UseVisualStyleBackColor = true;
      // 
      // btn_RdmCopy
      // 
      this.btn_RdmCopy.Location = new System.Drawing.Point(9, 89);
      this.btn_RdmCopy.Name = "btn_RdmCopy";
      this.btn_RdmCopy.Size = new System.Drawing.Size(107, 23);
      this.btn_RdmCopy.TabIndex = 8;
      this.btn_RdmCopy.Text = "Скопировать";
      this.btn_RdmCopy.UseVisualStyleBackColor = true;
      this.btn_RdmCopy.Click += new System.EventHandler(this.btn_RdmCopy_Click);
      // 
      // btn_RndClear
      // 
      this.btn_RndClear.Location = new System.Drawing.Point(9, 60);
      this.btn_RndClear.Name = "btn_RndClear";
      this.btn_RndClear.Size = new System.Drawing.Size(107, 23);
      this.btn_RndClear.TabIndex = 7;
      this.btn_RndClear.Text = "Очистить";
      this.btn_RndClear.UseVisualStyleBackColor = true;
      this.btn_RndClear.Click += new System.EventHandler(this.btn_RndClear_Click);
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
      // lbl_Random
      // 
      this.lbl_Random.AutoSize = true;
      this.lbl_Random.Location = new System.Drawing.Point(121, 36);
      this.lbl_Random.Name = "lbl_Random";
      this.lbl_Random.Size = new System.Drawing.Size(13, 13);
      this.lbl_Random.TabIndex = 1;
      this.lbl_Random.Text = "0";
      // 
      // btn_Random
      // 
      this.btn_Random.Location = new System.Drawing.Point(121, 8);
      this.btn_Random.Name = "btn_Random";
      this.btn_Random.Size = new System.Drawing.Size(95, 20);
      this.btn_Random.TabIndex = 0;
      this.btn_Random.Text = "Задать";
      this.btn_Random.UseVisualStyleBackColor = true;
      this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.lbl_Count);
      this.tabPage1.Controls.Add(this.btn_Reset);
      this.tabPage1.Controls.Add(this.btn_Minus);
      this.tabPage1.Controls.Add(this.btn_Plus);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(253, 165);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Счётчик";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // lbl_Count
      // 
      this.lbl_Count.AutoSize = true;
      this.lbl_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.lbl_Count.Location = new System.Drawing.Point(116, 51);
      this.lbl_Count.Name = "lbl_Count";
      this.lbl_Count.Size = new System.Drawing.Size(20, 24);
      this.lbl_Count.TabIndex = 3;
      this.lbl_Count.Text = "0";
      // 
      // btn_Reset
      // 
      this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btn_Reset.Location = new System.Drawing.Point(8, 46);
      this.btn_Reset.Name = "btn_Reset";
      this.btn_Reset.Size = new System.Drawing.Size(81, 34);
      this.btn_Reset.TabIndex = 2;
      this.btn_Reset.Text = "Сброс";
      this.btn_Reset.UseVisualStyleBackColor = true;
      this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
      // 
      // btn_Minus
      // 
      this.btn_Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btn_Minus.Location = new System.Drawing.Point(120, 78);
      this.btn_Minus.Name = "btn_Minus";
      this.btn_Minus.Size = new System.Drawing.Size(81, 34);
      this.btn_Minus.TabIndex = 1;
      this.btn_Minus.Text = "-";
      this.btn_Minus.UseVisualStyleBackColor = true;
      this.btn_Minus.Click += new System.EventHandler(this.btn_Minus_Click);
      // 
      // btn_Plus
      // 
      this.btn_Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.btn_Plus.Location = new System.Drawing.Point(120, 14);
      this.btn_Plus.Name = "btn_Plus";
      this.btn_Plus.Size = new System.Drawing.Size(81, 34);
      this.btn_Plus.TabIndex = 0;
      this.btn_Plus.Text = "+";
      this.btn_Plus.UseVisualStyleBackColor = true;
      this.btn_Plus.Click += new System.EventHandler(this.btn_Plus_Click);
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.tbx_Note);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(253, 165);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Блокнот";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // tbx_Note
      // 
      this.tbx_Note.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbx_Note.Location = new System.Drawing.Point(3, 3);
      this.tbx_Note.Name = "tbx_Note";
      this.tbx_Note.Size = new System.Drawing.Size(247, 159);
      this.tbx_Note.TabIndex = 0;
      this.tbx_Note.Text = "";
      // 
      // tsmi_Note
      // 
      this.tsmi_Note.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_InsertDate,
            this.tsmi_InsertTime,
            this.toolStripMenuItem1,
            this.tsmi_NoteSave,
            this.tsmi_NoteLoad});
      this.tsmi_Note.Name = "tsmi_Note";
      this.tsmi_Note.Size = new System.Drawing.Size(65, 20);
      this.tsmi_Note.Text = "Блокнот";
      // 
      // tsmi_InsertDate
      // 
      this.tsmi_InsertDate.Name = "tsmi_InsertDate";
      this.tsmi_InsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
      this.tsmi_InsertDate.Size = new System.Drawing.Size(232, 22);
      this.tsmi_InsertDate.Text = "Вставить дату";
      this.tsmi_InsertDate.Click += new System.EventHandler(this.tsmi_InsertDate_Click);
      // 
      // tsmi_InsertTime
      // 
      this.tsmi_InsertTime.Name = "tsmi_InsertTime";
      this.tsmi_InsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
      this.tsmi_InsertTime.Size = new System.Drawing.Size(232, 22);
      this.tsmi_InsertTime.Text = "Вставить время";
      this.tsmi_InsertTime.Click += new System.EventHandler(this.tsmi_InsertTime_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(229, 6);
      // 
      // tsmi_NoteSave
      // 
      this.tsmi_NoteSave.Name = "tsmi_NoteSave";
      this.tsmi_NoteSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.tsmi_NoteSave.Size = new System.Drawing.Size(232, 22);
      this.tsmi_NoteSave.Text = "Созранить";
      this.tsmi_NoteSave.Click += new System.EventHandler(this.tsmi_NoteSave_Click);
      // 
      // tsmi_NoteLoad
      // 
      this.tsmi_NoteLoad.Name = "tsmi_NoteLoad";
      this.tsmi_NoteLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
      this.tsmi_NoteLoad.Size = new System.Drawing.Size(232, 22);
      this.tsmi_NoteLoad.Text = "Загрузить";
      this.tsmi_NoteLoad.Click += new System.EventHandler(this.tsmi_NoteLoad_Click);
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
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage3.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
    private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tsmi_About;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Label lbl_Count;
    private System.Windows.Forms.Button btn_Reset;
    private System.Windows.Forms.Button btn_Minus;
    private System.Windows.Forms.Button btn_Plus;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.NumericUpDown numericUpDown2;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lbl_Random;
    private System.Windows.Forms.Button btn_Random;
    private System.Windows.Forms.TextBox tbx_Random;
    private System.Windows.Forms.Button btn_RndClear;
    private System.Windows.Forms.Button btn_RdmCopy;
    private System.Windows.Forms.CheckBox chbx_Random;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Note;
    private System.Windows.Forms.ToolStripMenuItem tsmi_InsertDate;
    private System.Windows.Forms.ToolStripMenuItem tsmi_InsertTime;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.RichTextBox tbx_Note;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem tsmi_NoteSave;
    private System.Windows.Forms.ToolStripMenuItem tsmi_NoteLoad;
  }
}

