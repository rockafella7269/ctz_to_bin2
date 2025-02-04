using System;

namespace ns0
{
	// Token: 0x02000028 RID: 40
	internal sealed class Class10 : Class8
	{
		// Token: 0x0600026A RID: 618 RVA: 0x000039AD File Offset: 0x00001BAD
		public Class10(byte byte_1)
		{
			this.byte_0 = new byte[]
			{
				byte_1
			};
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000039C5 File Offset: 0x00001BC5
		public Class10(byte[] byte_1)
		{
			if (byte_1 == null)
			{
				throw new ArgumentNullException("data");
			}
			this.byte_0 = (byte[])byte_1.Clone();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000039EC File Offset: 0x00001BEC
		public override long vmethod_0()
		{
			return (long)this.byte_0.Length;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600026D RID: 621 RVA: 0x000039F6 File Offset: 0x00001BF6
		public byte[] Byte_0
		{
			get
			{
				return this.byte_0;
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000FAF0 File Offset: 0x0000DCF0
		public void method_0(byte byte_1)
		{
			byte[] array = new byte[(long)this.byte_0.Length + 1L];
			this.byte_0.CopyTo(array, 0);
			array[(int)(checked((IntPtr)(unchecked((long)array.Length - 1L))))] = byte_1;
			this.byte_0 = array;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000FB30 File Offset: 0x0000DD30
		public void method_1(byte byte_1)
		{
			byte[] array = new byte[(long)this.byte_0.Length + 1L];
			array[0] = byte_1;
			this.byte_0.CopyTo(array, 1);
			this.byte_0 = array;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000FB68 File Offset: 0x0000DD68
		public void method_2(long long_0, byte[] byte_1)
		{
			byte[] destinationArray = new byte[(long)this.byte_0.Length + (long)byte_1.Length];
			if (long_0 > 0L)
			{
				Array.Copy(this.byte_0, 0L, destinationArray, 0L, long_0);
			}
			Array.Copy(byte_1, 0L, destinationArray, long_0, (long)byte_1.Length);
			if (long_0 < (long)this.byte_0.Length)
			{
				Array.Copy(this.byte_0, long_0, destinationArray, long_0 + (long)byte_1.Length, (long)this.byte_0.Length - long_0);
			}
			this.byte_0 = destinationArray;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000FBDC File Offset: 0x0000DDDC
		public override void vmethod_1(long long_0, long long_1)
		{
			byte[] array = new byte[(long)this.byte_0.Length - long_1];
			if (long_0 > 0L)
			{
				Array.Copy(this.byte_0, 0L, array, 0L, long_0);
			}
			if (long_0 + long_1 < (long)this.byte_0.Length)
			{
				Array.Copy(this.byte_0, long_0 + long_1, array, long_0, (long)array.Length - long_0);
			}
			this.byte_0 = array;
		}

		// Token: 0x040000D5 RID: 213
		private byte[] byte_0;
	}
}
