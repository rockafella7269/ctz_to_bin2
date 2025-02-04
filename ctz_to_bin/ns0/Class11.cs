using System;
using System.Collections;

namespace ns0
{
	// Token: 0x02000017 RID: 23
	internal sealed class Class11 : ICollection, IEnumerable
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x000029BF File Offset: 0x00000BBF
		public Class11()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00009EF8 File Offset: 0x000080F8
		public Class11(IEnumerable ienumerable_0)
		{
			if (ienumerable_0 == null)
			{
				throw new ArgumentNullException("collection");
			}
			foreach (object obj in ienumerable_0)
			{
				Class8 class8_ = (Class8)obj;
				this.method_3(class8_);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000029D2 File Offset: 0x00000BD2
		public Class8 Class8_0
		{
			get
			{
				return this.class8_0;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000029DA File Offset: 0x00000BDA
		public void method_0(Class8 class8_1, Class8 class8_2)
		{
			this.method_9(class8_1, class8_2);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000029E4 File Offset: 0x00000BE4
		public void method_1(Class8 class8_1, Class8 class8_2)
		{
			this.method_10(class8_1, class8_2);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000029EE File Offset: 0x00000BEE
		public void method_2(Class8 class8_1)
		{
			if (this.class8_0 == null)
			{
				this.method_14(class8_1);
				return;
			}
			this.method_10(this.class8_0, class8_1);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002A0D File Offset: 0x00000C0D
		public void method_3(Class8 class8_1)
		{
			if (this.class8_0 == null)
			{
				this.method_14(class8_1);
				return;
			}
			this.method_9(this.method_12(), class8_1);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002A2C File Offset: 0x00000C2C
		public void method_4(Class8 class8_1)
		{
			this.method_11(class8_1);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002A35 File Offset: 0x00000C35
		public void method_5()
		{
			if (this.class8_0 == null)
			{
				throw new InvalidOperationException("The collection is empty.");
			}
			this.method_11(this.class8_0);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002A56 File Offset: 0x00000C56
		public void method_6()
		{
			if (this.class8_0 == null)
			{
				throw new InvalidOperationException("The collection is empty.");
			}
			this.method_11(this.method_12());
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002A77 File Offset: 0x00000C77
		public Class8 method_7(Class8 class8_1, Class8 class8_2)
		{
			this.method_9(class8_1, class8_2);
			this.method_11(class8_1);
			return class8_2;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00009F6C File Offset: 0x0000816C
		public void method_8()
		{
			Class8 class2;
			for (Class8 @class = this.Class8_0; @class != null; @class = class2)
			{
				class2 = @class.Class8_0;
				this.method_13(@class);
			}
			this.class8_0 = null;
			this.int_0 = 0;
			this.int_1++;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00009FB0 File Offset: 0x000081B0
		private void method_9(Class8 class8_1, Class8 class8_2)
		{
			class8_2.class8_1 = class8_1;
			class8_2.class8_0 = class8_1.class8_0;
			class8_2.class11_0 = this;
			if (class8_1.class8_0 != null)
			{
				class8_1.class8_0.class8_1 = class8_2;
			}
			class8_1.class8_0 = class8_2;
			this.int_1++;
			this.int_0++;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000A010 File Offset: 0x00008210
		private void method_10(Class8 class8_1, Class8 class8_2)
		{
			class8_2.class8_0 = class8_1;
			class8_2.class8_1 = class8_1.class8_1;
			class8_2.class11_0 = this;
			if (class8_1.class8_1 != null)
			{
				class8_1.class8_1.class8_0 = class8_2;
			}
			class8_1.class8_1 = class8_2;
			if (this.class8_0 == class8_1)
			{
				this.class8_0 = class8_2;
			}
			this.int_1++;
			this.int_0++;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000A080 File Offset: 0x00008280
		private void method_11(Class8 class8_1)
		{
			Class8 class8_2 = class8_1.class8_1;
			Class8 @class = class8_1.class8_0;
			if (class8_2 != null)
			{
				class8_2.class8_0 = @class;
			}
			if (@class != null)
			{
				@class.class8_1 = class8_2;
			}
			if (this.class8_0 == class8_1)
			{
				this.class8_0 = @class;
			}
			this.method_13(class8_1);
			this.int_0--;
			this.int_1++;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000A0E4 File Offset: 0x000082E4
		private Class8 method_12()
		{
			Class8 result = null;
			for (Class8 @class = this.Class8_0; @class != null; @class = @class.Class8_0)
			{
				result = @class;
			}
			return result;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002A89 File Offset: 0x00000C89
		private void method_13(Class8 class8_1)
		{
			class8_1.class11_0 = null;
			class8_1.class8_0 = null;
			class8_1.class8_1 = null;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002AA0 File Offset: 0x00000CA0
		private void method_14(Class8 class8_1)
		{
			class8_1.class11_0 = this;
			class8_1.class8_0 = null;
			class8_1.class8_1 = null;
			this.class8_0 = class8_1;
			this.int_1++;
			this.int_0++;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000A10C File Offset: 0x0000830C
		public void CopyTo(Array array, int index)
		{
			Class8[] array2 = array as Class8[];
			for (Class8 @class = this.Class8_0; @class != null; @class = @class.Class8_0)
			{
				array2[index++] = @class;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00002ADA File Offset: 0x00000CDA
		public int Count
		{
			get
			{
				return this.int_0;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000247A File Offset: 0x0000067A
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00002AE2 File Offset: 0x00000CE2
		public object SyncRoot
		{
			get
			{
				return this.object_0;
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002AEA File Offset: 0x00000CEA
		public IEnumerator GetEnumerator()
		{
			return new Class11.Class12(this);
		}

		// Token: 0x04000052 RID: 82
		private readonly object object_0 = new object();

		// Token: 0x04000053 RID: 83
		internal int int_0;

		// Token: 0x04000054 RID: 84
		internal Class8 class8_0;

		// Token: 0x04000055 RID: 85
		internal int int_1;

		// Token: 0x02000018 RID: 24
		internal sealed class Class12 : IEnumerator, IDisposable
		{
			// Token: 0x060000DD RID: 221 RVA: 0x00002AF2 File Offset: 0x00000CF2
			internal Class12(Class11 class11_1)
			{
				this.class11_0 = class11_1;
				this.int_1 = class11_1.int_1;
				this.class8_0 = null;
				this.int_0 = -1;
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000DE RID: 222 RVA: 0x00002B1B File Offset: 0x00000D1B
			object IEnumerator.Current
			{
				get
				{
					if (this.int_0 < 0 || this.int_0 > this.class11_0.Count)
					{
						throw new InvalidOperationException("Enumerator is positioned before the first element or after the last element of the collection.");
					}
					return this.class8_0;
				}
			}

			// Token: 0x060000DF RID: 223 RVA: 0x0000A140 File Offset: 0x00008340
			public bool MoveNext()
			{
				if (this.int_1 != this.class11_0.int_1)
				{
					throw new InvalidOperationException("Collection was modified after the enumerator was instantiated.");
				}
				if (this.int_0 >= this.class11_0.Count)
				{
					return false;
				}
				int num = this.int_0 + 1;
				this.int_0 = num;
				if (num == 0)
				{
					this.class8_0 = this.class11_0.Class8_0;
				}
				else
				{
					this.class8_0 = this.class8_0.Class8_0;
				}
				return this.int_0 < this.class11_0.Count;
			}

			// Token: 0x060000E0 RID: 224 RVA: 0x00002B4A File Offset: 0x00000D4A
			void IEnumerator.Reset()
			{
				if (this.int_1 != this.class11_0.int_1)
				{
					throw new InvalidOperationException("Collection was modified after the enumerator was instantiated.");
				}
				this.int_0 = -1;
				this.class8_0 = null;
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x000023F6 File Offset: 0x000005F6
			public void Dispose()
			{
			}

			// Token: 0x04000056 RID: 86
			private Class11 class11_0;

			// Token: 0x04000057 RID: 87
			private Class8 class8_0;

			// Token: 0x04000058 RID: 88
			private int int_0;

			// Token: 0x04000059 RID: 89
			private int int_1;
		}
	}
}
