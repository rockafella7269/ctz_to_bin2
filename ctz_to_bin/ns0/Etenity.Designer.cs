namespace ns0
{
	// Token: 0x02000004 RID: 4
	public sealed partial class Etenity : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002422 File Offset: 0x00000622
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003CB4 File Offset: 0x00001EB4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns0.Etenity));
			this.checkedListBox1 = new global::System.Windows.Forms.CheckedListBox();
			this.treeView1 = new global::System.Windows.Forms.TreeView();
			this.button1 = new global::System.Windows.Forms.Button();
			this.saveFileDialog_0 = new global::System.Windows.Forms.SaveFileDialog();
			base.SuspendLayout();
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new global::System.Drawing.Point(207, 227);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new global::System.Drawing.Size(120, 94);
			this.checkedListBox1.TabIndex = 0;
			this.treeView1.BackColor = global::System.Drawing.SystemColors.Control;
			this.treeView1.Location = new global::System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new global::System.Drawing.Size(585, 389);
			this.treeView1.TabIndex = 1;
			this.treeView1.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.NodeMouseClick += new global::System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
			this.treeView1.Click += new global::System.EventHandler(this.treeView1_Click);
			this.button1.Location = new global::System.Drawing.Point(12, 395);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(562, 26);
			this.button1.TabIndex = 2;
			this.button1.Text = "Save to file";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(586, 433);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.treeView1);
			base.Controls.Add(this.checkedListBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Etenity";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "File sections";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Etenity_FormClosed);
			base.Load += new global::System.EventHandler(this.Etenity_Load);
			base.Shown += new global::System.EventHandler(this.Etenity_Shown);
			base.ResumeLayout(false);
		}

		// Token: 0x04000005 RID: 5
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.CheckedListBox checkedListBox1;

		// Token: 0x04000007 RID: 7
		public global::System.Windows.Forms.TreeView treeView1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog_0;
	}
}
