using System.Windows.Forms;

namespace FERExcelAddIn
{
    partial class PSVSizingForm
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
            this.components = new System.ComponentModel.Container();
            this.mainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.leftFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.psvConfigGroupBox = new System.Windows.Forms.GroupBox();
            this.radSinglePSV = new System.Windows.Forms.RadioButton();
            this.radMultiplePSV = new System.Windows.Forms.RadioButton();
            this.chkFireCase = new System.Windows.Forms.CheckBox();
            this.lblFluidType = new System.Windows.Forms.Label();
            this.fluidTypeCombo = new System.Windows.Forms.ComboBox();
            this.scenarioGroupBox = new System.Windows.Forms.GroupBox();
            this.chkBlockedOutlet = new System.Windows.Forms.CheckBox();
            this.chkExternalFire = new System.Windows.Forms.CheckBox();
            this.chkCoolingFailure = new System.Windows.Forms.CheckBox();
            this.chkTubeRupture = new System.Windows.Forms.CheckBox();
            this.chkChemicalReaction = new System.Windows.Forms.CheckBox();
            this.vesselDesignGroupBox = new System.Windows.Forms.GroupBox();
            this.lblMAWP = new System.Windows.Forms.Label();
            this.txtMAWP = new System.Windows.Forms.TextBox();
            this.lblDesignTemp = new System.Windows.Forms.Label();
            this.txtDesignTemp = new System.Windows.Forms.TextBox();
            this.lblAccumulation = new System.Windows.Forms.Label();
            this.cmbAccumulation = new System.Windows.Forms.ComboBox();
            this.lblFillLevel = new System.Windows.Forms.Label();
            this.txtFillLevel = new System.Windows.Forms.TextBox();
            this.lblVesselDiameter = new System.Windows.Forms.Label();
            this.vesselDiameterInput = new System.Windows.Forms.TextBox();
            this.lblVesselLength = new System.Windows.Forms.Label();
            this.vesselLengthInput = new System.Windows.Forms.TextBox();
            this.chkHorizontalVessel = new System.Windows.Forms.CheckBox();
            this.chkInsulated = new System.Windows.Forms.CheckBox();
            this.chkRefluxFailure = new System.Windows.Forms.CheckBox();
            this.chkWaterSpray = new System.Windows.Forms.CheckBox();
            this.chkPowerFailure = new System.Windows.Forms.CheckBox();
            this.chkHydraulicHammer = new System.Windows.Forms.CheckBox();  
            this.chkControlValveFailure = new System.Windows.Forms.CheckBox();
            this.chkCompressorFailure = new System.Windows.Forms.CheckBox();
            this.chkThermalExpansion = new System.Windows.Forms.CheckBox();
            
            this.chkUnderground = new System.Windows.Forms.CheckBox();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.lblPressure = new System.Windows.Forms.Label();
            this.pressureInput = new System.Windows.Forms.TextBox();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.temperatureInput = new System.Windows.Forms.TextBox();
            this.lblFlowRate = new System.Windows.Forms.Label();
            this.flowRateInput = new System.Windows.Forms.TextBox();
            this.lblMolecularWeight = new System.Windows.Forms.Label();
            this.molecularWeightInput = new System.Windows.Forms.TextBox();
            this.lblSpecificHeatRatio = new System.Windows.Forms.Label();
            this.specificHeatRatioInput = new System.Windows.Forms.TextBox();
            this.lblCompressibility = new System.Windows.Forms.Label();
            this.compressibilityInput = new System.Windows.Forms.TextBox();
            this.lblViscosity = new System.Windows.Forms.Label();
            this.viscosityInput = new System.Windows.Forms.TextBox();
            this.lblSpecificGravity = new System.Windows.Forms.Label();
            this.specificGravityInput = new System.Windows.Forms.TextBox();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.colScenario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFlowRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrificeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.autoCalculateCheckBox = new System.Windows.Forms.CheckBox();
            this.lblVesselOrientation = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mainTableLayout.SuspendLayout();
            this.leftFlowPanel.SuspendLayout();
            this.psvConfigGroupBox.SuspendLayout();
            this.scenarioGroupBox.SuspendLayout();
            this.vesselDesignGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // mainTableLayout
            //
            this.mainTableLayout.ColumnCount = 2;
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayout.Controls.Add(this.leftFlowPanel, 0, 0);
            this.mainTableLayout.Controls.Add(this.inputGroupBox, 1, 0);
            this.mainTableLayout.Controls.Add(this.resultsDataGridView, 0, 1);
            this.mainTableLayout.Controls.Add(this.buttonsPanel, 1, 1);
            this.mainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayout.Name = "mainTableLayout";
            this.mainTableLayout.RowCount = 2;
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.mainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.mainTableLayout.Size = new System.Drawing.Size(1168, 1031);
            this.mainTableLayout.TabIndex = 0;
            //
            // leftFlowPanel
            //
            this.leftFlowPanel.Controls.Add(this.psvConfigGroupBox);
            this.leftFlowPanel.Controls.Add(this.lblFluidType);
            this.leftFlowPanel.Controls.Add(this.fluidTypeCombo);
            this.leftFlowPanel.Controls.Add(this.scenarioGroupBox);
            this.leftFlowPanel.Controls.Add(this.vesselDesignGroupBox);
            this.leftFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.leftFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.leftFlowPanel.Name = "leftFlowPanel";
            this.leftFlowPanel.Size = new System.Drawing.Size(694, 715);
            this.leftFlowPanel.TabIndex = 0;
            this.leftFlowPanel.WrapContents = false;
            //
            // psvConfigGroupBox
            //
            this.psvConfigGroupBox.Controls.Add(this.radSinglePSV);
            this.psvConfigGroupBox.Controls.Add(this.radMultiplePSV);
            this.psvConfigGroupBox.Controls.Add(this.chkFireCase);
            this.psvConfigGroupBox.Location = new System.Drawing.Point(3, 3);
            this.psvConfigGroupBox.Name = "psvConfigGroupBox";
            this.psvConfigGroupBox.Size = new System.Drawing.Size(238, 120);
            this.psvConfigGroupBox.TabIndex = 0;
            this.psvConfigGroupBox.TabStop = false;
            this.psvConfigGroupBox.Text = "PSV Configuration";
            //
            // radSinglePSV
            //
            this.radSinglePSV.AutoSize = true;
            this.radSinglePSV.Checked = true;
            this.radSinglePSV.Location = new System.Drawing.Point(20, 30);
            this.radSinglePSV.Name = "radSinglePSV";
            this.radSinglePSV.Size = new System.Drawing.Size(114, 24);
            this.radSinglePSV.TabIndex = 0;
            this.radSinglePSV.TabStop = true;
            this.radSinglePSV.Text = "Single PSV";
            this.radSinglePSV.UseVisualStyleBackColor = true;
            //
            // radMultiplePSV
            //
            this.radMultiplePSV.AutoSize = true;
            this.radMultiplePSV.Location = new System.Drawing.Point(20, 60);
            this.radMultiplePSV.Name = "radMultiplePSV";
            this.radMultiplePSV.Size = new System.Drawing.Size(124, 24);
            this.radMultiplePSV.TabIndex = 1;
            this.radMultiplePSV.Text = "Multiple PSV";
            this.radMultiplePSV.UseVisualStyleBackColor = true;
            //
            // chkFireCase
            //
            this.chkFireCase.AutoSize = true;
            this.chkFireCase.Location = new System.Drawing.Point(20, 90);
            this.chkFireCase.Name = "chkFireCase";
            this.chkFireCase.Size = new System.Drawing.Size(103, 24);
            this.chkFireCase.TabIndex = 2;
            this.chkFireCase.Text = "Fire Case";
            this.chkFireCase.UseVisualStyleBackColor = true;
            //
            // lblFluidType
            //
            this.lblFluidType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFluidType.AutoSize = true;
            this.lblFluidType.Location = new System.Drawing.Point(3, 126);
            this.lblFluidType.Name = "lblFluidType";
            this.lblFluidType.Size = new System.Drawing.Size(85, 20);
            this.lblFluidType.TabIndex = 11;
            this.lblFluidType.Text = "Fluid Type:";
            //
            // fluidTypeCombo
            //
            this.fluidTypeCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fluidTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fluidTypeCombo.FormattingEnabled = true;
            this.fluidTypeCombo.Items.AddRange(new object[] {
            "Gas",
            "Liquid",
            "Steam",
            "Two-Phase"});
            this.fluidTypeCombo.Location = new System.Drawing.Point(232, 149);
            this.fluidTypeCombo.Name = "fluidTypeCombo";
            this.fluidTypeCombo.Size = new System.Drawing.Size(162, 28);
            this.fluidTypeCombo.TabIndex = 1;
            //
            // scenarioGroupBox
            //
            this.scenarioGroupBox.Controls.Add(this.chkCompressorFailure);
            this.scenarioGroupBox.Controls.Add(this.chkRefluxFailure);
            this.scenarioGroupBox.Controls.Add(this.chkHydraulicHammer);
            this.scenarioGroupBox.Controls.Add(this.chkPowerFailure);
            this.scenarioGroupBox.Controls.Add(this.chkControlValveFailure);
            this.scenarioGroupBox.Controls.Add(this.chkThermalExpansion);
            this.scenarioGroupBox.Controls.Add(this.chkBlockedOutlet);
            this.scenarioGroupBox.Controls.Add(this.chkExternalFire);
            this.scenarioGroupBox.Controls.Add(this.chkCoolingFailure);
            this.scenarioGroupBox.Controls.Add(this.chkTubeRupture);
            this.scenarioGroupBox.Controls.Add(this.chkChemicalReaction);
            this.scenarioGroupBox.Location = new System.Drawing.Point(3, 183);
            this.scenarioGroupBox.Name = "scenarioGroupBox";
            this.scenarioGroupBox.Size = new System.Drawing.Size(620, 222);
            this.scenarioGroupBox.TabIndex = 2;
            this.scenarioGroupBox.TabStop = false;
            this.scenarioGroupBox.Text = "Sizing Scenarios";
            //
            // chkBlockedOutlet
            //
            this.chkBlockedOutlet.AutoSize = true;
            this.chkBlockedOutlet.Checked = true;
            this.chkBlockedOutlet.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBlockedOutlet.Location = new System.Drawing.Point(20, 30);
            this.chkBlockedOutlet.Name = "chkBlockedOutlet";
            this.chkBlockedOutlet.Size = new System.Drawing.Size(139, 24);
            this.chkBlockedOutlet.TabIndex = 0;
            this.chkBlockedOutlet.Text = "Blocked Outlet";
            this.toolTip1.SetToolTip(this.chkBlockedOutlet, "Blocked Outlet (Single valve or full system blockage)");
            this.chkBlockedOutlet.UseVisualStyleBackColor = true;
            //
            // chkExternalFire
            //
            this.chkExternalFire.AutoSize = true;
            this.chkExternalFire.Location = new System.Drawing.Point(20, 60);
            this.chkExternalFire.Name = "chkExternalFire";
            this.chkExternalFire.Size = new System.Drawing.Size(250, 24);
            this.chkExternalFire.TabIndex = 1;
            this.chkExternalFire.Text = "Fire Case (Pool/Enclosed)";
            this.toolTip1.SetToolTip(this.chkExternalFire, "Fire Case (Open pool fire, enclosed fire)");
            this.chkExternalFire.UseVisualStyleBackColor = true;
            //
            // chkCoolingFailure
            //
            this.chkCoolingFailure.AutoSize = true;
            this.chkCoolingFailure.Location = new System.Drawing.Point(20, 90);
            this.chkCoolingFailure.Name = "chkCoolingFailure";
            this.chkCoolingFailure.Size = new System.Drawing.Size(140, 24);
            this.chkCoolingFailure.TabIndex = 2;
            this.chkCoolingFailure.Text = "Cooling Failure";
            this.chkCoolingFailure.UseVisualStyleBackColor = true;
            //
            // chkTubeRupture
            //
            this.chkTubeRupture.AutoSize = true;
            this.chkTubeRupture.Location = new System.Drawing.Point(20, 120);
            this.chkTubeRupture.Name = "chkTubeRupture";
            this.chkTubeRupture.Size = new System.Drawing.Size(242, 24);
            this.chkTubeRupture.TabIndex = 3;
            this.chkTubeRupture.Text = "Heat Exchanger Tube Rupture";
            this.chkTubeRupture.UseVisualStyleBackColor = true;
            //
            // chkChemicalReaction
            //
            this.chkChemicalReaction.AutoSize = true;
            this.chkChemicalReaction.Location = new System.Drawing.Point(20, 150);
            this.chkChemicalReaction.Name = "chkChemicalReaction";
            this.chkChemicalReaction.Size = new System.Drawing.Size(262, 24);
            this.chkChemicalReaction.TabIndex = 4;
            this.chkChemicalReaction.Text = "Chemical Reaction/Overpressure";
            this.toolTip1.SetToolTip(this.chkChemicalReaction, "Chemical Reaction/Overpressure (Runaway reactions)");
            this.chkChemicalReaction.UseVisualStyleBackColor = true;
            //
            // chkThermalExpansion
            //
            this.chkThermalExpansion.AutoSize = true;
            this.chkThermalExpansion.Location = new System.Drawing.Point(20, 180);
            this.chkThermalExpansion.Name = "chkThermalExpansion";
            this.chkThermalExpansion.Size = new System.Drawing.Size(174, 24);
            this.chkThermalExpansion.TabIndex = 5;
            this.chkThermalExpansion.Text = "Thermal Expansion";
            this.toolTip1.SetToolTip(this.chkThermalExpansion, "Thermal Expansion (Liquid-filled equipment heating)");
            this.chkThermalExpansion.UseVisualStyleBackColor = true;
            //
            // chkControlValveFailure
            //
            this.chkControlValveFailure.AutoSize = true;
            this.chkControlValveFailure.Location = new System.Drawing.Point(300, 30);
            this.chkControlValveFailure.Name = "chkControlValveFailure";
            this.chkControlValveFailure.Size = new System.Drawing.Size(191, 24);
            this.chkControlValveFailure.TabIndex = 6;
            this.chkControlValveFailure.Text = "Control Valve Failure";
            this.toolTip1.SetToolTip(this.chkControlValveFailure, "Control Valve Failure (Fail-open/closed, misoperation)");
            this.chkControlValveFailure.UseVisualStyleBackColor = true;
            //
            // chkPowerFailure
            //
            this.chkPowerFailure.AutoSize = true;
            this.chkPowerFailure.Location = new System.Drawing.Point(300, 60);
            this.chkPowerFailure.Name = "chkPowerFailure";
            this.chkPowerFailure.Size = new System.Drawing.Size(134, 24);
            this.chkPowerFailure.TabIndex = 7;
            this.chkPowerFailure.Text = "Power Failure";
            this.toolTip1.SetToolTip(this.chkPowerFailure, "Power Failure (Loss of utilities like cooling, reflux, etc.)");
            this.chkPowerFailure.UseVisualStyleBackColor = true;
            //
            // chkHydraulicHammer
            //
            this.chkHydraulicHammer.AutoSize = true;
            this.chkHydraulicHammer.Location = new System.Drawing.Point(300, 90);
            this.chkHydraulicHammer.Name = "chkHydraulicHammer";
            this.chkHydraulicHammer.Size = new System.Drawing.Size(269, 24);
            this.chkHydraulicHammer.TabIndex = 8;
            this.chkHydraulicHammer.Text = "Hydraulic Hammer/Water Hammer";
            this.chkHydraulicHammer.UseVisualStyleBackColor = true;
            //
            // chkRefluxFailure
            //
            this.chkRefluxFailure.AutoSize = true;
            this.chkRefluxFailure.Location = new System.Drawing.Point(300, 120);
            this.chkRefluxFailure.Name = "chkRefluxFailure";
            this.chkRefluxFailure.Size = new System.Drawing.Size(135, 24);
            this.chkRefluxFailure.TabIndex = 9;
            this.chkRefluxFailure.Text = "Reflux Failure";
            this.toolTip1.SetToolTip(this.chkRefluxFailure, "Reflux Failure (Distillation columns)");
            this.chkRefluxFailure.UseVisualStyleBackColor = true;
            //
            // chkCompressorFailure
            //
            this.chkCompressorFailure.AutoSize = true;
            this.chkCompressorFailure.Location = new System.Drawing.Point(300, 150);
            this.chkCompressorFailure.Name = "chkCompressorFailure";
            this.chkCompressorFailure.Size = new System.Drawing.Size(249, 24);
            this.chkCompressorFailure.TabIndex = 10;
            this.chkCompressorFailure.Text = "Compressor/Expander Failure";
            this.chkCompressorFailure.UseVisualStyleBackColor = true;
            //
            // vesselDesignGroupBox
            //
            this.vesselDesignGroupBox.Controls.Add(this.lblMAWP);
            this.vesselDesignGroupBox.Controls.Add(this.txtMAWP);
            this.vesselDesignGroupBox.Controls.Add(this.lblDesignTemp);
            this.vesselDesignGroupBox.Controls.Add(this.txtDesignTemp);
            this.vesselDesignGroupBox.Controls.Add(this.lblAccumulation);
            this.vesselDesignGroupBox.Controls.Add(this.cmbAccumulation);
            this.vesselDesignGroupBox.Controls.Add(this.lblFillLevel);
            this.vesselDesignGroupBox.Controls.Add(this.txtFillLevel);
            this.vesselDesignGroupBox.Controls.Add(this.lblVesselDiameter);
            this.vesselDesignGroupBox.Controls.Add(this.vesselDiameterInput);
            this.vesselDesignGroupBox.Controls.Add(this.lblVesselLength);
            this.vesselDesignGroupBox.Controls.Add(this.vesselLengthInput);
            this.vesselDesignGroupBox.Controls.Add(this.chkHorizontalVessel);
            this.vesselDesignGroupBox.Controls.Add(this.chkInsulated);
            this.vesselDesignGroupBox.Controls.Add(this.chkWaterSpray);
            this.vesselDesignGroupBox.Controls.Add(this.chkUnderground);
            this.vesselDesignGroupBox.Location = new System.Drawing.Point(3, 369);
            this.vesselDesignGroupBox.Name = "vesselDesignGroupBox";
            this.vesselDesignGroupBox.Size = new System.Drawing.Size(620, 300);
            this.vesselDesignGroupBox.TabIndex = 3;
            this.vesselDesignGroupBox.TabStop = false;
            this.vesselDesignGroupBox.Text = "Vessel Design Parameters";
            //
            // lblMAWP
            //
            this.lblMAWP.AutoSize = true;
            this.lblMAWP.Location = new System.Drawing.Point(20, 30);
            this.lblMAWP.Name = "lblMAWP";
            this.lblMAWP.Size = new System.Drawing.Size(105, 20);
            this.lblMAWP.TabIndex = 0;
            this.lblMAWP.Text = "MAWP (psig):";
            //
            // txtMAWP
            //
            this.txtMAWP.Location = new System.Drawing.Point(176, 26);
            this.txtMAWP.Name = "txtMAWP";
            this.txtMAWP.Size = new System.Drawing.Size(100, 26);
            this.txtMAWP.TabIndex = 1;
            this.txtMAWP.Text = "150";
            //
            // lblDesignTemp
            //
            this.lblDesignTemp.AutoSize = true;
            this.lblDesignTemp.Location = new System.Drawing.Point(20, 70);
            this.lblDesignTemp.Name = "lblDesignTemp";
            this.lblDesignTemp.Size = new System.Drawing.Size(136, 20);
            this.lblDesignTemp.TabIndex = 2;
            this.lblDesignTemp.Text = "Design Temp (°F):";
            //
            // txtDesignTemp
            //
            this.txtDesignTemp.Location = new System.Drawing.Point(176, 66);
            this.txtDesignTemp.Name = "txtDesignTemp";
            this.txtDesignTemp.Size = new System.Drawing.Size(100, 26);
            this.txtDesignTemp.TabIndex = 3;
            this.txtDesignTemp.Text = "300";
            //
            // lblAccumulation
            //
            this.lblAccumulation.AutoSize = true;
            this.lblAccumulation.Location = new System.Drawing.Point(20, 110);
            this.lblAccumulation.Name = "lblAccumulation";
            this.lblAccumulation.Size = new System.Drawing.Size(109, 20);
            this.lblAccumulation.TabIndex = 4;
            this.lblAccumulation.Text = "Accumulation:";
            //
            // cmbAccumulation
            //
            this.cmbAccumulation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccumulation.FormattingEnabled = true;
            this.cmbAccumulation.Items.AddRange(new object[] {
            "10% (Single PSV)",
            "16% (Multiple PSV)",
            "21% (Fire Case)"});
            this.cmbAccumulation.Location = new System.Drawing.Point(176, 106);
            this.cmbAccumulation.Name = "cmbAccumulation";
            this.cmbAccumulation.Size = new System.Drawing.Size(215, 28);
            this.cmbAccumulation.TabIndex = 5;
            //
            // lblFillLevel
            //
            this.lblFillLevel.AutoSize = true;
            this.lblFillLevel.Location = new System.Drawing.Point(20, 150);
            this.lblFillLevel.Name = "lblFillLevel";
            this.lblFillLevel.Size = new System.Drawing.Size(101, 20);
            this.lblFillLevel.TabIndex = 6;
            this.lblFillLevel.Text = "Fill Level (%):";
            //
            // txtFillLevel
            //
            this.txtFillLevel.Location = new System.Drawing.Point(176, 146);
            this.txtFillLevel.Name = "txtFillLevel";
            this.txtFillLevel.Size = new System.Drawing.Size(100, 26);
            this.txtFillLevel.TabIndex = 7;
            this.txtFillLevel.Text = "100";
            //
            // lblVesselDiameter
            //
            this.lblVesselDiameter.AutoSize = true;
            this.lblVesselDiameter.Location = new System.Drawing.Point(20, 190);
            this.lblVesselDiameter.Name = "lblVesselDiameter";
            this.lblVesselDiameter.Size = new System.Drawing.Size(154, 20);
            this.lblVesselDiameter.TabIndex = 8;
            this.lblVesselDiameter.Text = "Vessel Diameter (ft):";
            //
            // vesselDiameterInput
            //
            this.vesselDiameterInput.Location = new System.Drawing.Point(180, 187);
            this.vesselDiameterInput.Name = "vesselDiameterInput";
            this.vesselDiameterInput.Size = new System.Drawing.Size(70, 26);
            this.vesselDiameterInput.TabIndex = 9;
            this.vesselDiameterInput.Text = "10";
            //
            // lblVesselLength
            //
            this.lblVesselLength.AutoSize = true;
            this.lblVesselLength.Location = new System.Drawing.Point(20, 230);
            this.lblVesselLength.Name = "lblVesselLength";
            this.lblVesselLength.Size = new System.Drawing.Size(139, 20);
            this.lblVesselLength.TabIndex = 10;
            this.lblVesselLength.Text = "Vessel Length (ft):";
            //
            // vesselLengthInput
            //
            this.vesselLengthInput.Location = new System.Drawing.Point(180, 227);
            this.vesselLengthInput.Name = "vesselLengthInput";
            this.vesselLengthInput.Size = new System.Drawing.Size(70, 26);
            this.vesselLengthInput.TabIndex = 11;
            this.vesselLengthInput.Text = "20";
            //
            // chkHorizontalVessel
            //
            this.chkHorizontalVessel.AutoSize = true;
            this.chkHorizontalVessel.Location = new System.Drawing.Point(430, 190);
            this.chkHorizontalVessel.Name = "chkHorizontalVessel";
            this.chkHorizontalVessel.Size = new System.Drawing.Size(159, 24);
            this.chkHorizontalVessel.TabIndex = 12;
            this.chkHorizontalVessel.Text = "Horizontal Vessel";
            this.chkHorizontalVessel.UseVisualStyleBackColor = true;
            //
            // chkInsulated
            //
            this.chkInsulated.AutoSize = true;
            this.chkInsulated.Location = new System.Drawing.Point(430, 70);
            this.chkInsulated.Name = "chkInsulated";
            this.chkInsulated.Size = new System.Drawing.Size(101, 24);
            this.chkInsulated.TabIndex = 13;
            this.chkInsulated.Text = "Insulated";
            this.chkInsulated.UseVisualStyleBackColor = true;
            //
            // chkWaterSpray
            //
            this.chkWaterSpray.AutoSize = true;
            this.chkWaterSpray.Location = new System.Drawing.Point(430, 110);
            this.chkWaterSpray.Name = "chkWaterSpray";
            this.chkWaterSpray.Size = new System.Drawing.Size(123, 24);
            this.chkWaterSpray.TabIndex = 14;
            this.chkWaterSpray.Text = "Water Spray";
            this.chkWaterSpray.UseVisualStyleBackColor = true;
            //
            // chkUnderground
            //
            this.chkUnderground.AutoSize = true;
            this.chkUnderground.Location = new System.Drawing.Point(430, 150);
            this.chkUnderground.Name = "chkUnderground";
            this.chkUnderground.Size = new System.Drawing.Size(129, 24);
            this.chkUnderground.TabIndex = 15;
            this.chkUnderground.Text = "Underground";
            this.chkUnderground.UseVisualStyleBackColor = true;
            //
            // inputGroupBox
            //
            this.inputGroupBox.Controls.Add(this.lblPressure);
            this.inputGroupBox.Controls.Add(this.pressureInput);
            this.inputGroupBox.Controls.Add(this.lblTemperature);
            this.inputGroupBox.Controls.Add(this.temperatureInput);
            this.inputGroupBox.Controls.Add(this.lblFlowRate);
            this.inputGroupBox.Controls.Add(this.flowRateInput);
            this.inputGroupBox.Controls.Add(this.lblMolecularWeight);
            this.inputGroupBox.Controls.Add(this.molecularWeightInput);
            this.inputGroupBox.Controls.Add(this.lblSpecificHeatRatio);
            this.inputGroupBox.Controls.Add(this.specificHeatRatioInput);
            this.inputGroupBox.Controls.Add(this.lblCompressibility);
            this.inputGroupBox.Controls.Add(this.compressibilityInput);
            this.inputGroupBox.Controls.Add(this.lblViscosity);
            this.inputGroupBox.Controls.Add(this.viscosityInput);
            this.inputGroupBox.Controls.Add(this.lblSpecificGravity);
            this.inputGroupBox.Controls.Add(this.specificGravityInput);
            this.inputGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputGroupBox.Location = new System.Drawing.Point(703, 3);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(462, 715);
            this.inputGroupBox.TabIndex = 1;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input Parameters";
            //
            // lblPressure
            //
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(20, 30);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(114, 20);
            this.lblPressure.TabIndex = 0;
            this.lblPressure.Text = "Pressure psig):";
            //
            // pressureInput
            //
            this.pressureInput.Location = new System.Drawing.Point(274, 32);
            this.pressureInput.Name = "pressureInput";
            this.pressureInput.Size = new System.Drawing.Size(100, 26);
            this.pressureInput.TabIndex = 1;
            this.pressureInput.Text = "100";
            //
            // lblTemperature
            //
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(20, 70);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(133, 20);
            this.lblTemperature.TabIndex = 2;
            this.lblTemperature.Text = "Temperature (°F):";
            //
            // temperatureInput
            //
            this.temperatureInput.Location = new System.Drawing.Point(274, 72);
            this.temperatureInput.Name = "temperatureInput";
            this.temperatureInput.Size = new System.Drawing.Size(100, 26);
            this.temperatureInput.TabIndex = 3;
            this.temperatureInput.Text = "60";
            //
            // lblFlowRate
            //
            this.lblFlowRate.AutoSize = true;
            this.lblFlowRate.Location = new System.Drawing.Point(20, 110);
            this.lblFlowRate.Name = "lblFlowRate";
            this.lblFlowRate.Size = new System.Drawing.Size(85, 20);
            this.lblFlowRate.TabIndex = 4;
            this.lblFlowRate.Text = "Flow Rate:";
            //
            // flowRateInput
            //
            this.flowRateInput.Location = new System.Drawing.Point(274, 112);
            this.flowRateInput.Name = "flowRateInput";
            this.flowRateInput.Size = new System.Drawing.Size(100, 26);
            this.flowRateInput.TabIndex = 5;
            this.flowRateInput.Text = "500";
            //
            // lblMolecularWeight
            //
            this.lblMolecularWeight.AutoSize = true;
            this.lblMolecularWeight.Location = new System.Drawing.Point(20, 150);
            this.lblMolecularWeight.Name = "lblMolecularWeight";
            this.lblMolecularWeight.Size = new System.Drawing.Size(187, 20);
            this.lblMolecularWeight.TabIndex = 6;
            this.lblMolecularWeight.Text = "Molecular Weight (g/mol):";
            //
            // molecularWeightInput
            //
            this.molecularWeightInput.Location = new System.Drawing.Point(274, 152);
            this.molecularWeightInput.Name = "molecularWeightInput";
            this.molecularWeightInput.Size = new System.Drawing.Size(100, 26);
            this.molecularWeightInput.TabIndex = 7;
            this.molecularWeightInput.Text = "28.97";
            //
            // lblSpecificHeatRatio
            //
            this.lblSpecificHeatRatio.AutoSize = true;
            this.lblSpecificHeatRatio.Location = new System.Drawing.Point(20, 190);
            this.lblSpecificHeatRatio.Name = "lblSpecificHeatRatio";
            this.lblSpecificHeatRatio.Size = new System.Drawing.Size(223, 20);
            this.lblSpecificHeatRatio.TabIndex = 8;
            this.lblSpecificHeatRatio.Text = "Specific Heat Ratio (k=Cp/Cv):";
            //
            // specificHeatRatioInput
            //
            this.specificHeatRatioInput.Location = new System.Drawing.Point(274, 192);
            this.specificHeatRatioInput.Name = "specificHeatRatioInput";
            this.specificHeatRatioInput.Size = new System.Drawing.Size(100, 26);
            this.specificHeatRatioInput.TabIndex = 9;
            this.specificHeatRatioInput.Text = "1.4";
            //
            // lblCompressibility
            //
            this.lblCompressibility.AutoSize = true;
            this.lblCompressibility.Location = new System.Drawing.Point(20, 230);
            this.lblCompressibility.Name = "lblCompressibility";
            this.lblCompressibility.Size = new System.Drawing.Size(192, 20);
            this.lblCompressibility.TabIndex = 10;
            this.lblCompressibility.Text = "Compressibility Factor (Z):";
            //
            // compressibilityInput
            //
            this.compressibilityInput.Location = new System.Drawing.Point(274, 232);
            this.compressibilityInput.Name = "compressibilityInput";
            this.compressibilityInput.Size = new System.Drawing.Size(100, 26);
            this.compressibilityInput.TabIndex = 11;
            this.compressibilityInput.Text = "1.0";
            //
            // lblViscosity
            //
            this.lblViscosity.AutoSize = true;
            this.lblViscosity.Location = new System.Drawing.Point(20, 270);
            this.lblViscosity.Name = "lblViscosity";
            this.lblViscosity.Size = new System.Drawing.Size(107, 20);
            this.lblViscosity.TabIndex = 12;
            this.lblViscosity.Text = "Viscosity (cP):";
            //
            // viscosityInput
            //
            this.viscosityInput.Location = new System.Drawing.Point(274, 272);
            this.viscosityInput.Name = "viscosityInput";
            this.viscosityInput.Size = new System.Drawing.Size(100, 26);
            this.viscosityInput.TabIndex = 13;
            this.viscosityInput.Text = "1.0";
            //
            // lblSpecificGravity
            //
            this.lblSpecificGravity.AutoSize = true;
            this.lblSpecificGravity.Location = new System.Drawing.Point(20, 310);
            this.lblSpecificGravity.Name = "lblSpecificGravity";
            this.lblSpecificGravity.Size = new System.Drawing.Size(160, 20);
            this.lblSpecificGravity.TabIndex = 14;
            this.lblSpecificGravity.Text = "Specific Gravity (SG):";
            //
            // specificGravityInput
            //
            this.specificGravityInput.Location = new System.Drawing.Point(274, 312);
            this.specificGravityInput.Name = "specificGravityInput";
            this.specificGravityInput.Size = new System.Drawing.Size(100, 26);
            this.specificGravityInput.TabIndex = 15;
            this.specificGravityInput.Text = "1.0";
            //
            // resultsDataGridView
            //
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colScenario,
            this.colFlowRate,
            this.colArea,
            this.colOrificeSize});
            this.resultsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsDataGridView.Location = new System.Drawing.Point(3, 724);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.ReadOnly = true;
            this.resultsDataGridView.RowHeadersVisible = false;
            this.resultsDataGridView.RowHeadersWidth = 62;
            this.resultsDataGridView.RowTemplate.Height = 28;
            this.resultsDataGridView.Size = new System.Drawing.Size(694, 304);
            this.resultsDataGridView.TabIndex = 2;
            //
            // colScenario
            //
            this.colScenario.HeaderText = "Scenario";
            this.colScenario.MinimumWidth = 8;
            this.colScenario.Name = "colScenario";
            this.colScenario.ReadOnly = true;
            this.colScenario.Width = 150;
            //
            // colFlowRate
            //
            this.colFlowRate.HeaderText = "Flow Rate";
            this.colFlowRate.MinimumWidth = 8;
            this.colFlowRate.Name = "colFlowRate";
            this.colFlowRate.ReadOnly = true;
            this.colFlowRate.Width = 150;
            //
            // colArea
            //
            this.colArea.HeaderText = "Area (in²)";
            this.colArea.MinimumWidth = 8;
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            this.colArea.Width = 150;
            //
            // colOrificeSize
            //
            this.colOrificeSize.HeaderText = "Orifice Size";
            this.colOrificeSize.MinimumWidth = 8;
            this.colOrificeSize.Name = "colOrificeSize";
            this.colOrificeSize.ReadOnly = true;
            this.colOrificeSize.Width = 150;
            //
            // buttonsPanel
            //
            this.buttonsPanel.Controls.Add(this.btnExcelExport);
            this.buttonsPanel.Controls.Add(this.btnCalculate);
            this.buttonsPanel.Controls.Add(this.autoCalculateCheckBox);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsPanel.Location = new System.Drawing.Point(703, 724);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(462, 304);
            this.buttonsPanel.TabIndex = 3;
            //
            // btnExcelExport
            //
            this.btnExcelExport.Location = new System.Drawing.Point(20, 60);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(150, 40);
            this.btnExcelExport.TabIndex = 1;
            this.btnExcelExport.Text = "Export to Excel";
            this.btnExcelExport.UseVisualStyleBackColor = true;
            //
            // btnCalculate
            //
            this.btnCalculate.Location = new System.Drawing.Point(20, 10);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 40);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            //
            // autoCalculateCheckBox
            //
            this.autoCalculateCheckBox.AutoSize = true;
            this.autoCalculateCheckBox.Location = new System.Drawing.Point(24, 122);
            this.autoCalculateCheckBox.Name = "autoCalculateCheckBox";
            this.autoCalculateCheckBox.Size = new System.Drawing.Size(140, 24);
            this.autoCalculateCheckBox.TabIndex = 2;
            this.autoCalculateCheckBox.Text = "Auto-Calculate";
            this.autoCalculateCheckBox.UseVisualStyleBackColor = true;
            //
            // lblVesselOrientation
            //
            this.lblVesselOrientation.AutoSize = true;
            this.lblVesselOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVesselOrientation.Location = new System.Drawing.Point(426, 30);
            this.lblVesselOrientation.Name = "lblVesselOrientation";
            this.lblVesselOrientation.Size = new System.Drawing.Size(103, 20);
            this.lblVesselOrientation.TabIndex = 16;
            this.lblVesselOrientation.Text = "Orientation:";
            //
            // PSVSizingForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 1031);
            this.Controls.Add(this.mainTableLayout);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "PSVSizingForm";
            this.Text = "PSV Sizing Calculator";
            this.mainTableLayout.ResumeLayout(false);
            this.leftFlowPanel.ResumeLayout(false);
            this.leftFlowPanel.PerformLayout();
            this.psvConfigGroupBox.ResumeLayout(false);
            this.psvConfigGroupBox.PerformLayout();
            this.scenarioGroupBox.ResumeLayout(false);
            this.scenarioGroupBox.PerformLayout();
            this.vesselDesignGroupBox.ResumeLayout(false);
            this.vesselDesignGroupBox.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.buttonsPanel.ResumeLayout(false);
            this.buttonsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayout;
        private System.Windows.Forms.FlowLayoutPanel leftFlowPanel;
        private System.Windows.Forms.GroupBox psvConfigGroupBox;
        internal System.Windows.Forms.RadioButton radSinglePSV;
        internal System.Windows.Forms.RadioButton radMultiplePSV;
        internal System.Windows.Forms.CheckBox chkFireCase;
        internal System.Windows.Forms.ComboBox fluidTypeCombo;
        internal System.Windows.Forms.GroupBox scenarioGroupBox;
        internal System.Windows.Forms.CheckBox chkBlockedOutlet;
        internal System.Windows.Forms.CheckBox chkExternalFire;
        internal System.Windows.Forms.CheckBox chkCoolingFailure;
        internal System.Windows.Forms.CheckBox chkTubeRupture;
        internal System.Windows.Forms.CheckBox chkChemicalReaction;
        internal System.Windows.Forms.CheckBox chkThermalExpansion;
        internal System.Windows.Forms.CheckBox chkControlValveFailure;
        internal System.Windows.Forms.CheckBox chkPowerFailure;
        internal System.Windows.Forms.CheckBox chkHydraulicHammer;
        internal System.Windows.Forms.CheckBox chkRefluxFailure;
        internal System.Windows.Forms.CheckBox chkCompressorFailure;
        private System.Windows.Forms.GroupBox vesselDesignGroupBox;
        private System.Windows.Forms.Label lblMAWP;
        internal System.Windows.Forms.TextBox txtMAWP;
        private System.Windows.Forms.Label lblDesignTemp;
        internal System.Windows.Forms.TextBox txtDesignTemp;
        private System.Windows.Forms.Label lblAccumulation;
        internal System.Windows.Forms.ComboBox cmbAccumulation;
        private System.Windows.Forms.Label lblFillLevel;
        internal System.Windows.Forms.TextBox txtFillLevel;
        internal System.Windows.Forms.Label lblVesselDiameter;
        internal System.Windows.Forms.TextBox vesselDiameterInput;
        internal System.Windows.Forms.Label lblVesselLength;
        internal System.Windows.Forms.TextBox vesselLengthInput;
        internal System.Windows.Forms.CheckBox chkHorizontalVessel;
        internal System.Windows.Forms.CheckBox chkInsulated;
        internal System.Windows.Forms.CheckBox chkWaterSpray;
        internal System.Windows.Forms.CheckBox chkUnderground;
        internal System.Windows.Forms.Label lblVesselOrientation;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Label lblPressure;
        internal System.Windows.Forms.TextBox pressureInput;
        private System.Windows.Forms.Label lblTemperature;
        internal System.Windows.Forms.TextBox temperatureInput;
        internal System.Windows.Forms.Label lblFlowRate;
        internal System.Windows.Forms.TextBox flowRateInput;
        internal System.Windows.Forms.Label lblMolecularWeight;
        internal System.Windows.Forms.TextBox molecularWeightInput;
        internal System.Windows.Forms.Label lblSpecificHeatRatio;
        internal System.Windows.Forms.TextBox specificHeatRatioInput;
        internal System.Windows.Forms.Label lblCompressibility;
        internal System.Windows.Forms.TextBox compressibilityInput;
        internal System.Windows.Forms.Label lblViscosity;
        internal System.Windows.Forms.TextBox viscosityInput;
        internal System.Windows.Forms.Label lblSpecificGravity;
        internal System.Windows.Forms.TextBox specificGravityInput;
        internal System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScenario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFlowRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrificeSize;
        private System.Windows.Forms.Panel buttonsPanel;
        internal System.Windows.Forms.Button btnExcelExport;
        internal System.Windows.Forms.Button btnCalculate;
        internal System.Windows.Forms.CheckBox autoCalculateCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Label lblFluidType;
    }
}