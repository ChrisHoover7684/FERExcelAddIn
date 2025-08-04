using System;
using System.Windows.Forms;

namespace CorrosionRateCalculator
{
    public partial class CorrosionRateForm : Form
    {
        public CorrosionRateForm()
        {
            InitializeComponent();
            dtInitialDate.Value = DateTime.Now.AddYears(-1);
            dtFinalDate.Value = DateTime.Now;
            txtExposureTime.Enabled = true;
            dtInitialDate.Enabled = false;
            dtFinalDate.Enabled = false;
        }

        private void radioManualYears_CheckedChanged(object sender, EventArgs e)
        {
            if (radioManualYears.Checked)
            {
                txtExposureTime.Enabled = true;
                dtInitialDate.Enabled = false;
                dtFinalDate.Enabled = false;
                dtInitialDate.Value = DateTime.Now.AddYears(-1);
                dtFinalDate.Value = DateTime.Now;
            }
        }

        private void radioUseDates_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUseDates.Checked)
            {
                txtExposureTime.Enabled = false;
                dtInitialDate.Enabled = true;
                dtFinalDate.Enabled = true;
                txtExposureTime.Text = "";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!double.TryParse(txtInitialThickness.Text, out double initialInches) || initialInches <= 0)
                    throw new ArgumentException("Please enter a valid positive number for initial thickness");

                if (!double.TryParse(txtFinalThickness.Text, out double finalInches) || finalInches <= 0)
                    throw new ArgumentException("Please enter a valid positive number for final thickness");

                if (initialInches <= finalInches)
                    throw new ArgumentException("Initial thickness must be greater than final thickness");

                double exposureTime;

                if (radioUseDates.Checked)
                {
                    if (dtFinalDate.Value <= dtInitialDate.Value)
                        throw new ArgumentException("Final date must be after initial date");

                    TimeSpan span = dtFinalDate.Value - dtInitialDate.Value;
                    exposureTime = span.TotalDays / 365.25;
                }
                else
                {
                    if (!double.TryParse(txtExposureTime.Text, out exposureTime) || exposureTime <= 0)
                        throw new ArgumentException("Please enter a valid positive number for exposure time");
                }

                double thicknessLoss = initialInches - finalInches;
                double corrosionRateInPerYr = thicknessLoss / exposureTime;
                double corrosionRateMPY = corrosionRateInPerYr * 1000;
                double corrosionRateMMPerYr = corrosionRateInPerYr * 25.4;

                lblResult.Text = $"Corrosion Rate:\n" +
                                $"{corrosionRateInPerYr:F5} inches/year\n" +
                                $"{corrosionRateMPY:F2} MPY (mils/year)\n" +
                                $"{corrosionRateMMPerYr:F4} mm/year\n\n" +
                                $"Exposure Time: {exposureTime:F2} years";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResult.Text = "Calculation failed. Please check your inputs.";
            }
        }
    }
}