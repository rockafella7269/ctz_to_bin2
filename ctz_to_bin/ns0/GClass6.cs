using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x0200001B RID: 27
	public sealed class GClass6 : GInterface1, IDisposable
	{
		// Token: 0x06000111 RID: 273 RVA: 0x0000AD04 File Offset: 0x00008F04
		public GClass6(string string_1)
		{
			this.string_0 = string_1;
			try
			{
				this.fileStream_0 = File.Open(string_1, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
			}
			catch
			{
				try
				{
					this.fileStream_0 = File.Open(string_1, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					this.bool_0 = true;
				}
				catch
				{
					throw;
				}
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000AD74 File Offset: 0x00008F74
		[CompilerGenerated]
		public void imethod_9(EventHandler eventHandler_2)
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

		// Token: 0x06000113 RID: 275 RVA: 0x0000ADAC File Offset: 0x00008FAC
		[CompilerGenerated]
		public void imethod_10(EventHandler eventHandler_2)
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

		// Token: 0x06000114 RID: 276 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		~GClass6()
		{
			this.Dispose();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002D66 File Offset: 0x00000F66
		private void method_0(EventArgs eventArgs_0)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, eventArgs_0);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00002D7D File Offset: 0x00000F7D
		public string String_0
		{
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002D85 File Offset: 0x00000F85
		public bool imethod_7()
		{
			return this.class13_0.Count > 0;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000AE10 File Offset: 0x00009010
		public void imethod_8()
		{
			if (this.bool_0)
			{
				throw new Exception("File is in read-only mode.");
			}
			if (!this.imethod_7())
			{
				return;
			}
			IDictionaryEnumerator enumerator = this.class13_0.GetEnumerator();
			while (enumerator.MoveNext())
			{
				long num = (long)enumerator.Key;
				byte b = (byte)enumerator.Value;
				if (this.fileStream_0.Position != num)
				{
					this.fileStream_0.Position = num;
				}
				this.fileStream_0.Write(new byte[]
				{
					b
				}, 0, 1);
			}
			this.class13_0.Clear();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002D95 File Offset: 0x00000F95
		public void method_1()
		{
			this.class13_0.Clear();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000AEA4 File Offset: 0x000090A4
		[CompilerGenerated]
		public void imethod_5(EventHandler eventHandler_2)
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

		// Token: 0x0600011B RID: 283 RVA: 0x0000AEDC File Offset: 0x000090DC
		[CompilerGenerated]
		public void imethod_6(EventHandler eventHandler_2)
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

		// Token: 0x0600011C RID: 284 RVA: 0x0000AF14 File Offset: 0x00009114
		public byte imethod_0(long long_0)
		{
			if (this.class13_0.method_1(long_0))
			{
				return this.class13_0[long_0];
			}
			if (this.fileStream_0.Position != long_0)
			{
				this.fileStream_0.Position = long_0;
			}
			return (byte)this.fileStream_0.ReadByte();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002DA2 File Offset: 0x00000FA2
		public long imethod_4()
		{
			return this.fileStream_0.Length;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002DAF File Offset: 0x00000FAF
		public void imethod_1(long long_0, byte byte_0)
		{
			if (this.class13_0.method_1(long_0))
			{
				this.class13_0[long_0] = byte_0;
			}
			else
			{
				this.class13_0.method_0(long_0, byte_0);
			}
			this.method_0(EventArgs.Empty);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002DE6 File Offset: 0x00000FE6
		public void imethod_3(long long_0, long long_1)
		{
			throw new NotSupportedException("FileByteProvider.DeleteBytes");
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002DF2 File Offset: 0x00000FF2
		public void imethod_2(long long_0, byte[] byte_0)
		{
			throw new NotSupportedException("FileByteProvider.InsertBytes");
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002DFE File Offset: 0x00000FFE
		public bool imethod_11()
		{
			return !this.bool_0;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000247A File Offset: 0x0000067A
		public bool imethod_12()
		{
			return false;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000247A File Offset: 0x0000067A
		public bool imethod_13()
		{
			return false;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002E09 File Offset: 0x00001009
		public void Dispose()
		{
			if (this.fileStream_0 != null)
			{
				this.string_0 = null;
				this.fileStream_0.Close();
				this.fileStream_0 = null;
			}
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000066 RID: 102
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x04000067 RID: 103
		private GClass6.Class13 class13_0 = new GClass6.Class13();

		// Token: 0x04000068 RID: 104
		private string string_0;

		// Token: 0x04000069 RID: 105
		private FileStream fileStream_0;

		// Token: 0x0400006A RID: 106
		private bool bool_0;

		// Token: 0x0400006B RID: 107
		[CompilerGenerated]
		private EventHandler eventHandler_1;

		// Token: 0x0200001C RID: 28
		private sealed class Class13 : DictionaryBase
		{
			// Token: 0x17000021 RID: 33
			public byte this[long long_0]
			{
				get
				{
					return (byte)base.Dictionary[long_0];
				}
				set
				{
					base.Dictionary[long_0] = value;
				}
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00002E6B File Offset: 0x0000106B
			public void method_0(long long_0, byte byte_0)
			{
				base.Dictionary.Add(long_0, byte_0);
			}

			// Token: 0x06000129 RID: 297 RVA: 0x00002E84 File Offset: 0x00001084
			public bool method_1(long long_0)
			{
				return base.Dictionary.Contains(long_0);
			}
		}
	}
}
