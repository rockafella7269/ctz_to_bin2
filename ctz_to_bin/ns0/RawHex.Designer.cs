namespace ns0
{
	// Token: 0x0200000B RID: 11
	public sealed partial class RawHex : global::System.Windows.Forms.Form
	{
		// Token: 0x06000074 RID: 116 RVA: 0x0000262E File Offset: 0x0000082E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000965C File Offset: 0x0000785C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.RawHex));
			this.hexBox1 = new global::ns0.GControl0();
			base.SuspendLayout();
			this.hexBox1.Int32_0 = 8;
			this.hexBox1.Boolean_4 = true;
			this.hexBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.hexBox1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.hexBox1.Int32_1 = 8;
			this.hexBox1.Boolean_5 = true;
			this.hexBox1.Location = new global::System.Drawing.Point(0, 0);
			this.hexBox1.Name = "hexBox1";
			this.hexBox1.Color_4 = global::System.Drawing.Color.FromArgb(100, 60, 188, 255);
			this.hexBox1.Size = new global::System.Drawing.Size(800, 450);
			this.hexBox1.Boolean_6 = true;
			this.hexBox1.TabIndex = 1;
			this.hexBox1.Boolean_2 = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.hexBox1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "RawHex";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RawHex";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.RawHex_FormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.RawHex_FormClosed);
			base.Load += new global::System.EventHandler(this.RawHex_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000033 RID: 51
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000034 RID: 52
		private global::ns0.GControl0 hexBox1;
	}
}
