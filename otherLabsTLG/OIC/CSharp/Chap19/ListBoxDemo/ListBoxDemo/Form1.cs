using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxDemo
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void cmdAdd_Click(object sender, EventArgs e)
      {
         listBox1.Items.Add(txtString.Text);
      }

      private void cmdRemove_Click(object sender, EventArgs e)
      {
         listBox1.Items.Remove(txtString.Text);
      }

      private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         if (listBox1.SelectedIndex != -1)
            txtString.Text = (string)listBox1.SelectedItem;
      }
   }
}
