using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0
{
	// Token: 0x0200000D RID: 13
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal sealed class Class6
	{
		// Token: 0x06000077 RID: 119 RVA: 0x000025D2 File Offset: 0x000007D2
		internal Class6()
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00002664 File Offset: 0x00000864
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Class6.resourceManager_0 == null)
				{
                    //Class6.resourceManager_0 = new ResourceManager("ns0.Class6", typeof(Class6).Assembly);
                    Class6.resourceManager_0 = new ResourceManager("ns0.Properties.Class6", typeof(Class6).Assembly);

                }
                return Class6.resourceManager_0;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002690 File Offset: 0x00000890
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002697 File Offset: 0x00000897
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Class6.cultureInfo_0;
			}
			set
			{
				Class6.cultureInfo_0 = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000269F File Offset: 0x0000089F
		internal static byte[] array6
		{
			get
			{
				return (byte[])Class6.ResourceManager.GetObject("array6", Class6.cultureInfo_0);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000026BA File Offset: 0x000008BA
		internal static byte[] ctz_to_bin
		{
			get
			{
				return (byte[])Class6.ResourceManager.GetObject("ctz_to_bin", Class6.cultureInfo_0);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000026D5 File Offset: 0x000008D5
		internal static byte[] tablica_offset
		{
			get
			{
				return (byte[])Class6.ResourceManager.GetObject("tablica_offset", Class6.cultureInfo_0);
			}
		}

		// Token: 0x04000035 RID: 53
		private static ResourceManager resourceManager_0;

		// Token: 0x04000036 RID: 54
		private static CultureInfo cultureInfo_0;
	}
}
