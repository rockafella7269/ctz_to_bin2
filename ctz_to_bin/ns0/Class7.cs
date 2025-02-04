using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000012 RID: 18
	internal sealed class Class7
	{
		// Token: 0x060000A3 RID: 163 RVA: 0x000099F4 File Offset: 0x00007BF4
		static Class7()
		{
			Class7.int_0 = int.MaxValue;
			Class7.int_1 = int.MinValue;
			Class7.memoryStream_0 = new MemoryStream(0);
			Class7.memoryStream_1 = new MemoryStream(0);
			Class7.object_0 = new object();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00009A44 File Offset: 0x00007C44
		private static string smethod_0(Assembly assembly_0)
		{
			string text = assembly_0.FullName;
			int num = text.IndexOf(',');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			return text;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00009A70 File Offset: 0x00007C70
		private static byte[] smethod_1(Assembly assembly_0)
		{
			try
			{
				string fullName = assembly_0.FullName;
				int num = fullName.IndexOf("PublicKeyToken=");
				if (num < 0)
				{
					num = fullName.IndexOf("publickeytoken=");
				}
				if (num < 0)
				{
					return null;
				}
				num += 15;
				if (fullName[num] != 'n')
				{
					if (fullName[num] != 'N')
					{
						string s = fullName.Substring(num, 16);
						long value = long.Parse(s, NumberStyles.HexNumber);
						byte[] bytes = BitConverter.GetBytes(value);
						Array.Reverse(bytes);
						return bytes;
					}
				}
				return null;
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00009B10 File Offset: 0x00007D10
		internal static byte[] smethod_2(Stream stream_0)
		{
			byte[] result;
			lock (Class7.object_0)
			{
				result = Class7.smethod_4(97L, stream_0);
			}
			return result;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00009B54 File Offset: 0x00007D54
		internal static byte[] smethod_3(long long_0, Stream stream_0)
		{
			byte[] result;
			try
			{
				result = Class7.smethod_2(stream_0);
			}
			catch
			{
				result = Class7.smethod_4(97L, stream_0);
			}
			return result;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00009B90 File Offset: 0x00007D90
		internal static byte[] smethod_4(long long_0, object object_1)
		{
			Stream stream = object_1 as Stream;
			Stream stream2 = stream;
			MemoryStream memoryStream = null;
			for (int i = 1; i < 4; i++)
			{
				stream.ReadByte();
			}
			ushort num = (ushort)stream.ReadByte();
            num = (ushort)~num;
            if ((num & 2) != 0)
            {
                DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider();
                byte[] array = new byte[8];
                stream.Read(array, 0, 8);
                descryptoServiceProvider.IV = array;
                byte[] array2 = new byte[8];
                stream.Read(array2, 0, 8);

                // Check if array2 is all zeros
                bool flag = true;
                byte[] array3 = array2;
                for (int j = 0; j < array3.Length; j++)
                {
                    if (array3[j] != 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    array2 = Class7.smethod_1(Assembly.GetExecutingAssembly());
                }

                descryptoServiceProvider.Key = array2;
                if (Class7.memoryStream_0 == null)
                {
                    if (Class7.int_0 == 2147483647)
                    {
                        Class7.memoryStream_0.Capacity = (int)stream.Length;
                    }
                    else
                    {
                        Class7.memoryStream_0.Capacity = Class7.int_0;
                    }
                }
                Class7.memoryStream_0.Position = 0L;
                ICryptoTransform cryptoTransform = descryptoServiceProvider.CreateDecryptor();
                int inputBlockSize = cryptoTransform.InputBlockSize;
                int outputBlockSize = cryptoTransform.OutputBlockSize;
                byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
                byte[] array5 = new byte[cryptoTransform.InputBlockSize];
                int num2 = (int)stream.Position;
                while ((long)(num2 + inputBlockSize) < stream.Length)
                {
                    stream.Read(array5, 0, inputBlockSize);
                    int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
                    Class7.memoryStream_0.Write(array4, 0, count);
                    num2 += inputBlockSize;
                }
                stream.Read(array5, 0, (int)(stream.Length - (long)num2));
                byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream.Length - (long)num2));
                Class7.memoryStream_0.Write(array6, 0, array6.Length);
                stream2 = Class7.memoryStream_0;
                stream2.Position = 0L;
                memoryStream = Class7.memoryStream_0;
                goto IL_1D1;
            }
        IL_1D1:
			if ((num & 8) != 0)
			{
				if (Class7.memoryStream_1 == null)
				{
					if (Class7.int_1 == -2147483648)
					{
						Class7.memoryStream_1.Capacity = (int)stream2.Length * 2;
					}
					else
					{
						Class7.memoryStream_1.Capacity = Class7.int_1;
					}
				}
				Class7.memoryStream_1.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream2, CompressionMode.Decompress);
				int num3 = 1000;
				byte[] buffer = new byte[1000];
				int num4;
				do
				{
					num4 = deflateStream.Read(buffer, 0, num3);
					if (num4 > 0)
					{
						Class7.memoryStream_1.Write(buffer, 0, num4);
					}
				}
				while (num4 >= num3);
				memoryStream = Class7.memoryStream_1;
			}
			if (memoryStream != null)
			{
				return memoryStream.ToArray();
			}
			byte[] array7 = new byte[stream.Length - stream.Position];
			stream.Read(array7, 0, array7.Length);
			return array7;
		}

		// Token: 0x04000046 RID: 70
		private static readonly object object_0;

		// Token: 0x04000047 RID: 71
		private static readonly int int_0;

		// Token: 0x04000048 RID: 72
		private static readonly int int_1;

		// Token: 0x04000049 RID: 73
		private static readonly MemoryStream memoryStream_0 = null;

		// Token: 0x0400004A RID: 74
		private static readonly MemoryStream memoryStream_1 = null;

		// Token: 0x0400004B RID: 75
		private static readonly byte byte_0;
	}
}
