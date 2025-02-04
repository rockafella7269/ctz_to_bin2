using System;
using System.Text;

namespace ns0
{
	// Token: 0x02000013 RID: 19
	public sealed class GClass2 : GInterface0
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00009E44 File Offset: 0x00008044
		public char imethod_0(byte byte_0)
		{
			string @string = this.encoding_0.GetString(new byte[]
			{
				byte_0
			});
			if (@string.Length <= 0)
			{
				return '.';
			}
			return @string[0];
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00009E7C File Offset: 0x0000807C
		public byte imethod_1(char char_0)
		{
			byte[] bytes = this.encoding_0.GetBytes(new char[]
			{
				char_0
			});
			if (bytes.Length == 0)
			{
				return 0;
			}
			return bytes[0];
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000028A6 File Offset: 0x00000AA6
		public override string ToString()
		{
			return "EBCDIC (Code Page 500)";
		}

		// Token: 0x0400004C RID: 76
		private Encoding encoding_0 = Encoding.GetEncoding(500);
	}
}
