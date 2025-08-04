namespace FERExcelAddIn
{
    partial class HTHACheckerForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label lblH2Pressure;
        private System.Windows.Forms.TextBox txtH2Pressure;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblDisclaimer;
        private System.Windows.Forms.RichTextBox rtbResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.lblH2Pressure = new System.Windows.Forms.Label();
            this.txtH2Pressure = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(20, 20);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(69, 20);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Material:";
            // 
            // cboMaterial
            // 
            this.cboMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterial.FormattingEnabled = true;
            this.cboMaterial.Location = new System.Drawing.Point(176, 17);
            this.cboMaterial.Name = "cboMaterial";
            this.cboMaterial.Size = new System.Drawing.Size(324, 28);
            this.cboMaterial.TabIndex = 1;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(20, 60);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(104, 20);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "Temperature:";
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(176, 54);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 26);
            this.txtTemperature.TabIndex = 3;
            // 
            // lblH2Pressure
            // 
            this.lblH2Pressure.AutoSize = true;
            this.lblH2Pressure.Location = new System.Drawing.Point(20, 100);
            this.lblH2Pressure.Name = "lblH2Pressure";
            this.lblH2Pressure.Size = new System.Drawing.Size(140, 20);
            this.lblH2Pressure.TabIndex = 4;
            this.lblH2Pressure.Text = "H₂ Pressure (psia):";
            // 
            // txtH2Pressure
            // 
            this.txtH2Pressure.Location = new System.Drawing.Point(176, 94);
            this.txtH2Pressure.Name = "txtH2Pressure";
            this.txtH2Pressure.Size = new System.Drawing.Size(100, 26);
            this.txtH2Pressure.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(20, 140);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(563, 78);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check HTHA Risk";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.BackColor = System.Drawing.Color.LightYellow;
            this.lblDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisclaimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic);
            this.lblDisclaimer.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDisclaimer.Location = new System.Drawing.Point(0, 629);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Padding = new System.Windows.Forms.Padding(5);
            this.lblDisclaimer.Size = new System.Drawing.Size(610, 139);
            this.lblDisclaimer.TabIndex = 8;
            this.lblDisclaimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbResult
            // 
            this.rtbResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbResult.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbResult.Location = new System.Drawing.Point(20, 224);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(563, 384);
            this.rtbResult.TabIndex = 7;
            this.rtbResult.Text = "";
            // 
            // HTHACheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 768);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtH2Pressure);
            this.Controls.Add(this.lblH2Pressure);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.cboMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblDisclaimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HTHACheckerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTHA Checker (API 941)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}