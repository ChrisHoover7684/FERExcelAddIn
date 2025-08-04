using System.Windows.Forms;

namespace FERExcelAddIn
{
    partial class FlangeBoltLoadCalculatorForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.txtTargetStress = new System.Windows.Forms.TextBox();
            this.lblTargetStress = new System.Windows.Forms.Label();
            this.cmbBoltSize = new System.Windows.Forms.ComboBox();
            this.lblBoltSize = new System.Windows.Forms.Label();
            this.cmbLubrication = new System.Windows.Forms.ComboBox();
            this.lblLubrication = new System.Windows.Forms.Label();
            this.cmbBoltGrade = new System.Windows.Forms.ComboBox();
            this.lblBoltGrade = new System.Windows.Forms.Label();
            this.cmbFlangeClass = new System.Windows.Forms.ComboBox();
            this.lblFlangeClass = new System.Windows.Forms.Label();
            this.cmbFlangeSize = new System.Windows.Forms.ComboBox();
            this.lblFlangeSize = new System.Windows.Forms.Label();
            this.grpOutputs = new System.Windows.Forms.GroupBox();
            this.txtStressPercent = new System.Windows.Forms.TextBox();
            this.lblStressPercent = new System.Windows.Forms.Label();
            this.txtTorque = new System.Windows.Forms.TextBox();
            this.lblTorque = new System.Windows.Forms.Label();
            this.txtBoltLoad = new System.Windows.Forms.TextBox();
            this.lblBoltLoad = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.grpInputs.SuspendLayout();
            this.grpOutputs.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PCC-1 Bolt Load Calculator";
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.txtTargetStress);
            this.grpInputs.Controls.Add(this.lblTargetStress);
            this.grpInputs.Controls.Add(this.cmbBoltSize);
            this.grpInputs.Controls.Add(this.lblBoltSize);
            this.grpInputs.Controls.Add(this.cmbLubrication);
            this.grpInputs.Controls.Add(this.lblLubrication);
            this.grpInputs.Controls.Add(this.cmbBoltGrade);
            this.grpInputs.Controls.Add(this.lblBoltGrade);
            this.grpInputs.Controls.Add(this.cmbFlangeClass);
            this.grpInputs.Controls.Add(this.lblFlangeClass);
            this.grpInputs.Controls.Add(this.cmbFlangeSize);
            this.grpInputs.Controls.Add(this.lblFlangeSize);
            this.grpInputs.Location = new System.Drawing.Point(15, 40);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(320, 250);
            this.grpInputs.TabIndex = 1;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Input Parameters";
            // 
            // txtTargetStress
            // 
            this.txtTargetStress.Location = new System.Drawing.Point(121, 190);
            this.txtTargetStress.Name = "txtTargetStress";
            this.txtTargetStress.Size = new System.Drawing.Size(150, 20);
            this.txtTargetStress.TabIndex = 5;
            this.txtTargetStress.Text = "50";
            // 
            // lblTargetStress
            // 
            this.lblTargetStress.AutoSize = true;
            this.lblTargetStress.Location = new System.Drawing.Point(21, 193);
            this.lblTargetStress.Name = "lblTargetStress";
            this.lblTargetStress.Size = new System.Drawing.Size(90, 13);
            this.lblTargetStress.TabIndex = 4;
            this.lblTargetStress.Text = "Target Stress (%):";
            // 
            // cmbBoltSize
            // 
            this.cmbBoltSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoltSize.FormattingEnabled = true;
            this.cmbBoltSize.Location = new System.Drawing.Point(121, 150);
            this.cmbBoltSize.Name = "cmbBoltSize";
            this.cmbBoltSize.Size = new System.Drawing.Size(150, 21);
            this.cmbBoltSize.TabIndex = 3;
            // 
            // lblBoltSize
            // 
            this.lblBoltSize.AutoSize = true;
            this.lblBoltSize.Location = new System.Drawing.Point(21, 153);
            this.lblBoltSize.Name = "lblBoltSize";
            this.lblBoltSize.Size = new System.Drawing.Size(51, 13);
            this.lblBoltSize.TabIndex = 2;
            this.lblBoltSize.Text = "Bolt Size:";
            // 
            // cmbLubrication
            // 
            this.cmbLubrication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLubrication.FormattingEnabled = true;
            this.cmbLubrication.Location = new System.Drawing.Point(121, 120);
            this.cmbLubrication.Name = "cmbLubrication";
            this.cmbLubrication.Size = new System.Drawing.Size(150, 21);
            this.cmbLubrication.TabIndex = 3;
            // 
            // lblLubrication
            // 
            this.lblLubrication.AutoSize = true;
            this.lblLubrication.Location = new System.Drawing.Point(21, 123);
            this.lblLubrication.Name = "lblLubrication";
            this.lblLubrication.Size = new System.Drawing.Size(62, 13);
            this.lblLubrication.TabIndex = 2;
            this.lblLubrication.Text = "Lubrication:";
            // 
            // cmbBoltGrade
            // 
            this.cmbBoltGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoltGrade.FormattingEnabled = true;
            this.cmbBoltGrade.Location = new System.Drawing.Point(121, 90);
            this.cmbBoltGrade.Name = "cmbBoltGrade";
            this.cmbBoltGrade.Size = new System.Drawing.Size(150, 21);
            this.cmbBoltGrade.TabIndex = 3;
            // 
            // lblBoltGrade
            // 
            this.lblBoltGrade.AutoSize = true;
            this.lblBoltGrade.Location = new System.Drawing.Point(21, 93);
            this.lblBoltGrade.Name = "lblBoltGrade";
            this.lblBoltGrade.Size = new System.Drawing.Size(60, 13);
            this.lblBoltGrade.TabIndex = 2;
            this.lblBoltGrade.Text = "Bolt Grade:";
            // 
            // cmbFlangeClass
            // 
            this.cmbFlangeClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlangeClass.FormattingEnabled = true;
            this.cmbFlangeClass.Location = new System.Drawing.Point(121, 60);
            this.cmbFlangeClass.Name = "cmbFlangeClass";
            this.cmbFlangeClass.Size = new System.Drawing.Size(150, 21);
            this.cmbFlangeClass.TabIndex = 1;
            // 
            // lblFlangeClass
            // 
            this.lblFlangeClass.AutoSize = true;
            this.lblFlangeClass.Location = new System.Drawing.Point(21, 63);
            this.lblFlangeClass.Name = "lblFlangeClass";
            this.lblFlangeClass.Size = new System.Drawing.Size(70, 13);
            this.lblFlangeClass.TabIndex = 0;
            this.lblFlangeClass.Text = "Flange Class:";
            // 
            // cmbFlangeSize
            // 
            this.cmbFlangeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlangeSize.FormattingEnabled = true;
            this.cmbFlangeSize.Location = new System.Drawing.Point(121, 30);
            this.cmbFlangeSize.Name = "cmbFlangeSize";
            this.cmbFlangeSize.Size = new System.Drawing.Size(150, 21);
            this.cmbFlangeSize.TabIndex = 1;
            // 
            // lblFlangeSize
            // 
            this.lblFlangeSize.AutoSize = true;
            this.lblFlangeSize.Location = new System.Drawing.Point(21, 33);
            this.lblFlangeSize.Name = "lblFlangeSize";
            this.lblFlangeSize.Size = new System.Drawing.Size(65, 13);
            this.lblFlangeSize.TabIndex = 0;
            this.lblFlangeSize.Text = "Flange Size:";
            // 
            // grpOutputs
            // 
            this.grpOutputs.Controls.Add(this.txtStressPercent);
            this.grpOutputs.Controls.Add(this.lblStressPercent);
            this.grpOutputs.Controls.Add(this.txtTorque);
            this.grpOutputs.Controls.Add(this.lblTorque);
            this.grpOutputs.Controls.Add(this.txtBoltLoad);
            this.grpOutputs.Controls.Add(this.lblBoltLoad);
            this.grpOutputs.Location = new System.Drawing.Point(350, 40);
            this.grpOutputs.Name = "grpOutputs";
            this.grpOutputs.Size = new System.Drawing.Size(300, 180);
            this.grpOutputs.TabIndex = 2;
            this.grpOutputs.TabStop = false;
            this.grpOutputs.Text = "Results";
            // 
            // txtStressPercent
            // 
            this.txtStressPercent.BackColor = System.Drawing.SystemColors.Info;
            this.txtStressPercent.Location = new System.Drawing.Point(120, 90);
            this.txtStressPercent.Name = "txtStressPercent";
            this.txtStressPercent.ReadOnly = true;
            this.txtStressPercent.Size = new System.Drawing.Size(150, 20);
            this.txtStressPercent.TabIndex = 5;
            this.txtStressPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblStressPercent
            // 
            this.lblStressPercent.AutoSize = true;
            this.lblStressPercent.Location = new System.Drawing.Point(20, 93);
            this.lblStressPercent.Name = "lblStressPercent";
            this.lblStressPercent.Size = new System.Drawing.Size(82, 13);
            this.lblStressPercent.TabIndex = 4;
            this.lblStressPercent.Text = "Stress (% Yield):";
            // 
            // txtTorque
            // 
            this.txtTorque.BackColor = System.Drawing.SystemColors.Info;
            this.txtTorque.Location = new System.Drawing.Point(120, 60);
            this.txtTorque.Name = "txtTorque";
            this.txtTorque.ReadOnly = true;
            this.txtTorque.Size = new System.Drawing.Size(150, 20);
            this.txtTorque.TabIndex = 3;
            this.txtTorque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTorque
            // 
            this.lblTorque.AutoSize = true;
            this.lblTorque.Location = new System.Drawing.Point(20, 63);
            this.lblTorque.Name = "lblTorque";
            this.lblTorque.Size = new System.Drawing.Size(44, 13);
            this.lblTorque.TabIndex = 2;
            this.lblTorque.Text = "Torque:";
            // 
            // txtBoltLoad
            // 
            this.txtBoltLoad.BackColor = System.Drawing.SystemColors.Info;
            this.txtBoltLoad.Location = new System.Drawing.Point(120, 30);
            this.txtBoltLoad.Name = "txtBoltLoad";
            this.txtBoltLoad.ReadOnly = true;
            this.txtBoltLoad.Size = new System.Drawing.Size(150, 20);
            this.txtBoltLoad.TabIndex = 1;
            this.txtBoltLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBoltLoad
            // 
            this.lblBoltLoad.AutoSize = true;
            this.lblBoltLoad.Location = new System.Drawing.Point(20, 33);
            this.lblBoltLoad.Name = "lblBoltLoad";
            this.lblBoltLoad.Size = new System.Drawing.Size(55, 13);
            this.lblBoltLoad.TabIndex = 0;
            this.lblBoltLoad.Text = "Bolt Load:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(350, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 32);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(510, 230);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(12, 300);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(329, 13);
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Note: Calculations follow PCC-1 Appendix A (Bolt Torque Guidelines)";
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer = new System.Windows.Forms.Label();
            this.lblDisclaimer.AutoSize = true;
            this.lblDisclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisclaimer.Location = new System.Drawing.Point(12, 315);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(437, 13);
            this.lblDisclaimer.TabIndex = 6;
            this.lblDisclaimer.Text = "Disclaimer: This calculator is for estimation purposes only. Consult a qualified engineer for critical applications.";
            // 
            // FlangeBoltLoadCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(680, 330);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpOutputs);
            this.Controls.Add(this.grpInputs);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlangeBoltLoadCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PCC-1 Bolt Load Calculator";
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.grpOutputs.ResumeLayout(false);
            this.grpOutputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.TextBox txtTargetStress;
        private System.Windows.Forms.Label lblTargetStress;
        private System.Windows.Forms.ComboBox cmbBoltSize;
        private System.Windows.Forms.Label lblBoltSize;
        private System.Windows.Forms.ComboBox cmbLubrication;
        private System.Windows.Forms.Label lblLubrication;
        private System.Windows.Forms.ComboBox cmbBoltGrade;
        private System.Windows.Forms.Label lblBoltGrade;
        private System.Windows.Forms.ComboBox cmbFlangeClass;
        private System.Windows.Forms.Label lblFlangeClass;
        private System.Windows.Forms.ComboBox cmbFlangeSize;
        private System.Windows.Forms.Label lblFlangeSize;
        private System.Windows.Forms.GroupBox grpOutputs;
        private System.Windows.Forms.TextBox txtStressPercent;
        private System.Windows.Forms.Label lblStressPercent;
        private System.Windows.Forms.TextBox txtTorque;
        private System.Windows.Forms.Label lblTorque;
        private System.Windows.Forms.TextBox txtBoltLoad;
        private System.Windows.Forms.Label lblBoltLoad;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblDisclaimer;
    }
}
