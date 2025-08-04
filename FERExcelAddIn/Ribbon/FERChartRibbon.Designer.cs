using Microsoft.Office.Tools.Ribbon;

namespace FERExcelAddIn
{
    partial class FERChartRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public FERChartRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.btnShowThicknessForm = this.Factory.CreateRibbonButton();
            this.btnShowLWNForm = this.Factory.CreateRibbonButton();
            this.btnShowBoltInfoForm = this.Factory.CreateRibbonButton();
            this.btnShowCorrosionRateForm = this.Factory.CreateRibbonButton();
            this.btnShowPipeWeightCalculator = this.Factory.CreateRibbonButton();
            this.btnShowConversionForm = this.Factory.CreateRibbonButton();
            this.btnShowThermalExpansionForm = this.Factory.CreateRibbonButton();
            this.btnShowPCC1Form = this.Factory.CreateRibbonButton();
            this.btnShowBoltLoadCalc = this.Factory.CreateRibbonButton();
            this.btnShowGasketSelector = this.Factory.CreateRibbonButton();
            this.btnShowAPI571 = this.Factory.CreateRibbonButton();
            this.btnShowAPI510ExemptionEval = this.Factory.CreateRibbonButton();
            this.btnCUIAssessment = this.Factory.CreateRibbonButton();
            this.btnB313Calcs = this.Factory.CreateRibbonButton();
            this.btnShowHTHAForm = this.Factory.CreateRibbonButton();
            this.btnShowB313Form = this.Factory.CreateRibbonButton();
            this.btnShowInsulationTool = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.btnOpenGanttChart = this.Factory.CreateRibbonButton();
            this.btnOpenPCMSPCodeSearchForm = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.btnPSVSizing = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Label = "FER Tools";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.btnShowThicknessForm);
            this.group1.Items.Add(this.btnShowLWNForm);
            this.group1.Items.Add(this.btnShowBoltInfoForm);
            this.group1.Items.Add(this.btnShowCorrosionRateForm);
            this.group1.Items.Add(this.btnShowPipeWeightCalculator);
            this.group1.Items.Add(this.btnShowConversionForm);
            this.group1.Items.Add(this.btnShowThermalExpansionForm);
            this.group1.Items.Add(this.btnShowPCC1Form);
            this.group1.Items.Add(this.btnShowBoltLoadCalc);
            this.group1.Items.Add(this.btnShowGasketSelector);
            this.group1.Items.Add(this.btnShowAPI571);
            this.group1.Items.Add(this.btnShowAPI510ExemptionEval);
            this.group1.Items.Add(this.btnCUIAssessment);
            this.group1.Items.Add(this.btnB313Calcs);
            this.group1.Items.Add(this.btnShowHTHAForm);
            this.group1.Items.Add(this.btnShowB313Form);
            this.group1.Items.Add(this.btnShowInsulationTool);
            this.group1.Label = "Userforms";
            this.group1.Name = "group1";
            // 
            // btnShowThicknessForm
            // 
            this.btnShowThicknessForm.Label = "NPS Lookup";
            this.btnShowThicknessForm.Name = "btnShowThicknessForm";
            this.btnShowThicknessForm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowThicknessForm_Click);
            // 
            // btnShowLWNForm
            // 
            this.btnShowLWNForm.Label = "LWN Lookup";
            this.btnShowLWNForm.Name = "btnShowLWNForm";
            this.btnShowLWNForm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowLWNForm_Click);
            // 
            // btnShowBoltInfoForm
            // 
            this.btnShowBoltInfoForm.Label = "Flange / Bolt Info";
            this.btnShowBoltInfoForm.Name = "btnShowBoltInfoForm";
            this.btnShowBoltInfoForm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowBoltInfoForm_Click);
            // 
            // btnShowCorrosionRateForm
            // 
            this.btnShowCorrosionRateForm.Label = "Corrosion Rate Calc";
            this.btnShowCorrosionRateForm.Name = "btnShowCorrosionRateForm";
            this.btnShowCorrosionRateForm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowCorrosionRateForm_Click);
            // 
            // btnShowPipeWeightCalculator
            // 
            this.btnShowPipeWeightCalculator.Label = "Pipe Weight";
            this.btnShowPipeWeightCalculator.Name = "btnShowPipeWeightCalculator";
            this.btnShowPipeWeightCalculator.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowPipeWeightCalculator_Click);
            // 
            // btnShowConversionForm
            // 
            this.btnShowConversionForm.Label = "Unit Conversions";
            this.btnShowConversionForm.Name = "btnShowConversionForm";
            this.btnShowConversionForm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowConversionForm_Click);
            // 
            // btnShowThermalExpansionForm
            // 
            this.btnShowThermalExpansionForm.Label = "Thermal Expansion";
            this.btnShowThermalExpansionForm.Name = "btnShowThermalExpansionForm";
            this.btnShowThermalExpansionForm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnThermalExpansion_Click);
            // 
            // btnShowPCC1Form
            // 
            this.btnShowPCC1Form.Label = "PCC-1 Flange Calc";
            this.btnShowPCC1Form.Name = "btnShowPCC1Form";
            this.btnShowPCC1Form.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowPCC1Form_Click);
            // 
            // btnShowBoltLoadCalc
            // 
            this.btnShowBoltLoadCalc.Label = "PCC-1 Bolt Load Calc";
            this.btnShowBoltLoadCalc.Name = "btnShowBoltLoadCalc";
            this.btnShowBoltLoadCalc.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowBoltLoadCalc_Click);
            // 
            // btnShowGasketSelector
            // 
            this.btnShowGasketSelector.Label = "Gasket Selector";
            this.btnShowGasketSelector.Name = "btnShowGasketSelector";
            this.btnShowGasketSelector.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowGasketSelector_Click);
            // 
            // btnShowAPI571
            // 
            this.btnShowAPI571.Label = "API 571 Quick Reference";
            this.btnShowAPI571.Name = "btnShowAPI571";
            this.btnShowAPI571.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowAPI571_Click);
            // 
            // btnShowAPI510ExemptionEval
            // 
            this.btnShowAPI510ExemptionEval.Label = "API 510 Exemption Eval.";
            this.btnShowAPI510ExemptionEval.Name = "btnShowAPI510ExemptionEval";
            this.btnShowAPI510ExemptionEval.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowAPI510ExemptionEval_Click);
            // 
            // btnCUIAssessment
            // 
            this.btnCUIAssessment.Label = "CUI/CUF Assessment";
            this.btnCUIAssessment.Name = "btnCUIAssessment";
            this.btnCUIAssessment.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnCUIAssessment_Click);
            // 
            // btnB313Calcs
            // 
            this.btnB313Calcs.Label = "ASME B13.3 Calcs";
            this.btnB313Calcs.Name = "btnB313Calcs";
            this.btnB313Calcs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnB313Calcs_Click);
            // 
            // btnShowHTHAForm
            // 
            this.btnShowHTHAForm.Label = "HTHA Checker";
            this.btnShowHTHAForm.Name = "btnShowHTHAForm";
            this.btnShowHTHAForm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowHTHAForm_Click);
            // 
            // btnShowB313Form
            // 
            this.btnShowB313Form.Label = "";
            this.btnShowB313Form.Name = "btnShowB313Form";
            // 
            // btnShowInsulationTool
            // 
            this.btnShowInsulationTool.Label = "";
            this.btnShowInsulationTool.Name = "btnShowInsulationTool";
            // 
            // group2
            // 
            this.group2.Items.Add(this.btnOpenGanttChart);
            this.group2.Items.Add(this.btnOpenPCMSPCodeSearchForm);
            this.group2.Label = "Workbooks";
            this.group2.Name = "group2";
            // 
            // btnOpenGanttChart
            // 
            this.btnOpenGanttChart.Label = "Gantt Chart Template";
            this.btnOpenGanttChart.Name = "btnOpenGanttChart";
            this.btnOpenGanttChart.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnOpenGanttChart_Click);
            // 
            // btnOpenPCMSPCodeSearchForm
            // 
            this.btnOpenPCMSPCodeSearchForm.Label = "PCMS P-Code Search";
            this.btnOpenPCMSPCodeSearchForm.Name = "btnOpenPCMSPCodeSearchForm";
            this.btnOpenPCMSPCodeSearchForm.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnOpenPCMSPCodeSearchForm_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.btnPSVSizing);
            this.group3.Name = "group3";
            // 
            // btnPSVSizing
            // 
            this.btnPSVSizing.Label = "PSV Sizing";
            this.btnPSVSizing.Name = "btnPSVSizing";
            this.btnPSVSizing.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnPSVSizing_Click_1);
            // 
            // FERChartRibbon
            // 
            this.Name = "FERChartRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.FERChartRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowThicknessForm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowLWNForm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowBoltInfoForm;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowConversionForm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowPipeWeightCalculator;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowThermalExpansionForm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowCorrosionRateForm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowGasketSelector;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowPCC1Form;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnOpenGanttChart;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnOpenPCMSPCodeSearchForm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowHTHAForm;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowInsulationTool;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnShowBoltLoadCalc;
        internal RibbonButton btnShowAPI571;
        internal RibbonButton btnShowAPI510ExemptionEval;
        internal RibbonButton btnCUIAssessment;
        internal RibbonButton btnShowB313Form;
        internal RibbonButton btnB313Calcs;
        internal RibbonButton btnPSVSizing;
    }
}