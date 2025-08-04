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
            lstMechanisms.SelectedIndexChanged += lstMechanisms_SelectedIndexChanged; // Add this line
        }

        private void InitializeData()
        {
            // Initialize filters
            cboMaterialFilter.Items.Add("All Materials");
            cboMaterialFilter.Items.AddRange(DamageMechanismRepository.GetAllMaterials().ToArray());
            cboMaterialFilter.SelectedIndex = 0;

            cboUnitFilter.Items.Add("All Units");
            cboUnitFilter.Items.AddRange(DamageMechanismRepository.GetAllUnits().ToArray());
            cboUnitFilter.SelectedIndex = 0;

            // Load mechanisms
            RefreshMechanismList();
        }

        private void RefreshMechanismList()
        {
            var searchText = txtSearch.Text == "Search mechanisms..." ? "" : txtSearch.Text;
            var materialFilter = cboMaterialFilter.SelectedIndex > 0 ? cboMaterialFilter.Text : "";
            var unitFilter = cboUnitFilter.SelectedIndex > 0 ? cboUnitFilter.Text : "";

            lstMechanisms.DataSource = DamageMechanismRepository.SearchMechanisms(
                searchText,
                materialFilter,
                unitFilter);

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
                lblName.Text = selected.Name ?? string.Empty;
                txtDescription.Text = selected.Description ?? string.Empty;
                txtMaterials.Text = selected.AffectedMaterials ?? string.Empty;
                txtFactors.Text = selected.CriticalFactors ?? string.Empty;
                txtPrevention.Text = selected.Prevention ?? string.Empty;
                txtInspection.Text = selected.Inspection ?? string.Empty;

                lblRiskLevel.Text = $"Risk: {selected.RiskLevel ?? "Unknown"}";
                lblRiskLevel.BackColor = GetRiskColor(selected.RiskLevel);

                // Load related mechanisms
                lstRelated.DataSource = selected.RelatedMechanisms?
                    .Select(name => DamageMechanismRepository.GetMechanism(name))
                    .Where(mech => mech != null)
                    .ToList() ?? new List<DamageMechanism>();
            }
            else
            {
                // Clear all fields if nothing is selected
                lblName.Text = "Select a mechanism";
                txtDescription.Text = string.Empty;
                txtMaterials.Text = string.Empty;
                txtFactors.Text = string.Empty;
                txtPrevention.Text = string.Empty;
                txtInspection.Text = string.Empty;
                lblRiskLevel.Text = "Risk: Unknown";
                lblRiskLevel.BackColor = SystemColors.Control;
                lstRelated.DataSource = null;
            }
        }

        private Color GetRiskColor(string riskLevel)
        {
            if (string.IsNullOrEmpty(riskLevel))
                return SystemColors.Control;

            switch (riskLevel.ToLower())
            {
                case "critical": return Color.Red;
                case "high": return Color.OrangeRed;
                case "medium": return Color.Orange;
                case "low": return Color.LightGreen;
                default: return SystemColors.Control;
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
            if (lstRelated.SelectedItem is DamageMechanism related)
            {
                var index = lstMechanisms.FindString(related.Name);
                if (index >= 0) lstMechanisms.SelectedIndex = index;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaterialFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMechanismList();
        }

        private void cboUnitFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMechanismList();
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            cboMaterialFilter.SelectedIndex = 0;
            cboUnitFilter.SelectedIndex = 0;
            txtSearch.Text = "Search mechanisms...";
            txtSearch.ForeColor = SystemColors.GrayText;
            RefreshMechanismList();
        }
    }
}