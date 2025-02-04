using System;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000002 RID: 2
	internal static class Class0
	{
		// Token: 0x06000001 RID: 1
		[DllImport("user32", CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr CallWindowProcW([In] byte[] byte_0, IntPtr intptr_0, int int_1, [In] [Out] byte[] byte_1, IntPtr intptr_1);

		// Token: 0x06000002 RID: 2
		[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool VirtualProtect([In] byte[] byte_0, IntPtr intptr_0, int int_1, out int int_2);

		// Token: 0x06000003 RID: 3 RVA: 0x00003A08 File Offset: 0x00001C08
		public static string smethod_0()
		{
			byte[] value = new byte[8];
			if (Class0.smethod_1(ref value))
			{
				return string.Format("{0:X8}{1:X8}", BitConverter.ToUInt32(value, 4), BitConverter.ToUInt32(value, 0));
			}
			return "ND";
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00003A50 File Offset: 0x00001C50
		private static bool smethod_1(ref byte[] byte_0)
		{
			byte[] array;
			if (IntPtr.Size == 8)
			{
				array = new byte[]
				{
					83,
					72,
					199,
					192,
					1,
					0,
					0,
					0,
					15,
					162,
					65,
					137,
					0,
					65,
					137,
					80,
					4,
					91,
					195
				};
			}
			else
			{
				array = new byte[]
				{
					85,
					137,
					229,
					87,
					139,
					125,
					16,
					106,
					1,
					88,
					83,
					15,
					162,
					137,
					7,
					137,
					87,
					4,
					91,
					95,
					137,
					236,
					93,
					194,
					16,
					0
				};
			}
			IntPtr intPtr = new IntPtr(array.Length);
			int num;
			if (!Class0.VirtualProtect(array, intPtr, 64, out num))
			{
				Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
			}
			intPtr = new IntPtr(byte_0.Length);
			return Class0.CallWindowProcW(array, IntPtr.Zero, 0, byte_0, intPtr) != IntPtr.Zero;
		}

		// Token: 0x04000001 RID: 1
		private static int int_0;
	}
}
