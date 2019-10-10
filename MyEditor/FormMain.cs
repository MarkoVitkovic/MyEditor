using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEditor
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
				{
					writer.Write(textBox1.Text);
				}
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
				{
					textBox1.Text = reader.ReadToEnd();
				}
			}
		}
	}
}
