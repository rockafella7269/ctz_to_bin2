using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ns0
{
	// Token: 0x0200002A RID: 42
	internal static class Class18
	{
		// Token: 0x06000276 RID: 630 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		static Class18()
		{
			List<string> list = new List<string>
			{
				"devenv",
				"vcsexpress",
				"vbexpress",
				"vcexpress",
				"sharpdevelop"
			};
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				string item = currentProcess.ProcessName.ToLower();
				Class18.bool_0 = list.Contains(item);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000039FE File Offset: 0x00001BFE
		public static bool Boolean_0
		{
			get
			{
				return Class18.bool_0;
			}
		}

		// Token: 0x040000D9 RID: 217
		private static bool bool_0;
	}
}
