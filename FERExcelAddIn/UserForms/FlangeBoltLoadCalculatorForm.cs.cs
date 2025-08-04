using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FERExcelAddIn
{
    public partial class FlangeBoltLoadCalculatorForm : Form
    {
        // ========================
        // 1. Configuration Constants
        // ========================
        private static class Constants
        {
            public static string[] FlangeSizes = { "0.5", "0.75", "1", "1.5", "2", "3", "4", "6", "8", "10", "12", "14", "16", "18", "20", "24" };
            public static string[] FlangeClasses = { "150", "300", "400", "600", "900", "1500", "2500" };
            public static string[] BoltGrades =
            {
                "A193 B7", "A193 B7M", "A193 B8", "A193 B8M", "A193 B16",
                "A320 L7", "A320 L7M", "A320 B8", "A320 B8M",
                "A453 660", "A453 651",
                "A307 B", "A307 C",
                "A490", "A325",
                "F1554 Gr. 36", "F1554 Gr. 55", "F1554 Gr. 105",
                "A354 BC", "A354 BD",
                "A449"
            };
            public static string[] BoltSizes =
           {
                // Imperial
                "0.25", "0.3125", "0.375", "0.4375", "0.5", "0.5625", "0.625",
                "0.75", "0.875", "1", "1.125", "1.25", "1.375", "1.5", "1.75",
                "2", "2.25", "2.5", "2.75", "3", "3.5", "4",
                // Metric
                "M6", "M8", "M10", "M12", "M14", "M16", "M18",
                "M20", "M22", "M24", "M27", "M30", "M36"
            };
            public static string[] LubricationTypes = {
        "Dry (Unlubricated, K=0.20)",
        "Moly Paste (K=0.12)",
        "Anti-Seize (K=0.14)",
        "Teflon-Coated (K=0.06)",
        "Wax-Based (K=0.10)",
        "Graphite (K=0.15)",
        "Copper-Based (K=0.13)"
    };
        }

        // ========================
        // 2. Data Structures
        // ========================
        private class BoltSpecs
        {
            public double TensileArea { get; }
            public double YieldStrength { get; }

            public BoltSpecs(double tensileArea, double yieldStrength)
            {
                TensileArea = tensileArea;
                YieldStrength = yieldStrength;
            }
        }

        // ========================
        // 3. Application State
        // ========================
        private readonly Dictionary<string, Dictionary<string, BoltSpecs>> _boltData = new Dictionary<string, Dictionary<string, BoltSpecs>>();
        private readonly Dictionary<string, double> _pcc1DefaultStresses = new Dictionary<string, double>()
        {
            {"A193 B7", 50}, {"A193 B7M", 45}, {"A193 B8", 40}, {"A193 B8M", 40}, {"A193 B16", 45},
            {"A320 L7", 45}, {"A320 L7M", 40}, {"A320 B8", 35}, {"A320 B8M", 35},
            {"A453 660", 40}, {"A453 651", 40},
            {"A307 B", 40}, {"A307 C", 45},
            {"A490", 50}, {"A325", 45},
            {"F1554 Gr. 36", 40}, {"F1554 Gr. 55", 45}, {"F1554 Gr. 105", 50},
            {"A354 BC", 45}, {"A354 BD", 50},
            {"A449", 45}
        };

        private readonly ToolTip _toolTip = new ToolTip();

        // ========================
        // 4. Main Form Implementation
        // ========================
        public FlangeBoltLoadCalculatorForm()
        {
            InitializeComponent();
            InitializeBoltData();
            InitializeForm();
        }


        private void InitializeBoltData()
        {
            // ASME SA-193 B7 (Complete range per ASME B18.2.1)
            AddBoltSpec("A193 B7", "0.25", 0.0318, 105000);
            AddBoltSpec("A193 B7", "0.3125", 0.0524, 105000);
            AddBoltSpec("A193 B7", "0.375", 0.0775, 105000);
            AddBoltSpec("A193 B7", "0.4375", 0.1063, 105000);
            AddBoltSpec("A193 B7", "0.5", 0.1419, 105000);
            AddBoltSpec("A193 B7", "0.5625", 0.182, 105000);
            AddBoltSpec("A193 B7", "0.625", 0.226, 105000);
            AddBoltSpec("A193 B7", "0.75", 0.3345, 105000);
            AddBoltSpec("A193 B7", "0.875", 0.462, 105000);
            AddBoltSpec("A193 B7", "1", 0.606, 105000);
            AddBoltSpec("A193 B7", "1.125", 0.763, 105000);
            AddBoltSpec("A193 B7", "1.25", 0.969, 105000);
            AddBoltSpec("A193 B7", "1.375", 1.155, 105000);
            AddBoltSpec("A193 B7", "1.5", 1.405, 105000);
            AddBoltSpec("A193 B7", "1.75", 1.90, 105000);
            AddBoltSpec("A193 B7", "2", 2.50, 105000);
            AddBoltSpec("A193 B7", "2.25", 3.25, 105000);
            AddBoltSpec("A193 B7", "2.5", 4.00, 105000);
            AddBoltSpec("A193 B7", "2.75", 4.93, 105000);
            AddBoltSpec("A193 B7", "3", 5.97, 105000);
            AddBoltSpec("A193 B7", "3.5", 8.35, 105000);
            AddBoltSpec("A193 B7", "4", 11.10, 105000);

            // ASME SA-193 B7M (Metric Stress-Relieved)
            AddBoltSpec("A193 B7M", "M6", 0.0276, 80000);   // 20.1 mm² → 0.0276 in²
            AddBoltSpec("A193 B7M", "M8", 0.0489, 80000);   // 36.6 mm² → 0.0489 in²
            AddBoltSpec("A193 B7M", "M10", 0.0785, 80000);  // 58.0 mm² → 0.0785 in²
            AddBoltSpec("A193 B7M", "M12", 0.1307, 80000);  // 84.3 mm² → 0.1307 in²
            AddBoltSpec("A193 B7M", "M14", 0.1649, 80000);  // 115 mm² → 0.1649 in²
            AddBoltSpec("A193 B7M", "M16", 0.2434, 80000);  // 157 mm² → 0.2434 in²
            AddBoltSpec("A193 B7M", "M18", 0.2724, 80000);  // 192 mm² → 0.2724 in²
            AddBoltSpec("A193 B7M", "M20", 0.3797, 80000);  // 245 mm² → 0.3797 in²
            AddBoltSpec("A193 B7M", "M22", 0.4556, 80000);  // 303 mm² → 0.4556 in²
            AddBoltSpec("A193 B7M", "M24", 0.5513, 80000);  // 353 mm² → 0.5513 in²
            AddBoltSpec("A193 B7M", "M27", 0.6935, 80000);  // 459 mm² → 0.6935 in²
            AddBoltSpec("A193 B7M", "M30", 0.8656, 80000);  // 561 mm² → 0.8656 in²
            AddBoltSpec("A193 B7M", "M36", 1.252, 80000);   // 817 mm² → 1.252 in²

            // ASME SA-193 B8 (Stainless Steel)
            AddBoltSpec("A193 B8", "0.25", 0.0318, 75000);
            AddBoltSpec("A193 B8", "0.3125", 0.0524, 75000);
            AddBoltSpec("A193 B8", "0.375", 0.0775, 75000);
            AddBoltSpec("A193 B8", "0.4375", 0.1063, 75000);
            AddBoltSpec("A193 B8", "0.5", 0.1419, 75000);
            AddBoltSpec("A193 B8", "0.625", 0.226, 75000);
            AddBoltSpec("A193 B8", "0.75", 0.3345, 75000);
            AddBoltSpec("A193 B8", "0.875", 0.462, 75000);
            AddBoltSpec("A193 B8", "1", 0.606, 75000);
            AddBoltSpec("A193 B8", "1.25", 0.969, 75000);
            AddBoltSpec("A193 B8", "1.5", 1.405, 75000);
            AddBoltSpec("A193 B8", "2", 2.50, 75000);

            // ASME SA-193 B8M (Stainless Steel, Molybdenum)
            AddBoltSpec("A193 B8M", "0.25", 0.0318, 70000);
            AddBoltSpec("A193 B8M", "0.5", 0.1419, 70000);
            AddBoltSpec("A193 B8M", "0.75", 0.3345, 70000);
            AddBoltSpec("A193 B8M", "1", 0.606, 70000);
            AddBoltSpec("A193 B8M", "1.25", 0.969, 70000);
            AddBoltSpec("A193 B8M", "1.5", 1.405, 70000);

            // ASME SA-320 (Low Temperature Bolting)
            AddBoltSpec("A320 L7", "0.5", 0.1419, 100000);
            AddBoltSpec("A320 L7", "0.625", 0.226, 100000);
            AddBoltSpec("A320 L7", "0.75", 0.3345, 100000);
            AddBoltSpec("A320 L7", "0.875", 0.462, 100000);
            AddBoltSpec("A320 L7", "1", 0.606, 100000);
            AddBoltSpec("A320 L7", "1.125", 0.763, 100000);
            AddBoltSpec("A320 L7", "1.25", 0.969, 100000);
            AddBoltSpec("A320 L7", "1.5", 1.405, 100000);
            AddBoltSpec("A320 L7", "2", 2.50, 100000);

            // ASME SA-320 L7M (Low Temperature, Metric)
            AddBoltSpec("A320 L7M", "M12", 0.1307, 90000);
            AddBoltSpec("A320 L7M", "M16", 0.2434, 90000);
            AddBoltSpec("A320 L7M", "M20", 0.3797, 90000);
            AddBoltSpec("A320 L7M", "M24", 0.5513, 90000);
            AddBoltSpec("A320 L7M", "M30", 0.8656, 90000);

            // ASTM A307 (Commercial Bolts)
            AddBoltSpec("A307 B", "0.25", 0.0318, 60000);
            AddBoltSpec("A307 B", "0.5", 0.1419, 60000);
            AddBoltSpec("A307 B", "0.75", 0.3345, 60000);
            AddBoltSpec("A307 B", "1", 0.606, 60000);
            AddBoltSpec("A307 B", "1.25", 0.969, 60000);
            AddBoltSpec("A307 B", "1.5", 1.405, 60000);
            AddBoltSpec("A307 B", "2", 2.50, 60000);
            // A307 C (Higher grade than A307 B)
            AddBoltSpec("A307 C", "0.5", 0.1419, 70000);
            AddBoltSpec("A307 C", "0.75", 0.3345, 70000);
            AddBoltSpec("A307 C", "1", 0.606, 70000);

            // ASTM A490 (Structural Bolts)
            AddBoltSpec("A490", "0.5", 0.1419, 130000);
            AddBoltSpec("A490", "0.625", 0.226, 130000);
            AddBoltSpec("A490", "0.75", 0.3345, 130000);
            AddBoltSpec("A490", "0.875", 0.462, 130000);
            AddBoltSpec("A490", "1", 0.606, 130000);
            AddBoltSpec("A490", "1.125", 0.763, 130000);
            AddBoltSpec("A490", "1.25", 0.969, 130000);

            // ASTM F1554 (Anchor Bolts)
            AddBoltSpec("F1554 Gr. 36", "0.5", 0.1419, 36000);
            AddBoltSpec("F1554 Gr. 36", "0.75", 0.3345, 36000);
            AddBoltSpec("F1554 Gr. 36", "1", 0.606, 36000);
            AddBoltSpec("F1554 Gr. 55", "0.5", 0.1419, 55000);
            AddBoltSpec("F1554 Gr. 55", "0.75", 0.3345, 55000);
            AddBoltSpec("F1554 Gr. 55", "1", 0.606, 55000);
            AddBoltSpec("F1554 Gr. 105", "0.5", 0.1419, 105000);
            AddBoltSpec("F1554 Gr. 105", "0.75", 0.3345, 105000);
            AddBoltSpec("F1554 Gr. 105", "1", 0.606, 105000);

            // ASME SA-354 Grade BD (Quenched and tempered alloy steel bolts)
            AddBoltSpec("A354 BD", "0.5", 0.1419, 115000);
            AddBoltSpec("A354 BD", "0.625", 0.226, 115000);
            AddBoltSpec("A354 BD", "0.75", 0.3345, 115000);
            AddBoltSpec("A354 BD", "0.875", 0.462, 115000);
            AddBoltSpec("A354 BD", "1", 0.606, 115000);
            AddBoltSpec("A354 BD", "1.125", 0.763, 115000);
            AddBoltSpec("A354 BD", "1.25", 0.969, 115000);
            AddBoltSpec("A354 BD", "1.375", 1.155, 115000);
            AddBoltSpec("A354 BD", "1.5", 1.405, 115000);
            AddBoltSpec("A354 BD", "1.75", 1.90, 115000);
            AddBoltSpec("A354 BD", "2", 2.50, 115000);
            AddBoltSpec("A354 BC", "0.5", 0.1419, 105000);
            AddBoltSpec("A354 BC", "0.75", 0.3345, 105000);
            AddBoltSpec("A354 BC", "1", 0.606, 105000);
            AddBoltSpec("A354 BC", "1.25", 0.969, 105000);


            // Metric sizes for A354 BD
            AddBoltSpec("A354 BD", "M12", 0.1307, 115000);   // 84.3 mm² → 0.1307 in²
            AddBoltSpec("A354 BD", "M16", 0.2434, 115000);   // 157 mm² → 0.2434 in²
            AddBoltSpec("A354 BD", "M20", 0.3797, 115000);   // 245 mm² → 0.3797 in²
            AddBoltSpec("A354 BD", "M24", 0.5513, 115000);   // 353 mm² → 0.5513 in²
            AddBoltSpec("A354 BD", "M30", 0.8656, 115000);    // 561 mm² → 0.8656 in²
            AddBoltSpec("A354 BD", "M36", 1.252, 115000);     // 817 mm² → 1.252 in²

            // A453 660 - High Temp Alloy (FIXED: Added 0.875")
            AddBoltSpec("A453 660", "0.5", 0.1419, 120000);
            AddBoltSpec("A453 660", "0.625", 0.226, 120000);
            AddBoltSpec("A453 660", "0.75", 0.3345, 120000);
            AddBoltSpec("A453 660", "0.875", 0.462, 120000); // Added missing size
            AddBoltSpec("A453 660", "1", 0.606, 120000);
            AddBoltSpec("A453 660", "1.25", 0.969, 120000);
            AddBoltSpec("A453 660", "1.5", 1.405, 120000);
        }

        private void AddBoltSpec(string grade, string size, double tensileArea, double yieldStrength)
        {
            if (!_boltData.ContainsKey(grade))
                _boltData[grade] = new Dictionary<string, BoltSpecs>();

            _boltData[grade][size] = new BoltSpecs(tensileArea, yieldStrength);
        }

        private void InitializeForm()
        {
            // Load dropdowns
            cmbFlangeSize.Items.AddRange(Constants.FlangeSizes);
            cmbFlangeClass.Items.AddRange(Constants.FlangeClasses);
            cmbBoltGrade.Items.AddRange(Constants.BoltGrades);
            cmbBoltSize.Items.AddRange(Constants.BoltSizes);
            cmbLubrication.Items.AddRange(Constants.LubricationTypes);

            // Set defaults
            cmbFlangeSize.SelectedIndex = 4;  // 2"
            cmbFlangeClass.SelectedIndex = 0; // 150
            cmbBoltGrade.SelectedIndex = 0;   // A193 B7
            cmbBoltSize.SelectedIndex = 2;    // 1"
            cmbLubrication.SelectedIndex = 1; // Moly

            SetDefaultTargetStress();
            ConfigureToolTips();

            // Improve UI behavior
            txtBoltLoad.ReadOnly = true;
            txtTorque.ReadOnly = true;
            txtStressPercent.ReadOnly = true;
        }

        private void SetDefaultTargetStress()
        {
            var selectedGrade = cmbBoltGrade.SelectedItem?.ToString() ?? "A193 B7";
            txtTargetStress.Text = _pcc1DefaultStresses.TryGetValue(selectedGrade, out double stress)
                ? stress.ToString()
                : "50";
        }

        private void ConfigureToolTips()
        {
            _toolTip.SetToolTip(cmbLubrication, "PCC-1 Appendix K: Typical nut factors");
            _toolTip.SetToolTip(txtTargetStress, "PCC-1 Section 10 recommends 40-70% of yield stress");
        }

        // ========================
        // 5. Core Logic
        // ========================
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs(out string boltGrade, out string boltSize, out double targetStressPercent))
                    return;

                var specs = GetBoltSpecs(boltGrade, boltSize);
                ValidatePcc1Compliance(targetStressPercent, boltGrade);

                double boltLoad = CalculateBoltLoad(specs, targetStressPercent);
                double torque = CalculateTorque(boltSize, boltLoad, cmbLubrication.SelectedItem.ToString());

                DisplayResults(boltLoad, torque, targetStressPercent, boltGrade);
            }
            catch (Exception ex)
            {
                string errorMessage = $"Calculation failed: {ex.Message}\n\n";

                if (ex.Message.Contains("No specifications found for"))
                {
                    errorMessage += "The selected bolt grade and size combination is not supported by this calculator.\n" +
                                    "Please check the available bolt sizes for the selected grade.";
                }
                else
                {
                    errorMessage += "Common issues:\n" +
                                    "1. Missing bolt size for selected grade\n" +
                                    "2. Invalid characters in stress %\n" +
                                    "3. Unsupported bolt/lubrication combination";
                }

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs(out string boltGrade, out string boltSize, out double targetStressPercent)
        {
            boltGrade = cmbBoltGrade.SelectedItem?.ToString();
            boltSize = cmbBoltSize.SelectedItem?.ToString();
            targetStressPercent = 0;

            if (string.IsNullOrEmpty(boltGrade))
            {
                ShowError("Please select a bolt grade");
                return false;
            }

            if (!double.TryParse(txtTargetStress.Text, out targetStressPercent) || targetStressPercent <= 0)
            {
                ShowError("Invalid target stress percentage");
                return false;
            }

            return true;
        }

        private BoltSpecs GetBoltSpecs(string grade, string size)
        {
            if (_boltData.TryGetValue(grade, out var gradeData) &&
                gradeData.TryGetValue(size, out var specs))
            {
                return specs;
            }
            throw new Exception($"No specifications found for {grade} {size}");
        }

        private void ValidatePcc1Compliance(double targetStressPercent, string boltGrade)
        {
            if (targetStressPercent < 40 || targetStressPercent > 70)
            {
                MessageBox.Show(
                    $"PCC-1 Section 10 recommends {GetRecommendedStressRange(boltGrade)} for {boltGrade}.\n" +
                    "Stresses >70% require engineering review (Appendix O).",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private double CalculateBoltLoad(BoltSpecs specs, double targetStressPercent)
        {
            return (targetStressPercent / 100) * specs.YieldStrength * specs.TensileArea;
        }

        private double CalculateTorque(string boltSize, double boltLoad, string lubrication)
        {
            double nominalDiameter;
            if (boltSize.StartsWith("M"))
            {
                nominalDiameter = double.Parse(boltSize.Substring(1)) / 25.4; // Convert mm to inches
            }
            else
            {
                nominalDiameter = double.Parse(boltSize);
            }

            try
            {
                double kFactor = double.Parse(lubrication.Split('=')[1].Trim(')'));
                return kFactor * nominalDiameter * boltLoad;
            }
            catch
            {
                return 0.20 * nominalDiameter * boltLoad; // Default dry coefficient
            }
        }

        private string GetRecommendedStressRange(string boltGrade)
        {
            switch (boltGrade)
            {
                case "A193 B7": return "40-60%";
                case "A320 L7": return "35-55%";
                case "A453 660": case "A453 651": return "30-50%";
                case "A354 BC": case "A354 BD": return "45-65%";  // High-strength alloy
                case "F1554 Gr. 105": return "40-55%";  // Anchor bolts
                default: return "40-60%";
            }
        }

        private void DisplayResults(double boltLoad, double torque, double stressPercent, string boltGrade)
        {
            txtBoltLoad.Text = $"{boltLoad:N0} lbf";
            txtTorque.Text = $"{torque:N0} ft-lb";
            txtStressPercent.Text = $"{stressPercent}% (PCC-1 Range: {GetRecommendedStressRange(boltGrade)})";
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ========================
        // 6. Event Handlers
        // ========================
        private void cmbBoltGrade_SelectedIndexChanged(object sender, EventArgs e) => SetDefaultTargetStress();
        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}
