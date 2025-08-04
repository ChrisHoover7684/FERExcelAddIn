using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FERExcelAddIn
{
    public partial class CUIAssessmentForm : Form
    {
        public CUIAssessmentForm()
        {
            InitializeComponent();
            WireUpEventHandlers();
            SetDefaultSelections();
        }

        private void WireUpEventHandlers()
        {
            btnCalculate.Click += BtnCalculate_Click;
            btnSsCalculate.Click += BtnSsCalculate_Click;
            btnCufCalculate.Click += BtnCufCalculate_Click;
        }

        private void SetDefaultSelections()
        {
            // Carbon Steel tab
            cmbTemperatureRange.SelectedIndex = 0;
            cmbCoatingAge.SelectedIndex = 0;
            cmbJacketingCondition.SelectedIndex = 0;
            cmbHeatTracing.SelectedIndex = 0;
            cmbEnvironment.SelectedIndex = 0;
            cmbInsulationType.SelectedIndex = 0;
            cmbLineSize.SelectedIndex = 0;

            // Stainless Steel tab
            cmbSsTemperatureRange.SelectedIndex = 0;
            cmbSsCoatingAge.SelectedIndex = 0;
            cmbSsJacketingCondition.SelectedIndex = 0;
            cmbSsHeatTracing.SelectedIndex = 0;
            cmbSsEnvironment.SelectedIndex = 0;
            cmbSsInsulationType.SelectedIndex = 0;
            cmbSsLineSize.SelectedIndex = 0;

            // CUF tab
            cmbCufTemperature.SelectedIndex = 0;
            cmbCufCoatingAge.SelectedIndex = 0;
            cmbCufFireproofing.SelectedIndex = 0;
            cmbCufWaterIngress.SelectedIndex = 0;
            cmbCufEnvironment.SelectedIndex = 0;
            cmbCufMaterialType.SelectedIndex = 0;
        }

        private void BtnCufCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateCufInputs())
            {
                int totalScore = CalculateCufScore();
                string riskLevel = GetCufRiskLevel(totalScore);
                lblCufResult.Text = $"Total CUF Likelihood Score: {totalScore}\nRisk Level: {riskLevel}";
                lblCufResult.ForeColor = GetRiskColor(riskLevel);
            }
        }

        private int CalculateCufScore()
        {
            int score = 0;
            score += GetSelectedPoints(cmbCufTemperature);
            score += GetSelectedPoints(cmbCufCoatingAge);
            score += GetSelectedPoints(cmbCufFireproofing);
            score += GetSelectedPoints(cmbCufWaterIngress);
            score += GetSelectedPoints(cmbCufEnvironment);
            score += GetSelectedPoints(cmbCufMaterialType);
            return score;
        }

        private string GetCufRiskLevel(int score)
        {
            if (score < 7) return "A - Lowest Likelihood";
            if (score >= 7 && score < 12) return "B - Low Likelihood";
            if (score >= 12 && score <= 16) return "C - Moderate Likelihood";
            if (score > 16 && score <= 19) return "D - High Likelihood";
            return "E - Highest Likelihood";
        }

        private bool ValidateCufInputs()
        {
            return ValidateComboBoxes(new[] {
                cmbCufTemperature, cmbCufCoatingAge, cmbCufFireproofing,
                cmbCufWaterIngress, cmbCufEnvironment, cmbCufMaterialType
            }, "CUF Assessment");
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateCarbonSteelInputs())
            {
                int totalScore = CalculateCarbonSteelScore();
                string riskLevel = GetRiskLevel(totalScore);
                lblResult.Text = $"Total CUI Likelihood Score: {totalScore}\nRisk Level: {riskLevel}";
                lblResult.ForeColor = GetRiskColor(riskLevel);
            }
        }

        private void BtnSsCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateStainlessSteelInputs())
            {
                int totalScore = CalculateStainlessSteelScore();

                // Apply duplex adjustment if needed
                if (tabPage2.Text.Contains("Duplex"))
                {
                    totalScore = (int)(totalScore * 0.8); // 20% reduction for duplex
                }

                string riskLevel = GetRiskLevel(totalScore);
                lblSsResult.Text = $"Total CUI Likelihood Score: {totalScore}\nRisk Level: {riskLevel}";
                lblSsResult.ForeColor = GetRiskColor(riskLevel);
            }
        }

        private int CalculateCarbonSteelScore()
        {
            int score = 0;
            score += GetSelectedPoints(cmbTemperatureRange);
            score += GetSelectedPoints(cmbCoatingAge);
            score += GetSelectedPoints(cmbJacketingCondition);
            score += GetSelectedPoints(cmbHeatTracing);
            score += GetSelectedPoints(cmbEnvironment);
            score += GetSelectedPoints(cmbInsulationType);
            score += GetSelectedPoints(cmbLineSize);
            return score;
        }

        private int CalculateStainlessSteelScore()
        {
            int score = 0;
            score += GetSelectedPoints(cmbSsTemperatureRange);
            score += GetSelectedPoints(cmbSsCoatingAge);
            score += GetSelectedPoints(cmbSsJacketingCondition);
            score += GetSelectedPoints(cmbSsHeatTracing);
            score += GetSelectedPoints(cmbSsEnvironment);
            score += GetSelectedPoints(cmbSsInsulationType);
            score += GetSelectedPoints(cmbSsLineSize);
            return score;
        }

        private int GetSelectedPoints(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex <= 0) return 0;
            string selectedText = comboBox.SelectedItem.ToString();

            int start = selectedText.LastIndexOf('(') + 1;
            int end = selectedText.IndexOf(" point");
            if (end == -1) return 0;

            string pointsStr = selectedText.Substring(start, end - start);
            return int.Parse(pointsStr);
        }

        private string GetRiskLevel(int score)
        {
            if (score < 7) return "A - Lowest Likelihood (Very Low Risk)";
            if (score >= 7 && score < 14) return "B - Low Likelihood (Low Risk)";
            if (score >= 14 && score <= 20) return "C - Moderate Likelihood (Medium Risk)";
            if (score > 20 && score <= 27) return "D - High Likelihood (High Risk)";
            return "E - Highest Likelihood (Very High Risk)";
        }

        private Color GetRiskColor(string riskLevel)
        {
            switch (riskLevel.Substring(0, 1))
            {
                case "A": return Color.FromArgb(0, 128, 0);     // Dark Green
                case "B": return Color.FromArgb(144, 238, 144);  // Light Green
                case "C": return Color.FromArgb(255, 165, 0);    // Orange
                case "D": return Color.FromArgb(255, 69, 0);     // Red-Orange
                case "E": return Color.FromArgb(178, 34, 34);    // Firebrick Red
                default: return Color.Gray;
            }
        }

        private bool ValidateCarbonSteelInputs()
        {
            return ValidateComboBoxes(new[] {
                cmbTemperatureRange, cmbCoatingAge, cmbJacketingCondition,
                cmbHeatTracing, cmbEnvironment, cmbInsulationType, cmbLineSize
            }, "Carbon Steel");
        }

        private bool ValidateStainlessSteelInputs()
        {
            return ValidateComboBoxes(new[] {
                cmbSsTemperatureRange, cmbSsCoatingAge, cmbSsJacketingCondition,
                cmbSsHeatTracing, cmbSsEnvironment, cmbSsInsulationType, cmbSsLineSize
            }, "Stainless Steel");
        }

        private bool ValidateComboBoxes(ComboBox[] comboBoxes, string tabName)
        {
            Dictionary<string, string[]> fieldNamesMap = new Dictionary<string, string[]>
            {
                { "Carbon Steel", new[] { "temperature range", "coating/age condition", "jacketing condition",
                    "heat tracing condition", "external environment", "insulation type", "line size" } },
                { "Stainless Steel", new[] { "temperature range", "coating/age condition", "jacketing condition",
                    "heat tracing condition", "external environment", "insulation type", "line size" } },
                { "CUF Assessment", new[] { "operating temperature", "coating/age condition", "fireproofing condition",
                    "potential for water ingress", "external environment", "material type" } }
            };

            string[] fieldNames = fieldNamesMap.ContainsKey(tabName) ?
                fieldNamesMap[tabName] :
                new string[comboBoxes.Length];

            for (int i = 0; i < comboBoxes.Length; i++)
            {
                if (comboBoxes[i].SelectedIndex <= 0)
                {
                    MessageBox.Show($"Please select {fieldNames[i]} in {tabName} tab",
                                  "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxes[i].Focus();
                    return false;
                }
            }
            return true;
        }
    }
}