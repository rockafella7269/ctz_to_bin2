using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns0
{
	// Token: 0x02000019 RID: 25
	public sealed class GClass4 : GInterface1
	{
		// Token: 0x060000E2 RID: 226 RVA: 0x00002B78 File Offset: 0x00000D78
		public GClass4(byte[] byte_0) : this(new List<byte>(byte_0))
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002B86 File Offset: 0x00000D86
		public GClass4(List<byte> list_1)
		{
			this.list_0 = list_1;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002B95 File Offset: 0x00000D95
		private void method_0(EventArgs eventArgs_0)
		{
			this.bool_0 = true;
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, eventArgs_0);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002BB3 File Offset: 0x00000DB3
		private void method_1(EventArgs eventArgs_0)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, eventArgs_0);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002BCA File Offset: 0x00000DCA
		public List<byte> List_0
		{
			get
			{
				return this.list_0;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002BD2 File Offset: 0x00000DD2
		public bool imethod_7()
		{
			return this.bool_0;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002BDA File Offset: 0x00000DDA
		public void imethod_8()
		{
			this.bool_0 = false;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000A1CC File Offset: 0x000083CC
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

		// Token: 0x060000EA RID: 234 RVA: 0x0000A204 File Offset: 0x00008404
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

		// Token: 0x060000EB RID: 235 RVA: 0x0000A23C File Offset: 0x0000843C
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

		// Token: 0x060000EC RID: 236 RVA: 0x0000A274 File Offset: 0x00008474
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

		// Token: 0x060000ED RID: 237 RVA: 0x00002BE3 File Offset: 0x00000DE3
		public byte imethod_0(long long_0)
		{
			return this.list_0[(int)long_0];
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002BF2 File Offset: 0x00000DF2
		public void imethod_1(long long_0, byte byte_0)
		{
			this.list_0[(int)long_0] = byte_0;
			this.method_0(EventArgs.Empty);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000A2AC File Offset: 0x000084AC
		public void imethod_3(long long_0, long long_1)
		{
			int index = (int)Math.Max(0L, long_0);
			int count = (int)Math.Min((long)((int)this.imethod_4()), long_1);
			this.list_0.RemoveRange(index, count);
			this.method_1(EventArgs.Empty);
			this.method_0(EventArgs.Empty);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002C0D File Offset: 0x00000E0D
		public void imethod_2(long long_0, byte[] byte_0)
		{
			this.list_0.InsertRange((int)long_0, byte_0);
			this.method_1(EventArgs.Empty);
			this.method_0(EventArgs.Empty);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002C33 File Offset: 0x00000E33
		public long imethod_4()
		{
			return (long)this.list_0.Count;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000025DA File Offset: 0x000007DA
		public bool imethod_11()
		{
			return true;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000025DA File Offset: 0x000007DA
		public bool imethod_12()
		{
			return true;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000025DA File Offset: 0x000007DA
		public bool imethod_13()
		{
			return true;
		}

		// Token: 0x0400005A RID: 90
		private bool bool_0;

		// Token: 0x0400005B RID: 91
		private List<byte> list_0;

		// Token: 0x0400005C RID: 92
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x0400005D RID: 93
		[CompilerGenerated]
		private EventHandler eventHandler_1;
	}
}
