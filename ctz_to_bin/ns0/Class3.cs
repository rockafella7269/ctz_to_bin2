using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ns0
{
	// Token: 0x02000008 RID: 8
	internal sealed class Class3
	{
		// Token: 0x06000065 RID: 101
		[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, int int_0, out uint uint_0, out uint uint_1, out GEnum0 genum0_0, StringBuilder stringBuilder_1, int int_1);

		// Token: 0x06000066 RID: 102 RVA: 0x000091A4 File Offset: 0x000073A4
		public static string smethod_0()
		{
			StringBuilder stringBuilder = new StringBuilder(261);
			StringBuilder stringBuilder2 = new StringBuilder(261);
			uint num;
			uint num2;
			GEnum0 genum;
			if (!Class3.GetVolumeInformation("c:\\", stringBuilder, stringBuilder.Capacity, out num, out num2, out genum, stringBuilder2, stringBuilder2.Capacity))
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}
			stringBuilder.ToString();
			stringBuilder2.ToString();
			return num.ToString("X2");
		}
	}
}
