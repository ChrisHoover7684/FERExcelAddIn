using System.Windows.Forms;

namespace FERExcelAddin
{
    partial class frmGasketSelector
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblFluidType = new System.Windows.Forms.Label();
            this.btnToggleUnits = new System.Windows.Forms.Button();
            this.cmbFluidType = new System.Windows.Forms.ComboBox();
            this.lblPressure = new System.Windows.Forms.Label();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lblFlangeType = new System.Windows.Forms.Label();
            this.cmbFlangeType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPressureUnit = new System.Windows.Forms.Label();
            this.lblTempUnit = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.lblMinTempUnit = new System.Windows.Forms.Label();
            this.cmbServiceSeverity = new System.Windows.Forms.ComboBox();
            this.lblServiceSeverity = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnShowAllGasket = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFluidType
            // 
            this.lblFluidType.AutoSize = true;
            this.lblFluidType.Location = new System.Drawing.Point(10, 163);
            this.lblFluidType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFluidType.Name = "lblFluidType";
            this.lblFluidType.Size = new System.Drawing.Size(85, 20);
            this.lblFluidType.TabIndex = 0;
            this.lblFluidType.Text = "Fluid Type:";
            // 
            // btnToggleUnits
            // 
            this.btnToggleUnits.Location = new System.Drawing.Point(233, 14);
            this.btnToggleUnits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnToggleUnits.Name = "btnToggleUnits";
            this.btnToggleUnits.Size = new System.Drawing.Size(225, 35);
            this.btnToggleUnits.TabIndex = 12;
            this.btnToggleUnits.Text = "Switch to Metric Units";
            this.btnToggleUnits.UseVisualStyleBackColor = true;
            this.btnToggleUnits.Click += new System.EventHandler(this.btnToggleUnits_Click);
            // 
            // cmbFluidType
            // 
            this.cmbFluidType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFluidType.FormattingEnabled = true;
            this.cmbFluidType.Location = new System.Drawing.Point(172, 158);
            this.cmbFluidType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFluidType.Name = "cmbFluidType";
            this.cmbFluidType.Size = new System.Drawing.Size(298, 28);
            this.cmbFluidType.TabIndex = 1;
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(10, 254);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(110, 20);
            this.lblPressure.TabIndex = 5;
            this.lblPressure.Text = "Pressure (psi):";
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(172, 251);
            this.txtPressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(148, 26);
            this.txtPressure.TabIndex = 3;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(10, 211);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(133, 20);
            this.lblTemperature.TabIndex = 7;
            this.lblTemperature.Text = "Temperature (°F):";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(172, 205);
            this.txtTemperature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(148, 26);
            this.txtTemperature.TabIndex = 5;
            // 
            // lblFlangeType
            // 
            this.lblFlangeType.AutoSize = true;
            this.lblFlangeType.Location = new System.Drawing.Point(10, 302);
            this.lblFlangeType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlangeType.Name = "lblFlangeType";
            this.lblFlangeType.Size = new System.Drawing.Size(100, 20);
            this.lblFlangeType.TabIndex = 6;
            this.lblFlangeType.Text = "Flange Type:";
            // 
            // cmbFlangeType
            // 
            this.cmbFlangeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlangeType.FormattingEnabled = true;
            this.cmbFlangeType.Location = new System.Drawing.Point(172, 297);
            this.cmbFlangeType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFlangeType.Name = "cmbFlangeType";
            this.cmbFlangeType.Size = new System.Drawing.Size(298, 28);
            this.cmbFlangeType.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(388, 350);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 46);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(613, 350);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 46);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(838, 350);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 46);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPressureUnit
            // 
            this.lblPressureUnit.AutoSize = true;
            this.lblPressureUnit.Location = new System.Drawing.Point(338, 257);
            this.lblPressureUnit.Name = "lblPressureUnit";
            this.lblPressureUnit.Size = new System.Drawing.Size(29, 20);
            this.lblPressureUnit.TabIndex = 14;
            this.lblPressureUnit.Text = "psi";
            // 
            // lblTempUnit
            // 
            this.lblTempUnit.AutoSize = true;
            this.lblTempUnit.Location = new System.Drawing.Point(338, 208);
            this.lblTempUnit.Name = "lblTempUnit";
            this.lblTempUnit.Size = new System.Drawing.Size(24, 20);
            this.lblTempUnit.TabIndex = 15;
            this.lblTempUnit.Text = "°F";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Location = new System.Drawing.Point(10, 120);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(111, 20);
            this.lblMinTemp.TabIndex = 16;
            this.lblMinTemp.Text = "Min Temp (°F):";
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(172, 117);
            this.txtMinTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(148, 26);
            this.txtMinTemp.TabIndex = 17;
            // 
            // lblMinTempUnit
            // 
            this.lblMinTempUnit.AutoSize = true;
            this.lblMinTempUnit.Location = new System.Drawing.Point(328, 120);
            this.lblMinTempUnit.Name = "lblMinTempUnit";
            this.lblMinTempUnit.Size = new System.Drawing.Size(24, 20);
            this.lblMinTempUnit.TabIndex = 18;
            this.lblMinTempUnit.Text = "°F";
            // 
            // cmbServiceSeverity
            // 
            this.cmbServiceSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceSeverity.FormattingEnabled = true;
            this.cmbServiceSeverity.Location = new System.Drawing.Point(172, 76);
            this.cmbServiceSeverity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbServiceSeverity.Name = "cmbServiceSeverity";
            this.cmbServiceSeverity.Size = new System.Drawing.Size(298, 28);
            this.cmbServiceSeverity.TabIndex = 19;
            // 
            // lblServiceSeverity
            // 
            this.lblServiceSeverity.AutoSize = true;
            this.lblServiceSeverity.Location = new System.Drawing.Point(10, 84);
            this.lblServiceSeverity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceSeverity.Name = "lblServiceSeverity";
            this.lblServiceSeverity.Size = new System.Drawing.Size(125, 20);
            this.lblServiceSeverity.TabIndex = 20;
            this.lblServiceSeverity.Text = "Service Severity:";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.ColumnHeadersHeight = 34;
            this.dgvResults.Location = new System.Drawing.Point(24, 423);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowHeadersWidth = 62;
            this.dgvResults.Size = new System.Drawing.Size(1306, 452);
            this.dgvResults.TabIndex = 21;
            // 
            // btnShowAllGasket
            // 
            this.btnShowAllGasket.Location = new System.Drawing.Point(779, 37);
            this.btnShowAllGasket.Name = "btnShowAllGasket";
            this.btnShowAllGasket.Size = new System.Drawing.Size(361, 67);
            this.btnShowAllGasket.TabIndex = 22;
            this.btnShowAllGasket.Text = "Show All Gasket Data";
            this.btnShowAllGasket.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(779, 114);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(361, 26);
            this.txtSearch.TabIndex = 23;
            // 
            // frmGasketSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 906);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnShowAllGasket);
            this.Controls.Add(this.lblServiceSeverity);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.cmbServiceSeverity);
            this.Controls.Add(this.lblMinTempUnit);
            this.Controls.Add(this.txtMinTemp);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.lblTempUnit);
            this.Controls.Add(this.lblPressureUnit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbFlangeType);
            this.Controls.Add(this.lblFlangeType);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.cmbFluidType);
            this.Controls.Add(this.lblFluidType);
            this.Controls.Add(this.btnToggleUnits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGasketSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gasket Selection Tool";
            this.Load += new System.EventHandler(this.frmGasketSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFluidType;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnToggleUnits;
        private System.Windows.Forms.ComboBox cmbFluidType;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label lblFlangeType;
        private System.Windows.Forms.ComboBox cmbFlangeType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPressureUnit;
        private System.Windows.Forms.Label lblTempUnit;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.Label lblMinTempUnit;
        private System.Windows.Forms.ComboBox cmbServiceSeverity;
        private System.Windows.Forms.Label lblServiceSeverity;
        private Button btnShowAllGasket;
    }
}