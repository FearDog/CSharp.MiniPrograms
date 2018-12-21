using System;
using System.Windows.Forms;

namespace MiniPrograms
{
  public partial class MainForm : Form
  {
    int count = 0;
    Random rnd;
    char[] spec_Char = new char[] {'!','@','#','$','%','^','&','*','(',')','_','-','+','=','?','.',','};

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
      int n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
      int i = 0;
      string s = "";

      if (chbx_Random.Checked)
      {
        while (((chbx_RandomChar.Checked && tbx_Random.Text.IndexOf(Convert.ToChar(n).ToString()) != -1) ||
         (!chbx_RandomChar.Checked && tbx_Random.Text.IndexOf(n.ToString()) != -1)) && i <= 1000)
        {
          n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
          i++;
        }
      }

      if (i <= 1000)
      {
        if (chbx_RandomChar.Checked)
          s = Convert.ToChar(n).ToString();
        else
          s = n.ToString();
        tbx_Random.AppendText(s + "\n");
      }
      lbl_Random.Text = s;
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
      chlb_Password.SetItemChecked(0, true);
      chlb_Password.SetItemChecked(1, true);
    }

    private void btn_PassCreate_Click(object sender, EventArgs e)
    {
      if (chlb_Password.CheckedItems.Count <= 0) return;
      string pass = "";
      for (int i = 0; i < nud_PassLength.Value; i++)
      {
        int n = rnd.Next(0, chlb_Password.CheckedItems.Count);
        string s = chlb_Password.CheckedItems[n].ToString();
        switch (s)
        {
          case "Цифры":
            pass += rnd.Next(10).ToString();
            break;
          case "Прописные буквы":
            pass += Convert.ToChar(rnd.Next(65,90));
            break;
          case "Строчные буквы":
            pass += Convert.ToChar(rnd.Next(97, 122));
            break;
          case "Спец. символы":
            pass += spec_Char[rnd.Next(spec_Char.Length)];
            break;
        }
        tbx_Password.Text = pass;
        Clipboard.SetText(pass);
      }
    }
  }
}
