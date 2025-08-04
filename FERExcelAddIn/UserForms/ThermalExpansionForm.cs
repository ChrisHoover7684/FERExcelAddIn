using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FERExcelAddIn
{
    public partial class ThermalExpansionForm : Form
    {
        // Material CTE values (in/in°F)
        private readonly Dictionary<string, double> _materialCTE = new Dictionary<string, double>
        {
            { "Carbon Steel", 6.5e-6 },
            { "Stainless Steel", 9.0e-6 },
            { "Copper", 9.3e-6 },
            { "PVC", 30.0e-6 }
        };

        public ThermalExpansionForm()
        {
            InitializeComponent();
            SetupForm();
        }

        private void SetupForm()
        {
            // Populate materials
            cmbMaterial.DataSource = new BindingSource(_materialCTE, null);
            cmbMaterial.DisplayMember = "Key";

            // Set default unit to °F
            optFahrenheit.Checked = true;

            // Wire events
            btnCalculate.Click += CalculateExpansion;
            btnClose.Click += (s, e) => Close();
        }

        private void CalculateExpansion(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (cmbMaterial.SelectedItem == null ||
                    !double.TryParse(txtDeltaT.Text, out double deltaT) ||
                    !double.TryParse(txtLength.Text, out double length))
                {
                    MessageBox.Show("Please enter valid numbers for all fields.",
                                  "Input Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                // Get CTE
                var material = (KeyValuePair<string, double>)cmbMaterial.SelectedItem;
                double cte = material.Value;

                // Convert °C to °F if needed
                if (optCelsius.Checked)
                    deltaT *= 1.8;

                // Calculate expansion: ΔL = α × L × ΔT
                double expansion = cte * length * deltaT;

                // Display result
                txtResult.Text = $"Material: {material.Key}\r\n" +
                                $"ΔT: {deltaT:0.##}°F\r\n" +
                                $"Length: {length:0.##} in\r\n" +
                                $"Expansion (ΔL): {expansion:0.0000} in";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Calculation error: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
    }
}