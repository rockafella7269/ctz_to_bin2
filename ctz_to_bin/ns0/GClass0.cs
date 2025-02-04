using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x0200000F RID: 15
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public sealed class GClass0 : Component
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00002715 File Offset: 0x00000915
		internal GClass0(GControl0 gcontrol0_1)
		{
			this.gcontrol0_0 = gcontrol0_1;
			this.gcontrol0_0.Event_2 += this.method_0;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000273B File Offset: 0x0000093B
		private void method_0(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00009810 File Offset: 0x00007A10
		private void method_1()
		{
			if (Class18.Boolean_0)
			{
				return;
			}
			if (this.contextMenuStrip_0 == null)
			{
				ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
				this.toolStripMenuItem_0 = new ToolStripMenuItem(this.String_4, this.Image_0, new EventHandler(this.method_3));
				contextMenuStrip.Items.Add(this.toolStripMenuItem_0);
				this.toolStripMenuItem_1 = new ToolStripMenuItem(this.String_5, this.Image_1, new EventHandler(this.method_4));
				contextMenuStrip.Items.Add(this.toolStripMenuItem_1);
				this.toolStripMenuItem_2 = new ToolStripMenuItem(this.String_6, this.Image_2, new EventHandler(this.method_5));
				contextMenuStrip.Items.Add(this.toolStripMenuItem_2);
				contextMenuStrip.Items.Add(new ToolStripSeparator());
				this.toolStripMenuItem_3 = new ToolStripMenuItem(this.String_7, this.Image_3, new EventHandler(this.method_6));
				contextMenuStrip.Items.Add(this.toolStripMenuItem_3);
				contextMenuStrip.Opening += this.method_2;
				this.contextMenuStrip_0 = contextMenuStrip;
			}
			if (this.gcontrol0_0.GInterface1_0 == null && this.gcontrol0_0.ContextMenuStrip == this.contextMenuStrip_0)
			{
				this.gcontrol0_0.ContextMenuStrip = null;
				return;
			}
			if (this.gcontrol0_0.GInterface1_0 != null && this.gcontrol0_0.ContextMenuStrip == null)
			{
				this.gcontrol0_0.ContextMenuStrip = this.contextMenuStrip_0;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000998C File Offset: 0x00007B8C
		private void method_2(object sender, CancelEventArgs e)
		{
			this.toolStripMenuItem_0.Enabled = this.gcontrol0_0.method_36();
			this.toolStripMenuItem_1.Enabled = this.gcontrol0_0.method_34();
			this.toolStripMenuItem_2.Enabled = this.gcontrol0_0.method_38();
			this.toolStripMenuItem_3.Enabled = this.gcontrol0_0.method_16();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002743 File Offset: 0x00000943
		private void method_3(object sender, EventArgs e)
		{
			this.gcontrol0_0.method_35();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002750 File Offset: 0x00000950
		private void method_4(object sender, EventArgs e)
		{
			this.gcontrol0_0.method_33();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000275D File Offset: 0x0000095D
		private void method_5(object sender, EventArgs e)
		{
			this.gcontrol0_0.method_37();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000276A File Offset: 0x0000096A
		private void method_6(object sender, EventArgs e)
		{
			this.gcontrol0_0.method_17();
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00002777 File Offset: 0x00000977
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000277F File Offset: 0x0000097F
		[DefaultValue(null)]
		[Localizable(true)]
		[Category("BuiltIn-ContextMenu")]
		public string String_0
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002788 File Offset: 0x00000988
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002790 File Offset: 0x00000990
		[Localizable(true)]
		[Category("BuiltIn-ContextMenu")]
		[DefaultValue(null)]
		public string String_1
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002799 File Offset: 0x00000999
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000027A1 File Offset: 0x000009A1
		[DefaultValue(null)]
		[Category("BuiltIn-ContextMenu")]
		[Localizable(true)]
		public string String_2
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000027AA File Offset: 0x000009AA
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000027B2 File Offset: 0x000009B2
		[Category("BuiltIn-ContextMenu")]
		[DefaultValue(null)]
		[Localizable(true)]
		public string String_3
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000027BB File Offset: 0x000009BB
		internal string String_4
		{
			get
			{
				if (string.IsNullOrEmpty(this.String_1))
				{
					return "Cut";
				}
				return this.String_1;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000027D6 File Offset: 0x000009D6
		internal string String_5
		{
			get
			{
				if (string.IsNullOrEmpty(this.String_0))
				{
					return "Copy";
				}
				return this.String_0;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000027F1 File Offset: 0x000009F1
		internal string String_6
		{
			get
			{
				if (string.IsNullOrEmpty(this.String_2))
				{
					return "Paste";
				}
				return this.String_2;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000280C File Offset: 0x00000A0C
		internal string String_7
		{
			get
			{
				if (string.IsNullOrEmpty(this.String_3))
				{
					return "SelectAll";
				}
				return this.String_3;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002827 File Offset: 0x00000A27
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000282F File Offset: 0x00000A2F
		[Category("BuiltIn-ContextMenu")]
		[DefaultValue(null)]
		public Image Image_0
		{
			get
			{
				return this.image_0;
			}
			set
			{
				this.image_0 = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002838 File Offset: 0x00000A38
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002840 File Offset: 0x00000A40
		[Category("BuiltIn-ContextMenu")]
		[DefaultValue(null)]
		public Image Image_1
		{
			get
			{
				return this.image_1;
			}
			set
			{
				this.image_1 = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002849 File Offset: 0x00000A49
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002851 File Offset: 0x00000A51
		[DefaultValue(null)]
		[Category("BuiltIn-ContextMenu")]
		public Image Image_2
		{
			get
			{
				return this.image_2;
			}
			set
			{
				this.image_2 = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000285A File Offset: 0x00000A5A
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002862 File Offset: 0x00000A62
		[Category("BuiltIn-ContextMenu")]
		[DefaultValue(null)]
		public Image Image_3
		{
			get
			{
				return this.image_3;
			}
			set
			{
				this.image_3 = value;
			}
		}

		// Token: 0x04000038 RID: 56
		private GControl0 gcontrol0_0;

		// Token: 0x04000039 RID: 57
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x0400003A RID: 58
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x0400003B RID: 59
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x0400003C RID: 60
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x0400003D RID: 61
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x0400003E RID: 62
		private string string_0;

		// Token: 0x0400003F RID: 63
		private string string_1;

		// Token: 0x04000040 RID: 64
		private string string_2;

		// Token: 0x04000041 RID: 65
		private string string_3;

		// Token: 0x04000042 RID: 66
		private Image image_0;

		// Token: 0x04000043 RID: 67
		private Image image_1;

		// Token: 0x04000044 RID: 68
		private Image image_2;

		// Token: 0x04000045 RID: 69
		private Image image_3;
	}
}
