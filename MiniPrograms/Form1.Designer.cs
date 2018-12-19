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
      this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_Exit = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmi_About = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btn_Plus = new System.Windows.Forms.Button();
      this.btn_Minus = new System.Windows.Forms.Button();
      this.btn_Reset = new System.Windows.Forms.Button();
      this.lbl_Count = new System.Windows.Forms.Label();
      this.btn_Random = new System.Windows.Forms.Button();
      this.lbl_Random = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
      this.menuStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(229, 24);
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
      // помощьToolStripMenuItem
      // 
      this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_About});
      this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
      this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
      this.помощьToolStripMenuItem.Text = "Помощь";
      // 
      // tsmi_Exit
      // 
      this.tsmi_Exit.Name = "tsmi_Exit";
      this.tsmi_Exit.Size = new System.Drawing.Size(180, 22);
      this.tsmi_Exit.Text = "Выход";
      this.tsmi_Exit.Click += new System.EventHandler(this.tsmi_Exit_Click);
      // 
      // tsmi_About
      // 
      this.tsmi_About.Name = "tsmi_About";
      this.tsmi_About.Size = new System.Drawing.Size(180, 22);
      this.tsmi_About.Text = "О программе";
      this.tsmi_About.Click += new System.EventHandler(this.tsmi_About_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 24);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(229, 157);
      this.tabControl1.TabIndex = 1;
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
      this.tabPage1.Size = new System.Drawing.Size(221, 131);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Счётчик";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.numericUpDown2);
      this.tabPage2.Controls.Add(this.numericUpDown1);
      this.tabPage2.Controls.Add(this.label3);
      this.tabPage2.Controls.Add(this.label2);
      this.tabPage2.Controls.Add(this.lbl_Random);
      this.tabPage2.Controls.Add(this.btn_Random);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(221, 131);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Генератор";
      this.tabPage2.UseVisualStyleBackColor = true;
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
      // btn_Random
      // 
      this.btn_Random.Location = new System.Drawing.Point(102, 8);
      this.btn_Random.Name = "btn_Random";
      this.btn_Random.Size = new System.Drawing.Size(77, 20);
      this.btn_Random.TabIndex = 0;
      this.btn_Random.Text = "Задать";
      this.btn_Random.UseVisualStyleBackColor = true;
      this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
      // 
      // lbl_Random
      // 
      this.lbl_Random.AutoSize = true;
      this.lbl_Random.Location = new System.Drawing.Point(101, 36);
      this.lbl_Random.Name = "lbl_Random";
      this.lbl_Random.Size = new System.Drawing.Size(35, 13);
      this.lbl_Random.TabIndex = 1;
      this.lbl_Random.Text = "label1";
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
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 36);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(22, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "До";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.Location = new System.Drawing.Point(32, 8);
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
      this.numericUpDown1.TabIndex = 4;
      this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // numericUpDown2
      // 
      this.numericUpDown2.Location = new System.Drawing.Point(32, 34);
      this.numericUpDown2.Name = "numericUpDown2";
      this.numericUpDown2.Size = new System.Drawing.Size(63, 20);
      this.numericUpDown2.TabIndex = 5;
      this.numericUpDown2.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(229, 181);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "Мои утилиты";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
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
  }
}

