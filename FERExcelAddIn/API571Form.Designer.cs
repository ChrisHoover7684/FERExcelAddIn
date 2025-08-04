using System.Windows.Forms;

namespace FERExcelAddIn
{
    partial class API571Form
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
            this.lstMechanisms = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactors = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrevention = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInspection = new System.Windows.Forms.RichTextBox();
            this.lblRiskLevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstRelated = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaterials = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnits = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lstMechanisms
            // 
            this.lstMechanisms.DisplayMember = "Name";
            this.lstMechanisms.FormattingEnabled = true;
            this.lstMechanisms.ItemHeight = 20;
            this.lstMechanisms.Location = new System.Drawing.Point(14, 55);
            this.lstMechanisms.Name = "lstMechanisms";
            this.lstMechanisms.Size = new System.Drawing.Size(445, 724);
            this.lstMechanisms.TabIndex = 0;
            this.lstMechanisms.ValueMember = "Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(14, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(445, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search mechanisms...";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(519, -2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(586, 29);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Select a mechanism";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescription.Location = new System.Drawing.Point(519, 51);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(584, 99);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Critical Factors:";
            // 
            // txtFactors
            // 
            this.txtFactors.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFactors.Location = new System.Drawing.Point(519, 357);
            this.txtFactors.Name = "txtFactors";
            this.txtFactors.ReadOnly = true;
            this.txtFactors.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtFactors.Size = new System.Drawing.Size(584, 75);
            this.txtFactors.TabIndex = 8;
            this.txtFactors.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prevention/Mitigation:";
            // 
            // txtPrevention
            // 
            this.txtPrevention.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrevention.Location = new System.Drawing.Point(519, 460);
            this.txtPrevention.Name = "txtPrevention";
            this.txtPrevention.ReadOnly = true;
            this.txtPrevention.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtPrevention.Size = new System.Drawing.Size(584, 99);
            this.txtPrevention.TabIndex = 10;
            this.txtPrevention.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 565);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Inspection Methods:";
            // 
            // txtInspection
            // 
            this.txtInspection.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInspection.Location = new System.Drawing.Point(519, 588);
            this.txtInspection.Name = "txtInspection";
            this.txtInspection.ReadOnly = true;
            this.txtInspection.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtInspection.Size = new System.Drawing.Size(584, 61);
            this.txtInspection.TabIndex = 12;
            this.txtInspection.Text = "";
            // 
            // lblRiskLevel
            // 
            this.lblRiskLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRiskLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiskLevel.Location = new System.Drawing.Point(519, 654);
            this.lblRiskLevel.Name = "lblRiskLevel";
            this.lblRiskLevel.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblRiskLevel.Size = new System.Drawing.Size(584, 105);
            this.lblRiskLevel.TabIndex = 13;
            this.lblRiskLevel.Text = "Risk: ";
            this.lblRiskLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 763);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Related Mechanisms:";
            // 
            // lstRelated
            // 
            this.lstRelated.FormattingEnabled = true;
            this.lstRelated.ItemHeight = 20;
            this.lstRelated.Location = new System.Drawing.Point(510, 788);
            this.lstRelated.Name = "lstRelated";
            this.lstRelated.Size = new System.Drawing.Size(462, 84);
            this.lstRelated.TabIndex = 15;
            this.lstRelated.DoubleClick += new System.EventHandler(this.lstRelated_DoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(986, 788);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 84);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Affected Materials:";
            // 
            // txtMaterials
            // 
            this.txtMaterials.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaterials.Location = new System.Drawing.Point(519, 178);
            this.txtMaterials.Name = "txtMaterials";
            this.txtMaterials.ReadOnly = true;
            this.txtMaterials.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtMaterials.Size = new System.Drawing.Size(584, 61);
            this.txtMaterials.TabIndex = 6;
            this.txtMaterials.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Affected Units:";
            // 
            // txtUnits
            // 
            this.txtUnits.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtUnits.Location = new System.Drawing.Point(519, 268);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.ReadOnly = true;
            this.txtUnits.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtUnits.Size = new System.Drawing.Size(584, 61);
            this.txtUnits.TabIndex = 18;
            this.txtUnits.Text = "";
            // 
            // API571Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 878);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaterials);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstRelated);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRiskLevel);
            this.Controls.Add(this.txtInspection);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrevention);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFactors);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstMechanisms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "API571Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API 571 Quick Reference";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMechanisms;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtMaterials;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtUnits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtFactors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtPrevention;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtInspection;
        private System.Windows.Forms.Label lblRiskLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstRelated;
        private System.Windows.Forms.Button btnClose;
    }
}