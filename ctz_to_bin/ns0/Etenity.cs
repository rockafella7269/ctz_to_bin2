using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000004 RID: 4
	public sealed partial class Etenity : Form
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000023C4 File Offset: 0x000005C4
		public Etenity(Form1 form1_1, string string_1)
		{
			this.form1_0 = form1_1;
			this.string_0 = string_1;
			this.InitializeComponent();
			this.Text = "File " + string_1 + " sections";
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023F6 File Offset: 0x000005F6
		private void Etenity_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023F6 File Offset: 0x000005F6
		private void treeView1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000023F6 File Offset: 0x000005F6
		private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003AD4 File Offset: 0x00001CD4
		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Clipboard.SetText(BitConverter.ToString((byte[])this.treeView1.SelectedNode.Tag).Replace("-", " "));
			try
			{
				RawHex rawHex = new RawHex(this.string_0, (byte[])this.treeView1.SelectedNode.Tag, long.Parse(this.treeView1.SelectedNode.Name), this, this.form1_0);
				rawHex.Show();
				rawHex.BringToFront();
				base.SendToBack();
			}
			catch
			{
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003B74 File Offset: 0x00001D74
		private void button1_Click(object sender, EventArgs e)
		{
			this.saveFileDialog_0.FileName = Path.GetFileNameWithoutExtension(this.string_0) + ".bin";
			this.saveFileDialog_0.Filter = "Binnary file|*.bin";
			this.saveFileDialog_0.OverwritePrompt = false;
			if (this.saveFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if (File.Exists(this.saveFileDialog_0.FileName))
					{
						File.Delete(this.saveFileDialog_0.FileName);
					}
					using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(this.saveFileDialog_0.FileName, FileMode.OpenOrCreate, FileAccess.Write)))
					{
						foreach (object obj in this.treeView1.Nodes)
						{
							byte[] buffer = (byte[])((TreeNode)obj).Tag;
							binaryWriter.Write(buffer);
							binaryWriter.Flush();
						}
						binaryWriter.Close();
					}
					MessageBox.Show("File saved", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex)
				{
					string message = ex.Message;
				}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000023F8 File Offset: 0x000005F8
		private void Etenity_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.bool_0)
			{
				this.form1_0.Visible = true;
				this.form1_0.BringToFront();
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002419 File Offset: 0x00000619
		private void Etenity_Shown(object sender, EventArgs e)
		{
			this.bool_0 = true;
		}

		// Token: 0x04000002 RID: 2
		private bool bool_0;

		// Token: 0x04000003 RID: 3
		private string string_0;

		// Token: 0x04000004 RID: 4
		private Form1 form1_0;
	}
}
