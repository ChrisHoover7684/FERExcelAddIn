namespace FERExcelAddIn
{
    partial class PipeWeightCalculatorForm
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
            this.lblOuterDiameter = new System.Windows.Forms.Label();
            this.txtOuterDiameter = new System.Windows.Forms.TextBox();
            this.lblWallThickness = new System.Windows.Forms.Label();
            this.txtWallThickness = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.rbtnImperial = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOuterDiameter
            // 
            this.lblOuterDiameter.AutoSize = true;
            this.lblOuterDiameter.Location = new System.Drawing.Point(12, 70);
            this.lblOuterDiameter.Name = "lblOuterDiameter";
            this.lblOuterDiameter.Size = new System.Drawing.Size(119, 13);
            this.lblOuterDiameter.TabIndex = 0;
            this.lblOuterDiameter.Text = "Outer Diameter (inches):";
            // 
            // txtOuterDiameter
            // 
            this.txtOuterDiameter.Location = new System.Drawing.Point(137, 67);
            this.txtOuterDiameter.Name = "txtOuterDiameter";
            this.txtOuterDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtOuterDiameter.TabIndex = 1;
            // 
            // lblWallThickness
            // 
            this.lblWallThickness.AutoSize = true;
            this.lblWallThickness.Location = new System.Drawing.Point(12, 96);
            this.lblWallThickness.Name = "lblWallThickness";
            this.lblWallThickness.Size = new System.Drawing.Size(119, 13);
            this.lblWallThickness.TabIndex = 2;
            this.lblWallThickness.Text = "Wall Thickness (inches):";
            // 
            // txtWallThickness
            // 
            this.txtWallThickness.Location = new System.Drawing.Point(137, 93);
            this.txtWallThickness.Name = "txtWallThickness";
            this.txtWallThickness.Size = new System.Drawing.Size(100, 20);
            this.txtWallThickness.TabIndex = 3;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(12, 122);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(76, 13);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length (feet):";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(137, 119);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 5;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(12, 148);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(47, 13);
            this.lblMaterial.TabIndex = 6;
            this.lblMaterial.Text = "Material:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(137, 145);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(200, 21);
            this.cmbMaterial.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(137, 172);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(218, 172);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(137, 201);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(200, 20);
            this.txtWeight.TabIndex = 10;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(12, 204);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 13);
            this.lblWeight.TabIndex = 11;
            this.lblWeight.Text = "Weight:";
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(6, 19);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(54, 17);
            this.rbtnMetric.TabIndex = 12;
            this.rbtnMetric.Text = "Metric";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            // 
            // rbtnImperial
            // 
            this.rbtnImperial.AutoSize = true;
            this.rbtnImperial.Checked = true;
            this.rbtnImperial.Location = new System.Drawing.Point(66, 19);
            this.rbtnImperial.Name = "rbtnImperial";
            this.rbtnImperial.Size = new System.Drawing.Size(61, 17);
            this.rbtnImperial.TabIndex = 13;
            this.rbtnImperial.TabStop = true;
            this.rbtnImperial.Text = "Imperial";
            this.rbtnImperial.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnMetric);
            this.groupBox1.Controls.Add(this.rbtnImperial);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 45);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unit System";
            // 
            // PipeWeightCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 236);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtWallThickness);
            this.Controls.Add(this.lblWallThickness);
            this.Controls.Add(this.txtOuterDiameter);
            this.Controls.Add(this.lblOuterDiameter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PipeWeightCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pipe Weight Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOuterDiameter;
        private System.Windows.Forms.TextBox txtOuterDiameter;
        private System.Windows.Forms.Label lblWallThickness;
        private System.Windows.Forms.TextBox txtWallThickness;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.RadioButton rbtnImperial;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}