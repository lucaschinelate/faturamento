using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using faturamento;
using faturamento.Entity.Faturamento;

namespace faturamento.Library.Class.Forms
{
	public class CustomParentForm : Form
	{
		frmPrincipal mdi;

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			this.WindowState = FormWindowState.Maximized;

			mdi = (frmPrincipal) this.MdiParent;
			Boolean bolNewItem = true;

			foreach (ToolStripButton item in mdi.tabForms.Items) {
				item.Checked = false;
				if (item.Name == this.Name) {
					item.Checked = true;
					bolNewItem = false;
				}
			}
			if (bolNewItem == true) {
				ToolStripButton newButton = new ToolStripButton();
				newButton.Name = this.Name;
				newButton.Text = this.Text;
				newButton.Checked = true;
				mdi.tabForms.Items.Add(newButton);
			}
		}

		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);

			mdi = (frmPrincipal) this.MdiParent;
			foreach (ToolStripButton item in mdi.tabForms.Items) {
				item.Checked = false;
				if (item.Name == this.Name) {
					item.Checked = true;
				}
			}
		}

		protected override void OnClosed(EventArgs e)
		{
			base.OnClosed(e);
			mdi = (frmPrincipal) this.MdiParent;
			foreach (ToolStripButton item in mdi.tabForms.Items) {
				item.Checked = false;
				if (item.Name == this.Name) {
					mdi.tabForms.Items.Remove(item);
					return;
				}
			}
			
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// CustomParentForm
			// 
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Name = "CustomParentForm";
			this.Load += new System.EventHandler(this.CustomParentForm_Load);
			this.ResumeLayout(false);

		}

		private void CustomParentForm_Load(object sender, EventArgs e)
		{
			
		}
	}
}
