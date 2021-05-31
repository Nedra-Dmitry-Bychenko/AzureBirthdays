using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureBirthdays {
  public partial class MainForm : Form {
    #region Private Data

    private string m_Code;
    private string m_Url;

    private NedraUsers m_Users;

    #endregion Private Data

    #region Algorithm

    private void CoreFeed() {
      foreach (var user in m_Users.Items) {
        dgvMain.Rows.Add();

        DataGridViewRow row = dgvMain.Rows[dgvMain.Rows.Count - 1];

        row.Cells[0].Value = user;
        row.Cells[1].Value = true;
        row.Cells[2].Value = user.FullName;
        row.Cells[3].Value = user.Department;
      }
    }

    private void CoreAuthenticate() {
      if (string.IsNullOrEmpty(m_Url))
        return;

      // Clipboard wants STA
      Thread thread = new(() => Clipboard.SetText(m_Code));
      thread.SetApartmentState(ApartmentState.STA);
      thread.Start();
      thread.Join();

      Process.Start(new System.Diagnostics.ProcessStartInfo {
        FileName = m_Url,
        UseShellExecute = true
      });
    }

    private void OnAuthentication(object sender, AuthenticationEventArgs args) {
      m_Url = args.Url;
      m_Code = args.Code;

      Action action = () => {
        tbAuthenticate.Text = m_Code;
        llAuthenticate.Text = $"{m_Url}";
      };

      tbAuthenticate.Invoke(action);
    }

    private async Task CoreStartAuthentication() {
      await AzureClient.Build(OnAuthentication);

      if (AzureClient.Client is not null) {
        llAuthenticate.Visible = false;

        lbPassed.Location = llAuthenticate.Location;
        lbPassed.Visible = true;

        m_Users = await NedraUsers.Create();

        CoreFeed();
      }
    }

    #endregion Algorithm

    #region Create

    public MainForm() {
      InitializeComponent();
    }

    #endregion Create

    private async void MainForm_Load(object sender, EventArgs e) {
      await CoreStartAuthentication();
    }

    private void llAuthenticate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      CoreAuthenticate();
    }

    private void tbAuthenticate_MouseDoubleClick(object sender, MouseEventArgs e) {
      CoreAuthenticate();
    }

    private void tbAuthenticate_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.None) {
        e.Handled = true;

        CoreAuthenticate();
      }
    }

    private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }
  }
}
