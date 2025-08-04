using System.Windows.Forms;

namespace FERExcelAddIn
{
    partial class B31_3PipeCalculator
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbMaterialGroup = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSpec = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colNPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarlowThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSearch = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.labelWeldJointFactor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxDimensions = new System.Windows.Forms.GroupBox();
            this.txtOuterDiameter = new System.Windows.Forms.TextBox();
            this.cmbNPS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOD = new System.Windows.Forms.Label();
            this.toolTipWeldJointFactor = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxConditions = new System.Windows.Forms.GroupBox();
            this.txtBarlowThicknessResult = new System.Windows.Forms.TextBox();
            this.lblBarlowThickness = new System.Windows.Forms.Label();
            this.txtMinThicknessResult = new System.Windows.Forms.TextBox();
            this.labelMinThickness = new System.Windows.Forms.Label();
            this.txtStressValue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxMaterialData = new System.Windows.Forms.GroupBox();
            this.txtTensile = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPNo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtYield = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBoxFactors = new System.Windows.Forms.GroupBox();
            this.btnShowTable304 = new System.Windows.Forms.Button();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.txtWeldJointFactor = new System.Windows.Forms.TextBox();
            this.cmbQualityFactor = new System.Windows.Forms.ComboBox();
            this.txtYCoefficient = new System.Windows.Forms.TextBox();
            this.txtClassConditionTemper = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtProductForm = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUNSNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNominalComposition = new System.Windows.Forms.TextBox();
            this.lblNominalComposition = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.groupMaterialNotes = new System.Windows.Forms.GroupBox();
            this.rtbNotesActual = new System.Windows.Forms.RichTextBox();
            this.dgvMaterials = new System.Windows.Forms.DataGridView();
            this.colLineNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNominalComposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductForm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSpecNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUNSNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClassConditionTemper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterialGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.groupBoxResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.groupBoxDimensions.SuspendLayout();
            this.groupBoxConditions.SuspendLayout();
            this.groupBoxMaterialData.SuspendLayout();
            this.groupBoxFactors.SuspendLayout();
            this.groupMaterialNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).BeginInit();
            this.panelInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMaterialGroup
            // 
            this.cmbMaterialGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterialGroup.FormattingEnabled = true;
            this.cmbMaterialGroup.Location = new System.Drawing.Point(122, 17);
            this.cmbMaterialGroup.Name = "cmbMaterialGroup";
            this.cmbMaterialGroup.Size = new System.Drawing.Size(595, 31);
            this.cmbMaterialGroup.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 20);
            this.label12.MinimumSize = new System.Drawing.Size(90, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "Group:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(120, 55);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(412, 31);
            this.cmbMaterial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.MinimumSize = new System.Drawing.Size(90, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Material:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSpec
            // 
            this.cmbSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpec.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpec.FormattingEnabled = true;
            this.cmbSpec.Location = new System.Drawing.Point(120, 85);
            this.cmbSpec.Name = "cmbSpec";
            this.cmbSpec.Size = new System.Drawing.Size(412, 31);
            this.cmbSpec.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.MinimumSize = new System.Drawing.Size(90, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Spec:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbGrade
            // 
            this.cmbGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrade.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrade.FormattingEnabled = true;
            this.cmbGrade.Location = new System.Drawing.Point(120, 115);
            this.cmbGrade.Name = "cmbGrade";
            this.cmbGrade.Size = new System.Drawing.Size(412, 31);
            this.cmbGrade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 118);
            this.label3.MinimumSize = new System.Drawing.Size(90, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grade:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.dgvResults);
            this.groupBoxResults.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResults.Location = new System.Drawing.Point(930, 350);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(537, 588);
            this.groupBoxResults.TabIndex = 2;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "t-mins";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNPS,
            this.colOD,
            this.colThickness,
            this.colBarlowThickness});
            this.dgvResults.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResults.Location = new System.Drawing.Point(20, 30);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowHeadersWidth = 62;
            this.dgvResults.RowTemplate.Height = 28;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(497, 552);
            this.dgvResults.TabIndex = 6;
            // 
            // colNPS
            // 
            this.colNPS.HeaderText = "NPS";
            this.colNPS.MinimumWidth = 4;
            this.colNPS.Name = "colNPS";
            // 
            // colOD
            // 
            this.colOD.HeaderText = "OD";
            this.colOD.MinimumWidth = 4;
            this.colOD.Name = "colOD";
            // 
            // colThickness
            // 
            this.colThickness.HeaderText = "B31.3 t-min (in)";
            this.colThickness.MinimumWidth = 8;
            this.colThickness.Name = "colThickness";
            // 
            // colBarlowThickness
            // 
            this.colBarlowThickness.HeaderText = "Barlow t-min (in)";
            this.colBarlowThickness.MinimumWidth = 8;
            this.colBarlowThickness.Name = "colBarlowThickness";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(15, 28);
            this.labelSearch.MinimumSize = new System.Drawing.Size(90, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(90, 15);
            this.labelSearch.TabIndex = 13;
            this.labelSearch.Text = "Search:";
            this.labelSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 88);
            this.label9.MinimumSize = new System.Drawing.Size(129, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "(Y) Coefficient:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label9, "ASME B31.3 Table 304.1.1");
            // 
            // labelWeldJointFactor
            // 
            this.labelWeldJointFactor.AutoSize = true;
            this.labelWeldJointFactor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeldJointFactor.Location = new System.Drawing.Point(15, 58);
            this.labelWeldJointFactor.MinimumSize = new System.Drawing.Size(146, 0);
            this.labelWeldJointFactor.Name = "labelWeldJointFactor";
            this.labelWeldJointFactor.Size = new System.Drawing.Size(163, 23);
            this.labelWeldJointFactor.TabIndex = 16;
            this.labelWeldJointFactor.Text = "(W) Weld Factor:";
            this.labelWeldJointFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelWeldJointFactor, "ASME B31.3 Table 302.3.5-1");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 28);
            this.label7.MinimumSize = new System.Drawing.Size(156, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "(E) Quality Factor:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label7, "ASME B31.3 Table A-3 (Formerly Table A-1B)");
            // 
            // groupBoxDimensions
            // 
            this.groupBoxDimensions.Controls.Add(this.txtOuterDiameter);
            this.groupBoxDimensions.Controls.Add(this.cmbNPS);
            this.groupBoxDimensions.Controls.Add(this.label4);
            this.groupBoxDimensions.Controls.Add(this.lblOD);
            this.groupBoxDimensions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDimensions.Location = new System.Drawing.Point(19, 362);
            this.groupBoxDimensions.Margin = new System.Windows.Forms.Padding(10, 0, 10, 15);
            this.groupBoxDimensions.Name = "groupBoxDimensions";
            this.groupBoxDimensions.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxDimensions.Size = new System.Drawing.Size(545, 60);
            this.groupBoxDimensions.TabIndex = 1;
            this.groupBoxDimensions.TabStop = false;
            this.groupBoxDimensions.Text = "Pipe Dimensions";
            // 
            // txtOuterDiameter
            // 
            this.txtOuterDiameter.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOuterDiameter.Location = new System.Drawing.Point(405, 28);
            this.txtOuterDiameter.Name = "txtOuterDiameter";
            this.txtOuterDiameter.ReadOnly = true;
            this.txtOuterDiameter.Size = new System.Drawing.Size(127, 30);
            this.txtOuterDiameter.TabIndex = 9;
            // 
            // cmbNPS
            // 
            this.cmbNPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNPS.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNPS.FormattingEnabled = true;
            this.cmbNPS.Location = new System.Drawing.Point(110, 25);
            this.cmbNPS.Name = "cmbNPS";
            this.cmbNPS.Size = new System.Drawing.Size(65, 31);
            this.cmbNPS.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(15, 28);
            this.label4.MinimumSize = new System.Drawing.Size(90, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "NPS:";
            // 
            // lblOD
            // 
            this.lblOD.AutoSize = true;
            this.lblOD.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOD.Location = new System.Drawing.Point(213, 31);
            this.lblOD.MinimumSize = new System.Drawing.Size(90, 0);
            this.lblOD.Name = "lblOD";
            this.lblOD.Size = new System.Drawing.Size(186, 23);
            this.lblOD.TabIndex = 8;
            this.lblOD.Text = "Outer Diameter (D):";
            this.lblOD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolTipWeldJointFactor
            // 
            this.toolTipWeldJointFactor.AutoPopDelay = 5000;
            this.toolTipWeldJointFactor.InitialDelay = 500;
            this.toolTipWeldJointFactor.ReshowDelay = 100;
            // 
            // groupBoxConditions
            // 
            this.groupBoxConditions.Controls.Add(this.txtBarlowThicknessResult);
            this.groupBoxConditions.Controls.Add(this.lblBarlowThickness);
            this.groupBoxConditions.Controls.Add(this.txtMinThicknessResult);
            this.groupBoxConditions.Controls.Add(this.labelMinThickness);
            this.groupBoxConditions.Controls.Add(this.txtStressValue);
            this.groupBoxConditions.Controls.Add(this.label10);
            this.groupBoxConditions.Controls.Add(this.txtPressure);
            this.groupBoxConditions.Controls.Add(this.label5);
            this.groupBoxConditions.Controls.Add(this.txtTemperature);
            this.groupBoxConditions.Controls.Add(this.label6);
            this.groupBoxConditions.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConditions.Location = new System.Drawing.Point(15, 437);
            this.groupBoxConditions.Margin = new System.Windows.Forms.Padding(10, 0, 10, 15);
            this.groupBoxConditions.Name = "groupBoxConditions";
            this.groupBoxConditions.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxConditions.Size = new System.Drawing.Size(545, 190);
            this.groupBoxConditions.TabIndex = 2;
            this.groupBoxConditions.TabStop = false;
            this.groupBoxConditions.Text = "Design Conditions";
            // 
            // txtBarlowThicknessResult
            // 
            this.txtBarlowThicknessResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBarlowThicknessResult.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarlowThicknessResult.Location = new System.Drawing.Point(234, 153);
            this.txtBarlowThicknessResult.Name = "txtBarlowThicknessResult";
            this.txtBarlowThicknessResult.ReadOnly = true;
            this.txtBarlowThicknessResult.Size = new System.Drawing.Size(298, 30);
            this.txtBarlowThicknessResult.TabIndex = 16;
            // 
            // lblBarlowThickness
            // 
            this.lblBarlowThickness.AutoSize = true;
            this.lblBarlowThickness.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarlowThickness.Location = new System.Drawing.Point(15, 158);
            this.lblBarlowThickness.MinimumSize = new System.Drawing.Size(145, 0);
            this.lblBarlowThickness.Name = "lblBarlowThickness";
            this.lblBarlowThickness.Size = new System.Drawing.Size(160, 23);
            this.lblBarlowThickness.TabIndex = 15;
            this.lblBarlowThickness.Text = "Barlow t-min (in):";
            this.lblBarlowThickness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMinThicknessResult
            // 
            this.txtMinThicknessResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMinThicknessResult.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinThicknessResult.Location = new System.Drawing.Point(234, 123);
            this.txtMinThicknessResult.Name = "txtMinThicknessResult";
            this.txtMinThicknessResult.ReadOnly = true;
            this.txtMinThicknessResult.Size = new System.Drawing.Size(298, 30);
            this.txtMinThicknessResult.TabIndex = 14;
            // 
            // labelMinThickness
            // 
            this.labelMinThickness.AutoSize = true;
            this.labelMinThickness.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinThickness.Location = new System.Drawing.Point(15, 128);
            this.labelMinThickness.MinimumSize = new System.Drawing.Size(137, 0);
            this.labelMinThickness.Name = "labelMinThickness";
            this.labelMinThickness.Size = new System.Drawing.Size(151, 23);
            this.labelMinThickness.TabIndex = 13;
            this.labelMinThickness.Text = "B31.3 t-min (in):";
            this.labelMinThickness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStressValue
            // 
            this.txtStressValue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtStressValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStressValue.Location = new System.Drawing.Point(234, 93);
            this.txtStressValue.Name = "txtStressValue";
            this.txtStressValue.ReadOnly = true;
            this.txtStressValue.Size = new System.Drawing.Size(298, 30);
            this.txtStressValue.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 98);
            this.label10.MinimumSize = new System.Drawing.Size(135, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "(S) Stress (psi):";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPressure
            // 
            this.txtPressure.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPressure.Location = new System.Drawing.Point(234, 63);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(222, 30);
            this.txtPressure.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 68);
            this.label5.MinimumSize = new System.Drawing.Size(156, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "(P) Pressure (psi):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(234, 33);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(222, 30);
            this.txtTemperature.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 38);
            this.label6.MinimumSize = new System.Drawing.Size(151, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Temperature (°F):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxMaterialData
            // 
            this.groupBoxMaterialData.Controls.Add(this.txtTensile);
            this.groupBoxMaterialData.Controls.Add(this.label17);
            this.groupBoxMaterialData.Controls.Add(this.txtPNo);
            this.groupBoxMaterialData.Controls.Add(this.label19);
            this.groupBoxMaterialData.Controls.Add(this.txtYield);
            this.groupBoxMaterialData.Controls.Add(this.label20);
            this.groupBoxMaterialData.Controls.Add(this.txtMaxTemp);
            this.groupBoxMaterialData.Controls.Add(this.label21);
            this.groupBoxMaterialData.Controls.Add(this.txtMinTemp);
            this.groupBoxMaterialData.Controls.Add(this.label18);
            this.groupBoxMaterialData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMaterialData.Location = new System.Drawing.Point(15, 779);
            this.groupBoxMaterialData.Name = "groupBoxMaterialData";
            this.groupBoxMaterialData.Size = new System.Drawing.Size(545, 143);
            this.groupBoxMaterialData.TabIndex = 5;
            this.groupBoxMaterialData.TabStop = false;
            this.groupBoxMaterialData.Text = "Material Properties";
            // 
            // txtTensile
            // 
            this.txtTensile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTensile.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTensile.Location = new System.Drawing.Point(418, 30);
            this.txtTensile.Name = "txtTensile";
            this.txtTensile.Size = new System.Drawing.Size(100, 30);
            this.txtTensile.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(20, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 1;
            this.label17.Text = "PNo";
            // 
            // txtPNo
            // 
            this.txtPNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPNo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPNo.Location = new System.Drawing.Point(150, 90);
            this.txtPNo.Name = "txtPNo";
            this.txtPNo.Size = new System.Drawing.Size(100, 30);
            this.txtPNo.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(280, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 3;
            this.label19.Text = "Tensile";
            // 
            // txtYield
            // 
            this.txtYield.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtYield.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYield.Location = new System.Drawing.Point(418, 60);
            this.txtYield.Name = "txtYield";
            this.txtYield.Size = new System.Drawing.Size(100, 30);
            this.txtYield.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(280, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 5;
            this.label20.Text = "Yield";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaxTemp.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTemp.Location = new System.Drawing.Point(150, 60);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(100, 30);
            this.txtMaxTemp.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(20, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 7;
            this.label21.Text = "MaxTemp";
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMinTemp.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinTemp.Location = new System.Drawing.Point(150, 27);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(100, 30);
            this.txtMinTemp.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 9;
            this.label18.Text = "MinTemp";
            // 
            // groupBoxFactors
            // 
            this.groupBoxFactors.Controls.Add(this.btnShowTable304);
            this.groupBoxFactors.Controls.Add(this.btnShowTable);
            this.groupBoxFactors.Controls.Add(this.txtWeldJointFactor);
            this.groupBoxFactors.Controls.Add(this.cmbQualityFactor);
            this.groupBoxFactors.Controls.Add(this.label7);
            this.groupBoxFactors.Controls.Add(this.labelWeldJointFactor);
            this.groupBoxFactors.Controls.Add(this.txtYCoefficient);
            this.groupBoxFactors.Controls.Add(this.label9);
            this.groupBoxFactors.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFactors.Location = new System.Drawing.Point(19, 642);
            this.groupBoxFactors.Margin = new System.Windows.Forms.Padding(10, 0, 10, 15);
            this.groupBoxFactors.Name = "groupBoxFactors";
            this.groupBoxFactors.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxFactors.Size = new System.Drawing.Size(545, 134);
            this.groupBoxFactors.TabIndex = 3;
            this.groupBoxFactors.TabStop = false;
            this.groupBoxFactors.Text = "Calculation Factors";
            // 
            // btnShowTable304
            // 
            this.btnShowTable304.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable304.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowTable304.Location = new System.Drawing.Point(295, 88);
            this.btnShowTable304.Name = "btnShowTable304";
            this.btnShowTable304.Size = new System.Drawing.Size(119, 23);
            this.btnShowTable304.TabIndex = 22;
            this.btnShowTable304.Text = "Table 304.1.1-1";
            this.btnShowTable304.UseVisualStyleBackColor = true;
            // 
            // btnShowTable
            // 
            this.btnShowTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnShowTable.Location = new System.Drawing.Point(295, 59);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(119, 23);
            this.btnShowTable.TabIndex = 21;
            this.btnShowTable.Text = "Table 302.3.5-1";
            this.btnShowTable.UseVisualStyleBackColor = true;
            // 
            // txtWeldJointFactor
            // 
            this.txtWeldJointFactor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeldJointFactor.Location = new System.Drawing.Point(188, 56);
            this.txtWeldJointFactor.Name = "txtWeldJointFactor";
            this.txtWeldJointFactor.Size = new System.Drawing.Size(76, 30);
            this.txtWeldJointFactor.TabIndex = 20;
            // 
            // cmbQualityFactor
            // 
            this.cmbQualityFactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQualityFactor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQualityFactor.FormattingEnabled = true;
            this.cmbQualityFactor.Location = new System.Drawing.Point(188, 25);
            this.cmbQualityFactor.Name = "cmbQualityFactor";
            this.cmbQualityFactor.Size = new System.Drawing.Size(344, 31);
            this.cmbQualityFactor.TabIndex = 7;
            // 
            // txtYCoefficient
            // 
            this.txtYCoefficient.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYCoefficient.Location = new System.Drawing.Point(188, 86);
            this.txtYCoefficient.Name = "txtYCoefficient";
            this.txtYCoefficient.Size = new System.Drawing.Size(76, 30);
            this.txtYCoefficient.TabIndex = 9;
            this.txtYCoefficient.Text = "0.4";
            // 
            // txtClassConditionTemper
            // 
            this.txtClassConditionTemper.Location = new System.Drawing.Point(0, 0);
            this.txtClassConditionTemper.Name = "txtClassConditionTemper";
            this.txtClassConditionTemper.Size = new System.Drawing.Size(100, 26);
            this.txtClassConditionTemper.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 0;
            // 
            // txtProductForm
            // 
            this.txtProductForm.Location = new System.Drawing.Point(0, 0);
            this.txtProductForm.Name = "txtProductForm";
            this.txtProductForm.Size = new System.Drawing.Size(100, 26);
            this.txtProductForm.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 0;
            // 
            // txtUNSNo
            // 
            this.txtUNSNo.Location = new System.Drawing.Point(0, 0);
            this.txtUNSNo.Name = "txtUNSNo";
            this.txtUNSNo.Size = new System.Drawing.Size(100, 26);
            this.txtUNSNo.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 0;
            // 
            // txtNominalComposition
            // 
            this.txtNominalComposition.Location = new System.Drawing.Point(0, 0);
            this.txtNominalComposition.Name = "txtNominalComposition";
            this.txtNominalComposition.Size = new System.Drawing.Size(100, 26);
            this.txtNominalComposition.TabIndex = 0;
            // 
            // lblNominalComposition
            // 
            this.lblNominalComposition.Location = new System.Drawing.Point(0, 0);
            this.lblNominalComposition.Name = "lblNominalComposition";
            this.lblNominalComposition.Size = new System.Drawing.Size(100, 23);
            this.lblNominalComposition.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 0;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(0, 0);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 26);
            this.txtSize.TabIndex = 0;
            // 
            // groupMaterialNotes
            // 
            this.groupMaterialNotes.Controls.Add(this.rtbNotesActual);
            this.groupMaterialNotes.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMaterialNotes.Location = new System.Drawing.Point(573, 362);
            this.groupMaterialNotes.Name = "groupMaterialNotes";
            this.groupMaterialNotes.Padding = new System.Windows.Forms.Padding(10);
            this.groupMaterialNotes.Size = new System.Drawing.Size(351, 570);
            this.groupMaterialNotes.TabIndex = 5;
            this.groupMaterialNotes.TabStop = false;
            this.groupMaterialNotes.Text = "Notes";
            // 
            // rtbNotesActual
            // 
            this.rtbNotesActual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbNotesActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbNotesActual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotesActual.Font = new System.Drawing.Font("Arial", 10F);
            this.rtbNotesActual.Location = new System.Drawing.Point(10, 33);
            this.rtbNotesActual.Name = "rtbNotesActual";
            this.rtbNotesActual.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbNotesActual.Size = new System.Drawing.Size(331, 527);
            this.rtbNotesActual.TabIndex = 3;
            this.rtbNotesActual.Text = "";
            // 
            // dgvMaterials
            // 
            this.dgvMaterials.AllowUserToAddRows = false;
            this.dgvMaterials.AllowUserToDeleteRows = false;
            this.dgvMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLineNo,
            this.colMaterial,
            this.colNominalComposition,
            this.colProductForm,
            this.colSpecNo,
            this.colTypeGrade,
            this.colUNSNo,
            this.colClassConditionTemper,
            this.colSize});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMaterials.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaterials.EnableHeadersVisualStyles = false;
            this.dgvMaterials.Location = new System.Drawing.Point(12, 54);
            this.dgvMaterials.MultiSelect = false;
            this.dgvMaterials.Name = "dgvMaterials";
            this.dgvMaterials.RowHeadersVisible = false;
            this.dgvMaterials.RowHeadersWidth = 62;
            this.dgvMaterials.RowTemplate.Height = 24;
            this.dgvMaterials.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterials.Size = new System.Drawing.Size(1455, 290);
            this.dgvMaterials.TabIndex = 0;
            // 
            // colLineNo
            // 
            this.colLineNo.HeaderText = "Line No.";
            this.colLineNo.MinimumWidth = 2;
            this.colLineNo.Name = "colLineNo";
            // 
            // colMaterial
            // 
            this.colMaterial.HeaderText = "Material";
            this.colMaterial.MinimumWidth = 8;
            this.colMaterial.Name = "colMaterial";
            // 
            // colNominalComposition
            // 
            this.colNominalComposition.HeaderText = "Nominal Composition";
            this.colNominalComposition.MinimumWidth = 12;
            this.colNominalComposition.Name = "colNominalComposition";
            // 
            // colProductForm
            // 
            this.colProductForm.HeaderText = "Product Form";
            this.colProductForm.MinimumWidth = 12;
            this.colProductForm.Name = "colProductForm";
            // 
            // colSpecNo
            // 
            this.colSpecNo.HeaderText = "Spec. No.";
            this.colSpecNo.MinimumWidth = 8;
            this.colSpecNo.Name = "colSpecNo";
            // 
            // colTypeGrade
            // 
            this.colTypeGrade.HeaderText = "Type/Grade";
            this.colTypeGrade.MinimumWidth = 8;
            this.colTypeGrade.Name = "colTypeGrade";
            // 
            // colUNSNo
            // 
            this.colUNSNo.HeaderText = "UNS No.";
            this.colUNSNo.MinimumWidth = 8;
            this.colUNSNo.Name = "colUNSNo";
            // 
            // colClassConditionTemper
            // 
            this.colClassConditionTemper.HeaderText = "Class/ Condition/ Temper";
            this.colClassConditionTemper.MinimumWidth = 8;
            this.colClassConditionTemper.Name = "colClassConditionTemper";
            // 
            // colSize
            // 
            this.colSize.HeaderText = "Size (in.)";
            this.colSize.MinimumWidth = 8;
            this.colSize.Name = "colSize";
            // 
            // colMaterialGroup
            // 
            this.colMaterialGroup.HeaderText = "Material Group";
            this.colMaterialGroup.MinimumWidth = 8;
            this.colMaterialGroup.Name = "colMaterialGroup";
            this.colMaterialGroup.Width = 150;
            // 
            // panelInputs
            // 
            this.panelInputs.AutoScroll = true;
            this.panelInputs.Controls.Add(this.label12);
            this.panelInputs.Controls.Add(this.groupBoxMaterialData);
            this.panelInputs.Controls.Add(this.groupBoxResults);
            this.panelInputs.Controls.Add(this.cmbMaterialGroup);
            this.panelInputs.Controls.Add(this.dgvMaterials);
            this.panelInputs.Controls.Add(this.groupBoxDimensions);
            this.panelInputs.Controls.Add(this.groupMaterialNotes);
            this.panelInputs.Controls.Add(this.groupBoxConditions);
            this.panelInputs.Controls.Add(this.groupBoxFactors);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInputs.Location = new System.Drawing.Point(0, 0);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(1484, 1027);
            this.panelInputs.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 959);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1484, 68);
            this.panelButtons.TabIndex = 1;
            // 
            // B31_3PipeCalculator
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1484, 1027);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelInputs);
            this.MinimumSize = new System.Drawing.Size(1218, 634);
            this.Name = "B31_3PipeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ASME B31.3 Pipe Thickness Calculator";
            this.groupBoxResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.groupBoxDimensions.ResumeLayout(false);
            this.groupBoxDimensions.PerformLayout();
            this.groupBoxConditions.ResumeLayout(false);
            this.groupBoxConditions.PerformLayout();
            this.groupBoxMaterialData.ResumeLayout(false);
            this.groupBoxMaterialData.PerformLayout();
            this.groupBoxFactors.ResumeLayout(false);
            this.groupBoxFactors.PerformLayout();
            this.groupMaterialNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterials)).EndInit();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ToolTip toolTipWeldJointFactor;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSpec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxDimensions;
        private System.Windows.Forms.TextBox txtOuterDiameter;
        private System.Windows.Forms.ComboBox cmbNPS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOD;
        private System.Windows.Forms.GroupBox groupBoxConditions;
        private System.Windows.Forms.TextBox txtBarlowThicknessResult;
        private System.Windows.Forms.Label lblBarlowThickness;
        private System.Windows.Forms.TextBox txtMinThicknessResult;
        private System.Windows.Forms.Label labelMinThickness;
        private System.Windows.Forms.TextBox txtStressValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvMaterials;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLineNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterialGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNominalComposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeGrade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUNSNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassConditionTemper;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.ComboBox cmbMaterialGroup;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBoxMaterialData;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtYield;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtTensile;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtClassConditionTemper;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUNSNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProductForm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNominalComposition;
        private System.Windows.Forms.Label lblNominalComposition;
        private GroupBox groupMaterialNotes;
        private RichTextBox rtbNotesActual;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarlowThickness;
        private GroupBox groupBoxFactors;
        private Button btnShowTable304;
        private Button btnShowTable;
        private TextBox txtWeldJointFactor;
        private ComboBox cmbQualityFactor;
        private Label label7;
        private Label labelWeldJointFactor;
        private TextBox txtYCoefficient;
        private Label label9;
        private Panel panelInputs;
        private Panel panelButtons;
    }
}
