using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x0200001A RID: 26
	public sealed class GClass5 : GInterface1, IDisposable
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00002C41 File Offset: 0x00000E41
		public GClass5(string string_1) : this(string_1, false)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002C4B File Offset: 0x00000E4B
		public GClass5(string string_1, bool bool_1)
		{
			this.string_0 = string_1;
			if (!bool_1)
			{
				this.stream_0 = File.Open(string_1, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
			}
			else
			{
				this.stream_0 = File.Open(string_1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			this.bool_0 = bool_1;
			this.method_7();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000A2F8 File Offset: 0x000084F8
		public GClass5(Stream stream_1)
		{
			if (stream_1 == null)
			{
				throw new ArgumentNullException("stream");
			}
			if (!stream_1.CanSeek)
			{
				throw new ArgumentException("stream must supported seek operations(CanSeek)");
			}
			this.stream_0 = stream_1;
			this.bool_0 = !stream_1.CanWrite;
			this.method_7();
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000A348 File Offset: 0x00008548
		[CompilerGenerated]
		public void imethod_5(EventHandler eventHandler_2)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000A380 File Offset: 0x00008580
		[CompilerGenerated]
		public void imethod_6(EventHandler eventHandler_2)
		{
			EventHandler eventHandler = this.eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000A3B8 File Offset: 0x000085B8
		[CompilerGenerated]
		public void imethod_9(EventHandler eventHandler_2)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000A3F0 File Offset: 0x000085F0
		[CompilerGenerated]
		public void imethod_10(EventHandler eventHandler_2)
		{
			EventHandler eventHandler = this.eventHandler_1;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value = (EventHandler)Delegate.Remove(eventHandler2, eventHandler_2);
				eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000A428 File Offset: 0x00008628
		public byte imethod_0(long long_1)
		{
			long num;
			Class8 @class = this.method_3(long_1, out num);
			Class9 class2 = @class as Class9;
			if (class2 != null)
			{
				return this.method_5(class2.Int64_0 + long_1 - num);
			}
			return ((Class10)@class).Byte_0[(int)(checked((IntPtr)(unchecked(long_1 - num))))];
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000A46C File Offset: 0x0000866C
		public void imethod_1(long long_1, byte byte_0)
		{
			try
			{
				long num;
				Class8 @class = this.method_3(long_1, out num);
				Class10 class2 = @class as Class10;
				if (class2 != null)
				{
					class2.Byte_0[(int)(checked((IntPtr)(unchecked(long_1 - num))))] = byte_0;
				}
				else
				{
					Class9 class3 = (Class9)@class;
					if (num == long_1 && @class.Class8_1 != null)
					{
						Class10 class4 = @class.Class8_1 as Class10;
						if (class4 != null)
						{
							class4.method_0(byte_0);
							class3.method_2(1L);
							if (class3.vmethod_0() == 0L)
							{
								this.class11_0.method_4(class3);
							}
							return;
						}
					}
					if (num + class3.vmethod_0() - 1L == long_1 && @class.Class8_0 != null)
					{
						Class10 class5 = @class.Class8_0 as Class10;
						if (class5 != null)
						{
							class5.method_1(byte_0);
							class3.method_1(1L);
							if (class3.vmethod_0() == 0L)
							{
								this.class11_0.method_4(class3);
							}
							return;
						}
					}
					Class9 class6 = null;
					if (long_1 > num)
					{
						class6 = new Class9(class3.Int64_0, long_1 - num);
					}
					Class9 class7 = null;
					if (long_1 < num + class3.vmethod_0() - 1L)
					{
						class7 = new Class9(class3.Int64_0 + long_1 - num + 1L, class3.vmethod_0() - (long_1 - num + 1L));
					}
					@class = this.class11_0.method_7(@class, new Class10(byte_0));
					if (class6 != null)
					{
						this.class11_0.method_1(@class, class6);
					}
					if (class7 != null)
					{
						this.class11_0.method_0(@class, class7);
					}
				}
			}
			finally
			{
				this.method_2(EventArgs.Empty);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000A5E8 File Offset: 0x000087E8
		public void imethod_2(long long_1, byte[] byte_0)
		{
			try
			{
				long num;
				Class8 @class = this.method_3(long_1, out num);
				Class10 class2 = @class as Class10;
				if (class2 != null)
				{
					class2.method_2(long_1 - num, byte_0);
				}
				else
				{
					Class9 class3 = (Class9)@class;
					if (num == long_1 && @class.Class8_1 != null)
					{
						Class10 class4 = @class.Class8_1 as Class10;
						if (class4 != null)
						{
							class4.method_2(class4.vmethod_0(), byte_0);
							return;
						}
					}
					Class9 class5 = null;
					if (long_1 > num)
					{
						class5 = new Class9(class3.Int64_0, long_1 - num);
					}
					Class9 class6 = null;
					if (long_1 < num + class3.vmethod_0())
					{
						class6 = new Class9(class3.Int64_0 + long_1 - num, class3.vmethod_0() - (long_1 - num));
					}
					@class = this.class11_0.method_7(@class, new Class10(byte_0));
					if (class5 != null)
					{
						this.class11_0.method_1(@class, class5);
					}
					if (class6 != null)
					{
						this.class11_0.method_0(@class, class6);
					}
				}
			}
			finally
			{
				this.long_0 += (long)byte_0.Length;
				this.method_1(EventArgs.Empty);
				this.method_2(EventArgs.Empty);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000A704 File Offset: 0x00008904
		public void imethod_3(long long_1, long long_2)
		{
			try
			{
				long num = long_2;
				long num2;
				Class8 @class = this.method_3(long_1, out num2);
				while (num > 0L && @class != null)
				{
					long num3 = @class.vmethod_0();
					Class8 class8_ = @class.Class8_0;
					long num4 = Math.Min(num, num3 - (long_1 - num2));
					@class.vmethod_1(long_1 - num2, num4);
					if (@class.vmethod_0() == 0L)
					{
						this.class11_0.method_4(@class);
						if (this.class11_0.Class8_0 == null)
						{
							this.class11_0.method_2(new Class10(new byte[0]));
						}
					}
					num -= num4;
					num2 += @class.vmethod_0();
					@class = ((num > 0L) ? class8_ : null);
				}
			}
			finally
			{
				this.long_0 -= long_2;
				this.method_1(EventArgs.Empty);
				this.method_2(EventArgs.Empty);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002C8A File Offset: 0x00000E8A
		public long imethod_4()
		{
			return this.long_0;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000A7E0 File Offset: 0x000089E0
		public bool imethod_7()
		{
			if (this.bool_0)
			{
				return false;
			}
			if (this.long_0 != this.stream_0.Length)
			{
				return true;
			}
			long num = 0L;
			for (Class8 class8_ = this.class11_0.Class8_0; class8_ != null; class8_ = class8_.Class8_0)
			{
				Class9 @class = class8_ as Class9;
				if (@class == null)
				{
					return true;
				}
				if (@class.Int64_0 != num)
				{
					return true;
				}
				num += @class.vmethod_0();
			}
			return num != this.stream_0.Length;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000A85C File Offset: 0x00008A5C
		public void imethod_8()
		{
			if (this.bool_0)
			{
				throw new OperationCanceledException("File is in read-only mode");
			}
			if (this.long_0 > this.stream_0.Length)
			{
				this.stream_0.SetLength(this.long_0);
			}
			long num = 0L;
			for (Class8 class8_ = this.class11_0.Class8_0; class8_ != null; class8_ = class8_.Class8_0)
			{
				Class9 @class = class8_ as Class9;
				if (@class != null && @class.Int64_0 != num)
				{
					this.method_6(@class, num);
				}
				num += class8_.vmethod_0();
			}
			num = 0L;
			for (Class8 class8_2 = this.class11_0.Class8_0; class8_2 != null; class8_2 = class8_2.Class8_0)
			{
				Class10 class2 = class8_2 as Class10;
				if (class2 != null)
				{
					this.stream_0.Position = num;
					int num2 = 0;
					while ((long)num2 < class2.vmethod_0())
					{
						this.stream_0.Write(class2.Byte_0, num2, (int)Math.Min(4096L, class2.vmethod_0() - (long)num2));
						num2 += 4096;
					}
				}
				num += class8_2.vmethod_0();
			}
			this.stream_0.SetLength(this.long_0);
			this.method_7();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000A978 File Offset: 0x00008B78
		public void method_0(string string_1)
		{
			using (FileStream fileStream = File.Open(string_1, FileMode.Create, FileAccess.ReadWrite, FileShare.Read))
			{
				byte[] array = new byte[this.stream_0.Length];
				this.stream_0.Read(array, 0, array.Length);
				fileStream.Write(array, 0, array.Length);
				long num = 0L;
				for (Class8 class8_ = this.class11_0.Class8_0; class8_ != null; class8_ = class8_.Class8_0)
				{
					Class9 @class = class8_ as Class9;
					if (@class != null && @class.Int64_0 != num)
					{
						this.method_6(@class, num);
					}
					num += class8_.vmethod_0();
				}
				num = 0L;
				for (Class8 class8_2 = this.class11_0.Class8_0; class8_2 != null; class8_2 = class8_2.Class8_0)
				{
					Class10 class2 = class8_2 as Class10;
					if (class2 != null)
					{
						fileStream.Position = num;
						int num2 = 0;
						while ((long)num2 < class2.vmethod_0())
						{
							fileStream.Write(class2.Byte_0, num2, (int)Math.Min(4096L, class2.vmethod_0() - (long)num2));
							num2 += 4096;
						}
					}
					num += class8_2.vmethod_0();
				}
				fileStream.SetLength(this.long_0);
				fileStream.Close();
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00002C92 File Offset: 0x00000E92
		public bool imethod_11()
		{
			return !this.bool_0;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002C92 File Offset: 0x00000E92
		public bool imethod_12()
		{
			return !this.bool_0;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002C92 File Offset: 0x00000E92
		public bool imethod_13()
		{
			return !this.bool_0;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		~GClass5()
		{
			this.Dispose();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002C9D File Offset: 0x00000E9D
		public void Dispose()
		{
			if (this.stream_0 != null)
			{
				this.stream_0.Close();
				this.stream_0 = null;
			}
			this.string_0 = null;
			this.class11_0 = null;
			GC.SuppressFinalize(this);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002CCD File Offset: 0x00000ECD
		public bool Boolean_0
		{
			get
			{
				return this.bool_0;
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002CD5 File Offset: 0x00000ED5
		private void method_1(EventArgs eventArgs_0)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, eventArgs_0);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002CEC File Offset: 0x00000EEC
		private void method_2(EventArgs eventArgs_0)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, eventArgs_0);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000AAE4 File Offset: 0x00008CE4
		private Class8 method_3(long long_1, out long long_2)
		{
			if (long_1 >= 0L && long_1 <= this.long_0)
			{
				long_2 = 0L;
				for (Class8 class8_ = this.class11_0.Class8_0; class8_ != null; class8_ = class8_.Class8_0)
				{
					if ((long_2 <= long_1 && long_2 + class8_.vmethod_0() > long_1) || class8_.Class8_0 == null)
					{
						return class8_;
					}
					long_2 += class8_.vmethod_0();
				}
				return null;
			}
			throw new ArgumentOutOfRangeException("findOffset");
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000AB50 File Offset: 0x00008D50
		private Class9 method_4(Class8 class8_0, long long_1, out long long_2)
		{
			long_2 = long_1 + class8_0.vmethod_0();
			for (class8_0 = class8_0.Class8_0; class8_0 != null; class8_0 = class8_0.Class8_0)
			{
				Class9 @class = class8_0 as Class9;
				if (@class != null)
				{
					return @class;
				}
				long_2 += class8_0.vmethod_0();
			}
			return null;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002D03 File Offset: 0x00000F03
		private byte method_5(long long_1)
		{
			if (this.stream_0.Position != long_1)
			{
				this.stream_0.Position = long_1;
			}
			return (byte)this.stream_0.ReadByte();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000AB98 File Offset: 0x00008D98
		private void method_6(Class9 class9_0, long long_1)
		{
			long long_2;
			Class9 @class = this.method_4(class9_0, long_1, out long_2);
			if (@class != null && long_1 + class9_0.vmethod_0() > @class.Int64_0)
			{
				this.method_6(@class, long_2);
			}
			if (class9_0.Int64_0 > long_1)
			{
				byte[] array = new byte[4096];
				for (long num = 0L; num < class9_0.vmethod_0(); num += (long)array.Length)
				{
					long position = class9_0.Int64_0 + num;
					int count = (int)Math.Min((long)array.Length, class9_0.vmethod_0() - num);
					this.stream_0.Position = position;
					this.stream_0.Read(array, 0, count);
					long position2 = long_1 + num;
					this.stream_0.Position = position2;
					this.stream_0.Write(array, 0, count);
				}
			}
			else
			{
				byte[] array2 = new byte[4096];
				for (long num2 = 0L; num2 < class9_0.vmethod_0(); num2 += (long)array2.Length)
				{
					int num3 = (int)Math.Min((long)array2.Length, class9_0.vmethod_0() - num2);
					long position3 = class9_0.Int64_0 + class9_0.vmethod_0() - num2 - (long)num3;
					this.stream_0.Position = position3;
					this.stream_0.Read(array2, 0, num3);
					long position4 = long_1 + class9_0.vmethod_0() - num2 - (long)num3;
					this.stream_0.Position = position4;
					this.stream_0.Write(array2, 0, num3);
				}
			}
			class9_0.method_0(long_1);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002D2B File Offset: 0x00000F2B
		private void method_7()
		{
			this.class11_0 = new Class11();
			this.class11_0.method_2(new Class9(0L, this.stream_0.Length));
			this.long_0 = this.stream_0.Length;
		}

		// Token: 0x0400005E RID: 94
		private static int int_0;

		// Token: 0x0400005F RID: 95
		private string string_0;

		// Token: 0x04000060 RID: 96
		public Stream stream_0;

		// Token: 0x04000061 RID: 97
		private Class11 class11_0;

		// Token: 0x04000062 RID: 98
		private long long_0;

		// Token: 0x04000063 RID: 99
		private bool bool_0;

		// Token: 0x04000064 RID: 100
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x04000065 RID: 101
		[CompilerGenerated]
		private EventHandler eventHandler_1;
	}
}
