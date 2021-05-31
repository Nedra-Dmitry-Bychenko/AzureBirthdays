
namespace AzureBirthdays {
  partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.lbPassed = new System.Windows.Forms.Label();
      this.llAuthenticate = new System.Windows.Forms.LinkLabel();
      this.tbAuthenticate = new System.Windows.Forms.TextBox();
      this.lbAzureManual = new System.Windows.Forms.Label();
      this.btnRun = new System.Windows.Forms.Button();
      this.clmChecked = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.clmBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.clmDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dgvMain = new System.Windows.Forms.DataGridView();
      this.clmObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
      this.SuspendLayout();
      // 
      // lbPassed
      // 
      this.lbPassed.AutoSize = true;
      this.lbPassed.Location = new System.Drawing.Point(27, 373);
      this.lbPassed.Name = "lbPassed";
      this.lbPassed.Size = new System.Drawing.Size(366, 41);
      this.lbPassed.TabIndex = 7;
      this.lbPassed.Text = "Successfully authenticated";
      this.lbPassed.Visible = false;
      // 
      // llAuthenticate
      // 
      this.llAuthenticate.AutoSize = true;
      this.llAuthenticate.Location = new System.Drawing.Point(27, 297);
      this.llAuthenticate.Name = "llAuthenticate";
      this.llAuthenticate.Size = new System.Drawing.Size(186, 41);
      this.llAuthenticate.TabIndex = 6;
      this.llAuthenticate.TabStop = true;
      this.llAuthenticate.Text = "Authenticate";
      this.llAuthenticate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAuthenticate_LinkClicked);
      // 
      // tbAuthenticate
      // 
      this.tbAuthenticate.BackColor = System.Drawing.SystemColors.Info;
      this.tbAuthenticate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tbAuthenticate.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.tbAuthenticate.Location = new System.Drawing.Point(27, 153);
      this.tbAuthenticate.Name = "tbAuthenticate";
      this.tbAuthenticate.ReadOnly = true;
      this.tbAuthenticate.Size = new System.Drawing.Size(566, 114);
      this.tbAuthenticate.TabIndex = 5;
      this.tbAuthenticate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.tbAuthenticate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAuthenticate_KeyDown);
      this.tbAuthenticate.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbAuthenticate_MouseDoubleClick);
      // 
      // lbAzureManual
      // 
      this.lbAzureManual.Location = new System.Drawing.Point(27, 28);
      this.lbAzureManual.Name = "lbAzureManual";
      this.lbAzureManual.Size = new System.Drawing.Size(566, 105);
      this.lbAzureManual.TabIndex = 4;
      this.lbAzureManual.Text = "To connect to Azure Active Directory you should authenticate with the code below:" +
    "";
      // 
      // btnRun
      // 
      this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRun.Location = new System.Drawing.Point(1485, 847);
      this.btnRun.Name = "btnRun";
      this.btnRun.Size = new System.Drawing.Size(188, 58);
      this.btnRun.TabIndex = 9;
      this.btnRun.Text = "button1";
      this.btnRun.UseVisualStyleBackColor = true;
      // 
      // clmChecked
      // 
      this.clmChecked.Frozen = true;
      this.clmChecked.HeaderText = "";
      this.clmChecked.MinimumWidth = 12;
      this.clmChecked.Name = "clmChecked";
      this.clmChecked.Width = 250;
      // 
      // clmName
      // 
      this.clmName.Frozen = true;
      this.clmName.HeaderText = "Name";
      this.clmName.MinimumWidth = 12;
      this.clmName.Name = "clmName";
      this.clmName.ReadOnly = true;
      this.clmName.Width = 250;
      // 
      // clmBirthday
      // 
      this.clmBirthday.HeaderText = "Birthday";
      this.clmBirthday.MinimumWidth = 12;
      this.clmBirthday.Name = "clmBirthday";
      this.clmBirthday.ReadOnly = true;
      this.clmBirthday.Width = 250;
      // 
      // dataGridViewCheckBoxColumn1
      // 
      this.dataGridViewCheckBoxColumn1.Frozen = true;
      this.dataGridViewCheckBoxColumn1.HeaderText = "";
      this.dataGridViewCheckBoxColumn1.MinimumWidth = 12;
      this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
      this.dataGridViewCheckBoxColumn1.Width = 250;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "Name";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 12;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 250;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.HeaderText = "Birthday";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 12;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 250;
      // 
      // clmDepartment
      // 
      this.clmDepartment.HeaderText = "Department";
      this.clmDepartment.MinimumWidth = 12;
      this.clmDepartment.Name = "clmDepartment";
      this.clmDepartment.ReadOnly = true;
      this.clmDepartment.Width = 250;
      // 
      // dataGridViewCheckBoxColumn2
      // 
      this.dataGridViewCheckBoxColumn2.Frozen = true;
      this.dataGridViewCheckBoxColumn2.HeaderText = "";
      this.dataGridViewCheckBoxColumn2.MinimumWidth = 12;
      this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
      this.dataGridViewCheckBoxColumn2.Width = 250;
      // 
      // dgvMain
      // 
      this.dgvMain.AllowUserToAddRows = false;
      this.dgvMain.AllowUserToDeleteRows = false;
      this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmObject,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.dgvMain.Location = new System.Drawing.Point(614, 28);
      this.dgvMain.Name = "dgvMain";
      this.dgvMain.RowHeadersVisible = false;
      this.dgvMain.RowHeadersWidth = 102;
      this.dgvMain.RowTemplate.Height = 49;
      this.dgvMain.Size = new System.Drawing.Size(1059, 774);
      this.dgvMain.TabIndex = 10;
      this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // clmObject
      // 
      this.clmObject.Frozen = true;
      this.clmObject.HeaderText = "";
      this.clmObject.MinimumWidth = 12;
      this.clmObject.Name = "clmObject";
      this.clmObject.ReadOnly = true;
      this.clmObject.Visible = false;
      this.clmObject.Width = 250;
      // 
      // dataGridViewCheckBoxColumn3
      // 
      this.dataGridViewCheckBoxColumn3.Frozen = true;
      this.dataGridViewCheckBoxColumn3.HeaderText = "";
      this.dataGridViewCheckBoxColumn3.MinimumWidth = 12;
      this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
      this.dataGridViewCheckBoxColumn3.Width = 50;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.Frozen = true;
      this.dataGridViewTextBoxColumn3.HeaderText = "Name";
      this.dataGridViewTextBoxColumn3.MinimumWidth = 12;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 350;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.Frozen = true;
      this.dataGridViewTextBoxColumn4.HeaderText = "Birthday";
      this.dataGridViewTextBoxColumn4.MinimumWidth = 12;
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 250;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.HeaderText = "Department";
      this.dataGridViewTextBoxColumn5.MinimumWidth = 12;
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.Width = 250;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1707, 938);
      this.Controls.Add(this.dgvMain);
      this.Controls.Add(this.btnRun);
      this.Controls.Add(this.lbPassed);
      this.Controls.Add(this.llAuthenticate);
      this.Controls.Add(this.tbAuthenticate);
      this.Controls.Add(this.lbAzureManual);
      this.Name = "MainForm";
      this.Text = "Birthdays";
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbPassed;
    private System.Windows.Forms.LinkLabel llAuthenticate;
    private System.Windows.Forms.TextBox tbAuthenticate;
    private System.Windows.Forms.Label lbAzureManual;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.DataGridViewCheckBoxColumn clmChecked;
    private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
    private System.Windows.Forms.DataGridViewTextBoxColumn clmBirthday;
    private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn clmDepartment;
    private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
    private System.Windows.Forms.DataGridView dgvMain;
    private System.Windows.Forms.DataGridViewTextBoxColumn clmObject;
    private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
  }
}

