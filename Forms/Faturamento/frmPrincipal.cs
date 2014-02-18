using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace faturamento
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void tabForms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			foreach (ToolStripButton form in tabForms.Items) {
				form.Checked = false;
				if (form.Name == e.ClickedItem.Name) {
					form.Checked = true;
				}
			}

			foreach (Form form in Application.OpenForms) {
				if (form.Name == e.ClickedItem.Name) {
					form.Focus();
					return;
				}
			}
		}
	}
}
