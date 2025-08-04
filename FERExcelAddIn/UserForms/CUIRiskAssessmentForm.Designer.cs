using System.Windows.Forms;

namespace FERExcelAddIn
{
    partial class CUIAssessmentForm
    {
        private System.ComponentModel.IContainer components = null;
        

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCarbonGrading = new System.Windows.Forms.Label();
            this.cmbTemperatureRange = new System.Windows.Forms.ComboBox();
            this.cmbCoatingAge = new System.Windows.Forms.ComboBox();
            this.cmbJacketingCondition = new System.Windows.Forms.ComboBox();
            this.cmbHeatTracing = new System.Windows.Forms.ComboBox();
            this.cmbEnvironment = new System.Windows.Forms.ComboBox();
            this.cmbInsulationType = new System.Windows.Forms.ComboBox();
            this.cmbLineSize = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSsGrading = new System.Windows.Forms.Label();
            this.cmbSsTemperatureRange = new System.Windows.Forms.ComboBox();
            this.cmbSsCoatingAge = new System.Windows.Forms.ComboBox();
            this.cmbSsJacketingCondition = new System.Windows.Forms.ComboBox();
            this.cmbSsHeatTracing = new System.Windows.Forms.ComboBox();
            this.cmbSsEnvironment = new System.Windows.Forms.ComboBox();
            this.cmbSsInsulationType = new System.Windows.Forms.ComboBox();
            this.cmbSsLineSize = new System.Windows.Forms.ComboBox();
            this.btnSsCalculate = new System.Windows.Forms.Button();
            this.lblSsResult = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblCufGrading = new System.Windows.Forms.Label();
            this.cmbCufTemperature = new System.Windows.Forms.ComboBox();
            this.cmbCufCoatingAge = new System.Windows.Forms.ComboBox();
            this.cmbCufFireproofing = new System.Windows.Forms.ComboBox();
            this.cmbCufWaterIngress = new System.Windows.Forms.ComboBox();
            this.cmbCufEnvironment = new System.Windows.Forms.ComboBox();
            this.cmbCufMaterialType = new System.Windows.Forms.ComboBox();
            this.btnCufCalculate = new System.Windows.Forms.Button();
            this.lblCufResult = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(850, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCarbonGrading);
            this.tabPage1.Controls.Add(this.cmbTemperatureRange);
            this.tabPage1.Controls.Add(this.cmbCoatingAge);
            this.tabPage1.Controls.Add(this.cmbJacketingCondition);
            this.tabPage1.Controls.Add(this.cmbHeatTracing);
            this.tabPage1.Controls.Add(this.cmbEnvironment);
            this.tabPage1.Controls.Add(this.cmbInsulationType);
            this.tabPage1.Controls.Add(this.cmbLineSize);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(842, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "A.1 - Carbon & Low Alloy Steel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCarbonGrading
            // 
            this.lblCarbonGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCarbonGrading.Location = new System.Drawing.Point(450, 300);
            this.lblCarbonGrading.Name = "lblCarbonGrading";
            this.lblCarbonGrading.Size = new System.Drawing.Size(200, 127);
            this.lblCarbonGrading.TabIndex = 9;
            this.lblCarbonGrading.Text = "Grading Chart:\r\nA = <7 points\r\nB = 7 to <14 points\r\nC = 14 to 20 points\r\nD = >20 " +
    "to 27 points\r\nE = >27 points";
            // 
            // cmbTemperatureRange
            // 
            this.cmbTemperatureRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemperatureRange.FormattingEnabled = true;
            this.cmbTemperatureRange.Items.AddRange(new object[] {
            "Select temperature range...",
            "25°F to 100°F or 270°F to 350°F (1 point)",
            "100°F to 170°F or 230°F to 270°F (3 points)",
            "170°F to 230°F or cyclic service (5 points)"});
            this.cmbTemperatureRange.Location = new System.Drawing.Point(20, 20);
            this.cmbTemperatureRange.Name = "cmbTemperatureRange";
            this.cmbTemperatureRange.Size = new System.Drawing.Size(463, 28);
            this.cmbTemperatureRange.TabIndex = 0;
            // 
            // cmbCoatingAge
            // 
            this.cmbCoatingAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoatingAge.FormattingEnabled = true;
            this.cmbCoatingAge.Items.AddRange(new object[] {
            "Select coating/age...",
            "Quality coating within 8 years or system age <15 years (0 points)",
            "Quality coating within 15 years or system age <30 years (1 point)",
            "General coating 8 to 15 years (3 points)",
            "General coating age >15 years, system age >30 years (5 points)"});
            this.cmbCoatingAge.Location = new System.Drawing.Point(20, 60);
            this.cmbCoatingAge.Name = "cmbCoatingAge";
            this.cmbCoatingAge.Size = new System.Drawing.Size(463, 28);
            this.cmbCoatingAge.TabIndex = 1;
            // 
            // cmbJacketingCondition
            // 
            this.cmbJacketingCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJacketingCondition.FormattingEnabled = true;
            this.cmbJacketingCondition.Items.AddRange(new object[] {
            "Select jacketing condition...",
            "System age <5 years without deficiencies (0 points)",
            "Average condition with good maintenance (1 point)",
            "Average condition with some deficiencies (3 points)",
            "Damaged condition with several deficiencies (5 points)"});
            this.cmbJacketingCondition.Location = new System.Drawing.Point(20, 100);
            this.cmbJacketingCondition.Name = "cmbJacketingCondition";
            this.cmbJacketingCondition.Size = new System.Drawing.Size(463, 28);
            this.cmbJacketingCondition.TabIndex = 2;
            // 
            // cmbHeatTracing
            // 
            this.cmbHeatTracing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeatTracing.FormattingEnabled = true;
            this.cmbHeatTracing.Items.AddRange(new object[] {
            "Select heat tracing...",
            "None (0 points)",
            "High-integrity steam system or electric tracing (1 point)",
            "Steam system with medium integrity (3 points)",
            "Steam system with visible leaks (5 points)"});
            this.cmbHeatTracing.Location = new System.Drawing.Point(20, 140);
            this.cmbHeatTracing.Name = "cmbHeatTracing";
            this.cmbHeatTracing.Size = new System.Drawing.Size(463, 28);
            this.cmbHeatTracing.TabIndex = 3;
            // 
            // cmbEnvironment
            // 
            this.cmbEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnvironment.FormattingEnabled = true;
            this.cmbEnvironment.Items.AddRange(new object[] {
            "Select environment...",
            "No sweating (0 points)",
            "Arid and inland (1 point)",
            "All other locations (3 points)",
            "Coastal/marine, cooling tower overspray (5 points)"});
            this.cmbEnvironment.Location = new System.Drawing.Point(20, 180);
            this.cmbEnvironment.Name = "cmbEnvironment";
            this.cmbEnvironment.Size = new System.Drawing.Size(463, 28);
            this.cmbEnvironment.TabIndex = 4;
            // 
            // cmbInsulationType
            // 
            this.cmbInsulationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInsulationType.FormattingEnabled = true;
            this.cmbInsulationType.Items.AddRange(new object[] {
            "Select insulation type...",
            "No insulation, insulating coatings (0 points)",
            "Expanded perlite, cellular glass (1 point)",
            "Fiberglass, silica aerogel (3 points)",
            "Traditional mineral wool (5 points)"});
            this.cmbInsulationType.Location = new System.Drawing.Point(20, 220);
            this.cmbInsulationType.Name = "cmbInsulationType";
            this.cmbInsulationType.Size = new System.Drawing.Size(463, 28);
            this.cmbInsulationType.TabIndex = 5;
            // 
            // cmbLineSize
            // 
            this.cmbLineSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLineSize.FormattingEnabled = true;
            this.cmbLineSize.Items.AddRange(new object[] {
            "Select line size...",
            "Equipment (0 points)",
            ">6 in. (1 point)",
            ">2 in. to 6 in. (3 points)",
            "≤2 in. (5 points)"});
            this.cmbLineSize.Location = new System.Drawing.Point(20, 260);
            this.cmbLineSize.Name = "cmbLineSize";
            this.cmbLineSize.Size = new System.Drawing.Size(463, 28);
            this.cmbLineSize.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(20, 300);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 30);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate CUI Likelihood";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(20, 340);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(400, 50);
            this.lblResult.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSsGrading);
            this.tabPage2.Controls.Add(this.cmbSsTemperatureRange);
            this.tabPage2.Controls.Add(this.cmbSsCoatingAge);
            this.tabPage2.Controls.Add(this.cmbSsJacketingCondition);
            this.tabPage2.Controls.Add(this.cmbSsHeatTracing);
            this.tabPage2.Controls.Add(this.cmbSsEnvironment);
            this.tabPage2.Controls.Add(this.cmbSsInsulationType);
            this.tabPage2.Controls.Add(this.cmbSsLineSize);
            this.tabPage2.Controls.Add(this.btnSsCalculate);
            this.tabPage2.Controls.Add(this.lblSsResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(842, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "A.3 - Austenitic and Duplex Stainless Steel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSsGrading
            // 
            this.lblSsGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblSsGrading.Location = new System.Drawing.Point(450, 300);
            this.lblSsGrading.Name = "lblSsGrading";
            this.lblSsGrading.Size = new System.Drawing.Size(200, 128);
            this.lblSsGrading.TabIndex = 9;
            this.lblSsGrading.Text = "Grading Chart:\r\nA = <7 points\r\nB = 7 to <14 points\r\nC = 14 to 20 points\r\nD = >20 " +
    "to 27 points\r\nE = >27 points";
            // 
            // cmbSsTemperatureRange
            // 
            this.cmbSsTemperatureRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSsTemperatureRange.FormattingEnabled = true;
            this.cmbSsTemperatureRange.Items.AddRange(new object[] {
            "Select temperature range...",
            "120°F to 140°F (1 point)",
            "250°F to 400°F (3 points)",
            "140°F to 250°F (5 points)"});
            this.cmbSsTemperatureRange.Location = new System.Drawing.Point(20, 20);
            this.cmbSsTemperatureRange.Name = "cmbSsTemperatureRange";
            this.cmbSsTemperatureRange.Size = new System.Drawing.Size(453, 28);
            this.cmbSsTemperatureRange.TabIndex = 0;
            // 
            // cmbSsCoatingAge
            // 
            this.cmbSsCoatingAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSsCoatingAge.FormattingEnabled = true;
            this.cmbSsCoatingAge.Items.AddRange(new object[] {
            "Select coating/age...",
            "Quality coating within 8 years (0 points)",
            "Quality coating within 15 years (1 point)",
            "General coating 8 to 15 years (3 points)",
            "General coating >15 years or unknown (5 points)"});
            this.cmbSsCoatingAge.Location = new System.Drawing.Point(20, 60);
            this.cmbSsCoatingAge.Name = "cmbSsCoatingAge";
            this.cmbSsCoatingAge.Size = new System.Drawing.Size(453, 28);
            this.cmbSsCoatingAge.TabIndex = 1;
            // 
            // cmbSsJacketingCondition
            // 
            this.cmbSsJacketingCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSsJacketingCondition.FormattingEnabled = true;
            this.cmbSsJacketingCondition.Items.AddRange(new object[] {
            "Select jacketing condition...",
            "No deficiencies (0 points)",
            "Average condition with good maintenance (1 point)",
            "Average condition with some deficiencies (3 points)",
            "Damaged condition with several deficiencies (5 points)"});
            this.cmbSsJacketingCondition.Location = new System.Drawing.Point(20, 100);
            this.cmbSsJacketingCondition.Name = "cmbSsJacketingCondition";
            this.cmbSsJacketingCondition.Size = new System.Drawing.Size(453, 28);
            this.cmbSsJacketingCondition.TabIndex = 2;
            // 
            // cmbSsHeatTracing
            // 
            this.cmbSsHeatTracing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSsHeatTracing.FormattingEnabled = true;
            this.cmbSsHeatTracing.Items.AddRange(new object[] {
            "Select heat tracing...",
            "None (0 points)",
            "High-integrity steam/electric (CI-free) (1 point)",
            "Steam system with medium integrity (3 points)",
            "Visible leaks or electrical with PVC (5 points)"});
            this.cmbSsHeatTracing.Location = new System.Drawing.Point(20, 140);
            this.cmbSsHeatTracing.Name = "cmbSsHeatTracing";
            this.cmbSsHeatTracing.Size = new System.Drawing.Size(453, 28);
            this.cmbSsHeatTracing.TabIndex = 3;
            // 
            // cmbSsEnvironment
            // 
            this.cmbSsEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSsEnvironment.FormattingEnabled = true;
            this.cmbSsEnvironment.Items.AddRange(new object[] {
            "Select environment...",
            "No sweating (0 points)",
            "Arid and inland (1 point)",
            "All other locations (3 points)",
            "Coastal/marine, cooling tower (5 points)"});
            this.cmbSsEnvironment.Location = new System.Drawing.Point(20, 180);
            this.cmbSsEnvironment.Name = "cmbSsEnvironment";
            this.cmbSsEnvironment.Size = new System.Drawing.Size(453, 28);
            this.cmbSsEnvironment.TabIndex = 4;
            // 
            // cmbSsInsulationType
            // 
            this.cmbSsInsulationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSsInsulationType.FormattingEnabled = true;
            this.cmbSsInsulationType.Items.AddRange(new object[] {
            "Select insulation type...",
            "No insulation, insulating coatings (0 points)",
            "Expanded perlite, cellular glass (1 point)",
            "Fiberglass, silica aerogel (3 points)",
            "Traditional mineral wool (5 points)"});
            this.cmbSsInsulationType.Location = new System.Drawing.Point(20, 220);
            this.cmbSsInsulationType.Name = "cmbSsInsulationType";
            this.cmbSsInsulationType.Size = new System.Drawing.Size(453, 28);
            this.cmbSsInsulationType.TabIndex = 5;
            // 
            // cmbSsLineSize
            // 
            this.cmbSsLineSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSsLineSize.FormattingEnabled = true;
            this.cmbSsLineSize.Items.AddRange(new object[] {
            "Select line size...",
            "Equipment (0 points)",
            ">6 in. (1 point)",
            ">2 in. to 6 in. (3 points)",
            "≤2 in. (5 points)"});
            this.cmbSsLineSize.Location = new System.Drawing.Point(20, 260);
            this.cmbSsLineSize.Name = "cmbSsLineSize";
            this.cmbSsLineSize.Size = new System.Drawing.Size(453, 28);
            this.cmbSsLineSize.TabIndex = 6;
            // 
            // btnSsCalculate
            // 
            this.btnSsCalculate.Location = new System.Drawing.Point(20, 300);
            this.btnSsCalculate.Name = "btnSsCalculate";
            this.btnSsCalculate.Size = new System.Drawing.Size(200, 30);
            this.btnSsCalculate.TabIndex = 7;
            this.btnSsCalculate.Text = "Calculate CUI Likelihood";
            this.btnSsCalculate.UseVisualStyleBackColor = true;
            // 
            // lblSsResult
            // 
            this.lblSsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSsResult.Location = new System.Drawing.Point(20, 340);
            this.lblSsResult.Name = "lblSsResult";
            this.lblSsResult.Size = new System.Drawing.Size(400, 50);
            this.lblSsResult.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblCufGrading);
            this.tabPage3.Controls.Add(this.cmbCufTemperature);
            this.tabPage3.Controls.Add(this.cmbCufCoatingAge);
            this.tabPage3.Controls.Add(this.cmbCufFireproofing);
            this.tabPage3.Controls.Add(this.cmbCufWaterIngress);
            this.tabPage3.Controls.Add(this.cmbCufEnvironment);
            this.tabPage3.Controls.Add(this.cmbCufMaterialType);
            this.tabPage3.Controls.Add(this.btnCufCalculate);
            this.tabPage3.Controls.Add(this.lblCufResult);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(842, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "A.5 - CUF Assessment";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblCufGrading
            // 
            this.lblCufGrading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblCufGrading.Location = new System.Drawing.Point(450, 260);
            this.lblCufGrading.Name = "lblCufGrading";
            this.lblCufGrading.Size = new System.Drawing.Size(200, 136);
            this.lblCufGrading.TabIndex = 8;
            this.lblCufGrading.Text = "Grading Chart:\r\nA = <7 points\r\nB = 7 to <12 points\r\nC = 12 to 16 points\r\nD = >16 " +
    "to 19 points\r\nE = >19 points";
            // 
            // cmbCufTemperature
            // 
            this.cmbCufTemperature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCufTemperature.FormattingEnabled = true;
            this.cmbCufTemperature.Items.AddRange(new object[] {
            "Select operating temperature...",
            "120°F to 140°F (49°C to 60°C) (1 point)",
            "250°F to 400°F (121°C to 204°C) (3 points)",
            "140°F to 250°F (60°C to 121°C) (5 points)"});
            this.cmbCufTemperature.Location = new System.Drawing.Point(20, 20);
            this.cmbCufTemperature.Name = "cmbCufTemperature";
            this.cmbCufTemperature.Size = new System.Drawing.Size(439, 28);
            this.cmbCufTemperature.TabIndex = 0;
            // 
            // cmbCufCoatingAge
            // 
            this.cmbCufCoatingAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCufCoatingAge.FormattingEnabled = true;
            this.cmbCufCoatingAge.Items.AddRange(new object[] {
            "Select coating/age...",
            "Quality coating within 8 years or system age <15 years (0 points)",
            "Quality coating within 15 years or system age <30 years (1 point)",
            "General coating 8 to 15 years (3 points)",
            "General coating >15 years, system age >30 years, or unknown (5 points)"});
            this.cmbCufCoatingAge.Location = new System.Drawing.Point(20, 60);
            this.cmbCufCoatingAge.Name = "cmbCufCoatingAge";
            this.cmbCufCoatingAge.Size = new System.Drawing.Size(439, 28);
            this.cmbCufCoatingAge.TabIndex = 1;
            // 
            // cmbCufFireproofing
            // 
            this.cmbCufFireproofing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCufFireproofing.FormattingEnabled = true;
            this.cmbCufFireproofing.Items.AddRange(new object[] {
            "Select fireproofing condition...",
            "System age <5 years without deficiencies (0 points)",
            "Average condition with good maintenance (1 point)",
            "Average condition with cracking evident (3 points)",
            "Damaged condition (5 points)"});
            this.cmbCufFireproofing.Location = new System.Drawing.Point(20, 100);
            this.cmbCufFireproofing.Name = "cmbCufFireproofing";
            this.cmbCufFireproofing.Size = new System.Drawing.Size(439, 28);
            this.cmbCufFireproofing.TabIndex = 2;
            // 
            // cmbCufWaterIngress
            // 
            this.cmbCufWaterIngress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCufWaterIngress.FormattingEnabled = true;
            this.cmbCufWaterIngress.Items.AddRange(new object[] {
            "Select potential for water ingress...",
            "None (0 points)",
            "Design allows for water ingress/travel from above (5 points)"});
            this.cmbCufWaterIngress.Location = new System.Drawing.Point(20, 140);
            this.cmbCufWaterIngress.Name = "cmbCufWaterIngress";
            this.cmbCufWaterIngress.Size = new System.Drawing.Size(439, 28);
            this.cmbCufWaterIngress.TabIndex = 3;
            // 
            // cmbCufEnvironment
            // 
            this.cmbCufEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCufEnvironment.FormattingEnabled = true;
            this.cmbCufEnvironment.Items.AddRange(new object[] {
            "Select external environment...",
            "No sweating (0 points)",
            "Arid and inland (1 point)",
            "All other locations (3 points)",
            "Coastal and marine, cooling tower overspray (5 points)"});
            this.cmbCufEnvironment.Location = new System.Drawing.Point(20, 180);
            this.cmbCufEnvironment.Name = "cmbCufEnvironment";
            this.cmbCufEnvironment.Size = new System.Drawing.Size(439, 28);
            this.cmbCufEnvironment.TabIndex = 4;
            // 
            // cmbCufMaterialType
            // 
            this.cmbCufMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCufMaterialType.FormattingEnabled = true;
            this.cmbCufMaterialType.Items.AddRange(new object[] {
            "Select material type...",
            "Intumescent coating, silica aerogel (0 points)",
            "Cementitious (1 point)",
            "Calcium silicate, mineral fiber (5 points)"});
            this.cmbCufMaterialType.Location = new System.Drawing.Point(20, 220);
            this.cmbCufMaterialType.Name = "cmbCufMaterialType";
            this.cmbCufMaterialType.Size = new System.Drawing.Size(439, 28);
            this.cmbCufMaterialType.TabIndex = 5;
            // 
            // btnCufCalculate
            // 
            this.btnCufCalculate.Location = new System.Drawing.Point(20, 260);
            this.btnCufCalculate.Name = "btnCufCalculate";
            this.btnCufCalculate.Size = new System.Drawing.Size(200, 30);
            this.btnCufCalculate.TabIndex = 6;
            this.btnCufCalculate.Text = "Calculate CUF Likelihood";
            this.btnCufCalculate.UseVisualStyleBackColor = true;
            // 
            // lblCufResult
            // 
            this.lblCufResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCufResult.Location = new System.Drawing.Point(20, 300);
            this.lblCufResult.Name = "lblCufResult";
            this.lblCufResult.Size = new System.Drawing.Size(400, 50);
            this.lblCufResult.TabIndex = 7;
            // 
            // CUIAssessmentForm
            // 
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.tabControl1);
            this.Name = "CUIAssessmentForm";
            this.Text = "API 583/581 CUI Assessment Calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbTemperatureRange;
        private System.Windows.Forms.ComboBox cmbCoatingAge;
        private System.Windows.Forms.ComboBox cmbJacketingCondition;
        private System.Windows.Forms.ComboBox cmbHeatTracing;
        private System.Windows.Forms.ComboBox cmbEnvironment;
        private System.Windows.Forms.ComboBox cmbInsulationType;
        private System.Windows.Forms.ComboBox cmbLineSize;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCarbonGrading;
        private System.Windows.Forms.ComboBox cmbSsTemperatureRange;
        private System.Windows.Forms.ComboBox cmbSsCoatingAge;
        private System.Windows.Forms.ComboBox cmbSsJacketingCondition;
        private System.Windows.Forms.ComboBox cmbSsHeatTracing;
        private System.Windows.Forms.ComboBox cmbSsEnvironment;
        private System.Windows.Forms.ComboBox cmbSsInsulationType;
        private System.Windows.Forms.ComboBox cmbSsLineSize;
        private System.Windows.Forms.Button btnSsCalculate;
        private System.Windows.Forms.Label lblSsResult;
        private System.Windows.Forms.Label lblSsGrading;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbCufTemperature;
        private System.Windows.Forms.ComboBox cmbCufCoatingAge;
        private System.Windows.Forms.ComboBox cmbCufFireproofing;
        private System.Windows.Forms.ComboBox cmbCufWaterIngress;
        private System.Windows.Forms.ComboBox cmbCufEnvironment;
        private System.Windows.Forms.ComboBox cmbCufMaterialType;
        private System.Windows.Forms.Button btnCufCalculate;
        private System.Windows.Forms.Label lblCufResult;
        private System.Windows.Forms.Label lblCufGrading;
    }
}