using System;
using System.Collections;

namespace ns0
{
	// Token: 0x02000014 RID: 20
	public sealed class GClass3 : CollectionBase
	{
		// Token: 0x060000AE RID: 174 RVA: 0x000028AD File Offset: 0x00000AAD
		public GClass3()
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000028B5 File Offset: 0x00000AB5
		public GClass3(byte[] byte_0)
		{
			this.method_1(byte_0);
		}

		// Token: 0x17000013 RID: 19
		public byte this[int int_0]
		{
			get
			{
				return (byte)base.List[int_0];
			}
			set
			{
				base.List[int_0] = value;
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000028EB File Offset: 0x00000AEB
		public void method_0(byte byte_0)
		{
			base.List.Add(byte_0);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000028FF File Offset: 0x00000AFF
		public void method_1(byte[] byte_0)
		{
			base.InnerList.AddRange(byte_0);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000290D File Offset: 0x00000B0D
		public void method_2(byte byte_0)
		{
			base.List.Remove(byte_0);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002920 File Offset: 0x00000B20
		public void method_3(int int_0, int int_1)
		{
			base.InnerList.RemoveRange(int_0, int_1);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000292F File Offset: 0x00000B2F
		public void method_4(int int_0, byte[] byte_0)
		{
			base.InnerList.InsertRange(int_0, byte_0);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00009EA8 File Offset: 0x000080A8
		public byte[] method_5()
		{
			byte[] array = new byte[base.Count];
			base.InnerList.CopyTo(0, array, 0, array.Length);
			return array;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000293E File Offset: 0x00000B3E
		public void method_6(int int_0, byte byte_0)
		{
			base.InnerList.Insert(int_0, byte_0);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002952 File Offset: 0x00000B52
		public int method_7(byte byte_0)
		{
			return base.InnerList.IndexOf(byte_0);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002965 File Offset: 0x00000B65
		public bool method_8(byte byte_0)
		{
			return base.InnerList.Contains(byte_0);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002978 File Offset: 0x00000B78
		public void method_9(byte[] byte_0, int int_0)
		{
			base.InnerList.CopyTo(byte_0, int_0);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00009ED4 File Offset: 0x000080D4
		public byte[] method_10()
		{
			byte[] array = new byte[base.Count];
			this.method_9(array, 0);
			return array;
		}
	}
}
