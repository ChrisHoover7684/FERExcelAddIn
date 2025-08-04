using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FERExcelAddIn
{
    public partial class HTHACheckerForm : Form
    {
        public HTHACheckerForm()
        {
            InitializeComponent();
            InitializeMaterialDropdown();
            SetupDisclaimerLabel();
            this.Load += HTHACheckerForm_Load;
        }

        private void HTHACheckerForm_Load(object sender, EventArgs e)
        {
            lblDisclaimer.Text = "Disclaimer: This tool uses Nelson Curve data based on API 941. " +
                               "It is intended for preliminary screening only. Always consult the latest edition of API 941 " +
                               "and perform metallurgical evaluation for final decisions.";
        }

        private void SetupDisclaimerLabel()
        {
            lblDisclaimer.Dock = DockStyle.Bottom;
            lblDisclaimer.BackColor = Color.LightYellow;
            lblDisclaimer.TextAlign = ContentAlignment.MiddleCenter;
            lblDisclaimer.AutoSize = false;
            lblDisclaimer.Height = 70;
            lblDisclaimer.Padding = new Padding(5);
            lblDisclaimer.Font = new Font(lblDisclaimer.Font, FontStyle.Italic);
        }

        private void InitializeMaterialDropdown()
        {
            cboMaterial.Items.AddRange(new object[] {
                "Carbon Steel (C ≤ 0.3%, PWHT)",
                "Carbon Steel (C ≤ 0.3%, non-PWHT)",
                "1.0Cr-0.5Mo",
                "1.25Cr-0.5Mo",
                "2.25Cr-1.0Mo",
                "3Cr-1Mo",
                "6Cr-0.5Mo",
            });
            cboMaterial.SelectedIndex = 0;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                string material = cboMaterial.SelectedItem.ToString();
                double temperature = double.Parse(txtTemperature.Text);
                double h2Pressure = double.Parse(txtH2Pressure.Text);

                AssessHTHA(material, temperature, h2Pressure);
            }
            catch (Exception ex)
            {
                rtbResult.Clear();
                AppendFormattedText($"Error in calculation: {ex.Message}", Color.Red, true);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTemperature.Text) ||
                string.IsNullOrWhiteSpace(txtH2Pressure.Text))
            {
                MessageBox.Show("Please enter both temperature and H₂ pressure.",
                              "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtTemperature.Text, out double temp) ||
                !double.TryParse(txtH2Pressure.Text, out double pressure))
            {
                MessageBox.Show("Please enter valid numeric values.",
                              "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (temp <= 0 || pressure <= 0)
            {
                MessageBox.Show("Values must be greater than zero.",
                              "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static class NelsonCurveData
        {
            public static Dictionary<string, (double[] pressures, double[] temps)> Curves =
                new Dictionary<string, (double[], double[])>
            {
                // Carbon Steel (C ≤ 0.3%, PWHT)
                {
                    "Carbon Steel (C ≤ 0.3%, PWHT)",
                    (
                        new double[] { 0, 50, 100, 101, 150, 200, 250, 295, 300, 350, 400, 500, 600, 900, 1600, 2400, 3000, 13000 },
                        new double[] { 1100, 1080, 1055, 699, 600, 575, 555, 550, 548, 540, 535, 525, 515, 500, 475, 450, 430, 430 }
                    )
                },
                // Carbon Steel (C ≤ 0.3%, non-PWHT)
                {
                    "Carbon Steel (C ≤ 0.3%, non-PWHT)",
                    (
                        new double[] { 0, 50, 100, 101, 150, 200, 250, 295, 300, 350, 400, 500, 600, 900, 1600, 2400, 3000, 13000 },
                        new double[] { 1050, 1030, 1005, 649, 550, 525, 505, 500, 498, 490, 485, 475, 465, 450, 425, 400, 380, 380 }
                    )
                },
                // 1.0Cr-0.5Mo Steel
                {
                    "1.0Cr-0.5Mo",
                    (
                        new double[] { 0, 300, 400, 450, 500, 600, 700, 1220, 1221, 1300, 1500, 1700, 1900, 2300, 2999, 3000, 13000 },
                        new double[] { 1100, 1000, 970, 955, 945, 920, 900, 900, 950, 775, 695, 660, 650, 640, 625, 625, 625 }
                    )
                },
                // 1.25Cr-0.5Mo Steel
                {
                    "1.25Cr-0.5Mo",
                    (
                        new double[] { 0, 350, 351, 900, 901, 1220, 1221, 1300, 1500, 1700, 1900, 2300, 2999, 3000, 13000 },
                        new double[] { 1150, 1100, 1100, 990, 991, 950, 950, 775, 695, 660, 650, 640, 625, 625, 625 }
                    )
                },
                {
                    "2.25Cr-1.0Mo",
                    (
                        new double[] { 0, 300, 400, 1400, 1999, 2000, 6000 },
                        new double[] { 1200, 1140, 1120, 950, 856, 855, 855 }
                    )
                },
                // 3Cr-1Mo
                {
                    "3Cr-1Mo",
                    (
                        new double[] { 0, 500, 800, 1200, 1400, 1800, 6000 },
                        new double[] { 1250, 1145, 1095, 1025, 1000, 950, 950 }
                    )
                },
                // 6Cr-0.5Mo
                {
                    "6Cr-0.5Mo",
                    (
                        new double[] { 0, 500, 700, 1050, 6000 },
                        new double[] { 1300, 1205, 1170, 1115, 1115 }
                    )
                }
            };
        }

        private double InterpolateTemperature(string material, double pressurePsia)
        {
            if (!NelsonCurveData.Curves.TryGetValue(material, out var curve))
                return double.NaN;

            var pressures = curve.pressures;
            var temps = curve.temps;

            // Check for exact matches first
            for (int i = 0; i < pressures.Length; i++)
            {
                if (Math.Abs(pressurePsia - pressures[i]) < 0.1)
                    return temps[i];
            }

            // Handle pressures below/above curve bounds
            if (pressurePsia <= pressures[0])
                return temps[0];
            if (pressurePsia >= pressures[pressures.Length - 1])
                return temps[temps.Length - 1];

            // Find the segment where the pressure fits
            for (int i = 1; i < pressures.Length; i++)
            {
                if (pressurePsia < pressures[i])
                {
                    // Linear interpolation: T = T1 + (P - P1) * (T2 - T1) / (P2 - P1)
                    return temps[i - 1] + (pressurePsia - pressures[i - 1]) *
                           (temps[i] - temps[i - 1]) / (pressures[i] - pressures[i - 1]);
                }
            }

            return temps[temps.Length - 1]; // Fallback (should never reach here)
        }



        private void AssessHTHA(string material, double tempF, double pressurePsia)
        {
            rtbResult.Clear();

            double maxAllowableTemp = InterpolateTemperature(material, pressurePsia);

            if (double.IsNaN(maxAllowableTemp))
            {
                AppendFormattedText("HTHA Risk Assessment (API RP 941)", Color.Black, true);
                AppendFormattedText("──────────────────────────────", Color.Gray, false);
                AppendFormattedText($"Material: {material}", Color.Black, false);
                AppendFormattedText($"Temperature: {tempF}°F ({(tempF - 32) * 5 / 9:F1}°C)", Color.Black, false);
                AppendFormattedText($"H₂ Partial Pressure: {pressurePsia} psia ({pressurePsia * 0.00689476:F2} MPa)", Color.Black, false);
                AppendFormattedText("\nResult: ❓ CURVE DATA UNAVAILABLE", Color.Orange, true);
                AppendFormattedText("\nRecommendations:", Color.Black, true);
                AppendFormattedText("Consult API 941 Figure 1 for this material", Color.Black, false);
                return;
            }

            // Calculate temperature ratio (0.0 to 1.0+)
            double tempRatio = tempF / maxAllowableTemp;
            string tempProximity = $" ({(tempRatio):P0} of limit)";

            // Risk assessment with 4 categories
            Color riskColor;
            string riskLevel;
            string riskCategory;

            if (tempRatio >= 1.0) // ≥100% (Critical)
            {
                riskColor = Color.Red;
                riskLevel = "🚨 CRITICAL RISK (On/Above Curve)";
                riskCategory = "Critical";
            }
            else if (tempRatio >= 0.85) // 85-100% (Warning)
            {
                riskColor = Color.Orange;
                riskLevel = "⚠️ WARNING (Approaching Curve)";
                riskCategory = "Warning";
            }
            else if (tempRatio >= 0.5) // 50-85% (Caution)
            {
                riskColor = Color.Goldenrod;
                riskLevel = "🔸 CAUTION (Mid-Range)";
                riskCategory = "Caution";
            }
            else // <50% (Safe)
            {
                riskColor = Color.Green;
                riskLevel = "✅ SAFE (Well Below Curve)";
                riskCategory = "Safe";
            }

            // Build the output
            AppendFormattedText("HTHA Risk Assessment (API RP 941)", Color.Black, true);
            AppendFormattedText("──────────────────────────────", Color.Gray, false);
            AppendFormattedText($"Material: {material}", Color.Black, false);
            AppendFormattedText($"Temperature: {tempF}°F ({(tempF - 32) * 5 / 9:F1}°C)", Color.Black, false);
            AppendFormattedText($"H₂ Partial Pressure: {pressurePsia} psia ({pressurePsia * 0.00689476:F2} MPa)", Color.Black, false);
            AppendFormattedText($"\nResult: {riskLevel}", riskColor, true);
            AppendFormattedText($"• Temperature is at {tempRatio:P0} of the Nelson Curve limit", Color.Black, false);

            // Add detailed recommendations
            AppendFormattedText("\nImmediate Actions:", Color.Black, true);
            foreach (var rec in HTHARecommendations.GeneralRecommendations[riskCategory])
            {
                AppendFormattedText($"• {rec}", riskColor, false);
            }

            // Add material-specific notes
            AppendFormattedText("\nMaterial Notes:", Color.Black, true);
            string materialType = material.Contains("Cr") ? "CrMo" : "Carbon";
            foreach (var rec in HTHARecommendations.MaterialSpecificRecommendations[materialType])
            {
                AppendFormattedText($"• {rec}", Color.DarkBlue, false);
            }
        }
        public static class HTHARecommendations
        {
            public static Dictionary<string, List<string>> GeneralRecommendations = new Dictionary<string, List<string>>()
            {
                ["Critical"] = new List<string> {
            "IMMEDIATE ACTION REQUIRED: Shutdown and inspect per API 571 Section 4.2.6.",
            "Perform advanced NDE (PAUT/TOFD) to check for HTHA damage.",
            "Consult a materials engineer for mitigation options (e.g., cladding upgrade)."
        },
                ["Warning"] = new List<string> {
            "High Risk: Schedule inspection at next turnaround.",
            "Monitor operating conditions closely - avoid excursions.",
            "Consider upgrading to more resistant material during next maintenance."
        },
                ["Caution"] = new List<string> {
            "Moderate Risk: Include in routine inspection plans.",
            "Review historical data for temperature/pressure fluctuations.",
            "Consider corrosion coupons for long-term monitoring."
        },
                ["Safe"] = new List<string> {
            "Low Risk: Maintain standard inspection frequency.",
            "Document baseline measurements for future reference.",
            "Reassess if process conditions change significantly."
        }
            };

            public static Dictionary<string, List<string>> MaterialSpecificRecommendations = new Dictionary<string, List<string>>()
            {
                ["Carbon"] = new List<string> {
            "Carbon steels are most vulnerable to HTHA - monitor hardness (<200 HB).",
            "PWHT is critical for carbon steels above 450°F (232°C)."
        },
                ["CrMo"] = new List<string> {
            "Cr-Mo alloys require verified PWHT and hardness control.",
            "For 2.25Cr-1Mo and higher alloys, consider hydrogen probes."
        }
            };
        }
        private void AppendFormattedText(string text, Color color, bool bold)
        {
            rtbResult.SelectionStart = rtbResult.TextLength;
            rtbResult.SelectionLength = 0;

            rtbResult.SelectionColor = color;
            rtbResult.SelectionFont = new Font(rtbResult.Font, bold ? FontStyle.Bold : FontStyle.Regular);
            rtbResult.AppendText(text + "\n");
            rtbResult.SelectionColor = rtbResult.ForeColor;
        }
    }
}