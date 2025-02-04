using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace ns0
{
	// Token: 0x0200001F RID: 31
	public sealed class GClass7
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000132 RID: 306 RVA: 0x00002F1C File Offset: 0x0000111C
		// (set) Token: 0x06000133 RID: 307 RVA: 0x00002F24 File Offset: 0x00001124
		public bool IsValid { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002F2D File Offset: 0x0000112D
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00002F35 File Offset: 0x00001135
		internal byte[] FindBuffer { get; private set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00002F3E File Offset: 0x0000113E
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00002F46 File Offset: 0x00001146
		internal byte[] FindBufferLowerCase { get; private set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00002F4F File Offset: 0x0000114F
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00002F57 File Offset: 0x00001157
		internal byte[] FindBufferUpperCase { get; private set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00002F60 File Offset: 0x00001160
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002F68 File Offset: 0x00001168
		public bool Boolean_0
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				this.bool_1 = value;
				this.method_0();
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00002F77 File Offset: 0x00001177
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00002F7F File Offset: 0x0000117F
		public string String_0
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
				this.method_0();
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00002F8E File Offset: 0x0000118E
		// (set) Token: 0x0600013F RID: 319 RVA: 0x00002F96 File Offset: 0x00001196
		public byte[] Hex { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00002F9F File Offset: 0x0000119F
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00002FA7 File Offset: 0x000011A7
		public GEnum1 Type { get; set; }

		// Token: 0x06000142 RID: 322 RVA: 0x0000B008 File Offset: 0x00009208
		private void method_0()
		{
			string text = (this.String_0 != null) ? this.String_0 : string.Empty;
			this.FindBuffer = Encoding.ASCII.GetBytes(text);
			this.FindBufferLowerCase = Encoding.ASCII.GetBytes(text.ToLower());
			this.FindBufferUpperCase = Encoding.ASCII.GetBytes(text.ToUpper());
		}

		// Token: 0x04000071 RID: 113
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000072 RID: 114
		[CompilerGenerated]
		private byte[] byte_0;

		// Token: 0x04000073 RID: 115
		[CompilerGenerated]
		private byte[] byte_1;

		// Token: 0x04000074 RID: 116
		[CompilerGenerated]
		private byte[] byte_2;

		// Token: 0x04000075 RID: 117
		private bool bool_1;

		// Token: 0x04000076 RID: 118
		private string string_0;

		// Token: 0x04000077 RID: 119
		[CompilerGenerated]
		private byte[] byte_3;

		// Token: 0x04000078 RID: 120
		[CompilerGenerated]
		private GEnum1 genum1_0;
	}
}
