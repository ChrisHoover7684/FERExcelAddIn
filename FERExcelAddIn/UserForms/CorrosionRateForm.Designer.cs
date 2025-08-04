namespace CorrosionRateCalculator
{
    partial class CorrosionRateForm
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.dtFinalDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtInitialDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExposureTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFinalThickness = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInitialThickness = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMode = new System.Windows.Forms.GroupBox();
            this.radioUseDates = new System.Windows.Forms.RadioButton();
            this.radioManualYears = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpInput.SuspendLayout();
            this.grpMode.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(547, 40);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "CORROSION RATE CALCULATOR";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.dtFinalDate);
            this.grpInput.Controls.Add(this.label5);
            this.grpInput.Controls.Add(this.dtInitialDate);
            this.grpInput.Controls.Add(this.label4);
            this.grpInput.Controls.Add(this.txtExposureTime);
            this.grpInput.Controls.Add(this.label3);
            this.grpInput.Controls.Add(this.txtFinalThickness);
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.txtInitialThickness);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInput.Location = new System.Drawing.Point(12, 150);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(523, 180);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Measurement Data";
            // 
            // dtFinalDate
            // 
            this.dtFinalDate.Enabled = false;
            this.dtFinalDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinalDate.Location = new System.Drawing.Point(264, 145);
            this.dtFinalDate.Name = "dtFinalDate";
            this.dtFinalDate.Size = new System.Drawing.Size(200, 31);
            this.dtFinalDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Final Measurement Date:";
            // 
            // dtInitialDate
            // 
            this.dtInitialDate.Enabled = false;
            this.dtInitialDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInitialDate.Location = new System.Drawing.Point(264, 115);
            this.dtInitialDate.Name = "dtInitialDate";
            this.dtInitialDate.Size = new System.Drawing.Size(200, 31);
            this.dtInitialDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Initial Measurement Date:";
            // 
            // txtExposureTime
            // 
            this.txtExposureTime.Location = new System.Drawing.Point(264, 87);
            this.txtExposureTime.Name = "txtExposureTime";
            this.txtExposureTime.Size = new System.Drawing.Size(100, 31);
            this.txtExposureTime.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Exposure Time (years):";
            // 
            // txtFinalThickness
            // 
            this.txtFinalThickness.Location = new System.Drawing.Point(264, 57);
            this.txtFinalThickness.Name = "txtFinalThickness";
            this.txtFinalThickness.Size = new System.Drawing.Size(100, 31);
            this.txtFinalThickness.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Thickness (inches):";
            // 
            // txtInitialThickness
            // 
            this.txtInitialThickness.Location = new System.Drawing.Point(264, 27);
            this.txtInitialThickness.Name = "txtInitialThickness";
            this.txtInitialThickness.Size = new System.Drawing.Size(100, 31);
            this.txtInitialThickness.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Thickness (inches):";
            // 
            // grpMode
            // 
            this.grpMode.Controls.Add(this.radioUseDates);
            this.grpMode.Controls.Add(this.radioManualYears);
            this.grpMode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMode.Location = new System.Drawing.Point(12, 50);
            this.grpMode.Name = "grpMode";
            this.grpMode.Size = new System.Drawing.Size(523, 90);
            this.grpMode.TabIndex = 2;
            this.grpMode.TabStop = false;
            this.grpMode.Text = "Exposure Time Calculation Mode";
            // 
            // radioUseDates
            // 
            this.radioUseDates.AutoSize = true;
            this.radioUseDates.Location = new System.Drawing.Point(20, 55);
            this.radioUseDates.Name = "radioUseDates";
            this.radioUseDates.Size = new System.Drawing.Size(312, 29);
            this.radioUseDates.TabIndex = 1;
            this.radioUseDates.Text = "Calculate from measurement dates";
            this.radioUseDates.UseVisualStyleBackColor = true;
            this.radioUseDates.CheckedChanged += new System.EventHandler(this.radioUseDates_CheckedChanged);
            // 
            // radioManualYears
            // 
            this.radioManualYears.AutoSize = true;
            this.radioManualYears.Checked = true;
            this.radioManualYears.Location = new System.Drawing.Point(20, 25);
            this.radioManualYears.Name = "radioManualYears";
            this.radioManualYears.Size = new System.Drawing.Size(199, 29);
            this.radioManualYears.TabIndex = 0;
            this.radioManualYears.TabStop = true;
            this.radioManualYears.Text = "Enter years manually";
            this.radioManualYears.UseVisualStyleBackColor = true;
            this.radioManualYears.CheckedChanged += new System.EventHandler(this.radioManualYears_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(12, 340);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(523, 40);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "CALCULATE CORROSION RATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblResult);
            this.grpResults.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResults.Location = new System.Drawing.Point(12, 390);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(523, 150);
            this.grpResults.TabIndex = 4;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResult.Location = new System.Drawing.Point(3, 27);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(5);
            this.lblResult.Size = new System.Drawing.Size(517, 120);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Results will appear here...";
            // 
            // CorrosionRateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 550);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpMode);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CorrosionRateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Corrosion Rate Calculator";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpMode.ResumeLayout(false);
            this.grpMode.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.DateTimePicker dtFinalDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtInitialDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtExposureTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFinalThickness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInitialThickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpMode;
        private System.Windows.Forms.RadioButton radioUseDates;
        private System.Windows.Forms.RadioButton radioManualYears;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grpResults;
        private System.Windows.Forms.Label lblResult;
    }
}