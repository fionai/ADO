using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DBtools;
using System.Runtime.InteropServices;

namespace Academy
{
	public partial class MainForm : Form
	{
		string[] queries =
		{
			"SELECT * FROM Students WHERE [group]=group_id AND direction=direction_id"
		};
		DBtools.Connector connector;
		DBtools.Connector movies_connector;
		public MainForm()
		{
			InitializeComponent();
			AllocConsole();
			connector = new DBtools.Connector("Data Source=PROBOOK\\SQLEXPRESS;Initial Catalog=SPU_411_Import;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
			tabControl_SelectedIndexChanged(tabControl, null);
		}
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataGridView dgv =
			(this.GetType().GetField($"dgv{tabControl.SelectedTab.Text}").GetValue(this) as DataGridView);
			dgv.DataSource  = connector.Select($"SELECT * FROM {tabControl.SelectedTab.Text}");
			toolStripStatusLabel.Text = $"Количество записей: {dgv.RowCount - 1}";
		}
	}
}
