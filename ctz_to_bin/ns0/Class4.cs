using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.Win32;

namespace ns0
{
	// Token: 0x0200000A RID: 10
	internal sealed class Class4
	{
		// Token: 0x06000068 RID: 104 RVA: 0x0000920C File Offset: 0x0000740C
		public static string smethod_0(string string_0)
		{
			string str = Class0.smethod_0();
			return Class4.smethod_1(Class4.smethod_2(Class3.smethod_0() + str + string_0).ToUpper());
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000923C File Offset: 0x0000743C
		private static string smethod_1(string string_0)
		{
			string text = string.Empty;
			int num = 1;
			for (int i = 0; i < string_0.Length; i++)
			{
				text += string_0[i].ToString();
				if (num == 8)
				{
					text += "-";
					num = 0;
				}
				num++;
			}
			if (text.Substring(text.Length - 1, 1) == "-")
			{
				text = text.Substring(0, text.Length - 1);
			}
			return text;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000092C0 File Offset: 0x000074C0
		private static string smethod_2(string string_0)
		{
			string result;
			using (SHA256 sha = SHA256.Create())
			{
				byte[] array = sha.ComputeHash(Encoding.UTF8.GetBytes(string_0));
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					stringBuilder.Append(array[i].ToString("x2"));
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00009338 File Offset: 0x00007538
		public static bool smethod_3(string string_0)
		{
			RegistryKey registryKey = null;
			bool result;
			try
			{
				registryKey = Registry.CurrentUser.CreateSubKey("ctz");
				registryKey.SetValue("KEY", string_0, RegistryValueKind.String);
				registryKey.Close();
				return true;
			}
			catch
			{
				result = false;
			}
			finally
			{
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000025DA File Offset: 0x000007DA
		public static bool smethod_4(string string_0, Form1 form1_0)
		{
			return true;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000025DD File Offset: 0x000007DD
		private static bool smethod_5(string string_0, byte[] byte_0)
		{
			return ((RSACryptoServiceProvider)new X509Certificate2(Class6.ctz_to_bin).PublicKey.Key).VerifyData(Encoding.Default.GetBytes(string_0), SHA1.Create(), byte_0);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000939C File Offset: 0x0000759C
		private static string smethod_6(string string_0)
		{
			char[] array = string_0.ToCharArray();
			string text = string.Empty;
			for (int i = array.Length - 1; i > -1; i--)
			{
				text += array[i].ToString();
			}
			return text;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000093DC File Offset: 0x000075DC
		private static byte[] smethod_7(byte[] byte_0, byte[] byte_1)
		{
			byte[] result = null;
			byte[] salt = new byte[]
			{
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8
			};
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					rijndaelManaged.Mode = CipherMode.CBC;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(byte_0, 0, byte_0.Length);
						cryptoStream.Close();
					}
					result = memoryStream.ToArray();
				}
			}
			return result;
		}
	}
}
