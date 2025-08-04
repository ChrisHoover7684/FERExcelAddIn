using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FERExcelAddIn
{
    public partial class PipeWeightCalculatorForm : Form
    {
        private bool isMetric = false;
        private const double DensityConversionFactor = 0.036127; // 1 g/cm³ = 0.036127 lb/in³

        public PipeWeightCalculatorForm()
        {
            InitializeComponent();
            InitializeMaterials();
            SetupEventHandlers();
            UpdateUnitLabels();
        }

        private void InitializeMaterials()
        {
            cmbMaterial.Items.Clear();

            if (isMetric)
            {
                // Metric densities (g/cm³)
                cmbMaterial.Items.AddRange(new object[] {
                    "Polyvinyl Chloride (PVC) (1.45)",
                    "Pure Iron (7.86)",
                    "Wrought Iron (7.75)",
                    "Mild Steel (7.88)",
                    "Stainless Steel (8.03)",
                    "Aluminum (2.7)",
                    "Carbon Steel (7.84)",
                    "Brass (8.5)",
                    "Copper (8.96)"
                });
            }
            else
            {
                // Imperial densities (lb/in³) - converted from metric
                cmbMaterial.Items.AddRange(new object[] {
                    $"Polyvinyl Chloride (PVC) ({1.45 * DensityConversionFactor:0.#####})",
                    $"Pure Iron ({7.86 * DensityConversionFactor:0.#####})",
                    $"Wrought Iron ({7.75 * DensityConversionFactor:0.#####})",
                    $"Mild Steel ({7.88 * DensityConversionFactor:0.#####})",
                    $"Stainless Steel ({8.03 * DensityConversionFactor:0.#####})",
                    $"Aluminum ({2.7 * DensityConversionFactor:0.#####})",
                    $"Carbon Steel ({7.84 * DensityConversionFactor:0.#####})",
                    $"Brass ({8.5 * DensityConversionFactor:0.#####})",
                    $"Copper ({8.96 * DensityConversionFactor:0.#####})"
                });
            }
            cmbMaterial.SelectedIndex = 0;
        }

        private void SetupEventHandlers()
        {
            btnCalculate.Click += (s, e) => CalculatePipeWeight();
            btnClose.Click += (s, e) => this.Close();

            txtOuterDiameter.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) CalculatePipeWeight(); };
            txtWallThickness.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) CalculatePipeWeight(); };
            txtLength.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) CalculatePipeWeight(); };

            rbtnMetric.CheckedChanged += UnitSystem_Changed;
            rbtnImperial.CheckedChanged += UnitSystem_Changed;
        }

        private void UnitSystem_Changed(object sender, EventArgs e)
        {
            isMetric = rbtnMetric.Checked;
            UpdateUnitLabels();
            InitializeMaterials();
            ConvertExistingValues();
        }

        private void UpdateUnitLabels()
        {
            lblOuterDiameter.Text = isMetric ? "Outer Diameter (mm):" : "Outer Diameter (inches):";
            lblWallThickness.Text = isMetric ? "Wall Thickness (mm):" : "Wall Thickness (inches):";
            lblLength.Text = isMetric ? "Length (meters):" : "Length (feet):";
            lblMaterial.Text = isMetric ? "Material (g/cm³):" : "Material (lb/in³):";
        }

        private void ConvertExistingValues()
        {
            try
            {
                if (double.TryParse(txtOuterDiameter.Text, out double odValue))
                {
                    txtOuterDiameter.Text = isMetric
                        ? (odValue * 25.4).ToString("0.00")  // inches to mm
                        : (odValue / 25.4).ToString("0.00"); // mm to inches
                }

                if (double.TryParse(txtWallThickness.Text, out double wtValue))
                {
                    txtWallThickness.Text = isMetric
                        ? (wtValue * 25.4).ToString("0.00")  // inches to mm
                        : (wtValue / 25.4).ToString("0.00"); // mm to inches
                }

                if (double.TryParse(txtLength.Text, out double lenValue))
                {
                    txtLength.Text = isMetric
                        ? (lenValue * 0.3048).ToString("0.00")  // feet to meters
                        : (lenValue / 0.3048).ToString("0.00"); // meters to feet
                }
            }
            catch
            {
                // Silently handle conversion errors
            }
        }

        private void CalculatePipeWeight()
        {
            try
            {
                if (!ValidateInputs()) return;

                double outerDiameter = double.Parse(txtOuterDiameter.Text);
                double wallThickness = double.Parse(txtWallThickness.Text);
                double length = double.Parse(txtLength.Text);
                string material = cmbMaterial.SelectedItem.ToString();

                double density = ExtractDensity(material);

                if (isMetric)
                {
                    // Metric calculation (mm and meters)
                    double outerDiamM = outerDiameter / 1000;
                    double thicknessM = wallThickness / 1000;
                    double innerDiamM = outerDiamM - (2 * thicknessM);

                    double crossSectionArea = Math.PI * (Math.Pow(outerDiamM, 2) - Math.Pow(innerDiamM, 2)) / 4;
                    double volume = crossSectionArea * length;
                    double weightKg = volume * density * 1000; // g/cm³ to kg/m³ conversion
                    double weightLb = weightKg * 2.20462;

                    txtWeight.Text = $"{weightKg:0.00} kg ({weightLb:0.00} lbs)";
                }
                else
                {
                    // Imperial calculation (inches and feet)
                    double crossSectionArea = Math.PI * (Math.Pow(outerDiameter, 2) -
                                             Math.Pow(outerDiameter - 2 * wallThickness, 2)) / 4;
                    double volume = crossSectionArea * (length * 12); // convert feet to inches
                    double weightLb = volume * density;
                    double weightKg = weightLb / 2.20462;

                    txtWeight.Text = $"{weightLb:0.00} lbs ({weightKg:0.00} kg)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Calculation error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double ExtractDensity(string material)
        {
            var match = Regex.Match(material, @"\((\d+\.?\d*)");
            if (match.Success && double.TryParse(match.Groups[1].Value, out double density))
                return density;
            throw new ArgumentException("Invalid material density format");
        }

        private bool ValidateInputs()
        {
            return ValidatePositiveDouble(txtOuterDiameter, "outer diameter") &&
                   ValidatePositiveDouble(txtWallThickness, "wall thickness") &&
                   ValidatePositiveDouble(txtLength, "length") &&
                   ValidateWallThickness();
        }

        private bool ValidatePositiveDouble(TextBox textBox, string fieldName)
        {
            if (!double.TryParse(textBox.Text, out double value) || value <= 0)
            {
                MessageBox.Show($"Please enter a valid {fieldName}", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateWallThickness()
        {
            if (double.TryParse(txtOuterDiameter.Text, out double od) &&
                double.TryParse(txtWallThickness.Text, out double wt))
            {
                if (!isMetric)
                {
                    od *= 25.4;
                    wt *= 25.4;
                }

                if (wt >= od / 2)
                {
                    MessageBox.Show("Wall thickness must be less than half of outer diameter",
                        "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWallThickness.Focus();
                    return false;
                }
            }
            return true;
        }
    }
}