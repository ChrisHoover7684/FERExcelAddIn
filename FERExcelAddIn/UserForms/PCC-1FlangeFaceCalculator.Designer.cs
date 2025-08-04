namespace FERExcelAddIn
{
    partial class FlangeCalculatorForm
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

        private void InitializeComponent()
        {
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtDistanceFromEdge = new System.Windows.Forms.TextBox();
            this.cmbGasketType = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpFlangeParameters = new System.Windows.Forms.GroupBox();
            this.cmbFlangeSize = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFlangeClass = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEvaluation = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.grpFlangeDimensions = new System.Windows.Forms.GroupBox();
            this.txtBore = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpGasketDimensions = new System.Windows.Forms.GroupBox();
            this.txtRadialWidth = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGasketOD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGasketID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grpIndicationInputs = new System.Windows.Forms.GroupBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.lblDimensions = new System.Windows.Forms.Label();
            this.grpFlangeParameters.SuspendLayout();
            this.grpFlangeDimensions.SuspendLayout();
            this.grpGasketDimensions.SuspendLayout();
            this.grpIndicationInputs.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(120, 24);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 2;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(120, 50);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(120, 76);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(100, 20);
            this.txtDepth.TabIndex = 4;
            // 
            // txtDistanceFromEdge
            // 
            this.txtDistanceFromEdge.Location = new System.Drawing.Point(120, 102);
            this.txtDistanceFromEdge.Name = "txtDistanceFromEdge";
            this.txtDistanceFromEdge.Size = new System.Drawing.Size(100, 20);
            this.txtDistanceFromEdge.TabIndex = 5;
            // 
            // cmbGasketType
            // 
            this.cmbGasketType.FormattingEnabled = true;
            this.cmbGasketType.Items.AddRange(new object[] {
            "hard",
            "soft"});
            this.cmbGasketType.Location = new System.Drawing.Point(120, 128);
            this.cmbGasketType.Name = "cmbGasketType";
            this.cmbGasketType.Size = new System.Drawing.Size(100, 21);
            this.cmbGasketType.TabIndex = 6;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(6, 16);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(133, 15);
            this.lblGrade.TabIndex = 7;
            this.lblGrade.Text = "Flange Face Grade:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 214);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(226, 72);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Evaluate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Radial Length (in):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Defect Width (in):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Depth (in):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Distance from edge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gasket type:";
            // 
            // grpFlangeParameters
            // 
            this.grpFlangeParameters.Controls.Add(this.cmbFlangeSize);
            this.grpFlangeParameters.Controls.Add(this.label6);
            this.grpFlangeParameters.Controls.Add(this.cmbFlangeClass);
            this.grpFlangeParameters.Controls.Add(this.label7);
            this.grpFlangeParameters.Location = new System.Drawing.Point(12, 12);
            this.grpFlangeParameters.Name = "grpFlangeParameters";
            this.grpFlangeParameters.Size = new System.Drawing.Size(230, 80);
            this.grpFlangeParameters.TabIndex = 13;
            this.grpFlangeParameters.TabStop = false;
            this.grpFlangeParameters.Text = "Flange Parameters";
            // 
            // cmbFlangeSize
            // 
            this.cmbFlangeSize.FormattingEnabled = true;
            this.cmbFlangeSize.Location = new System.Drawing.Point(120, 20);
            this.cmbFlangeSize.Name = "cmbFlangeSize";
            this.cmbFlangeSize.Size = new System.Drawing.Size(100, 21);
            this.cmbFlangeSize.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Flange Size (NPS):";
            // 
            // cmbFlangeClass
            // 
            this.cmbFlangeClass.FormattingEnabled = true;
            this.cmbFlangeClass.Location = new System.Drawing.Point(120, 46);
            this.cmbFlangeClass.Name = "cmbFlangeClass";
            this.cmbFlangeClass.Size = new System.Drawing.Size(100, 21);
            this.cmbFlangeClass.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Flange Class:";
            // 
            // lblEvaluation
            // 
            this.lblEvaluation.AutoSize = true;
            this.lblEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvaluation.Location = new System.Drawing.Point(6, 36);
            this.lblEvaluation.Name = "lblEvaluation";
            this.lblEvaluation.Size = new System.Drawing.Size(0, 13);
            this.lblEvaluation.TabIndex = 14;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(6, 56);
            this.lblNotes.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(0, 13);
            this.lblNotes.TabIndex = 15;
            // 
            // grpFlangeDimensions
            // 
            this.grpFlangeDimensions.Controls.Add(this.txtBore);
            this.grpFlangeDimensions.Controls.Add(this.label10);
            this.grpFlangeDimensions.Controls.Add(this.txtOD);
            this.grpFlangeDimensions.Controls.Add(this.label9);
            this.grpFlangeDimensions.Controls.Add(this.txtThickness);
            this.grpFlangeDimensions.Controls.Add(this.label8);
            this.grpFlangeDimensions.Location = new System.Drawing.Point(12, 98);
            this.grpFlangeDimensions.Name = "grpFlangeDimensions";
            this.grpFlangeDimensions.Size = new System.Drawing.Size(230, 110);
            this.grpFlangeDimensions.TabIndex = 16;
            this.grpFlangeDimensions.TabStop = false;
            this.grpFlangeDimensions.Text = "Flange Dimensions (inches)";
            // 
            // txtBore
            // 
            this.txtBore.Location = new System.Drawing.Point(120, 80);
            this.txtBore.Name = "txtBore";
            this.txtBore.ReadOnly = true;
            this.txtBore.Size = new System.Drawing.Size(100, 20);
            this.txtBore.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Bore ID:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(120, 50);
            this.txtOD.Name = "txtOD";
            this.txtOD.ReadOnly = true;
            this.txtOD.Size = new System.Drawing.Size(100, 20);
            this.txtOD.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Flange OD:";
            // 
            // txtThickness
            // 
            this.txtThickness.Location = new System.Drawing.Point(120, 20);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.ReadOnly = true;
            this.txtThickness.Size = new System.Drawing.Size(100, 20);
            this.txtThickness.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thickness:";
            // 
            // grpGasketDimensions
            // 
            this.grpGasketDimensions.Controls.Add(this.txtRadialWidth);
            this.grpGasketDimensions.Controls.Add(this.label13);
            this.grpGasketDimensions.Controls.Add(this.txtGasketOD);
            this.grpGasketDimensions.Controls.Add(this.label12);
            this.grpGasketDimensions.Controls.Add(this.txtGasketID);
            this.grpGasketDimensions.Controls.Add(this.label11);
            this.grpGasketDimensions.Location = new System.Drawing.Point(248, 12);
            this.grpGasketDimensions.Name = "grpGasketDimensions";
            this.grpGasketDimensions.Size = new System.Drawing.Size(230, 110);
            this.grpGasketDimensions.TabIndex = 17;
            this.grpGasketDimensions.TabStop = false;
            this.grpGasketDimensions.Text = "Gasket Dimensions (inches)";
            // 
            // txtRadialWidth
            // 
            this.txtRadialWidth.Location = new System.Drawing.Point(120, 80);
            this.txtRadialWidth.Name = "txtRadialWidth";
            this.txtRadialWidth.ReadOnly = true;
            this.txtRadialWidth.Size = new System.Drawing.Size(100, 20);
            this.txtRadialWidth.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Radial Width (w):";
            // 
            // txtGasketOD
            // 
            this.txtGasketOD.Location = new System.Drawing.Point(120, 50);
            this.txtGasketOD.Name = "txtGasketOD";
            this.txtGasketOD.ReadOnly = true;
            this.txtGasketOD.Size = new System.Drawing.Size(100, 20);
            this.txtGasketOD.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Gasket OD:";
            // 
            // txtGasketID
            // 
            this.txtGasketID.Location = new System.Drawing.Point(120, 20);
            this.txtGasketID.Name = "txtGasketID";
            this.txtGasketID.ReadOnly = true;
            this.txtGasketID.Size = new System.Drawing.Size(100, 20);
            this.txtGasketID.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Gasket ID:";
            // 
            // grpIndicationInputs
            // 
            this.grpIndicationInputs.Controls.Add(this.label1);
            this.grpIndicationInputs.Controls.Add(this.txtLength);
            this.grpIndicationInputs.Controls.Add(this.label2);
            this.grpIndicationInputs.Controls.Add(this.txtWidth);
            this.grpIndicationInputs.Controls.Add(this.label3);
            this.grpIndicationInputs.Controls.Add(this.txtDepth);
            this.grpIndicationInputs.Controls.Add(this.label4);
            this.grpIndicationInputs.Controls.Add(this.txtDistanceFromEdge);
            this.grpIndicationInputs.Controls.Add(this.label5);
            this.grpIndicationInputs.Controls.Add(this.cmbGasketType);
            this.grpIndicationInputs.Location = new System.Drawing.Point(248, 128);
            this.grpIndicationInputs.Name = "grpIndicationInputs";
            this.grpIndicationInputs.Size = new System.Drawing.Size(230, 168);
            this.grpIndicationInputs.TabIndex = 18;
            this.grpIndicationInputs.TabStop = false;
            this.grpIndicationInputs.Text = "Indication Inputs (inches)";
            // 
            // grpResults
            // 
            this.grpResults.Controls.Add(this.lblGrade);
            this.grpResults.Controls.Add(this.lblEvaluation);
            this.grpResults.Controls.Add(this.lblNotes);
            this.grpResults.Location = new System.Drawing.Point(15, 302);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(463, 170);
            this.grpResults.TabIndex = 19;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // lblDimensions
            // 
            this.lblDimensions.AutoSize = true;
            this.lblDimensions.Location = new System.Drawing.Point(12, 380);
            this.lblDimensions.Name = "lblDimensions";
            this.lblDimensions.Size = new System.Drawing.Size(0, 13);
            this.lblDimensions.TabIndex = 20;
            // 
            // FlangeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 513);
            this.Controls.Add(this.lblDimensions);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpIndicationInputs);
            this.Controls.Add(this.grpGasketDimensions);
            this.Controls.Add(this.grpFlangeDimensions);
            this.Controls.Add(this.grpFlangeParameters);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlangeCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PCC-1 Flange Face Calculator";
            this.grpFlangeParameters.ResumeLayout(false);
            this.grpFlangeParameters.PerformLayout();
            this.grpFlangeDimensions.ResumeLayout(false);
            this.grpFlangeDimensions.PerformLayout();
            this.grpGasketDimensions.ResumeLayout(false);
            this.grpGasketDimensions.PerformLayout();
            this.grpIndicationInputs.ResumeLayout(false);
            this.grpIndicationInputs.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtDistanceFromEdge;
        private System.Windows.Forms.ComboBox cmbGasketType;
        private System.Windows.Forms.ComboBox cmbFlangeSize;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDimensions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpFlangeParameters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFlangeClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEvaluation;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.GroupBox grpFlangeDimensions;
        private System.Windows.Forms.TextBox txtBore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtThickness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpGasketDimensions;
        private System.Windows.Forms.TextBox txtRadialWidth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGasketOD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGasketID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox grpIndicationInputs;
        private System.Windows.Forms.GroupBox grpResults;
    }
}