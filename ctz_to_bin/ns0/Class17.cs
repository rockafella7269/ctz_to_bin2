using System;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000029 RID: 41
	internal static class Class17
	{
		// Token: 0x06000272 RID: 626
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool CreateCaret(IntPtr intptr_0, IntPtr intptr_1, int int_3, int int_4);

		// Token: 0x06000273 RID: 627
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool ShowCaret(IntPtr intptr_0);

		// Token: 0x06000274 RID: 628
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool DestroyCaret();

		// Token: 0x06000275 RID: 629
		[DllImport("user32.dll", SetLastError = true)]
		public static extern bool SetCaretPos(int int_3, int int_4);

		// Token: 0x040000D6 RID: 214
		public static int int_0;

		// Token: 0x040000D7 RID: 215
		public static int int_1;

		// Token: 0x040000D8 RID: 216
		public static int int_2;
	}
}
