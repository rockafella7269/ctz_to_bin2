using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns0
{
	// Token: 0x02000005 RID: 5
	internal sealed class Class1
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002441 File Offset: 0x00000641
		public Class1(Form1 form1_1, ProgressBar progressBar_1)
		{
			this.form1_0 = form1_1;
			this.progressBar_0 = progressBar_1;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003F5C File Offset: 0x0000215C
		public void method_0()
		{
			List<byte> list = new List<byte>();
			if (Class4.smethod_4(Class4.smethod_0(this.form1_0.Text), this.form1_0))
			{
				for (int i = 0; i < 257; i++)
				{
					list.AddRange(this.byte_0.Skip(0).Take(256).ToArray<byte>());
				}
				this.byte_0 = list.ToArray();
				return;
			}
			this.byte_0 = new byte[256];
			for (int j = 0; j < 256; j += 2)
			{
				list.Add((byte)(this.byte_0[j] ^ 34));
				list.Add((byte)(this.byte_0[j + 1] ^ 14));
			}
		}

        // Token: 0x06000012 RID: 18 RVA: 0x00004010 File Offset: 0x00002210
        public void method_1(string string_0)
		{
			if (Class4.smethod_4(Class4.smethod_0(this.form1_0.Text), this.form1_0))
			{
				long num = 0L;
				new List<byte[]>();
				try
				{
					using (BinaryReader binaryReader = new BinaryReader(File.Open(string_0, FileMode.Open)))
					{
						byte[] byte_ = new byte[4096];
						List<TreeNode> list = new List<TreeNode>();
						this.progressBar_0.Maximum = (int)binaryReader.BaseStream.Length;
						byte[] array = binaryReader.ReadBytes(1024);
						byte b = array[6];
						int int_ = 1003181;
						try
						{
							BitConverter.ToUInt32(array, 1016);
						}
						catch
						{
						}
						int int_2 = 4296314;
						byte[] array2 = null;
						int num2;
						if (BitConverter.ToUInt32(array, 16) > 0U)
						{
							byte[] array3 = new byte[array.Length - 16];
							Array.Copy(array, 16, array3, 0, array.Length - 16);
							num2 = (int)BitConverter.ToUInt32(array3, 0);
							array2 = binaryReader.ReadBytes(num2);
							int_ = this.method_31(array2, num2, int_2);
						}
						byte[] byte_2 = binaryReader.ReadBytes(8);
						long position = binaryReader.BaseStream.Position;
						int num3 = this.method_31(byte_2, 6, int_);
						int num4 = (int)this.method_21(byte_2);
						if ((int)((ushort)num3) != num4)
						{
							throw new Exception("ERROR");
						}
						this.method_22(byte_2);
						num3 = 4381306;
						num2 = this.method_23(array, 20) * 12;
						long offset = binaryReader.BaseStream.Position + (long)num2;
						BitConverter.ToUInt32(array, 24);
						binaryReader.BaseStream.Seek(offset, SeekOrigin.Begin);
						num2 = this.method_23(array, 24);
						byte[] byte_3 = binaryReader.ReadBytes(num2);
						num3 = this.method_31(byte_3, num2, num3);
						int num5 = 46860;
						byte[] array4 = this.method_15(0.0);
						int uint_ = this.method_20(array2);
						array4 = this.method_16(ref array4, array2, (uint)uint_);
						long num6 = position;
						int int_3 = num5;
						int num7 = 0;
						try
						{
							bool flag = false;
							for (;;)
							{
								Application.DoEvents();
								binaryReader.BaseStream.Seek(num6, SeekOrigin.Begin);
								byte[] array5 = binaryReader.ReadBytes(12);
								if (binaryReader.BaseStream.Position + 12L > binaryReader.BaseStream.Length)
								{
									break;
								}
								array5 = array5;
								int_3 = this.method_31(array5, 12, int_3);
								int int_4;
								if (array[6] < 13)
								{
									int_4 = (int)array5[11];
								}
								else
								{
									int_4 = this.method_14(ref array4, (int)array5[11], int_3, 0.0);
								}
								num6 += 12L;
								if (array[10] > 0)
								{
									this.method_13(ref array5, (ushort)array[6], int_4, 11);
								}
								long num8 = (long)BitConverter.ToUInt32(array5, 0);
								int num9 = (int)BitConverter.ToUInt16(array5, 8);
								if (num8 + (long)num9 > binaryReader.BaseStream.Length && flag)
								{
									break;
								}
								binaryReader.BaseStream.Position = num8;
								binaryReader.BaseStream.Seek(num8, SeekOrigin.Begin);
								this.method_9((int)binaryReader.BaseStream.Position);
								byte[] array6 = binaryReader.ReadBytes(num9);
								if (array[10] > 0)
								{
									this.method_13(ref array6, (ushort)array[6], int_4, num9);
								}
								if (array[11] > 0 && (array5[array5.Length - 2] & 7) > 0)
								{
									byte[] tag = this.method_3(array6, byte_, (int)array5[10]);
									list.Add(new TreeNode("")
									{
										Name = BitConverter.ToUInt16(array5, 4).ToString(),
										Text = "offset:    0x" + num.ToString("X2"),
										Tag = tag
									});
								}
								else
								{
									byte[] tag2 = array6.Take(array6.Length).ToArray<byte>();
									list.Add(new TreeNode("")
									{
										Name = BitConverter.ToUInt16(array5, 4).ToString(),
										Text = "offset:    0x" + num.ToString("X2"),
										Tag = tag2
									});
								}
								num += 4096L;
								byte b2 = array5[10];
								num7 += 4;
							}
						}
						catch (Exception ex)
						{
							string message = ex.Message;
						}
						this.method_9(0);
						if (list.Count > 0)
						{
							Etenity etenity = new Etenity(this.form1_0, Path.GetFileName(string_0));
							etenity.treeView1.Nodes.AddRange(list.ToArray());
							etenity.Show();
							this.form1_0.Visible = false;
						}
						else
						{
							MessageBox.Show("File is locked or unrecognized!", this.form1_0.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							this.form1_0.Visible = true;
							this.form1_0.BringToFront();
							this.form1_0.Show();
						}
						binaryReader.Close();
					}
				}
				catch (Exception ex2)
				{
					string message2 = ex2.Message;
					this.form1_0.Visible = true;
					this.form1_0.BringToFront();
					this.form1_0.Show();
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000247A File Offset: 0x0000067A
		private int method_2(uint uint_0, byte[] byte_2, int int_0)
		{
			return 0;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000454C File Offset: 0x0000274C
		private byte[] method_3(byte[] byte_2, byte[] byte_3, int int_0)
		{
			ushort num = 0;
			ushort num2 = 0;
			int num3 = this.method_8(ref num, byte_2, (short)int_0);
			this.method_6(ref num2, byte_3, (ushort)int_0, (uint)num3);
			List<int> list = new List<int>();
			while (num2 < 4096)
			{
				int num4 = this.method_8(ref num, byte_2, (short)int_0);
				this.method_6(ref num2, byte_3, (ushort)int_0, (uint)num4);
				if (num3 == num4)
				{
					list.Add((int)num2);
					ushort num5 = (ushort)this.method_8(ref num, byte_2, 2);
					num5 = num5;
					int num6 = byte_3.Length;
					int num7 = int_0 * (int)num5;
					int num8 = (int)num2 + num7;
					if (num6 < num8)
					{
					}
					while (num5 > 0)
					{
						this.method_6(ref num2, byte_3, (ushort)int_0, (uint)num3);
						num5 -= 1;
					}
					if (num2 >= 4096)
					{
						break;
					}
					num3 = num4;
				}
				else
				{
					num3 = num4;
				}
			}
			return byte_3.Take(byte_3.Length).ToArray<byte>();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00004624 File Offset: 0x00002824
		private byte[] method_4(ref byte[] byte_2, ref byte[] byte_3, byte byte_4, List<int> list_0)
		{
			int num = 0;
			byte[] array = null;
			int num2 = 0;
			if (byte_4 > 0)
			{
				byte[] array2 = byte_2;
				byte[] array3 = byte_2;
				byte[] array4 = byte_3;
				byte b = byte_4;
				byte b2 = byte_3[0];
				byte b3 = byte_3[1];
				switch (b2)
				{
				case 10:
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
					break;
				default:
				{
					do
					{
						list_0 = list_0;
						array2 = array3;
						if (num2 == 0)
						{
							List<byte> list = new List<byte>();
							list.AddRange(array3.Skip(0).Take(list_0[num2]));
							list.AddRange(array3.Skip(list_0[num2] + 2).Take(array3.Length - list_0[num2] - 2));
							array = list.ToArray();
						}
						else
						{
							List<byte> list2 = new List<byte>();
							list2.AddRange(array.Skip(0).Take(list_0[num2]));
							list2.AddRange(array.Skip(list_0[num2] + 2).Take(array.Length - list_0[num2] - 2));
							array = list2.ToArray();
						}
						this.method_7(ref array2, ref array4);
						b -= 1;
						num += 4;
						num2++;
					}
					while (b != 0);
					byte b4 = array[list_0[num2]];
					List<byte> list3 = new List<byte>();
					list3.AddRange(array.Skip(0).Take(list_0[num2]));
					for (int i = 0; i < num; i++)
					{
						list3.Add(0);
					}
					list3.AddRange(array.Skip(list_0[num2] + 2).Take(array.Length - list_0[num2] - 2));
					array = list3.ToArray();
					break;
				}
				}
				byte_2 = array;
			}
			return array;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000047E4 File Offset: 0x000029E4
		private bool method_5(int int_0, int int_1)
		{
			int num = (int_0 ^ int_1) & (int_0 ^ int_0 - int_1);
			bool result = false;
			bool.TryParse(num.ToString(), out result);
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00004810 File Offset: 0x00002A10
		private int method_6(ref ushort ushort_0, byte[] byte_2, ushort ushort_1, uint uint_0)
		{
			ushort num = ushort_0;
			byte[] array = byte_2;
			if (array.Length != 0)
			{
				int num2 = array.Length;
				int num3 = (int)num;
				int num4 = (int)ushort_1 + num3;
				if (num2 >= num4)
				{
					switch (ushort_1)
					{
					case 1:
						array[(int)num] = BitConverter.GetBytes(uint_0)[0];
						break;
					case 2:
						array[(int)num] = BitConverter.GetBytes(uint_0)[0];
						array[(int)(num + 1)] = BitConverter.GetBytes(uint_0)[1];
						break;
					case 4:
						array[(int)num] = BitConverter.GetBytes(uint_0)[0];
						array[(int)(num + 1)] = BitConverter.GetBytes(uint_0)[1];
						array[(int)(num + 2)] = (byte)(uint_0 >> 16);
						array[(int)(num + 3)] = BitConverter.GetBytes(uint_0)[3];
						break;
					}
				}
			}
			num += ushort_1;
			ushort_0 = num;
			this.method_7(ref array, ref this.byte_1);
			array = array;
			return 0;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000048C8 File Offset: 0x00002AC8
		private byte[] method_7(ref byte[] byte_2, ref byte[] byte_3)
		{
			bool flag = byte_2[0] == 0;
			if (byte_2 != null && flag)
			{
				byte[] array = byte_2;
				byte_2 = array;
			}
			return byte_2;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000048F0 File Offset: 0x00002AF0
		private int method_8(ref ushort ushort_0, byte[] byte_2, short short_0)
		{
			ushort num = ushort_0;
			byte[] array = byte_2;
			int result;
			if (short_0 == 1)
			{
				result = (int)array[(int)num];
			}
			else if (short_0 == 2)
			{
				result = ((int)array[(int)(num + 1)] << 8 | (int)array[(int)num]);
			}
			else
			{
				result = ((int)array[(int)(num + 3)] << 24 | (int)array[(int)(num + 2)] << 16 | (int)array[(int)(num + 1)] << 8 | (int)array[(int)num]);
			}
			num += (ushort)short_0;
			ushort_0 = num;
			this.method_7(ref array, ref this.byte_1);
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004958 File Offset: 0x00002B58
		private void method_9(int int_0)
		{
			if (this.progressBar_0.InvokeRequired)
			{
				this.progressBar_0.Invoke(new Action<int>(this.method_9), new object[]
				{
					int_0
				});
				return;
			}
			this.progressBar_0.Value = int_0;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000049A8 File Offset: 0x00002BA8
		private int method_10(uint uint_0, byte[] byte_2, char char_0, double double_0, int int_0)
		{
			byte[] array = new byte[byte_2.Length];
			if (int_0 > 0)
			{
				array[0] = byte_2[(int)byte_2[1]];
				array[1] = byte_2[(int)(byte_2[1] + 1)];
				array[2] = byte_2[(int)(byte_2[1] + 2)];
				array[3] = byte_2[(int)(byte_2[1] + 3)];
				array[4] = byte_2[(int)(byte_2[1] + 4)];
				array[5] = byte_2[(int)(byte_2[1] + 5)];
				BitConverter.ToInt32(array, 2);
				int num = (int)array[6];
				if (num <= 0)
				{
				}
				if (uint_0 > 0U && uint_0 != 1U)
				{
					uint num2 = uint_0 - 1U;
				}
				else if (int_0 < (int)char_0)
				{
				}
			}
			return 0;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000247A File Offset: 0x0000067A
		private int method_11(int int_0, int int_1)
		{
			return 0;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000247D File Offset: 0x0000067D
		private int method_12(uint uint_0, byte[] byte_2, char char_0, double double_0, int int_0)
		{
			return this.method_10(uint_0, byte_2, char_0, double_0, int_0);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004A34 File Offset: 0x00002C34
		private void method_13(ref byte[] byte_2, ushort ushort_0, int int_0, int int_1)
		{
			byte b = (byte)int_0;
			if (int_1 - 1 >= 0)
			{
				int num = int_1;
				short num2 = 0;
				int num3 = 0;
				int num4 = 4;
				int num5 = 0;
				do
				{
					if (ushort_0 > 9)
					{
						Class1.smethod_0(num2);
						int num6 = (int)(num2 * 4);
						if (num2 == 1160)
						{
							num2 = num2;
						}
						if (num5 == 256)
						{
							num5 = 0;
						}
						if (num2 >= 256)
						{
							num2 = num2;
							num6 = num5 * 4;
							num6 = num6;
						}
						int num7 = (int)BitConverter.GetBytes((int)BitConverter.ToUInt32(this.byte_0, num6))[(int)(Class1.smethod_0(num2) & 3)];
						byte[] array = byte_2;
						int num8 = num3;
						array[num8] ^= (byte)((int)b ^ num7 ^ (int)num2);
						if (ushort_0 >= 14)
						{
							byte[] array2 = byte_2;
							int num9 = num3;
							array2[num9] ^= (byte)(ushort_0 & 255);
						}
					}
                    else
                    {
                        byte[] array3 = byte_2;
                        int num10 = num3;
                        array3[num10] ^= (byte)(b ^ (byte)((sbyte)num2));
                    }
                    b += (byte)int_0;
					num4 += 4;
					num3++;
					num2 += 1;
					num--;
					num5++;
				}
				while (num > 0);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004B40 File Offset: 0x00002D40
		private int method_14(ref byte[] byte_2, int int_0, int int_1, double double_0)
		{
			byte[] array = byte_2;
			if (byte_2[0] == 0)
			{
				array = this.method_25(byte_2, int_1, double_0);
				byte_2 = array;
			}
			int num = int_0 % 32;
			return (int)array[int_0 % 32 + 84];
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004B78 File Offset: 0x00002D78
		private byte[] method_15(double double_0)
		{
			byte[] array = new byte[120];
			array[84] = 103;
			array[85] = 230;
			array[86] = 9;
			array[87] = 106;
			array[88] = 133;
			array[89] = 174;
			array[90] = 103;
			array[91] = 187;
			array[92] = 114;
			array[93] = 243;
			array[94] = 110;
			array[95] = 60;
			array[96] = 58;
			array[97] = 245;
			array[98] = 79;
			array[99] = 165;
			array[100] = 127;
			array[101] = 82;
			array[102] = 14;
			array[103] = 81;
			array[104] = 140;
			array[105] = 104;
			array[106] = 5;
			array[107] = 155;
			array[108] = 171;
			array[109] = 217;
			array[110] = 131;
			array[111] = 31;
			array[112] = 25;
			array[113] = 205;
			array[114] = 224;
			array[115] = 91;
			return array;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004C78 File Offset: 0x00002E78
		private byte[] method_16(ref byte[] byte_2, byte[] byte_3, uint uint_0)
		{
			byte[] array = byte_2;
			byte[] result = null;
			long value = (long)((ulong)(8U * uint_0));
			BitConverter.GetBytes(value);
			array[8] = BitConverter.GetBytes(value)[0];
			array[9] = BitConverter.GetBytes(value)[1];
			array[10] = BitConverter.GetBytes(value)[2];
			array[11] = BitConverter.GetBytes(value)[3];
			array[12] = BitConverter.GetBytes(value)[4];
			array[13] = BitConverter.GetBytes(value)[5];
			array[14] = BitConverter.GetBytes(value)[6];
			array[15] = BitConverter.GetBytes(value)[7];
			uint num = (uint)array[17];
			int num2 = (int)array[17];
			uint num3 = uint_0 + (uint)num2;
			uint num4 = num3 >> 6;
			int num5 = 64;
			if (num3 >> 6 > 0U)
			{
				uint num6 = 64U - num;
				byte[] byte_4 = this.method_18(array, byte_3, (int)(num + 20U), (int)(64U - num));
				uint num7 = uint_0 - num6;
				array = this.method_19(byte_4);
				int num8 = 64;
				if (num4 - 1U > 0U)
				{
					int num9 = (int)(num4 - 1U);
					do
					{
						byte[] byte_5 = byte_3.Skip(num8).Take(64).ToArray<byte>();
						array = this.method_17(byte_5, array, 20, 64);
						array = array;
						num7 -= 64U;
						num5 += 64;
						num8 += 64;
						array = this.method_19(array);
						array = array;
						num9--;
					}
					while (num9 > 0);
					array[16] = 0;
				}
				array = array;
				byte[] byte_6 = byte_3.Skip(num5).Take((int)num7).ToArray<byte>();
				array = this.method_17(byte_6, array, 20, (int)num7);
				byte[] array2 = array;
				int num10 = 16;
				array2[num10] += (byte)num7;
				result = array;
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004DE4 File Offset: 0x00002FE4
		private byte[] method_17(byte[] byte_2, byte[] byte_3, int int_0, int int_1)
		{
			byte[] array = new byte[byte_3.Length];
			byte_3.CopyTo(array, 0);
			Array.Copy(byte_2, 0, array, int_0, int_1);
			return array;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004E10 File Offset: 0x00003010
		private byte[] method_18(byte[] byte_2, byte[] byte_3, int int_0, int int_1)
		{
			byte[] array = new byte[byte_2.Length];
			byte_2.CopyTo(array, 0);
			Array.Copy(byte_3, 0, array, int_0, int_1);
			return array;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004E3C File Offset: 0x0000303C
		private byte[] method_19(byte[] byte_2)
		{
			uint num = BitConverter.ToUInt32(new byte[]
			{
				byte_2[84],
				byte_2[85],
				byte_2[86],
				byte_2[87]
			}, 0);
			uint num2 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[88],
				byte_2[89],
				byte_2[90],
				byte_2[91]
			}, 0);
			uint num3 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[92],
				byte_2[93],
				byte_2[94],
				byte_2[95]
			}, 0);
			uint num4 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[96],
				byte_2[97],
				byte_2[98],
				byte_2[99]
			}, 0);
			uint num5 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[100],
				byte_2[101],
				byte_2[102],
				byte_2[103]
			}, 0);
			uint num6 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[104],
				byte_2[105],
				byte_2[106],
				byte_2[107]
			}, 0);
			uint num7 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[108],
				byte_2[109],
				byte_2[110],
				byte_2[111]
			}, 0);
			uint num8 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[112],
				byte_2[113],
				byte_2[114],
				byte_2[115]
			}, 0);
			num = num;
			byte[] array = new byte[64];
			Array.Copy(byte_2, 20, array, 0, 64);
			array = array;
			int num9 = 16;
			byte[] array2 = array;
			int num10 = 0;
			do
			{
				if (Class4.smethod_4(Class4.smethod_0(this.form1_0.Text), this.form1_0))
				{
					int uint_ = BitConverter.ToInt32(array, num10);
					byte[] bytes = BitConverter.GetBytes(this.method_30((uint)uint_));
					array2[num10] = bytes[0];
					array2[num10 + 1] = bytes[1];
					array2[num10 + 2] = bytes[2];
					array2[num10 + 3] = bytes[3];
					num10 += 4;
					num9--;
				}
				else
				{
					int uint_2 = BitConverter.ToInt32(array, num10);
					byte[] bytes2 = BitConverter.GetBytes(this.method_30((uint)uint_2));
					array2[num10] = bytes2[3];
					array2[num10 + 1] = bytes2[2];
					array2[num10 + 2] = bytes2[1];
					array2[num10 + 3] = bytes2[0];
					num10 += 4;
					num9--;
				}
			}
			while (num9 > 0);
			byte[] array3 = array2;
			num9 = 48;
			num10 = 0;
			do
			{
				int num11 = 4;
				uint num12 = BitConverter.ToUInt32(array3, num10 + num11);
				uint num13 = num12 >> 3 ^ ((num12 >> 18 | num12 << 14) ^ (num12 >> 7 | num12 << 25));
				BitConverter.GetBytes(num13);
				uint num14 = BitConverter.ToUInt32(array3, num10 + num11 + 32);
				uint num15 = BitConverter.ToUInt32(array3, num10 + num11 - 4);
				int num16 = BitConverter.ToInt32(array3, num10 + num11 + 52);
				uint num17 = (uint)num16 >> 10 ^ ((uint)num16 >> 19 | (uint)((uint)num16 << 13)) ^ ((uint)num16 >> 17 | (uint)((uint)num16 << 15));
				array3 = this.method_29(array3, BitConverter.GetBytes(num17 + num15 + num13 + num14));
				num10 += 4;
				num9--;
			}
			while (num9 > 0);
			num9 = 64;
			num10 = 0;
			byte[] value = new byte[]
			{
				152,
				47,
				138,
				66,
				145,
				68,
				55,
				113,
				207,
				251,
				192,
				181,
				165,
				219,
				181,
				233,
				91,
				194,
				86,
				57,
				241,
				17,
				241,
				89,
				164,
				130,
				63,
				146,
				213,
				94,
				28,
				171,
				152,
				170,
				7,
				216,
				1,
				91,
				131,
				18,
				190,
				133,
				49,
				36,
				195,
				125,
				12,
				85,
				116,
				93,
				190,
				114,
				254,
				177,
				222,
				128,
				167,
				6,
				220,
				155,
				116,
				241,
				155,
				193,
				193,
				105,
				155,
				228,
				134,
				71,
				190,
				239,
				198,
				157,
				193,
				15,
				204,
				161,
				12,
				36,
				111,
				44,
				233,
				45,
				170,
				132,
				116,
				74,
				220,
				169,
				176,
				92,
				218,
				136,
				249,
				118,
				82,
				81,
				62,
				152,
				109,
				198,
				49,
				168,
				200,
				39,
				3,
				176,
				199,
				127,
				89,
				191,
				243,
				11,
				224,
				198,
				71,
				145,
				167,
				213,
				81,
				99,
				202,
				6,
				103,
				41,
				41,
				20,
				133,
				10,
				183,
				39,
				56,
				33,
				27,
				46,
				252,
				109,
				44,
				77,
				19,
				13,
				56,
				83,
				84,
				115,
				10,
				101,
				187,
				10,
				106,
				118,
				46,
				201,
				194,
				129,
				133,
				44,
				114,
				146,
				161,
				232,
				191,
				162,
				75,
				102,
				26,
				168,
				112,
				139,
				75,
				194,
				163,
				81,
				108,
				199,
				25,
				232,
				146,
				209,
				36,
				6,
				153,
				214,
				133,
				53,
				14,
				244,
				112,
				160,
				106,
				16,
				22,
				193,
				164,
				25,
				8,
				108,
				55,
				30,
				76,
				119,
				72,
				39,
				181,
				188,
				176,
				52,
				179,
				12,
				28,
				57,
				74,
				170,
				216,
				78,
				79,
				202,
				156,
				91,
				243,
				111,
				46,
				104,
				238,
				130,
				143,
				116,
				111,
				99,
				165,
				120,
				20,
				120,
				200,
				132,
				8,
				2,
				199,
				140,
				250,
				byte.MaxValue,
				190,
				144,
				235,
				108,
				80,
				164,
				247,
				163,
				249,
				190,
				242,
				120,
				113,
				198
			};
			do
			{
				uint num13 = (num >> 22 | num << 10) ^ (num >> 13 | num << 19) ^ (num >> 2 | num << 30);
				uint num18 = num13 + ((num3 & num2) ^ (num & num3) ^ (num & num2));
				uint num19 = BitConverter.ToUInt32(array3, num10) + BitConverter.ToUInt32(value, num10) + num8 + ((num5 >> 25 | num5 << 7) ^ (num5 >> 11 | num5 << 21) ^ (num5 >> 6 | num5 << 26)) + ((num7 & ~num5) ^ (num5 & num6));
				num8 = num7;
				num7 = num6;
				num6 = num5;
				num5 = num19 + num4;
				num4 = num3;
				num3 = num2;
				num2 = num;
				num = num19 + num18;
				num10 += 4;
				num9--;
			}
			while (num9 > 0);
			uint num20 = BitConverter.ToUInt32(byte_2, 84);
			num20 += num;
			byte_2[84] = BitConverter.GetBytes(num20)[0];
			byte_2[85] = BitConverter.GetBytes(num20)[1];
			byte_2[86] = BitConverter.GetBytes(num20)[2];
			byte_2[87] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 88) + num2;
			byte_2[88] = BitConverter.GetBytes(num20)[0];
			byte_2[89] = BitConverter.GetBytes(num20)[1];
			byte_2[90] = BitConverter.GetBytes(num20)[2];
			byte_2[91] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 92) + num3;
			byte_2[92] = BitConverter.GetBytes(num20)[0];
			byte_2[93] = BitConverter.GetBytes(num20)[1];
			byte_2[94] = BitConverter.GetBytes(num20)[2];
			byte_2[95] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 96) + num4;
			byte_2[96] = BitConverter.GetBytes(num20)[0];
			byte_2[97] = BitConverter.GetBytes(num20)[1];
			byte_2[98] = BitConverter.GetBytes(num20)[2];
			byte_2[99] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 100) + num5;
			byte_2[100] = BitConverter.GetBytes(num20)[0];
			byte_2[101] = BitConverter.GetBytes(num20)[1];
			byte_2[102] = BitConverter.GetBytes(num20)[2];
			byte_2[103] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 104) + num6;
			byte_2[104] = BitConverter.GetBytes(num20)[0];
			byte_2[105] = BitConverter.GetBytes(num20)[1];
			byte_2[106] = BitConverter.GetBytes(num20)[2];
			byte_2[107] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 108) + num7;
			byte_2[108] = BitConverter.GetBytes(num20)[0];
			byte_2[109] = BitConverter.GetBytes(num20)[1];
			byte_2[110] = BitConverter.GetBytes(num20)[2];
			byte_2[111] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 112) + num8;
			byte_2[112] = BitConverter.GetBytes(num20)[0];
			byte_2[113] = BitConverter.GetBytes(num20)[1];
			byte_2[114] = BitConverter.GetBytes(num20)[2];
			byte_2[115] = BitConverter.GetBytes(num20)[3];
			return byte_2;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000248C File Offset: 0x0000068C
		private int method_20(byte[] byte_2)
		{
			return byte_2.Length;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002491 File Offset: 0x00000691
		private ushort method_21(byte[] byte_2)
		{
			return (ushort)BitConverter.ToInt16(new byte[]
			{
				byte_2[byte_2.Length - 2],
				byte_2[byte_2.Length - 1]
			}, 0);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000024B4 File Offset: 0x000006B4
		private int method_22(byte[] byte_2)
		{
			return (int)((ushort)BitConverter.ToInt16(new byte[]
			{
				byte_2[byte_2.Length - 4],
				byte_2[byte_2.Length - 3]
			}, 0));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000024D7 File Offset: 0x000006D7
		private int method_23(byte[] byte_2, int int_0)
		{
			return (int)BitConverter.ToUInt32(new byte[]
			{
				byte_2[int_0],
				byte_2[int_0 + 1],
				byte_2[int_0 + 2],
				byte_2[int_0 + 3]
			}, 0);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000543C File Offset: 0x0000363C
		private byte[] method_24(byte[] byte_2, int int_0, short short_0, double double_0, int int_1)
		{
			byte_2 = byte_2;
			short_0 = (short)Class1.smethod_0(short_0);
			if (int_0 < 32)
			{
				byte_2[int_0 + int_1 - 1] = (byte)short_0;
				byte_2 = byte_2;
				int num = 0;
                while (num < (int_0 & ~1))
                {
                    byte_2[int_1 + num] = BitConverter.GetBytes(0)[0];
					byte_2[int_1 + num + 1] = BitConverter.GetBytes(0)[0];
					num++;
				}
				byte_2 = byte_2;
			}
			else
			{
				byte_2[int_1] = BitConverter.GetBytes(0)[0];
				byte_2[int_1 + 1] = BitConverter.GetBytes(0)[0];
				byte_2[int_1 + 2] = BitConverter.GetBytes(0)[0];
				byte_2[int_1 + 3] = BitConverter.GetBytes(0)[0];
				byte_2[int_1 + 4] = BitConverter.GetBytes(0)[0];
				byte_2[int_1 + 5] = BitConverter.GetBytes(0)[0];
				byte_2[int_1 + 6] = BitConverter.GetBytes(0)[0];
				byte_2[int_1 + 7] = BitConverter.GetBytes(0)[0];
				int num2 = int_0 - 16;
				double value = BitConverter.ToDouble(byte_2, int_1);
				byte_2[int_1 + num2] = BitConverter.GetBytes(value)[0];
				byte_2[int_1 + num2 + 1] = BitConverter.GetBytes(value)[1];
				byte_2[int_1 + num2 + 2] = BitConverter.GetBytes(value)[2];
				byte_2[int_1 + num2 + 3] = BitConverter.GetBytes(value)[3];
				byte_2[int_1 + num2 + 4] = BitConverter.GetBytes(value)[4];
				byte_2[int_1 + num2 + 5] = BitConverter.GetBytes(value)[5];
				byte_2[int_1 + num2 + 6] = BitConverter.GetBytes(value)[6];
				byte_2[int_1 + num2 + 7] = BitConverter.GetBytes(value)[7];
				byte_2[int_1 + 8 + num2] = BitConverter.GetBytes(value)[0];
				byte_2[int_1 + 8 + num2 + 1] = BitConverter.GetBytes(value)[1];
				byte_2[int_1 + 8 + num2 + 2] = BitConverter.GetBytes(value)[2];
				byte_2[int_1 + 8 + num2 + 3] = BitConverter.GetBytes(value)[3];
				byte_2[int_1 + 8 + num2 + 4] = BitConverter.GetBytes(value)[4];
				byte_2[int_1 + 8 + num2 + 5] = BitConverter.GetBytes(value)[5];
				byte_2[int_1 + 8 + num2 + 6] = BitConverter.GetBytes(value)[6];
				byte_2[int_1 + 8 + num2 + 7] = BitConverter.GetBytes(value)[7];
				int num3 = -4;
				num3 = num3;
				int num4 = num3 + num2;
				int num5 = num4 - num3;
				int num6 = -num4;
				bool flag;
				do
				{
					byte_2[int_1 + num5 + num6] = BitConverter.GetBytes(value)[0];
					byte_2[int_1 + num5 + num6 + 1] = BitConverter.GetBytes(value)[1];
					byte_2[int_1 + num5 + num6 + 2] = BitConverter.GetBytes(value)[2];
					byte_2[int_1 + num5 + num6 + 3] = BitConverter.GetBytes(value)[3];
					byte_2[int_1 + num5 + num6 + 4] = BitConverter.GetBytes(value)[4];
					byte_2[int_1 + num5 + num6 + 5] = BitConverter.GetBytes(value)[5];
					byte_2[int_1 + num5 + num6 + 6] = BitConverter.GetBytes(value)[6];
					byte_2[int_1 + num5 + num6 + 7] = BitConverter.GetBytes(value)[7];
					byte_2[int_1 + 8 + num5 + num6] = BitConverter.GetBytes(value)[0];
					byte_2[int_1 + 8 + num5 + num6 + 1] = BitConverter.GetBytes(value)[1];
					byte_2[int_1 + 8 + num5 + num6 + 2] = BitConverter.GetBytes(value)[2];
					byte_2[int_1 + 8 + num5 + num6 + 3] = BitConverter.GetBytes(value)[3];
					byte_2[int_1 + 8 + num5 + num6 + 4] = BitConverter.GetBytes(value)[4];
					byte_2[int_1 + 8 + num5 + num6 + 5] = BitConverter.GetBytes(value)[5];
					byte_2[int_1 + 8 + num5 + num6 + 6] = BitConverter.GetBytes(value)[6];
					byte_2[int_1 + 8 + num5 + num6 + 7] = BitConverter.GetBytes(value)[7];
					flag = (num6 + 16 < 0);
					num6 += 16;
				}
				while (flag);
			}
			return byte_2;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000057A4 File Offset: 0x000039A4
		private byte[] method_25(byte[] byte_2, int int_0, double double_0)
		{
			byte[] array = byte_2;
			uint num = BitConverter.ToUInt32(byte_2, 16);
			num = num;
			byte b = byte_2[(int)(num + 20U)];
			b = 128;
			byte_2[(int)(num + 20U)] = b;
			uint num2 = BitConverter.ToUInt32(byte_2, 16);
			if (num2 < 56U)
            {
                byte[] array2 = array;
                int num3 = 16;
                byte b2 = array2[num3];
                array2[num3] = (byte)(b2 + 1);
                if ((short)b2 > (short)(array[16] + 1))
                {
                }
            }
            else
            {
				int num4 = (int)(num2 + 1U);
				if (num4 <= 63)
				{
					byte b3 = array[num4 + 20];
					do
					{
						b3 = 0;
						array[num4 + 20] = b3;
						num4++;
						b3 += 1;
					}
					while (num4 != 64);
				}
				byte[] array3 = this.method_28(array);
				array3[16] = 0;
				array = array3;
			}
			uint num5 = BitConverter.ToUInt32(array, 16);
			num5 = num5;
			array = this.method_24(array, (int)(56U - num5), 0, double_0, (int)(num5 + 20U));
			uint value = (uint)this.method_30(BitConverter.ToUInt32(array, 12));
			array[76] = BitConverter.GetBytes(value)[0];
			array[77] = BitConverter.GetBytes(value)[1];
			array[78] = BitConverter.GetBytes(value)[2];
			array[79] = BitConverter.GetBytes(value)[3];
			array = array;
			value = (uint)this.method_30(BitConverter.ToUInt32(array, 8));
			array[80] = BitConverter.GetBytes(value)[0];
			array[81] = BitConverter.GetBytes(value)[1];
			array[82] = BitConverter.GetBytes(value)[2];
			array[83] = BitConverter.GetBytes(value)[3];
			array = this.method_19(array);
			value = (uint)this.method_30(BitConverter.ToUInt32(array, 84));
			array[84] = BitConverter.GetBytes(value)[0];
			array[85] = BitConverter.GetBytes(value)[1];
			array[86] = BitConverter.GetBytes(value)[2];
			array[87] = BitConverter.GetBytes(value)[3];
			value = (uint)this.method_30(BitConverter.ToUInt32(array, 88));
			array[88] = BitConverter.GetBytes(value)[0];
			array[89] = BitConverter.GetBytes(value)[1];
			array[90] = BitConverter.GetBytes(value)[2];
			array[91] = BitConverter.GetBytes(value)[3];
			value = (uint)this.method_30(BitConverter.ToUInt32(array, 92));
			array[92] = BitConverter.GetBytes(value)[0];
			array[93] = BitConverter.GetBytes(value)[1];
			array[94] = BitConverter.GetBytes(value)[2];
			array[95] = BitConverter.GetBytes(value)[3];
			value = (uint)this.method_30(BitConverter.ToUInt32(array, 96));
			array[96] = BitConverter.GetBytes(value)[0];
			array[97] = BitConverter.GetBytes(value)[1];
			array[98] = BitConverter.GetBytes(value)[2];
			array[99] = BitConverter.GetBytes(value)[3];
			value = (uint)this.method_30(BitConverter.ToUInt32(array, 100));
			array[100] = BitConverter.GetBytes(value)[0];
			array[101] = BitConverter.GetBytes(value)[1];
			array[102] = BitConverter.GetBytes(value)[2];
			array[103] = BitConverter.GetBytes(value)[3];
			value = (uint)this.method_30(BitConverter.ToUInt32(array, 104));
			array[104] = BitConverter.GetBytes(value)[0];
			array[105] = BitConverter.GetBytes(value)[1];
			array[106] = BitConverter.GetBytes(value)[2];
			array[107] = BitConverter.GetBytes(value)[3];
			value = (uint)this.method_30(BitConverter.ToUInt32(array, 108));
			array[108] = BitConverter.GetBytes(value)[0];
			array[109] = BitConverter.GetBytes(value)[1];
			array[110] = BitConverter.GetBytes(value)[2];
			array[111] = BitConverter.GetBytes(value)[3];
			value = (uint)this.method_30(BitConverter.ToUInt32(array, 112));
			array[112] = BitConverter.GetBytes(value)[0];
			array[113] = BitConverter.GetBytes(value)[1];
			array[114] = BitConverter.GetBytes(value)[2];
			array[115] = BitConverter.GetBytes(value)[3];
			array[0] = 1;
			return array;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002503 File Offset: 0x00000703
		private static byte smethod_0(short short_0)
		{
			return (byte)(short_0 >> 8);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005B1C File Offset: 0x00003D1C
		private byte[] method_26(byte[] byte_2, int int_0, ushort ushort_0)
		{
			ushort_0 = (ushort)Class1.smethod_0((short)ushort_0);
			if (int_0 < 32)
			{
				byte_2[int_0 - 1] = (byte)ushort_0;
				for (int i = 0; i < 22; i++)
				{
					byte_2[i] = 0;
				}
			}
			else
			{
				for (int j = 0; j < 44; j++)
				{
					byte_2[j] = 0;
				}
			}
			return byte_2;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005B68 File Offset: 0x00003D68
		private byte[] method_27(byte[] byte_2, uint uint_0)
		{
			byte[] array = new byte[120];
			array[84] = 103;
			array[85] = 230;
			array[86] = 9;
			array[87] = 106;
			array[88] = 133;
			array[89] = 174;
			array[90] = 103;
			array[91] = 187;
			array[92] = 114;
			array[93] = 243;
			array[94] = 110;
			array[95] = 60;
			array[96] = 58;
			array[97] = 245;
			array[98] = 79;
			array[99] = 165;
			array[100] = 127;
			array[101] = 82;
			array[102] = 14;
			array[103] = 81;
			array[104] = 140;
			array[105] = 104;
			array[106] = 5;
			array[107] = 155;
			array[108] = 171;
			array[109] = 217;
			array[110] = 131;
			array[111] = 31;
			array[112] = 25;
			array[113] = 205;
			array[114] = 224;
			array[115] = 91;
			byte b = byte_2[0];
			byte[] array2 = BitConverter.GetBytes((short)(8U * uint_0));
			Array.Reverse(array2);
			array2 = array2;
			array[9] = array2[0];
			array[10] = array2[1];
			uint num = uint_0 >> 6;
			int num2 = 0;
			int num3 = 0;
			if (uint_0 + (uint)num3 >> 6 > 0U)
			{
				int num4 = 64 - num2;
				uint_0 -= (uint)num4;
				byte[] destinationArray = new byte[array.Length - num2 - 20];
				Array.Copy(array, num2 + 20, destinationArray, 0, array.Length - num2 - 20);
				byte[] array3 = new byte[64];
				Array.Copy(byte_2, 0, array3, 0, array3.Length);
				array3 = array3;
				Array.Copy(array3, 0, array, 20, array3.Length);
				array = array;
				this.method_28(array);
				if (num - 1U > 0U)
				{
					int num5 = (int)(num - 1U);
					byte[] array4 = new byte[64];
					int num6 = 64;
					Array.Copy(byte_2, num6, array4, 0, array4.Length);
					array4 = array4;
					do
					{
						num6 += 64;
						Array.Copy(byte_2, num6, array4, 0, array4.Length);
						array4 = array4;
						uint_0 -= 64U;
						num5--;
					}
					while (num5 > 0);
				}
			}
			return array;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005D68 File Offset: 0x00003F68
		private byte[] method_28(byte[] byte_2)
		{
			uint num = BitConverter.ToUInt32(new byte[]
			{
				byte_2[84],
				byte_2[85],
				byte_2[86],
				byte_2[87]
			}, 0);
			uint num2 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[88],
				byte_2[89],
				byte_2[90],
				byte_2[91]
			}, 0);
			uint num3 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[92],
				byte_2[93],
				byte_2[94],
				byte_2[95]
			}, 0);
			uint num4 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[96],
				byte_2[97],
				byte_2[98],
				byte_2[99]
			}, 0);
			uint num5 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[100],
				byte_2[101],
				byte_2[102],
				byte_2[103]
			}, 0);
			uint num6 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[104],
				byte_2[105],
				byte_2[106],
				byte_2[107]
			}, 0);
			uint num7 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[108],
				byte_2[109],
				byte_2[110],
				byte_2[111]
			}, 0);
			uint num8 = BitConverter.ToUInt32(new byte[]
			{
				byte_2[112],
				byte_2[113],
				byte_2[114],
				byte_2[115]
			}, 0);
			num = num;
			byte[] array = new byte[64];
			Array.Copy(byte_2, 20, array, 0, 64);
			array = array;
			int num9 = 16;
			byte[] array2 = array;
			int num10 = 0;
			do
			{
				int uint_ = BitConverter.ToInt32(array, num10);
				byte[] bytes = BitConverter.GetBytes(this.method_30((uint)uint_));
				array2[num10] = bytes[0];
				array2[num10 + 1] = bytes[1];
				array2[num10 + 2] = bytes[2];
				array2[num10 + 3] = bytes[3];
				num10 += 4;
				num9--;
			}
			while (num9 > 0);
			byte[] array3 = array2;
			num9 = 48;
			num10 = 0;
			do
			{
				int num11 = 4;
				uint num12 = BitConverter.ToUInt32(array3, num10 + num11);
				uint num13 = num12 >> 3 ^ ((num12 >> 18 | num12 << 14) ^ (num12 >> 7 | num12 << 25));
				BitConverter.GetBytes(num13);
				uint num14 = BitConverter.ToUInt32(array3, num10 + num11 + 32);
				uint num15 = BitConverter.ToUInt32(array3, num10 + num11 - 4);
				int num16 = BitConverter.ToInt32(array3, num10 + num11 + 52);
				uint num17 = (uint)num16 >> 10 ^ ((uint)num16 >> 19 | (uint)((uint)num16 << 13)) ^ ((uint)num16 >> 17 | (uint)((uint)num16 << 15));
				array3 = this.method_29(array3, BitConverter.GetBytes(num17 + num15 + num13 + num14));
				num10 += 4;
				num9--;
			}
			while (num9 > 0);
			num9 = 64;
			num10 = 0;
			byte[] value = new byte[]
			{
				152,
				47,
				138,
				66,
				145,
				68,
				55,
				113,
				207,
				251,
				192,
				181,
				165,
				219,
				181,
				233,
				91,
				194,
				86,
				57,
				241,
				17,
				241,
				89,
				164,
				130,
				63,
				146,
				213,
				94,
				28,
				171,
				152,
				170,
				7,
				216,
				1,
				91,
				131,
				18,
				190,
				133,
				49,
				36,
				195,
				125,
				12,
				85,
				116,
				93,
				190,
				114,
				254,
				177,
				222,
				128,
				167,
				6,
				220,
				155,
				116,
				241,
				155,
				193,
				193,
				105,
				155,
				228,
				134,
				71,
				190,
				239,
				198,
				157,
				193,
				15,
				204,
				161,
				12,
				36,
				111,
				44,
				233,
				45,
				170,
				132,
				116,
				74,
				220,
				169,
				176,
				92,
				218,
				136,
				249,
				118,
				82,
				81,
				62,
				152,
				109,
				198,
				49,
				168,
				200,
				39,
				3,
				176,
				199,
				127,
				89,
				191,
				243,
				11,
				224,
				198,
				71,
				145,
				167,
				213,
				81,
				99,
				202,
				6,
				103,
				41,
				41,
				20,
				133,
				10,
				183,
				39,
				56,
				33,
				27,
				46,
				252,
				109,
				44,
				77,
				19,
				13,
				56,
				83,
				84,
				115,
				10,
				101,
				187,
				10,
				106,
				118,
				46,
				201,
				194,
				129,
				133,
				44,
				114,
				146,
				161,
				232,
				191,
				162,
				75,
				102,
				26,
				168,
				112,
				139,
				75,
				194,
				163,
				81,
				108,
				199,
				25,
				232,
				146,
				209,
				36,
				6,
				153,
				214,
				133,
				53,
				14,
				244,
				112,
				160,
				106,
				16,
				22,
				193,
				164,
				25,
				8,
				108,
				55,
				30,
				76,
				119,
				72,
				39,
				181,
				188,
				176,
				52,
				179,
				12,
				28,
				57,
				74,
				170,
				216,
				78,
				79,
				202,
				156,
				91,
				243,
				111,
				46,
				104,
				238,
				130,
				143,
				116,
				111,
				99,
				165,
				120,
				20,
				120,
				200,
				132,
				8,
				2,
				199,
				140,
				250,
				byte.MaxValue,
				190,
				144,
				235,
				108,
				80,
				164,
				247,
				163,
				249,
				190,
				242,
				120,
				113,
				198
			};
			do
			{
				uint num13 = (num >> 22 | num << 10) ^ (num >> 13 | num << 19) ^ (num >> 2 | num << 30);
				uint num18 = num13 + ((num3 & num2) ^ (num & num3) ^ (num & num2));
				uint num19 = BitConverter.ToUInt32(array3, num10) + BitConverter.ToUInt32(value, num10) + num8 + ((num5 >> 25 | num5 << 7) ^ (num5 >> 11 | num5 << 21) ^ (num5 >> 6 | num5 << 26)) + ((num7 & ~num5) ^ (num5 & num6));
				num8 = num7;
				num7 = num6;
				num6 = num5;
				num5 = num19 + num4;
				num4 = num3;
				num3 = num2;
				num2 = num;
				num = num19 + num18;
				num10 += 4;
				num9--;
			}
			while (num9 > 0);
			uint num20 = BitConverter.ToUInt32(byte_2, 84);
			num20 += num;
			byte_2[84] = BitConverter.GetBytes(num20)[0];
			byte_2[85] = BitConverter.GetBytes(num20)[1];
			byte_2[86] = BitConverter.GetBytes(num20)[2];
			byte_2[87] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 88) + num2;
			byte_2[88] = BitConverter.GetBytes(num20)[0];
			byte_2[89] = BitConverter.GetBytes(num20)[1];
			byte_2[90] = BitConverter.GetBytes(num20)[2];
			byte_2[91] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 92) + num3;
			byte_2[92] = BitConverter.GetBytes(num20)[0];
			byte_2[93] = BitConverter.GetBytes(num20)[1];
			byte_2[94] = BitConverter.GetBytes(num20)[2];
			byte_2[95] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 96) + num4;
			byte_2[96] = BitConverter.GetBytes(num20)[0];
			byte_2[97] = BitConverter.GetBytes(num20)[1];
			byte_2[98] = BitConverter.GetBytes(num20)[2];
			byte_2[99] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 100) + num5;
			byte_2[100] = BitConverter.GetBytes(num20)[0];
			byte_2[101] = BitConverter.GetBytes(num20)[1];
			byte_2[102] = BitConverter.GetBytes(num20)[2];
			byte_2[103] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 104) + num6;
			byte_2[104] = BitConverter.GetBytes(num20)[0];
			byte_2[105] = BitConverter.GetBytes(num20)[1];
			byte_2[106] = BitConverter.GetBytes(num20)[2];
			byte_2[107] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 108) + num7;
			byte_2[108] = BitConverter.GetBytes(num20)[0];
			byte_2[109] = BitConverter.GetBytes(num20)[1];
			byte_2[110] = BitConverter.GetBytes(num20)[2];
			byte_2[111] = BitConverter.GetBytes(num20)[3];
			num20 = BitConverter.ToUInt32(byte_2, 112) + num8;
			byte_2[112] = BitConverter.GetBytes(num20)[0];
			byte_2[113] = BitConverter.GetBytes(num20)[1];
			byte_2[114] = BitConverter.GetBytes(num20)[2];
			byte_2[115] = BitConverter.GetBytes(num20)[3];
			return byte_2;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002509 File Offset: 0x00000709
		private static string smethod_1(string string_0)
		{
			char[] array = string_0.ToCharArray();
			Array.Reverse(array);
			return new string(array);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000062F0 File Offset: 0x000044F0
		private byte[] method_29(byte[] byte_2, byte[] byte_3)
		{
			int num = byte_2.Length + byte_3.Length;
			int val = byte_2.Length;
			byte_2.GetType().GetElementType();
			byte[] array = new byte[num];
			int num2 = Math.Min(val, num);
			if (num2 > 0)
			{
				Array.Copy(byte_2, array, num2);
			}
			array[array.Length - 4] = byte_3[0];
			array[array.Length - 3] = byte_3[1];
			array[array.Length - 2] = byte_3[2];
			array[array.Length - 1] = byte_3[3];
			return array;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000251C File Offset: 0x0000071C
		private int method_30(uint uint_0)
		{
			return (int)((uint_0 << 8 & 16711680U) | (uint_0 >> 8 & 65280U) | uint_0 << 24 | uint_0 >> 24);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006358 File Offset: 0x00004558
		private int method_31(byte[] byte_2, int int_0, int int_1)
		{
			ushort[] array = new ushort[]
			{
				0,
				49345,
				49537,
				320,
				49921,
				960,
				640,
				49729,
				50689,
				1728,
				1920,
				51009,
				1280,
				50625,
				50305,
				1088,
				52225,
				3264,
				3456,
				52545,
				3840,
				53185,
				52865,
				3648,
				2560,
				51905,
				52097,
				2880,
				51457,
				2496,
				2176,
				51265,
				55297,
				6336,
				6528,
				55617,
				6912,
				56257,
				55937,
				6720,
				7680,
				57025,
				57217,
				8000,
				56577,
				7616,
				7296,
				56385,
				5120,
				54465,
				54657,
				5440,
				55041,
				6080,
				5760,
				54849,
				53761,
				4800,
				4992,
				54081,
				4352,
				53697,
				53377,
				4160,
				61441,
				12480,
				12672,
				61761,
				13056,
				62401,
				62081,
				12864,
				13824,
				63169,
				63361,
				14144,
				62721,
				13760,
				13440,
				62529,
				15360,
				64705,
				64897,
				15680,
				65281,
				16320,
				16000,
				65089,
				64001,
				15040,
				15232,
				64321,
				14592,
				63937,
				63617,
				14400,
				10240,
				59585,
				59777,
				10560,
				60161,
				11200,
				10880,
				59969,
				60929,
				11968,
				12160,
				61249,
				11520,
				60865,
				60545,
				11328,
				58369,
				9408,
				9600,
				58689,
				9984,
				59329,
				59009,
				9792,
				8704,
				58049,
				58241,
				9024,
				57601,
				8640,
				8320,
				57409,
				40961,
				24768,
				24960,
				41281,
				25344,
				41921,
				41601,
				25152,
				26112,
				42689,
				42881,
				26432,
				42241,
				26048,
				25728,
				42049,
				27648,
				44225,
				44417,
				27968,
				44801,
				28608,
				28288,
				44609,
				43521,
				27328,
				27520,
				43841,
				26880,
				43457,
				43137,
				26688,
				30720,
				47297,
				47489,
				31040,
				47873,
				31680,
				31360,
				47681,
				48641,
				32448,
				32640,
				48961,
				32000,
				48577,
				48257,
				31808,
				46081,
				29888,
				30080,
				46401,
				30464,
				47041,
				46721,
				30272,
				29184,
				45761,
				45953,
				29504,
				45313,
				29120,
				28800,
				45121,
				20480,
				37057,
				37249,
				20800,
				37633,
				21440,
				21120,
				37441,
				38401,
				22208,
				22400,
				38721,
				21760,
				38337,
				38017,
				21568,
				39937,
				23744,
				23936,
				40257,
				24320,
				40897,
				40577,
				24128,
				23040,
				39617,
				39809,
				23360,
				39169,
				22976,
				22656,
				38977,
				34817,
				18624,
				18816,
				35137,
				19200,
				35777,
				35457,
				19008,
				19968,
				36545,
				36737,
				20288,
				36097,
				19904,
				19584,
				35905,
				17408,
				33985,
				34177,
				17728,
				34561,
				18368,
				18048,
				34369,
				33281,
				17088,
				17280,
				33601,
				16640,
				33217,
				32897,
				16448
			};
			int num = 0;
			if (int_0 - 1 >= 0)
			{
				int num2 = int_0;
				do
				{
					ushort num3 = (ushort)((byte)((ushort)((byte)int_1 ^ byte_2[num])));
					int num4 = (int)array[(int)num3];
					num4 = num4;
					num4 = ((ushort)int_1 >> 8 ^ (int)((short)num4));
					int_1 = num4;
					num++;
					num2--;
				}
				while (num2 > 0);
			}
			return int_1;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000253B File Offset: 0x0000073B
		private ushort method_32(int int_0)
		{
			return (ushort)((long)int_0 & 65535L);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000063C0 File Offset: 0x000045C0
		private int method_33(byte[] byte_2, int int_0)
		{
			int num = 0;
			for (;;)
			{
				if (int_0 != 0)
				{
					if (int_0 != 1)
					{
						if (int_0 != 7)
						{
							break;
						}
						byte byte_3 = byte_2[num];
						byte[] array = new byte[byte_2.Length - num];
						Array.Copy(byte_2, num, array, 0, byte_2.Length - num);
						this.method_34(num + 20, byte_2, array, byte_3, 0);
						num++;
					}
					else
					{
						bool flag = byte_2[num] != 0;
						num++;
						if (((flag ? 1 : 0) & 32) == 0)
						{
							int_0 = 7;
						}
						else
						{
							num++;
							int_0 = 2;
						}
					}
				}
				else if ((byte_2[num] & 15) == 8)
				{
					num++;
					int_0 = 1;
				}
			}
			return -2;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000644C File Offset: 0x0000464C
		private int method_34(int int_0, byte[] byte_2, byte[] byte_3, byte byte_4, int int_1)
        {
            var fieldInfo = typeof(Class19).GetField("struct2_0", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic);

            RuntimeHelpers.InitializeArray(new byte[18], fieldInfo.FieldHandle);
            int num = 0;
			int i = byte_3.Length;
			int num2 = 0;
			int j = 0;
			int num3 = 0;
			byte b = byte_3[12];
			if (b >= byte_3[11])
			{
				byte b2 = byte_3[10];
			}
			else
			{
				byte b3 = byte_3[11];
			}
			for (;;)
			{
				IL_1B3:
				switch (num3)
				{
				case 0:
				{
					IL_166:
					while (j < 3)
					{
						while (i > 0)
						{
							i--;
							byte b4 = byte_3[num++];
							num2 |= (int)b4 << j;
							j += 8;
							if (j >= 3)
							{
								goto IL_166;
							}
						}
						goto IL_1B3;
					}
					int num4 = num2 & 7;
					num4 = num4;
					if (num4 >> 1 < 1)
					{
						num3 = 1;
					}
					else if (num4 >> 1 == 1)
					{
						num3 = 6;
					}
					else if (num4 >> 1 == 2)
					{
						num2 >>= 3;
						j -= 3;
						num3 = 3;
					}
					else if (num4 >> 1 == 3)
					{
						num3 = 9;
					}
					break;
				}
				case 3:
				{
					IL_C2:
					while (j < 14)
					{
						while (i > 0)
						{
							i--;
							byte b4 = byte_3[num++];
							num2 |= (int)b4 << j;
							j += 8;
							if (j >= 14)
							{
								goto IL_C2;
							}
						}
						goto IL_1B3;
					}
					int num5 = num2 & 16383;
					num5 = num5;
					if ((num2 & 31) <= 29 && (num5 >> 5 & 31) <= 29)
					{
						int num6 = ((num2 & 16383) >> 5 & 31) + (num2 & 31) + 258;
						if (num6 < 19)
						{
							num6 = 19;
						}
						if (4 * num6 > 0)
						{
							num2 >>= 14;
							j -= 14;
							num3 = 4;
						}
					}
					else
					{
						num3 = 9;
					}
					break;
				}
				case 4:
					for (;;)
					{
						IL_8E:
						if (j < 3)
						{
							while (i > 0)
							{
								i--;
								byte b4 = byte_3[num++];
								num2 |= (int)b4 << j;
								j += 8;
								if (j >= 3)
								{
									goto IL_8E;
								}
							}
							break;
						}
						num2 >>= 3;
						j -= 3;
					}
					break;
				}
			}
		}

        private object fieldof(Class19.Struct2 struct2_0)
        {
            throw new NotImplementedException();
        }

        // Token: 0x0400000A RID: 10
        private byte[] byte_0 = Class6.tablica_offset;

		// Token: 0x0400000B RID: 11
		private byte[] byte_1 = new byte[]
		{
			17,
			6,
			84,
			66,
			121,
			116,
			101,
			115,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			17
		};

		// Token: 0x0400000C RID: 12
		private Form1 form1_0;

		// Token: 0x0400000D RID: 13
		private ProgressBar progressBar_0;
	}
}
