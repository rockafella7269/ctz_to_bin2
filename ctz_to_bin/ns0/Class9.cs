using System;

namespace ns0
{
	// Token: 0x0200001D RID: 29
	internal sealed class Class9 : Class8
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00002E97 File Offset: 0x00001097
		public Class9(long long_2, long long_3)
		{
			this.long_1 = long_2;
			this.long_0 = long_3;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00002EAD File Offset: 0x000010AD
		public long Int64_0
		{
			get
			{
				return this.long_1;
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002EB5 File Offset: 0x000010B5
		public override long vmethod_0()
		{
			return this.long_0;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002EBD File Offset: 0x000010BD
		public void method_0(long long_2)
		{
			this.long_1 = long_2;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002EC6 File Offset: 0x000010C6
		public void method_1(long long_2)
		{
			if (long_2 > this.long_0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.long_0 -= long_2;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002EEA File Offset: 0x000010EA
		public void method_2(long long_2)
		{
			if (long_2 > this.long_0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.long_1 += long_2;
			this.long_0 -= long_2;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000AF64 File Offset: 0x00009164
		public override void vmethod_1(long long_2, long long_3)
		{
			if (long_2 > this.long_0)
			{
				throw new ArgumentOutOfRangeException("position");
			}
			if (long_2 + long_3 > this.long_0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			long num = this.long_1;
			long num2 = this.long_0 - long_3 - long_2;
			long long_4 = this.long_1 + long_2 + long_3;
			if (long_2 > 0L && num2 > 0L)
			{
				this.long_1 = num;
				this.long_0 = long_2;
				this.class11_0.method_0(this, new Class9(long_4, num2));
				return;
			}
			if (long_2 > 0L)
			{
				this.long_1 = num;
				this.long_0 = long_2;
				return;
			}
			this.long_1 = long_4;
			this.long_0 = num2;
		}

		// Token: 0x0400006C RID: 108
		private long long_0;

		// Token: 0x0400006D RID: 109
		private long long_1;
	}
}
