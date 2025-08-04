using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace FERExcelAddIn
{
    public partial class MultiPageConverterForm : Form
    {
        public MultiPageConverterForm()
        {
            InitializeComponent();
            InitializeEventHandlers();
            InitializeUnitLists();
            InitializeGeometryTab();
        }

        private void InitializeEventHandlers()
        {
            // Common events for all tabs
            btnConvertLength.Click += ConvertButton_Click;
            btnConvertTemperature.Click += ConvertButton_Click;
            btnConvertArea.Click += ConvertButton_Click;
            btnConvertVolume.Click += ConvertButton_Click;
            btnConvertWeight.Click += ConvertButton_Click;

            btnReverseLength.Click += ReverseButton_Click;
            btnReverseTemperature.Click += ReverseButton_Click;
            btnReverseArea.Click += ReverseButton_Click;
            btnReverseVolume.Click += ReverseButton_Click;
            btnReverseWeight.Click += ReverseButton_Click;

            btnConvertTime.Click += ConvertButton_Click;
            btnReverseTime.Click += ReverseButton_Click;
            cmbTimeFrom.SelectedIndexChanged += UnitSelectionChanged;
            cmbTimeTo.SelectedIndexChanged += UnitSelectionChanged;

            btnConvertPressure.Click += ConvertButton_Click;
            btnReversePressure.Click += ReverseButton_Click;
            cmbPressureFrom.SelectedIndexChanged += UnitSelectionChanged;
            cmbPressureTo.SelectedIndexChanged += UnitSelectionChanged;

            // Selection change events
            cmbLengthFrom.SelectedIndexChanged += UnitSelectionChanged;
            cmbLengthTo.SelectedIndexChanged += UnitSelectionChanged;
            cmbTempFrom.SelectedIndexChanged += UnitSelectionChanged;
            cmbTempTo.SelectedIndexChanged += UnitSelectionChanged;
            cmbAreaFrom.SelectedIndexChanged += UnitSelectionChanged;
            cmbAreaTo.SelectedIndexChanged += UnitSelectionChanged;
            cmbVolumeFrom.SelectedIndexChanged += UnitSelectionChanged;
            cmbVolumeTo.SelectedIndexChanged += UnitSelectionChanged;
            cmbWeightFrom.SelectedIndexChanged += UnitSelectionChanged;
            cmbWeightTo.SelectedIndexChanged += UnitSelectionChanged;
        }

        private void InitializeUnitLists()
        {
            // Length units
            string[] lengthUnits = new string[] {
                "Inches", "Feet", "Yards", "Miles",
                "Millimeters", "Centimeters", "Meters", "Kilometers"
            };
            cmbLengthFrom.Items.AddRange(lengthUnits);
            cmbLengthTo.Items.AddRange(lengthUnits);
            cmbLengthFrom.SelectedIndex = 0;
            cmbLengthTo.SelectedIndex = 1;

            // Temperature units
            string[] tempUnits = new string[] {
                "Celsius", "Fahrenheit", "Kelvin"
            };
            cmbTempFrom.Items.AddRange(tempUnits);
            cmbTempTo.Items.AddRange(tempUnits);
            cmbTempFrom.SelectedIndex = 0;
            cmbTempTo.SelectedIndex = 1;

            // Area units
            string[] areaUnits = new string[] {
                "Square Inches", "Square Feet", "Square Yards", "Square Miles",
                "Acres", "Square Millimeters", "Square Centimeters",
                "Square Meters", "Square Kilometers", "Hectares"
            };
            cmbAreaFrom.Items.AddRange(areaUnits);
            cmbAreaTo.Items.AddRange(areaUnits);
            cmbAreaFrom.SelectedIndex = 0;
            cmbAreaTo.SelectedIndex = 1;

            // Volume units
            string[] volumeUnits = new string[] {
                "Cubic Inches", "Cubic Feet", "Cubic Yards", "Cubic Centimeters",
                "Cubic Meters", "Liters", "Milliliters", "Gallons", "Quarts",
                "Pints", "Cups", "Fluid Ounces", "Tablespoons", "Teaspoons",
                "Barrels (Oil)"
            };
            cmbVolumeFrom.Items.AddRange(volumeUnits);
            cmbVolumeTo.Items.AddRange(volumeUnits);
            cmbVolumeFrom.SelectedIndex = 0;
            cmbVolumeTo.SelectedIndex = 1;

            // Weight units
            string[] weightUnits = new string[] {
                "Ounces", "Pounds", "Tons", "Milligrams",
                "Grams", "Kilograms", "Metric Tons"
            };
            cmbWeightFrom.Items.AddRange(weightUnits);
            cmbWeightTo.Items.AddRange(weightUnits);
            cmbWeightFrom.SelectedIndex = 0;
            cmbWeightTo.SelectedIndex = 1;

            // Time units
            string[] timeUnits = new string[] {
                "Nanoseconds", "Microseconds", "Milliseconds",
                "Seconds", "Minutes", "Hours", "Days",
                "Weeks", "Months", "Years", "Decades", "Centuries",
                 "Quarters"};
            cmbTimeFrom.Items.AddRange(timeUnits);
            cmbTimeTo.Items.AddRange(timeUnits);
            cmbTimeFrom.SelectedIndex = 3;  // Default to Seconds
            cmbTimeTo.SelectedIndex = 4;    // Default to Minutes

            // Pressure units
            string[] pressureUnits = new string[] {
                    "Pascals (Pa)", "Kilopascals (kPa)", "Bars (bar)",
                    "PSI", "Atmospheres (atm)", "mmHg/Torr",
                    "Inches of Water (in WC)", "Inches of Mercury (inHg)"};
            cmbPressureFrom.Items.AddRange(pressureUnits);
            cmbPressureTo.Items.AddRange(pressureUnits);
            cmbPressureFrom.SelectedIndex = 0;  // Default to Pascals
            cmbPressureTo.SelectedIndex = 3;    // Default to PSI
        
        
        }

        private void InitializeGeometryTab()
        {
            // Circle calculations
            cmbCircleFrom.Items.AddRange(new string[] { "Circumference", "Diameter", "Radius", "Area" });
            cmbCircleFrom.SelectedIndex = 0;
            btnCalculateCircle.Click += CalculateCircle;

            // Right triangle calculations
            btnCalculateTriangle.Click += CalculateRightTriangle;

            // Sphere calculations
            cmbSphereFrom.Items.AddRange(new string[] { "Radius", "Volume", "Surface Area" });
            cmbSphereFrom.SelectedIndex = 0;
            btnCalculateSphere.Click += CalculateSphere;

            // Rectangle/box calculations
            btnCalculateRect.Click += CalculateRectangle;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            TabPage currentTab = tabControl1.SelectedTab;

            try
            {
                double inputValue = 0;
                string fromUnit = "";
                string toUnit = "";
                TextBox txtResult = null;

                if (currentTab == tabLength)
                {
                    inputValue = double.Parse(txtLengthInput.Text);
                    fromUnit = cmbLengthFrom.SelectedItem.ToString();
                    toUnit = cmbLengthTo.SelectedItem.ToString();
                    txtResult = txtLengthResult;
                }
                else if (currentTab == tabTemperature)
                {
                    inputValue = double.Parse(txtTempInput.Text);
                    fromUnit = cmbTempFrom.SelectedItem.ToString();
                    toUnit = cmbTempTo.SelectedItem.ToString();
                    txtResult = txtTempResult;
                }
                else if (currentTab == tabArea)
                {
                    inputValue = double.Parse(txtAreaInput.Text);
                    fromUnit = cmbAreaFrom.SelectedItem.ToString();
                    toUnit = cmbAreaTo.SelectedItem.ToString();
                    txtResult = txtAreaResult;
                }
                else if (currentTab == tabVolume)
                {
                    inputValue = double.Parse(txtVolumeInput.Text);
                    fromUnit = cmbVolumeFrom.SelectedItem.ToString();
                    toUnit = cmbVolumeTo.SelectedItem.ToString();
                    txtResult = txtVolumeResult;
                }
                else if (currentTab == tabWeight)
                {
                    inputValue = double.Parse(txtWeightInput.Text);
                    fromUnit = cmbWeightFrom.SelectedItem.ToString();
                    toUnit = cmbWeightTo.SelectedItem.ToString();
                    txtResult = txtWeightResult;
                }
                else if (currentTab == tabTime)
                {
                    inputValue = double.Parse(txtTimeInput.Text);
                    fromUnit = cmbTimeFrom.SelectedItem.ToString();
                    toUnit = cmbTimeTo.SelectedItem.ToString();
                    txtResult = txtTimeResult;
                }
                else if (currentTab == tabPressure)
                {
                    inputValue = double.Parse(txtPressureInput.Text);
                    fromUnit = cmbPressureFrom.SelectedItem.ToString();
                    toUnit = cmbPressureTo.SelectedItem.ToString();
                    txtResult = txtPressureResult;
                }

                double result = ConvertUnits(inputValue, fromUnit, toUnit, currentTab.Name.Replace("tab", ""));
                txtResult.Text = $"{inputValue} {fromUnit} = {result:0.###} {toUnit}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in conversion: {ex.Message}", "Conversion Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double ConvertUnits(double value, string fromUnit, string toUnit, string unitType)
        {
            if (fromUnit == toUnit) return value;

            switch (unitType)
            {
                case "Length":
                    return ConvertLength(value, fromUnit, toUnit);
                case "Temperature":
                    return ConvertTemperature(value, fromUnit, toUnit);
                case "Area":
                    return ConvertArea(value, fromUnit, toUnit);
                case "Volume":
                    return ConvertVolume(value, fromUnit, toUnit);
                case "Weight":
                    return ConvertWeight(value, fromUnit, toUnit);
                case "Time":
                    return ConvertTime(value, fromUnit, toUnit);
                case "Pressure":
                    return ConvertPressure(value, fromUnit, toUnit);
                default:
                    throw new Exception("Unknown unit type");
            }
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            TabPage currentTab = tabControl1.SelectedTab;

            if (currentTab == tabLength)
                SwapComboBoxItems(cmbLengthFrom, cmbLengthTo);
            else if (currentTab == tabTemperature)
                SwapComboBoxItems(cmbTempFrom, cmbTempTo);
            else if (currentTab == tabArea)
                SwapComboBoxItems(cmbAreaFrom, cmbAreaTo);
            else if (currentTab == tabVolume)
                SwapComboBoxItems(cmbVolumeFrom, cmbVolumeTo);
            else if (currentTab == tabWeight)
                SwapComboBoxItems(cmbWeightFrom, cmbWeightTo);
            else if (currentTab == tabTime)
                SwapComboBoxItems(cmbTimeFrom, cmbTimeTo);
            else if (currentTab == tabPressure)
                SwapComboBoxItems(cmbPressureFrom, cmbPressureTo);
        }

        private void SwapComboBoxItems(ComboBox from, ComboBox to)
        {
            int fromIndex = from.SelectedIndex;
            from.SelectedIndex = to.SelectedIndex;
            to.SelectedIndex = fromIndex;
        }

        private void UnitSelectionChanged(object sender, EventArgs e)
        {
            // Optional: Add logic to show conversion formulas or hints
        }

        #region Geometry Calculations
        private void CalculateCircle(object sender, EventArgs e)
        {
            if (double.TryParse(txtCircleInput.Text, out double value))
            {
                double radius = 0;
                string from = cmbCircleFrom.SelectedItem.ToString();

                switch (from)
                {
                    case "Circumference": radius = value / (2 * Math.PI); break;
                    case "Diameter": radius = value / 2; break;
                    case "Radius": radius = value; break;
                    case "Area": radius = Math.Sqrt(value / Math.PI); break;
                }

                txtCircleResults.Text =
                    $"Radius: {radius:0.##}\r\n" +
                    $"Diameter: {radius * 2:0.##}\r\n" +
                    $"Circumference: {2 * Math.PI * radius:0.##}\r\n" +
                    $"Area: {Math.PI * radius * radius:0.##}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateRightTriangle(object sender, EventArgs e)
        {
            if (double.TryParse(txtTriangleA.Text, out double a) &&
                double.TryParse(txtTriangleB.Text, out double b))
            {
                double c = Math.Sqrt(a * a + b * b);
                txtTriangleResults.Text =
                    $"Hypotenuse: {c:0.##}\r\n" +
                    $"Area: {0.5 * a * b:0.##}";
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for both sides", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalculateSphere(object sender, EventArgs e)
        {
            if (double.TryParse(txtSphereInput.Text, out double value))
            {
                double radius = 0;
                string from = cmbSphereFrom.SelectedItem.ToString();

                switch (from)
                {
                    case "Radius": radius = value; break;
                    case "Volume": radius = Math.Pow(value * 0.75 / Math.PI, 1.0 / 3.0); break;
                    case "Surface Area": radius = Math.Sqrt(value / (4 * Math.PI)); break;
                }

                txtSphereResults.Text =
                    $"Radius: {radius:0.##}\r\n" +
                    $"Volume: {(4.0 / 3.0) * Math.PI * Math.Pow(radius, 3):0.##}\r\n" +
                    $"Surface Area: {4 * Math.PI * radius * radius:0.##}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double ConvertPressure(double value, string fromUnit, string toUnit)
        {
            // Convert everything to Pascals first
            double pascals = 0;
            switch (fromUnit)
            {
                case "Pascals (Pa)": pascals = value; break;
                case "Kilopascals (kPa)": pascals = value * 1000; break;
                case "Bars (bar)": pascals = value * 100_000; break;
                case "PSI": pascals = value * 6894.76; break;
                case "Atmospheres (atm)": pascals = value * 101_325; break;
                case "mmHg/Torr": pascals = value * 133.322; break;
                case "Inches of Water (in WC)": pascals = value * 248.84; break;
                case "Inches of Mercury (inHg)": pascals = value * 3386.39; break;
                default: throw new Exception("Unknown pressure unit");
            }

            // Convert from Pascals to target unit
            switch (toUnit)
            {
                case "Pascals (Pa)": return pascals;
                case "Kilopascals (kPa)": return pascals / 1000;
                case "Bars (bar)": return pascals / 100_000;
                case "PSI": return pascals / 6894.76;
                case "Atmospheres (atm)": return pascals / 101_325;
                case "mmHg/Torr": return pascals / 133.322;
                case "Inches of Water (in WC)": return pascals / 248.84;
                case "Inches of Mercury (inHg)": return pascals / 3386.39;
                default: throw new Exception("Unknown pressure unit");
            }
        }
        private void CalculateRectangle(object sender, EventArgs e)
        {
            if (double.TryParse(txtRectLength.Text, out double l) &&
                double.TryParse(txtRectWidth.Text, out double w))
            {
                double area = l * w;
                double diagonal = Math.Sqrt(l * l + w * w);

                string volumeText = "";
                if (double.TryParse(txtRectHeight.Text, out double h))
                    volumeText = $"\r\nVolume: {l * w * h:0.##}";

                txtRectResults.Text =
                    $"Area: {area:0.##}\r\n" +
                    $"Diagonal: {diagonal:0.##}" +
                    volumeText;
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for length and width", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Conversion Methods
        private double ConvertLength(double value, string fromUnit, string toUnit)
        {
            double meters = 0;
            switch (fromUnit)
            {
                case "Inches": meters = value * 0.0254; break;
                case "Feet": meters = value * 0.3048; break;
                case "Yards": meters = value * 0.9144; break;
                case "Miles": meters = value * 1609.34; break;
                case "Millimeters": meters = value * 0.001; break;
                case "Centimeters": meters = value * 0.01; break;
                case "Meters": meters = value; break;
                case "Kilometers": meters = value * 1000; break;
                default: throw new Exception("Unknown length unit");
            }

            switch (toUnit)
            {
                case "Inches": return meters / 0.0254;
                case "Feet": return meters / 0.3048;
                case "Yards": return meters / 0.9144;
                case "Miles": return meters / 1609.34;
                case "Millimeters": return meters / 0.001;
                case "Centimeters": return meters / 0.01;
                case "Meters": return meters;
                case "Kilometers": return meters / 1000;
                default: throw new Exception("Unknown length unit");
            }
        }

        private double ConvertTemperature(double value, string fromUnit, string toUnit)
        {
            double celsius = 0;
            switch (fromUnit)
            {
                case "Celsius": celsius = value; break;
                case "Fahrenheit": celsius = (value - 32) * 5 / 9; break;
                case "Kelvin": celsius = value - 273.15; break;
                default: throw new Exception("Unknown temperature unit");
            }

            switch (toUnit)
            {
                case "Celsius": return celsius;
                case "Fahrenheit": return (celsius * 9 / 5) + 32;
                case "Kelvin": return celsius + 273.15;
                default: throw new Exception("Unknown temperature unit");
            }
        }

        private double ConvertArea(double value, string fromUnit, string toUnit)
        {
            double squareMeters = 0;
            switch (fromUnit)
            {
                case "Square Inches": squareMeters = value * 0.00064516; break;
                case "Square Feet": squareMeters = value * 0.092903; break;
                case "Square Yards": squareMeters = value * 0.836127; break;
                case "Square Miles": squareMeters = value * 2589988.11; break;
                case "Acres": squareMeters = value * 4046.86; break;
                case "Square Millimeters": squareMeters = value * 0.000001; break;
                case "Square Centimeters": squareMeters = value * 0.0001; break;
                case "Square Meters": squareMeters = value; break;
                case "Square Kilometers": squareMeters = value * 1000000; break;
                case "Hectares": squareMeters = value * 10000; break;
                default: throw new Exception("Unknown area unit");
            }

            switch (toUnit)
            {
                case "Square Inches": return squareMeters / 0.00064516;
                case "Square Feet": return squareMeters / 0.092903;
                case "Square Yards": return squareMeters / 0.836127;
                case "Square Miles": return squareMeters / 2589988.11;
                case "Acres": return squareMeters / 4046.86;
                case "Square Millimeters": return squareMeters / 0.000001;
                case "Square Centimeters": return squareMeters / 0.0001;
                case "Square Meters": return squareMeters;
                case "Square Kilometers": return squareMeters / 1000000;
                case "Hectares": return squareMeters / 10000;
                default: throw new Exception("Unknown area unit");
            }
        }

        private double ConvertVolume(double value, string fromUnit, string toUnit)
        {
            double liters = 0;
            switch (fromUnit)
            {
                case "Cubic Inches": liters = value * 0.0163871; break;
                case "Cubic Feet": liters = value * 28.3168; break;
                case "Cubic Yards": liters = value * 764.555; break;
                case "Cubic Centimeters": liters = value * 0.001; break;
                case "Cubic Meters": liters = value * 1000; break;
                case "Liters": liters = value; break;
                case "Milliliters": liters = value * 0.001; break;
                case "Gallons": liters = value * 3.785411784; break;
                case "Quarts": liters = value * 0.946353; break;
                case "Pints": liters = value * 0.473176; break;
                case "Cups": liters = value * 0.236588; break;
                case "Fluid Ounces": liters = value * 0.0295735; break;
                case "Tablespoons": liters = value * 0.0147868; break;
                case "Teaspoons": liters = value * 0.00492892; break;
                case "Barrels (Oil)": liters = value * 158.987294928; break;
                default: throw new Exception("Unknown volume unit");
            }

            switch (toUnit)
            {
                case "Cubic Inches": return liters / 0.0163871;
                case "Cubic Feet": return liters / 28.3168;
                case "Cubic Yards": return liters / 764.555;
                case "Cubic Centimeters": return liters / 0.001;
                case "Cubic Meters": return liters / 1000;
                case "Liters": return liters;
                case "Milliliters": return liters / 0.001;
                case "Gallons": return liters / 3.785411784;
                case "Quarts": return liters / 0.946353;
                case "Pints": return liters / 0.473176;
                case "Cups": return liters / 0.236588;
                case "Fluid Ounces": return liters / 0.0295735;
                case "Tablespoons": return liters / 0.0147868;
                case "Teaspoons": return liters / 0.00492892;
                case "Barrels (Oil)": return liters / 158.987294928;
                default: throw new Exception("Unknown volume unit");
            }
        }

        private double ConvertWeight(double value, string fromUnit, string toUnit)
        {
            double kilograms = 0;
            switch (fromUnit)
            {
                case "Ounces": kilograms = value * 0.0283495; break;
                case "Pounds": kilograms = value * 0.453592; break;
                case "Tons": kilograms = value * 907.185; break;
                case "Milligrams": kilograms = value * 0.000001; break;
                case "Grams": kilograms = value * 0.001; break;
                case "Kilograms": kilograms = value; break;
                case "Metric Tons": kilograms = value * 1000; break;
                default: throw new Exception("Unknown weight unit");
            }

            switch (toUnit)
            {
                case "Ounces": return kilograms / 0.0283495;
                case "Pounds": return kilograms / 0.453592;
                case "Tons": return kilograms / 907.185;
                case "Milligrams": return kilograms / 0.000001;
                case "Grams": return kilograms / 0.001;
                case "Kilograms": return kilograms;
                case "Metric Tons": return kilograms / 1000;
                default: throw new Exception("Unknown weight unit");
            }
        }
        private double ConvertTime(double value, string fromUnit, string toUnit)
        {
            // First convert everything to hours as a common base
            double hours = 0;

            switch (fromUnit)
            {
                case "Nanoseconds": hours = value / 3_600_000_000_000.0; break;
                case "Microseconds": hours = value / 3_600_000_000.0; break;
                case "Milliseconds": hours = value / 3_600_000.0; break;
                case "Seconds": hours = value / 3600.0; break;
                case "Minutes": hours = value / 60.0; break;
                case "Hours": hours = value; break;
                case "Days": hours = value * 24; break;
                case "Weeks": hours = value * 168; break; // 7 days * 24 hours
                case "Months": hours = value * 730.5; break; // 30.4375 days * 24 hours
                case "Years": hours = value * 8766; break; // 365.25 days * 24 hours
                case "Decades": hours = value * 87_660; break;
                case "Centuries": hours = value * 876_600; break;
                
                case "Quarters": hours = value * 2191.5; break; // 3 months * 730.5 hours
                default: throw new Exception("Unknown time unit");
            }

            // Now convert from hours to the target unit
            switch (toUnit)
            {
                case "Nanoseconds": return hours * 3_600_000_000_000.0;
                case "Microseconds": return hours * 3_600_000_000.0;
                case "Milliseconds": return hours * 3_600_000.0;
                case "Seconds": return hours * 3600.0;
                case "Minutes": return hours * 60.0;
                case "Hours": return hours;
                case "Days": return hours / 24.0;
                case "Weeks": return hours / 168.0;
                case "Months": return hours / 730.5;
                case "Years": return hours / 8766.0;
                case "Decades": return hours / 87_660.0;
                case "Centuries": return hours / 876_600.0;
                
                case "Quarters": return hours / 2191.5;
                default: throw new Exception("Unknown time unit");
            }
        }
        #endregion
    }
}