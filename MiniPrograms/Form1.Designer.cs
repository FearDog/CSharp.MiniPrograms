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
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(302, 24);
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(302, 187);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "Мои утилиты";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tsmi_Exit;
    private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem tsmi_About;
  }
}

