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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterials = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrevention = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInspection = new System.Windows.Forms.TextBox();
            this.lblRiskLevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstRelated = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboMaterialFilter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboUnitFilter = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMechanisms
            // 
            this.lstMechanisms.DisplayMember = "Name";
            this.lstMechanisms.FormattingEnabled = true;
            this.lstMechanisms.Location = new System.Drawing.Point(9, 146);
            this.lstMechanisms.Margin = new System.Windows.Forms.Padding(2);
            this.lstMechanisms.Name = "lstMechanisms";
            this.lstMechanisms.Size = new System.Drawing.Size(298, 316);
            this.lstMechanisms.TabIndex = 0;
            this.lstMechanisms.ValueMember = "Name";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(298, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search mechanisms...";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(346, -1);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(391, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Select a mechanism";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDescription.Location = new System.Drawing.Point(346, 33);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(391, 66);
            this.txtDescription.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Affected Materials:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description:";
            // 
            // txtMaterials
            // 
            this.txtMaterials.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtMaterials.Location = new System.Drawing.Point(346, 116);
            this.txtMaterials.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaterials.Multiline = true;
            this.txtMaterials.Name = "txtMaterials";
            this.txtMaterials.ReadOnly = true;
            this.txtMaterials.Size = new System.Drawing.Size(391, 41);
            this.txtMaterials.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Critical Factors:";
            // 
            // txtFactors
            // 
            this.txtFactors.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtFactors.Location = new System.Drawing.Point(346, 175);
            this.txtFactors.Margin = new System.Windows.Forms.Padding(2);
            this.txtFactors.Multiline = true;
            this.txtFactors.Name = "txtFactors";
            this.txtFactors.ReadOnly = true;
            this.txtFactors.Size = new System.Drawing.Size(391, 50);
            this.txtFactors.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Prevention/Mitigation:";
            // 
            // txtPrevention
            // 
            this.txtPrevention.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrevention.Location = new System.Drawing.Point(346, 241);
            this.txtPrevention.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrevention.Multiline = true;
            this.txtPrevention.Name = "txtPrevention";
            this.txtPrevention.ReadOnly = true;
            this.txtPrevention.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrevention.Size = new System.Drawing.Size(391, 66);
            this.txtPrevention.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Inspection Methods:";
            // 
            // txtInspection
            // 
            this.txtInspection.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtInspection.Location = new System.Drawing.Point(346, 324);
            this.txtInspection.Margin = new System.Windows.Forms.Padding(2);
            this.txtInspection.Multiline = true;
            this.txtInspection.Name = "txtInspection";
            this.txtInspection.ReadOnly = true;
            this.txtInspection.Size = new System.Drawing.Size(391, 41);
            this.txtInspection.TabIndex = 12;
            // 
            // lblRiskLevel
            // 
            this.lblRiskLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRiskLevel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRiskLevel.Location = new System.Drawing.Point(346, 367);
            this.lblRiskLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRiskLevel.Name = "lblRiskLevel";
            this.lblRiskLevel.Size = new System.Drawing.Size(150, 19);
            this.lblRiskLevel.TabIndex = 13;
            this.lblRiskLevel.Text = "Risk: ";
            this.lblRiskLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 388);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Related Mechanisms:";
            // 
            // lstRelated
            // 
            this.lstRelated.FormattingEnabled = true;
            this.lstRelated.Location = new System.Drawing.Point(346, 404);
            this.lstRelated.Margin = new System.Windows.Forms.Padding(2);
            this.lstRelated.Name = "lstRelated";
            this.lstRelated.Size = new System.Drawing.Size(188, 56);
            this.lstRelated.TabIndex = 15;
            this.lstRelated.DoubleClick += new System.EventHandler(this.lstRelated_DoubleClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(658, 430);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(78, 28);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboMaterialFilter
            // 
            this.cboMaterialFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterialFilter.FormattingEnabled = true;
            this.cboMaterialFilter.Location = new System.Drawing.Point(9, 49);
            this.cboMaterialFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaterialFilter.Name = "cboMaterialFilter";
            this.cboMaterialFilter.Size = new System.Drawing.Size(298, 21);
            this.cboMaterialFilter.TabIndex = 17;
            this.cboMaterialFilter.SelectedIndexChanged += new System.EventHandler(this.cboMaterialFilter_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Filter by Material:";
            // 
            // cboUnitFilter
            // 
            this.cboUnitFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnitFilter.FormattingEnabled = true;
            this.cboUnitFilter.Location = new System.Drawing.Point(9, 96);
            this.cboUnitFilter.Margin = new System.Windows.Forms.Padding(2);
            this.cboUnitFilter.Name = "cboUnitFilter";
            this.cboUnitFilter.Size = new System.Drawing.Size(298, 21);
            this.cboUnitFilter.TabIndex = 19;
            this.cboUnitFilter.SelectedIndexChanged += new System.EventHandler(this.cboUnitFilter_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Filter by Unit:";
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(9, 121);
            this.btnResetFilters.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(75, 19);
            this.btnResetFilters.TabIndex = 21;
            this.btnResetFilters.Text = "Reset Filters";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // API571Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 511);
            this.Controls.Add(this.btnResetFilters);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboUnitFilter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMaterialFilter);
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
            this.Controls.Add(this.txtMaterials);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstMechanisms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaterials;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFactors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrevention;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInspection;
        private System.Windows.Forms.Label lblRiskLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstRelated;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboMaterialFilter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboUnitFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnResetFilters;
    }
}