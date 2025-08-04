using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FERExcelAddIn
{
    public partial class FlangeCalculatorForm : Form
    {
        private Dictionary<string, Dictionary<string, FlangeDimensions>> flangeData;

        public FlangeCalculatorForm()
        {
            InitializeComponent();
            this.Text = "PCC-1 Flange Face Calculator (Appendix D)";
            InitializeFlangeData();
            LoadFlangeClasses();
            LoadFlangeSizes();
            LoadGasketTypes();
            SetDefaultValues();
        }

        private void InitializeFlangeData()
        {
            flangeData = new Dictionary<string, Dictionary<string, FlangeDimensions>>();

            // Format: AddFlangeDimension(size, class, thickness, outer diameter, bore, raised face width, gasket ID, gasket OD, radial width)
            // Complete ASME B16.5 data with raised face dimensions and gasket data
            // Sizes ½" to 1½" - all classes have 0.38" raised face
            AddFlangeDimension("0.5", "150", 0.44, 3.5, 0.88, 0.38, 0.84, 1.875, 0.5175);
            AddFlangeDimension("0.5", "300", 0.56, 3.5, 0.88, 0.38, 0.84, 2.125, 0.6425);
            AddFlangeDimension("0.5", "400", 0.68, 3.5, 0.88, 0.38, 0.84, 2.125, 0.6425);
            AddFlangeDimension("0.5", "600", 0.81, 3.5, 0.88, 0.38, 0.84, 2.125, 0.6425);
            AddFlangeDimension("0.5", "900", 0.94, 3.5, 0.88, 0.38, 0.84, 2.5, 0.83);
            AddFlangeDimension("0.5", "1500", 1.06, 3.5, 0.88, 0.38, 0.84, 2.5, 0.83);
            AddFlangeDimension("0.5", "2500", 1.19, 3.5, 0.88, 0.38, 0.84, 2.5, 0.83);

            AddFlangeDimension("0.75", "150", 0.44, 3.88, 1.09, 0.38, 1.06, 2.25, 0.595);
            AddFlangeDimension("0.75", "300", 0.56, 3.88, 1.09, 0.38, 1.06, 2.625, 0.7825);
            AddFlangeDimension("0.75", "400", 0.69, 3.88, 1.09, 0.38, 1.06, 2.625, 0.7825);
            AddFlangeDimension("0.75", "600", 0.81, 3.88, 1.09, 0.38, 1.06, 2.625, 0.7825);
            AddFlangeDimension("0.75", "900", 0.94, 3.88, 1.09, 0.38, 1.06, 2.75, 0.845);
            AddFlangeDimension("0.75", "1500", 1.06, 3.88, 1.09, 0.38, 1.06, 2.75, 0.845);
            AddFlangeDimension("0.75", "2500", 1.19, 3.88, 1.09, 0.38, 1.06, 2.75, 0.845);

            AddFlangeDimension("1", "150", 0.56, 4.25, 1.36, 0.38, 1.31, 2.625, 0.6575);
            AddFlangeDimension("1", "300", 0.69, 4.25, 1.36, 0.38, 1.31, 2.875, 0.7825);
            AddFlangeDimension("1", "400", 0.81, 4.25, 1.36, 0.38, 1.31, 2.875, 0.7825);
            AddFlangeDimension("1", "600", 0.94, 4.25, 1.36, 0.38, 1.31, 2.875, 0.7825);
            AddFlangeDimension("1", "900", 1.06, 4.25, 1.36, 0.38, 1.31, 3.125, 0.9075);
            AddFlangeDimension("1", "1500", 1.19, 4.25, 1.36, 0.38, 1.31, 3.125, 0.9075);
            AddFlangeDimension("1", "2500", 1.31, 4.25, 1.36, 0.38, 1.31, 3.125, 0.9075);

            AddFlangeDimension("1.25", "150", 0.56, 4.62, 1.7, 0.38, 1.66, 3.0, 0.67);
            AddFlangeDimension("1.25", "300", 0.75, 4.62, 1.7, 0.38, 1.66, 3.25, 0.795);
            AddFlangeDimension("1.25", "400", 0.88, 4.62, 1.7, 0.38, 1.66, 3.25, 0.795);
            AddFlangeDimension("1.25", "600", 1.0, 4.62, 1.7, 0.38, 1.66, 3.25, 0.795);
            AddFlangeDimension("1.25", "900", 1.13, 4.62, 1.7, 0.38, 1.66, 3.5, 0.92);
            AddFlangeDimension("1.25", "1500", 1.25, 4.62, 1.7, 0.38, 1.66, 3.5, 0.92);
            AddFlangeDimension("1.25", "2500", 1.38, 4.62, 1.7, 0.38, 1.66, 3.5, 0.92);

            AddFlangeDimension("1.5", "150", 0.62, 5.0, 1.95, 0.38, 1.91, 3.375, 0.7325);
            AddFlangeDimension("1.5", "300", 0.81, 5.0, 1.95, 0.38, 1.91, 3.75, 0.92);
            AddFlangeDimension("1.5", "400", 0.94, 5.0, 1.95, 0.38, 1.91, 3.75, 0.92);
            AddFlangeDimension("1.5", "600", 1.06, 5.0, 1.95, 0.38, 1.91, 3.75, 0.92);
            AddFlangeDimension("1.5", "900", 1.19, 5.0, 1.95, 0.38, 1.91, 3.875, 0.9825);
            AddFlangeDimension("1.5", "1500", 1.31, 5.0, 1.95, 0.38, 1.91, 3.875, 0.9825);
            AddFlangeDimension("1.5", "2500", 1.44, 5.0, 1.95, 0.38, 1.91, 3.875, 0.9825);

            // Sizes 2" to 12" - all classes have 0.62" raised face (except 150# 14"-24" which is 0.62")
            AddFlangeDimension("2", "150", 0.69, 6.0, 2.38, 0.62, 2.38, 4.125, 0.8725);
            AddFlangeDimension("2", "300", 0.88, 6.0, 2.38, 0.62, 2.38, 4.375, 0.9975);
            AddFlangeDimension("2", "400", 1.06, 6.0, 2.38, 0.62, 2.38, 4.375, 0.9975);
            AddFlangeDimension("2", "600", 1.25, 6.0, 2.38, 0.62, 2.38, 4.375, 0.9975);
            AddFlangeDimension("2", "900", 1.44, 6.0, 2.38, 0.62, 2.38, 5.625, 1.6225);
            AddFlangeDimension("2", "1500", 1.63, 6.0, 2.38, 0.62, 2.38, 5.625, 1.6225);
            AddFlangeDimension("2", "2500", 1.81, 6.0, 2.38, 0.62, 2.38, 5.625, 1.6225);

            AddFlangeDimension("2.5", "150", 0.88, 7.0, 2.88, 0.62, 2.88, 4.875, 0.9975);
            AddFlangeDimension("2.5", "300", 1.06, 7.0, 2.88, 0.62, 2.88, 5.125, 1.1225);
            AddFlangeDimension("2.5", "400", 1.25, 7.0, 2.88, 0.62, 2.88, 5.125, 1.1225);
            AddFlangeDimension("2.5", "600", 1.5, 7.5, 2.88, 0.62, 2.88, 5.125, 1.1225);
            AddFlangeDimension("2.5", "900", 1.75, 7.5, 2.88, 0.62, 2.88, 6.5, 1.81);
            AddFlangeDimension("2.5", "1500", 2.0, 8.5, 2.88, 0.62, 2.88, 6.5, 1.81);
            AddFlangeDimension("2.5", "2500", 2.25, 8.5, 2.88, 0.62, 2.88, 6.5, 1.81);

            AddFlangeDimension("3", "150", 0.94, 7.5, 3.5, 0.62, 3.5, 5.375, 0.9375);
            AddFlangeDimension("3", "300", 1.19, 8.0, 3.5, 0.62, 3.5, 5.875, 1.1875);
            AddFlangeDimension("3", "400", 1.44, 8.0, 3.5, 0.62, 3.5, 5.875, 1.1875);
            AddFlangeDimension("3", "600", 1.69, 8.5, 3.5, 0.62, 3.5, 5.875, 1.1875);
            AddFlangeDimension("3", "900", 1.94, 9.0, 3.5, 0.62, 3.5, 6.625, 1.5625);
            AddFlangeDimension("3", "1500", 2.19, 10.0, 3.5, 0.62, 3.5, 6.625, 1.5625);
            AddFlangeDimension("3", "2500", 2.44, 10.0, 3.5, 0.62, 3.5, 6.625, 1.5625);

            AddFlangeDimension("4", "150", 1.0, 9.0, 4.5, 0.62, 4.5, 6.875, 1.1875);
            AddFlangeDimension("4", "300", 1.25, 9.5, 4.5, 0.62, 4.5, 7.125, 1.3125);
            AddFlangeDimension("4", "400", 1.5, 9.5, 4.5, 0.62, 4.5, 7.0, 1.25);
            AddFlangeDimension("4", "600", 1.88, 10.75, 4.5, 0.62, 4.5, 7.625, 1.5625);
            AddFlangeDimension("4", "900", 2.25, 11.0, 4.5, 0.62, 4.5, 8.125, 1.8125);
            AddFlangeDimension("4", "1500", 2.63, 12.5, 4.5, 0.62, 4.5, 8.125, 1.8125);
            AddFlangeDimension("4", "2500", 3.0, 12.5, 4.5, 0.62, 4.5, 8.125, 1.8125);

            AddFlangeDimension("5", "150", 1.06, 10.0, 5.56, 0.62, 5.56, 7.75, 1.095);
            AddFlangeDimension("5", "300", 1.38, 10.5, 5.56, 0.62, 5.56, 8.5, 1.47);
            AddFlangeDimension("5", "400", 1.63, 10.5, 5.56, 0.62, 5.56, 8.375, 1.4075);
            AddFlangeDimension("5", "600", 2.0, 11.75, 5.56, 0.62, 5.56, 9.5, 1.97);
            AddFlangeDimension("5", "900", 2.38, 12.0, 5.56, 0.62, 5.56, 9.75, 2.095);
            AddFlangeDimension("5", "1500", 2.75, 13.75, 5.56, 0.62, 5.56, 9.75, 2.095);
            AddFlangeDimension("5", "2500", 3.13, 13.75, 5.56, 0.62, 5.56, 9.75, 2.095);

            AddFlangeDimension("6", "150", 1.13, 11.0, 6.62, 0.62, 6.62, 8.75, 1.065);
            AddFlangeDimension("6", "300", 1.44, 11.5, 6.62, 0.62, 6.62, 9.875, 1.6275);
            AddFlangeDimension("6", "400", 1.75, 11.5, 6.62, 0.62, 6.62, 9.75, 1.565);
            AddFlangeDimension("6", "600", 2.13, 13.0, 6.62, 0.62, 6.62, 10.5, 1.94);
            AddFlangeDimension("6", "900", 2.5, 13.25, 6.62, 0.62, 6.62, 11.375, 2.3775);
            AddFlangeDimension("6", "1500", 2.88, 15.25, 6.62, 0.62, 6.62, 11.375, 2.3775);
            AddFlangeDimension("6", "2500", 3.25, 15.25, 6.62, 0.62, 6.62, 11.375, 2.3775);

            AddFlangeDimension("8", "150", 1.25, 13.5, 8.62, 0.62, 8.62, 11.0, 1.19);
            AddFlangeDimension("8", "300", 1.63, 14.0, 8.62, 0.62, 8.62, 12.125, 1.7525);
            AddFlangeDimension("8", "400", 1.94, 14.0, 8.62, 0.62, 8.62, 12.0, 1.69);
            AddFlangeDimension("8", "600", 2.38, 15.5, 8.62, 0.62, 8.62, 12.625, 2.0025);
            AddFlangeDimension("8", "900", 2.75, 16.0, 8.62, 0.62, 8.62, 14.125, 2.7525);
            AddFlangeDimension("8", "1500", 3.13, 18.0, 8.62, 0.62, 8.62, 14.125, 2.7525);
            AddFlangeDimension("8", "2500", 3.5, 18.0, 8.62, 0.62, 8.62, 14.125, 2.7525);

            AddFlangeDimension("10", "150", 1.38, 16.0, 10.75, 0.62, 10.75, 13.375, 1.3125);
            AddFlangeDimension("10", "300", 1.81, 16.5, 10.75, 0.62, 10.75, 14.25, 1.75);
            AddFlangeDimension("10", "400", 2.13, 16.5, 10.75, 0.62, 10.75, 14.125, 1.6875);
            AddFlangeDimension("10", "600", 2.63, 18.5, 10.75, 0.62, 10.75, 15.75, 2.5);
            AddFlangeDimension("10", "900", 3.0, 19.0, 10.75, 0.62, 10.75, 17.125, 3.1875);
            AddFlangeDimension("10", "1500", 3.38, 21.25, 10.75, 0.62, 10.75, 17.125, 3.1875);
            AddFlangeDimension("10", "2500", 3.75, 21.25, 10.75, 0.62, 10.75, 17.125, 3.1875);

            AddFlangeDimension("12", "150", 1.38, 19.75, 12.75, 0.62, 12.75, 16.125, 1.6875);
            AddFlangeDimension("12", "300", 1.69, 21.25, 12.75, 0.62, 12.75, 16.625, 1.9375);
            AddFlangeDimension("12", "400", 2.0, 21.25, 12.75, 0.62, 12.75, 16.5, 1.875);
            AddFlangeDimension("12", "600", 2.31, 21.25, 12.75, 0.62, 12.75, 18.0, 2.625);
            AddFlangeDimension("12", "900", 2.63, 21.25, 12.75, 0.62, 12.75, 19.625, 3.4375);
            AddFlangeDimension("12", "1500", 2.94, 21.25, 12.75, 0.62, 12.75, 19.625, 3.4375);
            AddFlangeDimension("12", "2500", 3.25, 21.25, 12.75, 0.62, 12.75, 19.625, 3.4375);

            // Sizes 14" to 24" - 300# to 600# have 0.75", 900# to 2500# have 1.00"
            AddFlangeDimension("14", "150", 1.5, 23.25, 14.0, 0.62, 14.0, 18.75, 2.375);
            AddFlangeDimension("14", "300", 1.88, 23.25, 14.0, 0.75, 14.0, 19.25, 2.625);
            AddFlangeDimension("14", "400", 2.25, 23.25, 14.0, 0.75, 14.0, 19.0, 2.5);
            AddFlangeDimension("14", "600", 2.63, 23.25, 14.0, 0.75, 14.0, 20.5, 3.25);
            AddFlangeDimension("14", "900", 3.0, 23.25, 14.0, 1.0, 14.0, 22.125, 4.0625);
            AddFlangeDimension("14", "1500", 3.38, 23.25, 14.0, 1.0, 14.0, 22.125, 4.0625);
            AddFlangeDimension("14", "2500", 3.75, 23.25, 14.0, 1.0, 14.0, 22.125, 4.0625);

            AddFlangeDimension("16", "150", 1.63, 25.75, 16.0, 0.62, 16.0, 21.25, 2.625);
            AddFlangeDimension("16", "300", 2.06, 27.0, 16.0, 0.75, 16.0, 22.0, 3.0);
            AddFlangeDimension("16", "400", 2.44, 27.0, 16.0, 0.75, 16.0, 21.75, 2.875);
            AddFlangeDimension("16", "600", 2.88, 29.5, 16.0, 0.75, 16.0, 23.75, 3.875);
            AddFlangeDimension("16", "900", 3.25, 30.0, 16.0, 1.0, 16.0, 25.625, 4.8125);
            AddFlangeDimension("16", "1500", 3.63, 32.5, 16.0, 1.0, 16.0, 25.625, 4.8125);
            AddFlangeDimension("16", "2500", 4.0, 32.5, 16.0, 1.0, 16.0, 25.625, 4.8125);

            AddFlangeDimension("18", "150", 1.75, 28.25, 18.0, 0.62, 18.0, 23.75, 2.875);
            AddFlangeDimension("18", "300", 2.19, 29.5, 18.0, 0.75, 18.0, 24.5, 3.25);
            AddFlangeDimension("18", "400", 2.63, 29.5, 18.0, 0.75, 18.0, 24.25, 3.125);
            AddFlangeDimension("18", "600", 3.06, 32.0, 18.0, 0.75, 18.0, 26.5, 4.25);
            AddFlangeDimension("18", "900", 3.5, 32.5, 18.0, 1.0, 18.0, 28.375, 5.1875);
            AddFlangeDimension("18", "1500", 3.88, 35.0, 18.0, 1.0, 18.0, 28.375, 5.1875);
            AddFlangeDimension("18", "2500", 4.25, 35.0, 18.0, 1.0, 18.0, 28.375, 5.1875);

            AddFlangeDimension("20", "150", 1.88, 30.75, 20.0, 0.62, 20.0, 26.25, 3.125);
            AddFlangeDimension("20", "300", 2.38, 32.0, 20.0, 0.75, 20.0, 27.0, 3.5);
            AddFlangeDimension("20", "400", 2.81, 32.0, 20.0, 0.75, 20.0, 26.75, 3.375);
            AddFlangeDimension("20", "600", 3.25, 35.0, 20.0, 0.75, 20.0, 29.25, 4.625);
            AddFlangeDimension("20", "900", 3.75, 35.5, 20.0, 1.0, 20.0, 31.375, 5.6875);
            AddFlangeDimension("20", "1500", 4.13, 38.0, 20.0, 1.0, 20.0, 31.375, 5.6875);
            AddFlangeDimension("20", "2500", 4.5, 38.0, 20.0, 1.0, 20.0, 31.375, 5.6875);

            AddFlangeDimension("24", "150", 1.88, 32.0, 24.0, 0.62, 24.0, 32.0, 4.0);
            AddFlangeDimension("24", "300", 2.38, 38.0, 24.0, 0.75, 24.0, 33.0, 4.5);
            AddFlangeDimension("24", "400", 2.88, 38.0, 24.0, 0.75, 24.0, 32.75, 4.375);
            AddFlangeDimension("24", "600", 3.38, 38.0, 24.0, 0.75, 24.0, 35.75, 5.875);
            AddFlangeDimension("24", "900", 3.88, 38.0, 24.0, 1.0, 24.0, 38.125, 7.0625);
            AddFlangeDimension("24", "1500", 4.38, 38.0, 24.0, 1.0, 24.0, 38.125, 7.0625);
            AddFlangeDimension("24", "2500", 4.88, 38.0, 24.0, 1.0, 24.0, 38.125, 7.0625);
        }

        private void AddFlangeDimension(string size, string rating, double thickness, double od, double bore, double raisedFaceWidth, double gasketID, double gasketOD, double radialWidth)
        {
            if (!flangeData.ContainsKey(size))
                flangeData[size] = new Dictionary<string, FlangeDimensions>();

            flangeData[size][rating] = new FlangeDimensions(thickness, od, bore, raisedFaceWidth, gasketID, gasketOD, radialWidth);
        }

        private void LoadFlangeClasses()
        {
            cmbFlangeClass.Items.AddRange(new object[] { "150", "300", "400", "600", "900", "1500", "2500" });
            cmbFlangeClass.SelectedIndex = 1; // Default to 300#
            cmbFlangeClass.SelectedIndexChanged += FlangeSelectionChanged;
        }

        private void LoadFlangeSizes()
        {
            cmbFlangeSize.Items.AddRange(new object[] {
                "0.5", "0.75", "1", "1.25", "1.5", "2",
                "2.5", "3", "3.5", "4", "5", "6",
                "8", "10", "12", "14", "16", "18",
                "20", "22", "24",
            });
            cmbFlangeSize.SelectedIndex = 12; // Default to 12"
            cmbFlangeSize.SelectedIndexChanged += FlangeSelectionChanged;
        }

        private void LoadGasketTypes()
        {
            cmbGasketType.Items.AddRange(new object[] { "soft", "hard" });
            cmbGasketType.SelectedIndex = 0;
        }

        private void FlangeSelectionChanged(object sender, EventArgs e)
        {
            UpdateFlangeDimensions();
        }

        private void UpdateFlangeDimensions()
        {
            if (cmbFlangeSize.SelectedItem == null || cmbFlangeClass.SelectedItem == null)
                return;

            string size = cmbFlangeSize.SelectedItem.ToString();
            string rating = cmbFlangeClass.SelectedItem.ToString();

            if (flangeData.ContainsKey(size) && flangeData[size].ContainsKey(rating))
            {
                var dims = flangeData[size][rating];
                //lblDimensions.Text = $"Dimensions - Thickness: {dims.Thickness:F2}\" | OD: {dims.OuterDiameter:F2}\" | Bore: {dims.Bore:F2}\" | RF Width: {dims.RaisedFaceWidth:F2}\"";
                txtThickness.Text = dims.Thickness.ToString("F2");
                txtOD.Text = dims.OuterDiameter.ToString("F2");
                txtBore.Text = dims.Bore.ToString("F2");
                txtGasketID.Text = dims.GasketID.ToString("F2");
                txtGasketOD.Text = dims.GasketOD.ToString("F2");
                txtRadialWidth.Text = dims.RadialWidth.ToString("F4");
            }
            else
            {
                lblDimensions.Text = "Dimensions: Data not available for selected size/class";
                txtThickness.Text = "";
                txtOD.Text = "";
                txtBore.Text = "";
                txtGasketID.Text = "";
                txtGasketOD.Text = "";
                txtRadialWidth.Text = "";
            }
        }

        private void SetDefaultValues()
        {
            txtLength.Text = "0.5";
            txtWidth.Text = "0.1";
            txtDepth.Text = "0.02";
            txtDistanceFromEdge.Text = "0.25";
            UpdateFlangeDimensions();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputs())
                    return;

                double flangeSize = double.Parse(cmbFlangeSize.SelectedItem.ToString());
                string flangeClass = cmbFlangeClass.SelectedItem.ToString();
                double length = double.Parse(txtLength.Text);
                double width = double.Parse(txtWidth.Text);
                double depth = double.Parse(txtDepth.Text);
                double distanceFromEdge = double.Parse(txtDistanceFromEdge.Text);
                string gasketType = cmbGasketType.SelectedItem.ToString();

                var result = EvaluateFlangeFace(flangeSize, flangeClass, length, width, depth, distanceFromEdge, gasketType);

                lblGrade.Text = $"Flange Face Grade: {result.Grade}";
                lblEvaluation.Text = result.Evaluation;
                lblNotes.Text = result.Notes;

                lblGrade.ForeColor = GetGradeColor(result.Grade);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in calculation: {ex.Message}", "Calculation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            if (cmbFlangeSize.SelectedItem == null ||
                !double.TryParse(cmbFlangeSize.SelectedItem.ToString(), out _) ||
                cmbFlangeClass.SelectedItem == null ||
                !int.TryParse(cmbFlangeClass.SelectedItem.ToString(), out _) ||
                !double.TryParse(txtLength.Text, out _) ||
                !double.TryParse(txtWidth.Text, out _) ||
                !double.TryParse(txtDepth.Text, out _) ||
                !double.TryParse(txtDistanceFromEdge.Text, out _))
            {
                MessageBox.Show("Please enter valid numeric values for all fields", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbGasketType.SelectedItem == null)
            {
                MessageBox.Show("Please select a gasket type", "Input Required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private (string Grade, string Evaluation, string Notes) EvaluateFlangeFace(
            double flangeSize, string flangeClass,
            double length, double width,
            double depth, double distanceFromEdge,
            string gasketType,
            double? circumferentialFlatness = null,
            double? radialFlatness = null,
            double? pipingSurfaceHeight = null)
        {
            const double measurementTolerance = 0.001;
            bool isHardGasket = gasketType == "hard";
            bool isHighPressure = int.Parse(flangeClass) >= 600;

            // Get flange dimensions including raised face width
            string sizeKey = flangeSize.ToString();
            if (!flangeData.ContainsKey(sizeKey) || !flangeData[sizeKey].ContainsKey(flangeClass))
            {
                return ("D", "Data Missing", "Flange dimensions not available for evaluation");
            }

            double gasketSurfaceWidth = flangeData[sizeKey][flangeClass].RaisedFaceWidth;

            // Validate defect width doesn't exceed gasket seating surface
            if (width > gasketSurfaceWidth)
            {
                return ("D", "Unacceptable - width",
                    $"Defect width ({width:F3}\") exceeds gasket seating surface width ({gasketSurfaceWidth:F3}\")");
            }

            // Calculate relative distance from edge in terms of gasket surface width
            double rd = distanceFromEdge / gasketSurfaceWidth;

            // Table D-2 depth limits
            var depthLimits = isHardGasket
                ? new[] { (0.25, 0.030), (0.5, 0.010), (0.75, 0.0) }
                : new[] { (0.25, 0.050), (0.5, 0.030), (0.75, 0.005) };

            double maxAllowedDepth = 0;
            string zone = "";
            foreach (var limit in depthLimits)
            {
                if (rd < limit.Item1)
                {
                    maxAllowedDepth = limit.Item2;
                    zone = $"rd < {(limit.Item1 * 100):F0}% of w";
                    break;
                }
            }

            // Edge distance absolute minimum (Figure D-3 protection)
            double minEdgeDistance = Math.Max(0.125, width * 0.1); // At least 0.125" or 10% of width

            // Evaluation
            if (distanceFromEdge < minEdgeDistance)
                return ("D", "Unacceptable - edge distance",
                       $"Minimum edge distance ({minEdgeDistance:F3}\") not met (Figure D-3)");

            if (maxAllowedDepth == 0 && depth > measurementTolerance)
                return ("D", "Unacceptable - location",
                       $"Defects not allowed in this location ({zone})");

            if (depth > maxAllowedDepth)
                return ("C", "Requires repair",
                       $"Depth ({depth:F3}\") exceeds {maxAllowedDepth:F3}\" limit for {zone}");

            // Figure D-3 multiple defect rules
            if (length > 2 * width)
                return ("C", "Requires repair",
                       $"Length ({length:F3}\") exceeds 2x width limit (Figure D-3)");

            // Minor defect acceptance
            if (depth <= 0.005 && length <= 0.1)
                return ("A", "Acceptable as-is",
                       "Minor defect within automatic acceptance limits");

            return ("B", "Acceptable with verification",
                   "Defect within limits - verify no sealing surface damage (Figure D-3)");
        }

        private System.Drawing.Color GetGradeColor(string grade)
        {
            switch (grade)
            {
                case "A": return System.Drawing.Color.Green;
                case "B": return System.Drawing.Color.Blue;
                case "C": return System.Drawing.Color.Orange;
                case "D": return System.Drawing.Color.Red;
                default: return System.Drawing.Color.Black;
            }
        }

        private class FlangeDimensions
        {
            public double Thickness { get; }
            public double OuterDiameter { get; }
            public double Bore { get; }
            public double RaisedFaceWidth { get; }
            public double GasketID { get; }
            public double GasketOD { get; }
            public double RadialWidth { get; }

            public FlangeDimensions(double thickness, double outerDiameter, double bore, double raisedFaceWidth, double gasketID, double gasketOD, double radialWidth)
            {
                Thickness = thickness;
                OuterDiameter = outerDiameter;
                Bore = bore;
                RaisedFaceWidth = raisedFaceWidth;
                GasketID = gasketID;
                GasketOD = gasketOD;
                RadialWidth = radialWidth;
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
