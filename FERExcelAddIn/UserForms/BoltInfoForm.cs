using NetOffice.OfficeApi.Tools.Informations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FERExcelAddIn
{
    public partial class BoltInfoForm : Form
    {
        public BoltInfoForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Initialize combo boxes
            InitializeFlangeSizes();
            InitializeFlangeRatings();

            // Set read-only appearance
            MakeOutputFieldsReadOnly();

            // Event handlers
            btnBoltInfoLookup.Click += BtnBoltInfoLookup_Click;
            btnCloseBoltForm.Click += BtnCloseBoltForm_Click;
            btnShowBoltTable.Click += BtnShowBoltTable_Click;
        }

        private void InitializeFlangeSizes()
        {
            cmbFlangeSize.Items.AddRange(new object[] {
                "1/2\"", "3/4\"", "1\"", "1.25\"", "1.5\"",
                "2\"", "2.5\"", "3\"", "3.5\"", "4\"",
                "5\"", "6\"", "8\"", "10\"", "12\"",
                "14\"", "16\"", "18\"", "20\"", "22\"", "24\""
            });
        }

        private void InitializeFlangeRatings()
        {
            cmbFlangeRating.Items.AddRange(new object[] {
                "150", "300", "400", "600", "900", "1500", "2500"
            });
        }

        private void MakeOutputFieldsReadOnly()
        {
            txtNumOfBolts.BackColor = SystemColors.Control;
            txtBoltDiameter.BackColor = SystemColors.Control;
            txtStudBoltLen.BackColor = SystemColors.Control;
            txtMachinedBoltLen.BackColor = SystemColors.Control;
            txtBoltCircle.BackColor = SystemColors.Control;
            txtFlangeDiameter.BackColor = SystemColors.Control;
            txtBoltHole.BackColor = SystemColors.Control;
        }

        private void BtnBoltInfoLookup_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                string flangeSize = cmbFlangeSize.SelectedItem.ToString();
                string flangeRating = cmbFlangeRating.SelectedItem.ToString();

                var boltInfo = LookupBoltInfo(flangeSize, flangeRating);

                // Display results
                txtNumOfBolts.Text = boltInfo.NumberOfBolts.ToString();
                txtBoltDiameter.Text = boltInfo.BoltDiameter;
                txtStudBoltLen.Text = boltInfo.StudBoltLength;
                txtMachinedBoltLen.Text = boltInfo.MachinedBoltLength;
                txtBoltCircle.Text = boltInfo.BoltCircleDiameter;
                txtFlangeDiameter.Text = boltInfo.FlangeDiameter;
                txtBoltHole.Text = boltInfo.BoltHoleDiameter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving bolt information: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCloseBoltForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidateInputs()
        {
            if (cmbFlangeSize.SelectedItem == null)
            {
                MessageBox.Show("Please select a Flange Size", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFlangeSize.Focus();
                return false;
            }

            if (cmbFlangeRating.SelectedItem == null)
            {
                MessageBox.Show("Please select a Flange Rating", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbFlangeRating.Focus();
                return false;
            }

            return true;
        }

        private BoltInfo LookupBoltInfo(string flangeSize, string flangeRating)
        {
            // First try to get data from Excel

            // Remove the inch symbol if present for matching
            string cleanSize = flangeSize.Replace("\"", "").Trim();
            string cleanRating = flangeRating.Replace("#", "").Trim();

            // Create a nested dictionary for all bolt information
            var boltData = CreateBoltDataDictionary();

            // Try to find the matching bolt info
            if (boltData.TryGetValue(cleanSize, out var ratingDict))
            {
                if (ratingDict.TryGetValue(cleanRating, out var boltInfo))
                {
                    return boltInfo;
                }
            }

            // Return default values if not found - now with all required parameters
            return new BoltInfo(
                numberOfBolts: 0,
                boltDiameter: "N/A",
                studBoltLength: "N/A",
                machinedBoltLength: "N/A",
                boltCircleDiameter: "N/A",
                flangeDiameter: "N/A",
                boltHoleDiameter: "N/A"
            );
        }



        private Dictionary<string, Dictionary<string, BoltInfo>> CreateBoltDataDictionary()
        {
            return new Dictionary<string, Dictionary<string, BoltInfo>>
    {
        // 1/2" Flange
        { "1/2", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(4, "1/2\"", "2-1/4\"", "2\"", "3-1/4\"", "3-1/2\"", "0.62\"") },
            { "300", new BoltInfo(4, "1/2\"", "2-1/2\"", "2-1/4\"", "3-1/2\"", "3-1/2\"", "0.62\"") },
            { "400", new BoltInfo(4, "1/2\"", "3\"", "n/a", "3-1/2\"", "3-1/2\"", "0.62\"") },
            { "600", new BoltInfo(4, "1/2\"", "3\"", "n/a", "3-1/2\"", "3-1/2\"", "0.62\"") },
            { "900", new BoltInfo(4, "3/4\"", "3\"", "n/a", "3-1/2\"", "3-1/2\"", "0.75\"") },
            { "1500", new BoltInfo(4, "3/4\"", "4-1/4\"", "n/a", "4-1/2\"", "4-1/2\"", "0.75\"") },
            { "2500", new BoltInfo(4, "3/4\"", "4-3/4\"", "n/a", "5\"", "5\"", "0.75\"") }
        }},

        // 3/4" Flange
        { "3/4", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(4, "1/2\"", "2-1/2\"", "2\"", "3-5/8\"", "3-7/8\"", "0.62\"") },
            { "300", new BoltInfo(4, "5/8\"", "3\"", "2-1/2\"", "4\"", "4-1/8\"", "0.75\"") },
            { "400", new BoltInfo(4, "5/8\"", "3-1/2\"", "n/a", "4-1/2\"", "4-1/2\"", "0.75\"") },
            { "600", new BoltInfo(4, "5/8\"", "3-1/2\"", "n/a", "4-1/2\"", "4-1/2\"", "0.75\"") },
            { "900", new BoltInfo(4, "3/4\"", "3-1/2\"", "n/a", "4-1/2\"", "4-1/2\"", "0.88\"") },
            { "1500", new BoltInfo(4, "3/4\"", "4-1/2\"", "n/a", "5-1/2\"", "5-1/2\"", "0.88\"") },
            { "2500", new BoltInfo(4, "3/4\"", "5\"", "n/a", "6\"", "6\"", "0.88\"") }
        }},

        // 1" Flange
        { "1", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(4, "1/2\"", "2-1/2\"", "2\"", "3-7/8\"", "4-1/4\"", "0.62\"") },
            { "300", new BoltInfo(4, "5/8\"", "3\"", "2-1/2\"", "4-1/4\"", "4-5/8\"", "0.75\"") },
            { "400", new BoltInfo(4, "5/8\"", "3-1/2\"", "n/a", "4-3/4\"", "5\"", "0.75\"") },
            { "600", new BoltInfo(4, "3/4\"", "3-1/2\"", "n/a", "5-1/2\"", "5-1/2\"", "0.88\"") },
            { "900", new BoltInfo(4, "3/4\"", "4\"", "n/a", "5-1/4\"", "5-1/2\"", "0.88\"") },
            { "1500", new BoltInfo(4, "7/8\"", "5\"", "n/a", "6-1/4\"", "6-1/2\"", "1.0\"") },
            { "2500", new BoltInfo(4, "1\"", "5-1/2\"", "n/a", "7\"", "7-1/4\"", "1.12\"") }
        }},

        // 1-1/4" Flange
        { "1-1/4", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(4, "1/2\"", "2-3/4\"", "2-1/4\"", "4-1/4\"", "4-5/8\"", "0.62\"") },
            { "300", new BoltInfo(4, "5/8\"", "3-1/4\"", "2-3/4\"", "4-5/8\"", "5\"", "0.75\"") },
            { "400", new BoltInfo(4, "3/4\"", "3-3/4\"", "n/a", "5-1/4\"", "5-1/2\"", "0.88\"") },
            { "600", new BoltInfo(4, "3/4\"", "4\"", "n/a", "5-1/2\"", "5-3/4\"", "0.88\"") },
            { "900", new BoltInfo(4, "7/8\"", "4-1/2\"", "n/a", "6-1/4\"", "6-1/2\"", "1.0\"") },
            { "1500", new BoltInfo(4, "1\"", "5-1/2\"", "n/a", "7-1/4\"", "7-1/2\"", "1.12\"") },
            { "2500", new BoltInfo(4, "1-1/8\"", "6\"", "n/a", "8\"", "8-1/4\"", "1.25\"") }
        }},

        // 1-1/2" Flange
        { "1-1/2", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(4, "5/8\"", "3\"", "2-1/2\"", "4-3/4\"", "5\"", "0.75\"") },
            { "300", new BoltInfo(4, "3/4\"", "3-1/2\"", "3\"", "5-1/4\"", "5-1/2\"", "0.88\"") },
            { "400", new BoltInfo(4, "3/4\"", "4\"", "n/a", "6\"", "6-1/4\"", "0.88\"") },
            { "600", new BoltInfo(4, "7/8\"", "4-1/4\"", "n/a", "6-1/2\"", "6-3/4\"", "1.0\"") },
            { "900", new BoltInfo(4, "1\"", "5\"", "n/a", "7-1/2\"", "7-3/4\"", "1.12\"") },
            { "1500", new BoltInfo(4, "1-1/8\"", "6\"", "n/a", "8-1/2\"", "8-3/4\"", "1.25\"") },
            { "2500", new BoltInfo(4, "1-1/4\"", "6-1/2\"", "n/a", "9-1/2\"", "9-3/4\"", "1.38\"") }
        }},

        // 2" Flange
        { "2", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(4, "5/8\"", "3-1/2\"", "3\"", "5\"", "6\"", "0.75\"") },
            { "300", new BoltInfo(8, "5/8\"", "3-1/2\"", "3\"", "6\"", "6-1/2\"", "0.75\"") },
            { "400", new BoltInfo(8, "3/4\"", "4\"", "n/a", "6-1/2\"", "7\"", "0.88\"") },
            { "600", new BoltInfo(8, "7/8\"", "4-1/2\"", "n/a", "7-1/2\"", "8\"", "1.0\"") },
            { "900", new BoltInfo(8, "1\"", "5-1/2\"", "n/a", "8-1/2\"", "9\"", "1.12\"") },
            { "1500", new BoltInfo(8, "1-1/4\"", "6-1/2\"", "n/a", "10\"", "10-3/4\"", "1.38\"") },
            { "2500", new BoltInfo(8, "1-3/8\"", "7-1/2\"", "n/a", "11-1/2\"", "12\"", "1.5\"") }
        }},

        // 2-1/2" Flange
        { "2-1/2", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(4, "3/4\"", "3-3/4\"", "3-1/4\"", "5-1/2\"", "7\"", "0.88\"") },
            { "300", new BoltInfo(8, "3/4\"", "4\"", "3-1/2\"", "7\"", "7-1/2\"", "0.88\"") },
            { "400", new BoltInfo(8, "7/8\"", "4-1/2\"", "n/a", "8\"", "8-1/2\"", "1.0\"") },
            { "600", new BoltInfo(8, "1\"", "5\"", "n/a", "8-1/2\"", "9\"", "1.12\"") },
            { "900", new BoltInfo(8, "1-1/8\"", "6\"", "n/a", "10\"", "10-1/2\"", "1.25\"") },
            { "1500", new BoltInfo(8, "1-3/8\"", "7-1/2\"", "n/a", "11-1/2\"", "12\"", "1.5\"") },
            { "2500", new BoltInfo(8, "1-1/2\"", "8-1/2\"", "n/a", "13\"", "13-1/2\"", "1.62\"") }
        }},

        // 3" Flange
        { "3", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(4, "3/4\"", "4\"", "3-1/2\"", "6\"", "7-1/2\"", "0.88\"") },
            { "300", new BoltInfo(8, "7/8\"", "4-1/2\"", "4\"", "7-1/2\"", "8-1/2\"", "1.0\"") },
            { "400", new BoltInfo(8, "1\"", "5\"", "n/a", "8\"", "9\"", "1.12\"") },
            { "600", new BoltInfo(8, "1-1/8\"", "5-1/2\"", "n/a", "9\"", "10\"", "1.25\"") },
            { "900", new BoltInfo(8, "1-1/4\"", "6-1/2\"", "n/a", "10-1/2\"", "11\"", "1.38\"") },
            { "1500", new BoltInfo(8, "1-1/2\"", "8\"", "n/a", "12-1/2\"", "13-1/2\"", "1.62\"") },
            { "2500", new BoltInfo(8, "1-5/8\"", "9\"", "n/a", "14\"", "15\"", "1.75\"") }
        }},

        // 4" Flange
        { "4", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(8, "3/4\"", "4-1/2\"", "4\"", "7\"", "9\"", "0.88\"") },
            { "300", new BoltInfo(8, "7/8\"", "5\"", "4-1/2\"", "7-1/2\"", "10\"", "1.0\"") },
            { "400", new BoltInfo(8, "1\"", "5-1/2\"", "n/a", "8-1/2\"", "11\"", "1.12\"") },
            { "600", new BoltInfo(8, "1-1/8\"", "6\"", "n/a", "9\"", "12\"", "1.25\"") },
            { "900", new BoltInfo(8, "1-1/4\"", "7\"", "n/a", "10-3/4\"", "13-1/2\"", "1.38\"") },
            { "1500", new BoltInfo(8, "1-5/8\"", "9\"", "n/a", "13\"", "16\"", "1.75\"") },
            { "2500", new BoltInfo(8, "1-7/8\"", "10\"", "n/a", "15\"", "18\"", "2.0\"") }
        }},

        // 5" Flange
        { "5", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(8, "7/8\"", "5-1/2\"", "5\"", "8\"", "10\"", "1.0\"") },
            { "300", new BoltInfo(8, "1\"", "6\"", "5-1/2\"", "8-1/2\"", "11\"", "1.12\"") },
            { "400", new BoltInfo(8, "1-1/8\"", "6-1/2\"", "n/a", "9-1/2\"", "12\"", "1.25\"") },
            { "600", new BoltInfo(8, "1-1/4\"", "7\"", "n/a", "10-1/2\"", "13-1/2\"", "1.38\"") },
            { "900", new BoltInfo(8, "1-1/2\"", "8\"", "n/a", "12\"", "15\"", "1.62\"") },
            { "1500", new BoltInfo(8, "1-7/8\"", "10\"", "n/a", "14-1/2\"", "18\"", "2.0\"") },
            { "2500", new BoltInfo(8, "2-1/8\"", "11-1/2\"", "n/a", "16-1/2\"", "20\"", "2.25\"") }
        }},

        // 6" Flange
        { "6", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(12, "7/8\"", "5-1/2\"", "5\"", "9-1/2\"", "11\"", "1.0\"") },
            { "300", new BoltInfo(12, "1\"", "6\"", "5-1/2\"", "11\"", "12-1/2\"", "1.12\"") },
            { "400", new BoltInfo(12, "1-1/8\"", "6-1/2\"", "n/a", "12\"", "13-1/2\"", "1.25\"") },
            { "600", new BoltInfo(12, "1-1/4\"", "7\"", "n/a", "12-3/4\"", "14-1/2\"", "1.38\"") },
            { "900", new BoltInfo(12, "1-1/2\"", "8-1/2\"", "n/a", "14-1/2\"", "16-1/2\"", "1.62\"") },
            { "1500", new BoltInfo(12, "2\"", "11\"", "n/a", "17-1/2\"", "20\"", "2.25\"") },
            { "2500", new BoltInfo(12, "2-1/4\"", "12-1/2\"", "n/a", "20\"", "22\"", "2.5\"") }
        }},

        // 8" Flange
        { "8", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(12, "7/8\"", "6\"", "5-1/2\"", "11\"", "13-1/2\"", "1.0\"") },
            { "300", new BoltInfo(12, "1-1/8\"", "6-1/2\"", "6\"", "13-1/2\"", "15\"", "1.25\"") },
            { "400", new BoltInfo(12, "1-1/4\"", "7\"", "n/a", "15\"", "16-1/2\"", "1.38\"") },
            { "600", new BoltInfo(12, "1-3/8\"", "7-1/2\"", "n/a", "16\"", "18\"", "1.5\"") },
            { "900", new BoltInfo(12, "1-5/8\"", "9\"", "n/a", "18-1/2\"", "20-1/2\"", "1.88\"") },
            { "1500", new BoltInfo(12, "2-1/8\"", "12\"", "n/a", "22\"", "24\"", "2.38\"") },
            { "2500", new BoltInfo(12, "2-1/2\"", "14\"", "n/a", "25\"", "27\"", "2.75\"") }
        }},

        // 10" Flange
        { "10", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(16, "1\"", "6-1/2\"", "6\"", "13-1/2\"", "16\"", "1.12\"") },
            { "300", new BoltInfo(16, "1-1/4\"", "7\"", "6-1/2\"", "16\"", "18-1/2\"", "1.38\"") },
            { "400", new BoltInfo(16, "1-3/8\"", "7-1/2\"", "n/a", "17-1/2\"", "20\"", "1.5\"") },
            { "600", new BoltInfo(16, "1-1/2\"", "8\"", "n/a", "19\"", "21-1/2\"", "1.62\"") },
            { "900", new BoltInfo(16, "1-7/8\"", "10\"", "n/a", "21-1/2\"", "24\"", "2.0\"") },
            { "1500", new BoltInfo(16, "2-3/8\"", "13\"", "n/a", "26\"", "29\"", "2.5\"") },
            { "2500", new BoltInfo(16, "2-3/4\"", "15\"", "n/a", "29-1/2\"", "32\"", "2.88\"") }
        }},

        // 12" Flange
        { "12", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(16, "1-1/8\"", "7\"", "6-1/2\"", "15-1/2\"", "19\"", "1.25\"") },
            { "300", new BoltInfo(16, "1-3/8\"", "7-1/2\"", "7\"", "19\"", "21-1/2\"", "1.5\"") },
            { "400", new BoltInfo(16, "1-1/2\"", "8\"", "n/a", "21\"", "23-1/2\"", "1.62\"") },
            { "600", new BoltInfo(16, "1-5/8\"", "8-1/2\"", "n/a", "22-1/2\"", "25\"", "1.75\"") },
            { "900", new BoltInfo(16, "2\"", "11\"", "n/a", "25\"", "27-1/2\"", "2.25\"") },
            { "1500", new BoltInfo(16, "2-3/4\"", "15\"", "n/a", "30\"", "32\"", "2.88\"") },
            { "2500", new BoltInfo(16, "3-1/8\"", "17\"", "n/a", "34\"", "36\"", "3.25\"") }
        }},

        // 14" Flange
        { "14", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(20, "1-1/8\"", "7-1/2\"", "7\"", "16-1/2\"", "21\"", "1.25\"") },
            { "300", new BoltInfo(20, "1-3/8\"", "8\"", "7-1/2\"", "20-1/2\"", "23-1/2\"", "1.5\"") },
            { "400", new BoltInfo(20, "1-1/2\"", "8-1/2\"", "n/a", "22-1/2\"", "25\"", "1.62\"") },
            { "600", new BoltInfo(20, "1-3/4\"", "9\"", "n/a", "24\"", "26-1/2\"", "1.88\"") },
            { "900", new BoltInfo(20, "2-1/8\"", "11-1/2\"", "n/a", "27-1/2\"", "29-1/2\"", "2.38\"") },
            { "1500", new BoltInfo(20, "2-7/8\"", "16\"", "n/a", "33\"", "35\"", "3.0\"") },
            { "2500", new BoltInfo(20, "3-1/4\"", "18\"", "n/a", "37\"", "39\"", "3.5\"") }
        }},

        // 16" Flange
        { "16", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(20, "1-1/4\"", "8\"", "7-1/2\"", "18-1/2\"", "23-1/2\"", "1.38\"") },
            { "300", new BoltInfo(20, "1-1/2\"", "8-1/2\"", "8\"", "22\"", "25-1/2\"", "1.62\"") },
            { "400", new BoltInfo(20, "1-5/8\"", "9\"", "n/a", "24\"", "27-1/2\"", "1.75\"") },
            { "600", new BoltInfo(20, "1-7/8\"", "10\"", "n/a", "26\"", "29-1/2\"", "2.0\"") },
            { "900", new BoltInfo(20, "2-1/4\"", "12-1/2\"", "n/a", "30\"", "32\"", "2.38\"") },
            { "1500", new BoltInfo(20, "3\"", "17\"", "n/a", "36\"", "38\"", "3.25\"") },
            { "2500", new BoltInfo(20, "3-1/2\"", "19\"", "n/a", "40\"", "42\"", "3.75\"") }
        }},

        // 18" Flange
        { "18", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(24, "1-1/4\"", "8-1/2\"", "8\"", "20\"", "25\"", "1.38\"") },
            { "300", new BoltInfo(24, "1-5/8\"", "9\"", "8-1/2\"", "23-1/2\"", "27-1/2\"", "1.75\"") },
            { "400", new BoltInfo(24, "1-7/8\"", "10\"", "n/a", "25-1/2\"", "29-1/2\"", "2.0\"") },
            { "600", new BoltInfo(24, "2\"", "11\"", "n/a", "28\"", "31-1/2\"", "2.12\"") },
            { "900", new BoltInfo(24, "2-3/8\"", "13-1/2\"", "n/a", "32\"", "34-1/2\"", "2.62\"") },
            { "1500", new BoltInfo(24, "3-1/4\"", "18\"", "n/a", "39\"", "41\"", "3.5\"") },
            { "2500", new BoltInfo(24, "3-3/4\"", "20\"", "n/a", "43\"", "45\"", "4.0\"") }
        }},

        // 20" Flange
        { "20", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(24, "1-1/4\"", "9\"", "8-1/2\"", "21-1/2\"", "27-1/2\"", "1.38\"") },
            { "300", new BoltInfo(24, "1-5/8\"", "9-1/2\"", "9\"", "25\"", "29-1/2\"", "1.75\"") },
            { "400", new BoltInfo(24, "1-7/8\"", "10-1/2\"", "n/a", "27-1/2\"", "31-1/2\"", "2.0\"") },
            { "600", new BoltInfo(24, "2-1/8\"", "11-1/2\"", "n/a", "30\"", "34\"", "2.25\"") },
            { "900", new BoltInfo(24, "2-5/8\"", "14\"", "n/a", "34-1/2\"", "37\"", "2.88\"") },
            { "1500", new BoltInfo(24, "3-1/2\"", "19\"", "n/a", "42\"", "44\"", "3.75\"") },
            { "2500", new BoltInfo(24, "4\"", "21\"", "n/a", "46\"", "48\"", "4.25\"") }
        }},

        // 22" Flange
        { "22", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(24, "1-1/2\"", "9-1/2\"", "9\"", "23\"", "29-1/2\"", "1.62\"") },
            { "300", new BoltInfo(24, "1-7/8\"", "10-1/2\"", "10\"", "27-1/2\"", "32\"", "2.0\"") },
            { "400", new BoltInfo(24, "2\"", "11-1/2\"", "n/a", "29-1/2\"", "34\"", "2.12\"") },
            { "600", new BoltInfo(24, "2-1/4\"", "12-1/2\"", "n/a", "32\"", "36-1/2\"", "2.38\"") },
            { "900", new BoltInfo(24, "2-5/8\"", "15\"", "n/a", "37\"", "40\"", "2.88\"") },
            { "1500", new BoltInfo(24, "3-1/2\"", "20\"", "n/a", "44\"", "46\"", "3.75\"") },
            { "2500", new BoltInfo(24, "4\"", "22\"", "n/a", "48\"", "50\"", "4.25\"") }
        }},

        // 24" Flange
        { "24", new Dictionary<string, BoltInfo> {
            { "150", new BoltInfo(24, "1-1/2\"", "10\"", "9-1/2\"", "25\"", "32\"", "1.62\"") },
            { "300", new BoltInfo(24, "1-7/8\"", "11\"", "10-1/2\"", "29-1/2\"", "34-1/2\"", "2.0\"") },
            { "400", new BoltInfo(24, "2\"", "12\"", "n/a", "32\"", "37\"", "2.12\"") },
            { "600", new BoltInfo(24, "2-1/4\"", "13\"", "n/a", "35\"", "40\"", "2.38\"") },
            { "900", new BoltInfo(24, "2-3/4\"", "16\"", "n/a", "40\"", "44\"", "2.88\"") },
            { "1500", new BoltInfo(24, "3-3/4\"", "21\"", "n/a", "47\"", "50\"", "4.0\"") },
            { "2500", new BoltInfo(24, "4-1/4\"", "24\"", "n/a", "52\"", "55\"", "4.5\"") }
        }}
    };
        }
        private void BtnShowBoltTable_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new form to display the full table
                Form tableForm = new Form();
                tableForm.Text = "Complete Bolt Information Table";
                tableForm.Size = new Size(1800, 600);
                tableForm.StartPosition = FormStartPosition.Manual;
                tableForm.Location = new Point(
                    this.Location.X + (this.Width - tableForm.Width) / 2,
                    this.Location.Y + (this.Height - tableForm.Height) / 2
                );

                // Create DataGridView
                DataGridView dataGridView = new DataGridView();
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView.Dock = DockStyle.Fill;
                dataGridView.ReadOnly = true;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.RowHeadersVisible = false;
                dataGridView.AllowUserToOrderColumns = true;
                dataGridView.AllowUserToResizeRows = false;

                // Add columns with headers - now including all properties
                dataGridView.Columns.Add("FlangeSize", "Flange Size");
                dataGridView.Columns.Add("Rating", "Rating");
                dataGridView.Columns.Add("NumberOfBolts", "Number of Bolts");
                dataGridView.Columns.Add("BoltDiameter", "Bolt Diameter");
                dataGridView.Columns.Add("StudBoltLength", "Stud Bolt Length");
                dataGridView.Columns.Add("MachinedBoltLength", "Machined Bolt Length");
                dataGridView.Columns.Add("BoltCircleDiameter", "Bolt Circle Diameter");
                dataGridView.Columns.Add("FlangeDiameter", "Flange Diameter");
                dataGridView.Columns.Add("BoltHoleDiameter", "Bolt Hole Diameter");

                // Style headers
                dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
                dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView.EnableHeadersVisualStyles = false;
                dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;

                // Get all bolt data
                var boltData = CreateBoltDataDictionary();

                // Add all data rows with all properties
                foreach (var sizeEntry in boltData)
                {
                    foreach (var ratingEntry in sizeEntry.Value)
                    {
                        var boltInfo = ratingEntry.Value;
                        dataGridView.Rows.Add(
                            sizeEntry.Key + "\"",  // Add inch symbol
                            ratingEntry.Key,
                            boltInfo.NumberOfBolts,
                            boltInfo.BoltDiameter,
                            boltInfo.StudBoltLength,
                            boltInfo.MachinedBoltLength,
                            boltInfo.BoltCircleDiameter,
                            boltInfo.FlangeDiameter,
                            boltInfo.BoltHoleDiameter
                        );
                    }
                }

                // Highlight current selection if available
                if (cmbFlangeSize.SelectedItem != null && cmbFlangeRating.SelectedItem != null)
                {
                    string currentSize = cmbFlangeSize.SelectedItem.ToString().Replace("\"", "");
                    string currentRating = cmbFlangeRating.SelectedItem.ToString().Replace("#", "").Trim();

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        if (row.Cells["FlangeSize"].Value.ToString().Replace("\"", "") == currentSize &&
                            row.Cells["Rating"].Value.ToString() == currentRating)
                        {
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            row.DefaultCellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
                            dataGridView.FirstDisplayedScrollingRowIndex = row.Index; // Scroll to show
                            break;
                        }
                    }
                }

                // Add search functionality
                TextBox searchBox = new TextBox();
                searchBox.Dock = DockStyle.Top;
                searchBox.Text = "Search (size or rating)...";
                searchBox.ForeColor = SystemColors.GrayText;
                searchBox.Margin = new Padding(5);

                searchBox.Enter += (s, args) =>
                {
                    if (searchBox.Text == "Search (size or rating)...")
                    {
                        searchBox.Text = "";
                        searchBox.ForeColor = SystemColors.WindowText;
                    }
                };

                searchBox.Leave += (s, args) =>
                {
                    if (string.IsNullOrWhiteSpace(searchBox.Text))
                    {
                        searchBox.Text = "Search (size or rating)...";
                        searchBox.ForeColor = SystemColors.GrayText;
                    }
                };

                searchBox.TextChanged += (s, args) =>
                {
                    if (searchBox.Text == "Search (size or rating)..." &&
                        searchBox.ForeColor == SystemColors.GrayText)
                        return;

                    string searchText = searchBox.Text.ToLower();
                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        string size = row.Cells["FlangeSize"].Value.ToString().ToLower();
                        string rating = row.Cells["Rating"].Value.ToString().ToLower();
                        row.Visible = string.IsNullOrEmpty(searchText) ||
                                     size.Contains(searchText) ||
                                     rating.Contains(searchText);
                    }
                };

                // Add controls to form
                tableForm.Controls.Add(dataGridView);
                tableForm.Controls.Add(searchBox);
                tableForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying table: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }


        private class BoltInfo
        {
            public int NumberOfBolts { get; }
            public string BoltDiameter { get; }
            public string StudBoltLength { get; }
            public string MachinedBoltLength { get; }
            public string BoltCircleDiameter { get; }
            public string FlangeDiameter { get; }
            public string BoltHoleDiameter { get; }

            public BoltInfo(int numberOfBolts, string boltDiameter, string studBoltLength, string machinedBoltLength,
          string boltCircleDiameter, string flangeDiameter, string boltHoleDiameter)
            {
                NumberOfBolts = numberOfBolts;
                BoltDiameter = boltDiameter;
                StudBoltLength = studBoltLength;
                MachinedBoltLength = machinedBoltLength;
                BoltCircleDiameter = boltCircleDiameter;
                FlangeDiameter = flangeDiameter;
                BoltHoleDiameter = boltHoleDiameter;
            }
        }
    }
}