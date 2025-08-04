using System;
using System.Drawing;
using System.Windows.Forms;

namespace FERExcelAddIn
{
    public partial class API510ExemptionEvaluator : Form
    {
        private bool useMetric = true;

        public API510ExemptionEvaluator()
        {
            InitializeComponent();
            WireUpEvents();
            InitializeDefaults();
        }

        private void WireUpEvents()
        {
            // Unit selection changed
            radMetric.CheckedChanged += UnitSystemChanged;
            radImperial.CheckedChanged += UnitSystemChanged;

            // Enable/disable groups based on checkbox states
            chkMovableStructure.CheckedChanged += (s, e) =>
                grpMovableTypes.Enabled = chkMovableStructure.Checked;

            chkASMEExempt.CheckedChanged += (s, e) =>
                grpASMETypes.Enabled = chkASMEExempt.Checked;

            radDirectVolume.CheckedChanged += (s, e) =>
            {
                txtDirectVolume.Enabled = radDirectVolume.Checked;
                grpCalculatedVolume.Enabled = radCalculateVolume.Checked;
            };

            // Calculation and evaluation events
            btnCalculateVolume.Click += CalculateVolume;
            btnEvaluate.Click += EvaluateExemption;
            btnClearSpecs.Click += ClearSpecifications;
        }

        private void InitializeDefaults()
        {
            cmbHeadType.SelectedIndex = 0;
            cmbHeadCount.SelectedIndex = 1;
            UpdateUnitLabels();
        }

        private double GetVesselVolume()
        {
            if (radDirectVolume.Checked)
            {
                if (!double.TryParse(txtDirectVolume.Text, out double volume) || volume <= 0)
                {
                    throw new ArgumentException("Please enter a valid volume");
                }
                return useMetric ? volume : volume * 0.0283168; // Convert ft³ to m³
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtCalculatedVolume.Text))
                {
                    throw new ArgumentException("Please calculate volume first");
                }
                if (!double.TryParse(txtCalculatedVolume.Text, out double volume) || volume <= 0)
                {
                    throw new ArgumentException("Invalid calculated volume");
                }
                return volume; // Already converted during calculation
            }
        }

        private double GetDesignPressure()
        {
            if (!double.TryParse(txtDesignPressure.Text, out double pressure) || pressure <= 0)
            {
                throw new ArgumentException("Please enter a valid design pressure");
            }
            return useMetric ? pressure : pressure * 0.00689476; // Convert PSI to MPa
        }

        private double GetDesignTemperature()
        {
            if (!double.TryParse(txtDesignTemp.Text, out double temp))
            {
                throw new ArgumentException("Please enter a valid design temperature");
            }
            return useMetric ? temp : (temp - 32) * 5 / 9; // Convert °F to °C
        }

        private ExemptionResult EvaluateExemptionCriteria()
        {
            var result = new ExemptionResult();

            try
            {
                double volume = GetVesselVolume(); // Always in m³
                double pressure = GetDesignPressure(); // Always in MPa

                // Check movable structures exemption first
                if (chkMovableStructure.Checked)
                {
                    if (optTruckTank.Checked)
                        return result.SetExempt("A.a.1", "Cargo/volume tank for truck/ship/barge");
                    if (optBrakeReceiver.Checked)
                        return result.SetExempt("A.a.2", "Air receiver for braking system");
                    if (optOceanVessel.Checked)
                        return result.SetExempt("A.a.3", "Pressure vessel in oceangoing ship/barge");
                }

                // Check ASME exemptions next
                if (chkASMEExempt.Checked)
                {
                    if (optTubularHeater.Checked)
                        return result.SetExempt("A.b.1", "Fired process tubular heater");
                    if (optRotatingDevice.Checked)
                        return result.SetExempt("A.b.2", "Integral part of rotating device");
                }

                // Check vessel specifications
                if (volume <= 0.14 && pressure <= 1.7)
                    return result.SetExempt("A.c.1", "Volume ≤ 0.14m³ & Pressure ≤ 1.7MPa");
                if (volume <= 0.08 && pressure <= 2.4)
                    return result.SetExempt("A.c.2", "Volume ≤ 0.08m³ & Pressure ≤ 2.4MPa");
                if (volume <= 0.04 && pressure <= 4.1)
                    return result.SetExempt("A.c.3", "Volume ≤ 0.04m³ & Pressure ≤ 4.1MPa");

                return result.SetExempt("", GetFailureReason(volume, pressure));
            }
            catch (Exception ex)
            {
                return result.SetExempt("", $"Evaluation error: {ex.Message}");
            }
        }

        private string GetFailureReason(double volumeM3, double pressureMPa)
        {
            if (volumeM3 > 0.14) return $"Volume ({volumeM3:F4}m³) exceeds exemption limits";
            if (pressureMPa > 4.1) return $"Pressure ({pressureMPa:F2}MPa) exceeds exemption limits";

            if (volumeM3 <= 0.14 && pressureMPa > 1.7)
                return $"Volume qualifies for A.c.1 but pressure ({pressureMPa:F2}MPa) > 1.7MPa";
            if (volumeM3 <= 0.08 && pressureMPa > 2.4)
                return $"Volume qualifies for A.c.2 but pressure ({pressureMPa:F2}MPa) > 2.4MPa";

            return "Does not meet any exemption criteria";
        }

        private void CalculateVolume(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtOD.Text, out double od) || od <= 0)
                {
                    MessageBox.Show("Please enter a valid outside diameter", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtOD.Focus();
                    return;
                }

                if (!double.TryParse(txtLength.Text, out double length) || length <= 0)
                {
                    MessageBox.Show("Please enter a valid length", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtLength.Focus();
                    return;
                }

                // Convert to meters for calculations if necessary
                double odMeters = useMetric ? od : od * 0.0254;
                double lengthMeters = useMetric ? length : length * 0.0254;

                int headCount = cmbHeadCount.SelectedIndex;
                double radius = odMeters / 2;
                double cylinderVolume = Math.PI * Math.Pow(radius, 2) * lengthMeters;
                double headVolume = CalculateHeadVolume(odMeters);
                double totalVolume = cylinderVolume + (headVolume * headCount);

                // Convert back to display units if necessary
                txtCalculatedVolume.Text = useMetric
                    ? totalVolume.ToString("F4")
                    : (totalVolume / 0.0283168).ToString("F4");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Calculation error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateHeadVolume(double odMeters)
        {
            string headType = cmbHeadType.SelectedItem.ToString();
            double radius = odMeters / 2;

            switch (headType)
            {
                case "Ellipsoidal (2:1)":
                    return (4.0 / 3.0) * Math.PI * Math.Pow(radius / 2, 2) * radius;
                case "Hemispherical":
                    return (2.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
                case "Torispherical":
                    return 0.0809 * Math.Pow(odMeters, 3);
                default: // Flat heads
                    return 0;
            }
        }

        private void EvaluateExemption(object sender, EventArgs e)
        {
            try
            {
                ExemptionResult result = EvaluateExemptionCriteria();
                DisplayResult(result);
            }
            catch (Exception ex)
            {
                txtResult.Text = $"Evaluation error: {ex.Message}";
                txtResult.BackColor = Color.LightPink;
            }
        }

        private void DisplayResult(ExemptionResult result)
        {
            if (result.IsExempt)
            {
                txtResult.Text = $"EXEMPT (Annex {result.Clause}){Environment.NewLine}{result.Reason}";
                txtResult.BackColor = Color.LightGreen;
            }
            else
            {
                txtResult.Text = "NOT EXEMPT - Inspection required per API 510";
                txtResult.BackColor = Color.LightPink;
            }
        }

        private void ClearSpecifications(object sender, EventArgs e)
        {
            // Clear all input fields
            txtDirectVolume.Text = "0";
            txtOD.Text = "0";
            txtLength.Text = "0";
            txtCalculatedVolume.Text = "";
            txtDesignPressure.Text = "0";
            txtDesignTemp.Text = "0";

            // Reset selections
            cmbHeadType.SelectedIndex = 0;
            cmbHeadCount.SelectedIndex = 1;
            radDirectVolume.Checked = true;

            // Clear results
            txtResult.Text = "";
            txtResult.BackColor = SystemColors.Window;
        }

        private void UnitSystemChanged(object sender, EventArgs e)
        {
            useMetric = radMetric.Checked;
            UpdateUnitLabels();
            ConvertCurrentValues();
        }

        private void UpdateUnitLabels()
        {
            if (useMetric)
            {
                lblODUnits.Text = "m";
                lblLengthUnits.Text = "m";
                lblDirectVolumeUnits.Text = "m³";
                lblCalculatedVolumeUnits.Text = "m³";
                lblPressureUnits.Text = "MPa";
                lblTempUnits.Text = "°C";
                radDirectVolume.Text = "Enter volume directly (m³)";
            }
            else
            {
                lblODUnits.Text = "in";
                lblLengthUnits.Text = "in";
                lblDirectVolumeUnits.Text = "ft³";
                lblCalculatedVolumeUnits.Text = "ft³";
                lblPressureUnits.Text = "PSI";
                lblTempUnits.Text = "°F";
                radDirectVolume.Text = "Enter volume directly (ft³)";
            }
        }

        private void ConvertCurrentValues()
        {
            try
            {
                // Convert OD (meters to inches or vice versa)
                if (double.TryParse(txtOD.Text, out double odValue) && odValue > 0)
                {
                    txtOD.Text = useMetric ?
                        (odValue * 0.0254).ToString("F4") :  // in to m
                        (odValue / 0.0254).ToString("F4");     // m to in
                }

                // Convert Length (meters to inches or vice versa)
                if (double.TryParse(txtLength.Text, out double lengthValue) && lengthValue > 0)
                {
                    txtLength.Text = useMetric ?
                        (lengthValue * 0.0254).ToString("F4") :  // in to m
                        (lengthValue / 0.0254).ToString("F4");   // m to in
                }

                // Convert Direct Volume (m³ to ft³ or vice versa)
                if (double.TryParse(txtDirectVolume.Text, out double directVolume) && directVolume > 0)
                {
                    txtDirectVolume.Text = useMetric ?
                        (directVolume * 0.0283168).ToString("F4") :  // ft³ to m³
                        (directVolume / 0.0283168).ToString("F4");   // m³ to ft³
                }

                // Convert Calculated Volume (m³ to ft³ or vice versa)
                if (double.TryParse(txtCalculatedVolume.Text, out double calcVolume) && calcVolume > 0)
                {
                    txtCalculatedVolume.Text = useMetric ?
                        (calcVolume * 0.0283168).ToString("F4") :  // ft³ to m³
                        (calcVolume / 0.0283168).ToString("F4");   // m³ to ft³
                }

                // Convert Pressure (MPa to PSI or vice versa)
                if (double.TryParse(txtDesignPressure.Text, out double pressure) && pressure > 0)
                {
                    txtDesignPressure.Text = useMetric ?
                        (pressure * 0.00689476).ToString("F2") :  // PSI to MPa
                        (pressure / 0.00689476).ToString("F2");   // MPa to PSI
                }

                // Convert Temperature (°C to °F or vice versa)
                if (double.TryParse(txtDesignTemp.Text, out double temp))
                {
                    txtDesignTemp.Text = useMetric
                        ? ((temp - 32) * 5 / 9).ToString("F1")   // °F to °C
                        : (temp * 9 / 5 + 32).ToString("F1");    // °C to °F
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error converting units: {ex.Message}",
                    "Unit Conversion Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class ExemptionResult
        {
            public bool IsExempt { get; private set; }
            public string Clause { get; private set; }
            public string Reason { get; private set; }

            public ExemptionResult SetExempt(string clause, string reason)
            {
                IsExempt = !string.IsNullOrEmpty(clause);
                Clause = clause;
                Reason = reason;
                return this;
            }
        }
    }
}