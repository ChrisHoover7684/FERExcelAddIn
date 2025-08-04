namespace FERExcelAddIn
{
    partial class API510ExemptionEvaluator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMovable = new System.Windows.Forms.TabPage();
            this.grpMovableTypes = new System.Windows.Forms.GroupBox();
            this.optOceanVessel = new System.Windows.Forms.RadioButton();
            this.optBrakeReceiver = new System.Windows.Forms.RadioButton();
            this.optTruckTank = new System.Windows.Forms.RadioButton();
            this.chkMovableStructure = new System.Windows.Forms.CheckBox();
            this.tabASME = new System.Windows.Forms.TabPage();
            this.grpASMETypes = new System.Windows.Forms.GroupBox();
            this.optRotatingDevice = new System.Windows.Forms.RadioButton();
            this.optTubularHeater = new System.Windows.Forms.RadioButton();
            this.chkASMEExempt = new System.Windows.Forms.CheckBox();
            this.tabSpecs = new System.Windows.Forms.TabPage();
            this.grpVolumeInput = new System.Windows.Forms.GroupBox();
            this.lblDirectVolumeUnits = new System.Windows.Forms.Label();
            this.txtDirectVolume = new System.Windows.Forms.TextBox();
            this.radDirectVolume = new System.Windows.Forms.RadioButton();
            this.radCalculateVolume = new System.Windows.Forms.RadioButton();
            this.grpCalculatedVolume = new System.Windows.Forms.GroupBox();
            this.btnCalculateVolume = new System.Windows.Forms.Button();
            this.txtCalculatedVolume = new System.Windows.Forms.TextBox();
            this.lblCalculatedVolumeUnits = new System.Windows.Forms.Label();
            this.lblVolumeResult = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLengthUnits = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.lblODUnits = new System.Windows.Forms.Label();
            this.lblOD = new System.Windows.Forms.Label();
            this.cmbHeadCount = new System.Windows.Forms.ComboBox();
            this.lblHeadCount = new System.Windows.Forms.Label();
            this.cmbHeadType = new System.Windows.Forms.ComboBox();
            this.lblHeadType = new System.Windows.Forms.Label();
            this.grpDesignConditions = new System.Windows.Forms.GroupBox();
            this.txtDesignTemp = new System.Windows.Forms.TextBox();
            this.lblTempUnits = new System.Windows.Forms.Label();
            this.lblDesignTemp = new System.Windows.Forms.Label();
            this.txtDesignPressure = new System.Windows.Forms.TextBox();
            this.lblPressureUnits = new System.Windows.Forms.Label();
            this.lblDesignPressure = new System.Windows.Forms.Label();
            this.grpUnits = new System.Windows.Forms.GroupBox();
            this.radMetric = new System.Windows.Forms.RadioButton();
            this.radImperial = new System.Windows.Forms.RadioButton();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnClearSpecs = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabMovable.SuspendLayout();
            this.grpMovableTypes.SuspendLayout();
            this.tabASME.SuspendLayout();
            this.grpASMETypes.SuspendLayout();
            this.tabSpecs.SuspendLayout();
            this.grpVolumeInput.SuspendLayout();
            this.grpCalculatedVolume.SuspendLayout();
            this.grpDesignConditions.SuspendLayout();
            this.grpUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMovable);
            this.tabControl1.Controls.Add(this.tabASME);
            this.tabControl1.Controls.Add(this.tabSpecs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabMovable
            // 
            this.tabMovable.Controls.Add(this.grpMovableTypes);
            this.tabMovable.Controls.Add(this.chkMovableStructure);
            this.tabMovable.Location = new System.Drawing.Point(4, 29);
            this.tabMovable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMovable.Name = "tabMovable";
            this.tabMovable.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tabMovable.Size = new System.Drawing.Size(989, 459);
            this.tabMovable.TabIndex = 0;
            this.tabMovable.Text = "Movable Structures";
            this.tabMovable.UseVisualStyleBackColor = true;
            // 
            // grpMovableTypes
            // 
            this.grpMovableTypes.Controls.Add(this.optOceanVessel);
            this.grpMovableTypes.Controls.Add(this.optBrakeReceiver);
            this.grpMovableTypes.Controls.Add(this.optTruckTank);
            this.grpMovableTypes.Enabled = false;
            this.grpMovableTypes.Location = new System.Drawing.Point(12, 55);
            this.grpMovableTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMovableTypes.Name = "grpMovableTypes";
            this.grpMovableTypes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMovableTypes.Size = new System.Drawing.Size(864, 169);
            this.grpMovableTypes.TabIndex = 1;
            this.grpMovableTypes.TabStop = false;
            this.grpMovableTypes.Text = "Select Type";
            // 
            // optOceanVessel
            // 
            this.optOceanVessel.AutoSize = true;
            this.optOceanVessel.Location = new System.Drawing.Point(24, 123);
            this.optOceanVessel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optOceanVessel.Name = "optOceanVessel";
            this.optOceanVessel.Size = new System.Drawing.Size(418, 24);
            this.optOceanVessel.TabIndex = 2;
            this.optOceanVessel.Text = "Pressure vessel in oceangoing ship/barge/floating craft";
            this.optOceanVessel.UseVisualStyleBackColor = true;
            // 
            // optBrakeReceiver
            // 
            this.optBrakeReceiver.AutoSize = true;
            this.optBrakeReceiver.Location = new System.Drawing.Point(24, 77);
            this.optBrakeReceiver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optBrakeReceiver.Name = "optBrakeReceiver";
            this.optBrakeReceiver.Size = new System.Drawing.Size(245, 24);
            this.optBrakeReceiver.TabIndex = 1;
            this.optBrakeReceiver.Text = "Air receiver for braking system";
            this.optBrakeReceiver.UseVisualStyleBackColor = true;
            // 
            // optTruckTank
            // 
            this.optTruckTank.AutoSize = true;
            this.optTruckTank.Location = new System.Drawing.Point(24, 31);
            this.optTruckTank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optTruckTank.Name = "optTruckTank";
            this.optTruckTank.Size = new System.Drawing.Size(306, 24);
            this.optTruckTank.TabIndex = 0;
            this.optTruckTank.Text = "Cargo/volume tank for truck/ship/barge";
            this.optTruckTank.UseVisualStyleBackColor = true;
            // 
            // chkMovableStructure
            // 
            this.chkMovableStructure.AutoSize = true;
            this.chkMovableStructure.Location = new System.Drawing.Point(20, 20);
            this.chkMovableStructure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMovableStructure.Name = "chkMovableStructure";
            this.chkMovableStructure.Size = new System.Drawing.Size(229, 24);
            this.chkMovableStructure.TabIndex = 0;
            this.chkMovableStructure.Text = "Is this a movable structure?";
            this.chkMovableStructure.UseVisualStyleBackColor = true;
            // 
            // tabASME
            // 
            this.tabASME.Controls.Add(this.grpASMETypes);
            this.tabASME.Controls.Add(this.chkASMEExempt);
            this.tabASME.Location = new System.Drawing.Point(4, 29);
            this.tabASME.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabASME.Name = "tabASME";
            this.tabASME.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tabASME.Size = new System.Drawing.Size(989, 459);
            this.tabASME.TabIndex = 1;
            this.tabASME.Text = "ASME Exemptions";
            this.tabASME.UseVisualStyleBackColor = true;
            // 
            // grpASMETypes
            // 
            this.grpASMETypes.Controls.Add(this.optRotatingDevice);
            this.grpASMETypes.Controls.Add(this.optTubularHeater);
            this.grpASMETypes.Enabled = false;
            this.grpASMETypes.Location = new System.Drawing.Point(12, 55);
            this.grpASMETypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpASMETypes.Name = "grpASMETypes";
            this.grpASMETypes.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpASMETypes.Size = new System.Drawing.Size(864, 123);
            this.grpASMETypes.TabIndex = 1;
            this.grpASMETypes.TabStop = false;
            this.grpASMETypes.Text = "Select ASME Exemption Type";
            // 
            // optRotatingDevice
            // 
            this.optRotatingDevice.AutoSize = true;
            this.optRotatingDevice.Location = new System.Drawing.Point(24, 77);
            this.optRotatingDevice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optRotatingDevice.Name = "optRotatingDevice";
            this.optRotatingDevice.Size = new System.Drawing.Size(424, 24);
            this.optRotatingDevice.TabIndex = 1;
            this.optRotatingDevice.Text = "Integral part of rotating/reciprocating mechanical device";
            this.optRotatingDevice.UseVisualStyleBackColor = true;
            // 
            // optTubularHeater
            // 
            this.optTubularHeater.AutoSize = true;
            this.optTubularHeater.Location = new System.Drawing.Point(24, 31);
            this.optTubularHeater.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.optTubularHeater.Name = "optTubularHeater";
            this.optTubularHeater.Size = new System.Drawing.Size(233, 24);
            this.optTubularHeater.TabIndex = 0;
            this.optTubularHeater.Text = "Fired process tubular heater";
            this.optTubularHeater.UseVisualStyleBackColor = true;
            // 
            // chkASMEExempt
            // 
            this.chkASMEExempt.AutoSize = true;
            this.chkASMEExempt.Location = new System.Drawing.Point(20, 20);
            this.chkASMEExempt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkASMEExempt.Name = "chkASMEExempt";
            this.chkASMEExempt.Size = new System.Drawing.Size(365, 24);
            this.chkASMEExempt.TabIndex = 0;
            this.chkASMEExempt.Text = "Does this qualify for ASME BPVC exemptions?";
            this.chkASMEExempt.UseVisualStyleBackColor = true;
            // 
            // tabSpecs
            // 
            this.tabSpecs.Controls.Add(this.grpVolumeInput);
            this.tabSpecs.Controls.Add(this.grpDesignConditions);
            this.tabSpecs.Location = new System.Drawing.Point(4, 29);
            this.tabSpecs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSpecs.Name = "tabSpecs";
            this.tabSpecs.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tabSpecs.Size = new System.Drawing.Size(989, 459);
            this.tabSpecs.TabIndex = 2;
            this.tabSpecs.Text = "Vessel Specifications";
            this.tabSpecs.UseVisualStyleBackColor = true;
            // 
            // grpVolumeInput
            // 
            this.grpVolumeInput.Controls.Add(this.lblDirectVolumeUnits);
            this.grpVolumeInput.Controls.Add(this.txtDirectVolume);
            this.grpVolumeInput.Controls.Add(this.grpUnits);
            this.grpVolumeInput.Controls.Add(this.radDirectVolume);
            this.grpVolumeInput.Controls.Add(this.radCalculateVolume);
            this.grpVolumeInput.Controls.Add(this.grpCalculatedVolume);
            this.grpVolumeInput.Location = new System.Drawing.Point(12, 9);
            this.grpVolumeInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVolumeInput.Name = "grpVolumeInput";
            this.grpVolumeInput.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVolumeInput.Size = new System.Drawing.Size(965, 277);
            this.grpVolumeInput.TabIndex = 9;
            this.grpVolumeInput.TabStop = false;
            this.grpVolumeInput.Text = "Volume Input";
            // 
            // lblDirectVolumeUnits
            // 
            this.lblDirectVolumeUnits.AutoSize = true;
            this.lblDirectVolumeUnits.Location = new System.Drawing.Point(374, 47);
            this.lblDirectVolumeUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirectVolumeUnits.Name = "lblDirectVolumeUnits";
            this.lblDirectVolumeUnits.Size = new System.Drawing.Size(27, 20);
            this.lblDirectVolumeUnits.TabIndex = 8;
            this.lblDirectVolumeUnits.Text = "m³";
            // 
            // txtDirectVolume
            // 
            this.txtDirectVolume.Location = new System.Drawing.Point(254, 43);
            this.txtDirectVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDirectVolume.Name = "txtDirectVolume";
            this.txtDirectVolume.Size = new System.Drawing.Size(103, 26);
            this.txtDirectVolume.TabIndex = 2;
            // 
            // radDirectVolume
            // 
            this.radDirectVolume.AutoSize = true;
            this.radDirectVolume.Checked = true;
            this.radDirectVolume.Location = new System.Drawing.Point(24, 43);
            this.radDirectVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radDirectVolume.Name = "radDirectVolume";
            this.radDirectVolume.Size = new System.Drawing.Size(138, 24);
            this.radDirectVolume.TabIndex = 5;
            this.radDirectVolume.TabStop = true;
            this.radDirectVolume.Text = "Direct Volume:";
            this.radDirectVolume.UseVisualStyleBackColor = true;
            // 
            // radCalculateVolume
            // 
            this.radCalculateVolume.AutoSize = true;
            this.radCalculateVolume.Location = new System.Drawing.Point(24, 92);
            this.radCalculateVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radCalculateVolume.Name = "radCalculateVolume";
            this.radCalculateVolume.Size = new System.Drawing.Size(274, 24);
            this.radCalculateVolume.TabIndex = 4;
            this.radCalculateVolume.Text = "Calculate volume from dimensions";
            this.radCalculateVolume.UseVisualStyleBackColor = true;
            // 
            // grpCalculatedVolume
            // 
            this.grpCalculatedVolume.Controls.Add(this.btnCalculateVolume);
            this.grpCalculatedVolume.Controls.Add(this.txtCalculatedVolume);
            this.grpCalculatedVolume.Controls.Add(this.lblCalculatedVolumeUnits);
            this.grpCalculatedVolume.Controls.Add(this.lblVolumeResult);
            this.grpCalculatedVolume.Controls.Add(this.txtLength);
            this.grpCalculatedVolume.Controls.Add(this.lblLengthUnits);
            this.grpCalculatedVolume.Controls.Add(this.lblLength);
            this.grpCalculatedVolume.Controls.Add(this.txtOD);
            this.grpCalculatedVolume.Controls.Add(this.lblODUnits);
            this.grpCalculatedVolume.Controls.Add(this.lblOD);
            this.grpCalculatedVolume.Controls.Add(this.cmbHeadCount);
            this.grpCalculatedVolume.Controls.Add(this.lblHeadCount);
            this.grpCalculatedVolume.Controls.Add(this.cmbHeadType);
            this.grpCalculatedVolume.Controls.Add(this.lblHeadType);
            this.grpCalculatedVolume.Enabled = false;
            this.grpCalculatedVolume.Location = new System.Drawing.Point(8, 123);
            this.grpCalculatedVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCalculatedVolume.Name = "grpCalculatedVolume";
            this.grpCalculatedVolume.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCalculatedVolume.Size = new System.Drawing.Size(949, 138);
            this.grpCalculatedVolume.TabIndex = 3;
            this.grpCalculatedVolume.TabStop = false;
            this.grpCalculatedVolume.Text = "Vessel Dimensions";
            // 
            // btnCalculateVolume
            // 
            this.btnCalculateVolume.Location = new System.Drawing.Point(564, 29);
            this.btnCalculateVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculateVolume.Name = "btnCalculateVolume";
            this.btnCalculateVolume.Size = new System.Drawing.Size(152, 76);
            this.btnCalculateVolume.TabIndex = 9;
            this.btnCalculateVolume.Text = "Calculate";
            this.btnCalculateVolume.UseVisualStyleBackColor = true;
            // 
            // txtCalculatedVolume
            // 
            this.txtCalculatedVolume.Location = new System.Drawing.Point(786, 51);
            this.txtCalculatedVolume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCalculatedVolume.Name = "txtCalculatedVolume";
            this.txtCalculatedVolume.ReadOnly = true;
            this.txtCalculatedVolume.Size = new System.Drawing.Size(103, 26);
            this.txtCalculatedVolume.TabIndex = 5;
            // 
            // lblCalculatedVolumeUnits
            // 
            this.lblCalculatedVolumeUnits.AutoSize = true;
            this.lblCalculatedVolumeUnits.Location = new System.Drawing.Point(901, 54);
            this.lblCalculatedVolumeUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalculatedVolumeUnits.Name = "lblCalculatedVolumeUnits";
            this.lblCalculatedVolumeUnits.Size = new System.Drawing.Size(27, 20);
            this.lblCalculatedVolumeUnits.TabIndex = 0;
            this.lblCalculatedVolumeUnits.Text = "m³";
            // 
            // lblVolumeResult
            // 
            this.lblVolumeResult.AutoSize = true;
            this.lblVolumeResult.Location = new System.Drawing.Point(782, 24);
            this.lblVolumeResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolumeResult.Name = "lblVolumeResult";
            this.lblVolumeResult.Size = new System.Drawing.Size(146, 20);
            this.lblVolumeResult.TabIndex = 4;
            this.lblVolumeResult.Text = "Calculated Volume:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(307, 77);
            this.txtLength.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(88, 26);
            this.txtLength.TabIndex = 10;
            this.txtLength.Text = "0";
            // 
            // lblLengthUnits
            // 
            this.lblLengthUnits.AutoSize = true;
            this.lblLengthUnits.Location = new System.Drawing.Point(397, 82);
            this.lblLengthUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLengthUnits.Name = "lblLengthUnits";
            this.lblLengthUnits.Size = new System.Drawing.Size(22, 20);
            this.lblLengthUnits.TabIndex = 2;
            this.lblLengthUnits.Text = "m";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(307, 51);
            this.lblLength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(63, 20);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Length:";
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(187, 77);
            this.txtOD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOD.Name = "txtOD";
            this.txtOD.Size = new System.Drawing.Size(88, 26);
            this.txtOD.TabIndex = 11;
            this.txtOD.Text = "0";
            // 
            // lblODUnits
            // 
            this.lblODUnits.AutoSize = true;
            this.lblODUnits.Location = new System.Drawing.Point(277, 82);
            this.lblODUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblODUnits.Name = "lblODUnits";
            this.lblODUnits.Size = new System.Drawing.Size(22, 20);
            this.lblODUnits.TabIndex = 3;
            this.lblODUnits.Text = "m";
            // 
            // lblOD
            // 
            this.lblOD.AutoSize = true;
            this.lblOD.Location = new System.Drawing.Point(187, 51);
            this.lblOD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOD.Name = "lblOD";
            this.lblOD.Size = new System.Drawing.Size(37, 20);
            this.lblOD.TabIndex = 6;
            this.lblOD.Text = "OD:";
            // 
            // cmbHeadCount
            // 
            this.cmbHeadCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeadCount.FormattingEnabled = true;
            this.cmbHeadCount.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbHeadCount.Location = new System.Drawing.Point(427, 77);
            this.cmbHeadCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbHeadCount.Name = "cmbHeadCount";
            this.cmbHeadCount.Size = new System.Drawing.Size(73, 28);
            this.cmbHeadCount.TabIndex = 12;
            // 
            // lblHeadCount
            // 
            this.lblHeadCount.AutoSize = true;
            this.lblHeadCount.Location = new System.Drawing.Point(427, 51);
            this.lblHeadCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadCount.Name = "lblHeadCount";
            this.lblHeadCount.Size = new System.Drawing.Size(73, 20);
            this.lblHeadCount.TabIndex = 7;
            this.lblHeadCount.Text = "# Heads:";
            // 
            // cmbHeadType
            // 
            this.cmbHeadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeadType.FormattingEnabled = true;
            this.cmbHeadType.Items.AddRange(new object[] {
            "Ellipsoidal (2:1)",
            "Hemispherical",
            "Torispherical",
            "Flat"});
            this.cmbHeadType.Location = new System.Drawing.Point(15, 77);
            this.cmbHeadType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbHeadType.Name = "cmbHeadType";
            this.cmbHeadType.Size = new System.Drawing.Size(150, 28);
            this.cmbHeadType.TabIndex = 13;
            // 
            // lblHeadType
            // 
            this.lblHeadType.AutoSize = true;
            this.lblHeadType.Location = new System.Drawing.Point(15, 51);
            this.lblHeadType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadType.Name = "lblHeadType";
            this.lblHeadType.Size = new System.Drawing.Size(52, 20);
            this.lblHeadType.TabIndex = 8;
            this.lblHeadType.Text = "Head:";
            // 
            // grpDesignConditions
            // 
            this.grpDesignConditions.Controls.Add(this.txtDesignTemp);
            this.grpDesignConditions.Controls.Add(this.lblTempUnits);
            this.grpDesignConditions.Controls.Add(this.lblDesignTemp);
            this.grpDesignConditions.Controls.Add(this.txtDesignPressure);
            this.grpDesignConditions.Controls.Add(this.lblPressureUnits);
            this.grpDesignConditions.Controls.Add(this.lblDesignPressure);
            this.grpDesignConditions.Location = new System.Drawing.Point(12, 292);
            this.grpDesignConditions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDesignConditions.Name = "grpDesignConditions";
            this.grpDesignConditions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDesignConditions.Size = new System.Drawing.Size(420, 123);
            this.grpDesignConditions.TabIndex = 10;
            this.grpDesignConditions.TabStop = false;
            this.grpDesignConditions.Text = "Design Conditions";
            // 
            // txtDesignTemp
            // 
            this.txtDesignTemp.Location = new System.Drawing.Point(180, 77);
            this.txtDesignTemp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesignTemp.Name = "txtDesignTemp";
            this.txtDesignTemp.Size = new System.Drawing.Size(103, 26);
            this.txtDesignTemp.TabIndex = 7;
            this.txtDesignTemp.Text = "0";
            // 
            // lblTempUnits
            // 
            this.lblTempUnits.AutoSize = true;
            this.lblTempUnits.Location = new System.Drawing.Point(300, 82);
            this.lblTempUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempUnits.Name = "lblTempUnits";
            this.lblTempUnits.Size = new System.Drawing.Size(25, 20);
            this.lblTempUnits.TabIndex = 0;
            this.lblTempUnits.Text = "°C";
            // 
            // lblDesignTemp
            // 
            this.lblDesignTemp.AutoSize = true;
            this.lblDesignTemp.Location = new System.Drawing.Point(15, 82);
            this.lblDesignTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesignTemp.Name = "lblDesignTemp";
            this.lblDesignTemp.Size = new System.Drawing.Size(158, 20);
            this.lblDesignTemp.TabIndex = 2;
            this.lblDesignTemp.Text = "Design Temperature:";
            // 
            // txtDesignPressure
            // 
            this.txtDesignPressure.Location = new System.Drawing.Point(180, 31);
            this.txtDesignPressure.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDesignPressure.Name = "txtDesignPressure";
            this.txtDesignPressure.Size = new System.Drawing.Size(103, 26);
            this.txtDesignPressure.TabIndex = 6;
            this.txtDesignPressure.Text = "0";
            // 
            // lblPressureUnits
            // 
            this.lblPressureUnits.AutoSize = true;
            this.lblPressureUnits.Location = new System.Drawing.Point(300, 35);
            this.lblPressureUnits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPressureUnits.Name = "lblPressureUnits";
            this.lblPressureUnits.Size = new System.Drawing.Size(41, 20);
            this.lblPressureUnits.TabIndex = 1;
            this.lblPressureUnits.Text = "MPa";
            // 
            // lblDesignPressure
            // 
            this.lblDesignPressure.AutoSize = true;
            this.lblDesignPressure.Location = new System.Drawing.Point(15, 35);
            this.lblDesignPressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesignPressure.Name = "lblDesignPressure";
            this.lblDesignPressure.Size = new System.Drawing.Size(130, 20);
            this.lblDesignPressure.TabIndex = 3;
            this.lblDesignPressure.Text = "Design Pressure:";
            // 
            // grpUnits
            // 
            this.grpUnits.Controls.Add(this.radMetric);
            this.grpUnits.Controls.Add(this.radImperial);
            this.grpUnits.Location = new System.Drawing.Point(543, 20);
            this.grpUnits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUnits.Name = "grpUnits";
            this.grpUnits.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpUnits.Size = new System.Drawing.Size(255, 77);
            this.grpUnits.TabIndex = 6;
            this.grpUnits.TabStop = false;
            this.grpUnits.Text = "Units";
            // 
            // radMetric
            // 
            this.radMetric.AutoSize = true;
            this.radMetric.Checked = true;
            this.radMetric.Location = new System.Drawing.Point(15, 31);
            this.radMetric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radMetric.Name = "radMetric";
            this.radMetric.Size = new System.Drawing.Size(77, 24);
            this.radMetric.TabIndex = 0;
            this.radMetric.TabStop = true;
            this.radMetric.Text = "Metric";
            this.radMetric.UseVisualStyleBackColor = true;
            // 
            // radImperial
            // 
            this.radImperial.AutoSize = true;
            this.radImperial.Location = new System.Drawing.Point(135, 31);
            this.radImperial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radImperial.Name = "radImperial";
            this.radImperial.Size = new System.Drawing.Size(90, 24);
            this.radImperial.TabIndex = 1;
            this.radImperial.Text = "Imperial";
            this.radImperial.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(16, 498);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(981, 152);
            this.txtResult.TabIndex = 2;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEvaluate.Location = new System.Drawing.Point(310, 660);
            this.btnEvaluate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(291, 50);
            this.btnEvaluate.TabIndex = 1;
            this.btnEvaluate.Text = "Evaluate Exemption";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            // 
            // btnClearSpecs
            // 
            this.btnClearSpecs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearSpecs.Location = new System.Drawing.Point(310, 720);
            this.btnClearSpecs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearSpecs.Name = "btnClearSpecs";
            this.btnClearSpecs.Size = new System.Drawing.Size(291, 38);
            this.btnClearSpecs.TabIndex = 0;
            this.btnClearSpecs.Text = "Clear Specifications";
            this.btnClearSpecs.UseVisualStyleBackColor = true;
            // 
            // API510ExemptionEvaluator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 769);
            this.Controls.Add(this.btnClearSpecs);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(739, 724);
            this.Name = "API510ExemptionEvaluator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "API 510 Exemption Evaluator";
            this.tabControl1.ResumeLayout(false);
            this.tabMovable.ResumeLayout(false);
            this.tabMovable.PerformLayout();
            this.grpMovableTypes.ResumeLayout(false);
            this.grpMovableTypes.PerformLayout();
            this.tabASME.ResumeLayout(false);
            this.tabASME.PerformLayout();
            this.grpASMETypes.ResumeLayout(false);
            this.grpASMETypes.PerformLayout();
            this.tabSpecs.ResumeLayout(false);
            this.grpVolumeInput.ResumeLayout(false);
            this.grpVolumeInput.PerformLayout();
            this.grpCalculatedVolume.ResumeLayout(false);
            this.grpCalculatedVolume.PerformLayout();
            this.grpDesignConditions.ResumeLayout(false);
            this.grpDesignConditions.PerformLayout();
            this.grpUnits.ResumeLayout(false);
            this.grpUnits.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMovable;
        private System.Windows.Forms.GroupBox grpMovableTypes;
        private System.Windows.Forms.RadioButton optOceanVessel;
        private System.Windows.Forms.RadioButton optBrakeReceiver;
        private System.Windows.Forms.RadioButton optTruckTank;
        private System.Windows.Forms.CheckBox chkMovableStructure;
        private System.Windows.Forms.TabPage tabASME;
        private System.Windows.Forms.GroupBox grpASMETypes;
        private System.Windows.Forms.RadioButton optRotatingDevice;
        private System.Windows.Forms.RadioButton optTubularHeater;
        private System.Windows.Forms.CheckBox chkASMEExempt;
        private System.Windows.Forms.TabPage tabSpecs;
        private System.Windows.Forms.GroupBox grpVolumeInput;
        private System.Windows.Forms.Label lblDirectVolumeUnits;
        private System.Windows.Forms.TextBox txtDirectVolume;
        private System.Windows.Forms.RadioButton radDirectVolume;
        private System.Windows.Forms.RadioButton radCalculateVolume;
        private System.Windows.Forms.GroupBox grpCalculatedVolume;
        private System.Windows.Forms.Button btnCalculateVolume;
        private System.Windows.Forms.TextBox txtCalculatedVolume;
        private System.Windows.Forms.Label lblCalculatedVolumeUnits;
        private System.Windows.Forms.Label lblVolumeResult;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLengthUnits;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.Label lblODUnits;
        private System.Windows.Forms.Label lblOD;
        private System.Windows.Forms.ComboBox cmbHeadCount;
        private System.Windows.Forms.Label lblHeadCount;
        private System.Windows.Forms.ComboBox cmbHeadType;
        private System.Windows.Forms.Label lblHeadType;
        private System.Windows.Forms.GroupBox grpDesignConditions;
        private System.Windows.Forms.TextBox txtDesignTemp;
        private System.Windows.Forms.Label lblTempUnits;
        private System.Windows.Forms.Label lblDesignTemp;
        private System.Windows.Forms.TextBox txtDesignPressure;
        private System.Windows.Forms.Label lblPressureUnits;
        private System.Windows.Forms.Label lblDesignPressure;
        private System.Windows.Forms.GroupBox grpUnits;
        private System.Windows.Forms.RadioButton radImperial;
        private System.Windows.Forms.RadioButton radMetric;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnClearSpecs;
    }
}