using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FERExcelAddIn
{
    public partial class LWNForm : Form
    {
        private Dictionary<(string size, string schedule), double> thicknessData;

        public LWNForm()
        {
            InitializeComponent();
            InitializeThicknessData();
            InitializeComponentEvents();
            PopulateComboBoxes();
        }


        private void InitializeThicknessData()
        {
            thicknessData = new Dictionary<(string size, string schedule), double>()
    {
        // ============= LWN (Light Weight Neck) Data =============
        // 150#-LWN
        {("0.5", "150#-LWN"), 0.375}, {("0.75", "150#-LWN"), 0.435}, {("1", "150#-LWN"), 0.5},
        {("1.25", "150#-LWN"), 0.565}, {("1.5", "150#-LWN"), 0.56}, {("2", "150#-LWN"), 0.53},
        {("2.5", "150#-LWN"), 0.625}, {("3", "150#-LWN"), 0.625}, {("3.5", "150#-LWN"), 0.69},
        {("4", "150#-LWN"), 0.75}, {("5", "150#-LWN"), 0.75}, {("6", "150#-LWN"), 0.875},
        {("8", "150#-LWN"), 0.875}, {("10", "150#-LWN"), 1.0}, {("12", "150#-LWN"), 1.19},
        {("14", "150#-LWN"), 1.0}, {("16", "150#-LWN"), 1.0}, {("18", "150#-LWN"), 1.0},
        {("20", "150#-LWN"), 1.0}, {("24", "150#-LWN"), 1.125},

        // 300#-LWN
        {("0.5", "300#-LWN"), 0.5}, {("0.75", "300#-LWN"), 0.565}, {("1", "300#-LWN"), 0.56},
        {("1.25", "300#-LWN"), 0.625}, {("1.5", "300#-LWN"), 0.625}, {("2", "300#-LWN"), 0.655},
        {("2.5", "300#-LWN"), 0.72}, {("3", "300#-LWN"), 0.81}, {("3.5", "300#-LWN"), 0.875},
        {("4", "300#-LWN"), 0.875}, {("5", "300#-LWN"), 1.0}, {("6", "300#-LWN"), 1.06},
        {("8", "300#-LWN"), 1.125}, {("10", "300#-LWN"), 1.31}, {("12", "300#-LWN"), 1.375},
        {("14", "300#-LWN"), 1.375}, {("16", "300#-LWN"), 1.5}, {("18", "300#-LWN"), 1.5},
        {("20", "300#-LWN"), 1.56}, {("24", "300#-LWN"), 1.81},

        // 400#-LWN - Same as 300#-LWN
        {("0.5", "400#-LWN"), 0.5}, {("0.75", "400#-LWN"), 0.565}, {("1", "400#-LWN"), 0.56},
        {("1.25", "400#-LWN"), 0.625}, {("1.5", "400#-LWN"), 0.625}, {("2", "400#-LWN"), 0.655},
        {("2.5", "400#-LWN"), 0.72}, {("3", "400#-LWN"), 0.81}, {("3.5", "400#-LWN"), 0.875},
        {("4", "400#-LWN"), 0.875}, {("5", "400#-LWN"), 1.0}, {("6", "400#-LWN"), 1.06},
        {("8", "400#-LWN"), 1.125}, {("10", "400#-LWN"), 1.31}, {("12", "400#-LWN"), 1.375},
        {("14", "400#-LWN"), 1.375}, {("16", "400#-LWN"), 1.5}, {("18", "400#-LWN"), 1.5},
        {("20", "400#-LWN"), 1.56}, {("24", "400#-LWN"), 1.81},

        // 600#-LWN - Updated values
        {("0.5", "600#-LWN"), 0.5}, {("0.75", "600#-LWN"), 0.565}, {("1", "600#-LWN"), 0.56},
        {("1.25", "600#-LWN"), 0.625}, {("1.5", "600#-LWN"), 0.625}, {("2", "600#-LWN"), 0.655},
        {("2.5", "600#-LWN"), 0.72}, {("3", "600#-LWN"), 0.81}, {("3.5", "600#-LWN"), 0.875},
        {("4", "600#-LWN"), 1.0}, {("5", "600#-LWN"), 1.25}, {("6", "600#-LWN"), 1.375},
        {("8", "600#-LWN"), 1.375}, {("10", "600#-LWN"), 1.75}, {("12", "600#-LWN"), 1.875},
        {("14", "600#-LWN"), 1.5}, {("16", "600#-LWN"), 1.75}, {("18", "600#-LWN"), 1.75},
        {("20", "600#-LWN"), 2.0}, {("24", "600#-LWN"), 2.125},

        // 900#-LWN - Updated values
        {("0.5", "900#-LWN"), 0.53}, {("0.75", "900#-LWN"), 0.53}, {("1", "900#-LWN"), 0.56},
        {("1.25", "900#-LWN"), 0.625}, {("1.5", "900#-LWN"), 0.625}, {("2", "900#-LWN"), 1.06},
        {("2.5", "900#-LWN"), 1.19}, {("3", "900#-LWN"), 1.0}, 
        {("4", "900#-LWN"), 1.125}, {("5", "900#-LWN"), 1.25}, {("6", "900#-LWN"), 1.625},
        {("8", "900#-LWN"), 1.875}, {("10", "900#-LWN"), 2.25}, {("12", "900#-LWN"), 2.25},
        {("14", "900#-LWN"), 1.875}, {("16", "900#-LWN"), 2.0}, {("18", "900#-LWN"), 2.125},
        {("20", "900#-LWN"), 2.25}, {("24", "900#-LWN"), 2.75},

        // 1500#-LWN - Updated values
        {("0.5", "1500#-LWN"), 0.53}, {("0.75", "1500#-LWN"), 0.53}, {("1", "1500#-LWN"), 0.56},
        {("1.25", "1500#-LWN"), 0.625}, {("1.5", "1500#-LWN"), 0.625}, {("2", "1500#-LWN"), 1.06},
        {("2.5", "1500#-LWN"), 1.19}, {("3", "1500#-LWN"), 1.125}, 
        {("4", "1500#-LWN"), 1.19}, {("5", "1500#-LWN"), 1.375}, {("6", "1500#-LWN"), 1.5},
        {("8", "1500#-LWN"), 1.75}, {("10", "1500#-LWN"), 2.25}, {("12", "1500#-LWN"), 2.875},
        {("14", "1500#-LWN"), 2.75}, {("16", "1500#-LWN"), 2.875}, {("18", "1500#-LWN"), 2.75},
        {("20", "1500#-LWN"), 2.625}, {("24", "1500#-LWN"), 3.0},

        // 2500#-LWN - Updated values
        {("0.5", "2500#-LWN"), 0.655}, {("0.75", "2500#-LWN"), 0.655}, {("1", "2500#-LWN"), 0.625},
        {("1.25", "2500#-LWN"), 0.815}, {("1.5", "2500#-LWN"), 0.81}, {("2", "2500#-LWN"), 0.875},
        {("2.5", "2500#-LWN"), 1.0}, {("3", "2500#-LWN"), 1.125}, 
        {("4", "2500#-LWN"), 1.25}, {("5", "2500#-LWN"), 1.5}, {("6", "2500#-LWN"), 1.625},
        {("8", "2500#-LWN"), 2.0}, {("10", "2500#-LWN"), 2.375}, {("12", "2500#-LWN"), 2.69},
        

        // ============= HB (Heavy Barrel) Data =============
        // 150#-HB - Updated values
        {("0.5", "150#-HB"), 0.475}, {("0.75", "150#-HB"), 0.57}, {("1", "150#-HB"), 0.645},
        {("1.25", "150#-HB"), 0.67}, {("1.5", "150#-HB"), 0.75}, {("2", "150#-HB"), 0.875},
        {("2.5", "150#-HB"), 1.06}, {("3", "150#-HB"), 1.02}, {("3.5", "150#-HB"), 1.29},
        {("4", "150#-HB"), 1.305}, {("5", "150#-HB"), 1.22}, {("6", "150#-HB"), 1.245},
        {("8", "150#-HB"), 1.44}, {("10", "150#-HB"), 1.625}, {("12", "150#-HB"), 2.09},
        {("14", "150#-HB"), 1.56}, {("16", "150#-HB"), 1.81}, {("18", "150#-HB"), 1.47},
        {("20", "150#-HB"), 1.595}, {("24", "150#-HB"), 1.75},

        // 300#-HB - Updated values
        {("0.5", "300#-HB"), 0.6}, {("0.75", "300#-HB"), 0.725}, {("1", "300#-HB"), 0.74},
        {("1.25", "300#-HB"), 0.765}, {("1.5", "300#-HB"), 0.875}, {("2", "300#-HB"), 1.0},
        {("2.5", "300#-HB"), 1.15}, {("3", "300#-HB"), 1.24}, {("3.5", "300#-HB"), 1.32},
        {("4", "300#-HB"), 1.395}, {("5", "300#-HB"), 1.595}, {("6", "300#-HB"), 1.81},
        {("8", "300#-HB"), 1.97}, {("10", "300#-HB"), 2.03}, {("12", "300#-HB"), 2.28},
        {("14", "300#-HB"), 2.22}, {("16", "300#-HB"), 2.25}, {("18", "300#-HB"), 2.375},
        {("20", "300#-HB"), 2.5}, {("24", "300#-HB"), 2.81},

        // 400#-HB - Updated values
        {("0.5", "400#-HB"), 0.6}, {("0.75", "400#-HB"), 0.725}, {("1", "400#-HB"), 0.74},
        {("1.25", "400#-HB"), 0.765}, {("1.5", "400#-HB"), 0.875}, {("2", "400#-HB"), 1.0},
        {("2.5", "400#-HB"), 1.155}, {("3", "400#-HB"), 1.24}, {("3.5", "400#-HB"), 1.225},
        {("4", "400#-HB"), 1.305}, {("5", "400#-HB"), 1.5}, {("6", "400#-HB"), 1.715},
        {("8", "400#-HB"), 1.88}, {("10", "400#-HB"), 1.94}, {("12", "400#-HB"), 2.185},
        {("14", "400#-HB"), 2.125}, {("16", "400#-HB"), 2.155}, {("18", "400#-HB"), 2.28},
        {("20", "400#-HB"), 2.315}, {("24", "400#-HB"), 2.625},

        // 600#-HB - Updated values
        {("0.5", "600#-HB"), 0.6}, {("0.75", "600#-HB"), 0.725}, {("1", "600#-HB"), 0.74},
        {("1.25", "600#-HB"), 0.765}, {("1.5", "600#-HB"), 0.875}, {("2", "600#-HB"), 1.0},
        {("2.5", "600#-HB"), 1.15}, {("3", "600#-HB"), 1.24}, {("3.5", "600#-HB"), 1.225},
        {("4", "600#-HB"), 1.615}, {("5", "600#-HB"), 2.035}, {("6", "600#-HB"), 2.06},
        {("8", "600#-HB"), 2.16}, {("10", "600#-HB"), 2.72}, {("12", "600#-HB"), 2.935},
        {("14", "600#-HB"), 2.28}, {("16", "600#-HB"), 2.69}, {("18", "600#-HB"), 2.595},
        {("20", "600#-HB"), 2.97}, {("24", "600#-HB"), 3.03},

        // 900#-HB - Updated values
        {("0.5", "900#-HB"), 0.725}, {("0.75", "900#-HB"), 0.755}, {("1", "900#-HB"), 0.8},
        {("1.25", "900#-HB"), 0.83}, {("1.5", "900#-HB"), 0.875}, {("2", "900#-HB"), 1.56},
        {("2.5", "900#-HB"), 1.78}, {("3", "900#-HB"), 1.58}, 
        {("4", "900#-HB"), 1.805}, {("5", "900#-HB"), 2.095}, {("6", "900#-HB"), 2.465},
        {("8", "900#-HB"), 2.845}, {("10", "900#-HB"), 3.375}, {("12", "900#-HB"), 3.715},
        {("14", "900#-HB"), 2.81}, {("16", "900#-HB"), 2.845}, {("18", "900#-HB"), 3.03},
        {("20", "900#-HB"), 3.19}, {("24", "900#-HB"), 3.81},

        // 1500#-HB - Updated values
        {("0.5", "1500#-HB"), 0.725}, {("0.75", "1500#-HB"), 0.755}, {("1", "1500#-HB"), 0.8},
        {("1.25", "1500#-HB"), 0.83}, {("1.5", "1500#-HB"), 0.875}, {("2", "1500#-HB"), 1.56},
        {("2.5", "1500#-HB"), 1.78}, {("3", "1500#-HB"), 1.645}, 
        {("4", "1500#-HB"), 1.835}, {("5", "1500#-HB"), 2.155}, {("6", "1500#-HB"), 2.275},
        {("8", "1500#-HB"), 2.66}, {("10", "1500#-HB"), 3.25}, {("12", "1500#-HB"), 4.0},
        {("14", "1500#-HB"), 3.75}, {("16", "1500#-HB"), 3.94}, {("18", "1500#-HB"), 4.125},
        {("20", "1500#-HB"), 4.06}, {("24", "1500#-HB"), 4.81},

        // 2500#-HB - Updated values
        {("0.5", "2500#-HB"), 0.85}, {("0.75", "2500#-HB"), 0.88}, {("1", "2500#-HB"), 0.925},
        {("1.25", "2500#-HB"), 1.11}, {("1.5", "2500#-HB"), 1.22}, {("2", "2500#-HB"), 1.59},
        {("2.5", "2500#-HB"), 1.81}, {("3", "2500#-HB"), 2.05}, 
        {("4", "2500#-HB"), 2.275}, {("5", "2500#-HB"), 2.595}, {("6", "2500#-HB"), 2.81},
        {("8", "2500#-HB"), 3.25}, {("10", "2500#-HB"), 3.91}, {("12", "2500#-HB"), 4.37},
        

        // ============= EB (Equal Barrel) Data =============
        // 150#-EB - Updated values
        {("0.5", "150#-EB"), 1.5}, {("0.75", "150#-EB"), 1.565}, {("1", "150#-EB"), 1.625},
        {("1.25", "150#-EB"), 1.685}, {("1.5", "150#-EB"), 1.75}, {("2", "150#-EB"), 2.0},
        {("2.5", "150#-EB"), 2.25}, {("3", "150#-EB"), 2.25}, {("3.5", "150#-EB"), 2.5},
        {("4", "150#-EB"), 2.5}, {("5", "150#-EB"), 2.5}, {("6", "150#-EB"), 2.5},
        {("8", "150#-EB"), 2.75}, {("10", "150#-EB"), 3.0}, {("12", "150#-EB"), 3.5},
        {("14", "150#-EB"), 3.5}, {("16", "150#-EB"), 3.75}, {("18", "150#-EB"), 3.5},
        {("20", "150#-EB"), 3.75}, {("24", "150#-EB"), 4.0},

        // 300#-EB - Updated values
        {("0.5", "300#-EB"), 1.625}, {("0.75", "300#-EB"), 1.935}, {("1", "300#-EB"), 1.94},
        {("1.25", "300#-EB"), 2.0}, {("1.5", "300#-EB"), 2.31}, {("2", "300#-EB"), 2.25},
        {("2.5", "300#-EB"), 2.5}, {("3", "300#-EB"), 2.625}, {("3.5", "300#-EB"), 2.75},
        {("4", "300#-EB"), 3.0}, {("5", "300#-EB"), 3.0}, {("6", "300#-EB"), 3.25},
        {("8", "300#-EB"), 3.5}, {("10", "300#-EB"), 3.75}, {("12", "300#-EB"), 4.25},
        {("14", "300#-EB"), 4.5}, {("16", "300#-EB"), 4.75}, {("18", "300#-EB"), 5.0},
        {("20", "300#-EB"), 5.25}, {("24", "300#-EB"), 6.0},

        // 400#-EB - Same as 300#-EB
        {("0.5", "400#-EB"), 1.625}, {("0.75", "400#-EB"), 1.935}, {("1", "400#-EB"), 1.94},
        {("1.25", "400#-EB"), 2.0}, {("1.5", "400#-EB"), 2.31}, {("2", "400#-EB"), 2.25},
        {("2.5", "400#-EB"), 2.5}, {("3", "400#-EB"), 2.625}, {("3.5", "400#-EB"), 2.75},
        {("4", "400#-EB"), 3.0}, {("5", "400#-EB"), 3.0}, {("6", "400#-EB"), 3.25},
        {("8", "400#-EB"), 3.5}, {("10", "400#-EB"), 3.75}, {("12", "400#-EB"), 4.25},
        {("14", "400#-EB"), 4.5}, {("16", "400#-EB"), 4.75}, {("18", "400#-EB"), 5.0},
        {("20", "400#-EB"), 5.25}, {("24", "400#-EB"), 6.0},

        // 600#-EB - Updated values
        {("0.5", "600#-EB"), 1.625}, {("0.75", "600#-EB"), 1.935}, {("1", "600#-EB"), 1.94},
        {("1.25", "600#-EB"), 2.0}, {("1.5", "600#-EB"), 2.31}, {("2", "600#-EB"), 2.25},
        {("2.5", "600#-EB"), 2.5}, {("3", "600#-EB"), 2.625}, {("3.5", "600#-EB"), 2.75},
        {("4", "600#-EB"), 3.375}, {("5", "600#-EB"), 4.0}, {("6", "600#-EB"), 4.0},
        {("8", "600#-EB"), 4.25}, {("10", "600#-EB"), 5.0}, {("12", "600#-EB"), 5.0},
        {("14", "600#-EB"), 4.875}, {("16", "600#-EB"), 5.5}, {("18", "600#-EB"), 5.625},
        {("20", "600#-EB"), 6.0}, {("24", "600#-EB"), 6.5},

        // 900#-EB - Updated values
        {("0.5", "900#-EB"), 2.125}, {("0.75", "900#-EB"), 2.185}, {("1", "900#-EB"), 2.44},
        {("1.25", "900#-EB"), 2.5}, {("1.5", "900#-EB"), 2.75}, {("2", "900#-EB"), 3.25},
        {("2.5", "900#-EB"), 3.56}, {("3", "900#-EB"), 3.25}, 
        {("4", "900#-EB"), 3.75}, {("5", "900#-EB"), 4.375}, {("6", "900#-EB"), 4.5},
        {("8", "900#-EB"), 5.25}, {("10", "900#-EB"), 5.75}, {("12", "900#-EB"), 6.0},
        {("14", "900#-EB"), 5.625}, {("16", "900#-EB"), 5.875}, {("18", "900#-EB"), 6.5},
        {("20", "900#-EB"), 6.875}, {("24", "900#-EB"), 8.5},

        // 1500#-EB - Updated values
        {("0.5", "1500#-EB"), 2.125}, {("0.75", "1500#-EB"), 2.185}, {("1", "1500#-EB"), 2.44},
        {("1.25", "1500#-EB"), 2.5}, {("1.5", "1500#-EB"), 2.75}, {("2", "1500#-EB"), 3.25},
        {("2.5", "1500#-EB"), 3.560}, {("3", "1500#-EB"), 3.75}, 
        {("4", "1500#-EB"), 4.125}, {("5", "1500#-EB"), 4.875}, {("6", "1500#-EB"), 4.75},
        {("8", "1500#-EB"), 5.5}, {("10", "1500#-EB"), 6.5}, {("12", "1500#-EB"), 7.25},
        {("14", "1500#-EB"), 7.75}, {("16", "1500#-EB"), 8.25}, {("18", "1500#-EB"), 9.0},
        {("20", "1500#-EB"), 9.375}, {("24", "1500#-EB"), 11.0},

        // 2500#-EB - Updated values
        {("0.5", "2500#-EB"), 2.375}, {("0.75", "2500#-EB"), 2.375}, {("1", "2500#-EB"), 2.625},
        {("1.25", "2500#-EB"), 3.0}, {("1.5", "2500#-EB"), 3.25}, {("2", "2500#-EB"), 3.625},
        {("2.5", "2500#-EB"), 4.0}, {("3", "2500#-EB"), 4.5}, 
        {("4", "2500#-EB"), 5.0}, {("5", "2500#-EB"), 5.75}, {("6", "2500#-EB"), 6.5},
        {("8", "2500#-EB"), 6.875}, {("10", "2500#-EB"), 8.25}, {("12", "2500#-EB"), 9.0},
        
    };

        }
        
    
        

        private void InitializeComponentEvents()
        {
            
            this.btnClose.Click += BtnClose_Click;
            this.btnShowAllData.Click += BtnShowAllData_Click;

            this.cmbLWNSize.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            this.cmbLWNSchedule.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
        }

        private void PopulateComboBoxes()
        {
            // Clear existing items first to prevent duplicates
            cmbLWNSize.Items.Clear();
            cmbLWNSchedule.Items.Clear();

            // Populate size combo box
            cmbLWNSize.Items.AddRange(new object[] {
        "0.5", "0.75", "1", "1.25", "1.5", "2", "2.5", "3", "3.5", "4",
        "5", "6", "8", "10", "12", "14", "16", "18", "20", "24"});

            // Populate schedule combo box
            cmbLWNSchedule.Items.AddRange(new object[] {
        "150#-LWN", "300#-LWN", "400#-LWN", "600#-LWN", "900#-LWN", "1500#-LWN", "2500#-LWN",
        "150#-HB", "300#-HB", "400#-HB", "600#-HB", "900#-HB", "1500#-HB", "2500#-HB",
        "150#-EB", "300#-EB", "400#-EB", "600#-EB", "900#-EB", "1500#-EB", "2500#-EB"});

            // Set default selections to match screenshot (2" 300#-LWN)
            cmbLWNSize.SelectedItem = "2";
            cmbLWNSchedule.SelectedItem = "300#-LWN";

            // The calculation will now happen automatically through the SelectedIndexChanged event
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateThickness();
        }

        // Modified button click handler
        private void BtnLWNLookupThickness_Click(object sender, EventArgs e)
        {
            CalculateThickness();
        }

        // Extracted calculation logic into a separate method
        private void CalculateThickness()
        {
            try
            {
                if (cmbLWNSize.SelectedItem == null || cmbLWNSchedule.SelectedItem == null)
                {
                    // Don't show message box here since this might trigger during initialization
                    ClearResults();
                    return;
                }

                string size = cmbLWNSize.SelectedItem.ToString();
                string schedule = cmbLWNSchedule.SelectedItem.ToString();

                // Set the ID text box with the selected size
                txtLWNID.Text = size;

                if (thicknessData.TryGetValue((size, schedule), out double thickness))
                {
                    // Format thickness with 3 decimal places
                    txtLWNThickness.Text = thickness.ToString("0.###");

                    // Calculate limits according to ASME B16.5
                    double lowerLimit, upperLimit;

                    if (thickness <= 0.709) // 18mm or less
                    {
                        lowerLimit = thickness - 0.012;
                        upperLimit = thickness + 0.060;
                    }
                    else // greater than 18mm
                    {
                        lowerLimit = thickness - 0.020;
                        upperLimit = thickness + 0.060;
                    }

                    // Ensure lower limit doesn't go below zero
                    lowerLimit = Math.Max(lowerLimit, 0);

                    // Round to 3 decimal places
                    lowerLimit = Math.Round(lowerLimit, 3);
                    upperLimit = Math.Round(upperLimit, 3);

                    txtLWNLowerMil.Text = lowerLimit.ToString("0.###");
                    txtLWNUpperMil.Text = upperLimit.ToString("0.###");

                    // Calculate OD (OD = ID + (2 × Thickness))
                    if (double.TryParse(size, out double id))
                    {
                        double od = id + (2 * thickness);
                        txtLWNOD.Text = od.ToString("0.###");
                    }
                    else
                    {
                        txtLWNOD.Text = "N/A";
                    }
                }
                else
                {
                    ClearResults();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearResults();
            }
        }
       

        private void BtnShowAllData_Click(object sender, EventArgs e)
        {
            // Create a new form to display the data
            Form dataForm = new Form();
            dataForm.Text = "All LWN Thickness Data";
            dataForm.StartPosition = FormStartPosition.CenterParent;

            // Create a DataGridView to show the data
            DataGridView dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.DataSource = GetLWNDataTable();

            // Style the header row
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Add the DataGridView to the form
            dataForm.Controls.Add(dgv);

            // Calculate optimal form size
            int totalWidth = 0;
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                totalWidth += column.Width;
            }

            // Add extra width for borders and vertical scrollbar
            totalWidth += 40;

            // Calculate height (rows * row height + header height + some padding)
            int totalHeight = (dgv.Rows.Count * dgv.RowTemplate.Height) +
                              dgv.ColumnHeadersHeight + 60;

            // Set maximum reasonable size (adjust based on screen resolution)
            int maxWidth = Screen.FromControl(this).WorkingArea.Width - 100;
            int maxHeight = Screen.FromControl(this).WorkingArea.Height - 100;

            dataForm.Size = new Size(
                Math.Min(totalWidth, maxWidth),
                Math.Min(totalHeight, maxHeight)
            );

            // If we hit max dimensions, enable scrolling
            if (totalWidth > maxWidth)
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }

            // Show the form centered on the parent
            dataForm.Show(this);
        }

        private DataTable GetLWNDataTable()
        {
            DataTable table = new DataTable();

            // Add columns
            table.Columns.Add("Size (in)", typeof(string));
            table.Columns.Add("150#-LWN", typeof(string));
            table.Columns.Add("300#-LWN", typeof(string));
            table.Columns.Add("400#-LWN", typeof(string));
            table.Columns.Add("600#-LWN", typeof(string));
            table.Columns.Add("900#-LWN", typeof(string));
            table.Columns.Add("1500#-LWN", typeof(string));
            table.Columns.Add("2500#-LWN", typeof(string));
            table.Columns.Add("150#-HB", typeof(string));
            table.Columns.Add("300#-HB", typeof(string));
            table.Columns.Add("400#-HB", typeof(string));
            table.Columns.Add("600#-HB", typeof(string));
            table.Columns.Add("900#-HB", typeof(string));
            table.Columns.Add("1500#-HB", typeof(string));
            table.Columns.Add("2500#-HB", typeof(string));
            table.Columns.Add("150#-EB", typeof(string));
            table.Columns.Add("300#-EB", typeof(string));
            table.Columns.Add("400#-EB", typeof(string));
            table.Columns.Add("600#-EB", typeof(string));
            table.Columns.Add("900#-EB", typeof(string));
            table.Columns.Add("1500#-EB", typeof(string));
            table.Columns.Add("2500#-EB", typeof(string));

            // Add rows (using your data)
            string[] sizes = { "0.5", "0.75", "1", "1.25", "1.5", "2", "2.5", "3", "3.5", "4",
                      "5", "6", "8", "10", "12", "14", "16", "18", "20", "24" };

            foreach (string size in sizes)
            {
                table.Rows.Add(
                    size,
                    GetThicknessString(size, "150#-LWN"),
                    GetThicknessString(size, "300#-LWN"),
                    GetThicknessString(size, "400#-LWN"),
                    GetThicknessString(size, "600#-LWN"),
                    GetThicknessString(size, "900#-LWN"),
                    GetThicknessString(size, "1500#-LWN"),
                    GetThicknessString(size, "2500#-LWN"),
                    GetThicknessString(size, "150#-HB"),
                    GetThicknessString(size, "300#-HB"),
                    GetThicknessString(size, "400#-HB"),
                    GetThicknessString(size, "600#-HB"),
                    GetThicknessString(size, "900#-HB"),
                    GetThicknessString(size, "1500#-HB"),
                    GetThicknessString(size, "2500#-HB"),
                    GetThicknessString(size, "150#-EB"),
                    GetThicknessString(size, "300#-EB"),
                    GetThicknessString(size, "400#-EB"),
                    GetThicknessString(size, "600#-EB"),
                    GetThicknessString(size, "900#-EB"),
                    GetThicknessString(size, "1500#-EB"),
                    GetThicknessString(size, "2500#-EB")
                );
            }

            return table;
        }

        private string GetThicknessString(string size, string schedule)
        {
            return thicknessData.TryGetValue((size, schedule), out double t) ?
                   t.ToString("0.###") : "-";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearResults()
        {
            txtLWNThickness.Text = string.Empty;
            txtLWNLowerMil.Text = string.Empty;
            txtLWNUpperMil.Text = string.Empty;
            txtLWNID.Text = string.Empty;
            txtLWNOD.Text = string.Empty;
        }
    }
}