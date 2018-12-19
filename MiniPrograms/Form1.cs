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
      lbl_Random.Text = n.ToString();
    }
  }
}
