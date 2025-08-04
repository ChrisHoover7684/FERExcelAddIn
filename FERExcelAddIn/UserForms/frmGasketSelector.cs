using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace FERExcelAddin
{
    public partial class frmGasketSelector : Form
    {
        private bool useMetricUnits = false;
        private const double SAFETY_FACTOR = 0.8; // 80% of max rating for critical service

        public frmGasketSelector()
        {
            InitializeComponent();
            ConfigureResultsList();
            btnShowAllGasket.Click += btnShowAllGasket_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
        }

        private void ConfigureResultsList()
        {
            // Clear existing columns if any
            dgvResults.Columns.Clear();

            // Add columns with specific widths
            DataGridViewColumn typeColumn = new DataGridViewTextBoxColumn();
            typeColumn.Name = "Type";
            typeColumn.HeaderText = "Type";
            typeColumn.Width = 150;
            dgvResults.Columns.Add(typeColumn);

            DataGridViewColumn materialColumn = new DataGridViewTextBoxColumn();
            materialColumn.Name = "Material";
            materialColumn.HeaderText = "Material";
            materialColumn.Width = 200;
            dgvResults.Columns.Add(materialColumn);

            DataGridViewColumn pressureColumn = new DataGridViewTextBoxColumn();
            pressureColumn.Name = "Pressure";
            pressureColumn.HeaderText = "Max Pressure";
            pressureColumn.Width = 120;
            dgvResults.Columns.Add(pressureColumn);

            DataGridViewColumn tempColumn = new DataGridViewTextBoxColumn();
            tempColumn.Name = "Temperature";
            tempColumn.HeaderText = "Temp Range";
            tempColumn.Width = 150;
            dgvResults.Columns.Add(tempColumn);

            DataGridViewColumn notesColumn = new DataGridViewTextBoxColumn();
            notesColumn.Name = "Notes";
            notesColumn.HeaderText = "Notes";
            notesColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvResults.Columns.Add(notesColumn);

            // Other configuration
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Important for fixed widths
            dgvResults.RowHeadersVisible = false;
            dgvResults.AllowUserToAddRows = false;
            dgvResults.ReadOnly = true;
            dgvResults.ScrollBars = ScrollBars.Vertical;
            dgvResults.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            dgvResults.DefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewColumn column in dgvResults.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            dgvResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvResults.RowTemplate.Height = 40;
        }

        private void frmGasketSelector_Load(object sender, EventArgs e)
        {
            InitializeDropdowns();
            UpdateUnitLabels();
        }

        private void InitializeDropdowns()
        {
            // Fluid types with hazardous services marked
            cmbFluidType.Items.AddRange(new string[] {
        "Hydrocarbon", "Water", "Acid",
        "Hydrofluoric Acid (HF)", "Caustic", "Steam",
        "Gas", "Chemical", "Air", "Refrigerant", "Cryogenic"
    });
            cmbFluidType.SelectedIndex = 0;

            cmbFlangeType.Items.AddRange(new string[] {
        "RF (Raised Face)", "FF (Flat Face)",
        "RTJ (Ring Type Joint)", "Lap Joint"
    });
            cmbFlangeType.SelectedIndex = 0;

            // Removed standards dropdown completely
            // Add service severity options
            cmbServiceSeverity.Items.AddRange(new string[] {
        "Normal", "Cyclic", "Critical", "Hazardous"
    });
            cmbServiceSeverity.SelectedIndex = 0;
        }

        private void UpdateUnitLabels()
        {
            if (useMetricUnits)
            {
                lblPressure.Text = "Pressure (kPa):";
                lblTemperature.Text = "Temperature (°C):";
                lblMinTemp.Text = "Min Temp (°C):";
                lblPressureUnit.Text = "kPa";
                lblTempUnit.Text = "°C";
                lblMinTempUnit.Text = "°C";
                btnToggleUnits.Text = "Switch to Imperial Units";
            }
            else
            {
                lblPressure.Text = "Pressure (psi):";
                lblTemperature.Text = "Temperature (°F):";
                lblMinTemp.Text = "Min Temp (°F):";
                lblPressureUnit.Text = "psi";
                lblTempUnit.Text = "°F";
                lblMinTempUnit.Text = "°F";
                btnToggleUnits.Text = "Switch to Metric Units";
            }
        }

        private List<Gasket> GetGasketDatabase()
        {
            return new List<Gasket>
            {
                // 1. SPIRAL WOUND GASKETS (Complete Set)
                new Gasket {
                    Type = "Spiral Wound",
                    Subtype = "Standard",
                    Material = "SS304 + Flexible Graphite",
                    Standards = "ASME B16.20, ASME B16.5, ASME B31.3",
                    MaxPressure = 3000,
                    MaxPressureMetric = 20684,
                    MaxTemp = 1200,
                    MaxTempMetric = 649,
                    MinTemp = -325,
                    MinTempMetric = -198,
                    PressureClass = "150-2500",
                    AvailableSizes = "1/2\" to 60\"",
                    SeatingStress = "10,000-22,000 psi",
                    Applications = "Refineries, Petrochemical, Power Plants",
                    Alternatives = new List<string>{"SS316 + Graphite", "Carbon Steel + Graphite"},
                    FluidCompatibility = "Hydrocarbon,Steam,Water,Acid",
                    FlangeTypes = "RF,RTJ",
                    Notes = "Most common for hydrocarbon services"
                },
                new Gasket {
                    Type = "Spiral Wound",
                    Subtype = "Fire-Safe",
                    Material = "SS316 + Mica/ceramic filler",
                    Standards = "ASME B16.20, API 607, ASME B31.3",
                    MaxPressure = 2500,
                    MaxPressureMetric = 17237,
                    MaxTemp = 1500,
                    MaxTempMetric = 816,
                    MinTemp = -50,
                    MinTempMetric = -46,
                    PressureClass = "150-1500",
                    AvailableSizes = "1/2\" to 24\"",
                    SeatingStress = "12,000-20,000 psi",
                    Applications = "Fire-prone areas, Furnaces",
                    Alternatives = new List<string>{"Inconel + ceramic filler"},
                    FluidCompatibility = "Hydrocarbon,Steam",
                    FlangeTypes = "RF",
                    Notes = "API 607 fire-safe certified"
                },

                // 2. RING TYPE JOINTS (Complete Set)
                new Gasket {
                    Type = "RTJ",
                    Subtype = "R (Octagonal)",
                    Material = "Soft Iron",
                    Standards = "API 6A, ASME B16.20, ISO 10423",
                    MaxPressure = 5000,
                    MaxPressureMetric = 34474,
                    MaxTemp = 800,
                    MaxTempMetric = 427,
                    MinTemp = -20,
                    MinTempMetric = -29,
                    PressureClass = "300-2500",
                    AvailableSizes = "1/2\" to 24\"",
                    SeatingStress = "30,000-45,000 psi",
                    Applications = "High Pressure Pipelines, Wellheads",
                    Alternatives = new List<string>{"Low Carbon Steel", "SS304"},
                    FluidCompatibility = "Gas,Steam,Oil",
                    FlangeTypes = "RTJ",
                    Notes = "Standard for API 6A applications"
                },
                new Gasket {
                    Type = "RTJ",
                    Subtype = "BX",
                    Material = "Inconel 718",
                    Standards = "API 6A, ISO 10423",
                    MaxPressure = 20000,
                    MaxPressureMetric = 137895,
                    MaxTemp = 650,
                    MaxTempMetric = 343,
                    MinTemp = -50,
                    MinTempMetric = -46,
                    PressureClass = "5000-20000 psi",
                    AvailableSizes = "1/2\" to 24\"",
                    SeatingStress = "45,000-60,000 psi",
                    Applications = "Subsea equipment, HPHT",
                    Alternatives = new List<string>{"SS316"},
                    FluidCompatibility = "Gas,Oil",
                    FlangeTypes = "RTJ",
                    Notes = "For subsea HPHT applications"
                },

                // 3. KAMMPROFILE GASKETS
                new Gasket {
                    Type = "Kammprofile",
                    Subtype = "Grooved Metal + Graphite",
                    Material = "SS316 + Graphite",
                    Standards = "ASME B16.20, ASME B16.5",
                    MaxPressure = 3000,
                    MaxPressureMetric = 20684,
                    MaxTemp = 1000,
                    MaxTempMetric = 538,
                    MinTemp = -325,
                    MinTempMetric = -198,
                    PressureClass = "150-2500",
                    AvailableSizes = "1/2\" to 60\"",
                    SeatingStress = "15,000-30,000 psi",
                    Applications = "Offshore platforms, Heat exchangers",
                    Alternatives = new List<string>{"Inconel 625", "Titanium"},
                    FluidCompatibility = "Steam,Oil,Chemical",
                    FlangeTypes = "RF",
                    Notes = "Excellent for thermal cycling"
                },

                // 4. LENS GASKETS
                new Gasket {
                    Type = "Lens Gasket",
                    Material = "316 SS",
                    Standards = "DIN 2696",
                    MaxPressure = 10000,
                    MaxPressureMetric = 68948,
                    MaxTemp = 600,
                    MaxTempMetric = 316,
                    MinTemp = -200,
                    MinTempMetric = -129,
                    PressureClass = "Up to 10,000 psi",
                    AvailableSizes = "1/2\" to 12\"",
                    SeatingStress = "40,000-50,000 psi",
                    Applications = "Gas compressors, Ultra-high pressure",
                    Alternatives = new List<string>{"Monel"},
                    FluidCompatibility = "Gas,Steam",
                    FlangeTypes = "RTJ",
                    Notes = "For ultra-high pressure systems"
                },

                // 5. SPECIALTY GASKETS
                new Gasket {
                    Type = "Insulating Gasket",
                    Material = "PTFE + SS304",
                    Standards = "ASME B16.5, ASME B31.3",
                    MaxPressure = 300,
                    MaxPressureMetric = 2068,
                    MaxTemp = 260,
                    MaxTempMetric = 127,
                    MinTemp = -50,
                    MinTempMetric = -46,
                    PressureClass = "150",
                    AvailableSizes = "1/2\" to 24\"",
                    SeatingStress = "3,000-5,000 psi",
                    Applications = "Pipelines with cathodic protection",
                    Alternatives = new List<string>{"Ceramic + SS"},
                    FluidCompatibility = "Water,Oil",
                    FlangeTypes = "RF,FF",
                    Notes = "For galvanic isolation" },

                new Gasket {
                    Type = "Spiral Wound",
                    Material = "SS316 + Flexible Graphite",
                    Standards = "ASME B16.20, ASME B16.5, API 601, ASME B31.3",
                    MaxPressure = 3000,
                    MaxPressureMetric = 20684,
                    MaxTemp = 1200,
                    MaxTempMetric = 649,
                    MinTemp = -325,
                    MinTempMetric = -198,
                    PressureClass = "150-2500",
                    AvailableSizes = "1/2\" to 60\"",
                    SeatingStress = "10,000-22,000 psi",
                    Applications = "Chemical Processing, Marine",
                    Alternatives = new List<string>{"SS304 + Graphite", "Monel + Graphite"},
                    FluidCompatibility = "Hydrocarbon,Steam,Water,Acid,Seawater",
                    FlangeTypes = "RF,RTJ"
                },
                new Gasket {
                    Type = "Spiral Wound",
                    Material = "Inconel 625 + PTFE",
                    Standards = "ASME B16.20, ASME B16.5, ASME B31.3",
                    MaxPressure = 1500,
                    MaxPressureMetric = 10342,
                    MaxTemp = 500,
                    MaxTempMetric = 260,
                    MinTemp = -100,
                    MinTempMetric = -73,
                    PressureClass = "150-900",
                    AvailableSizes = "1/2\" to 24\"",
                    SeatingStress = "7,000-15,000 psi",
                    Applications = "Chemical Processing, Pharmaceuticals",
                    Alternatives = new List<string>{"Hastelloy + PTFE", "Titanium + PTFE"},
                    FluidCompatibility = "Chemical,Acid,HF",
                    FlangeTypes = "RF",
                    Notes = "For highly corrosive services"
                },
                new Gasket {
                    Type = "Spiral Wound",
                    Material = "Hastelloy C276 + Flexible Graphite",
                    Standards = "ASME B16.20, ASME B16.5, ASME B31.3",
                    MaxPressure = 2500,
                    MaxPressureMetric = 17237,
                    MaxTemp = 800,
                    MaxTempMetric = 427,
                    MinTemp = -150,
                    MinTempMetric = -101,
                    PressureClass = "150-1500",
                    AvailableSizes = "1/2\" to 24\"",
                    SeatingStress = "12,000-20,000 psi",
                    Applications = "HF Alkylation, Hot Caustic",
                    Alternatives = new List<string>{"Inconel 625 + Graphite", "Monel + Graphite"},
                    FluidCompatibility = "Acid,HF,Caustic",
                    FlangeTypes = "RF,RTJ",
                    Notes = "For severe corrosive services"
                },

        // 2. RING TYPE JOINTS (Complete Set)
                new Gasket {
                    Type = "RTJ",
                    Material = "Soft Iron",
                    Standards = "ASME B16.20, ASME B16.5, API 6A, ASME B31.3",
                    MaxPressure = 5000,
                    MaxPressureMetric = 34474,
                    MaxTemp = 800,
                    MaxTempMetric = 427,
                    MinTemp = -20,
                    MinTempMetric = -29,
                    PressureClass = "300-2500",
                    AvailableSizes = "1/2\" to 24\"",
                    SeatingStress = "30,000-45,000 psi",
                    Applications = "High Pressure Pipelines, Wellheads",
                    Alternatives = new List<string>{"Low Carbon Steel", "SS304"},
                    FluidCompatibility = "Gas,Steam,Oil",
                    FlangeTypes = "RTJ",
                    Notes = "Standard for API 6A applications"
                },
                new Gasket {
                    Type = "RTJ",
                    Subtype = "RX (Pressure-Energized)",
                    Material = "Inconel 625",
                    Standards = "API 6A, ISO 10423",
                    MaxPressure = 15000,  // psi
                    MaxTemp = 650,        // °F
                    Notes = "Self-energizing for wellhead equipment"
                },
                new Gasket {
                    Type = "RTJ",
                    Material = "SS316",
                    Standards = "ASME B16.20, ASME B16.5, API 6A, ASME B31.3",
                    MaxPressure = 6000,
                    MaxPressureMetric = 41369,
                    MaxTemp = 1000,
                    MaxTempMetric = 538,
                    MinTemp = -325,
                    MinTempMetric = -198,
                    PressureClass = "300-2500",
                    AvailableSizes = "1/2\" to 24\"",
                    SeatingStress = "30,000-45,000 psi",
                    Applications = "Offshore, Chemical, Cryogenic",
                    Alternatives = new List<string>{"SS304", "Monel"},
                    FluidCompatibility = "Gas,Steam,Chemical,Seawater",
                    FlangeTypes = "RTJ"
                },
                new Gasket {
                    Type = "RTJ",
                    Material = "Monel",
                    Standards = "ASME B16.20, ASME B16.5, ASME B31.3",
                    MaxPressure = 4500,
                    MaxPressureMetric = 31026,
                    MaxTemp = 900,
                    MaxTempMetric = 482,
                    MinTemp = -325,
                    MinTempMetric = -198,
                    PressureClass = "300-1500",
                    AvailableSizes = "1/2\" to 24\"",
                    SeatingStress = "30,000-45,000 psi",
                    Applications = "HF Service, Marine",
                    Alternatives = new List<string>{"Inconel 600", "Hastelloy C276"},
                    FluidCompatibility = "HF,Steam,Seawater",
                    FlangeTypes = "RTJ",
                    Notes = "Best for HF alkylation units"
                },
                new Gasket {
                    Type = "RTJ",
                    Material = "Nickel 200",
                    Standards = "ASME B16.20, ASME B16.5, ASME B31.3",
                    MaxPressure = 5000,
                    MaxPressureMetric = 34474,
                    MaxTemp = 800,
                    MaxTempMetric = 427,
                    MinTemp = -425,
                    MinTempMetric = -254,
                    PressureClass = "300-2500",
                    AvailableSizes = "1/2\" to 12\"",
                    SeatingStress = "30,000-45,000 psi",
                    Applications = "Cryogenic, LNG",
                    Alternatives = new List<string>{"SS316L", "Aluminum"},
                    FluidCompatibility = "Cryogenic,LNG,Oxygen",
                    FlangeTypes = "RTJ",
                    Notes = "For liquid nitrogen/oxygen service"
                },

        // 3. SHEET GASKETS (Complete Set)
                new Gasket {
                    Type = "Non-Asbestos Sheet",
                    Material = "Aramid Fiber + NBR",
                    Standards = "ASTM F104, ASME B16.21, ASME B31.3",
                    MaxPressure = 300,
                    MaxPressureMetric = 2068,
                    MaxTemp = 400,
                    MaxTempMetric = 204,
                    MinTemp = -20,
                    MinTempMetric = -29,
                    PressureClass = "150-300",
                    AvailableSizes = "1/8\" to 1/4\" thickness",
                    SeatingStress = "2,000-7,000 psi",
                    Applications = "Water, Air, Low Pressure Steam",
                    Alternatives = new List<string>{"Cellulose Fiber", "Glass Fiber"},
                    FluidCompatibility = "Water,Air,Steam",
                    FlangeTypes = "RF,FF",
                    Notes = "General purpose sheet gasket"
                },
                new Gasket {
                    Type = "Compressed Sheet",
                    Material = "Graphite",
                    Standards = "ASTM F104, ASME B16.21, ASME B31.3",
                    MaxPressure = 2500,
                    MaxPressureMetric = 17237,
                    MaxTemp = 1000,
                    MaxTempMetric = 538,
                    MinTemp = -450,
                    MinTempMetric = -268,
                    PressureClass = "150-900",
                    AvailableSizes = "1/16\" to 1/4\" thickness",
                    SeatingStress = "5,000-15,000 psi",
                    Applications = "Heat Exchangers, Boilers",
                    Alternatives = new List<string>{"PTFE Sheet", "Mica Sheet"},
                    FluidCompatibility = "Steam,Chemical,Acid",
                    FlangeTypes = "RF",
                    Notes = "Excellent for high temperature"
                },
        new Gasket {
            Type = "PTFE Sheet",
            Material = "Virgin PTFE",
            Standards = "ASTM D3295, ASME B16.21, ASME B31.3",
            MaxPressure = 150,
            MaxPressureMetric = 1034,
            MaxTemp = 450,
            MaxTempMetric = 232,
            MinTemp = -320,
            MinTempMetric = -196,
            PressureClass = "150",
            AvailableSizes = "1/32\" to 1/2\" thickness",
            SeatingStress = "2,000-5,000 psi",
            Applications = "Chemical Processing, Food",
            Alternatives = new List<string>{"Expanded PTFE", "Filled PTFE"},
            FluidCompatibility = "Acid,Chemical,Food",
            FlangeTypes = "RF,FF",
            Notes = "Not for caustics or steam >300°F"
        },

        // 4. PTFE GASKETS (Complete Set)
        new Gasket {
            Type = "PTFE Envelope",
            Material = "Virgin PTFE (SS304 core)",
            Standards = "ASME B16.21, ASME B31.3",
            MaxPressure = 300,
            MaxPressureMetric = 2068,
            MaxTemp = 450,
            MaxTempMetric = 232,
            MinTemp = -320,
            MinTempMetric = -196,
            PressureClass = "150-300",
            AvailableSizes = "1/2\" to 24\"",
            SeatingStress = "3,000-7,000 psi",
            Applications = "Chemical Processing, Food",
            Alternatives = new List<string>{"Expanded PTFE", "Filled PTFE"},
            FluidCompatibility = "Acid,Chemical,Food",
            FlangeTypes = "RF,FF",
            Notes = "For full vacuum service"
        },
        new Gasket {
            Type = "PTFE Envelope",
            Material = "Expanded PTFE (SS316 core)",
            Standards = "ASME B16.21, ASME B31.3",
            MaxPressure = 300,
            MaxPressureMetric = 2068,
            MaxTemp = 500,
            MaxTempMetric = 260,
            MinTemp = -320,
            MinTempMetric = -196,
            PressureClass = "150-300",
            AvailableSizes = "1/2\" to 24\"",
            SeatingStress = "3,000-7,000 psi",
            Applications = "Chemical Processing, Caustic",
            Alternatives = new List<string>{"Virgin PTFE", "Filled PTFE"},
            FluidCompatibility = "Acid,Chemical,Caustic",
            FlangeTypes = "RF,FF",
            Notes = "For ≤20% NaOH/KOH <250°F"
        },
        new Gasket {
            Type = "PTFE Envelope",
            Material = "Caustic Grade PTFE (SS316L core)",
            Standards = "ASME B16.21, ASME B31.3",
            MaxPressure = 300,
            MaxPressureMetric = 2068,
            MaxTemp = 300,
            MaxTempMetric = 149,
            MinTemp = -320,
            MinTempMetric = -196,
            PressureClass = "150-300",
            AvailableSizes = "1/2\" to 24\"",
            SeatingStress = "3,000-7,000 psi",
            Applications = "Caustic Service",
            Alternatives = new List<string>{"Spiral Wound Hastelloy", "RTJ Monel"},
            FluidCompatibility = "Caustic,Chemical",
            FlangeTypes = "RF,FF",
            Notes = "For ≤30% NaOH/KOH <300°F"
        },

        // 5. METAL JACKETED (Complete Set)
        new Gasket {
            Type = "Double Jacketed",
            Material = "SS304 + Flexible Graphite",
            Standards = "ASME B16.20, ASME B16.5, ASME B31.3",
            MaxPressure = 2500,
            MaxPressureMetric = 17237,
            MaxTemp = 1000,
            MaxTempMetric = 538,
            MinTemp = -325,
            MinTempMetric = -198,
            PressureClass = "150-1500",
            AvailableSizes = "1/2\" to 24\"",
            SeatingStress = "15,000-25,000 psi",
            Applications = "Heat Exchangers, Boilers",
            Alternatives = new List<string>{"Single Jacketed", "Corrugated Metal"},
            FluidCompatibility = "Steam,Oil,Water",
            FlangeTypes = "RF",
            Notes = "For heat exchanger channels"
        },
        new Gasket {
            Type = "Single Jacketed",
            Material = "SS316 + PTFE",
            Standards = "ASME B16.20, ASME B16.5, ASME B31.3",
            MaxPressure = 1500,
            MaxPressureMetric = 10342,
            MaxTemp = 500,
            MaxTempMetric = 260,
            MinTemp = -100,
            MinTempMetric = -73,
            PressureClass = "150-600",
            AvailableSizes = "1/2\" to 24\"",
            SeatingStress = "10,000-20,000 psi",
            Applications = "Chemical Processing",
            Alternatives = new List<string>{"Double Jacketed", "Spiral Wound"},
            FluidCompatibility = "Acid,Chemical",
            FlangeTypes = "RF",
            Notes = "For corrosive services <500°F"
        },

        // 6. KAMPROFILE (Complete Set)
        new Gasket {
            Type = "Kamprofile",
            Material = "SS304 + Graphite",
            Standards = "ASME B16.20, ASME B16.5, ASME B31.3",
            MaxPressure = 3000,
            MaxPressureMetric = 20684,
            MaxTemp = 1200,
            MaxTempMetric = 649,
            MinTemp = -325,
            MinTempMetric = -198,
            PressureClass = "150-2500",
            AvailableSizes = "1/2\" to 60\"",
            SeatingStress = "15,000-30,000 psi",
            Applications = "Heat Exchangers, Reactors",
            Alternatives = new List<string>{"Spiral Wound", "Double Jacketed"},
            FluidCompatibility = "Steam,Oil,Chemical",
            FlangeTypes = "RF",
            Notes = "Excellent for thermal cycling"
        },
        new Gasket {
    Type = "Metal Core",
    Material = "Carbon Steel + Graphite Facing",
    Standards = "ASME B16.20, ASME B16.5, ASME B31.3",
    MaxPressure = 2500,
    MaxPressureMetric = 17237,
    MaxTemp = 1000,
    MaxTempMetric = 538,
    MinTemp = -50,
    MinTempMetric = -46,
    PressureClass = "150-900",
    AvailableSizes = "1/2\" to 24\"",
    SeatingStress = "12,000-18,000 psi",
    Applications = "Heat exchangers, pumps, valves",
    Alternatives = new List<string>{"SS304 Core", "SS316 Core"},
    FluidCompatibility = "Steam,Oil,Water",
    FlangeTypes = "RF",
    Notes = "Better recovery than spiral wound for cyclic service"
},
        // 7. CORRUGATED METAL (Complete Set)
        new Gasket {
            Type = "Corrugated Metal",
            Material = "Aluminum",
            Standards = "ASME B16.21, ASME B31.3",
            MaxPressure = 800,
            MaxPressureMetric = 5516,
            MaxTemp = 400,
            MaxTempMetric = 204,
            MinTemp = -452,
            MinTempMetric = -269,
            PressureClass = "150-300",
            AvailableSizes = "1/2\" to 24\"",
            SeatingStress = "5,000-10,000 psi",
            Applications = "Cryogenic, Air, Oxygen",
            Alternatives = new List<string>{"Copper", "SS304"},
            FluidCompatibility = "Cryogenic,Air,Oxygen",
            FlangeTypes = "RF",
            Notes = "For liquid hydrogen/oxygen service"
        },

        // 8. SPECIALTY GASKETS
        new Gasket {
            Type = "Mica",
            Material = "Flexible Mica",
            Standards = "ASTM D3528, ASME B31.3",
            MaxPressure = 3000,
            MaxPressureMetric = 20684,
            MaxTemp = 1500,
            MaxTempMetric = 816,
            MinTemp = -100,
            MinTempMetric = -73,
            PressureClass = "150-900",
            AvailableSizes = "1/16\" to 1/4\" thickness",
            SeatingStress = "8,000-15,000 psi",
            Applications = "High Temperature Flue Gas",
            Alternatives = new List<string>{"Graphite Sheet", "Ceramic Fiber"},
            FluidCompatibility = "Flue Gas,Exhaust",
            FlangeTypes = "RF",
            Notes = "For exhaust systems >1000°F"
        },
         new Gasket {
            Type = "Double-Convolution Metal Jacket",
            Material = "316SS + Flexible Graphite",
            Standards = "ASME B16.20, ASME B16.5",
            MaxPressure = 4500,
            MaxPressureMetric = 31026,
            MaxTemp = 1500,
            MaxTempMetric = 816,
            MinTemp = -325,
            MinTempMetric = -198,
            PressureClass = "900-2500",
            AvailableSizes = "1/2\" to 24\"",
            SeatingStress = "25,000-40,000 psi",
            Applications = "Ultra-HP steam, Reformer furnaces",
            FluidCompatibility = "Steam,Hydrocarbon",
            FlangeTypes = "RF",
            Notes = "For pressure cycling >5,000 psi"
        },
          new Gasket {
            Type = "Twin-Seal",
            Material = "Dual Inconel 625 layers",
            Standards = "API 6A, ASME B31.3",
            MaxPressure = 10000,
            MaxPressureMetric = 68948,
            MaxTemp = -425,
            MaxTempMetric = -254,
            MinTemp = -425,
            MinTempMetric = -254,
            PressureClass = "Special",
            AvailableSizes = "2\" to 12\"",
            SeatingStress = "35,000-50,000 psi",
            Applications = "LNG terminals, Cryogenic",
            FluidCompatibility = "LNG,Liquid Nitrogen",
            FlangeTypes = "RTJ",
            Notes = "Zero-leak guarantee at cryogenic temps"
        },
        new Gasket {
    Type = "Expanded PTFE",
    Material = "ePTFE (100% PTFE)",
    Standards = "ASME B16.21, FDA, USP Class VI",
    MaxPressure = 300,
    MaxPressureMetric = 2068,
    MaxTemp = 500,
    MaxTempMetric = 260,
    MinTemp = -320,
    MinTempMetric = -196,
    PressureClass = "150",
    AvailableSizes = "1/16\" to 1/2\" thickness",
    SeatingStress = "2,000-5,000 psi",
    Applications = "Pharmaceutical, Food, Ultra-clean",
    Alternatives = new List<string>{"Filled PTFE", "Virgin PTFE"},
    FluidCompatibility = "Acid,Chemical,Caustic,Food",
    FlangeTypes = "RF,FF",
    Notes = "Excellent for FDA/USP compliant systems"
},
        new Gasket {
    Type = "Camprofile",
    Material = "SS316 + PTFE Filler",
    Standards = "ASME B16.20, ASME B16.5",
    MaxPressure = 1500,
    MaxPressureMetric = 10342,
    MaxTemp = 500,
    MaxTempMetric = 260,
    MinTemp = -320,
    MinTempMetric = -196,
    PressureClass = "150-600",
    AvailableSizes = "1/2\" to 24\"",
    SeatingStress = "10,000-20,000 psi",
    Applications = "Chemical processing, Acid services",
    Alternatives = new List<string>{"Graphite Filled", "Flexible Graphite"},
    FluidCompatibility = "Acid,Chemical,HF",
    FlangeTypes = "RF",
    Notes = "PTFE filler provides excellent chemical resistance"
},
        new Gasket {
    Type = "Thermiculite",
    Material = "SS304 + Thermiculite 815",
    Standards = "ASME B16.20, ASME B16.5",
    MaxPressure = 3000,
    MaxPressureMetric = 20684,
    MaxTemp = 1500,
    MaxTempMetric = 816,
    MinTemp = -100,
    MinTempMetric = -73,
    PressureClass = "150-900",
    AvailableSizes = "1/2\" to 24\"",
    SeatingStress = "15,000-25,000 psi",
    Applications = "Exhaust systems, High temp flanges",
    Alternatives = new List<string>{"Mica", "Ceramic Fiber"},
    FluidCompatibility = "Exhaust,Flue Gas,Steam",
    FlangeTypes = "RF",
    Notes = "Fire-safe certification available"
},
        new Gasket {
    Type = "Kammprofile",
    Material = "Titanium + Flexible Graphite",
    Standards = "ASME B16.20, ASME B16.5",
    MaxPressure = 3000,
    MaxPressureMetric = 20684,
    MaxTemp = 1000,
    MaxTempMetric = 538,
    MinTemp = -325,
    MinTempMetric = -198,
    PressureClass = "150-1500",
    AvailableSizes = "1/2\" to 60\"",
    SeatingStress = "15,000-30,000 psi",
    Applications = "Titanium process equipment, Seawater",
    Alternatives = new List<string>{"Hastelloy Core", "Monel Core"},
    FluidCompatibility = "Seawater,Chlorides,Acids",
    FlangeTypes = "RF",
    Notes = "Ideal for titanium piping systems"
},
        new Gasket {
    Type = "Rubber",
    Material = "NBR (Nitrile)",
    Standards = "ASTM D2000, ASME B16.21",
    MaxPressure = 150,
    MaxPressureMetric = 1034,
    MaxTemp = 250,
    MaxTempMetric = 121,
    MinTemp = -20,
    MinTempMetric = -29,
    PressureClass = "150",
    AvailableSizes = "1/8\" to 1\" thickness",
    SeatingStress = "1,000-3,000 psi",
    Applications = "Fuel oil, Water, Hydraulic fluid",
    Alternatives = new List<string>{"EPDM", "Neoprene"},
    FluidCompatibility = "Oil,Fuel,Water",
    FlangeTypes = "RF,FF",
    Notes = "Resistant to oils and fuels"
},
        new Gasket {
    Type = "Ceramic Fiber",
    Material = "Alumina-Silica",
    Standards = "ASTM C795",
    MaxPressure = 500,
    MaxPressureMetric = 3447,
    MaxTemp = 2300,
    MaxTempMetric = 1260,
    MinTemp = -100,
    MinTempMetric = -73,
    PressureClass = "150",
    AvailableSizes = "1/8\" to 1\" thickness",
    SeatingStress = "3,000-5,000 psi",
    Applications = "Furnaces, Boilers, Incinerators",
    Alternatives = new List<string>{"Mica", "Graphite"},
    FluidCompatibility = "Flue Gas,Hot Air",
    FlangeTypes = "RF",
    Notes = "For extreme temperature applications"
},
        new Gasket {
            Type = "Nuclear Grade",
            Subtype = "Reactor Coolant",
            Material = "Inconel 690",
            Standards = "ASME Section III, RCC-M",
            MaxPressure = 3500,
            MaxPressureMetric = 24132,
            MaxTemp = 1200,
            MaxTempMetric = 649,
            MinTemp = -50,
            MinTempMetric = -46,
            PressureClass = "Nuclear Class 1",
            AvailableSizes = "3/4\" to 16\"",
            SeatingStress = "30,000-45,000 psi",
            Applications = "PWR/BWR reactor systems",
            FluidCompatibility = "Borated Water",
            FlangeTypes = "RF,RTJ",
            Notes = "Radiation-resistant alloy"
        },
        new Gasket {
            Type = "Offshore Marine",
            Material = "Super Duplex SS + Graphite",
            Standards = "NORSOK M-650, DNVGL",
            MaxPressure = 5000,
            MaxPressureMetric = 34474,
            MaxTemp = 600,
            MaxTempMetric = 316,
            MinTemp = -40,
            MinTempMetric = -40,
            PressureClass = "1500-2500",
            AvailableSizes = "1\" to 36\"",
            SeatingStress = "20,000-35,000 psi",
            Applications = "Subsea, Seawater systems",
            FluidCompatibility = "Seawater,CO2,H2S",
            FlangeTypes = "RF",
            Notes = "PREN >40 for chloride resistance"
        },
         new Gasket {
            Type = "Graphene-Enhanced",
            Material = "SS316 + Graphene filler",
            Standards = "ASME B16.20, ASTM F37",
            MaxPressure = 3000,
            MaxPressureMetric = 20684,
            MaxTemp = 1800,
            MaxTempMetric = 982,
            MinTemp = -300,
            MinTempMetric = -184,
            PressureClass = "900-1500",
            AvailableSizes = "1/2\" to 12\"",
            SeatingStress = "15,000-25,000 psi",
            Applications = "High heat flux systems",
            FluidCompatibility = "Steam,Flue Gas",
            FlangeTypes = "RF",
            Notes = "30% better thermal conductivity"
        },
        new Gasket {
            Type = "Smart Gasket",
            Material = "Inconel 718 + embedded sensors",
            Standards = "API 6A Annex F",
            MaxPressure = 5000,
            MaxPressureMetric = 34474,
            MaxTemp = 650,
            MaxTempMetric = 343,
            MinTemp = -100,
            MinTempMetric = -73,
            PressureClass = "Special",
            AvailableSizes = "2\" to 8\"",
            SeatingStress = "30,000-45,000 psi",
            Applications = "Digital twin monitoring",
            FluidCompatibility = "Gas,Oil",
            FlangeTypes = "RTJ",
            Notes = "IoT-enabled with strain gauges"
        },

        // 4. RTJ Subtypes (3 new entries)
        new Gasket {
            Type = "RTJ",
            Subtype = "RX (Pressure-Energized)",
            Material = "Inconel 625",
            Standards = "API 6A, ISO 10423",
            MaxPressure = 15000,
            MaxPressureMetric = 103421,
            MaxTemp = 650,
            MaxTempMetric = 343,
            MinTemp = -50,
            MinTempMetric = -46,
            PressureClass = "5000-15000 psi",
            AvailableSizes = "1\" to 16\"",
            SeatingStress = "45,000-65,000 psi",
            Applications = "Christmas trees, Wellheads",
            FluidCompatibility = "Gas,Oil,CO2",
            FlangeTypes = "RTJ",
            Notes = "Pressure-energized sealing"
        },

        // 5. Extreme Environment (2 new entries)
        new Gasket {
            Type = "Graphoil",
            Material = "Flexible Graphite + SS316",
            Standards = "ASME B16.20",
            MaxPressure = 5000,
            MaxPressureMetric = 34474,
            MaxTemp = 1600,
            MaxTempMetric = 871,
            MinTemp = -450,
            MinTempMetric = -268,
            PressureClass = "900-2500",
            AvailableSizes = "1/8\" to 1\" thickness",
            SeatingStress = "8,000-12,000 psi",
            Applications = "Furnace flanges, Cokers",
            FluidCompatibility = "Flue Gas,Steam",
            FlangeTypes = "RF",
            Notes = "Not for oxygen service >300°F"
        },
        new Gasket {
            Type = "Teflon-Encapsulated",
            Material = "PTFE-encased EPDM",
            Standards = "FDA 21 CFR 177.1550",
            MaxPressure = 300,
            MaxPressureMetric = 2068,
            MaxTemp = 400,
            MaxTempMetric = 204,
            MinTemp = -60,
            MinTempMetric = -51,
            PressureClass = "150",
            AvailableSizes = "1/4\" to 24\"",
            SeatingStress = "2,000-5,000 psi",
            Applications = "Chemical splash zones",
            FluidCompatibility = "Acid,Caustic",
            FlangeTypes = "RF,FF",
            Notes = "Impervious to chemical penetration"
        },
    
            new Gasket {
            Type = "Rubber",
            Material = "EPDM",
            Standards = "ASTM D2000, ASME B31.3",
            MaxPressure = 150,
            MaxPressureMetric = 1034,
            MaxTemp = 250,
            MaxTempMetric = 121,
            MinTemp = -50,
            MinTempMetric = -46,
            PressureClass = "150",
            AvailableSizes = "1/8\" to 1/2\" thickness",
            SeatingStress = "1,000-3,000 psi",
            Applications = "Water, Air, Food",
            Alternatives = new List<string>{"NBR", "Neoprene"},
            FluidCompatibility = "Water,Air,Food",
            FlangeTypes = "RF,FF",
            Notes = "For potable water systems"
        }
    };

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var input = GetUserInputs();
            var isHFService = input.Fluid.Contains("Hydrofluoric Acid (HF)");
            var isCryogenicService = input.Fluid.Contains("Cryogenic");

            dgvResults.Rows.Clear(); // Clear existing results

            if (isHFService) AddHFWarnings();
            if (isCryogenicService) AddCryogenicWarnings();

            SearchGaskets(input, isHFService, isCryogenicService);
        }

        private bool ValidateInputs()
        {
            if (!double.TryParse(txtPressure.Text, out _) ||
                !double.TryParse(txtTemperature.Text, out _) ||
                (!string.IsNullOrEmpty(txtMinTemp.Text) && !double.TryParse(txtMinTemp.Text, out _)))
            {
                MessageBox.Show("Please enter valid numerical values for all temperature and pressure fields.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private UserInputs GetUserInputs()
        {
            return new UserInputs
            {
                Pressure = useMetricUnits ?
                    double.Parse(txtPressure.Text) :
                    double.Parse(txtPressure.Text) * 6.89476,
                Temperature = useMetricUnits ?
                    double.Parse(txtTemperature.Text) :
                    (double.Parse(txtTemperature.Text) - 32) * 5 / 9,
                MinTemperature = string.IsNullOrEmpty(txtMinTemp.Text) ?
                    (useMetricUnits ? -273.15 : -459.67) :
                    (useMetricUnits ?
                        double.Parse(txtMinTemp.Text) :
                        (double.Parse(txtMinTemp.Text) - 32) * 5 / 9),
                Fluid = cmbFluidType.SelectedItem?.ToString() ?? "",
                Flange = cmbFlangeType.SelectedItem?.ToString().Split(' ')[0] ?? "",
                Severity = cmbServiceSeverity.SelectedItem?.ToString() ?? "Normal"
            };
        }

        private void AddHFWarnings()
        {
            dgvResults.Rows.Add(new object[] {
        "=== API RP 751 HF SERVICE REQUIREMENTS ===",
        "",
        "",
        "",
        "• RTJ flanges mandatory for HF service\n" +
        "• Monel or Inconel gaskets required for concentrations >70%\n" +
        "• Helium leak testing required post-installation"
    });
        }

        private void AddCryogenicWarnings()
        {
            dgvResults.Rows.Add(new object[] {
        "=== CRYOGENIC SERVICE REQUIREMENTS ===",
        "",
        "",
        "",
        "• Materials must maintain ductility at cryogenic temps\n" +
        "• Consider thermal contraction in bolting\n" +
        "• ASME B31.3 para. 323.2.2 applies"
    });
        }

        private void SearchGaskets(UserInputs input, bool isHFService, bool isCryogenicService)
        {
            var gasketDB = GetGasketDatabase();
            bool foundMatches = false;
            var pressureUnit = useMetricUnits ? "kPa" : "psi";
            var tempUnit = useMetricUnits ? "°C" : "°F";

            foreach (var gasket in gasketDB)
            {
                // ADD DEBUGGING CODE HERE
                Debug.WriteLine($"Checking gasket: {gasket.Type} - {gasket.Material}");
                Debug.WriteLine($"  FluidCompat: {gasket.FluidCompatibility ?? "null"}");
                Debug.WriteLine($"  FlangeTypes: {gasket.FlangeTypes ?? "null"}");
                Debug.WriteLine($"  InputFlange: {input.Flange}");
                Debug.WriteLine($"  IsHFService: {isHFService}");
                Debug.WriteLine($"  FluidMatch: {gasket.FluidCompatibility?.Contains("HF") ?? false}");
                Debug.WriteLine($"  FlangeMatch: {gasket.FlangeTypes?.Contains(input.Flange) ?? false}");
                Debug.WriteLine($"  Pressure: {input.Pressure} <= {gasket.MaxPressureMetric * GetSeverityFactor(input.Severity)}: {input.Pressure <= gasket.MaxPressureMetric * GetSeverityFactor(input.Severity)}");
                Debug.WriteLine($"  Temp: {input.Temperature} <= {gasket.MaxTempMetric}: {input.Temperature <= gasket.MaxTempMetric}");
                Debug.WriteLine($"  MinTemp: {input.MinTemperature} >= {gasket.MinTempMetric}: {input.MinTemperature >= gasket.MinTempMetric}");

                if (IsGasketSuitable(gasket, input, isHFService, isCryogenicService))
                {
                    AddGasketToResults(gasket, input, pressureUnit, tempUnit, isHFService);
                    foundMatches = true;
                }
            }

            if (!foundMatches)
            {
                dgvResults.Rows.Add(new object[] {
            "No suitable gaskets found",
            "",
            "",
            "",
            "Consider:\n" +
            "- Adjusting temperature/pressure ranges\n" +
            "- Changing flange type\n" +
            "- Consulting a materials specialist"
        });
            }
        }


        private bool IsGasketSuitable(Gasket gasket, UserInputs input, bool isHFService, bool isCryogenicService)
        {
            // Null check for critical objects
            if (gasket == null || input == null)
                return false;

            // Apply safety factor based on service severity
            double pressureLimit = gasket.MaxPressureMetric * GetSeverityFactor(input.Severity);
            double tempLimit = gasket.MaxTempMetric;

            // Safe fluid compatibility check
            bool fluidCompatible;
            if (isHFService)
            {
                fluidCompatible = gasket.FluidCompatibility?.Contains("HF") ?? false;
            }
            else if (isCryogenicService)
            {
                fluidCompatible = gasket.FluidCompatibility?.Contains("Cryogenic") ?? false;
            }
            else
            {
                fluidCompatible = !string.IsNullOrEmpty(input.Fluid) &&
                                 (gasket.FluidCompatibility?.Contains(input.Fluid) ?? false);
            }

            // Safe numerical comparisons
            bool pressureOK = input.Pressure <= pressureLimit;
            bool tempOK = input.Temperature <= tempLimit;
            bool minTempOK = input.MinTemperature >= gasket.MinTempMetric;

            // Safe flange type check
            bool flangeOK = !string.IsNullOrEmpty(input.Flange) &&
                           !string.IsNullOrEmpty(gasket.FlangeTypes) &&
                           gasket.FlangeTypes.Contains(input.Flange);

            // Special rule for HF service - must be RTJ flange
            if (isHFService && input.Flange != "RTJ")
                return false;

            return fluidCompatible && pressureOK && tempOK && minTempOK && flangeOK;
        }

        private double GetSeverityFactor(string severity)
        {
            switch (severity)
            {
                case "Critical":
                    return SAFETY_FACTOR * 0.9;    // Additional 10% safety margin
                case "Hazardous":
                    return SAFETY_FACTOR * 0.85;    // Additional 15% safety margin
                case "Cyclic":
                    return SAFETY_FACTOR * 0.95;    // Additional 5% safety margin
                default:
                    return SAFETY_FACTOR;           // Normal service
            }
        }

        private void AddGasketToResults(Gasket gasket, UserInputs input,
                      string pressureUnit, string tempUnit, bool isHFService)
        {
            string type = gasket.Type;
            string material = gasket.Material;
            string pressure = $"{(useMetricUnits ? gasket.MaxPressureMetric : gasket.MaxPressure)} {pressureUnit}";
            string tempRange = $"{(useMetricUnits ? gasket.MinTempMetric : gasket.MinTemp)} to " +
                              $"{(useMetricUnits ? gasket.MaxTempMetric : gasket.MaxTemp)}{tempUnit}";

            string notes = "";

            // Highlight special service gaskets
            if (isHFService && (gasket.Material.Contains("Monel") || gasket.Material.Contains("Hastelloy")))
                notes += "HF-RATED\n";
            else if (gasket.FluidCompatibility.Contains("Cryogenic"))
                notes += "CRYOGENIC\n";

            // Add any special notes
            if (!string.IsNullOrEmpty(gasket.Notes))
            {
                notes += $"Note: {gasket.Notes}";
            }

            dgvResults.Rows.Add(new object[] { type, material, pressure, tempRange, notes });
        }
        private void btnShowAllGasket_Click(object sender, EventArgs e)
        {
            dgvResults.Rows.Clear(); // Clear existing results

            var gasketDB = GetGasketDatabase();
            var pressureUnit = useMetricUnits ? "kPa" : "psi";
            var tempUnit = useMetricUnits ? "°C" : "°F";

            foreach (var gasket in gasketDB)
            {
                string pressure = $"{(useMetricUnits ? gasket.MaxPressureMetric : gasket.MaxPressure)} {pressureUnit}";
                string tempRange = $"{(useMetricUnits ? gasket.MinTempMetric : gasket.MinTemp)} to " +
                                 $"{(useMetricUnits ? gasket.MaxTempMetric : gasket.MaxTemp)}{tempUnit}";

                string notes = "";

                // Include standards information in the notes
                if (!string.IsNullOrEmpty(gasket.Standards))
                {
                    notes += $"Standards: {gasket.Standards}\n";
                }

                // Add any special notes
                if (!string.IsNullOrEmpty(gasket.Notes))
                {
                    notes += $"Note: {gasket.Notes}";
                }

                dgvResults.Rows.Add(new object[] {
            gasket.Type + (string.IsNullOrEmpty(gasket.Subtype) ? "" : $" ({gasket.Subtype})"),
            gasket.Material,
            pressure,
            tempRange,
            notes
        });
            }

            // Add summary information
            dgvResults.Rows.Insert(0, new object[] {
        "=== ALL GASKET TYPES ===",
        "",
        "",
        "",
        $"Showing all {gasketDB.Count} available gasket configurations"
    });
        }
        private void HighlightMatchingCells(string searchText)
        {
            // Clear all highlighting first
            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.Empty;
                    cell.Style.ForeColor = SystemColors.ControlText;
                }
            }

            // Skip if search is empty or it's the header row
            if (string.IsNullOrWhiteSpace(searchText)) return;

            // Only search in Type (0), Material (1), and Notes (4) columns
            int[] columnsToSearch = { 0, 1, 4 };

            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                // Skip header rows (those starting with "===")
                if (row.Cells[0].Value?.ToString().StartsWith("===") ?? false)
                    continue;

                foreach (int colIndex in columnsToSearch)
                {
                    if (row.Cells[colIndex].Value != null &&
                        row.Cells[colIndex].Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // Highlight only the matching cell with a light yellow background
                        row.Cells[colIndex].Style.BackColor = Color.FromArgb(255, 255, 200);
                    }
                }
            }
        }

        private void FilterDataGridView(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Show all rows if search is empty
                foreach (DataGridViewRow row in dgvResults.Rows)
                {
                    row.Visible = true;
                }
                return;
            }

            // Only search in Type (0), Material (1), and Notes (4) columns
            int[] columnsToSearch = { 0, 1, 4 };

            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                // Always show header rows
                if (row.Cells[0].Value?.ToString().StartsWith("===") ?? false)
                {
                    row.Visible = true;
                    continue;
                }

                bool rowVisible = false;
                foreach (int colIndex in columnsToSearch)
                {
                    if (row.Cells[colIndex].Value != null &&
                        row.Cells[colIndex].Value.ToString().IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        rowVisible = true;
                        break;
                    }
                }
                row.Visible = rowVisible;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterDataGridView(txtSearch.Text);
            HighlightMatchingCells(txtSearch.Text);
        }

               
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbFluidType.SelectedIndex = 0;
            cmbFlangeType.SelectedIndex = 0;
            cmbServiceSeverity.SelectedIndex = 0;
            txtPressure.Clear();
            txtTemperature.Clear();
            txtMinTemp.Clear();
            dgvResults.Rows.Clear();
        }
       


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnToggleUnits_Click(object sender, EventArgs e)
        {
            // Convert current values
            ConvertField(txtPressure, 6.89476, 0.145038, "F2");
            ConvertField(txtTemperature, t => (t - 32) * 5 / 9, t => t * 9 / 5 + 32, "F1");
            ConvertField(txtMinTemp, t => (t - 32) * 5 / 9, t => t * 9 / 5 + 32, "F1");

            // Toggle unit system
            useMetricUnits = !useMetricUnits;
            UpdateUnitLabels();
        }

        private void ConvertField(TextBox box, double metricFactor, double imperialFactor, string format)
        {
            if (double.TryParse(box.Text, out double value))
            {
                box.Text = (useMetricUnits ?
                    value * imperialFactor :
                    value * metricFactor).ToString(format);
            }
        }

        private void ConvertField(TextBox box, Func<double, double> toMetric,
                                Func<double, double> toImperial, string format)
        {
            if (double.TryParse(box.Text, out double value))
            {
                box.Text = (useMetricUnits ?
                    toImperial(value) :
                    toMetric(value)).ToString(format);
            }
        }
    }

    public class Gasket
    {
        public string Type { get; set; }
        public string Subtype { get; set; }  // Added to better match reference table
        public string Material { get; set; }
        public string Standards { get; set; }
        public double MaxPressure { get; set; }       // psi
        public double MaxPressureMetric { get; set; }  // kPa
        public double MaxTemp { get; set; }           // °F
        public double MaxTempMetric { get; set; }     // °C
        public double MinTemp { get; set; } = -459.67;     // °F
        public double MinTempMetric { get; set; } = -273.15; // °C
        public string FluidCompatibility { get; set; }
        public string FlangeTypes { get; set; }
        public string Notes { get; set; }
        public string PressureClass { get; set; }
        public string AvailableSizes { get; set; }
        public string SeatingStress { get; set; }
        public string Applications { get; set; }
        public List<string> Alternatives { get; set; }
    }

    public class UserInputs
    {
        public double Pressure { get; set; }       // Always in kPa
        public double Temperature { get; set; }    // Always in °C
        public double MinTemperature { get; set; } // Always in °C
        public string Fluid { get; set; }
        public string Flange { get; set; }
        public string Severity { get; set; }       

    }
}


