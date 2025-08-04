namespace FERExcelAddIn
{
    partial class ThermalExpansionForm
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
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblDeltaT = new System.Windows.Forms.Label();
            this.txtDeltaT = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.grpTempUnit = new System.Windows.Forms.GroupBox();
            this.optCelsius = new System.Windows.Forms.RadioButton();
            this.optFahrenheit = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.grpTempUnit.SuspendLayout();
            this.SuspendLayout();

            // lblMaterial
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(20, 20);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Material:";

            // cmbMaterial
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(100, 17);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(180, 21);
            this.cmbMaterial.TabIndex = 1;

            // lblDeltaT
            this.lblDeltaT.AutoSize = true;
            this.lblDeltaT.Location = new System.Drawing.Point(20, 50);
            this.lblDeltaT.Name = "lblDeltaT";
            this.lblDeltaT.Size = new System.Drawing.Size(68, 13);
            this.lblDeltaT.TabIndex = 2;
            this.lblDeltaT.Text = "ΔT (Change):";

            // txtDeltaT
            this.txtDeltaT.Location = new System.Drawing.Point(100, 47);
            this.txtDeltaT.Name = "txtDeltaT";
            this.txtDeltaT.Size = new System.Drawing.Size(100, 20);
            this.txtDeltaT.TabIndex = 3;
            this.txtDeltaT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // lblLength
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(20, 80);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(70, 13);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length (in):";

            // txtLength
            this.txtLength.Location = new System.Drawing.Point(100, 77);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 5;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // grpTempUnit
            this.grpTempUnit.Controls.Add(this.optCelsius);
            this.grpTempUnit.Controls.Add(this.optFahrenheit);
            this.grpTempUnit.Location = new System.Drawing.Point(220, 45);
            this.grpTempUnit.Name = "grpTempUnit";
            this.grpTempUnit.Size = new System.Drawing.Size(120, 70);
            this.grpTempUnit.TabIndex = 6;
            this.grpTempUnit.TabStop = false;
            this.grpTempUnit.Text = "Temperature Unit";

            // optCelsius
            this.optCelsius.AutoSize = true;
            this.optCelsius.Location = new System.Drawing.Point(10, 40);
            this.optCelsius.Name = "optCelsius";
            this.optCelsius.Size = new System.Drawing.Size(58, 17);
            this.optCelsius.TabIndex = 1;
            this.optCelsius.Text = "°C";
            this.optCelsius.UseVisualStyleBackColor = true;

            // optFahrenheit
            this.optFahrenheit.AutoSize = true;
            this.optFahrenheit.Checked = true;
            this.optFahrenheit.Location = new System.Drawing.Point(10, 20);
            this.optFahrenheit.Name = "optFahrenheit";
            this.optFahrenheit.Size = new System.Drawing.Size(58, 17);
            this.optFahrenheit.TabIndex = 0;
            this.optFahrenheit.TabStop = true;
            this.optFahrenheit.Text = "°F";
            this.optFahrenheit.UseVisualStyleBackColor = true;

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(20, 120);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 30);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(160, 120);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 30);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;

            // txtResult
            this.txtResult.Location = new System.Drawing.Point(20, 160);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(320, 80);
            this.txtResult.TabIndex = 9;

            // ThermalExpansionForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpTempUnit);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtDeltaT);
            this.Controls.Add(this.lblDeltaT);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.lblMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThermalExpansionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thermal Expansion Calculator";
            this.grpTempUnit.ResumeLayout(false);
            this.grpTempUnit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblDeltaT;
        private System.Windows.Forms.TextBox txtDeltaT;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.GroupBox grpTempUnit;
        private System.Windows.Forms.RadioButton optCelsius;
        private System.Windows.Forms.RadioButton optFahrenheit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtResult;
    }
}