using System;

namespace ns0
{
	// Token: 0x02000015 RID: 21
	internal struct Struct0
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00002987 File Offset: 0x00000B87
		public Struct0(long long_1, int int_1)
		{
			this.long_0 = long_1;
			this.int_0 = int_1;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002997 File Offset: 0x00000B97
		public int Int32_0
		{
			get
			{
				return this.int_0;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000299F File Offset: 0x00000B9F
		public long Int64_0
		{
			get
			{
				return this.long_0;
			}
		}

		// Token: 0x0400004D RID: 77
		private int int_0;

		// Token: 0x0400004E RID: 78
		private long long_0;
	}
}
