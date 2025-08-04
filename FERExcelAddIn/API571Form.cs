using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FERExcelAddIn
{
    public partial class API571Form : Form
    {
        public API571Form()
        {
            InitializeComponent();
            InitializeUI();
            InitializeData();
        }

        private void InitializeUI()
        {
            // Configure search box placeholder
            txtSearch.Text = "Search mechanisms...";
            txtSearch.ForeColor = SystemColors.GrayText;

            // Configure ListBoxes
            lstMechanisms.DisplayMember = "Name";
            lstMechanisms.ValueMember = "Name";
            lstRelated.DisplayMember = "Name";

            // Set up event handlers
            txtSearch.Enter += TxtSearch_Enter;
            txtSearch.Leave += TxtSearch_Leave;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            lstMechanisms.SelectedIndexChanged += lstMechanisms_SelectedIndexChanged;
        }

        private void HighlightSearchTerm(string searchTerm, RichTextBox richTextBox)
        {
            if (string.IsNullOrWhiteSpace(searchTerm)) return;

            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = richTextBox.BackColor;

            int index = 0;
            while ((index = richTextBox.Text.IndexOf(searchTerm, index, StringComparison.OrdinalIgnoreCase)) >= 0)
            {
                richTextBox.Select(index, searchTerm.Length);
                richTextBox.SelectionBackColor = Color.Yellow;
                index += searchTerm.Length;
            }
            richTextBox.SelectionLength = 0; // Clear selection
        }

        private void InitializeData()
        {
            // Load mechanisms
            RefreshMechanismList();
        }

        private void RefreshMechanismList()
        {
            var searchText = txtSearch.Text == "Search mechanisms..." ? "" : txtSearch.Text;

            lstMechanisms.DataSource = DamageMechanismRepository.SearchMechanisms(searchText);

            // Select first item if available
            if (lstMechanisms.Items.Count > 0)
            {
                lstMechanisms.SelectedIndex = 0;
            }
        }

        private void DisplaySelectedMechanism()
        {
            if (lstMechanisms.SelectedItem is DamageMechanism selected)
            {
                // Update form fields with selected mechanism data
                lblName.Text = selected.Name ?? string.Empty;
                txtDescription.Text = selected.Description ?? string.Empty;
                txtMaterials.Text = selected.AffectedMaterials ?? string.Empty;
                txtUnits.Text = selected.AffectedUnits ?? string.Empty;
                txtFactors.Text = selected.CriticalFactors ?? string.Empty;
                txtPrevention.Text = selected.Prevention ?? string.Empty;
                txtInspection.Text = selected.Inspection ?? string.Empty;

                // Highlight search term in all relevant fields
                HighlightSearchTerm(txtSearch.Text, txtDescription);     // Description
                HighlightSearchTerm(txtSearch.Text, txtMaterials);       // Affected Materials
                HighlightSearchTerm(txtSearch.Text, txtUnits);           // Affected Units
                HighlightSearchTerm(txtSearch.Text, txtFactors);         // Critical Factors

                // Update risk level display with proper colors
                var riskLevel = selected.RiskLevel ?? "Unknown";
                lblRiskLevel.Text = $"Risk: {riskLevel}";

                // Set both background and text color based on risk level
                var (backColor, textColor) = GetRiskColors(riskLevel);
                lblRiskLevel.BackColor = backColor;
                lblRiskLevel.ForeColor = textColor;

                // Load related mechanisms
                /*lstRelated.DataSource = selected.RelatedMechanisms?
                    .Select(name => DamageMechanismRepository.GetMechanism(name))
                    .Where(mech => mech != null)
                    .ToList() ?? new List<DamageMechanism>();
                */

                lstRelated.DataSource = selected.RelatedMechanisms?.ToList() ?? new List<string>();
                lstRelated.DisplayMember = null; // Display raw strings
            }
            else
            {
                // Clear all fields if nothing is selected
                lblName.Text = "Select a mechanism";
                txtDescription.Text = string.Empty;
                txtMaterials.Text = string.Empty;
                txtUnits.Text = string.Empty;
                txtFactors.Text = string.Empty;
                txtPrevention.Text = string.Empty;
                txtInspection.Text = string.Empty;

                // Reset risk level display
                lblRiskLevel.Text = "Risk: Unknown";
                lblRiskLevel.BackColor = SystemColors.Control;
                lblRiskLevel.ForeColor = SystemColors.ControlText;

                lstRelated.DataSource = null;
            }
        }

        private (Color BackColor, Color TextColor) GetRiskColors(string riskLevel)
        {
            if (string.IsNullOrEmpty(riskLevel))
                return (SystemColors.Control, SystemColors.ControlText);

            // Extract the first risk level before any parentheses or qualifiers
            string primaryRisk = riskLevel.Split('(', '-', ':')[0].Trim().ToLower();

            switch (primaryRisk)
            {
                case "critical":
                    return (Color.FromArgb(178, 34, 34), Color.White); // Firebrick red #B22222
                case "high":
                    return (Color.FromArgb(255, 140, 0), Color.Black); // Dark orange #FF8C00
                case "medium":
                    return (Color.FromArgb(255, 215, 0), Color.Black); // Gold #FFD700
                case "low":
                    return (Color.FromArgb(144, 238, 144), Color.Black); // Light green #90EE90
                default:
                    return (SystemColors.Control, SystemColors.ControlText);
            }
        }

        private void TxtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search mechanisms...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void TxtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search mechanisms...";
                txtSearch.ForeColor = SystemColors.GrayText;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshMechanismList();
        }

        private void lstMechanisms_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySelectedMechanism();
        }

        private void lstRelated_DoubleClick(object sender, EventArgs e)
        {
            if (lstRelated.SelectedItem is string mechanismName)
            {
                // Find the corresponding mechanism in the main list
                var mechanism = DamageMechanismRepository.GetMechanism(mechanismName);
                if (mechanism != null)
                {
                    // Find and select the mechanism in the main list
                    var index = lstMechanisms.FindString(mechanism.Name);
                    if (index >= 0)
                    {
                        lstMechanisms.SelectedIndex = index;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}