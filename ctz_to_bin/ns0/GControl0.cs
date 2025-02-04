using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ns0
{
	// Token: 0x02000020 RID: 32
	[ToolboxBitmap(typeof(GControl0), "HexBox.bmp")]
	public sealed class GControl0 : Control
	{
		// Token: 0x06000143 RID: 323 RVA: 0x0000B068 File Offset: 0x00009268
		public GControl0()
		{
			this.vscrollBar_0 = new VScrollBar();
			this.vscrollBar_0.Scroll += this.vscrollBar_0_Scroll;
			this.gclass0_0 = new GClass0(this);
			this.BackColor = Color.White;
			this.Font = SystemFonts.MessageBoxFont;
			this.stringFormat_0 = new StringFormat(StringFormat.GenericTypographic);
			this.stringFormat_0.FormatFlags = StringFormatFlags.MeasureTrailingSpaces;
			this.method_20();
			base.SetStyle(ControlStyles.UserPaint, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			this.timer_0.Interval = 50;
			this.timer_0.Tick += this.timer_0_Tick;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000144 RID: 324 RVA: 0x0000B204 File Offset: 0x00009404
		// (remove) Token: 0x06000145 RID: 325 RVA: 0x0000B23C File Offset: 0x0000943C
		[Description("Occurs, when the value of InsertActive property has changed.")]
		public event EventHandler Event_0
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000146 RID: 326 RVA: 0x0000B274 File Offset: 0x00009474
		// (remove) Token: 0x06000147 RID: 327 RVA: 0x0000B2AC File Offset: 0x000094AC
		[Description("Occurs, when the value of ReadOnly property has changed.")]
		public event EventHandler Event_1
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000148 RID: 328 RVA: 0x0000B2E4 File Offset: 0x000094E4
		// (remove) Token: 0x06000149 RID: 329 RVA: 0x0000B31C File Offset: 0x0000951C
		[Description("Occurs, when the value of ByteProvider property has changed.")]
		public event EventHandler Event_2
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600014A RID: 330 RVA: 0x0000B354 File Offset: 0x00009554
		// (remove) Token: 0x0600014B RID: 331 RVA: 0x0000B38C File Offset: 0x0000958C
		[Description("Occurs, when the value of SelectionStart property has changed.")]
		public event EventHandler Event_3
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600014C RID: 332 RVA: 0x0000B3C4 File Offset: 0x000095C4
		// (remove) Token: 0x0600014D RID: 333 RVA: 0x0000B3FC File Offset: 0x000095FC
		[Description("Occurs, when the value of SelectionLength property has changed.")]
		public event EventHandler Event_4
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_4;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_4;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600014E RID: 334 RVA: 0x0000B434 File Offset: 0x00009634
		// (remove) Token: 0x0600014F RID: 335 RVA: 0x0000B46C File Offset: 0x0000966C
		[Description("Occurs, when the value of LineInfoVisible property has changed.")]
		public event EventHandler Event_5
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_5;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_5;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000150 RID: 336 RVA: 0x0000B4A4 File Offset: 0x000096A4
		// (remove) Token: 0x06000151 RID: 337 RVA: 0x0000B4DC File Offset: 0x000096DC
		[Description("Occurs, when the value of ColumnInfoVisibleChanged property has changed.")]
		public event EventHandler Event_6
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_6;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_6;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000152 RID: 338 RVA: 0x0000B514 File Offset: 0x00009714
		// (remove) Token: 0x06000153 RID: 339 RVA: 0x0000B54C File Offset: 0x0000974C
		[Description("Occurs, when the value of GroupSeparatorVisibleChanged property has changed.")]
		public event EventHandler Event_7
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_7;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_7;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000154 RID: 340 RVA: 0x0000B584 File Offset: 0x00009784
		// (remove) Token: 0x06000155 RID: 341 RVA: 0x0000B5BC File Offset: 0x000097BC
		[Description("Occurs, when the value of StringViewVisible property has changed.")]
		public event EventHandler Event_8
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_8;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_8, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_8;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_8, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000156 RID: 342 RVA: 0x0000B5F4 File Offset: 0x000097F4
		// (remove) Token: 0x06000157 RID: 343 RVA: 0x0000B62C File Offset: 0x0000982C
		[Description("Occurs, when the value of BorderStyle property has changed.")]
		public event EventHandler Event_9
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_9;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_9, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_9;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_9, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000158 RID: 344 RVA: 0x0000B664 File Offset: 0x00009864
		// (remove) Token: 0x06000159 RID: 345 RVA: 0x0000B69C File Offset: 0x0000989C
		[Description("Occurs, when the value of GroupSize property has changed.")]
		public event EventHandler Event_10
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_10;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_10, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_10;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_10, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600015A RID: 346 RVA: 0x0000B6D4 File Offset: 0x000098D4
		// (remove) Token: 0x0600015B RID: 347 RVA: 0x0000B70C File Offset: 0x0000990C
		[Description("Occurs, when the value of BytesPerLine property has changed.")]
		public event EventHandler Event_11
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_11;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_11, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_11;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_11, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600015C RID: 348 RVA: 0x0000B744 File Offset: 0x00009944
		// (remove) Token: 0x0600015D RID: 349 RVA: 0x0000B77C File Offset: 0x0000997C
		[Description("Occurs, when the value of UseFixedBytesPerLine property has changed.")]
		public event EventHandler Event_12
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_12;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_12, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_12;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_12, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600015E RID: 350 RVA: 0x0000B7B4 File Offset: 0x000099B4
		// (remove) Token: 0x0600015F RID: 351 RVA: 0x0000B7EC File Offset: 0x000099EC
		[Description("Occurs, when the value of VScrollBarVisible property has changed.")]
		public event EventHandler Event_13
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_13;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_13, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_13;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_13, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000160 RID: 352 RVA: 0x0000B824 File Offset: 0x00009A24
		// (remove) Token: 0x06000161 RID: 353 RVA: 0x0000B85C File Offset: 0x00009A5C
		[Description("Occurs, when the value of HexCasing property has changed.")]
		public event EventHandler Event_14
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_14;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_14, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_14;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_14, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000162 RID: 354 RVA: 0x0000B894 File Offset: 0x00009A94
		// (remove) Token: 0x06000163 RID: 355 RVA: 0x0000B8CC File Offset: 0x00009ACC
		[Description("Occurs, when the value of HorizontalByteCount property has changed.")]
		public event EventHandler Event_15
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_15;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_15, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_15;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_15, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000164 RID: 356 RVA: 0x0000B904 File Offset: 0x00009B04
		// (remove) Token: 0x06000165 RID: 357 RVA: 0x0000B93C File Offset: 0x00009B3C
		[Description("Occurs, when the value of VerticalByteCount property has changed.")]
		public event EventHandler Event_16
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_16;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_16, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_16;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_16, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000166 RID: 358 RVA: 0x0000B974 File Offset: 0x00009B74
		// (remove) Token: 0x06000167 RID: 359 RVA: 0x0000B9AC File Offset: 0x00009BAC
		[Description("Occurs, when the value of CurrentLine property has changed.")]
		public event EventHandler Event_17
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_17;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_17, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_17;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_17, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000168 RID: 360 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		// (remove) Token: 0x06000169 RID: 361 RVA: 0x0000BA1C File Offset: 0x00009C1C
		[Description("Occurs, when the value of CurrentPositionInLine property has changed.")]
		public event EventHandler Event_18
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_18;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_18, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_18;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_18, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600016A RID: 362 RVA: 0x0000BA54 File Offset: 0x00009C54
		// (remove) Token: 0x0600016B RID: 363 RVA: 0x0000BA8C File Offset: 0x00009C8C
		[Description("Occurs, when Copy method was invoked and ClipBoardData changed.")]
		public event EventHandler Event_19
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_19;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_19, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_19;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_19, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600016C RID: 364 RVA: 0x0000BAC4 File Offset: 0x00009CC4
		// (remove) Token: 0x0600016D RID: 365 RVA: 0x0000BAFC File Offset: 0x00009CFC
		[Description("Occurs, when CopyHex method was invoked and ClipBoardData changed.")]
		public event EventHandler Event_20
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_20;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_20, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_20;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_20, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600016E RID: 366 RVA: 0x0000BB34 File Offset: 0x00009D34
		// (remove) Token: 0x0600016F RID: 367 RVA: 0x0000BB6C File Offset: 0x00009D6C
		[Description("Occurs, when the CharSize property has changed")]
		public event EventHandler Event_21
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_21;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_21, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_21;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_21, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000170 RID: 368 RVA: 0x0000BBA4 File Offset: 0x00009DA4
		// (remove) Token: 0x06000171 RID: 369 RVA: 0x0000BBDC File Offset: 0x00009DDC
		[Description("Occurs, when the RequiredWidth property changes")]
		public event EventHandler Event_22
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = this.eventHandler_22;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_22, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = this.eventHandler_22;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_22, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000BC14 File Offset: 0x00009E14
		private void vscrollBar_0_Scroll(object sender, ScrollEventArgs e)
		{
			switch (e.Type)
			{
			case ScrollEventType.SmallDecrement:
				this.method_8();
				break;
			case ScrollEventType.SmallIncrement:
				this.method_7();
				break;
			case ScrollEventType.LargeDecrement:
				this.method_10();
				break;
			case ScrollEventType.LargeIncrement:
				this.method_9();
				break;
			case ScrollEventType.ThumbPosition:
			{
				long long_ = this.method_3(e.NewValue);
				this.method_11(long_);
				break;
			}
			case ScrollEventType.ThumbTrack:
			{
				if (this.timer_0.Enabled)
				{
					this.timer_0.Enabled = false;
				}
				int tickCount = Environment.TickCount;
				if (tickCount - this.int_4 > 50)
				{
					this.timer_0_Tick(null, null);
					this.int_4 = tickCount;
				}
				else
				{
					this.long_3 = this.method_3(e.NewValue);
					this.timer_0.Enabled = true;
				}
				break;
			}
			}
			e.NewValue = this.method_2(this.long_2);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002FB0 File Offset: 0x000011B0
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.timer_0.Enabled = false;
			this.method_11(this.long_3);
			this.int_4 = Environment.TickCount;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000BD00 File Offset: 0x00009F00
		private void method_0()
		{
			if (!this.Boolean_2 || this.ginterface1_0 == null || this.ginterface1_0.imethod_4() <= 0L || this.int_0 == 0)
			{
				if (this.Boolean_2)
				{
					this.long_0 = 0L;
					this.long_1 = 0L;
					this.long_2 = 0L;
					this.method_1();
				}
				return;
			}
			long num = (long)Math.Ceiling((double)(this.ginterface1_0.imethod_4() + 1L) / (double)this.int_0 - (double)this.int_1);
			num = Math.Max(0L, num);
			long num2 = this.long_4 / (long)this.int_0;
			if (num < this.long_1 && this.long_2 == this.long_1)
			{
				this.method_8();
			}
			if (num == this.long_1 && num2 == this.long_2)
			{
				return;
			}
			this.long_0 = 0L;
			this.long_1 = num;
			this.long_2 = Math.Min(num2, num);
			this.method_1();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000BDF8 File Offset: 0x00009FF8
		private void method_1()
		{
			int num = this.method_4(this.long_1);
			if (num > 0)
			{
				this.vscrollBar_0.Minimum = 0;
				this.vscrollBar_0.Maximum = num;
				this.vscrollBar_0.Value = this.method_2(this.long_2);
				this.vscrollBar_0.Visible = true;
				return;
			}
			this.vscrollBar_0.Visible = false;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000BE60 File Offset: 0x0000A060
		private int method_2(long long_11)
		{
			int num = 65535;
			if (this.long_1 < (long)num)
			{
				return (int)long_11;
			}
			double num2 = (double)long_11 / (double)this.long_1 * 100.0;
			int num3 = (int)Math.Floor((double)num / 100.0 * num2);
			num3 = (int)Math.Max(this.long_0, (long)num3);
			return (int)Math.Min(this.long_1, (long)num3);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000BECC File Offset: 0x0000A0CC
		private long method_3(int int_14)
		{
			int num = 65535;
			if (this.long_1 < (long)num)
			{
				return (long)int_14;
			}
			double num2 = (double)int_14 / (double)num * 100.0;
			return (long)((int)Math.Floor((double)this.long_1 / 100.0 * num2));
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000BF18 File Offset: 0x0000A118
		private int method_4(long long_11)
		{
			long num = 65535L;
			if (long_11 > num)
			{
				return (int)num;
			}
			return (int)long_11;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002FD5 File Offset: 0x000011D5
		public void method_5(long long_11)
		{
			if (long_11 >= this.long_0 && long_11 <= this.long_1)
			{
				if (long_11 != this.long_2)
				{
					this.long_2 = long_11;
					this.method_1();
					this.method_53();
					this.method_24();
					base.Invalidate();
					return;
				}
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000BF38 File Offset: 0x0000A138
		private void method_6(int int_14)
		{
			long long_;
			if (int_14 > 0)
			{
				long_ = Math.Min(this.long_1, this.long_2 + (long)int_14);
			}
			else
			{
				if (int_14 >= 0)
				{
					return;
				}
				long_ = Math.Max(this.long_0, this.long_2 + (long)int_14);
			}
			this.method_5(long_);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00003014 File Offset: 0x00001214
		private void method_7()
		{
			this.method_6(1);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000301D File Offset: 0x0000121D
		private void method_8()
		{
			this.method_6(-1);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00003026 File Offset: 0x00001226
		private void method_9()
		{
			this.method_6(this.int_1);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00003034 File Offset: 0x00001234
		private void method_10()
		{
			this.method_6(-this.int_1);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000BF84 File Offset: 0x0000A184
		private void method_11(long long_11)
		{
			int num = (this.long_1 > 65535L) ? 10 : 9;
			if (this.method_2(long_11) == this.method_4(this.long_1) - num)
			{
				long_11 = this.long_1;
			}
			this.method_5(long_11);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000BF84 File Offset: 0x0000A184
		public void method_12(long long_11)
		{
			int num = (this.long_1 > 65535L) ? 10 : 9;
			if (this.method_2(long_11) == this.method_4(this.long_1) - num)
			{
				long_11 = this.long_1;
			}
			this.method_5(long_11);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00003043 File Offset: 0x00001243
		public void method_13()
		{
			this.method_14(this.long_6);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		public void method_14(long long_11)
		{
			if (this.ginterface1_0 == null || this.interface0_0 == null)
			{
				return;
			}
			if (long_11 < this.long_4)
			{
				long long_12 = (long)Math.Floor((double)long_11 / (double)this.int_0);
				this.method_11(long_12);
				return;
			}
			if (long_11 > this.long_5)
			{
				long num = (long)Math.Floor((double)long_11 / (double)this.int_0);
				num -= (long)(this.int_1 - 1);
				this.method_11(num);
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00003051 File Offset: 0x00001251
		private void method_15()
		{
			if (this.long_9 == 0L)
			{
				return;
			}
			this.long_9 = 0L;
			this.vmethod_4(EventArgs.Empty);
			if (!this.bool_0)
			{
				this.method_23();
			}
			else
			{
				this.method_24();
			}
			base.Invalidate();
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000308B File Offset: 0x0000128B
		public bool method_16()
		{
			return base.Enabled && this.ginterface1_0 != null;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000030A2 File Offset: 0x000012A2
		public void method_17()
		{
			if (this.GInterface1_0 == null)
			{
				return;
			}
			this.method_18(0L, this.GInterface1_0.imethod_4());
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000030C0 File Offset: 0x000012C0
		public void method_18(long long_11, long long_12)
		{
			if (this.GInterface1_0 == null)
			{
				return;
			}
			if (!base.Enabled)
			{
				return;
			}
			this.method_19(long_11, long_12);
			this.method_13();
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000C040 File Offset: 0x0000A240
		private void method_19(long long_11, long long_12)
		{
			int int_ = 0;
			if (long_12 > 0L && this.bool_0)
			{
				this.method_25();
			}
			else if (long_12 == 0L && !this.bool_0)
			{
				this.method_23();
			}
			this.method_65(long_11, int_);
			this.method_66(long_12);
			this.method_24();
			base.Invalidate();
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000C094 File Offset: 0x0000A294
		private void method_20()
		{
			if (this.class14_0 == null)
			{
				this.class14_0 = new GControl0.Class14(this);
			}
			if (this.class14_0 == this.interface0_0)
			{
				return;
			}
			if (this.interface0_0 != null)
			{
				this.interface0_0.imethod_1();
			}
			this.interface0_0 = this.class14_0;
			this.interface0_0.imethod_0();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		private void method_21()
		{
			if (this.class15_0 == null)
			{
				this.class15_0 = new GControl0.Class15(this);
			}
			if (this.class15_0 == this.interface0_0)
			{
				return;
			}
			if (this.interface0_0 != null)
			{
				this.interface0_0.imethod_1();
			}
			this.interface0_0 = this.class15_0;
			this.interface0_0.imethod_0();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000C14C File Offset: 0x0000A34C
		private void method_22()
		{
			if (this.class16_0 == null)
			{
				this.class16_0 = new GControl0.Class16(this);
			}
			if (this.class16_0 == this.interface0_0)
			{
				return;
			}
			if (this.interface0_0 != null)
			{
				this.interface0_0.imethod_1();
			}
			this.interface0_0 = this.class16_0;
			this.interface0_0.imethod_0();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000C1A8 File Offset: 0x0000A3A8
		private void method_23()
		{
			if (this.ginterface1_0 != null && this.interface0_0 != null && !this.bool_0 && this.Focused)
			{
				int num = this.Boolean_8 ? 1 : ((int)this.sizeF_0.Width);
				int num2 = (int)this.sizeF_0.Height;
				Class17.CreateCaret(base.Handle, IntPtr.Zero, num, num2);
				this.method_24();
				Class17.ShowCaret(base.Handle);
				this.bool_0 = true;
				return;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000C228 File Offset: 0x0000A428
		public void method_24()
		{
			if (this.ginterface1_0 != null && this.interface0_0 != null)
			{
				long num = this.long_6 - this.long_4;
				PointF pointF = this.interface0_0.imethod_5(num);
				pointF.X += (float)this.int_9 * this.sizeF_0.Width;
				Class17.SetCaretPos((int)pointF.X, (int)pointF.Y);
				return;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000030E2 File Offset: 0x000012E2
		private void method_25()
		{
			if (!this.bool_0)
			{
				return;
			}
			Class17.DestroyCaret();
			this.bool_0 = false;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000C298 File Offset: 0x0000A498
		private void method_26(Point point_0)
		{
			if (this.ginterface1_0 == null || this.interface0_0 == null)
			{
				return;
			}
			long int64_ = this.long_6;
			int int32_ = this.int_9;
			if (this.rectangle_3.Contains(point_0))
			{
				Struct0 @struct = this.method_27(point_0);
				int64_ = @struct.Int64_0;
				int32_ = @struct.Int32_0;
				this.method_65(int64_, int32_);
				this.method_21();
				this.method_24();
				base.Invalidate();
				return;
			}
			if (this.rectangle_4.Contains(point_0))
			{
				Struct0 struct2 = this.method_28(point_0);
				int64_ = struct2.Int64_0;
				int32_ = struct2.Int32_0;
				this.method_65(int64_, int32_);
				this.method_22();
				this.method_24();
				base.Invalidate();
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000C34C File Offset: 0x0000A54C
		private Struct0 method_27(Point point_0)
		{
			float num = (float)(point_0.X - this.rectangle_3.X) / this.sizeF_0.Width;
			int num2 = (int)((float)(point_0.Y - this.rectangle_3.Y) / this.sizeF_0.Height);
			int num3 = (int)num;
			int num4 = num2;
			int num5 = num3 / 3 + 1;
			long num6 = Math.Min(this.ginterface1_0.imethod_4(), this.long_4 + (long)(this.int_0 * (num4 + 1) - this.int_0) + (long)num5 - 1L);
			int num7 = num3 % 3;
			if (num7 > 1)
			{
				num7 = 1;
			}
			if (num6 == this.ginterface1_0.imethod_4())
			{
				num7 = 0;
			}
			if (num6 < 0L)
			{
				return new Struct0(0L, 0);
			}
			return new Struct0(num6, num7);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000C408 File Offset: 0x0000A608
		private Struct0 method_28(Point point_0)
		{
			float num = (float)(point_0.X - this.rectangle_4.X) / this.sizeF_0.Width;
			int num2 = (int)((float)(point_0.Y - this.rectangle_4.Y) / this.sizeF_0.Height);
			int num3 = (int)num;
			int num4 = num2;
			int num5 = num3 + 1;
			long num6 = Math.Min(this.ginterface1_0.imethod_4(), this.long_4 + (long)(this.int_0 * (num4 + 1) - this.int_0) + (long)num5 - 1L);
			int num7 = 0;
			if (num6 < 0L)
			{
				return new Struct0(0L, 0);
			}
			return new Struct0(num6, num7);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
		[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
		public override bool PreProcessMessage(ref Message m)
		{
			switch (m.Msg)
			{
			case 256:
				return this.interface0_0.imethod_4(ref m);
			case 257:
				return this.interface0_0.imethod_2(ref m);
			case 258:
				return this.interface0_0.imethod_3(ref m);
			default:
				return base.PreProcessMessage(ref m);
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000030FA File Offset: 0x000012FA
		private bool method_29(ref Message message_0)
		{
			return base.PreProcessMessage(ref message_0);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000C508 File Offset: 0x0000A708
		public long method_30(GClass7 gclass7_0)
		{
			long num = this.Int64_2 + this.Int64_3;
			int num2 = 0;
			byte[] array = null;
			byte[] array2 = null;
			if (gclass7_0.Type == GEnum1.const_0 && gclass7_0.Boolean_0)
			{
				if (gclass7_0.FindBuffer == null || gclass7_0.FindBuffer.Length == 0)
				{
					throw new ArgumentException("FindBuffer can not be null when Type: Text and MatchCase: false");
				}
				array = gclass7_0.FindBuffer;
			}
			else if (gclass7_0.Type == GEnum1.const_0 && !gclass7_0.Boolean_0)
			{
				if (gclass7_0.FindBufferLowerCase == null || gclass7_0.FindBufferLowerCase.Length == 0)
				{
					throw new ArgumentException("FindBufferLowerCase can not be null when Type is Text and MatchCase is true");
				}
				if (gclass7_0.FindBufferUpperCase == null || gclass7_0.FindBufferUpperCase.Length == 0)
				{
					throw new ArgumentException("FindBufferUpperCase can not be null when Type is Text and MatchCase is true");
				}
				if (gclass7_0.FindBufferLowerCase.Length != gclass7_0.FindBufferUpperCase.Length)
				{
					throw new ArgumentException("FindBufferUpperCase and FindBufferUpperCase must have the same size when Type is Text and MatchCase is true");
				}
				array = gclass7_0.FindBufferLowerCase;
				array2 = gclass7_0.FindBufferUpperCase;
			}
			else if (gclass7_0.Type == GEnum1.const_1)
			{
				if (gclass7_0.Hex == null || gclass7_0.Hex.Length == 0)
				{
					throw new ArgumentException("Hex can not be null when Type is Hex");
				}
				array = gclass7_0.Hex;
			}
			int num3 = array.Length;
			this.bool_1 = false;
			for (long num4 = num; num4 < this.ginterface1_0.imethod_4(); num4 += 1L)
			{
				if (this.bool_1)
				{
					return -2L;
				}
				if (num4 % 1000L == 0L)
				{
					Application.DoEvents();
				}
				byte b = this.ginterface1_0.imethod_0(num4);
				if (!(b == array[num2] | (array2 != null && b == array2[num2])))
				{
					num4 -= (long)num2;
					num2 = 0;
					this.long_7 = num4;
				}
				else
				{
					num2++;
					if (num2 == num3)
					{
						long num5 = num4 - (long)num3 + 1L;
						this.method_18(num5, (long)num3);
						this.method_14(this.long_6 + this.long_9);
						this.method_14(this.long_6);
						return num5;
					}
				}
			}
			return -1L;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00003103 File Offset: 0x00001303
		public void method_31()
		{
			this.bool_1 = true;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000310C File Offset: 0x0000130C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public long Int64_0
		{
			get
			{
				return this.long_7;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000C6C4 File Offset: 0x0000A8C4
		private byte[] method_32()
		{
			if (!this.method_34())
			{
				return new byte[0];
			}
			byte[] array = new byte[this.long_9];
			int num = -1;
			for (long num2 = this.long_6; num2 < this.long_6 + this.long_9; num2 += 1L)
			{
				num++;
				array[num] = this.ginterface1_0.imethod_0(num2);
			}
			return array;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000C724 File Offset: 0x0000A924
		public void method_33()
		{
			if (!this.method_34())
			{
				return;
			}
			byte[] array = this.method_32();
			DataObject dataObject = new DataObject();
			Encoding.ASCII.GetString(array, 0, array.Length);
			string data = BitConverter.ToString(array).Replace("-", " ");
			dataObject.SetData(typeof(string), data);
			Clipboard.SetDataObject(dataObject, true);
			this.method_24();
			this.method_13();
			base.Invalidate();
			this.vmethod_19(EventArgs.Empty);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00003114 File Offset: 0x00001314
		public bool method_34()
		{
			return this.long_9 >= 1L && this.ginterface1_0 != null;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
		public void method_35()
		{
			if (!this.method_36())
			{
				return;
			}
			this.method_33();
			this.ginterface1_0.imethod_3(this.long_6, this.long_9);
			this.int_9 = 0;
			this.method_24();
			this.method_13();
			this.method_15();
			base.Invalidate();
			this.Refresh();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000312B File Offset: 0x0000132B
		public bool method_36()
		{
			return !this.Boolean_0 && base.Enabled && this.ginterface1_0 != null && (this.long_9 >= 1L && this.ginterface1_0.imethod_13());
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		public void method_37()
		{
			if (!this.method_38())
			{
				return;
			}
			if (this.long_9 > 0L)
			{
				this.ginterface1_0.imethod_3(this.long_6, this.long_9);
			}
			IDataObject dataObject = Clipboard.GetDataObject();
			byte[] array;
			if (dataObject.GetDataPresent("BinaryData"))
			{
				MemoryStream memoryStream = (MemoryStream)dataObject.GetData("BinaryData");
				array = new byte[memoryStream.Length];
				memoryStream.Read(array, 0, array.Length);
			}
			else
			{
				if (!dataObject.GetDataPresent(typeof(string)))
				{
					return;
				}
				string s = (string)dataObject.GetData(typeof(string));
				array = Encoding.ASCII.GetBytes(s);
			}
			this.ginterface1_0.imethod_2(this.long_6, array);
			this.method_65(this.long_6 + (long)array.Length, 0);
			this.method_15();
			this.method_13();
			this.method_24();
			base.Invalidate();
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000C8E0 File Offset: 0x0000AAE0
		public bool method_38()
		{
			if (this.Boolean_0 || !base.Enabled)
			{
				return false;
			}
			if (this.ginterface1_0 == null || !this.ginterface1_0.imethod_12())
			{
				return false;
			}
			if (!this.ginterface1_0.imethod_13() && this.long_9 > 0L)
			{
				return false;
			}
			IDataObject dataObject = Clipboard.GetDataObject();
			return dataObject.GetDataPresent("BinaryData") || dataObject.GetDataPresent(typeof(string));
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000C95C File Offset: 0x0000AB5C
		public bool method_39()
		{
			if (!this.method_38())
			{
				return false;
			}
			IDataObject dataObject = Clipboard.GetDataObject();
			if (dataObject.GetDataPresent(typeof(string)))
			{
				string string_ = (string)dataObject.GetData(typeof(string));
				return this.method_62(string_) != null;
			}
			return false;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		public void method_40()
		{
			if (!this.method_38())
			{
				return;
			}
			IDataObject dataObject = Clipboard.GetDataObject();
			if (!dataObject.GetDataPresent(typeof(string)))
			{
				return;
			}
			string string_ = (string)dataObject.GetData(typeof(string));
			byte[] array = this.method_62(string_);
			if (array == null)
			{
				return;
			}
			if (this.long_9 > 0L)
			{
				this.ginterface1_0.imethod_3(this.long_6, this.long_9);
			}
			this.ginterface1_0.imethod_2(this.long_6, array);
			this.method_65(this.long_6 + (long)array.Length, 0);
			this.method_15();
			this.method_13();
			this.method_24();
			base.Invalidate();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000CA64 File Offset: 0x0000AC64
		public void method_41()
		{
			if (!this.method_34())
			{
				return;
			}
			byte[] array = this.method_32();
			DataObject dataObject = new DataObject();
			string data = this.method_60(array);
			dataObject.SetData(typeof(string), data);
			MemoryStream data2 = new MemoryStream(array, 0, array.Length, false, true);
			dataObject.SetData("BinaryData", data2);
			Clipboard.SetDataObject(dataObject, true);
			this.method_24();
			this.method_13();
			base.Invalidate();
			this.vmethod_20(EventArgs.Empty);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000CADC File Offset: 0x0000ACDC
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			BorderStyle borderStyle = this.borderStyle_0;
			if (borderStyle == BorderStyle.FixedSingle)
			{
				e.Graphics.FillRectangle(new SolidBrush(this.BackColor), base.ClientRectangle);
				ControlPaint.DrawBorder(e.Graphics, base.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
				return;
			}
			if (borderStyle != BorderStyle.Fixed3D)
			{
				e.Graphics.FillRectangle(new SolidBrush(this.BackColor), base.ClientRectangle);
				return;
			}
			if (TextBoxRenderer.IsSupported)
			{
				VisualStyleElement element = VisualStyleElement.TextBox.TextEdit.Normal;
				Color backColor = this.BackColor;
				if (base.Enabled)
				{
					if (this.Boolean_0)
					{
						element = VisualStyleElement.TextBox.TextEdit.ReadOnly;
					}
					else if (this.Focused)
					{
						element = VisualStyleElement.TextBox.TextEdit.Focused;
					}
				}
				else
				{
					element = VisualStyleElement.TextBox.TextEdit.Disabled;
					backColor = this.Color_0;
				}
				VisualStyleRenderer visualStyleRenderer = new VisualStyleRenderer(element);
				visualStyleRenderer.DrawBackground(e.Graphics, base.ClientRectangle);
				Rectangle backgroundContentRectangle = visualStyleRenderer.GetBackgroundContentRectangle(e.Graphics, base.ClientRectangle);
				e.Graphics.FillRectangle(new SolidBrush(backColor), backgroundContentRectangle);
				return;
			}
			e.Graphics.FillRectangle(new SolidBrush(this.BackColor), base.ClientRectangle);
			ControlPaint.DrawBorder3D(e.Graphics, base.ClientRectangle, Border3DStyle.Sunken);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000CC04 File Offset: 0x0000AE04
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (this.ginterface1_0 == null)
			{
				return;
			}
			Region region = new Region(base.ClientRectangle);
			region.Exclude(this.rectangle_0);
			e.Graphics.ExcludeClip(region);
			this.method_53();
			if (this.bool_8)
			{
				this.method_42(e.Graphics, this.long_4, this.long_5);
			}
			if (!this.bool_9)
			{
				this.method_45(e.Graphics, this.long_4, this.long_5);
			}
			else
			{
				this.method_49(e.Graphics, this.long_4, this.long_5);
				if (this.bool_10)
				{
					this.method_50(e.Graphics);
				}
			}
			if (this.bool_7)
			{
				this.method_43(e.Graphics);
			}
			if (this.bool_6)
			{
				this.method_44(e.Graphics);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000CCE4 File Offset: 0x0000AEE4
		private void method_42(Graphics graphics_0, long long_11, long long_12)
		{
			long_12 = Math.Min(this.ginterface1_0.imethod_4() - 1L, long_12);
			Brush brush = new SolidBrush((this.Color_1 != Color.Empty) ? this.Color_1 : this.ForeColor);
			int num = this.method_59(long_12 - long_11).Y + 1;
			for (int i = 0; i < num; i++)
			{
				long num2 = long_11 + (long)(this.int_0 * i) + this.long_8;
				PointF pointF = this.method_56(new Point(0, i));
				string text = num2.ToString(this.string_0, Thread.CurrentThread.CurrentCulture);
				string s;
				if (8 - text.Length > -1)
				{
					s = new string('0', 8 - text.Length) + text;
				}
				else
				{
					s = new string('~', 8);
				}
				graphics_0.DrawString(s, this.Font, brush, new PointF((float)this.rectangle_1.X, pointF.Y), this.stringFormat_0);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000CDF0 File Offset: 0x0000AFF0
		private void method_43(Graphics graphics_0)
		{
			Brush brush_ = new SolidBrush(this.Color_1);
			for (int i = 0; i < this.int_0; i++)
			{
				this.method_47(graphics_0, (byte)i, brush_, i);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000CE28 File Offset: 0x0000B028
		private void method_44(Graphics graphics_0)
		{
			for (int i = this.Int32_1; i < this.int_0; i += this.Int32_1)
			{
				Pen pen = new Pen(new SolidBrush(this.Color_1), 1f);
				PointF pt = this.method_57(i);
				pt.X -= this.sizeF_0.Width / 2f;
				graphics_0.DrawLine(pen, pt, new PointF(pt.X, pt.Y + (float)this.rectangle_2.Height + (float)this.rectangle_3.Height));
				if (this.Boolean_6)
				{
					PointF pointF = this.method_58(new Point(i, 0));
					pt.X -= 2f;
					graphics_0.DrawLine(pen, new PointF(pointF.X, pointF.Y), new PointF(pointF.X, pointF.Y + (float)this.rectangle_3.Height));
				}
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000CF2C File Offset: 0x0000B12C
		private void method_45(Graphics graphics_0, long long_11, long long_12)
		{
			Brush brush_ = new SolidBrush(this.method_52());
			Brush brush_2 = new SolidBrush(this.color_3);
			Brush brush_3 = new SolidBrush(this.color_2);
			int num = -1;
			long num2 = Math.Min(this.ginterface1_0.imethod_4() - 1L, long_12 + (long)this.int_0);
			bool flag = this.interface0_0 == null || this.interface0_0.GetType() == typeof(GControl0.Class15);
			for (long num3 = long_11; num3 < num2 + 1L; num3 += 1L)
			{
				num++;
				Point point_ = this.method_59((long)num);
				byte byte_ = this.ginterface1_0.imethod_0(num3);
				if (num3 >= this.long_6 && num3 <= this.long_6 + this.long_9 - 1L && this.long_9 != 0L && flag)
				{
					this.method_48(graphics_0, byte_, brush_2, brush_3, point_);
				}
				else
				{
					this.method_46(graphics_0, byte_, brush_, point_);
				}
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000D024 File Offset: 0x0000B224
		private void method_46(Graphics graphics_0, byte byte_0, Brush brush_0, Point point_0)
		{
			PointF point = this.method_56(point_0);
			string text = this.method_61(byte_0);
			graphics_0.DrawString(text.Substring(0, 1), this.Font, brush_0, point, this.stringFormat_0);
			point.X += this.sizeF_0.Width;
			graphics_0.DrawString(text.Substring(1, 1), this.Font, brush_0, point, this.stringFormat_0);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000D094 File Offset: 0x0000B294
		private void method_47(Graphics graphics_0, byte byte_0, Brush brush_0, int int_14)
		{
			PointF point = this.method_57(int_14);
			string text = this.method_61(byte_0);
			graphics_0.DrawString(text.Substring(0, 1), this.Font, brush_0, point, this.stringFormat_0);
			point.X += this.sizeF_0.Width;
			graphics_0.DrawString(text.Substring(1, 1), this.Font, brush_0, point, this.stringFormat_0);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000D104 File Offset: 0x0000B304
		private void method_48(Graphics graphics_0, byte byte_0, Brush brush_0, Brush brush_1, Point point_0)
		{
			string text = byte_0.ToString(this.string_0, Thread.CurrentThread.CurrentCulture);
			if (text.Length == 1)
			{
				text = "0" + text;
			}
			PointF point = this.method_56(point_0);
			float width = (point_0.X + 1 == this.int_0) ? (this.sizeF_0.Width * 2f) : (this.sizeF_0.Width * 3f);
			graphics_0.FillRectangle(brush_1, point.X, point.Y, width, this.sizeF_0.Height);
			graphics_0.DrawString(text.Substring(0, 1), this.Font, brush_0, point, this.stringFormat_0);
			point.X += this.sizeF_0.Width;
			graphics_0.DrawString(text.Substring(1, 1), this.Font, brush_0, point, this.stringFormat_0);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000D1F4 File Offset: 0x0000B3F4
		private void method_49(Graphics graphics_0, long long_11, long long_12)
		{
			Brush brush = new SolidBrush(this.method_52());
			Brush brush2 = new SolidBrush(this.color_3);
			Brush brush3 = new SolidBrush(this.color_2);
			int num = -1;
			long num2 = Math.Min(this.ginterface1_0.imethod_4() - 1L, long_12 + (long)this.int_0);
			bool flag = this.interface0_0 == null || this.interface0_0.GetType() == typeof(GControl0.Class15);
			bool flag2 = this.interface0_0 != null && this.interface0_0.GetType() == typeof(GControl0.Class16);
			for (long num3 = long_11; num3 < num2 + 1L; num3 += 1L)
			{
				num++;
				Point point_ = this.method_59((long)num);
				PointF point = this.method_58(point_);
				byte byte_ = this.ginterface1_0.imethod_0(num3);
				bool flag3 = num3 >= this.long_6 && num3 <= this.long_6 + this.long_9 - 1L && this.long_9 != 0L;
				if (flag3 && flag)
				{
					this.method_48(graphics_0, byte_, brush2, brush3, point_);
				}
				else
				{
					this.method_46(graphics_0, byte_, brush, point_);
				}
				string s = new string(this.GInterface0_0.imethod_0(byte_), 1);
				if (flag3 && flag2)
				{
					graphics_0.FillRectangle(brush3, point.X, point.Y, this.sizeF_0.Width, this.sizeF_0.Height);
					graphics_0.DrawString(s, this.Font, brush2, point, this.stringFormat_0);
				}
				else
				{
					graphics_0.DrawString(s, this.Font, brush, point, this.stringFormat_0);
				}
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000D398 File Offset: 0x0000B598
		private void method_50(Graphics graphics_0)
		{
			if (this.interface0_0 != null && this.long_6 != -1L && base.Enabled)
			{
				if (this.interface0_0.GetType() == typeof(GControl0.Class15))
				{
					if (this.long_9 == 0L)
					{
						Point point_ = this.method_59(this.long_6 - this.long_4);
						PointF pointF = this.method_58(point_);
						Size size = new Size((int)this.sizeF_0.Width, (int)this.sizeF_0.Height);
						Rectangle rectangle_ = new Rectangle((int)pointF.X, (int)pointF.Y, size.Width, size.Height);
						if (rectangle_.IntersectsWith(this.rectangle_4))
						{
							rectangle_.Intersect(this.rectangle_4);
							this.method_51(graphics_0, rectangle_);
							return;
						}
					}
					else
					{
						int num = (int)((float)this.rectangle_4.Width - this.sizeF_0.Width);
						Point point_2 = this.method_59(this.long_6 - this.long_4);
						PointF pointF2 = this.method_58(point_2);
						Point point_3 = this.method_59(this.long_6 - this.long_4 + this.long_9 - 1L);
						PointF pointF3 = this.method_58(point_3);
						int num2 = point_3.Y - point_2.Y;
						if (num2 == 0)
						{
							Rectangle rectangle_2 = new Rectangle((int)pointF2.X, (int)pointF2.Y, (int)(pointF3.X - pointF2.X + this.sizeF_0.Width), (int)this.sizeF_0.Height);
							if (rectangle_2.IntersectsWith(this.rectangle_4))
							{
								rectangle_2.Intersect(this.rectangle_4);
								this.method_51(graphics_0, rectangle_2);
								return;
							}
						}
						else
						{
							Rectangle rectangle_3 = new Rectangle((int)pointF2.X, (int)pointF2.Y, (int)((float)(this.rectangle_4.X + num) - pointF2.X + this.sizeF_0.Width), (int)this.sizeF_0.Height);
							if (rectangle_3.IntersectsWith(this.rectangle_4))
							{
								rectangle_3.Intersect(this.rectangle_4);
								this.method_51(graphics_0, rectangle_3);
							}
							if (num2 > 1)
							{
								Rectangle rectangle_4 = new Rectangle(this.rectangle_4.X, (int)(pointF2.Y + this.sizeF_0.Height), this.rectangle_4.Width, (int)(this.sizeF_0.Height * (float)(num2 - 1)));
								if (rectangle_4.IntersectsWith(this.rectangle_4))
								{
									rectangle_4.Intersect(this.rectangle_4);
									this.method_51(graphics_0, rectangle_4);
								}
							}
							Rectangle rectangle_5 = new Rectangle(this.rectangle_4.X, (int)pointF3.Y, (int)(pointF3.X - (float)this.rectangle_4.X + this.sizeF_0.Width), (int)this.sizeF_0.Height);
							if (rectangle_5.IntersectsWith(this.rectangle_4))
							{
								rectangle_5.Intersect(this.rectangle_4);
								this.method_51(graphics_0, rectangle_5);
								return;
							}
						}
					}
				}
				else
				{
					if (this.long_9 == 0L)
					{
						Point point_4 = this.method_59(this.long_6 - this.long_4);
						PointF pointF4 = this.method_56(point_4);
						Size size2 = new Size((int)this.sizeF_0.Width * 2, (int)this.sizeF_0.Height);
						Rectangle rectangle_6 = new Rectangle((int)pointF4.X, (int)pointF4.Y, size2.Width, size2.Height);
						this.method_51(graphics_0, rectangle_6);
						return;
					}
					int num3 = (int)((float)this.rectangle_3.Width - this.sizeF_0.Width * 5f);
					Point point_5 = this.method_59(this.long_6 - this.long_4);
					PointF pointF5 = this.method_56(point_5);
					Point point_6 = this.method_59(this.long_6 - this.long_4 + this.long_9 - 1L);
					PointF pointF6 = this.method_56(point_6);
					int num4 = point_6.Y - point_5.Y;
					if (num4 == 0)
					{
						Rectangle rectangle_7 = new Rectangle((int)pointF5.X, (int)pointF5.Y, (int)(pointF6.X - pointF5.X + this.sizeF_0.Width * 2f), (int)this.sizeF_0.Height);
						if (rectangle_7.IntersectsWith(this.rectangle_3))
						{
							rectangle_7.Intersect(this.rectangle_3);
							this.method_51(graphics_0, rectangle_7);
							return;
						}
					}
					else
					{
						Rectangle rectangle_8 = new Rectangle((int)pointF5.X, (int)pointF5.Y, (int)((float)(this.rectangle_3.X + num3) - pointF5.X + this.sizeF_0.Width * 2f), (int)this.sizeF_0.Height);
						if (rectangle_8.IntersectsWith(this.rectangle_3))
						{
							rectangle_8.Intersect(this.rectangle_3);
							this.method_51(graphics_0, rectangle_8);
						}
						if (num4 > 1)
						{
							Rectangle rectangle_9 = new Rectangle(this.rectangle_3.X, (int)(pointF5.Y + this.sizeF_0.Height), (int)((float)num3 + this.sizeF_0.Width * 2f), (int)(this.sizeF_0.Height * (float)(num4 - 1)));
							if (rectangle_9.IntersectsWith(this.rectangle_3))
							{
								rectangle_9.Intersect(this.rectangle_3);
								this.method_51(graphics_0, rectangle_9);
							}
						}
						Rectangle rectangle_10 = new Rectangle(this.rectangle_3.X, (int)pointF6.Y, (int)(pointF6.X - (float)this.rectangle_3.X + this.sizeF_0.Width * 2f), (int)this.sizeF_0.Height);
						if (rectangle_10.IntersectsWith(this.rectangle_3))
						{
							rectangle_10.Intersect(this.rectangle_3);
							this.method_51(graphics_0, rectangle_10);
						}
					}
				}
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000D964 File Offset: 0x0000BB64
		private void method_51(Graphics graphics_0, Rectangle rectangle_5)
		{
			if (rectangle_5.Top >= 0 && rectangle_5.Left >= 0 && rectangle_5.Width > 0 && rectangle_5.Height > 0)
			{
				Bitmap image = new Bitmap(rectangle_5.Width, rectangle_5.Height);
				Graphics graphics = Graphics.FromImage(image);
				SolidBrush brush = new SolidBrush(this.color_4);
				graphics.FillRectangle(brush, 0, 0, rectangle_5.Width, rectangle_5.Height);
				graphics_0.CompositingQuality = CompositingQuality.GammaCorrected;
				graphics_0.DrawImage(image, rectangle_5.Left, rectangle_5.Top);
				return;
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00003163 File Offset: 0x00001363
		private Color method_52()
		{
			if (base.Enabled)
			{
				return this.ForeColor;
			}
			return Color.Gray;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
		public void method_53()
		{
			if (this.ginterface1_0 != null && this.ginterface1_0.imethod_4() != 0L)
			{
				this.long_4 = (this.long_2 + 1L) * (long)this.int_0 - (long)this.int_0;
				this.long_5 = Math.Min(this.ginterface1_0.imethod_4() - 1L, this.long_4 + (long)this.int_2);
				return;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000DA60 File Offset: 0x0000BC60
		private void method_54()
		{
			SizeF sizeF;
			using (base.CreateGraphics())
			{
				sizeF = base.CreateGraphics().MeasureString("A", this.Font, 100, this.stringFormat_0);
			}
			this.SizeF_0 = new SizeF((float)Math.Ceiling((double)sizeF.Width), (float)Math.Ceiling((double)sizeF.Height));
			int num = 0;
			this.rectangle_0 = base.ClientRectangle;
			this.rectangle_0.X = this.rectangle_0.X + this.int_5;
			this.rectangle_0.Y = this.rectangle_0.Y + this.int_7;
			this.rectangle_0.Width = this.rectangle_0.Width - (this.int_6 + this.int_5);
			this.rectangle_0.Height = this.rectangle_0.Height - (this.int_8 + this.int_7);
			if (this.bool_5)
			{
				this.rectangle_0.Width = this.rectangle_0.Width - this.vscrollBar_0.Width;
				this.vscrollBar_0.Left = this.rectangle_0.X + this.rectangle_0.Width;
				this.vscrollBar_0.Top = this.rectangle_0.Y;
				this.vscrollBar_0.Height = this.rectangle_0.Height;
				num += this.vscrollBar_0.Width;
			}
			int num2 = 4;
			if (this.bool_8)
			{
				this.rectangle_1 = new Rectangle(this.rectangle_0.X + num2, this.rectangle_0.Y, (int)(this.sizeF_0.Width * 10f), this.rectangle_0.Height);
				num += this.rectangle_1.Width;
			}
			else
			{
				this.rectangle_1 = Rectangle.Empty;
				this.rectangle_1.X = num2;
				num += num2;
			}
			this.rectangle_2 = new Rectangle(this.rectangle_1.X + this.rectangle_1.Width, this.rectangle_0.Y, this.rectangle_0.Width - this.rectangle_1.Width, (int)sizeF.Height + 4);
			if (this.bool_7)
			{
				this.rectangle_1.Y = this.rectangle_1.Y + ((int)sizeF.Height + 4);
				this.rectangle_1.Height = this.rectangle_1.Height - ((int)sizeF.Height + 4);
			}
			else
			{
				this.rectangle_2.Height = 0;
			}
			this.rectangle_3 = new Rectangle(this.rectangle_1.X + this.rectangle_1.Width, this.rectangle_1.Y, this.rectangle_0.Width - this.rectangle_1.Width, this.rectangle_0.Height - this.rectangle_2.Height);
			if (this.Boolean_1)
			{
				this.method_67(this.int_10);
				this.rectangle_3.Width = (int)Math.Floor((double)this.int_0 * (double)this.sizeF_0.Width * 3.0 + (double)(2f * this.sizeF_0.Width));
				num += this.rectangle_3.Width;
			}
			else
			{
				int num3 = (int)Math.Floor((double)this.rectangle_3.Width / (double)this.sizeF_0.Width);
				if (this.bool_9)
				{
					num3 -= 2;
					if (num3 > 1)
					{
						this.method_67((int)Math.Floor((double)num3 / 4.0));
					}
					else
					{
						this.method_67(1);
					}
				}
				else if (num3 > 1)
				{
					this.method_67((int)Math.Floor((double)num3 / 3.0));
				}
				else
				{
					this.method_67(1);
				}
				this.rectangle_3.Width = (int)Math.Floor((double)this.int_0 * (double)this.sizeF_0.Width * 3.0 + (double)(2f * this.sizeF_0.Width));
				num += this.rectangle_3.Width;
			}
			if (this.bool_9)
			{
				this.rectangle_4 = new Rectangle(this.rectangle_3.X + this.rectangle_3.Width, this.rectangle_3.Y, (int)(this.sizeF_0.Width * (float)this.int_0), this.rectangle_3.Height);
				num += this.rectangle_4.Width;
			}
			else
			{
				this.rectangle_4 = Rectangle.Empty;
			}
			this.Int32_2 = num;
			int int_ = (int)Math.Floor((double)this.rectangle_3.Height / (double)this.sizeF_0.Height);
			this.method_68(int_);
			this.int_2 = this.int_0 * this.int_1;
			this.method_0();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000DF30 File Offset: 0x0000C130
		private PointF method_55(long long_11)
		{
			Point point_ = this.method_59(long_11);
			return this.method_56(point_);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000DF4C File Offset: 0x0000C14C
		private PointF method_56(Point point_0)
		{
			float x = 3f * this.sizeF_0.Width * (float)point_0.X + (float)this.rectangle_3.X;
			float y = (float)(point_0.Y + 1) * this.sizeF_0.Height - this.sizeF_0.Height + (float)this.rectangle_3.Y;
			return new PointF(x, y);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000DFB8 File Offset: 0x0000C1B8
		private PointF method_57(int int_14)
		{
			Point point = this.method_59((long)int_14);
			float x = 3f * this.sizeF_0.Width * (float)point.X + (float)this.rectangle_2.X;
			float y = (float)this.rectangle_2.Y;
			return new PointF(x, y);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000E008 File Offset: 0x0000C208
		private PointF method_58(Point point_0)
		{
			float x = this.sizeF_0.Width * (float)point_0.X + (float)this.rectangle_4.X;
			float y = (float)(point_0.Y + 1) * this.sizeF_0.Height - this.sizeF_0.Height + (float)this.rectangle_4.Y;
			return new PointF(x, y);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000E06C File Offset: 0x0000C26C
		private Point method_59(long long_11)
		{
			int num = (int)Math.Floor((double)long_11 / (double)this.int_0);
			int x = (int)(long_11 + (long)this.int_0 - (long)(this.int_0 * (num + 1)));
			return new Point(x, num);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00003179 File Offset: 0x00001379
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00003181 File Offset: 0x00001381
		[DefaultValue(typeof(Color), "White")]
		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				base.BackColor = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000318A File Offset: 0x0000138A
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00003192 File Offset: 0x00001392
		public override Font Font
		{
			get
			{
				return base.Font;
			}
			set
			{
				if (value == null)
				{
					return;
				}
				base.Font = value;
				this.method_54();
				base.Invalidate();
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x000031AB File Offset: 0x000013AB
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x000031B3 File Offset: 0x000013B3
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Bindable(false)]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001BA RID: 442 RVA: 0x000031BC File Offset: 0x000013BC
		// (set) Token: 0x060001BB RID: 443 RVA: 0x000031C4 File Offset: 0x000013C4
		[Browsable(false)]
		[Bindable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override RightToLeft RightToLeft
		{
			get
			{
				return base.RightToLeft;
			}
			set
			{
				base.RightToLeft = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000031CD File Offset: 0x000013CD
		// (set) Token: 0x060001BD RID: 445 RVA: 0x000031D5 File Offset: 0x000013D5
		[DefaultValue(typeof(Color), "WhiteSmoke")]
		[Category("Appearance")]
		public Color Color_0
		{
			get
			{
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001BE RID: 446 RVA: 0x000031DE File Offset: 0x000013DE
		// (set) Token: 0x060001BF RID: 447 RVA: 0x000031E6 File Offset: 0x000013E6
		[Category("Hex")]
		[DefaultValue(false)]
		[Description("Gets or sets if the count of bytes in one line is fix.")]
		public bool Boolean_0
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				if (this.bool_3 == value)
				{
					return;
				}
				this.bool_3 = value;
				this.vmethod_1(EventArgs.Empty);
				base.Invalidate();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000320A File Offset: 0x0000140A
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00003212 File Offset: 0x00001412
		[DefaultValue(16)]
		[Category("Hex")]
		[Description("Gets or sets the maximum count of bytes in one line.")]
		public int Int32_0
		{
			get
			{
				return this.int_10;
			}
			set
			{
				if (this.int_10 == value)
				{
					return;
				}
				this.int_10 = value;
				this.vmethod_12(EventArgs.Empty);
				this.method_54();
				base.Invalidate();
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000323C File Offset: 0x0000143C
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00003244 File Offset: 0x00001444
		[Description("Gets or sets the byte-count between group separators (if visible).")]
		[Category("Hex")]
		[DefaultValue(4)]
		public int Int32_1
		{
			get
			{
				return this.int_11;
			}
			set
			{
				if (this.int_11 == value)
				{
					return;
				}
				this.int_11 = value;
				this.vmethod_11(EventArgs.Empty);
				this.method_54();
				base.Invalidate();
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000326E File Offset: 0x0000146E
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00003276 File Offset: 0x00001476
		[Description("Gets or sets if the count of bytes in one line is fix.")]
		[DefaultValue(false)]
		[Category("Hex")]
		public bool Boolean_1
		{
			get
			{
				return this.bool_4;
			}
			set
			{
				if (this.bool_4 == value)
				{
					return;
				}
				this.bool_4 = value;
				this.vmethod_10(EventArgs.Empty);
				this.method_54();
				base.Invalidate();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000032A0 File Offset: 0x000014A0
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
		[Category("Hex")]
		[Description("Gets or sets the visibility of a vertical scroll bar.")]
		[DefaultValue(false)]
		public bool Boolean_2
		{
			get
			{
				return this.bool_5;
			}
			set
			{
				if (this.bool_5 == value)
				{
					return;
				}
				this.bool_5 = value;
				if (this.bool_5)
				{
					base.Controls.Add(this.vscrollBar_0);
				}
				else
				{
					base.Controls.Remove(this.vscrollBar_0);
				}
				this.method_54();
				this.method_0();
				this.vmethod_13(EventArgs.Empty);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x000032A8 File Offset: 0x000014A8
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000E10C File Offset: 0x0000C30C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public GInterface1 GInterface1_0
		{
			get
			{
				return this.ginterface1_0;
			}
			set
			{
				if (this.ginterface1_0 == value)
				{
					return;
				}
				if (value == null)
				{
					this.method_20();
				}
				else
				{
					this.method_21();
				}
				if (this.ginterface1_0 != null)
				{
					this.ginterface1_0.imethod_6(new EventHandler(this.method_71));
				}
				this.ginterface1_0 = value;
				if (this.ginterface1_0 != null)
				{
					this.ginterface1_0.imethod_5(new EventHandler(this.method_71));
				}
				this.vmethod_2(EventArgs.Empty);
				if (value == null)
				{
					this.long_6 = -1L;
					this.int_9 = 0;
					this.long_9 = 0L;
					this.method_25();
				}
				else
				{
					this.method_65(0L, 0);
					this.method_66(0L);
					if (this.bool_0 && this.Focused)
					{
						this.method_24();
					}
					else
					{
						this.method_23();
					}
				}
				this.method_69();
				this.method_70();
				this.long_2 = 0L;
				this.method_53();
				this.method_54();
				base.Invalidate();
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000032B0 File Offset: 0x000014B0
		// (set) Token: 0x060001CB RID: 459 RVA: 0x000032B8 File Offset: 0x000014B8
		[Category("Hex")]
		[Description("Gets or sets the visibility of a separator vertical line.")]
		[DefaultValue(false)]
		public bool Boolean_3
		{
			get
			{
				return this.bool_6;
			}
			set
			{
				if (this.bool_6 == value)
				{
					return;
				}
				this.bool_6 = value;
				this.vmethod_7(EventArgs.Empty);
				this.method_54();
				base.Invalidate();
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000032E2 File Offset: 0x000014E2
		// (set) Token: 0x060001CD RID: 461 RVA: 0x000032EA File Offset: 0x000014EA
		[Category("Hex")]
		[DefaultValue(false)]
		[Description("Gets or sets the visibility of header row.")]
		public bool Boolean_4
		{
			get
			{
				return this.bool_7;
			}
			set
			{
				if (this.bool_7 == value)
				{
					return;
				}
				this.bool_7 = value;
				this.vmethod_6(EventArgs.Empty);
				this.method_54();
				base.Invalidate();
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00003314 File Offset: 0x00001514
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0000331C File Offset: 0x0000151C
		[DefaultValue(false)]
		[Category("Hex")]
		[Description("Gets or sets the visibility of a line info.")]
		public bool Boolean_5
		{
			get
			{
				return this.bool_8;
			}
			set
			{
				if (this.bool_8 == value)
				{
					return;
				}
				this.bool_8 = value;
				this.vmethod_5(EventArgs.Empty);
				this.method_54();
				base.Invalidate();
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00003346 File Offset: 0x00001546
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x0000334E File Offset: 0x0000154E
		[Category("Hex")]
		[Description("Gets or sets the offset of the line info.")]
		[DefaultValue(0L)]
		public long Int64_1
		{
			get
			{
				return this.long_8;
			}
			set
			{
				if (this.long_8 == value)
				{
					return;
				}
				this.long_8 = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00003367 File Offset: 0x00001567
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x0000E1FC File Offset: 0x0000C3FC
		[Category("Hex")]
		[DefaultValue(typeof(BorderStyle), "Fixed3D")]
		[Description("Gets or sets the hex box´s border style.")]
		public BorderStyle BorderStyle_0
		{
			get
			{
				return this.borderStyle_0;
			}
			set
			{
				if (this.borderStyle_0 == value)
				{
					return;
				}
				this.borderStyle_0 = value;
				switch (this.borderStyle_0)
				{
				case BorderStyle.None:
					this.int_5 = (this.int_7 = (this.int_6 = (this.int_8 = 0)));
					break;
				case BorderStyle.FixedSingle:
					this.int_5 = (this.int_7 = (this.int_6 = (this.int_8 = 1)));
					break;
				case BorderStyle.Fixed3D:
					this.int_5 = (this.int_6 = SystemInformation.Border3DSize.Width);
					this.int_7 = (this.int_8 = SystemInformation.Border3DSize.Height);
					break;
				}
				this.method_54();
				this.vmethod_9(EventArgs.Empty);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000336F File Offset: 0x0000156F
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00003377 File Offset: 0x00001577
		[DefaultValue(false)]
		[Description("Gets or sets the visibility of the string view.")]
		[Category("Hex")]
		public bool Boolean_6
		{
			get
			{
				return this.bool_9;
			}
			set
			{
				if (this.bool_9 == value)
				{
					return;
				}
				this.bool_9 = value;
				this.vmethod_8(EventArgs.Empty);
				this.method_54();
				base.Invalidate();
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000033A1 File Offset: 0x000015A1
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0000E2CC File Offset: 0x0000C4CC
		[DefaultValue(typeof(GEnum2), "Upper")]
		[Description("Gets or sets whether the HexBox control displays the hex characters in upper or lower case.")]
		[Category("Hex")]
		public GEnum2 GEnum2_0
		{
			get
			{
				if (this.string_0 == "X")
				{
					return GEnum2.const_0;
				}
				return GEnum2.const_1;
			}
			set
			{
				string b;
				if (value == GEnum2.const_0)
				{
					b = "X";
				}
				else
				{
					b = "x";
				}
				if (this.string_0 == b)
				{
					return;
				}
				this.string_0 = b;
				this.vmethod_14(EventArgs.Empty);
				base.Invalidate();
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000033B8 File Offset: 0x000015B8
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x000033C0 File Offset: 0x000015C0
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public long Int64_2
		{
			get
			{
				return this.long_6;
			}
			set
			{
				this.method_65(value, 0);
				this.method_13();
				base.Invalidate();
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000033D6 File Offset: 0x000015D6
		// (set) Token: 0x060001DB RID: 475 RVA: 0x000033DE File Offset: 0x000015DE
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public long Int64_3
		{
			get
			{
				return this.long_9;
			}
			set
			{
				this.method_66(value);
				this.method_13();
				base.Invalidate();
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001DC RID: 476 RVA: 0x000033F3 File Offset: 0x000015F3
		// (set) Token: 0x060001DD RID: 477 RVA: 0x000033FB File Offset: 0x000015FB
		[DefaultValue(typeof(Color), "Gray")]
		[Category("Hex")]
		[Description("Gets or sets the line info color. When this property is null, then ForeColor property is used.")]
		public Color Color_1
		{
			get
			{
				return this.color_1;
			}
			set
			{
				this.color_1 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000340A File Offset: 0x0000160A
		// (set) Token: 0x060001DF RID: 479 RVA: 0x00003412 File Offset: 0x00001612
		[Description("Gets or sets the background color for the selected bytes.")]
		[Category("Hex")]
		[DefaultValue(typeof(Color), "Blue")]
		public Color Color_2
		{
			get
			{
				return this.color_2;
			}
			set
			{
				this.color_2 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00003421 File Offset: 0x00001621
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00003429 File Offset: 0x00001629
		[Category("Hex")]
		[Description("Gets or sets the foreground color for the selected bytes.")]
		[DefaultValue(typeof(Color), "White")]
		public Color Color_3
		{
			get
			{
				return this.color_3;
			}
			set
			{
				this.color_3 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00003438 File Offset: 0x00001638
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00003440 File Offset: 0x00001640
		[DefaultValue(true)]
		[Description("Gets or sets the visibility of a shadow selection.")]
		[Category("Hex")]
		public bool Boolean_7
		{
			get
			{
				return this.bool_10;
			}
			set
			{
				if (this.bool_10 == value)
				{
					return;
				}
				this.bool_10 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00003459 File Offset: 0x00001659
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00003461 File Offset: 0x00001661
		[Description("Gets or sets the color of the shadow selection.")]
		[Category("Hex")]
		public Color Color_4
		{
			get
			{
				return this.color_4;
			}
			set
			{
				this.color_4 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00003470 File Offset: 0x00001670
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00003478 File Offset: 0x00001678
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public SizeF SizeF_0
		{
			get
			{
				return this.sizeF_0;
			}
			private set
			{
				if (this.sizeF_0 == value)
				{
					return;
				}
				this.sizeF_0 = value;
				if (this.eventHandler_21 != null)
				{
					this.eventHandler_21(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x000034A9 File Offset: 0x000016A9
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x000034B1 File Offset: 0x000016B1
		[DefaultValue(0)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Int32_2
		{
			get
			{
				return this.int_12;
			}
			private set
			{
				if (this.int_12 == value)
				{
					return;
				}
				this.int_12 = value;
				if (this.eventHandler_22 != null)
				{
					this.eventHandler_22(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001EA RID: 490 RVA: 0x000034DD File Offset: 0x000016DD
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public int Int32_3
		{
			get
			{
				return this.int_0;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000034E5 File Offset: 0x000016E5
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public int Int32_4
		{
			get
			{
				return this.int_1;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001EC RID: 492 RVA: 0x000034ED File Offset: 0x000016ED
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public long Int64_4
		{
			get
			{
				return this.long_10;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000034F5 File Offset: 0x000016F5
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public long Int64_5
		{
			get
			{
				return (long)this.int_13;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000034FE File Offset: 0x000016FE
		// (set) Token: 0x060001EF RID: 495 RVA: 0x00003506 File Offset: 0x00001706
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool Boolean_8
		{
			get
			{
				return this.bool_2;
			}
			set
			{
				if (this.bool_2 == value)
				{
					return;
				}
				this.bool_2 = value;
				this.method_25();
				this.method_23();
				this.vmethod_0(EventArgs.Empty);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00003530 File Offset: 0x00001730
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public GClass0 GClass0_0
		{
			get
			{
				return this.gclass0_0;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00003538 File Offset: 0x00001738
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00003553 File Offset: 0x00001753
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public GInterface0 GInterface0_0
		{
			get
			{
				if (this.ginterface0_0 == null)
				{
					this.ginterface0_0 = new GClass1();
				}
				return this.ginterface0_0;
			}
			set
			{
				if (value != null && value != this.ginterface0_0)
				{
					this.ginterface0_0 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000E314 File Offset: 0x0000C514
		private string method_60(byte[] byte_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte byte_ in byte_0)
			{
				string value = this.method_61(byte_);
				stringBuilder.Append(value);
				stringBuilder.Append(" ");
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Remove(stringBuilder.Length - 1, 1);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000E378 File Offset: 0x0000C578
		private string method_61(byte byte_0)
		{
			string text = byte_0.ToString(this.string_0, Thread.CurrentThread.CurrentCulture);
			if (text.Length == 1)
			{
				text = "0" + text;
			}
			return text;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
		private byte[] method_62(string string_1)
		{
			if (string.IsNullOrEmpty(string_1))
			{
				return null;
			}
			string_1 = string_1.Trim();
			string[] array = string_1.Split(new char[]
			{
				' '
			});
			byte[] array2 = new byte[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				string string_2 = array[i];
				byte b;
				if (!this.method_63(string_2, out b))
				{
					return null;
				}
				array2[i] = b;
			}
			return array2;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000356E File Offset: 0x0000176E
		private bool method_63(string string_1, out byte byte_0)
		{
			return byte.TryParse(string_1, NumberStyles.HexNumber, Thread.CurrentThread.CurrentCulture, out byte_0);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00003586 File Offset: 0x00001786
		private void method_64(long long_11)
		{
			this.method_65(long_11, this.int_9);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00003595 File Offset: 0x00001795
		private void method_65(long long_11, int int_14)
		{
			if (this.int_9 != int_14)
			{
				this.int_9 = int_14;
			}
			if (long_11 != this.long_6)
			{
				this.long_6 = long_11;
				this.method_69();
				this.method_70();
				this.vmethod_3(EventArgs.Empty);
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000035CE File Offset: 0x000017CE
		private void method_66(long long_11)
		{
			if (long_11 != this.long_9)
			{
				this.long_9 = long_11;
				this.vmethod_4(EventArgs.Empty);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000035EB File Offset: 0x000017EB
		private void method_67(int int_14)
		{
			if (this.int_0 == int_14)
			{
				return;
			}
			this.int_0 = int_14;
			this.vmethod_15(EventArgs.Empty);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00003609 File Offset: 0x00001809
		private void method_68(int int_14)
		{
			if (this.int_1 == int_14)
			{
				return;
			}
			this.int_1 = int_14;
			this.vmethod_16(EventArgs.Empty);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000E418 File Offset: 0x0000C618
		private void method_69()
		{
			long num = (long)Math.Floor((double)this.long_6 / (double)this.int_0) + 1L;
			if (this.ginterface1_0 == null && this.long_10 != 0L)
			{
				this.long_10 = 0L;
				this.vmethod_17(EventArgs.Empty);
				return;
			}
			if (num != this.long_10)
			{
				this.long_10 = num;
				this.vmethod_17(EventArgs.Empty);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000E480 File Offset: 0x0000C680
		private void method_70()
		{
			int num = this.method_59(this.long_6).X + 1;
			if (this.ginterface1_0 == null && this.int_13 != 0)
			{
				this.int_13 = 0;
				this.vmethod_18(EventArgs.Empty);
				return;
			}
			if (num != this.int_13)
			{
				this.int_13 = num;
				this.vmethod_18(EventArgs.Empty);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00003627 File Offset: 0x00001827
		protected void vmethod_0(EventArgs eventArgs_0)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, eventArgs_0);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000363E File Offset: 0x0000183E
		protected void vmethod_1(EventArgs eventArgs_0)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, eventArgs_0);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00003655 File Offset: 0x00001855
		protected void vmethod_2(EventArgs eventArgs_0)
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, eventArgs_0);
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000366C File Offset: 0x0000186C
		protected void vmethod_3(EventArgs eventArgs_0)
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, eventArgs_0);
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00003683 File Offset: 0x00001883
		protected void vmethod_4(EventArgs eventArgs_0)
		{
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, eventArgs_0);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000369A File Offset: 0x0000189A
		protected void vmethod_5(EventArgs eventArgs_0)
		{
			if (this.eventHandler_5 != null)
			{
				this.eventHandler_5(this, eventArgs_0);
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000036B1 File Offset: 0x000018B1
		protected void vmethod_6(EventArgs eventArgs_0)
		{
			if (this.eventHandler_6 != null)
			{
				this.eventHandler_6(this, eventArgs_0);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000036C8 File Offset: 0x000018C8
		protected void vmethod_7(EventArgs eventArgs_0)
		{
			if (this.eventHandler_7 != null)
			{
				this.eventHandler_7(this, eventArgs_0);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000036DF File Offset: 0x000018DF
		protected void vmethod_8(EventArgs eventArgs_0)
		{
			if (this.eventHandler_8 != null)
			{
				this.eventHandler_8(this, eventArgs_0);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000036F6 File Offset: 0x000018F6
		protected void vmethod_9(EventArgs eventArgs_0)
		{
			if (this.eventHandler_9 != null)
			{
				this.eventHandler_9(this, eventArgs_0);
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000370D File Offset: 0x0000190D
		protected void vmethod_10(EventArgs eventArgs_0)
		{
			if (this.eventHandler_12 != null)
			{
				this.eventHandler_12(this, eventArgs_0);
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00003724 File Offset: 0x00001924
		protected void vmethod_11(EventArgs eventArgs_0)
		{
			if (this.eventHandler_10 != null)
			{
				this.eventHandler_10(this, eventArgs_0);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000373B File Offset: 0x0000193B
		protected void vmethod_12(EventArgs eventArgs_0)
		{
			if (this.eventHandler_11 != null)
			{
				this.eventHandler_11(this, eventArgs_0);
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00003752 File Offset: 0x00001952
		protected void vmethod_13(EventArgs eventArgs_0)
		{
			if (this.eventHandler_13 != null)
			{
				this.eventHandler_13(this, eventArgs_0);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00003769 File Offset: 0x00001969
		protected void vmethod_14(EventArgs eventArgs_0)
		{
			if (this.eventHandler_14 != null)
			{
				this.eventHandler_14(this, eventArgs_0);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00003780 File Offset: 0x00001980
		protected void vmethod_15(EventArgs eventArgs_0)
		{
			if (this.eventHandler_15 != null)
			{
				this.eventHandler_15(this, eventArgs_0);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00003797 File Offset: 0x00001997
		protected void vmethod_16(EventArgs eventArgs_0)
		{
			if (this.eventHandler_16 != null)
			{
				this.eventHandler_16(this, eventArgs_0);
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000037AE File Offset: 0x000019AE
		protected void vmethod_17(EventArgs eventArgs_0)
		{
			if (this.eventHandler_17 != null)
			{
				this.eventHandler_17(this, eventArgs_0);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000037C5 File Offset: 0x000019C5
		protected void vmethod_18(EventArgs eventArgs_0)
		{
			if (this.eventHandler_18 != null)
			{
				this.eventHandler_18(this, eventArgs_0);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000037DC File Offset: 0x000019DC
		protected void vmethod_19(EventArgs eventArgs_0)
		{
			if (this.eventHandler_19 != null)
			{
				this.eventHandler_19(this, eventArgs_0);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000037F3 File Offset: 0x000019F3
		protected void vmethod_20(EventArgs eventArgs_0)
		{
			if (this.eventHandler_20 != null)
			{
				this.eventHandler_20(this, eventArgs_0);
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000380A File Offset: 0x00001A0A
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (!this.Focused)
			{
				base.Focus();
			}
			if (e.Button == MouseButtons.Left)
			{
				this.method_26(new Point(e.X, e.Y));
			}
			base.OnMouseDown(e);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000E4E4 File Offset: 0x0000C6E4
		protected override void OnMouseWheel(MouseEventArgs e)
		{
			int int_ = -(e.Delta * SystemInformation.MouseWheelScrollLines / 120);
			this.method_6(int_);
			base.OnMouseWheel(e);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00003846 File Offset: 0x00001A46
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.method_54();
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00003855 File Offset: 0x00001A55
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.method_23();
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00003864 File Offset: 0x00001A64
		protected override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			this.method_25();
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00003873 File Offset: 0x00001A73
		private void method_71(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000387B File Offset: 0x00001A7B
		protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
		{
			base.ScaleControl(factor, specified);
			base.BeginInvoke(new MethodInvoker(this.method_72));
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00003898 File Offset: 0x00001A98
		[CompilerGenerated]
		private void method_72()
		{
			this.method_54();
			if (this.bool_0)
			{
				this.method_25();
				this.method_23();
			}
			base.Invalidate();
		}

		// Token: 0x04000079 RID: 121
		private Rectangle rectangle_0;

		// Token: 0x0400007A RID: 122
		private Rectangle rectangle_1;

		// Token: 0x0400007B RID: 123
		private Rectangle rectangle_2;

		// Token: 0x0400007C RID: 124
		private Rectangle rectangle_3;

		// Token: 0x0400007D RID: 125
		private Rectangle rectangle_4;

		// Token: 0x0400007E RID: 126
		private StringFormat stringFormat_0;

		// Token: 0x0400007F RID: 127
		private int int_0;

		// Token: 0x04000080 RID: 128
		private int int_1;

		// Token: 0x04000081 RID: 129
		private int int_2;

		// Token: 0x04000082 RID: 130
		private long long_0;

		// Token: 0x04000083 RID: 131
		private long long_1;

		// Token: 0x04000084 RID: 132
		private long long_2;

		// Token: 0x04000085 RID: 133
		public VScrollBar vscrollBar_0;

		// Token: 0x04000086 RID: 134
		private System.Windows.Forms.Timer timer_0 = new System.Windows.Forms.Timer();

		// Token: 0x04000087 RID: 135
		private long long_3;

		// Token: 0x04000088 RID: 136
		private static int int_3;

		// Token: 0x04000089 RID: 137
		private int int_4;

		// Token: 0x0400008A RID: 138
		private int int_5 = SystemInformation.Border3DSize.Width;

		// Token: 0x0400008B RID: 139
		private int int_6 = SystemInformation.Border3DSize.Width;

		// Token: 0x0400008C RID: 140
		private int int_7 = SystemInformation.Border3DSize.Height;

		// Token: 0x0400008D RID: 141
		private int int_8 = SystemInformation.Border3DSize.Height;

		// Token: 0x0400008E RID: 142
		private long long_4;

		// Token: 0x0400008F RID: 143
		private long long_5;

		// Token: 0x04000090 RID: 144
		private long long_6 = -1L;

		// Token: 0x04000091 RID: 145
		private int int_9;

		// Token: 0x04000092 RID: 146
		private string string_0 = "X";

		// Token: 0x04000093 RID: 147
		private GControl0.Interface0 interface0_0;

		// Token: 0x04000094 RID: 148
		private GControl0.Class14 class14_0;

		// Token: 0x04000095 RID: 149
		private GControl0.Class15 class15_0;

		// Token: 0x04000096 RID: 150
		private GControl0.Class16 class16_0;

		// Token: 0x04000097 RID: 151
		private bool bool_0;

		// Token: 0x04000098 RID: 152
		private bool bool_1;

		// Token: 0x04000099 RID: 153
		private long long_7;

		// Token: 0x0400009A RID: 154
		private bool bool_2;

		// Token: 0x0400009B RID: 155
		[CompilerGenerated]
		private EventHandler eventHandler_0;

		// Token: 0x0400009C RID: 156
		[CompilerGenerated]
		private EventHandler eventHandler_1;

		// Token: 0x0400009D RID: 157
		[CompilerGenerated]
		private EventHandler eventHandler_2;

		// Token: 0x0400009E RID: 158
		[CompilerGenerated]
		private EventHandler eventHandler_3;

		// Token: 0x0400009F RID: 159
		[CompilerGenerated]
		private EventHandler eventHandler_4;

		// Token: 0x040000A0 RID: 160
		[CompilerGenerated]
		private EventHandler eventHandler_5;

		// Token: 0x040000A1 RID: 161
		[CompilerGenerated]
		private EventHandler eventHandler_6;

		// Token: 0x040000A2 RID: 162
		[CompilerGenerated]
		private EventHandler eventHandler_7;

		// Token: 0x040000A3 RID: 163
		[CompilerGenerated]
		private EventHandler eventHandler_8;

		// Token: 0x040000A4 RID: 164
		[CompilerGenerated]
		private EventHandler eventHandler_9;

		// Token: 0x040000A5 RID: 165
		[CompilerGenerated]
		private EventHandler eventHandler_10;

		// Token: 0x040000A6 RID: 166
		[CompilerGenerated]
		private EventHandler eventHandler_11;

		// Token: 0x040000A7 RID: 167
		[CompilerGenerated]
		private EventHandler eventHandler_12;

		// Token: 0x040000A8 RID: 168
		[CompilerGenerated]
		private EventHandler eventHandler_13;

		// Token: 0x040000A9 RID: 169
		[CompilerGenerated]
		private EventHandler eventHandler_14;

		// Token: 0x040000AA RID: 170
		[CompilerGenerated]
		private EventHandler eventHandler_15;

		// Token: 0x040000AB RID: 171
		[CompilerGenerated]
		private EventHandler eventHandler_16;

		// Token: 0x040000AC RID: 172
		[CompilerGenerated]
		private EventHandler eventHandler_17;

		// Token: 0x040000AD RID: 173
		[CompilerGenerated]
		private EventHandler eventHandler_18;

		// Token: 0x040000AE RID: 174
		[CompilerGenerated]
		private EventHandler eventHandler_19;

		// Token: 0x040000AF RID: 175
		[CompilerGenerated]
		private EventHandler eventHandler_20;

		// Token: 0x040000B0 RID: 176
		[CompilerGenerated]
		private EventHandler eventHandler_21;

		// Token: 0x040000B1 RID: 177
		[CompilerGenerated]
		private EventHandler eventHandler_22;

		// Token: 0x040000B2 RID: 178
		private Color color_0 = Color.FromName("WhiteSmoke");

		// Token: 0x040000B3 RID: 179
		private bool bool_3;

		// Token: 0x040000B4 RID: 180
		private int int_10 = 16;

		// Token: 0x040000B5 RID: 181
		private int int_11 = 4;

		// Token: 0x040000B6 RID: 182
		private bool bool_4;

		// Token: 0x040000B7 RID: 183
		private bool bool_5;

		// Token: 0x040000B8 RID: 184
		public GInterface1 ginterface1_0;

		// Token: 0x040000B9 RID: 185
		private bool bool_6;

		// Token: 0x040000BA RID: 186
		private bool bool_7;

		// Token: 0x040000BB RID: 187
		private bool bool_8;

		// Token: 0x040000BC RID: 188
		private long long_8;

		// Token: 0x040000BD RID: 189
		private BorderStyle borderStyle_0 = BorderStyle.Fixed3D;

		// Token: 0x040000BE RID: 190
		private bool bool_9;

		// Token: 0x040000BF RID: 191
		private long long_9;

		// Token: 0x040000C0 RID: 192
		private Color color_1 = Color.Gray;

		// Token: 0x040000C1 RID: 193
		private Color color_2 = Color.Blue;

		// Token: 0x040000C2 RID: 194
		private Color color_3 = Color.White;

		// Token: 0x040000C3 RID: 195
		private bool bool_10 = true;

		// Token: 0x040000C4 RID: 196
		private Color color_4 = Color.FromArgb(100, 60, 188, 255);

		// Token: 0x040000C5 RID: 197
		private SizeF sizeF_0;

		// Token: 0x040000C6 RID: 198
		private int int_12;

		// Token: 0x040000C7 RID: 199
		private long long_10;

		// Token: 0x040000C8 RID: 200
		private int int_13;

		// Token: 0x040000C9 RID: 201
		private GClass0 gclass0_0;

		// Token: 0x040000CA RID: 202
		private GInterface0 ginterface0_0;

		// Token: 0x02000021 RID: 33
		private interface Interface0
		{
			// Token: 0x0600021B RID: 539
			void imethod_0();

			// Token: 0x0600021C RID: 540
			void imethod_1();

			// Token: 0x0600021D RID: 541
			bool imethod_2(ref Message message_0);

			// Token: 0x0600021E RID: 542
			bool imethod_3(ref Message message_0);

			// Token: 0x0600021F RID: 543
			bool imethod_4(ref Message message_0);

			// Token: 0x06000220 RID: 544
			PointF imethod_5(long long_0);
		}

		// Token: 0x02000022 RID: 34
		private sealed class Class14 : GControl0.Interface0
		{
			// Token: 0x06000221 RID: 545 RVA: 0x000038BA File Offset: 0x00001ABA
			public Class14(GControl0 gcontrol0_1)
			{
				this.gcontrol0_0 = gcontrol0_1;
			}

			// Token: 0x06000222 RID: 546 RVA: 0x000023F6 File Offset: 0x000005F6
			public void imethod_0()
			{
			}

			// Token: 0x06000223 RID: 547 RVA: 0x000023F6 File Offset: 0x000005F6
			public void imethod_1()
			{
			}

			// Token: 0x06000224 RID: 548 RVA: 0x000038C9 File Offset: 0x00001AC9
			public bool imethod_2(ref Message message_0)
			{
				return this.gcontrol0_0.method_29(ref message_0);
			}

			// Token: 0x06000225 RID: 549 RVA: 0x000038C9 File Offset: 0x00001AC9
			public bool imethod_3(ref Message message_0)
			{
				return this.gcontrol0_0.method_29(ref message_0);
			}

			// Token: 0x06000226 RID: 550 RVA: 0x000038C9 File Offset: 0x00001AC9
			public bool imethod_4(ref Message message_0)
			{
				return this.gcontrol0_0.method_29(ref message_0);
			}

			// Token: 0x06000227 RID: 551 RVA: 0x0000E510 File Offset: 0x0000C710
			public PointF imethod_5(long long_0)
			{
				return default(PointF);
			}

			// Token: 0x040000CB RID: 203
			private GControl0 gcontrol0_0;
		}

		// Token: 0x02000023 RID: 35
		private class Class15 : GControl0.Interface0
		{
			// Token: 0x06000228 RID: 552 RVA: 0x000038D7 File Offset: 0x00001AD7
			public Class15(GControl0 gcontrol0_1)
			{
				this.gcontrol0_0 = gcontrol0_1;
			}

			// Token: 0x06000229 RID: 553 RVA: 0x0000E528 File Offset: 0x0000C728
			public virtual void imethod_0()
			{
				this.gcontrol0_0.MouseDown += this.gcontrol0_0_MouseDown;
				this.gcontrol0_0.MouseMove += this.gcontrol0_0_MouseMove;
				this.gcontrol0_0.MouseUp += this.gcontrol0_0_MouseUp;
			}

			// Token: 0x0600022A RID: 554 RVA: 0x0000E57C File Offset: 0x0000C77C
			public virtual void imethod_1()
			{
				this.gcontrol0_0.MouseDown -= this.gcontrol0_0_MouseDown;
				this.gcontrol0_0.MouseMove -= this.gcontrol0_0_MouseMove;
				this.gcontrol0_0.MouseUp -= this.gcontrol0_0_MouseUp;
			}

			// Token: 0x0600022B RID: 555 RVA: 0x0000E5D0 File Offset: 0x0000C7D0
			private void gcontrol0_0_MouseDown(object sender, MouseEventArgs e)
			{
				if (e.Button != MouseButtons.Left)
				{
					return;
				}
				this.bool_1 = true;
				if (!this.bool_0)
				{
					this.struct0_0 = new Struct0(this.gcontrol0_0.long_6, this.gcontrol0_0.int_9);
					this.gcontrol0_0.method_15();
					return;
				}
				this.gcontrol0_0_MouseMove(this, e);
			}

			// Token: 0x0600022C RID: 556 RVA: 0x0000E630 File Offset: 0x0000C830
			private void gcontrol0_0_MouseMove(object sender, MouseEventArgs e)
			{
				if (!this.bool_1)
				{
					return;
				}
				this.struct0_1 = this.vmethod_25(new Point(e.X, e.Y));
				long int64_ = this.struct0_1.Int64_0;
				long num;
				long num2;
				if (int64_ < this.struct0_0.Int64_0)
				{
					num = int64_;
					num2 = this.struct0_0.Int64_0 - int64_;
				}
				else if (int64_ > this.struct0_0.Int64_0)
				{
					num = this.struct0_0.Int64_0;
					num2 = int64_ - num;
				}
				else
				{
					num = this.gcontrol0_0.long_6;
					num2 = 0L;
				}
				if (num != this.gcontrol0_0.long_6 || num2 != this.gcontrol0_0.long_9)
				{
					this.gcontrol0_0.method_19(num, num2);
					this.gcontrol0_0.method_14(this.struct0_1.Int64_0);
				}
			}

			// Token: 0x0600022D RID: 557 RVA: 0x000038E6 File Offset: 0x00001AE6
			private void gcontrol0_0_MouseUp(object sender, MouseEventArgs e)
			{
				this.bool_1 = false;
			}

			// Token: 0x0600022E RID: 558 RVA: 0x0000E700 File Offset: 0x0000C900
			public virtual bool imethod_4(ref Message message_0)
			{
				Keys keys = (Keys)(message_0.WParam.ToInt32() | (int)Control.ModifierKeys);
				bool flag;
				return ((flag = this.Dictionary_0.ContainsKey(keys)) && this.method_1(keys)) || (flag ? this.Dictionary_0[keys] : new GControl0.Class15.Delegate0(this.method_0))(ref message_0);
			}

			// Token: 0x0600022F RID: 559 RVA: 0x000038EF File Offset: 0x00001AEF
			protected bool method_0(ref Message message_0)
			{
				this.gcontrol0_0.method_13();
				return this.gcontrol0_0.method_29(ref message_0);
			}

			// Token: 0x06000230 RID: 560 RVA: 0x0000E760 File Offset: 0x0000C960
			protected bool method_1(Keys keys_0)
			{
				KeyEventArgs keyEventArgs = new KeyEventArgs(keys_0);
				this.gcontrol0_0.OnKeyDown(keyEventArgs);
				return keyEventArgs.Handled;
			}

			// Token: 0x06000231 RID: 561 RVA: 0x00003908 File Offset: 0x00001B08
			protected virtual bool vmethod_0(ref Message message_0)
			{
				return this.vmethod_21();
			}

			// Token: 0x06000232 RID: 562 RVA: 0x0000E788 File Offset: 0x0000C988
			protected virtual bool vmethod_1(ref Message message_0)
			{
				long num = this.gcontrol0_0.long_6;
				int int_ = this.gcontrol0_0.int_9;
				if (num != 0L || int_ != 0)
				{
					num = Math.Max(-1L, num - (long)this.gcontrol0_0.int_0);
					if (num == -1L)
					{
						return true;
					}
					this.gcontrol0_0.method_64(num);
					if (num < this.gcontrol0_0.long_4)
					{
						this.gcontrol0_0.method_8();
					}
					this.gcontrol0_0.method_24();
					this.gcontrol0_0.Invalidate();
				}
				this.gcontrol0_0.method_13();
				this.gcontrol0_0.method_15();
				return true;
			}

			// Token: 0x06000233 RID: 563 RVA: 0x00003910 File Offset: 0x00001B10
			protected virtual bool vmethod_2(ref Message message_0)
			{
				return this.vmethod_22();
			}

			// Token: 0x06000234 RID: 564 RVA: 0x0000E824 File Offset: 0x0000CA24
			protected virtual bool vmethod_3(ref Message message_0)
			{
				long num = this.gcontrol0_0.long_6;
				int num2 = this.gcontrol0_0.int_9;
				if (num == this.gcontrol0_0.ginterface1_0.imethod_4() && num2 == 0)
				{
					return true;
				}
				num = Math.Min(this.gcontrol0_0.ginterface1_0.imethod_4(), num + (long)this.gcontrol0_0.int_0);
				if (num == this.gcontrol0_0.ginterface1_0.imethod_4())
				{
					num2 = 0;
				}
				this.gcontrol0_0.method_65(num, num2);
				if (num > this.gcontrol0_0.long_5 - 1L)
				{
					this.gcontrol0_0.method_7();
				}
				this.gcontrol0_0.method_24();
				this.gcontrol0_0.method_13();
				this.gcontrol0_0.method_15();
				this.gcontrol0_0.Invalidate();
				return true;
			}

			// Token: 0x06000235 RID: 565 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
			protected virtual bool vmethod_4(ref Message message_0)
			{
				long num = this.gcontrol0_0.long_6;
				int int_ = this.gcontrol0_0.int_9;
				if (num == 0L && int_ == 0)
				{
					return true;
				}
				num = Math.Max(0L, num - (long)this.gcontrol0_0.int_2);
				if (num == 0L)
				{
					return true;
				}
				this.gcontrol0_0.method_64(num);
				if (num < this.gcontrol0_0.long_4)
				{
					this.gcontrol0_0.method_10();
				}
				this.gcontrol0_0.method_15();
				this.gcontrol0_0.method_24();
				this.gcontrol0_0.Invalidate();
				return true;
			}

			// Token: 0x06000236 RID: 566 RVA: 0x0000E980 File Offset: 0x0000CB80
			protected virtual bool vmethod_5(ref Message message_0)
			{
				long num = this.gcontrol0_0.long_6;
				int num2 = this.gcontrol0_0.int_9;
				if (num == this.gcontrol0_0.ginterface1_0.imethod_4() && num2 == 0)
				{
					return true;
				}
				num = Math.Min(this.gcontrol0_0.ginterface1_0.imethod_4(), num + (long)this.gcontrol0_0.int_2);
				if (num == this.gcontrol0_0.ginterface1_0.imethod_4())
				{
					num2 = 0;
				}
				this.gcontrol0_0.method_65(num, num2);
				if (num > this.gcontrol0_0.long_5 - 1L)
				{
					this.gcontrol0_0.method_9();
				}
				this.gcontrol0_0.method_15();
				this.gcontrol0_0.method_24();
				this.gcontrol0_0.Invalidate();
				return true;
			}

			// Token: 0x06000237 RID: 567 RVA: 0x0000EA44 File Offset: 0x0000CC44
			protected virtual bool vmethod_6(ref Message message_0)
			{
				long num = this.gcontrol0_0.long_6;
				long num2 = this.gcontrol0_0.long_9;
				if (num + num2 < 1L)
				{
					return true;
				}
				if (num + num2 <= this.struct0_0.Int64_0)
				{
					if (num == 0L)
					{
						return true;
					}
					num -= 1L;
					num2 += 1L;
				}
				else
				{
					num2 = Math.Max(0L, num2 - 1L);
				}
				this.gcontrol0_0.method_13();
				this.gcontrol0_0.method_19(num, num2);
				return true;
			}

			// Token: 0x06000238 RID: 568 RVA: 0x0000EAB8 File Offset: 0x0000CCB8
			protected virtual bool vmethod_7(ref Message message_0)
			{
				long num = this.gcontrol0_0.long_6;
				long num2 = this.gcontrol0_0.long_9;
				if (num - (long)this.gcontrol0_0.int_0 < 0L && num <= this.struct0_0.Int64_0)
				{
					return true;
				}
				if (this.struct0_0.Int64_0 >= num + num2)
				{
					num -= (long)this.gcontrol0_0.int_0;
					num2 += (long)this.gcontrol0_0.int_0;
					this.gcontrol0_0.method_19(num, num2);
					this.gcontrol0_0.method_13();
				}
				else
				{
					num2 -= (long)this.gcontrol0_0.int_0;
					if (num2 < 0L)
					{
						num = this.struct0_0.Int64_0 + num2;
						num2 = -num2;
						this.gcontrol0_0.method_19(num, num2);
						this.gcontrol0_0.method_13();
					}
					else
					{
						num2 -= (long)this.gcontrol0_0.int_0;
						this.gcontrol0_0.method_19(num, num2);
						this.gcontrol0_0.method_14(num + num2);
					}
				}
				return true;
			}

			// Token: 0x06000239 RID: 569 RVA: 0x0000EBB4 File Offset: 0x0000CDB4
			protected virtual bool vmethod_8(ref Message message_0)
			{
				long num = this.gcontrol0_0.long_6;
				long num2 = this.gcontrol0_0.long_9;
				if (num + num2 >= this.gcontrol0_0.ginterface1_0.imethod_4())
				{
					return true;
				}
				if (this.struct0_0.Int64_0 <= num)
				{
					num2 += 1L;
					this.gcontrol0_0.method_19(num, num2);
					this.gcontrol0_0.method_14(num + num2);
				}
				else
				{
					num += 1L;
					num2 = Math.Max(0L, num2 - 1L);
					this.gcontrol0_0.method_19(num, num2);
					this.gcontrol0_0.method_13();
				}
				return true;
			}

			// Token: 0x0600023A RID: 570 RVA: 0x0000EC4C File Offset: 0x0000CE4C
			protected virtual bool vmethod_9(ref Message message_0)
			{
				long num = this.gcontrol0_0.long_6;
				long num2 = this.gcontrol0_0.long_9;
				long num3 = this.gcontrol0_0.ginterface1_0.imethod_4();
				if (num + num2 + (long)this.gcontrol0_0.int_0 > num3)
				{
					return true;
				}
				if (this.struct0_0.Int64_0 <= num)
				{
					num2 += (long)this.gcontrol0_0.int_0;
					this.gcontrol0_0.method_19(num, num2);
					this.gcontrol0_0.method_14(num + num2);
				}
				else
				{
					num2 -= (long)this.gcontrol0_0.int_0;
					if (num2 < 0L)
					{
						num = this.struct0_0.Int64_0;
						num2 = -num2;
					}
					else
					{
						num += (long)this.gcontrol0_0.int_0;
					}
					this.gcontrol0_0.method_19(num, num2);
					this.gcontrol0_0.method_13();
				}
				return true;
			}

			// Token: 0x0600023B RID: 571 RVA: 0x0000ED20 File Offset: 0x0000CF20
			protected virtual bool vmethod_10(ref Message message_0)
			{
				if (this.gcontrol0_0.bool_9 && this.gcontrol0_0.interface0_0.GetType() == typeof(GControl0.Class15))
				{
					this.gcontrol0_0.method_22();
					this.gcontrol0_0.method_13();
					this.gcontrol0_0.method_15();
					this.gcontrol0_0.method_24();
					this.gcontrol0_0.Invalidate();
					return true;
				}
				if (this.gcontrol0_0.Parent == null)
				{
					return true;
				}
				this.gcontrol0_0.Parent.SelectNextControl(this.gcontrol0_0, true, true, true, true);
				return true;
			}

			// Token: 0x0600023C RID: 572 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
			protected virtual bool vmethod_11(ref Message message_0)
			{
				if (this.gcontrol0_0.interface0_0 is GControl0.Class16)
				{
					this.bool_0 = false;
					this.gcontrol0_0.method_21();
					this.gcontrol0_0.method_13();
					this.gcontrol0_0.method_15();
					this.gcontrol0_0.method_24();
					this.gcontrol0_0.Invalidate();
					return true;
				}
				if (this.gcontrol0_0.Parent == null)
				{
					return true;
				}
				this.gcontrol0_0.Parent.SelectNextControl(this.gcontrol0_0, false, true, true, true);
				return true;
			}

			// Token: 0x0600023D RID: 573 RVA: 0x0000EE4C File Offset: 0x0000D04C
			protected virtual bool vmethod_12(ref Message message_0)
			{
				if (!this.gcontrol0_0.ginterface1_0.imethod_13())
				{
					return true;
				}
				if (this.gcontrol0_0.Boolean_0)
				{
					return true;
				}
				long long_ = this.gcontrol0_0.long_6;
				long long_2 = this.gcontrol0_0.long_9;
				long num = (this.gcontrol0_0.int_9 != 0 || long_2 != 0L) ? long_ : (long_ - 1L);
				if (num < 0L && long_2 < 1L)
				{
					return true;
				}
				long long_3 = (long_2 > 0L) ? long_2 : 1L;
				this.gcontrol0_0.ginterface1_0.imethod_3(Math.Max(0L, num), long_3);
				this.gcontrol0_0.method_0();
				if (long_2 == 0L)
				{
					this.vmethod_23();
				}
				this.gcontrol0_0.method_15();
				this.gcontrol0_0.Invalidate();
				return true;
			}

			// Token: 0x0600023E RID: 574 RVA: 0x0000EF08 File Offset: 0x0000D108
			protected virtual bool vmethod_13(ref Message message_0)
			{
				if (!this.gcontrol0_0.ginterface1_0.imethod_13())
				{
					return true;
				}
				if (this.gcontrol0_0.Boolean_0)
				{
					return true;
				}
				long long_ = this.gcontrol0_0.long_6;
				long long_2 = this.gcontrol0_0.long_9;
				if (long_ >= this.gcontrol0_0.ginterface1_0.imethod_4())
				{
					return true;
				}
				long long_3 = (long_2 > 0L) ? long_2 : 1L;
				this.gcontrol0_0.ginterface1_0.imethod_3(long_, long_3);
				this.gcontrol0_0.method_0();
				this.gcontrol0_0.method_15();
				this.gcontrol0_0.Invalidate();
				return true;
			}

			// Token: 0x0600023F RID: 575 RVA: 0x0000EFA4 File Offset: 0x0000D1A4
			protected virtual bool vmethod_14(ref Message message_0)
			{
				long num = this.gcontrol0_0.long_6;
				int int_ = this.gcontrol0_0.int_9;
				if (num < 1L)
				{
					return true;
				}
				num = 0L;
				int_ = 0;
				this.gcontrol0_0.method_65(num, int_);
				this.gcontrol0_0.method_13();
				this.gcontrol0_0.method_24();
				this.gcontrol0_0.method_15();
				return true;
			}

			// Token: 0x06000240 RID: 576 RVA: 0x0000F004 File Offset: 0x0000D204
			protected virtual bool vmethod_15(ref Message message_0)
			{
				long num = this.gcontrol0_0.long_6;
				int int_ = this.gcontrol0_0.int_9;
				if (num >= this.gcontrol0_0.ginterface1_0.imethod_4() - 1L)
				{
					return true;
				}
				num = this.gcontrol0_0.ginterface1_0.imethod_4();
				int_ = 0;
				this.gcontrol0_0.method_65(num, int_);
				this.gcontrol0_0.method_13();
				this.gcontrol0_0.method_24();
				this.gcontrol0_0.method_15();
				return true;
			}

			// Token: 0x06000241 RID: 577 RVA: 0x0000F084 File Offset: 0x0000D284
			protected virtual bool vmethod_16(ref Message message_0)
			{
				if (this.bool_1)
				{
					return true;
				}
				if (this.bool_0)
				{
					return true;
				}
				this.bool_0 = true;
				if (this.gcontrol0_0.long_9 > 0L)
				{
					return true;
				}
				this.struct0_0 = new Struct0(this.gcontrol0_0.long_6, this.gcontrol0_0.int_9);
				return true;
			}

			// Token: 0x06000242 RID: 578 RVA: 0x00003918 File Offset: 0x00001B18
			protected virtual bool vmethod_17(ref Message message_0)
			{
				this.gcontrol0_0.method_33();
				return true;
			}

			// Token: 0x06000243 RID: 579 RVA: 0x00003926 File Offset: 0x00001B26
			protected virtual bool vmethod_18(ref Message message_0)
			{
				this.gcontrol0_0.method_35();
				return true;
			}

			// Token: 0x06000244 RID: 580 RVA: 0x00003934 File Offset: 0x00001B34
			protected virtual bool vmethod_19(ref Message message_0)
			{
				this.gcontrol0_0.method_37();
				return true;
			}

			// Token: 0x06000245 RID: 581 RVA: 0x0000F0E0 File Offset: 0x0000D2E0
			public virtual bool imethod_3(ref Message message_0)
			{
				if (Control.ModifierKeys == Keys.Control)
				{
					return this.gcontrol0_0.method_29(ref message_0);
				}
				bool flag = this.gcontrol0_0.ginterface1_0.imethod_11();
				bool flag2 = this.gcontrol0_0.ginterface1_0.imethod_12();
				bool flag3 = this.gcontrol0_0.ginterface1_0.imethod_13();
				long long_ = this.gcontrol0_0.long_6;
				long long_2 = this.gcontrol0_0.long_9;
				int num = this.gcontrol0_0.int_9;
				if ((!flag && long_ != this.gcontrol0_0.ginterface1_0.imethod_4()) || (!flag2 && long_ == this.gcontrol0_0.ginterface1_0.imethod_4()))
				{
					return this.gcontrol0_0.method_29(ref message_0);
				}
				char c = (char)message_0.WParam.ToInt32();
				if (!Uri.IsHexDigit(c))
				{
					return this.gcontrol0_0.method_29(ref message_0);
				}
				if (this.method_2(c))
				{
					return true;
				}
				if (this.gcontrol0_0.Boolean_0)
				{
					return true;
				}
				bool flag4;
				if (!(flag4 = (long_ == this.gcontrol0_0.ginterface1_0.imethod_4())) && flag2 && this.gcontrol0_0.Boolean_8 && num == 0)
				{
					flag4 = true;
				}
				if (flag3 && flag2 && long_2 > 0L)
				{
					this.gcontrol0_0.ginterface1_0.imethod_3(long_, long_2);
					flag4 = true;
					num = 0;
					this.gcontrol0_0.method_65(long_, num);
				}
				this.gcontrol0_0.method_15();
				byte b;
				if (flag4)
				{
					b = 0;
				}
				else
				{
					b = this.gcontrol0_0.ginterface1_0.imethod_0(long_);
				}
				string text = b.ToString("X", Thread.CurrentThread.CurrentCulture);
				if (text.Length == 1)
				{
					text = "0" + text;
				}
				string text2 = c.ToString();
				if (num == 0)
				{
					text2 += text.Substring(1, 1);
				}
				else
				{
					text2 = text.Substring(0, 1) + text2;
				}
				byte b2 = byte.Parse(text2, NumberStyles.AllowHexSpecifier, Thread.CurrentThread.CurrentCulture);
				if (flag4)
				{
					this.gcontrol0_0.ginterface1_0.imethod_2(long_, new byte[]
					{
						b2
					});
				}
				else
				{
					this.gcontrol0_0.ginterface1_0.imethod_1(long_, b2);
				}
				this.vmethod_22();
				this.gcontrol0_0.Invalidate();
				return true;
			}

			// Token: 0x06000246 RID: 582 RVA: 0x0000F328 File Offset: 0x0000D528
			protected bool method_2(char char_0)
			{
				KeyPressEventArgs keyPressEventArgs = new KeyPressEventArgs(char_0);
				this.gcontrol0_0.OnKeyPress(keyPressEventArgs);
				return keyPressEventArgs.Handled;
			}

			// Token: 0x06000247 RID: 583 RVA: 0x0000F350 File Offset: 0x0000D550
			public virtual bool imethod_2(ref Message message_0)
			{
				Keys keys = (Keys)(message_0.WParam.ToInt32() | (int)Control.ModifierKeys);
				if ((keys == Keys.ShiftKey || keys == Keys.Insert) && this.method_3(keys))
				{
					return true;
				}
				if (keys == Keys.ShiftKey)
				{
					this.bool_0 = false;
					return true;
				}
				if (keys != Keys.Insert)
				{
					return this.gcontrol0_0.method_29(ref message_0);
				}
				return this.vmethod_20(ref message_0);
			}

			// Token: 0x06000248 RID: 584 RVA: 0x00003942 File Offset: 0x00001B42
			protected virtual bool vmethod_20(ref Message message_0)
			{
				this.gcontrol0_0.Boolean_8 = !this.gcontrol0_0.Boolean_8;
				return true;
			}

			// Token: 0x06000249 RID: 585 RVA: 0x0000F3B0 File Offset: 0x0000D5B0
			protected bool method_3(Keys keys_0)
			{
				KeyEventArgs keyEventArgs = new KeyEventArgs(keys_0);
				this.gcontrol0_0.OnKeyUp(keyEventArgs);
				return keyEventArgs.Handled;
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600024A RID: 586 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
			private Dictionary<Keys, GControl0.Class15.Delegate0> Dictionary_0
			{
				get
				{
					if (this.dictionary_0 == null)
					{
						this.dictionary_0 = new Dictionary<Keys, GControl0.Class15.Delegate0>();
						this.dictionary_0.Add(Keys.Left, new GControl0.Class15.Delegate0(this.vmethod_0));
						this.dictionary_0.Add(Keys.Up, new GControl0.Class15.Delegate0(this.vmethod_1));
						this.dictionary_0.Add(Keys.Right, new GControl0.Class15.Delegate0(this.vmethod_2));
						this.dictionary_0.Add(Keys.Down, new GControl0.Class15.Delegate0(this.vmethod_3));
						this.dictionary_0.Add(Keys.Prior, new GControl0.Class15.Delegate0(this.vmethod_4));
						this.dictionary_0.Add(Keys.Next, new GControl0.Class15.Delegate0(this.vmethod_5));
						this.dictionary_0.Add(Keys.LButton | Keys.MButton | Keys.Space | Keys.Shift, new GControl0.Class15.Delegate0(this.vmethod_6));
						this.dictionary_0.Add(Keys.RButton | Keys.MButton | Keys.Space | Keys.Shift, new GControl0.Class15.Delegate0(this.vmethod_7));
						this.dictionary_0.Add(Keys.LButton | Keys.RButton | Keys.MButton | Keys.Space | Keys.Shift, new GControl0.Class15.Delegate0(this.vmethod_8));
						this.dictionary_0.Add(Keys.Back | Keys.Space | Keys.Shift, new GControl0.Class15.Delegate0(this.vmethod_9));
						this.dictionary_0.Add(Keys.Tab, new GControl0.Class15.Delegate0(this.vmethod_10));
						this.dictionary_0.Add(Keys.Back, new GControl0.Class15.Delegate0(this.vmethod_12));
						this.dictionary_0.Add(Keys.Delete, new GControl0.Class15.Delegate0(this.vmethod_13));
						this.dictionary_0.Add(Keys.Home, new GControl0.Class15.Delegate0(this.vmethod_14));
						this.dictionary_0.Add(Keys.End, new GControl0.Class15.Delegate0(this.vmethod_15));
						this.dictionary_0.Add(Keys.ShiftKey | Keys.Shift, new GControl0.Class15.Delegate0(this.vmethod_16));
						this.dictionary_0.Add((Keys)131139, new GControl0.Class15.Delegate0(this.vmethod_17));
						this.dictionary_0.Add((Keys)131160, new GControl0.Class15.Delegate0(this.vmethod_18));
						this.dictionary_0.Add((Keys)131158, new GControl0.Class15.Delegate0(this.vmethod_19));
					}
					return this.dictionary_0;
				}
			}

			// Token: 0x0600024B RID: 587 RVA: 0x0000F608 File Offset: 0x0000D808
			protected virtual bool vmethod_21()
			{
				long num = this.gcontrol0_0.long_6;
				bool long_ = this.gcontrol0_0.long_9 != 0L;
				int num2 = this.gcontrol0_0.int_9;
				if (long_)
				{
					num2 = 0;
					this.gcontrol0_0.method_65(num, num2);
					this.gcontrol0_0.method_15();
				}
				else
				{
					if (num == 0L && num2 == 0)
					{
						return true;
					}
					if (num2 > 0)
					{
						num2--;
					}
					else
					{
						num = Math.Max(0L, num - 1L);
						num2++;
					}
					this.gcontrol0_0.method_65(num, num2);
					if (num < this.gcontrol0_0.long_4)
					{
						this.gcontrol0_0.method_8();
					}
					this.gcontrol0_0.method_24();
					this.gcontrol0_0.Invalidate();
				}
				this.gcontrol0_0.method_13();
				return true;
			}

			// Token: 0x0600024C RID: 588 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
			protected virtual bool vmethod_22()
			{
				long num = this.gcontrol0_0.long_6;
				int num2 = this.gcontrol0_0.int_9;
				long long_ = this.gcontrol0_0.long_9;
				if (long_ != 0L)
				{
					num += long_;
					num2 = 0;
					this.gcontrol0_0.method_65(num, num2);
					this.gcontrol0_0.method_15();
				}
				else if (num != this.gcontrol0_0.ginterface1_0.imethod_4() || num2 != 0)
				{
					if (num2 > 0)
					{
						num = Math.Min(this.gcontrol0_0.ginterface1_0.imethod_4(), num + 1L);
						num2 = 0;
					}
					else
					{
						num2++;
					}
					this.gcontrol0_0.method_65(num, num2);
					if (num > this.gcontrol0_0.long_5 - 1L)
					{
						this.gcontrol0_0.method_7();
					}
					this.gcontrol0_0.method_24();
					this.gcontrol0_0.Invalidate();
				}
				this.gcontrol0_0.method_13();
				return true;
			}

			// Token: 0x0600024D RID: 589 RVA: 0x0000F79C File Offset: 0x0000D99C
			protected virtual bool vmethod_23()
			{
				long num = this.gcontrol0_0.long_6;
				int int_ = this.gcontrol0_0.int_9;
				if (num == 0L)
				{
					return true;
				}
				num = Math.Max(0L, num - 1L);
				int_ = 0;
				this.gcontrol0_0.method_65(num, int_);
				if (num < this.gcontrol0_0.long_4)
				{
					this.gcontrol0_0.method_8();
				}
				this.gcontrol0_0.method_24();
				this.gcontrol0_0.method_13();
				this.gcontrol0_0.Invalidate();
				return true;
			}

			// Token: 0x0600024E RID: 590 RVA: 0x0000F81C File Offset: 0x0000DA1C
			protected virtual bool vmethod_24()
			{
				long num = this.gcontrol0_0.long_6;
				int int_ = this.gcontrol0_0.int_9;
				if (num == this.gcontrol0_0.ginterface1_0.imethod_4())
				{
					return true;
				}
				num = Math.Min(this.gcontrol0_0.ginterface1_0.imethod_4(), num + 1L);
				int_ = 0;
				this.gcontrol0_0.method_65(num, int_);
				if (num > this.gcontrol0_0.long_5 - 1L)
				{
					this.gcontrol0_0.method_7();
				}
				this.gcontrol0_0.method_24();
				this.gcontrol0_0.method_13();
				this.gcontrol0_0.Invalidate();
				return true;
			}

			// Token: 0x0600024F RID: 591 RVA: 0x0000395E File Offset: 0x00001B5E
			public virtual PointF imethod_5(long long_0)
			{
				return this.gcontrol0_0.method_55(long_0);
			}

			// Token: 0x06000250 RID: 592 RVA: 0x0000396C File Offset: 0x00001B6C
			protected virtual Struct0 vmethod_25(Point point_0)
			{
				return this.gcontrol0_0.method_27(point_0);
			}

			// Token: 0x040000CC RID: 204
			protected GControl0 gcontrol0_0;

			// Token: 0x040000CD RID: 205
			protected bool bool_0;

			// Token: 0x040000CE RID: 206
			private bool bool_1;

			// Token: 0x040000CF RID: 207
			private Struct0 struct0_0;

			// Token: 0x040000D0 RID: 208
			private Struct0 struct0_1;

			// Token: 0x040000D1 RID: 209
			private Dictionary<Keys, GControl0.Class15.Delegate0> dictionary_0;

			// Token: 0x02000024 RID: 36
			// (Invoke) Token: 0x06000252 RID: 594
			private delegate bool Delegate0(ref Message m);
		}

		// Token: 0x02000025 RID: 37
		private sealed class Class16 : GControl0.Class15
		{
			// Token: 0x06000255 RID: 597 RVA: 0x0000397A File Offset: 0x00001B7A
			public Class16(GControl0 gcontrol0_1) : base(gcontrol0_1)
			{
				this.gcontrol0_0.int_9 = 0;
			}

			// Token: 0x06000256 RID: 598 RVA: 0x0000F8C0 File Offset: 0x0000DAC0
			public override bool imethod_4(ref Message message_0)
			{
				Keys keys = (Keys)(message_0.WParam.ToInt32() | (int)Control.ModifierKeys);
				if ((keys == Keys.Tab || keys == (Keys.LButton | Keys.Back | Keys.Shift)) && base.method_1(keys))
				{
					return true;
				}
				if (keys == Keys.Tab)
				{
					return this.vmethod_10(ref message_0);
				}
				if (keys == (Keys.LButton | Keys.Back | Keys.Shift))
				{
					return this.vmethod_11(ref message_0);
				}
				return base.imethod_4(ref message_0);
			}

			// Token: 0x06000257 RID: 599 RVA: 0x0000398F File Offset: 0x00001B8F
			protected override bool vmethod_0(ref Message message_0)
			{
				return this.vmethod_23();
			}

			// Token: 0x06000258 RID: 600 RVA: 0x00003997 File Offset: 0x00001B97
			protected override bool vmethod_2(ref Message message_0)
			{
				return this.vmethod_24();
			}

			// Token: 0x06000259 RID: 601 RVA: 0x0000F920 File Offset: 0x0000DB20
			public override bool imethod_3(ref Message message_0)
			{
				if (Control.ModifierKeys == Keys.Control)
				{
					return this.gcontrol0_0.method_29(ref message_0);
				}
				bool flag = this.gcontrol0_0.ginterface1_0.imethod_11();
				bool flag2 = this.gcontrol0_0.ginterface1_0.imethod_12();
				bool flag3 = this.gcontrol0_0.ginterface1_0.imethod_13();
				long long_ = this.gcontrol0_0.long_6;
				long long_2 = this.gcontrol0_0.long_9;
				int int_ = this.gcontrol0_0.int_9;
				if ((!flag && long_ != this.gcontrol0_0.ginterface1_0.imethod_4()) || (!flag2 && long_ == this.gcontrol0_0.ginterface1_0.imethod_4()))
				{
					return this.gcontrol0_0.method_29(ref message_0);
				}
				char char_ = (char)message_0.WParam.ToInt32();
				if (base.method_2(char_))
				{
					return true;
				}
				if (this.gcontrol0_0.Boolean_0)
				{
					return true;
				}
				bool flag4;
				if (!(flag4 = (long_ == this.gcontrol0_0.ginterface1_0.imethod_4())) && flag2 && this.gcontrol0_0.Boolean_8)
				{
					flag4 = true;
				}
				if (flag3 && flag2 && long_2 > 0L)
				{
					this.gcontrol0_0.ginterface1_0.imethod_3(long_, long_2);
					flag4 = true;
					int_ = 0;
					this.gcontrol0_0.method_65(long_, int_);
				}
				this.gcontrol0_0.method_15();
				byte b = this.gcontrol0_0.GInterface0_0.imethod_1(char_);
				if (flag4)
				{
					this.gcontrol0_0.ginterface1_0.imethod_2(long_, new byte[]
					{
						b
					});
				}
				else
				{
					this.gcontrol0_0.ginterface1_0.imethod_1(long_, b);
				}
				this.vmethod_24();
				this.gcontrol0_0.Invalidate();
				return true;
			}

			// Token: 0x0600025A RID: 602 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
			public override PointF imethod_5(long long_0)
			{
				Point point_ = this.gcontrol0_0.method_59(long_0);
				return this.gcontrol0_0.method_58(point_);
			}

			// Token: 0x0600025B RID: 603 RVA: 0x0000399F File Offset: 0x00001B9F
			protected override Struct0 vmethod_25(Point point_0)
			{
				return this.gcontrol0_0.method_28(point_0);
			}
		}
	}
}
