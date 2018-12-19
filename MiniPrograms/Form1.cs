using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPrograms
{
  public partial class MainForm : Form
  {
    int count = 0;
    Random rnd;

    public MainForm()
    {
      InitializeComponent();
      rnd = new Random();
    }

    private void tsmi_Exit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void tsmi_About_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Программа содержит ряд небольших программ, " +
        "которые могут пригодиться в жизни.\nА главное научить меня " +
        "основам программирования на C#. \nАвтор Меженный Д.В.", "О программе");
    }

    private void btn_Plus_Click(object sender, EventArgs e)
    {
      count++;
      lbl_Count.Text = count.ToString();
    }

    private void btn_Minus_Click(object sender, EventArgs e)
    {
      count--;
      lbl_Count.Text = count.ToString();
    }

    private void btn_Reset_Click(object sender, EventArgs e)
    {
      count = 0;
      lbl_Count.Text = Convert.ToString(count);
    }

    private void btn_Random_Click(object sender, EventArgs e)
    {
      int n;
      n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);

      if (chbx_Random.Checked)
      {
        int i = 0;
        while (tbx_Random.Text.IndexOf(n.ToString()) != -1 && i <= 1000)
        {
          n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
          i++;
        }
        if (i <= 1000)
          tbx_Random.AppendText(n + "\n");
      }
      else tbx_Random.AppendText(n + "\n");
      lbl_Random.Text = n.ToString();
    }

    private void btn_RndClear_Click(object sender, EventArgs e)
    {
      tbx_Random.Clear();
    }

    private void btn_RdmCopy_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(tbx_Random.Text);
    }

    private void tsmi_InsertDate_Click(object sender, EventArgs e)
    {
      tbx_Note.AppendText(DateTime.Now.ToShortDateString());
    }

    private void tsmi_InsertTime_Click(object sender, EventArgs e)
    {
      tbx_Note.AppendText(DateTime.Now.ToShortTimeString());
    }

    private void tsmi_NoteSave_Click(object sender, EventArgs e)
    {
      try
      {
        tbx_Note.SaveFile("Notepad.rtf");
      }
      catch (Exception)
      {
        MessageBox.Show("Ошибка при сохранении");
      }
    }

    void LoadNote()
    {
      try
      {
        tbx_Note.LoadFile("Notepad.rtf");
      }
      catch (Exception)
      {
        MessageBox.Show("Ошибка при загрузке");
      }
    }

    private void tsmi_NoteLoad_Click(object sender, EventArgs e)
    {
      LoadNote();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      LoadNote();
    }
  }
}
