using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FERExcelAddIn
{
    public partial class NominalThicknessForm : Form
    {
        private Dictionary<(string size, string schedule), double> thicknessData;

        public NominalThicknessForm()
        {
            InitializeComponent();
            InitializeThicknessData();
            InitializeComponentEvents();
            PopulateComboBoxes();

            

            // Adjust the row styles to fill the space left by the removed button
            this.tableLayoutPanel1.RowStyles[2].Height = 0;
        }

        private void InitializeThicknessData()
        {
            thicknessData = new Dictionary<(string size, string schedule), double>()
    {
        // 0.125 inch
        {("0.125", "10"), 0.049}, {("0.125", "10s"), 0.049}, {("0.125", "30"), 0.057 },
        {("0.125", "40"), 0.068}, {("0.125", "40s"), 0.068}, {("0.125", "STD"), 0.068},
        {("0.125", "80"), 0.095}, {("0.125", "80s"), 0.095}, {("0.125", "XS"), 0.095},
        
        // 0.25 inch
        {("0.25", "10"), 0.065}, {("0.25", "10s"), 0.065}, {("0.25", "30"), 0.073 },
        {("0.25", "40"), 0.088}, {("0.25", "40s"), 0.088}, {("0.25", "STD"), 0.088},
        {("0.25", "80"), 0.119}, {("0.25", "80s"), 0.119}, {("0.25", "XS"), 0.119},
        
        // 0.375 inch
        {("0.375", "10"), 0.065}, {("0.375", "10s"), 0.065}, {("0.375", "30"), 0.073},
        {("0.375", "40"), 0.091}, {("0.375", "40s"), 0.091}, {("0.375", "STD"), 0.091},
        {("0.375", "80"), 0.126}, {("0.375", "80s"), 0.126}, {("0.375", "XS"), 0.126},
        
        // 0.5 inch
        {("0.5", "5"), 0.065}, {("0.5", "5s"), 0.065},
        {("0.5", "10"), 0.083}, {("0.5", "10s"), 0.083}, {("0.5", "30"), 0.095 },
        {("0.5", "40"), 0.109}, {("0.5", "40s"), 0.109}, {("0.5", "STD"), 0.109},
        {("0.5", "80"), 0.147}, {("0.5", "80s"), 0.147}, {("0.5", "XS"), 0.147},
        {("0.5", "160"), 0.188}, {("0.5", "XXS"), 0.294},
        
        // 0.75 inch
        {("0.75", "5"), 0.065}, {("0.75", "5s"), 0.065},
        {("0.75", "10"), 0.083}, {("0.75", "10s"), 0.083}, {("0.75", "30"), 0.095 },
        {("0.75", "40"), 0.113}, {("0.75", "40s"), 0.113}, {("0.75", "STD"), 0.113},
        {("0.75", "80"), 0.154}, {("0.75", "80s"), 0.154}, {("0.75", "XS"), 0.154},
        {("0.75", "160"), 0.219}, {("0.75", "XXS"), 0.308},
        
        // 1 inch
        {("1", "5"), 0.065}, {("1", "5s"), 0.065},
        {("1", "10"), 0.109}, {("1", "10s"), 0.109}, {("1", "30"), 0.114 },
        {("1", "40"), 0.133}, {("1", "40s"), 0.133}, {("1", "STD"), 0.133},
        {("1", "80"), 0.179}, {("1", "80s"), 0.179}, {("1", "XS"), 0.179},
        {("1", "160"), 0.250}, {("1", "XXS"), 0.358},
        
        // 1.25 inch
        {("1.25", "5"), 0.065}, {("1.25", "5s"), 0.065},
        {("1.25", "10"), 0.109}, {("1.25", "10s"), 0.109}, {("1.25", "30"), 0.117 },
        {("1.25", "40"), 0.140}, {("1.25", "40s"), 0.140}, {("1.25", "STD"), 0.140},
        {("1.25", "80"), 0.191}, {("1.25", "80s"), 0.191}, {("1.25", "XS"), 0.191},
        {("1.25", "160"), 0.250}, {("1.25", "XXS"), 0.382},
        
        // 1.5 inch
        {("1.5", "5"), 0.065}, {("1.5", "5s"), 0.065},
        {("1.5", "10"), 0.109}, {("1.5", "10s"), 0.109},{("1.5", "30"), 0.125 },
        {("1.5", "40"), 0.145}, {("1.5", "40s"), 0.145}, {("1.5", "STD"), 0.145},
        {("1.5", "80"), 0.200}, {("1.5", "80s"), 0.200}, {("1.5", "XS"), 0.200},
        {("1.5", "160"), 0.281}, {("1.5", "XXS"), 0.400},
        
        // 2 inch
        {("2", "5"), 0.065}, {("2", "5s"), 0.065},
        {("2", "10"), 0.109}, {("2", "10s"), 0.109},{("2", "30"), 0.125 },
        {("2", "40"), 0.154}, {("2", "40s"), 0.154}, {("2", "STD"), 0.154},
        {("2", "80"), 0.218}, {("2", "80s"), 0.218}, {("2", "XS"), 0.218},
        {("2", "160"), 0.344}, {("2", "XXS"), 0.436},
        
        // 2.5 inch
        {("2.5", "5"), 0.083}, {("2.5", "5s"), 0.083},
        {("2.5", "10"), 0.120}, {("2.5", "10s"), 0.120},{("2.5", "30"), 0.188 },
        {("2.5", "40"), 0.203}, {("2.5", "40s"), 0.203}, {("2.5", "STD"), 0.203},
        {("2.5", "80"), 0.276}, {("2.5", "80s"), 0.276}, {("2.5", "XS"), 0.276},
        {("2.5", "160"), 0.375}, {("2.5", "XXS"), 0.552},
        
        // 3 inch
        {("3", "5"), 0.083}, {("3", "5s"), 0.083},
        {("3", "10"), 0.120}, {("3", "10s"), 0.120}, {("3", "30"), 0.188 },
        {("3", "40"), 0.216}, {("3", "40s"), 0.216}, {("3", "STD"), 0.216},
        {("3", "80"), 0.300}, {("3", "80s"), 0.300}, {("3", "XS"), 0.300},
        {("3", "160"), 0.438}, {("3", "XXS"), 0.600},
        
        // 3.5 inch
        {("3.5", "5"), 0.083}, {("3.5", "5s"), 0.083},
        {("3.5", "10"), 0.120}, {("3.5", "10s"), 0.120}, {("3.5", "30"), 0.188 },
        {("3.5", "40"), 0.226}, {("3.5", "40s"), 0.226}, {("3.5", "STD"), 0.226},
        {("3.5", "80"), 0.318}, {("3.5", "80s"), 0.318}, {("3.5", "XS"), 0.318},
        {("3.5", "XXS"), 0.636},
        
        // 4 inch
        {("4", "5"), 0.083}, {("4", "5s"), 0.083},
        {("4", "10"), 0.120}, {("4", "10s"), 0.120}, {("4", "30"), 0.188},
        {("4", "40"), 0.237}, {("4", "40s"), 0.237}, {("4", "STD"), 0.237},
        {("4", "80"), 0.337}, {("4", "80s"), 0.337}, {("4", "XS"), 0.337},
        {("4", "120"), 0.438}, {("4", "160"), 0.531}, {("4", "XXS"), 0.674},
        
        // 5 inch
        {("5", "5"), 0.109}, {("5", "5s"), 0.109},
        {("5", "10"), 0.134}, {("5", "10s"), 0.134},
        {("5", "40"), 0.258}, {("5", "40s"), 0.258}, {("5", "STD"), 0.258},
        {("5", "80"), 0.375}, {("5", "80s"), 0.375}, {("5", "XS"), 0.375},
        {("5", "120"), 0.500}, {("5", "160"), 0.625}, {("5", "XXS"), 0.750},
        
        // 6 inch
        {("6", "5"), 0.109}, {("6", "5s"), 0.109},
        {("6", "10"), 0.134}, {("6", "10s"), 0.134},
        {("6", "40"), 0.280}, {("6", "40s"), 0.280}, {("6", "STD"), 0.280},
        {("6", "80"), 0.432}, {("6", "80s"), 0.432}, {("6", "XS"), 0.432},
        {("6", "120"), 0.562}, {("6", "160"), 0.719}, {("6", "XXS"), 0.864},
        
        // 8 inch
        {("8", "5"), 0.109}, {("8", "5s"), 0.109},
        {("8", "10"), 0.148}, {("8", "10s"), 0.148},
        {("8", "20"), 0.250}, {("8", "30"), 0.277},
        {("8", "40"), 0.322}, {("8", "40s"), 0.322}, {("8", "STD"), 0.322},
        {("8", "60"), 0.406}, {("8", "80"), 0.500}, {("8", "80s"), 0.500}, {("8", "XS"), 0.500},
        {("8", "100"), 0.594}, {("8", "120"), 0.719}, {("8", "140"), 0.812}, {("8", "160"), 0.906}, {("8", "XXS"), 0.875},
        
        // 10 inch
        {("10", "5"), 0.134}, {("10", "5s"), 0.134},
        {("10", "10"), 0.165}, {("10", "10s"), 0.165},
        {("10", "20"), 0.250}, {("10", "30"), 0.307},
        {("10", "40"), 0.365}, {("10", "40s"), 0.365}, {("10", "STD"), 0.365},
        {("10", "60"), 0.500}, {("10", "80"), 0.594}, {("10", "80s"), 0.500}, {("10", "XS"), 0.500},
        {("10", "100"), 0.719}, {("10", "120"), 0.844}, {("10", "140"), 1.000}, {("10", "160"), 1.125}, {("10", "XXS"), 1.000},
        
        // 12 inch
        {("12", "5"), 0.156}, {("12", "5s"), 0.156},
        {("12", "10"), 0.180}, {("12", "10s"), 0.180},
        {("12", "20"), 0.250}, {("12", "30"), 0.330},
        {("12", "40"), 0.406}, {("12", "40s"), 0.375}, {("12", "STD"), 0.375},
        {("12", "60"), 0.562}, {("12", "80"), 0.688}, {("12", "80s"), 0.500}, {("12", "XS"), 0.500},
        {("12", "100"), 0.844}, {("12", "120"), 1.000}, {("12", "140"), 1.125}, {("12", "160"), 1.312}, {("12", "XXS"), 1.000},
        
        // 14 inch
        {("14", "5"), 0.156}, {("14", "5s"), 0.156},
        {("14", "10"), 0.250}, {("14", "10s"), 0.188},
        {("14", "20"), 0.312}, {("14", "30"), 0.375},
        {("14", "40"), 0.438}, {("14", "40s"), 0.375}, {("14", "STD"), 0.375},
        {("14", "60"), 0.594}, {("14", "80"), 0.750}, {("14", "80s"), 0.500}, {("14", "XS"), 0.500},
        {("14", "100"), 0.938}, {("14", "120"), 1.094}, {("14", "140"), 1.250}, {("14", "160"), 1.406},
        
        // 16 inch
        {("16", "5"), 0.165}, {("16", "5s"), 0.165},
        {("16", "10"), 0.250}, {("16", "10s"), 0.188},
        {("16", "20"), 0.312}, {("16", "30"), 0.375},
        {("16", "40"), 0.500}, {("16", "40s"), 0.375}, {("16", "STD"), 0.375},
        {("16", "60"), 0.656}, {("16", "80"), 0.844}, {("16", "80s"), 0.500}, {("16", "XS"), 0.500},
        {("16", "100"), 1.031}, {("16", "120"), 1.219}, {("16", "140"), 1.438}, {("16", "160"), 1.594},
        
        // 18 inch
        {("18", "5"), 0.165}, {("18", "5s"), 0.165},
        {("18", "10"), 0.250}, {("18", "10s"), 0.188},
        {("18", "20"), 0.312}, {("18", "30"), 0.438},
        {("18", "40"), 0.562}, {("18", "40s"), 0.375}, {("18", "STD"), 0.375},
        {("18", "60"), 0.750}, {("18", "80"), 0.938}, {("18", "80s"), 0.500}, {("18", "XS"), 0.500},
        {("18", "100"), 1.156}, {("18", "120"), 1.375}, {("18", "140"), 1.562}, {("18", "160"), 1.781},
        
        // 20 inch
        {("20", "5"), 0.188}, {("20", "5s"), 0.188},
        {("20", "10"), 0.250}, {("20", "10s"), 0.218},
        {("20", "20"), 0.375}, {("20", "30"), 0.500},
        {("20", "40"), 0.594}, {("20", "40s"), 0.375}, {("20", "STD"), 0.375},
        {("20", "60"), 0.812}, {("20", "80"), 1.031}, {("20", "80s"), 0.500}, {("20", "XS"), 0.500},
        {("20", "100"), 1.281}, {("20", "120"), 1.500}, {("20", "140"), 1.750}, {("20", "160"), 1.969},
        
        // 22 inch
        {("22", "5"), 0.188}, {("22", "5s"), 0.188},
        {("22", "10"), 0.250}, {("22", "10s"), 0.218},
        {("22", "20"), 0.375}, {("22", "30"), 0.500},
        {("22", "STD"), 0.375},
        {("22", "60"), 0.875}, {("22", "80"), 1.125},  {("22", "XS"), 0.500},
        {("22", "100"), 1.375}, {("22", "120"), 1.625}, {("22", "140"), 1.875}, {("22", "160"), 2.125},
        
        // 24 inch
        {("24", "5"), 0.218}, {("24", "5s"), 0.218},
        {("24", "10"), 0.250}, {("24", "10s"), 0.250},
        {("24", "20"), 0.375}, {("24", "30"), 0.562},
        {("24", "40"), 0.688}, {("24", "40s"), 0.375}, {("24", "STD"), 0.375},
        {("24", "60"), 0.969}, {("24", "80"), 1.218}, {("24", "80s"), 0.500}, {("24", "XS"), 0.500},
        {("24", "100"), 1.531}, {("24", "120"), 1.812}, {("24", "140"), 2.062}, {("24", "160"), 2.344},
        
        // 26 inch
        {("26", "10"), 0.312}, {("26", "20"), 0.500},
        {("26", "STD"), 0.375}, {("26", "XS"), 0.500},
        
        // 28 inch
        {("28", "10"), 0.312}, {("28", "20"), 0.500},
        {("28", "30"), 0.625}, {("28", "STD"), 0.375}, {("28", "XS"), 0.500},
        
        // 30 inch
        {("30", "5"), 0.250}, {("30", "5s"), 0.250},
        {("30", "10"), 0.312}, {("30", "10s"), 0.312},
        {("30", "20"), 0.500}, {("30", "30"), 0.625},
        {("30", "STD"), 0.375}, {("30", "XS"), 0.500},
        
        // 32 inch
        {("32", "10"), 0.312}, {("32", "20"), 0.500},
        {("32", "30"), 0.625}, {("32", "40"), 0.688},
        {("32", "STD"), 0.375}, {("32", "XS"), 0.500},
        
        // 34 inch
        {("34", "10"), 0.312}, {("34", "20"), 0.500},
        {("34", "30"), 0.625}, {("34", "40"), 0.688},
        {("34", "STD"), 0.375}, {("34", "XS"), 0.500},
        
        // 36 inch
        {("36", "10"), 0.312}, {("36", "20"), 0.500},
        {("36", "30"), 0.625}, {("36", "40"), 0.750},
        {("36", "STD"), 0.375}, {("36", "XS"), 0.500},
        
        // 42 inch
        {("42", "STD"), 0.375}, {("42", "XS"), 0.500}
    };
        }


        private void InitializeComponentEvents()
        {
            // Remove existing handlers to prevent duplicates
            this.cmbPipeSize.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
            this.cmbSchedule.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
            this.btnClose.Click -= btnClose_Click;
            this.btnShowAllData.Click -= btnShowAllData_Click;

            // Wire up events for automatic calculation
            this.cmbPipeSize.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            this.cmbSchedule.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            this.btnClose.Click += btnClose_Click;
            this.btnShowAllData.Click += btnShowAllData_Click;
        }

        private void PopulateComboBoxes()
        {
            // Clear existing items
            cmbPipeSize.Items.Clear();
            cmbSchedule.Items.Clear();

            // Populate size combo box
            cmbPipeSize.Items.AddRange(new object[] {
               "0.125","0.25","0.375","0.5","0.75","1","1.25","1.5","2","2.5","3","3.5","4","5","6","8","10","12","14","16","18","20","22","24","26","28","30","32","34","36","42",});

            // Populate schedule combo box
            cmbSchedule.Items.AddRange(new object[] {
                "OD","5","5s","10","10s","20","30","40","40s","STD","60","80","80s","XS","100","120","140","160","XXS",});

            // Set default selections to 2" Schedule 80
            cmbPipeSize.SelectedItem = "2";
            cmbSchedule.SelectedItem = "80";

            // Trigger initial calculation
            CalculateThickness();
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateThickness();
        }

        private void CalculateThickness()
        {
            try
            {
                if (cmbPipeSize.SelectedItem == null || cmbSchedule.SelectedItem == null)
                {
                    ClearResults();
                    return;
                }

                string size = cmbPipeSize.SelectedItem.ToString();
                string schedule = cmbSchedule.SelectedItem.ToString();

                if (thicknessData.TryGetValue((size, schedule), out double thickness))
                {
                    // Set the nominal thickness
                    txtThickness.Text = thickness.ToString("0.###");

                    // Calculate and set the lower limit (-12.5%)
                    double lowerLimit = thickness * 0.875; // 100% - 12.5% = 87.5%
                    txtLowerMil.Text = lowerLimit.ToString("0.###");

                    // Calculate and set the upper limit (+12.5%)
                    double upperLimit = thickness * 1.125; // 100% + 12.5% = 112.5%
                    txtUpperMil.Text = upperLimit.ToString("0.###");

                    // Get standard OD from lookup table
                    if (StandardODs.TryGetValue(size, out double od))
                    {
                        // Display the standard OD (directly from lookup)
                        txtOD.Text = od.ToString("0.###");

                        // Calculate ID (ID = OD - 2*thickness)
                        double id = od - (2 * thickness);
                        txtID.Text = id.ToString("0.###");
                    }
                    else
                    {
                        txtOD.Text = "N/A";
                        txtID.Text = "N/A";
                    }
                }
                else
                {
                    MessageBox.Show($"Thickness data not found for {size}\" Schedule {schedule}",
                                    "Data Not Found",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private static readonly Dictionary<string, double> StandardODs = new Dictionary<string, double>()
            {
                {"0.125", 0.405}, {"0.25", 0.540}, {"0.375", 0.675},
                {"0.5", 0.840}, {"0.75", 1.050}, {"1", 1.315},
                {"1.25", 1.660}, {"1.5", 1.900}, {"2", 2.375},
                {"2.5", 2.875}, {"3", 3.500}, {"3.5", 4.000},
                {"4", 4.500}, {"5", 5.563}, {"6", 6.625},
                {"8", 8.625}, {"10", 10.750}, {"12", 12.750},
                {"14", 14.000}, {"16", 16.000}, {"18", 18.000},
                {"20", 20.000}, {"22", 22.000}, {"24", 24.000},
                {"26", 26.000}, {"28", 28.000}, {"30", 30.000},
                {"32", 32.000}, {"34", 34.000}, {"36", 36.000},
                {"42", 42.000}
            };
        private void btnShowAllData_Click(object sender, EventArgs e)
        {
            // Create and configure the form with optimized size
            Form dataForm = new Form
            {
                Text = "All Nominal Thickness Data",
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(1800, 1000), // Wider but slightly less tall than previous version
                FormBorderStyle = FormBorderStyle.Sizable,
                MinimumSize = new Size(1400, 700),
                MaximizeBox = true
            };

            // Create and configure the DataGridView
            DataGridView dgv = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 8.5f), // Slightly smaller font
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    WrapMode = DataGridViewTriState.False, // Disable text wrapping
                    Padding = new Padding(2)
                },
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 9, FontStyle.Bold), // Header font slightly larger
                    BackColor = Color.LightGray,
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                RowHeadersWidth = 80,
                ColumnHeadersHeight = 32, // Compact headers
                RowTemplate = { Height = 24 }, // Standard row height
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None,
                ScrollBars = ScrollBars.Both,
                AllowUserToResizeColumns = true,
                AllowUserToOrderColumns = true,
                EnableHeadersVisualStyles = false,
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.WhiteSmoke }
            };

            // Get current selections for highlighting
            string currentSize = cmbPipeSize.SelectedItem?.ToString();
            string currentSchedule = cmbSchedule.SelectedItem?.ToString();

            // Highlight current selection
            dgv.CellFormatting += (s, ev) =>
            {
                if (ev.RowIndex >= 0 && ev.ColumnIndex >= 0)
                {
                    var row = dgv.Rows[ev.RowIndex];
                    var size = row.Cells["Size"].Value?.ToString();
                    var schedule = dgv.Columns[ev.ColumnIndex].HeaderText.Replace("Sch ", "");

                    if (size == currentSize && schedule == currentSchedule)
                    {
                        ev.CellStyle.BackColor = Color.Yellow;
                        ev.CellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
                    }
                }
            };

            // Set data source
            dgv.DataSource = GetNominalThicknessDataTable();

            // Adjust column widths after data binding
            dgv.DataBindingComplete += (s, args) =>
            {
                // Set column widths based on content
                dgv.Columns["Size"].Width = 70; // Compact size column
                dgv.Columns["OD"].Width = 70;   // OD column width

                // Set standard width for most schedule columns
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    if (column.HeaderText.StartsWith("Sch"))
                    {
                        // Wider width for the last few columns
                        if (column.HeaderText.EndsWith("XXS") ||
                            column.HeaderText.EndsWith("160") ||
                            column.HeaderText.EndsWith("140") ||
                            column.HeaderText.EndsWith("120") ||
                            column.HeaderText.EndsWith("100"))
                        {
                            column.Width = 100; // Wider for these columns
                        }
                        else
                        {
                            column.Width = 85; // Standard width for others
                        }
                        column.MinimumWidth = 80;
                    }
                }

                // Specific wider columns for important schedules
                string[] importantSchedules = { "Sch 80", "Sch 40", "Sch 10" };
                foreach (string schedule in importantSchedules)
                {
                    if (dgv.Columns.Contains(schedule))
                    {
                        dgv.Columns[schedule].Width = 95;
                    }
                }
            };

            // Add controls and show form
            dataForm.Controls.Add(dgv);
            dataForm.Show(this);
        }

        private DataTable GetNominalThicknessDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Size", typeof(string));

            // Add schedule columns - note "OD" is now separate from the other schedules
            table.Columns.Add("OD", typeof(string)); // Changed from "Sch OD" to "OD"

            string[] schedules = { "5", "5s", "10", "10s", "20", "30", "40", "40s", "STD", "60", "80", "80s", "XS", "100", "120", "140", "160", "XXS", };
            foreach (var schedule in schedules)
            {
                table.Columns.Add($"Sch {schedule}", typeof(string));
            }

            // Add rows
            string[] sizes = { "0.125", "0.25", "0.375", "0.5", "0.75", "1", "1.25", "1.5", "2", "2.5", "3", "3.5", "4", "5", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "42", };
            foreach (var size in sizes)
            {
                var row = table.NewRow();
                row["Size"] = size;

                // Add OD value from StandardODs dictionary
                if (StandardODs.TryGetValue(size, out double od))
                {
                    row["OD"] = od.ToString("0.###");
                }
                else
                {
                    row["OD"] = "-";
                }

                // Add thickness values for each schedule
                foreach (var schedule in schedules)
                {
                    if (thicknessData.TryGetValue((size, schedule), out double thickness))
                    {
                        row[$"Sch {schedule}"] = thickness.ToString("0.###");
                    }
                    else
                    {
                        row[$"Sch {schedule}"] = "-";
                    }
                }

                table.Rows.Add(row);
            }

            return table;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearResults()
        {
            txtThickness.Text = string.Empty;
            txtLowerMil.Text = string.Empty;
            txtUpperMil.Text = string.Empty;
            txtID.Text = string.Empty;
            txtOD.Text = string.Empty;
        }
    }
}