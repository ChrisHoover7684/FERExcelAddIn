using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using ExcelDataReader;

namespace FERExcelAddIn
{
    public partial class B31_3PipeCalculator : Form
    {
        private List<MaterialData> _materialData = new List<MaterialData>();
        private List<string> _allMaterialGroups = new List<string>();
        private Dictionary<string, double> _npsToOd = new Dictionary<string, double>();
        private List<EFactorData> _eFactorData = new List<EFactorData>();
        private double currentStressValuePsi = 0;
        private bool _isInitializing = false;

        public B31_3PipeCalculator()
        {
            InitializeComponent();

            _isInitializing = true; // Add this flag at class level

            toolTip1 = new ToolTip();
            InitializeNPSData();
            InitializeEFactorData();
            LoadMaterialData();
            InitializeMaterialGroups();
            InitializeQualityFactorDropdown();
            InitializeWeldJointFactor();


            // Initialize with empty values first
            txtTemperature.Text = "";
            txtPressure.Text = "";
            txtYCoefficient.Text = "";
            txtWeldJointFactor.Text = "";

            WireUpEvents();

            // Now set default values after everything is initialized
            _isInitializing = false;
            InitializeDefaultValues();
            UpdateMaterialsGrid();
        }

        private void InitializeNPSData()
        {
            _npsToOd = new Dictionary<string, double>
            {
                {"0.5", 0.840}, {"0.75", 1.050}, {"1", 1.315},
                {"1.5", 1.900}, {"2", 2.375}, {"2.5", 2.875},
                {"3", 3.500}, {"4", 4.500}, {"5", 5.563},
                {"6", 6.625}, {"8", 8.625}, {"10", 10.750},
                {"12", 12.750}, {"14", 14.000}, {"16", 16.000},
                {"18", 18.000}, {"20", 20.000}, {"24", 24.000}
            };

            cmbNPS.DataSource = new BindingSource(_npsToOd, null);
            cmbNPS.DisplayMember = "Key";
            cmbNPS.ValueMember = "Value";
            cmbNPS.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitializeEFactorData()
        {
            _eFactorData = new List<EFactorData>
    {
        // General entries that apply to all materials
        new EFactorData("All Materials", "All Specs", "", "Seamless (No Longitudinal Weld)", 1.00, "B31.3 Table A-3"),
        new EFactorData("All Materials", "All Specs", "", "Furnace Butt Welded (Continuous Weld)", 0.60, "B31.3 Table A-3"),
        new EFactorData("All Materials", "All Specs", "", "Electric Resistance Welded (ERW)", 0.85, "B31.3 Table A-3"),
        new EFactorData("All Materials", "All Specs", "", "EFW - Single Butt (No RT)", 0.80, "B31.3 Table A-3"),
        new EFactorData("All Materials", "All Specs", "", "EFW - Single Butt (Spot RT)", 0.90, "B31.3 Table A-3"),
        new EFactorData("All Materials", "All Specs", "", "EFW - Single Butt (100% RT)", 1.00, "B31.3 Table A-3"),
        new EFactorData("All Materials", "All Specs", "", "EFW - Double Butt (No RT)", 0.85, "B31.3 Table A-3"),
        new EFactorData("All Materials", "All Specs", "", "EFW - Double Butt (Spot RT)", 0.90, "B31.3 Table A-3"),
        new EFactorData("All Materials", "All Specs", "", "EFW - Double Butt (100% RT)", 1.00, "B31.3 Table A-3"),

        // Carbon Steel
        new EFactorData("Carbon Steel", "API 5L", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Carbon Steel", "API 5L", "", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Carbon Steel", "API 5L", "", "Electric welded pipe", 0.85, ""),
        new EFactorData("Carbon Steel", "API 5L", "", "Electric fusion welded pipe, double butt seam", 0.95, ""),
        new EFactorData("Carbon Steel", "API 5L", "", "Continuous welded (furnace butt welded) pipe", 0.60, ""),

        new EFactorData("Carbon Steel", "A53", "Type S", "Seamless pipe", 1.00, ""),
        new EFactorData("Carbon Steel", "A53", "Type E", "Electric resistance welded pipe", 0.85, ""),
        new EFactorData("Carbon Steel", "A53", "Type F", "Furnace butt welded pipe", 0.60, ""),

        new EFactorData("Carbon Steel", "A106", "", "Seamless pipe", 1.00, ""),

        new EFactorData("Carbon Steel", "A134", "", "Electric fusion welded pipe, single butt, straight or spiral (helical) seam", 0.80, ""),
        new EFactorData("Carbon Steel", "A135", "", "Electric resistance welded pipe", 0.85, ""),
        new EFactorData("Carbon Steel", "A139", "", "Electric fusion welded pipe, straight or spiral (helical) seam", 0.80, ""),

        new EFactorData("Carbon Steel", "A179", "", "Seamless tube", 1.00, ""),

        new EFactorData("Carbon Steel", "A333", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Carbon Steel", "A333", "", "Electric resistance welded pipe", 0.85, "(4)"),

        new EFactorData("Carbon Steel", "A334", "", "Seamless tube", 1.00, ""),
        new EFactorData("Carbon Steel", "A335", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Carbon Steel", "A369", "", "Seamless pipe", 1.00, ""),

        new EFactorData("Carbon Steel", "A381", "", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Carbon Steel", "A381", "", "Electric fusion welded pipe, spot radiographed", 0.90, "(3)"),
        new EFactorData("Carbon Steel", "A381", "", "Electric fusion welded pipe, as manufactured", 0.85, ""),

        new EFactorData("Carbon Steel", "A524", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Carbon Steel", "A587", "", "Electric resistance welded pipe", 0.85, ""),

        new EFactorData("Carbon Steel", "A671", "12, 22, 32, 42, 52", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Carbon Steel", "A671", "13, 23, 33, 43, 53", "Electric fusion welded pipe, double butt seam", 0.85, ""),

        new EFactorData("Carbon Steel", "A672", "12, 22, 32, 42, 52", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Carbon Steel", "A672", "13, 23, 33, 43, 53", "Electric fusion welded pipe, double butt seam", 0.85, ""),

        new EFactorData("Carbon Steel", "A691", "12, 22, 32, 42, 52", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Carbon Steel", "A691", "13, 23, 33, 43, 53", "Electric fusion welded pipe, double butt seam", 0.85, "(4)"),

        // Low and Intermediate Alloy Steel
        new EFactorData("Low and Intermediate Alloy Steel", "A333", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Low and Intermediate Alloy Steel", "A333", "", "Electric resistance welded pipe", 0.85, "(4)"),

        new EFactorData("Low and Intermediate Alloy Steel", "A334", "", "Seamless tube", 1.00, ""),
        new EFactorData("Low and Intermediate Alloy Steel", "A335", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Low and Intermediate Alloy Steel", "A369", "", "Seamless pipe", 1.00, ""),

        new EFactorData("Low and Intermediate Alloy Steel", "A671", "12, 22, 32, 42, 52", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Low and Intermediate Alloy Steel", "A671", "13, 23, 33, 43, 53", "Electric fusion welded pipe, double butt seam", 0.85, "(4)"),

        new EFactorData("Low and Intermediate Alloy Steel", "A672", "12, 22, 32, 42, 52", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Low and Intermediate Alloy Steel", "A672", "13, 23, 33, 43, 53", "Electric fusion welded pipe, double butt seam", 0.85, "(4)"),

        new EFactorData("Low and Intermediate Alloy Steel", "A691", "12, 22, 32, 42, 52", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Low and Intermediate Alloy Steel", "A691", "13, 23, 33, 43, 53", "Electric fusion welded pipe, double butt seam", 0.85, "(4)"),

        // Stainless Steel
        new EFactorData("Stainless Steel", "A249", "", "Electric fusion welded tube, single butt seam", 0.80, ""),

        new EFactorData("Stainless Steel", "A268", "", "Seamless tube", 1.00, ""),
        new EFactorData("Stainless Steel", "A268", "", "Electric fusion welded tube, double butt seam", 0.85, ""),
        new EFactorData("Stainless Steel", "A268", "", "Electric fusion welded tube, single butt seam", 0.80, ""),

        new EFactorData("Stainless Steel", "A269", "", "Seamless tube", 1.00, ""),
        new EFactorData("Stainless Steel", "A269", "", "Electric fusion welded tube, double butt seam", 0.85, ""),
        new EFactorData("Stainless Steel", "A269", "", "Electric fusion welded tube, single butt seam", 0.80, ""),

        new EFactorData("Stainless Steel", "A270", "", "Seamless tube", 1.00, ""),
        new EFactorData("Stainless Steel", "A270", "", "Electric fusion welded tube, double butt seam", 0.85, ""),
        new EFactorData("Stainless Steel", "A270", "", "Electric fusion welded tube, single butt seam", 0.80, ""),

        new EFactorData("Stainless Steel", "A312", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Stainless Steel", "A312", "", "Electric fusion welded pipe, double butt seam", 0.85, ""),
        new EFactorData("Stainless Steel", "A312", "", "Electric fusion welded pipe, single butt seam", 0.80, ""),
        new EFactorData("Stainless Steel", "A312", "", "Electric fusion welded pipe, 100% radiographed", 1.00, "(5)"),

        new EFactorData("Stainless Steel", "A358", "1, 3, 4", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Stainless Steel", "A358", "5", "Electric fusion welded pipe, spot radiographed", 0.90, ""),
        new EFactorData("Stainless Steel", "A358", "2", "Electric fusion welded pipe, double butt seam", 0.85, ""),

        new EFactorData("Stainless Steel", "A376", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Stainless Steel", "A376", "", "Electric fusion welded pipe, double butt seam", 0.85, ""),

        new EFactorData("Stainless Steel", "A409", "", "Electric fusion welded pipe, single butt seam", 0.80, ""),

        new EFactorData("Stainless Steel", "A789", "", "Seamless tube", 1.00, ""),
        new EFactorData("Stainless Steel", "A789", "", "Electric fusion welded tube, 100% radiographed", 1.00, ""),
        new EFactorData("Stainless Steel", "A789", "", "Electric fusion welded tube, double butt seam", 0.85, ""),
        new EFactorData("Stainless Steel", "A789", "", "Electric fusion welded tube, single butt seam", 0.80, ""),

        new EFactorData("Stainless Steel", "A790", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Stainless Steel", "A790", "", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Stainless Steel", "A790", "", "Electric fusion welded pipe, double butt seam", 0.85, ""),
        new EFactorData("Stainless Steel", "A790", "", "Electric fusion welded pipe, single butt seam", 0.80, ""),

        new EFactorData("Stainless Steel", "A813", "DW", "Electric fusion welded pipe, double butt seam", 0.85, ""),
        new EFactorData("Stainless Steel", "A813", "SW", "Electric fusion welded pipe, single butt seam", 0.80, ""),

        new EFactorData("Stainless Steel", "A814", "DW", "Electric fusion welded pipe, double butt seam", 0.85, ""),
        new EFactorData("Stainless Steel", "A814", "SW", "Electric fusion welded pipe, single butt seam", 0.80, ""),

        new EFactorData("Stainless Steel", "A928", "1, 3, 4", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Stainless Steel", "A928", "5", "Electric fusion welded pipe, spot radiographed", 0.90, ""),
        new EFactorData("Stainless Steel", "A928", "2", "Electric fusion welded pipe, double butt seam", 0.85, ""),

        // Copper and Copper Alloy
        new EFactorData("Copper and Copper Alloy", "B42", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Copper and Copper Alloy", "B43", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Copper and Copper Alloy", "B68", "", "Seamless tube", 1.00, ""),
        new EFactorData("Copper and Copper Alloy", "B75", "", "Seamless tube", 1.00, ""),
        new EFactorData("Copper and Copper Alloy", "B88", "", "Seamless water tube", 1.00, ""),
        new EFactorData("Copper and Copper Alloy", "B280", "", "Seamless tube", 1.00, ""),
        new EFactorData("Copper and Copper Alloy", "B466", "", "Seamless pipe and tube", 1.00, ""),

        new EFactorData("Copper and Copper Alloy", "B467", "", "Electric resistance welded pipe", 0.85, ""),
        new EFactorData("Copper and Copper Alloy", "B467", "", "Electric fusion welded pipe, double butt seam", 0.85, ""),
        new EFactorData("Copper and Copper Alloy", "B467", "", "Electric fusion welded pipe, single butt seam", 0.80, ""),

        // Nickel and Nickel Alloy
        new EFactorData("Nickel and Nickel Alloy", "B161", "", "Seamless pipe and tube", 1.00, ""),
        new EFactorData("Nickel and Nickel Alloy", "B163", "", "Seamless tube", 1.00, ""),
        new EFactorData("Nickel and Nickel Alloy", "B165", "", "Seamless pipe and tube", 1.00, ""),
        new EFactorData("Nickel and Nickel Alloy", "B167", "", "Seamless pipe and tube", 1.00, ""),
        new EFactorData("Nickel and Nickel Alloy", "B407", "", "Seamless pipe and tube", 1.00, ""),
        new EFactorData("Nickel and Nickel Alloy", "B444", "", "Seamless pipe and tube", 1.00, ""),

        new EFactorData("Nickel and Nickel Alloy", "B464", "", "Welded pipe", 0.80, ""),

        new EFactorData("Nickel and Nickel Alloy", "B474", "1, 3, 4", "Welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Nickel and Nickel Alloy", "B474", "2", "Electric fusion welded pipe, double butt seam", 0.85, ""),

        new EFactorData("Nickel and Nickel Alloy", "B514", "", "Welded pipe", 0.80, ""),
        new EFactorData("Nickel and Nickel Alloy", "B515", "", "Welded tube", 0.80, ""),

        new EFactorData("Nickel and Nickel Alloy", "B619", "", "Electric resistance welded pipe", 0.85, ""),
        new EFactorData("Nickel and Nickel Alloy", "B619", "", "Electric fusion welded pipe, double butt seam", 0.85, ""),
        new EFactorData("Nickel and Nickel Alloy", "B619", "", "Electric fusion welded pipe, single butt seam", 0.80, ""),

        new EFactorData("Nickel and Nickel Alloy", "B622", "", "Seamless pipe and tube", 1.00, ""),

        new EFactorData("Nickel and Nickel Alloy", "B626", "All", "Electric resistance welded tube", 0.85, ""),
        new EFactorData("Nickel and Nickel Alloy", "B626", "All", "Electric fusion welded tube, double butt seam", 0.85, ""),
        new EFactorData("Nickel and Nickel Alloy", "B626", "All", "Electric fusion welded tube, single butt seam", 0.80, ""),

        new EFactorData("Nickel and Nickel Alloy", "B668", "All", "Seamless pipe and tube", 1.00, ""),
        new EFactorData("Nickel and Nickel Alloy", "B675", "All", "Welded pipe", 0.80, ""),
        new EFactorData("Nickel and Nickel Alloy", "B690", "", "Seamless pipe and tube", 1.00, ""),
        new EFactorData("Nickel and Nickel Alloy", "B704", "", "Welded tube", 0.80, ""),
        new EFactorData("Nickel and Nickel Alloy", "B705", "", "Welded pipe", 0.80, ""),

        new EFactorData("Nickel and Nickel Alloy", "B725", "", "Electric fusion welded pipe, double butt seam", 0.85, ""),
        new EFactorData("Nickel and Nickel Alloy", "B725", "", "Electric fusion welded pipe, single butt seam", 0.80, ""),

        new EFactorData("Nickel and Nickel Alloy", "B729", "", "Seamless pipe and tube", 1.00, ""),

        new EFactorData("Nickel and Nickel Alloy", "B804", "1, 3, 5", "Welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Nickel and Nickel Alloy", "B804", "2, 4", "Welded pipe, double fusion welded", 0.85, ""),
        new EFactorData("Nickel and Nickel Alloy", "B804", "6", "Welded pipe, single fusion welded", 0.80, ""),

        // Titanium and Titanium Alloy
        new EFactorData("Titanium and Titanium Alloy", "B338", "", "Seamless tube", 1.00, ""),
        new EFactorData("Titanium and Titanium Alloy", "B338", "", "Electric fusion welded tube, 100% radiographed", 1.00, ""),
        new EFactorData("Titanium and Titanium Alloy", "B338", "", "Electric fusion welded tube, double butt seam", 0.85, ""),
        new EFactorData("Titanium and Titanium Alloy", "B861", "", "Electric fusion welded tube, single butt seam", 0.80, ""),

        new EFactorData("Titanium and Titanium Alloy", "B862", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Titanium and Titanium Alloy", "B862", "", "Electric fusion welded pipe, 100% radiographed", 1.00, ""),
        new EFactorData("Titanium and Titanium Alloy", "B862", "", "Electric fusion welded pipe, double butt seam", 0.85, ""),
        new EFactorData("Titanium and Titanium Alloy", "B862", "", "Electric fusion welded pipe, single butt seam", 0.80, ""),

        // Zirconium and Zirconium Alloy
        new EFactorData("Zirconium and Zirconium Alloy", "B523", "", "Seamless tube", 1.00, ""),
        new EFactorData("Zirconium and Zirconium Alloy", "B523", "", "Electric fusion welded tube", 0.80, ""),

        new EFactorData("Zirconium and Zirconium Alloy", "B658", "", "Seamless pipe", 1.00, ""),
        new EFactorData("Zirconium and Zirconium Alloy", "B658", "", "Electric fusion welded pipe", 0.80, ""),

        // Aluminum Alloy
        new EFactorData("Aluminum Alloy", "B210", "", "Seamless tube", 1.00, ""),
        new EFactorData("Aluminum Alloy", "B241", "", "Seamless pipe and tube", 1.00, "")
    };
        }

        private void InitializeQualityFactorDropdown()
        {
            try
            {
                cmbQualityFactor.DisplayMember = "Description";
                cmbQualityFactor.ValueMember = "EFactor";
                cmbQualityFactor.DropDownStyle = ComboBoxStyle.DropDownList;

                // Initialize with empty list
                cmbQualityFactor.DataSource = new List<EFactorData>();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error initializing quality factor dropdown: {ex.Message}");
            }
        }

        private void InitializeWeldJointFactor()
        {
            txtWeldJointFactor.Text = "1.00";
            txtWeldJointFactor.Validating += TxtWeldJointFactor_Validating;
        }

        private void LoadMaterialData()
        {
            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                string resourceName = assembly.GetManifestResourceNames()
                    .Single(name => name.EndsWith("B31_3_Table_A-1C_Materials.xlsx"));

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet(new ExcelDataSetConfiguration()
                        {
                            ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                            {
                                UseHeaderRow = true
                            }
                        });

                        DataTable dataTable = result.Tables[0];
                        var headers = dataTable.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToList();

                        _materialData = dataTable.Rows.Cast<DataRow>().Select(row =>
                        {
                            var stressValues = new Dictionary<double, double>();
                            for (int i = 15; i < headers.Count; i++)
                            {
                                if (double.TryParse(headers[i], out double temp) && double.TryParse(row[i].ToString(), out double stress))
                                {
                                    stressValues[temp] = stress;
                                }
                            }

                            return new MaterialData
                            {
                                LineNo = row[0].ToString().Trim(),
                                MaterialGroup = row[1].ToString().Trim(),
                                Material = row[2].ToString().Trim(),
                                NominalComposition = row[3].ToString().Trim(),
                                ProductForm = row[4].ToString().Trim(),
                                Spec = row[5].ToString().Trim(),
                                Grade = row[6].ToString().Trim(),
                                UNSNo = row[7].ToString().Trim(),
                                ClassConditionTemper = row[8].ToString().Trim(),
                                Size = row[9].ToString().Trim(),
                                PNo = row[10].ToString().Trim(),
                                MinTemp = row.Table.Columns.Contains("Min. Temp. (°F)") ? row["Min. Temp. (°F)"].ToString().Trim() : "",
                                Tensile = row.Table.Columns.Contains("Min. Tensile Strength (ksi)") ? ParseDouble(row["Min. Tensile Strength (ksi)"].ToString(), 0) : 0,
                                Yield = row.Table.Columns.Contains("Min. Yield Strength (ksi)") ? ParseDouble(row["Min. Yield Strength (ksi)"].ToString(), 0) : 0,
                                MaxTemp = row.Table.Columns.Contains("Max. Temp. (°F)") ? ParseDouble(row["Max. Temp. (°F)"].ToString(), 0) : 0,
                                StressValues = stressValues,
                                Notes = row.Table.Columns.Contains("Notes") ? row["Notes"].ToString().Trim() : ""
                            };
                        }).ToList();
                    }
                }

                _allMaterialGroups = _materialData
                    .Select(m => m.MaterialGroup)
                    .Distinct()
                    .OrderBy(g => g)
                    .ToList();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"CRITICAL ERROR LOADING MATERIAL DATA: {ex.ToString()}");
                MessageBox.Show($"Error loading material data: {ex.Message}\n\nCheck debug output for details.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private double ParseDouble(string value, double defaultValue)
        {
            if (string.IsNullOrWhiteSpace(value)) return defaultValue;
            return double.TryParse(value.Trim(), out double result) ? result : defaultValue;
        }

        private void ShowYCoefficientImage()
        {
            try
            {
                string resourcePath = "FERExcelAddIn.Resources.B31_3_Table_304_1_1_1_YCoefficient.png";

                var assembly = Assembly.GetExecutingAssembly();
                if (!assembly.GetManifestResourceNames().Contains(resourcePath))
                {
                    MessageBox.Show($"Image resource not found!", "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
                {
                    if (stream == null || stream.Length == 0)
                    {
                        MessageBox.Show("Image stream is empty or invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using (MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        ms.Position = 0;
                        Image image = Image.FromStream(ms);
                        var viewer = new ImageViewerForm(image, "ASME B31.3 Table 304.1.1-1");
                        viewer.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowWeldJointFactorImage()
        {
            try
            {
                string resourcePath = "FERExcelAddIn.Resources.B31_3_Table_302_3_5_1_WFactor.png";
                var assembly = Assembly.GetExecutingAssembly();

                if (!assembly.GetManifestResourceNames().Contains(resourcePath))
                {
                    MessageBox.Show($"Image resource not found!", "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
                {
                    if (stream == null || stream.Length == 0)
                    {
                        MessageBox.Show("Image stream is empty or invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    using (MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        ms.Position = 0;
                        Image image = Image.FromStream(ms);
                        var viewer = new ImageViewerForm(image, "ASME B31.3 Table 302.3.5-1");
                        viewer.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WireUpEvents()
        {
            
            cmbQualityFactor.SelectedIndexChanged += CmbQualityFactor_SelectedIndexChanged;
            txtTemperature.TextChanged += TxtTemperature_TextChanged;
            txtPressure.TextChanged += TxtPressure_TextChanged;
            txtWeldJointFactor.Validating += TxtWeldJointFactor_Validating;
            txtTemperature.Validating += ValidateNumericInput;
            txtPressure.Validating += ValidateNumericInput;
            txtYCoefficient.Validating += ValidateNumericInput;
            dgvMaterials.CellClick += dgvMaterials_CellClick;
            txtYCoefficient.TextChanged += (s, e) => UpdateCurrentNPSThickness();
            cmbQualityFactor.SelectedIndexChanged += (s, e) => UpdateCurrentNPSThickness();
            txtWeldJointFactor.TextChanged += (s, e) => UpdateCurrentNPSThickness();

            cmbMaterialGroup.SelectedIndexChanged += UpdateAllCalculations;
            cmbNPS.SelectedIndexChanged += CmbNPS_SelectedIndexChanged;
            cmbNPS.SelectedIndexChanged += UpdateAllCalculations;
            txtTemperature.TextChanged += UpdateAllCalculations;
            txtPressure.TextChanged += UpdateAllCalculations;

            cmbMaterialGroup.SelectedIndexChanged += CmbMaterialGroup_SelectedIndexChanged;
            cmbNPS.SelectedIndexChanged += CmbNPS_SelectedIndexChanged;

            btnShowTable304.Click += (s, e) => ShowYCoefficientImage();
            btnShowTable.Click += (s, e) => ShowWeldJointFactorImage();

        }

        private void UpdateAllCalculations(object sender, EventArgs e)
        {
            if (_isInitializing) return;
            // Update stress value first as it's used by other calculations
            UpdateStressValue();

            // Update Y coefficient if temperature changed
            if (sender == txtTemperature)
            {
                UpdateYCoefficient();
            }

            // Update current NPS thickness display
            UpdateCurrentNPSThickness();

            // Update the results grid
            UpdateResultsGrid();
        }
        private void InitializeDefaultValues()
        {
            _isInitializing = true;
            try
            {
                cmbMaterialGroup.SelectedItem = "Carbon Steel -- Pipes and Tubes";
                cmbNPS.SelectedItem = _npsToOd.FirstOrDefault(x => x.Key == "2");
                txtTemperature.Text = "579";
                cmbQualityFactor.Text = "Seamless (No Longitudinal Weld)";
                txtPressure.Text = "200";
                txtYCoefficient.Text = "0.4";
                txtWeldJointFactor.Text = "1.00";

                cmbMaterialGroup.SelectedIndexChanged += CmbMaterialGroup_SelectedIndexChanged;
                cmbNPS.SelectedIndexChanged += CmbNPS_SelectedIndexChanged;
                cmbQualityFactor.SelectedIndexChanged += CmbQualityFactor_SelectedIndexChanged;
                txtTemperature.TextChanged += TxtTemperature_TextChanged;
                txtPressure.TextChanged += TxtPressure_TextChanged;
                txtWeldJointFactor.Validating += TxtWeldJointFactor_Validating;
                txtTemperature.Validating += ValidateNumericInput;
                txtPressure.Validating += ValidateNumericInput;
                txtYCoefficient.Validating += ValidateNumericInput;
                dgvMaterials.CellClick += dgvMaterials_CellClick;
                txtYCoefficient.TextChanged += UpdateAllCalculations;
                cmbQualityFactor.SelectedIndexChanged += UpdateAllCalculations;
                txtWeldJointFactor.TextChanged += UpdateAllCalculations;
                cmbMaterialGroup.SelectedIndexChanged += UpdateAllCalculations;
                cmbNPS.SelectedIndexChanged += UpdateAllCalculations;
                txtTemperature.TextChanged += UpdateAllCalculations;
                txtPressure.TextChanged += UpdateAllCalculations;

                // Select first material in grid if available
                if (dgvMaterials.Rows.Count > 0)
                {
                    dgvMaterials.Rows[0].Selected = true;
                    dgvMaterials_CellClick(dgvMaterials, new DataGridViewCellEventArgs(0, 0));
                }
                if (cmbNPS.SelectedIndex >= 0) CmbNPS_SelectedIndexChanged(null, EventArgs.Empty);

            }
            finally
            {
                _isInitializing = false;
            }
            UpdateStressValue();
        }

        private void CmbNPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isInitializing) return;

            if (cmbNPS.SelectedItem != null)
            {
                var selectedNPS = (KeyValuePair<string, double>)cmbNPS.SelectedItem;
                txtOuterDiameter.Text = selectedNPS.Value.ToString("F3"); // Format to 3 decimal places
            }
            else
            {
                txtOuterDiameter.Text = string.Empty;
            }

            // Update the grid which will handle highlighting the correct row
            UpdateResultsGrid();
        }

        private void CmbQualityFactor_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEFactorTooltip();
            UpdateCurrentNPSThickness();
        }

        private void TxtTemperature_TextChanged(object sender, EventArgs e)
        {
            UpdateStressValue();
            UpdateYCoefficient();
        }

        private void TxtPressure_TextChanged(object sender, EventArgs e)
        {
            UpdateCurrentNPSThickness();
        }

        private void UpdateQualityFactorOptions()
        {
            if (dgvMaterials.CurrentRow == null || dgvMaterials.CurrentRow.Tag == null)
            {
                Debug.WriteLine("No material selected in grid");
                return;
            }

            var selectedMaterial = (MaterialData)dgvMaterials.CurrentRow.Tag;
            Debug.WriteLine($"Updating quality factors for material: {selectedMaterial.Material}, Spec: {selectedMaterial.Spec}, Grade: {selectedMaterial.Grade}");

            var availableFactors = _eFactorData
                .Where(x => (x.SpecNo.Equals("All Specs", StringComparison.OrdinalIgnoreCase) ||
                             x.SpecNo.Equals(selectedMaterial.Spec, StringComparison.OrdinalIgnoreCase)) &&
                            (x.Material.Equals("All Materials", StringComparison.OrdinalIgnoreCase) ||
                             x.Material.Equals(selectedMaterial.Material, StringComparison.OrdinalIgnoreCase)) &&
                            (string.IsNullOrEmpty(x.TypeGrade) ||
                             x.TypeGrade.Equals(selectedMaterial.Grade, StringComparison.OrdinalIgnoreCase)))
                .OrderByDescending(x => x.EFactor)
                .ToList();

            Debug.WriteLine($"Found {availableFactors.Count} matching quality factors");

            cmbQualityFactor.DataSource = availableFactors;
            if (availableFactors.Count > 0)
            {
                cmbQualityFactor.SelectedIndex = 0;
                Debug.WriteLine($"Selected quality factor: {cmbQualityFactor.SelectedItem}");
            }
            else
            {
                Debug.WriteLine("No quality factors available for selected material");
            }
        }

        private void UpdateEFactorTooltip()
        {
            if (cmbQualityFactor.SelectedItem is EFactorData selectedFactor)
            {
                toolTip1.SetToolTip(cmbQualityFactor,
                    $"E = {selectedFactor.EFactor}\nSpec: {selectedFactor.SpecNo}\n{selectedFactor.Notes}");
            }
        }

        private void UpdateStressValue()
        {
            txtStressValue.Text = string.Empty;
            currentStressValuePsi = 0;

            if (dgvMaterials.CurrentRow == null || dgvMaterials.CurrentRow.Tag == null) return;
            var selectedMaterial = (MaterialData)dgvMaterials.CurrentRow.Tag;

            if (string.IsNullOrWhiteSpace(txtTemperature.Text) || !double.TryParse(txtTemperature.Text, out double temperature))
            {
                txtStressValue.Text = "Invalid temperature";
                return;
            }

            try
            {
                // Check if MinTemp is numeric before comparing
                if (double.TryParse(selectedMaterial.MinTemp, out double minTempValue))
                {
                    if (temperature < minTempValue)
                    {
                        txtStressValue.Text = $"Below min temp ({selectedMaterial.MinTemp}°F)";
                        HighlightTemperatureCell(true); // Highlight for low temperature
                        return;
                    }
                }

                // Check if temperature exceeds max temp
                if (temperature > selectedMaterial.MaxTemp)
                {
                    txtStressValue.Text = $"Above max temp ({selectedMaterial.MaxTemp}°F)";
                    HighlightTemperatureCell(true); // Highlight for high temperature
                    return;
                }

                // Temperature is within range, remove highlighting
                HighlightTemperatureCell(false);

                // Rest of the stress calculation logic...
                var stressPoints = selectedMaterial.StressValues;
                var lower = stressPoints.LastOrDefault(p => p.Key <= temperature);
                var higher = stressPoints.FirstOrDefault(p => p.Key >= temperature);

                double stressValueKsi = 0;

                if (lower.Key == higher.Key)
                {
                    stressValueKsi = lower.Value;
                }
                else if (lower.Key != 0 && higher.Key != 0)
                {
                    stressValueKsi = LinearInterpolate(lower.Key, lower.Value, higher.Key, higher.Value, temperature);
                }
                else if (lower.Key != 0)
                {
                    stressValueKsi = lower.Value;
                }
                else if (higher.Key != 0)
                {
                    stressValueKsi = higher.Value;
                }
                else
                {
                    txtStressValue.Text = "No data for temperature";
                    return;
                }

                currentStressValuePsi = stressValueKsi * 1000;
                txtStressValue.Text = currentStressValuePsi.ToString("F0");
            }
            catch (Exception ex)
            {
                txtStressValue.Text = "Error calculating stress";
                Debug.WriteLine($"Error calculating stress value: {ex.Message}");
            }
        }

        private void HighlightTemperatureCell(bool highlight)
        {
            if (highlight)
            {
                txtTemperature.BackColor = Color.LightCoral;
                txtTemperature.ForeColor = Color.DarkRed;
                toolTip1.SetToolTip(txtTemperature, "Temperature exceeds material limits");
            }
            else
            {
                txtTemperature.BackColor = SystemColors.Window;
                txtTemperature.ForeColor = SystemColors.WindowText;
                toolTip1.SetToolTip(txtTemperature, "");
            }
        }

        private double GetSelectedYCoefficient()
        {
            if (double.TryParse(txtYCoefficient.Text, out double yValue) && yValue >= 0 && yValue <= 0.7)
            {
                return yValue;
            }
            return 0.4;
        }

        private void TxtWeldJointFactor_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(txtWeldJointFactor.Text, out double result) || result <= 0 || result > 1)
            {
                MessageBox.Show("Weld Joint Factor must be between 0 and 1", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeldJointFactor.Text = "1.00";
                txtWeldJointFactor.SelectAll();
                e.Cancel = true;
            }
        }

        private void ValidateNumericInput(object sender, CancelEventArgs e)
        {
            if (sender is TextBox textBox && !string.IsNullOrEmpty(textBox.Text))
            {
                if (!double.TryParse(textBox.Text, out _))
                {
                    MessageBox.Show("Please enter a valid number.", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    textBox.SelectAll();
                    e.Cancel = true;
                }
            }
        }


        private void UpdateResultsGrid()
        {
            try
            {
                if (_isInitializing) return;

                // Clear all previous selections and styles first
                dgvResults.ClearSelection();
                ResetResultsGridStyles();

                // Store current selection before any updates
                string selectedNPS = cmbNPS.SelectedItem != null
                    ? ((KeyValuePair<string, double>)cmbNPS.SelectedItem).Key
                    : null;

                // Validate required inputs
                if (!ValidateGridInputs())
                {
                    dgvResults.Rows.Clear();
                    return;
                }

                // Get calculation parameters
                var (pressure, weldJointFactor, qualityFactor, yCoefficient, stressValue) = GetCalculationParameters();
                if (pressure <= 0 || weldJointFactor <= 0 || qualityFactor <= 0 || stressValue <= 0)
                {
                    dgvResults.Rows.Clear();
                    return;
                }

                // Update grid data
                UpdateGridData(pressure, weldJointFactor, qualityFactor, yCoefficient, stressValue);
                UpdateGridData(pressure, weldJointFactor, qualityFactor, yCoefficient, stressValue);

                // Only highlight if we have a valid selection and the grid has data
                if (!string.IsNullOrEmpty(selectedNPS) && dgvResults.Rows.Count > 0)
                {
                    HighlightSelectedRow(selectedNPS);
                }
                else
                {
                    // Explicitly clear selection if no valid NPS is selected
                    dgvResults.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error updating results grid: {ex.Message}");
            }
            finally
            {
                dgvResults.ResumeLayout();
            }
        }



        private void ResetResultsGridStyles()
        {
            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                row.DefaultCellStyle.BackColor = dgvResults.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.Font = dgvResults.DefaultCellStyle.Font;
            }
        }

        
        private bool ValidateGridInputs()
        {
            return cmbQualityFactor.SelectedItem != null &&
                   !string.IsNullOrEmpty(txtWeldJointFactor.Text) &&
                   !string.IsNullOrEmpty(txtPressure.Text) &&
                   !string.IsNullOrEmpty(txtTemperature.Text) &&
                   currentStressValuePsi > 0;
        }

        private (double pressure, double weldJointFactor, double qualityFactor, double yCoefficient, double stressValue) GetCalculationParameters()
        {
            double.TryParse(txtPressure.Text, out double pressure);
            double.TryParse(txtWeldJointFactor.Text, out double weldJointFactor);
            var qualityFactorData = cmbQualityFactor.SelectedItem as EFactorData;
            double qualityFactor = qualityFactorData?.EFactor ?? 0;
            double yCoefficient = GetSelectedYCoefficient();
            double stressValue = currentStressValuePsi;

            return (pressure, weldJointFactor, qualityFactor, yCoefficient, stressValue);
        }

        private void UpdateGridData(double pressure, double weldJointFactor, double qualityFactor, double yCoefficient, double stressValue)
        {
            dgvResults.SuspendLayout();
            dgvResults.Rows.Clear();

            foreach (var npsItem in _npsToOd)
            {
                double outerDiameter = npsItem.Value;
                double denominator = 2 * (stressValue * qualityFactor * weldJointFactor + pressure * yCoefficient);
                double minThicknessB313 = (pressure * outerDiameter) / denominator;
                double minThicknessBarlow = (pressure * outerDiameter) / (2 * stressValue);

                int rowIndex = dgvResults.Rows.Add(
                    npsItem.Key,
                    outerDiameter.ToString("F3"),
                    minThicknessB313.ToString("F4"),
                    minThicknessBarlow.ToString("F4")
                );

                dgvResults.Rows[rowIndex].Tag = npsItem.Key;
            }
        }

        private void HighlightSelectedRow(string selectedNPS)
        {
            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                if (row.Cells["colNPS"].Value != null &&
                    row.Cells["colNPS"].Value.ToString() == selectedNPS)
                {
                    row.Selected = true;
                    dgvResults.FirstDisplayedScrollingRowIndex = row.Index;

                    // Additional visual emphasis
                    row.DefaultCellStyle.BackColor = Color.LightYellow;
                    row.DefaultCellStyle.Font = new Font(dgvResults.Font, FontStyle.Bold);
                    break;
                }
            }
        }


        private void UpdateCurrentNPSThickness()
        {
            try
            {
                if (cmbNPS.SelectedItem == null)
                {
                    txtMinThicknessResult.Text = string.Empty;
                    txtBarlowThicknessResult.Text = string.Empty;
                    return;
                }

                var selectedNPS = (KeyValuePair<string, double>)cmbNPS.SelectedItem;
                double outerDiameter = selectedNPS.Value;

                if (!double.TryParse(txtPressure.Text, out double pressure) || pressure <= 0)
                {
                    txtMinThicknessResult.Text = string.Empty;
                    txtBarlowThicknessResult.Text = string.Empty;
                    return;
                }

                if (cmbQualityFactor.SelectedItem == null || !(cmbQualityFactor.SelectedItem is EFactorData))
                {
                    txtMinThicknessResult.Text = string.Empty;
                    txtBarlowThicknessResult.Text = string.Empty;
                    return;
                }

                double qualityFactor = ((EFactorData)cmbQualityFactor.SelectedItem).EFactor;

                if (!double.TryParse(txtWeldJointFactor.Text, out double weldJointFactor) || weldJointFactor <= 0)
                {
                    txtMinThicknessResult.Text = string.Empty;
                    txtBarlowThicknessResult.Text = string.Empty;
                    return;
                }

                double yCoefficient = GetSelectedYCoefficient();

                if (currentStressValuePsi <= 0)
                {
                    txtMinThicknessResult.Text = "Invalid stress";
                    txtBarlowThicknessResult.Text = "Invalid stress";
                    return;
                }

                // B31.3 calculation (same as in grid)
                double denominator = 2 * (currentStressValuePsi * qualityFactor * weldJointFactor + pressure * yCoefficient);
                double minThicknessB313 = (pressure * outerDiameter) / denominator;

                // Barlow calculation (same as in grid)
                double minThicknessBarlow = (pressure * outerDiameter) / (2 * currentStressValuePsi);

                txtMinThicknessResult.Text = minThicknessB313.ToString("F4");
                txtBarlowThicknessResult.Text = minThicknessBarlow.ToString("F4");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error in UpdateCurrentNPSThickness: {ex.Message}");
                txtMinThicknessResult.Text = "Error";
                txtBarlowThicknessResult.Text = "Error";
            }
        }

        private void UpdateYCoefficient()
        {
            if (dgvMaterials.CurrentRow == null || dgvMaterials.CurrentRow.Tag == null) return;
            var selectedMaterial = (MaterialData)dgvMaterials.CurrentRow.Tag;

            if (string.IsNullOrEmpty(txtTemperature.Text) || !double.TryParse(txtTemperature.Text, out double temperature))
            {
                txtYCoefficient.Text = "0.4";
                return;
            }

            string category = MaterialClassifier.GetMaterialCategory(selectedMaterial.Material);
            double yValue = GetInterpolatedYValue(category, temperature);
            txtYCoefficient.Text = yValue.ToString("F1");
        }

        private double GetInterpolatedYValue(string category, double temperature)
        {
            var ferriticPoints = new Dictionary<double, double>
            {
                { 900, 0.4 },
                { 950, 0.5 },
                { double.MaxValue, 0.7 }
            };

            var austeniticPoints = new Dictionary<double, double>
            {
                { 1050, 0.4 },
                { 1100, 0.5 },
                { double.MaxValue, 0.7 }
            };

            var nickelPoints = new Dictionary<double, double>
            {
                { 1150, 0.4 },
                { 1200, 0.5 },
                { double.MaxValue, 0.7 }
            };

            switch (category)
            {
                case "Gray iron": return 0.0;
                case "Ferritic": return InterpolateYValue(temperature, ferriticPoints);
                case "Austenitic": return InterpolateYValue(temperature, austeniticPoints);
                case "Nickel alloy": return InterpolateYValue(temperature, nickelPoints);
                default: return 0.4;
            }
        }

        private double InterpolateYValue(double temperature, Dictionary<double, double> breakpoints)
        {
            double lowerTemp = 0;
            double upperTemp = 0;
            double lowerY = 0.4;
            double upperY = 0.4;

            foreach (var point in breakpoints.OrderBy(p => p.Key))
            {
                if (temperature <= point.Key)
                {
                    upperTemp = point.Key;
                    upperY = point.Value;
                    break;
                }
                lowerTemp = point.Key;
                lowerY = point.Value;
            }

            if (temperature <= breakpoints.First().Key)
                return breakpoints.First().Value;

            if (temperature > breakpoints.Last().Key)
                return breakpoints.Last().Value;

            return lowerY + (upperY - lowerY) * (temperature - lowerTemp) / (upperTemp - lowerTemp);
        }

        private double LinearInterpolate(double x0, double y0, double x1, double y1, double x)
        {
            if (x0 == x1) return y0;
            return y0 + (y1 - y0) * (x - x0) / (x1 - x0);
        }

       

        private void UpdateMaterialsGrid()
        {
            dgvMaterials.Rows.Clear();

            var filteredData = _materialData
                .Where(m => cmbMaterialGroup.SelectedItem == null || m.MaterialGroup == cmbMaterialGroup.SelectedItem.ToString())
                .ToList();

            foreach (var material in filteredData)
            {
                int rowIndex = dgvMaterials.Rows.Add(
                    material.LineNo,
                    material.Material,
                    material.NominalComposition,
                    material.ProductForm,
                    material.Spec,
                    material.Grade,
                    material.UNSNo,
                    material.ClassConditionTemper,
                    material.Size
                );
                dgvMaterials.Rows[rowIndex].Tag = material;
            }
        }

        private void dgvMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMaterials.Rows[e.RowIndex];
                if (row.Tag is MaterialData material)
                {
                    cmbMaterialGroup.Text = material.MaterialGroup;
                    txtPNo.Text = material.PNo;
                    txtMinTemp.Text = material.MinTemp;
                    txtTensile.Text = material.Tensile.ToString();
                    txtYield.Text = material.Yield.ToString();
                    txtMaxTemp.Text = material.MaxTemp.ToString();

                    var notes = GetNotes(material.Notes);
                    DisplayNotesInRichTextBox(notes);

                    UpdateQualityFactorOptions();
                    UpdateAllCalculations(this, EventArgs.Empty);

                    // Trigger temperature validation when material changes
                    if (!string.IsNullOrEmpty(txtTemperature.Text))
                    {
                        UpdateStressValue();
                    }
                }
            }
        }


       


        private IEnumerable<string> GetNotes(string notes)
        {
            if (string.IsNullOrWhiteSpace(notes))
            {
                return Enumerable.Empty<string>();
            }

            // Extract all note numbers from the notes string
            var noteNumbers = Regex.Matches(notes, @"\d+")
                                  .Cast<Match>()
                                  .Select(m => m.Value)
                                  .Distinct()
                                  .OrderBy(n => int.Parse(n));

            // Format each note with bold number and proper spacing
            return noteNumbers.Select(n =>
            {
                string noteText = ASMEB31_3Notes2024.GetNote(n);
                return $"Note {n}:\n{noteText}";
            });
        }
        private void DisplayNotesInRichTextBox(IEnumerable<string> notes)
        {
            rtbNotesActual.Clear();

            if (!notes.Any())
            {
                rtbNotesActual.Text = "No notes available";
                return;
            }

            // Set default font
            rtbNotesActual.Font = new Font("Segoe UI", 9);
            //rtbNotesActual.SelectionAlignment = HorizontalAlignment.Left;

            bool firstNote = true;

            foreach (var note in notes)
            {
                if (!firstNote)
                {
                    // Add spacing between notes
                    rtbNotesActual.AppendText("\n\n");
                }
                firstNote = false;

                // Split note number from content
                var parts = note.Split(new[] { ':' }, 2);
                if (parts.Length == 2)
                {
                    // Add note number in bold
                    rtbNotesActual.SelectionFont = new Font(rtbNotesActual.Font, FontStyle.Bold);
                    rtbNotesActual.AppendText(parts[0] + ":");

                    // Add note content in regular font
                    rtbNotesActual.SelectionFont = new Font(rtbNotesActual.Font, FontStyle.Regular);
                    rtbNotesActual.AppendText(parts[1]);
                }
                else
                {
                    // Fallback if format doesn't match
                    rtbNotesActual.SelectionFont = new Font(rtbNotesActual.Font, FontStyle.Regular);
                    rtbNotesActual.AppendText(note);
                }
            }
        }

        private void InitializeMaterialGroups()
        {
            if (_allMaterialGroups == null || _allMaterialGroups.Count == 0)
            {
                Debug.WriteLine("Warning: No material groups loaded");
                return;
            }

            cmbMaterialGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterialGroup.DataSource = new List<string>(_allMaterialGroups);

            var defaultGroup = _allMaterialGroups.FirstOrDefault(g => g.Contains("Carbon Steel"))
                              ?? _allMaterialGroups.FirstOrDefault();
            if (defaultGroup != null)
            {
                cmbMaterialGroup.SelectedItem = defaultGroup;
            }
        }

        private void CmbMaterialGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMaterialsGrid();
        }

        private void CmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMaterialsGrid();
        }

        public class MaterialData
        {
            public string LineNo { get; set; }
            public string MaterialGroup { get; set; }
            public string Material { get; set; }
            public string NominalComposition { get; set; }
            public string ProductForm { get; set; }
            public string Spec { get; set; }
            public string Grade { get; set; }
            public string UNSNo { get; set; }
            public string ClassConditionTemper { get; set; }
            public string Size { get; set; }
            public string PNo { get; set; }
            public string MinTemp { get; set; }
            public double Tensile { get; set; }
            public double Yield { get; set; }
            public double MaxTemp { get; set; }
            public Dictionary<double, double> StressValues { get; set; } = new Dictionary<double, double>();
            public string Notes { get; set; }
        }

        public class EFactorData
        {
            public string Material { get; }
            public string SpecNo { get; }
            public string TypeGrade { get; }
            public string Description { get; }
            public double EFactor { get; }
            public string Notes { get; }

            public EFactorData(string material, string specNo, string typeGrade,
                string description, double eFactor, string notes)
            {
                Material = material;
                SpecNo = specNo;
                TypeGrade = typeGrade;
                Description = description;
                EFactor = eFactor;
                Notes = notes;
            }

            public override string ToString() => Description;
        }

        public static class MaterialClassifier
        {
            public static string GetMaterialCategory(string material)
            {
                if (string.IsNullOrWhiteSpace(material))
                    return "Other ductile metal";

                string baseMaterial = material.Split('-')[0].Trim();

                if (baseMaterial.Equals("Gray iron", StringComparison.OrdinalIgnoreCase))
                    return "Gray iron";

                if (baseMaterial.Equals("Carbon Steel", StringComparison.OrdinalIgnoreCase) ||
                    baseMaterial.Equals("Low and Intermediate Alloy Steel", StringComparison.OrdinalIgnoreCase))
                    return "Ferritic";

                if (baseMaterial.Equals("Stainless Steel", StringComparison.OrdinalIgnoreCase))
                    return "Austenitic";

                if (baseMaterial.Equals("Nickel Alloy", StringComparison.OrdinalIgnoreCase) ||
                    baseMaterial.Contains("N06617") ||
                    baseMaterial.Contains("N08800") ||
                    baseMaterial.Contains("N08810") ||
                    baseMaterial.Contains("N08825"))
                    return "Nickel alloy";

                return "Other ductile metal";
            }
        }

        private class ImageViewerForm : Form
        {
            public ImageViewerForm(Image image, string title)
            {
                if (image == null)
                    throw new ArgumentNullException(nameof(image));

                var pictureBox = new PictureBox
                {
                    Image = image,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill,
                    BackColor = Color.White
                };

                this.Text = title;
                this.Controls.Add(pictureBox);
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                this.StartPosition = FormStartPosition.CenterScreen;
                this.DoubleBuffered = true;
                this.KeyPreview = true;

                this.ClientSize = new Size(
                    Math.Min(image.Width, Screen.PrimaryScreen.WorkingArea.Width - 100),
                    Math.Min(image.Height, Screen.PrimaryScreen.WorkingArea.Height - 100)
                );
            }
            private void ShowWeldJointFactorImage()
            {
                try
                {
                    string resourcePath = "FERExcelAddIn.Resources.B31_3_Table_302_3_5_1_WFactor.png";

                    // First verify the resource exists
                    var assembly = Assembly.GetExecutingAssembly();
                    var resourceNames = assembly.GetManifestResourceNames();

                    // Debug output to verify resources
                    Debug.WriteLine("Available resources:");
                    foreach (var name in resourceNames)
                    {
                        Debug.WriteLine(name);
                    }

                    if (!resourceNames.Contains(resourcePath))
                    {
                        MessageBox.Show($"Image resource not found!\nLooking for: {resourcePath}\n\n" +
                                      $"Available resources:\n{string.Join("\n", resourceNames)}",
                                      "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
                    {
                        if (stream == null || stream.Length == 0)
                        {
                            MessageBox.Show("Image stream is empty or invalid", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Create a copy of the stream to prevent disposal issues
                        using (MemoryStream ms = new MemoryStream())
                        {
                            stream.CopyTo(ms);
                            ms.Position = 0;

                            try
                            {
                                // Load the image safely
                                Image image;
                                try
                                {
                                    image = Image.FromStream(ms);
                                }
                                catch (ArgumentException ex)
                                {
                                    MessageBox.Show($"The image file appears to be corrupted or in an unsupported format.\n\n" +
                                                    $"Technical details: {ex.Message}",
                                                    "Invalid Image Format",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                // Verify the image was loaded correctly
                                if (image.Width <= 0 || image.Height <= 0)
                                {
                                    MessageBox.Show("The loaded image has invalid dimensions", "Image Error",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                // Show the image viewer
                                var viewer = new ImageViewerForm(image, "ASME B31.3 Table 302.3.5-1");
                                viewer.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Unexpected error displaying image: {ex.Message}",
                                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void ShowYCoefficientImage()
            {
                try
                {
                    string resourcePath = "FERExcelAddIn.Resources.B31_3_Table_304_1_1_1_YCoefficient.png";

                    // First verify the resource exists
                    var assembly = Assembly.GetExecutingAssembly();
                    var resourceNames = assembly.GetManifestResourceNames();

                    // Debug output to verify resources
                    Debug.WriteLine("Available resources:");
                    foreach (var name in resourceNames)
                    {
                        Debug.WriteLine(name);
                    }

                    if (!resourceNames.Contains(resourcePath))
                    {
                        MessageBox.Show($"Image resource not found!\nLooking for: {resourcePath}\n\n" +
                                      $"Available resources:\n{string.Join("\n", resourceNames)}",
                                      "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
                    {
                        if (stream == null || stream.Length == 0)
                        {
                            MessageBox.Show("Image stream is empty or invalid", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Create a copy of the stream to prevent disposal issues
                        using (MemoryStream ms = new MemoryStream())
                        {
                            stream.CopyTo(ms);
                            ms.Position = 0;

                            try
                            {
                                // Load the image safely
                                Image image;
                                try
                                {
                                    image = Image.FromStream(ms);
                                }
                                catch (ArgumentException ex)
                                {
                                    MessageBox.Show($"The image file appears to be corrupted or in an unsupported format.\n\n" +
                                                    $"Technical details: {ex.Message}",
                                                    "Invalid Image Format",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                // Verify the image was loaded correctly
                                if (image.Width <= 0 || image.Height <= 0)
                                {
                                    MessageBox.Show("The loaded image has invalid dimensions", "Image Error",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                // Show the image viewer
                                var viewer = new ImageViewerForm(image, "ASME B31.3 Table 304.1.1-1");
                                viewer.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Unexpected error displaying image: {ex.Message}",
                                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            
           
        }

        
    }
}
