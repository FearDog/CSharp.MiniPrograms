using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace MiniPrograms
{
  public partial class MainForm : Form
  {
    int count = 0;
    Random rnd;
    char[] spec_Char = new char[] { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=', '?', '.', ',' };
    Dictionary<string, double> metrica;

    string[] lengthName = { "мм", "см", "дм", "м", "км", "милли" };
    double[] lengthValue = { 1, 10, 100, 1000, 1000000, 1609344 };

    string[] weightName = { "гр", "кг", "ц", "т", "карат", "унция" };
    double[] weightValue = { 1, 1000, 100000, 1000000, 0.125, 28.3495 };


    public MainForm()
    {
      InitializeComponent();
      rnd = new Random();
      metrica = new Dictionary<string, double>();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      loadNote();
      chlbPassword.SetItemChecked(0, true);
      chlbPassword.SetItemChecked(1, true);
      cbx_Metrica.Text = "Длина";
    }

    private void tsmiExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void tsmiAbout_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Программа содержит ряд небольших программ, " +
        "которые могут пригодиться в жизни.\nА главное научить меня " +
        "основам программирования на C#. \nАвтор Меженный Д.В.", "О программе");
    }

    private void btnPlus_Click(object sender, EventArgs e)
    {
      count++;
      lblCount.Text = count.ToString();
    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
      count--;
      lblCount.Text = count.ToString();
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      count = 0;
      lblCount.Text = Convert.ToString(count);
    }

    private void btnRandom_Click(object sender, EventArgs e)
    {
      int n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
      int i = 0;
      string s = "";

      if (chbxRandom.Checked)
      {
        while (((chbxRandomChar.Checked && tbx_Random.Text.IndexOf(Convert.ToChar(n).ToString()) != -1) ||
         (!chbxRandomChar.Checked && tbx_Random.Text.IndexOf(n.ToString()) != -1)) && i <= 1000)
        {
          n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value) + 1);
          i++;
        }
      }

      if (i <= 1000)
      {
        if (chbxRandomChar.Checked)
          s = Convert.ToChar(n).ToString();
        else
          s = n.ToString();
        tbx_Random.AppendText(s + "\n");
      }
      lblRandom.Text = s;
    }

    private void btnRndClear_Click(object sender, EventArgs e)
    {
      tbx_Random.Clear();
    }

    private void btnRdmCopy_Click(object sender, EventArgs e)
    {
      Clipboard.SetText(tbx_Random.Text);
    }

    private void tsmiInsertDate_Click(object sender, EventArgs e)
    {
      tbxNote.AppendText(DateTime.Now.ToShortDateString());
    }

    private void tsmiInsertTime_Click(object sender, EventArgs e)
    {
      tbxNote.AppendText(DateTime.Now.ToShortTimeString());
    }

    private void tsmiNoteSave_Click(object sender, EventArgs e)
    {
      try
      {
        tbxNote.SaveFile("Notepad.rtf");
      }
      catch (Exception)
      {
        MessageBox.Show("Ошибка при сохранении");
      }
    }

    void loadNote()
    {
      try
      {
        tbxNote.LoadFile("Notepad.rtf");
      }
      catch (Exception)
      {
        MessageBox.Show("Ошибка при загрузке");
      }
    }

    private void tsmiNoteLoad_Click(object sender, EventArgs e)
    {
      loadNote();
    }

    private void btnPassCreate_Click(object sender, EventArgs e)
    {
      if (chlbPassword.CheckedItems.Count <= 0) return;
      string pass = "";
      for (int i = 0; i < nudPassLength.Value; i++)
      {
        int n = rnd.Next(0, chlbPassword.CheckedItems.Count);
        string s = chlbPassword.CheckedItems[n].ToString();
        switch (s)
        {
          case "Цифры":
            pass += rnd.Next(10).ToString();
            break;
          case "Прописные буквы":
            pass += Convert.ToChar(rnd.Next(65, 90));
            break;
          case "Строчные буквы":
            pass += Convert.ToChar(rnd.Next(97, 122));
            break;
          case "Спец. символы":
            pass += spec_Char[rnd.Next(spec_Char.Length)];
            break;
        }
        tbxPassword.Text = pass;
        Clipboard.SetText(pass);
      }
    }

    private void converting(object sender, EventArgs e)
    {
      try
      {
        double n = Convert.ToDouble(tbxFrom.Text);
        double m1 = metrica[cbxFrom.Text];
        double m2 = metrica[cbxTo.Text];
        tbxTo.Text = (n * m1 / m2).ToString("0.########");
      }
      catch (Exception)
      {
      }
    }

    private void btnChangeFromTo_Click(object sender, EventArgs e)
    {
      string temp = cbxFrom.Text;
      cbxFrom.Text = cbxTo.Text;
      cbxTo.Text = temp;
    }

    private void cbx_Metrica_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (cbx_Metrica.Text)
      {
        case "Длина":
          setMetrica(lengthName, lengthValue);
          break;
        case "Вес":
          setMetrica(weightName, weightValue);
          break;
      }
    }

    private void setMetrica(string[] names, double[] values)
    {
      metrica.Clear();
      for (int i = 0; i < names.Length; i++)
        metrica.Add(names[i], values[i]);
      setNamesInCombobox(cbxFrom, names);
      setNamesInCombobox(cbxTo, names);
    }

    private void setNamesInCombobox(ComboBox cbx, string[] names)
    {
      cbx.Items.Clear();
      cbx.Items.AddRange(names);
      cbx.Text = names[0];
    }
  }
}
