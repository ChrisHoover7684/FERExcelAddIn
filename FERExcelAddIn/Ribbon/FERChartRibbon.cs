using CorrosionRateCalculator;
using FERExcelAddin;
using Microsoft.Office.Tools.Ribbon;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FERExcelAddIn
{
    public partial class FERChartRibbon
    {
        private void FERChartRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            
        }
       
        private void btnOpenGanttChart_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                using (Stream templateStream = Globals.ThisAddIn.GetGanttTemplateStream())
                {
                    if (templateStream == null)
                    {
                        // Show detailed error with available resources
                        var assembly = Assembly.GetExecutingAssembly();
                        string[] resources = assembly.GetManifestResourceNames();

                        MessageBox.Show($"Gantt chart template not found.\n\n" +
                                      $"Available resources:\n{string.Join("\n", resources)}\n\n" +
                                      $"Looking for: FERExcelAddIn.Gantt-Chart-Template.xlsx",
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return;
                    }

                    // Create temp file path
                    string tempPath = Path.Combine(Path.GetTempPath(), "Gantt-Chart-Template.xlsx");

                    // Save to temp file
                    using (var fileStream = File.Create(tempPath))
                    {
                        templateStream.CopyTo(fileStream);
                    }

                    // Open in Excel
                    Excel.Application excelApp = Globals.ThisAddIn.Application;
                    Excel.Workbook workbook = excelApp.Workbooks.Open(tempPath);

                    // Clean up when workbook closes
                    workbook.BeforeClose += (ref bool cancel) =>
                    {
                        try { File.Delete(tempPath); }
                        catch { /* Ignore deletion errors */ }
                    };

                    excelApp.Visible = true;
                    Marshal.ReleaseComObject(workbook);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening Gantt chart: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void btnShowThicknessForm_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm<NominalThicknessForm>("Nominal Thickness Calculator");
        }
        private void btnShowAPI571_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm<API571Form>("API 571 Quick Reference");
        }

        private void btnPSVSizing_Click_1(object sender, RibbonControlEventArgs e)

        {
            ShowForm<PSVSizingForm>("PSV Sizing Calculator");
        }


        private void btnShowLWNForm_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm<LWNForm>("LWN Calculator");
        }

        private void btnShowBoltInfoForm_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm<BoltInfoForm>("Bolt Information");
        }
      
        private void btnShowPCC1Form_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm<FlangeCalculatorForm>("PCC-1 Calculator");
        }
        private void btnShowBoltLoadCalc_Click(object sender, RibbonControlEventArgs e)
        {
          
            FlangeBoltLoadCalculatorForm boltLoadForm = new FlangeBoltLoadCalculatorForm();
            boltLoadForm.Show();
        }

        private void btnShowConversionForm_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm<MultiPageConverterForm>("Unit Converter");
        }
        private void btnShowHTHAForm_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm<HTHACheckerForm>("HTHA Checker"); 
        }

        private void btnShowPipeWeightCalculator_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm<PipeWeightCalculatorForm>("Pipe Weight Calculator");
        }

        private void btnShowAPI510ExemptionEval_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm<API510ExemptionEvaluator>("API 510 Exemption Evaluator");
        }

        private void btnShowGasketSelector_Click(object sender, RibbonControlEventArgs e)
        {
            var form = new frmGasketSelector();
            form.Show();
        }

        private void btnThermalExpansion_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm<ThermalExpansionForm>("Pipe Thermal Expansion Calculator");
        }

        private void btnCUIAssessment_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                // Change CUIRiskAssessmentForm to CUIAssessmentForm
                ShowForm<CUIAssessmentForm>("CUI Risk Assessment");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening CUI Risk Assessment: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
        private void btnOpenPCMSPCodeSearchForm_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                // Get the embedded resource stream
                using (Stream resourceStream = Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream("FERExcelAddIn.Resources.PCMS P-Codes.xlsx"))
                {
                    if (resourceStream == null)
                    {
                        // Debugging help - show available resources
                        var assembly = Assembly.GetExecutingAssembly();
                        string[] resources = assembly.GetManifestResourceNames();

                        MessageBox.Show($"PCMS P-Codes file not found.\n\n" +
                                      $"Available resources:\n{string.Join("\n", resources)}\n\n" +
                                      $"Looking for: FERExcelAddIn.PCMS P-Codes.xlsx",
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                        return;
                    }

                    // Create temp file path
                    string tempPath = Path.Combine(Path.GetTempPath(), "PCMS P-Codes.xlsx");

                    // Save to temp file
                    using (var fileStream = File.Create(tempPath))
                    {
                        resourceStream.CopyTo(fileStream);
                    }

                    // Open in Excel
                    Excel.Application excelApp = Globals.ThisAddIn.Application;
                    Excel.Workbook workbook = excelApp.Workbooks.Open(tempPath);

                    // Clean up when workbook closes
                    workbook.BeforeClose += (ref bool cancel) =>
                    {
                        try { File.Delete(tempPath); }
                        catch { /* Ignore deletion errors */ }
                    };

                    excelApp.Visible = true;
                    Marshal.ReleaseComObject(workbook);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening PCMS P-Codes: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void btnShowCorrosionRateForm_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                CorrosionRateForm form = new CorrosionRateForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnB313Calcs_Click(object sender, RibbonControlEventArgs e)
        {
            ShowForm<B31_3PipeCalculator>("ASME B31.3 Pipe Calculator");
        }


        private void ShowForm<T>(string formTitle, bool modal = false) where T : Form, new()
        {
            try
            {
                var form = new T();
                if (modal)
                    form.ShowDialog();
                else
                {
                    form.Show();
                    form.TopMost = true;  // Ensure form stays on top
                    form.Activate();
                    form.TopMost = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening {formTitle}: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        
    }
}