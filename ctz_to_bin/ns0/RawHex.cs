using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200000B RID: 11
	public sealed partial class RawHex : Form
	{
		// Token: 0x06000070 RID: 112 RVA: 0x000094D4 File Offset: 0x000076D4
		public RawHex(string string_1, byte[] byte_1, long long_0, Etenity etenity_1, Form1 form1_1)
		{
			this.etenity_0 = etenity_1;
			this.form1_0 = form1_1;
			this.InitializeComponent();
			base.TopMost = true;
			this.Text = string.Concat(new string[]
			{
				"Hex view sector: 0x",
				long_0.ToString("X2"),
				" - 0x",
				(long_0 + (long)byte_1.Length).ToString("X2"),
				" of file",
				string_1
			});
			try
			{
				this.string_0 = Path.GetTempPath() + "\\" + string.Format("{0}.bin", Guid.NewGuid());
				File.WriteAllBytes(this.string_0, byte_1);
				this.gclass5_0 = new GClass5(this.string_0, true);
				this.byte_0 = new byte[this.gclass5_0.stream_0.Length];
				this.gclass5_0.stream_0.Read(this.byte_0, 0, this.byte_0.Length);
				this.hexBox1.GInterface1_0 = this.gclass5_0;
				this.hexBox1.Int64_1 = long_0;
			}
			catch
			{
			}
			base.TopMost = true;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000260E File Offset: 0x0000080E
		private void RawHex_Load(object sender, EventArgs e)
		{
			base.BringToFront();
			this.etenity_0.SendToBack();
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000962C File Offset: 0x0000782C
		private void RawHex_FormClosed(object sender, FormClosedEventArgs e)
		{
			try
			{
				File.Delete(this.string_0);
			}
			catch
			{
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002621 File Offset: 0x00000821
		private void RawHex_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.etenity_0.BringToFront();
		}

		// Token: 0x0400002E RID: 46
		private Form1 form1_0;

		// Token: 0x0400002F RID: 47
		private Etenity etenity_0;

		// Token: 0x04000030 RID: 48
		private byte[] byte_0;

		// Token: 0x04000031 RID: 49
		private GClass5 gclass5_0;

		// Token: 0x04000032 RID: 50
		private string string_0 = string.Format("{0}.bin", Guid.NewGuid());
	}
}
