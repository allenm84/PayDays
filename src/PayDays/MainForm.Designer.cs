namespace PayDays
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.gridPayDays = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.gridPayDays)).BeginInit();
      this.SuspendLayout();
      // 
      // gridPayDays
      // 
      this.gridPayDays.AllowUserToAddRows = false;
      this.gridPayDays.AllowUserToDeleteRows = false;
      this.gridPayDays.AllowUserToResizeColumns = false;
      this.gridPayDays.AllowUserToResizeRows = false;
      this.gridPayDays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.gridPayDays.BackgroundColor = System.Drawing.SystemColors.Window;
      this.gridPayDays.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.gridPayDays.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.gridPayDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridPayDays.ColumnHeadersVisible = false;
      this.gridPayDays.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridPayDays.Location = new System.Drawing.Point(10, 10);
      this.gridPayDays.MultiSelect = false;
      this.gridPayDays.Name = "gridPayDays";
      this.gridPayDays.ReadOnly = true;
      this.gridPayDays.RowHeadersVisible = false;
      this.gridPayDays.RowTemplate.Height = 18;
      this.gridPayDays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.gridPayDays.Size = new System.Drawing.Size(258, 253);
      this.gridPayDays.TabIndex = 0;
      this.gridPayDays.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridPayDays_CellFormatting);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(278, 273);
      this.Controls.Add(this.gridPayDays);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Pay Days";
      ((System.ComponentModel.ISupportInitialize)(this.gridPayDays)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView gridPayDays;
  }
}

