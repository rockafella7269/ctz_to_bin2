using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000007 RID: 7
	public sealed partial class Form1 : Form
	{
		// Token: 0x0600005D RID: 93 RVA: 0x0000258F File Offset: 0x0000078F
		public Form1()
		{
			this.InitializeComponent();
			this.toolStripStatusLabel1.Text = Class4.smethod_0(this.Text);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00008D24 File Offset: 0x00006F24
		private void button1_Click(object sender, EventArgs e)
		{
			this.openFileDialog_0.FileName = "";
			if (!this.checkBox1.Checked)
			{
				if (!Class4.smethod_4(Class4.smethod_0(this.Text), this))
				{
					MessageBox.Show("Please register first this application", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
				{
					new Class1(this, this.progressBar1).method_1(this.openFileDialog_0.FileName);
					GC.Collect();
					return;
				}
			}
			else if (Class4.smethod_4(Class4.smethod_0(this.Text), this))
			{
				if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
				{
					new Class2(this, this.progressBar1).method_1(this.openFileDialog_0.FileName);
					GC.Collect();
					return;
				}
			}
			else
			{
				MessageBox.Show("Please register first this application", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000023F6 File Offset: 0x000005F6
		private void progressBar1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000023F6 File Offset: 0x000005F6
		private void Form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00008E00 File Offset: 0x00007000
		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
			try
			{
				Clipboard.SetText(this.toolStripStatusLabel1.Text);
			}
			catch
			{
			}
		}
	}
}
