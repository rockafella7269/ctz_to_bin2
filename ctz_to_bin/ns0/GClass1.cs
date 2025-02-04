using System;

namespace ns0
{
	// Token: 0x02000011 RID: 17
	public sealed class GClass1 : GInterface0
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0000286B File Offset: 0x00000A6B
		public char imethod_0(byte byte_0)
		{
			if (byte_0 > 31 && (byte_0 <= 126 || byte_0 >= 160))
			{
				return (char)byte_0;
			}
			return '.';
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002883 File Offset: 0x00000A83
		public byte imethod_1(char char_0)
		{
			return (byte)char_0;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002887 File Offset: 0x00000A87
		public override string ToString()
		{
			return "ANSI (Default)";
		}
	}
}
