namespace FERExcelAddIn
{
    partial class MultiPageConverterForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLength;
        private System.Windows.Forms.TabPage tabTemperature;
        private System.Windows.Forms.TabPage tabArea;
        private System.Windows.Forms.TabPage tabVolume;
        private System.Windows.Forms.TabPage tabWeight;
        private System.Windows.Forms.TabPage tabGeometry;

        private System.Windows.Forms.TabPage tabTime;
        private System.Windows.Forms.TextBox txtTimeInput;
        private System.Windows.Forms.TextBox txtTimeResult;
        private System.Windows.Forms.ComboBox cmbTimeFrom;
        private System.Windows.Forms.ComboBox cmbTimeTo;
        private System.Windows.Forms.Button btnConvertTime;
        private System.Windows.Forms.Button btnReverseTime;

        // Length controls
        private System.Windows.Forms.TextBox txtLengthInput;
        private System.Windows.Forms.TextBox txtLengthResult;
        private System.Windows.Forms.ComboBox cmbLengthFrom;
        private System.Windows.Forms.ComboBox cmbLengthTo;
        private System.Windows.Forms.Button btnConvertLength;
        private System.Windows.Forms.Button btnReverseLength;

        // Temperature controls
        private System.Windows.Forms.TextBox txtTempInput;
        private System.Windows.Forms.TextBox txtTempResult;
        private System.Windows.Forms.ComboBox cmbTempFrom;
        private System.Windows.Forms.ComboBox cmbTempTo;
        private System.Windows.Forms.Button btnConvertTemperature;
        private System.Windows.Forms.Button btnReverseTemperature;

        // Area controls
        private System.Windows.Forms.TextBox txtAreaInput;
        private System.Windows.Forms.TextBox txtAreaResult;
        private System.Windows.Forms.ComboBox cmbAreaFrom;
        private System.Windows.Forms.ComboBox cmbAreaTo;
        private System.Windows.Forms.Button btnConvertArea;
        private System.Windows.Forms.Button btnReverseArea;

        // Volume controls
        private System.Windows.Forms.TextBox txtVolumeInput;
        private System.Windows.Forms.TextBox txtVolumeResult;
        private System.Windows.Forms.ComboBox cmbVolumeFrom;
        private System.Windows.Forms.ComboBox cmbVolumeTo;
        private System.Windows.Forms.Button btnConvertVolume;
        private System.Windows.Forms.Button btnReverseVolume;

        // Weight controls
        private System.Windows.Forms.TextBox txtWeightInput;
        private System.Windows.Forms.TextBox txtWeightResult;
        private System.Windows.Forms.ComboBox cmbWeightFrom;
        private System.Windows.Forms.ComboBox cmbWeightTo;
        private System.Windows.Forms.Button btnConvertWeight;
        private System.Windows.Forms.Button btnReverseWeight;

        // Geometry controls
        private System.Windows.Forms.GroupBox groupCircle;
        private System.Windows.Forms.TextBox txtCircleInput;
        private System.Windows.Forms.ComboBox cmbCircleFrom;
        private System.Windows.Forms.Button btnCalculateCircle;
        private System.Windows.Forms.TextBox txtCircleResults;
        private System.Windows.Forms.GroupBox groupTriangle;
        private System.Windows.Forms.TextBox txtTriangleA;
        private System.Windows.Forms.TextBox txtTriangleB;
        private System.Windows.Forms.Button btnCalculateTriangle;
        private System.Windows.Forms.TextBox txtTriangleResults;
        private System.Windows.Forms.GroupBox groupSphere;
        private System.Windows.Forms.TextBox txtSphereInput;
        private System.Windows.Forms.ComboBox cmbSphereFrom;
        private System.Windows.Forms.Button btnCalculateSphere;
        private System.Windows.Forms.TextBox txtSphereResults;
        private System.Windows.Forms.GroupBox groupRectangle;
        private System.Windows.Forms.TextBox txtRectLength;
        private System.Windows.Forms.TextBox txtRectWidth;
        private System.Windows.Forms.TextBox txtRectHeight;
        private System.Windows.Forms.Button btnCalculateRect;
        private System.Windows.Forms.TextBox txtRectResults;
        private System.Windows.Forms.Label lblCircleValue;
        private System.Windows.Forms.Label lblCircleFrom;
        private System.Windows.Forms.Label lblTriangleA;
        private System.Windows.Forms.Label lblTriangleB;
        private System.Windows.Forms.Label lblSphereValue;
        private System.Windows.Forms.Label lblSphereFrom;
        private System.Windows.Forms.Label lblRectLength;
        private System.Windows.Forms.Label lblRectWidth;
        private System.Windows.Forms.Label lblRectHeight;

        private System.Windows.Forms.TabPage tabPressure;
        private System.Windows.Forms.TextBox txtPressureInput;
        private System.Windows.Forms.TextBox txtPressureResult;
        private System.Windows.Forms.ComboBox cmbPressureFrom;
        private System.Windows.Forms.ComboBox cmbPressureTo;
        private System.Windows.Forms.Button btnConvertPressure;
        private System.Windows.Forms.Button btnReversePressure;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLength = new System.Windows.Forms.TabPage();
            this.btnReverseLength = new System.Windows.Forms.Button();
            this.btnConvertLength = new System.Windows.Forms.Button();
            this.cmbLengthTo = new System.Windows.Forms.ComboBox();
            this.cmbLengthFrom = new System.Windows.Forms.ComboBox();
            this.txtLengthResult = new System.Windows.Forms.TextBox();
            this.txtLengthInput = new System.Windows.Forms.TextBox();
            this.tabTemperature = new System.Windows.Forms.TabPage();
            this.btnReverseTemperature = new System.Windows.Forms.Button();
            this.btnConvertTemperature = new System.Windows.Forms.Button();
            this.cmbTempTo = new System.Windows.Forms.ComboBox();
            this.cmbTempFrom = new System.Windows.Forms.ComboBox();
            this.txtTempResult = new System.Windows.Forms.TextBox();
            this.txtTempInput = new System.Windows.Forms.TextBox();
            this.tabArea = new System.Windows.Forms.TabPage();
            this.btnReverseArea = new System.Windows.Forms.Button();
            this.btnConvertArea = new System.Windows.Forms.Button();
            this.cmbAreaTo = new System.Windows.Forms.ComboBox();
            this.cmbAreaFrom = new System.Windows.Forms.ComboBox();
            this.txtAreaResult = new System.Windows.Forms.TextBox();
            this.txtAreaInput = new System.Windows.Forms.TextBox();
            this.tabVolume = new System.Windows.Forms.TabPage();
            this.btnReverseVolume = new System.Windows.Forms.Button();
            this.btnConvertVolume = new System.Windows.Forms.Button();
            this.cmbVolumeTo = new System.Windows.Forms.ComboBox();
            this.cmbVolumeFrom = new System.Windows.Forms.ComboBox();
            this.txtVolumeResult = new System.Windows.Forms.TextBox();
            this.txtVolumeInput = new System.Windows.Forms.TextBox();
            this.tabWeight = new System.Windows.Forms.TabPage();
            this.btnReverseWeight = new System.Windows.Forms.Button();
            this.btnConvertWeight = new System.Windows.Forms.Button();
            this.cmbWeightTo = new System.Windows.Forms.ComboBox();
            this.cmbWeightFrom = new System.Windows.Forms.ComboBox();
            this.txtWeightResult = new System.Windows.Forms.TextBox();
            this.txtWeightInput = new System.Windows.Forms.TextBox();
            this.tabGeometry = new System.Windows.Forms.TabPage();
            this.groupCircle = new System.Windows.Forms.GroupBox();
            this.txtCircleResults = new System.Windows.Forms.TextBox();
            this.btnCalculateCircle = new System.Windows.Forms.Button();
            this.cmbCircleFrom = new System.Windows.Forms.ComboBox();
            this.txtCircleInput = new System.Windows.Forms.TextBox();
            this.lblCircleValue = new System.Windows.Forms.Label();
            this.lblCircleFrom = new System.Windows.Forms.Label();
            this.groupTriangle = new System.Windows.Forms.GroupBox();
            this.txtTriangleResults = new System.Windows.Forms.TextBox();
            this.btnCalculateTriangle = new System.Windows.Forms.Button();
            this.txtTriangleB = new System.Windows.Forms.TextBox();
            this.txtTriangleA = new System.Windows.Forms.TextBox();
            this.lblTriangleA = new System.Windows.Forms.Label();
            this.lblTriangleB = new System.Windows.Forms.Label();
            this.groupSphere = new System.Windows.Forms.GroupBox();
            this.txtSphereResults = new System.Windows.Forms.TextBox();
            this.btnCalculateSphere = new System.Windows.Forms.Button();
            this.cmbSphereFrom = new System.Windows.Forms.ComboBox();
            this.txtSphereInput = new System.Windows.Forms.TextBox();
            this.lblSphereValue = new System.Windows.Forms.Label();
            this.lblSphereFrom = new System.Windows.Forms.Label();
            this.groupRectangle = new System.Windows.Forms.GroupBox();
            this.txtRectResults = new System.Windows.Forms.TextBox();
            this.btnCalculateRect = new System.Windows.Forms.Button();
            this.txtRectHeight = new System.Windows.Forms.TextBox();
            this.txtRectWidth = new System.Windows.Forms.TextBox();
            this.txtRectLength = new System.Windows.Forms.TextBox();
            this.lblRectLength = new System.Windows.Forms.Label();
            this.lblRectWidth = new System.Windows.Forms.Label();
            this.lblRectHeight = new System.Windows.Forms.Label();
            this.tabTime = new System.Windows.Forms.TabPage();
            this.btnReverseTime = new System.Windows.Forms.Button();
            this.btnConvertTime = new System.Windows.Forms.Button();
            this.cmbTimeTo = new System.Windows.Forms.ComboBox();
            this.cmbTimeFrom = new System.Windows.Forms.ComboBox();
            this.txtTimeResult = new System.Windows.Forms.TextBox();
            this.txtTimeInput = new System.Windows.Forms.TextBox();
            this.tabPressure = new System.Windows.Forms.TabPage();
            this.btnReversePressure = new System.Windows.Forms.Button();
            this.btnConvertPressure = new System.Windows.Forms.Button();
            this.cmbPressureTo = new System.Windows.Forms.ComboBox();
            this.cmbPressureFrom = new System.Windows.Forms.ComboBox();
            this.txtPressureResult = new System.Windows.Forms.TextBox();
            this.txtPressureInput = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabLength.SuspendLayout();
            this.tabTemperature.SuspendLayout();
            this.tabArea.SuspendLayout();
            this.tabVolume.SuspendLayout();
            this.tabWeight.SuspendLayout();
            this.tabGeometry.SuspendLayout();
            this.groupCircle.SuspendLayout();
            this.groupTriangle.SuspendLayout();
            this.groupSphere.SuspendLayout();
            this.groupRectangle.SuspendLayout();
            this.tabTime.SuspendLayout();
            this.tabPressure.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLength);
            this.tabControl1.Controls.Add(this.tabTemperature);
            this.tabControl1.Controls.Add(this.tabArea);
            this.tabControl1.Controls.Add(this.tabVolume);
            this.tabControl1.Controls.Add(this.tabWeight);
            this.tabControl1.Controls.Add(this.tabGeometry);
            this.tabControl1.Controls.Add(this.tabTime);
            this.tabControl1.Controls.Add(this.tabPressure);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLength
            // 
            this.tabLength.Controls.Add(this.btnReverseLength);
            this.tabLength.Controls.Add(this.btnConvertLength);
            this.tabLength.Controls.Add(this.cmbLengthTo);
            this.tabLength.Controls.Add(this.cmbLengthFrom);
            this.tabLength.Controls.Add(this.txtLengthResult);
            this.tabLength.Controls.Add(this.txtLengthInput);
            this.tabLength.Location = new System.Drawing.Point(4, 29);
            this.tabLength.Name = "tabLength";
            this.tabLength.Padding = new System.Windows.Forms.Padding(3);
            this.tabLength.Size = new System.Drawing.Size(672, 317);
            this.tabLength.TabIndex = 0;
            this.tabLength.Text = "Length";
            this.tabLength.UseVisualStyleBackColor = true;
            // 
            // btnReverseLength
            // 
            this.btnReverseLength.Location = new System.Drawing.Point(250, 80);
            this.btnReverseLength.Name = "btnReverseLength";
            this.btnReverseLength.Size = new System.Drawing.Size(150, 30);
            this.btnReverseLength.TabIndex = 5;
            this.btnReverseLength.Text = "Reverse";
            this.btnReverseLength.UseVisualStyleBackColor = true;
            // 
            // btnConvertLength
            // 
            this.btnConvertLength.Location = new System.Drawing.Point(250, 40);
            this.btnConvertLength.Name = "btnConvertLength";
            this.btnConvertLength.Size = new System.Drawing.Size(150, 30);
            this.btnConvertLength.TabIndex = 4;
            this.btnConvertLength.Text = "Convert";
            this.btnConvertLength.UseVisualStyleBackColor = true;
            // 
            // cmbLengthTo
            // 
            this.cmbLengthTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLengthTo.FormattingEnabled = true;
            this.cmbLengthTo.Location = new System.Drawing.Point(20, 120);
            this.cmbLengthTo.Name = "cmbLengthTo";
            this.cmbLengthTo.Size = new System.Drawing.Size(200, 28);
            this.cmbLengthTo.TabIndex = 3;
            // 
            // cmbLengthFrom
            // 
            this.cmbLengthFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLengthFrom.FormattingEnabled = true;
            this.cmbLengthFrom.Location = new System.Drawing.Point(20, 80);
            this.cmbLengthFrom.Name = "cmbLengthFrom";
            this.cmbLengthFrom.Size = new System.Drawing.Size(200, 28);
            this.cmbLengthFrom.TabIndex = 2;
            // 
            // txtLengthResult
            // 
            this.txtLengthResult.Location = new System.Drawing.Point(20, 160);
            this.txtLengthResult.Name = "txtLengthResult";
            this.txtLengthResult.ReadOnly = true;
            this.txtLengthResult.Size = new System.Drawing.Size(380, 26);
            this.txtLengthResult.TabIndex = 1;
            // 
            // txtLengthInput
            // 
            this.txtLengthInput.Location = new System.Drawing.Point(20, 40);
            this.txtLengthInput.Name = "txtLengthInput";
            this.txtLengthInput.Size = new System.Drawing.Size(200, 26);
            this.txtLengthInput.TabIndex = 0;
            // 
            // tabTemperature
            // 
            this.tabTemperature.Controls.Add(this.btnReverseTemperature);
            this.tabTemperature.Controls.Add(this.btnConvertTemperature);
            this.tabTemperature.Controls.Add(this.cmbTempTo);
            this.tabTemperature.Controls.Add(this.cmbTempFrom);
            this.tabTemperature.Controls.Add(this.txtTempResult);
            this.tabTemperature.Controls.Add(this.txtTempInput);
            this.tabTemperature.Location = new System.Drawing.Point(4, 29);
            this.tabTemperature.Name = "tabTemperature";
            this.tabTemperature.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemperature.Size = new System.Drawing.Size(672, 317);
            this.tabTemperature.TabIndex = 1;
            this.tabTemperature.Text = "Temperature";
            this.tabTemperature.UseVisualStyleBackColor = true;
            // 
            // btnReverseTemperature
            // 
            this.btnReverseTemperature.Location = new System.Drawing.Point(250, 80);
            this.btnReverseTemperature.Name = "btnReverseTemperature";
            this.btnReverseTemperature.Size = new System.Drawing.Size(150, 30);
            this.btnReverseTemperature.TabIndex = 5;
            this.btnReverseTemperature.Text = "Reverse";
            this.btnReverseTemperature.UseVisualStyleBackColor = true;
            // 
            // btnConvertTemperature
            // 
            this.btnConvertTemperature.Location = new System.Drawing.Point(250, 40);
            this.btnConvertTemperature.Name = "btnConvertTemperature";
            this.btnConvertTemperature.Size = new System.Drawing.Size(150, 30);
            this.btnConvertTemperature.TabIndex = 4;
            this.btnConvertTemperature.Text = "Convert";
            this.btnConvertTemperature.UseVisualStyleBackColor = true;
            // 
            // cmbTempTo
            // 
            this.cmbTempTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTempTo.FormattingEnabled = true;
            this.cmbTempTo.Location = new System.Drawing.Point(20, 120);
            this.cmbTempTo.Name = "cmbTempTo";
            this.cmbTempTo.Size = new System.Drawing.Size(200, 28);
            this.cmbTempTo.TabIndex = 3;
            // 
            // cmbTempFrom
            // 
            this.cmbTempFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTempFrom.FormattingEnabled = true;
            this.cmbTempFrom.Location = new System.Drawing.Point(20, 80);
            this.cmbTempFrom.Name = "cmbTempFrom";
            this.cmbTempFrom.Size = new System.Drawing.Size(200, 28);
            this.cmbTempFrom.TabIndex = 2;
            // 
            // txtTempResult
            // 
            this.txtTempResult.Location = new System.Drawing.Point(20, 160);
            this.txtTempResult.Name = "txtTempResult";
            this.txtTempResult.ReadOnly = true;
            this.txtTempResult.Size = new System.Drawing.Size(380, 26);
            this.txtTempResult.TabIndex = 1;
            // 
            // txtTempInput
            // 
            this.txtTempInput.Location = new System.Drawing.Point(20, 40);
            this.txtTempInput.Name = "txtTempInput";
            this.txtTempInput.Size = new System.Drawing.Size(200, 26);
            this.txtTempInput.TabIndex = 0;
            // 
            // tabArea
            // 
            this.tabArea.Controls.Add(this.btnReverseArea);
            this.tabArea.Controls.Add(this.btnConvertArea);
            this.tabArea.Controls.Add(this.cmbAreaTo);
            this.tabArea.Controls.Add(this.cmbAreaFrom);
            this.tabArea.Controls.Add(this.txtAreaResult);
            this.tabArea.Controls.Add(this.txtAreaInput);
            this.tabArea.Location = new System.Drawing.Point(4, 29);
            this.tabArea.Name = "tabArea";
            this.tabArea.Size = new System.Drawing.Size(672, 317);
            this.tabArea.TabIndex = 2;
            this.tabArea.Text = "Area";
            this.tabArea.UseVisualStyleBackColor = true;
            // 
            // btnReverseArea
            // 
            this.btnReverseArea.Location = new System.Drawing.Point(250, 80);
            this.btnReverseArea.Name = "btnReverseArea";
            this.btnReverseArea.Size = new System.Drawing.Size(150, 30);
            this.btnReverseArea.TabIndex = 5;
            this.btnReverseArea.Text = "Reverse";
            this.btnReverseArea.UseVisualStyleBackColor = true;
            // 
            // btnConvertArea
            // 
            this.btnConvertArea.Location = new System.Drawing.Point(250, 40);
            this.btnConvertArea.Name = "btnConvertArea";
            this.btnConvertArea.Size = new System.Drawing.Size(150, 30);
            this.btnConvertArea.TabIndex = 4;
            this.btnConvertArea.Text = "Convert";
            this.btnConvertArea.UseVisualStyleBackColor = true;
            // 
            // cmbAreaTo
            // 
            this.cmbAreaTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaTo.FormattingEnabled = true;
            this.cmbAreaTo.Location = new System.Drawing.Point(20, 120);
            this.cmbAreaTo.Name = "cmbAreaTo";
            this.cmbAreaTo.Size = new System.Drawing.Size(200, 28);
            this.cmbAreaTo.TabIndex = 3;
            // 
            // cmbAreaFrom
            // 
            this.cmbAreaFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaFrom.FormattingEnabled = true;
            this.cmbAreaFrom.Location = new System.Drawing.Point(20, 80);
            this.cmbAreaFrom.Name = "cmbAreaFrom";
            this.cmbAreaFrom.Size = new System.Drawing.Size(200, 28);
            this.cmbAreaFrom.TabIndex = 2;
            // 
            // txtAreaResult
            // 
            this.txtAreaResult.Location = new System.Drawing.Point(20, 160);
            this.txtAreaResult.Name = "txtAreaResult";
            this.txtAreaResult.ReadOnly = true;
            this.txtAreaResult.Size = new System.Drawing.Size(380, 26);
            this.txtAreaResult.TabIndex = 1;
            // 
            // txtAreaInput
            // 
            this.txtAreaInput.Location = new System.Drawing.Point(20, 40);
            this.txtAreaInput.Name = "txtAreaInput";
            this.txtAreaInput.Size = new System.Drawing.Size(200, 26);
            this.txtAreaInput.TabIndex = 0;
            // 
            // tabVolume
            // 
            this.tabVolume.Controls.Add(this.btnReverseVolume);
            this.tabVolume.Controls.Add(this.btnConvertVolume);
            this.tabVolume.Controls.Add(this.cmbVolumeTo);
            this.tabVolume.Controls.Add(this.cmbVolumeFrom);
            this.tabVolume.Controls.Add(this.txtVolumeResult);
            this.tabVolume.Controls.Add(this.txtVolumeInput);
            this.tabVolume.Location = new System.Drawing.Point(4, 29);
            this.tabVolume.Name = "tabVolume";
            this.tabVolume.Size = new System.Drawing.Size(672, 317);
            this.tabVolume.TabIndex = 3;
            this.tabVolume.Text = "Volume";
            this.tabVolume.UseVisualStyleBackColor = true;
            // 
            // btnReverseVolume
            // 
            this.btnReverseVolume.Location = new System.Drawing.Point(250, 80);
            this.btnReverseVolume.Name = "btnReverseVolume";
            this.btnReverseVolume.Size = new System.Drawing.Size(150, 30);
            this.btnReverseVolume.TabIndex = 5;
            this.btnReverseVolume.Text = "Reverse";
            this.btnReverseVolume.UseVisualStyleBackColor = true;
            // 
            // btnConvertVolume
            // 
            this.btnConvertVolume.Location = new System.Drawing.Point(250, 40);
            this.btnConvertVolume.Name = "btnConvertVolume";
            this.btnConvertVolume.Size = new System.Drawing.Size(150, 30);
            this.btnConvertVolume.TabIndex = 4;
            this.btnConvertVolume.Text = "Convert";
            this.btnConvertVolume.UseVisualStyleBackColor = true;
            // 
            // cmbVolumeTo
            // 
            this.cmbVolumeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVolumeTo.FormattingEnabled = true;
            this.cmbVolumeTo.Location = new System.Drawing.Point(20, 120);
            this.cmbVolumeTo.Name = "cmbVolumeTo";
            this.cmbVolumeTo.Size = new System.Drawing.Size(200, 28);
            this.cmbVolumeTo.TabIndex = 3;
            // 
            // cmbVolumeFrom
            // 
            this.cmbVolumeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVolumeFrom.FormattingEnabled = true;
            this.cmbVolumeFrom.Location = new System.Drawing.Point(20, 80);
            this.cmbVolumeFrom.Name = "cmbVolumeFrom";
            this.cmbVolumeFrom.Size = new System.Drawing.Size(200, 28);
            this.cmbVolumeFrom.TabIndex = 2;
            // 
            // txtVolumeResult
            // 
            this.txtVolumeResult.Location = new System.Drawing.Point(20, 160);
            this.txtVolumeResult.Name = "txtVolumeResult";
            this.txtVolumeResult.ReadOnly = true;
            this.txtVolumeResult.Size = new System.Drawing.Size(380, 26);
            this.txtVolumeResult.TabIndex = 1;
            // 
            // txtVolumeInput
            // 
            this.txtVolumeInput.Location = new System.Drawing.Point(20, 40);
            this.txtVolumeInput.Name = "txtVolumeInput";
            this.txtVolumeInput.Size = new System.Drawing.Size(200, 26);
            this.txtVolumeInput.TabIndex = 0;
            // 
            // tabWeight
            // 
            this.tabWeight.Controls.Add(this.btnReverseWeight);
            this.tabWeight.Controls.Add(this.btnConvertWeight);
            this.tabWeight.Controls.Add(this.cmbWeightTo);
            this.tabWeight.Controls.Add(this.cmbWeightFrom);
            this.tabWeight.Controls.Add(this.txtWeightResult);
            this.tabWeight.Controls.Add(this.txtWeightInput);
            this.tabWeight.Location = new System.Drawing.Point(4, 29);
            this.tabWeight.Name = "tabWeight";
            this.tabWeight.Size = new System.Drawing.Size(672, 317);
            this.tabWeight.TabIndex = 4;
            this.tabWeight.Text = "Weight";
            this.tabWeight.UseVisualStyleBackColor = true;
            // 
            // btnReverseWeight
            // 
            this.btnReverseWeight.Location = new System.Drawing.Point(250, 80);
            this.btnReverseWeight.Name = "btnReverseWeight";
            this.btnReverseWeight.Size = new System.Drawing.Size(150, 30);
            this.btnReverseWeight.TabIndex = 5;
            this.btnReverseWeight.Text = "Reverse";
            this.btnReverseWeight.UseVisualStyleBackColor = true;
            // 
            // btnConvertWeight
            // 
            this.btnConvertWeight.Location = new System.Drawing.Point(250, 40);
            this.btnConvertWeight.Name = "btnConvertWeight";
            this.btnConvertWeight.Size = new System.Drawing.Size(150, 30);
            this.btnConvertWeight.TabIndex = 4;
            this.btnConvertWeight.Text = "Convert";
            this.btnConvertWeight.UseVisualStyleBackColor = true;
            // 
            // cmbWeightTo
            // 
            this.cmbWeightTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeightTo.FormattingEnabled = true;
            this.cmbWeightTo.Location = new System.Drawing.Point(20, 120);
            this.cmbWeightTo.Name = "cmbWeightTo";
            this.cmbWeightTo.Size = new System.Drawing.Size(200, 28);
            this.cmbWeightTo.TabIndex = 3;
            // 
            // cmbWeightFrom
            // 
            this.cmbWeightFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeightFrom.FormattingEnabled = true;
            this.cmbWeightFrom.Location = new System.Drawing.Point(20, 80);
            this.cmbWeightFrom.Name = "cmbWeightFrom";
            this.cmbWeightFrom.Size = new System.Drawing.Size(200, 28);
            this.cmbWeightFrom.TabIndex = 2;
            // 
            // txtWeightResult
            // 
            this.txtWeightResult.Location = new System.Drawing.Point(20, 160);
            this.txtWeightResult.Name = "txtWeightResult";
            this.txtWeightResult.ReadOnly = true;
            this.txtWeightResult.Size = new System.Drawing.Size(380, 26);
            this.txtWeightResult.TabIndex = 1;
            // 
            // txtWeightInput
            // 
            this.txtWeightInput.Location = new System.Drawing.Point(20, 40);
            this.txtWeightInput.Name = "txtWeightInput";
            this.txtWeightInput.Size = new System.Drawing.Size(200, 26);
            this.txtWeightInput.TabIndex = 0;
            // 
            // tabGeometry
            // 
            this.tabGeometry.Controls.Add(this.groupCircle);
            this.tabGeometry.Controls.Add(this.groupTriangle);
            this.tabGeometry.Controls.Add(this.groupSphere);
            this.tabGeometry.Controls.Add(this.groupRectangle);
            this.tabGeometry.Location = new System.Drawing.Point(4, 29);
            this.tabGeometry.Name = "tabGeometry";
            this.tabGeometry.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeometry.Size = new System.Drawing.Size(675, 365);
            this.tabGeometry.TabIndex = 5;
            this.tabGeometry.Text = "Geometry";
            this.tabGeometry.UseVisualStyleBackColor = true;
            // 
            // groupCircle
            // 
            this.groupCircle.Controls.Add(this.txtCircleResults);
            this.groupCircle.Controls.Add(this.btnCalculateCircle);
            this.groupCircle.Controls.Add(this.cmbCircleFrom);
            this.groupCircle.Controls.Add(this.txtCircleInput);
            this.groupCircle.Controls.Add(this.lblCircleValue);
            this.groupCircle.Controls.Add(this.lblCircleFrom);
            this.groupCircle.Location = new System.Drawing.Point(345, 162);
            this.groupCircle.Name = "groupCircle";
            this.groupCircle.Size = new System.Drawing.Size(319, 195);
            this.groupCircle.TabIndex = 0;
            this.groupCircle.TabStop = false;
            this.groupCircle.Text = "Circle Calculations";
            // 
            // txtCircleResults
            // 
            this.txtCircleResults.Location = new System.Drawing.Point(6, 88);
            this.txtCircleResults.Multiline = true;
            this.txtCircleResults.Name = "txtCircleResults";
            this.txtCircleResults.ReadOnly = true;
            this.txtCircleResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCircleResults.Size = new System.Drawing.Size(307, 101);
            this.txtCircleResults.TabIndex = 3;
            // 
            // btnCalculateCircle
            // 
            this.btnCalculateCircle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculateCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCircle.ForeColor = System.Drawing.Color.White;
            this.btnCalculateCircle.Location = new System.Drawing.Point(192, 22);
            this.btnCalculateCircle.Name = "btnCalculateCircle";
            this.btnCalculateCircle.Size = new System.Drawing.Size(121, 60);
            this.btnCalculateCircle.TabIndex = 2;
            this.btnCalculateCircle.Text = "Calculate";
            this.btnCalculateCircle.UseVisualStyleBackColor = false;
            // 
            // cmbCircleFrom
            // 
            this.cmbCircleFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCircleFrom.FormattingEnabled = true;
            this.cmbCircleFrom.Location = new System.Drawing.Point(62, 54);
            this.cmbCircleFrom.Name = "cmbCircleFrom";
            this.cmbCircleFrom.Size = new System.Drawing.Size(124, 28);
            this.cmbCircleFrom.TabIndex = 1;
            // 
            // txtCircleInput
            // 
            this.txtCircleInput.Location = new System.Drawing.Point(62, 22);
            this.txtCircleInput.Name = "txtCircleInput";
            this.txtCircleInput.Size = new System.Drawing.Size(124, 26);
            this.txtCircleInput.TabIndex = 0;
            // 
            // lblCircleValue
            // 
            this.lblCircleValue.AutoSize = true;
            this.lblCircleValue.Location = new System.Drawing.Point(6, 22);
            this.lblCircleValue.Name = "lblCircleValue";
            this.lblCircleValue.Size = new System.Drawing.Size(54, 20);
            this.lblCircleValue.TabIndex = 4;
            this.lblCircleValue.Text = "Value:";
            // 
            // lblCircleFrom
            // 
            this.lblCircleFrom.AutoSize = true;
            this.lblCircleFrom.Location = new System.Drawing.Point(6, 54);
            this.lblCircleFrom.Name = "lblCircleFrom";
            this.lblCircleFrom.Size = new System.Drawing.Size(50, 20);
            this.lblCircleFrom.TabIndex = 5;
            this.lblCircleFrom.Text = "From:";
            // 
            // groupTriangle
            // 
            this.groupTriangle.Controls.Add(this.txtTriangleResults);
            this.groupTriangle.Controls.Add(this.btnCalculateTriangle);
            this.groupTriangle.Controls.Add(this.txtTriangleB);
            this.groupTriangle.Controls.Add(this.txtTriangleA);
            this.groupTriangle.Controls.Add(this.lblTriangleA);
            this.groupTriangle.Controls.Add(this.lblTriangleB);
            this.groupTriangle.Location = new System.Drawing.Point(345, 3);
            this.groupTriangle.Name = "groupTriangle";
            this.groupTriangle.Size = new System.Drawing.Size(319, 153);
            this.groupTriangle.TabIndex = 1;
            this.groupTriangle.TabStop = false;
            this.groupTriangle.Text = "Right Triangle";
            // 
            // txtTriangleResults
            // 
            this.txtTriangleResults.Location = new System.Drawing.Point(6, 88);
            this.txtTriangleResults.Multiline = true;
            this.txtTriangleResults.Name = "txtTriangleResults";
            this.txtTriangleResults.ReadOnly = true;
            this.txtTriangleResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTriangleResults.Size = new System.Drawing.Size(295, 56);
            this.txtTriangleResults.TabIndex = 3;
            // 
            // btnCalculateTriangle
            // 
            this.btnCalculateTriangle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculateTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateTriangle.ForeColor = System.Drawing.Color.White;
            this.btnCalculateTriangle.Location = new System.Drawing.Point(165, 22);
            this.btnCalculateTriangle.Name = "btnCalculateTriangle";
            this.btnCalculateTriangle.Size = new System.Drawing.Size(136, 60);
            this.btnCalculateTriangle.TabIndex = 2;
            this.btnCalculateTriangle.Text = "Calculate";
            this.btnCalculateTriangle.UseVisualStyleBackColor = false;
            // 
            // txtTriangleB
            // 
            this.txtTriangleB.Location = new System.Drawing.Point(6, 54);
            this.txtTriangleB.Name = "txtTriangleB";
            this.txtTriangleB.Size = new System.Drawing.Size(100, 26);
            this.txtTriangleB.TabIndex = 1;
            this.txtTriangleB.Text = "4";
            // 
            // txtTriangleA
            // 
            this.txtTriangleA.Location = new System.Drawing.Point(6, 22);
            this.txtTriangleA.Name = "txtTriangleA";
            this.txtTriangleA.Size = new System.Drawing.Size(100, 26);
            this.txtTriangleA.TabIndex = 0;
            this.txtTriangleA.Text = "3";
            // 
            // lblTriangleA
            // 
            this.lblTriangleA.AutoSize = true;
            this.lblTriangleA.Location = new System.Drawing.Point(6, 22);
            this.lblTriangleA.Name = "lblTriangleA";
            this.lblTriangleA.Size = new System.Drawing.Size(60, 20);
            this.lblTriangleA.TabIndex = 4;
            this.lblTriangleA.Text = "Side A:";
            // 
            // lblTriangleB
            // 
            this.lblTriangleB.AutoSize = true;
            this.lblTriangleB.Location = new System.Drawing.Point(6, 54);
            this.lblTriangleB.Name = "lblTriangleB";
            this.lblTriangleB.Size = new System.Drawing.Size(60, 20);
            this.lblTriangleB.TabIndex = 5;
            this.lblTriangleB.Text = "Side B:";
            // 
            // groupSphere
            // 
            this.groupSphere.Controls.Add(this.txtSphereResults);
            this.groupSphere.Controls.Add(this.btnCalculateSphere);
            this.groupSphere.Controls.Add(this.cmbSphereFrom);
            this.groupSphere.Controls.Add(this.txtSphereInput);
            this.groupSphere.Controls.Add(this.lblSphereValue);
            this.groupSphere.Controls.Add(this.lblSphereFrom);
            this.groupSphere.Location = new System.Drawing.Point(6, 162);
            this.groupSphere.Name = "groupSphere";
            this.groupSphere.Size = new System.Drawing.Size(325, 195);
            this.groupSphere.TabIndex = 2;
            this.groupSphere.TabStop = false;
            this.groupSphere.Text = "Sphere Calculations";
            // 
            // txtSphereResults
            // 
            this.txtSphereResults.Location = new System.Drawing.Point(6, 88);
            this.txtSphereResults.Multiline = true;
            this.txtSphereResults.Name = "txtSphereResults";
            this.txtSphereResults.ReadOnly = true;
            this.txtSphereResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSphereResults.Size = new System.Drawing.Size(307, 101);
            this.txtSphereResults.TabIndex = 3;
            // 
            // btnCalculateSphere
            // 
            this.btnCalculateSphere.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculateSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateSphere.ForeColor = System.Drawing.Color.White;
            this.btnCalculateSphere.Location = new System.Drawing.Point(192, 22);
            this.btnCalculateSphere.Name = "btnCalculateSphere";
            this.btnCalculateSphere.Size = new System.Drawing.Size(121, 60);
            this.btnCalculateSphere.TabIndex = 2;
            this.btnCalculateSphere.Text = "Calculate";
            this.btnCalculateSphere.UseVisualStyleBackColor = false;
            // 
            // cmbSphereFrom
            // 
            this.cmbSphereFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSphereFrom.FormattingEnabled = true;
            this.cmbSphereFrom.Location = new System.Drawing.Point(6, 54);
            this.cmbSphereFrom.Name = "cmbSphereFrom";
            this.cmbSphereFrom.Size = new System.Drawing.Size(180, 28);
            this.cmbSphereFrom.TabIndex = 1;
            // 
            // txtSphereInput
            // 
            this.txtSphereInput.Location = new System.Drawing.Point(6, 22);
            this.txtSphereInput.Name = "txtSphereInput";
            this.txtSphereInput.Size = new System.Drawing.Size(180, 26);
            this.txtSphereInput.TabIndex = 0;
            // 
            // lblSphereValue
            // 
            this.lblSphereValue.AutoSize = true;
            this.lblSphereValue.Location = new System.Drawing.Point(6, 22);
            this.lblSphereValue.Name = "lblSphereValue";
            this.lblSphereValue.Size = new System.Drawing.Size(54, 20);
            this.lblSphereValue.TabIndex = 4;
            this.lblSphereValue.Text = "Value:";
            // 
            // lblSphereFrom
            // 
            this.lblSphereFrom.AutoSize = true;
            this.lblSphereFrom.Location = new System.Drawing.Point(6, 54);
            this.lblSphereFrom.Name = "lblSphereFrom";
            this.lblSphereFrom.Size = new System.Drawing.Size(50, 20);
            this.lblSphereFrom.TabIndex = 5;
            this.lblSphereFrom.Text = "From:";
            // 
            // groupRectangle
            // 
            this.groupRectangle.Controls.Add(this.txtRectResults);
            this.groupRectangle.Controls.Add(this.btnCalculateRect);
            this.groupRectangle.Controls.Add(this.txtRectHeight);
            this.groupRectangle.Controls.Add(this.txtRectWidth);
            this.groupRectangle.Controls.Add(this.txtRectLength);
            this.groupRectangle.Controls.Add(this.lblRectLength);
            this.groupRectangle.Controls.Add(this.lblRectWidth);
            this.groupRectangle.Controls.Add(this.lblRectHeight);
            this.groupRectangle.Location = new System.Drawing.Point(12, 6);
            this.groupRectangle.Name = "groupRectangle";
            this.groupRectangle.Size = new System.Drawing.Size(319, 150);
            this.groupRectangle.TabIndex = 3;
            this.groupRectangle.TabStop = false;
            this.groupRectangle.Text = "Rectangle/Box";
            // 
            // txtRectResults
            // 
            this.txtRectResults.Location = new System.Drawing.Point(6, 88);
            this.txtRectResults.Multiline = true;
            this.txtRectResults.Name = "txtRectResults";
            this.txtRectResults.ReadOnly = true;
            this.txtRectResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRectResults.Size = new System.Drawing.Size(295, 56);
            this.txtRectResults.TabIndex = 4;
            // 
            // btnCalculateRect
            // 
            this.btnCalculateRect.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCalculateRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateRect.ForeColor = System.Drawing.Color.White;
            this.btnCalculateRect.Location = new System.Drawing.Point(165, 22);
            this.btnCalculateRect.Name = "btnCalculateRect";
            this.btnCalculateRect.Size = new System.Drawing.Size(136, 60);
            this.btnCalculateRect.TabIndex = 3;
            this.btnCalculateRect.Text = "Calculate";
            this.btnCalculateRect.UseVisualStyleBackColor = false;
            // 
            // txtRectHeight
            // 
            this.txtRectHeight.Location = new System.Drawing.Point(6, 86);
            this.txtRectHeight.Name = "txtRectHeight";
            this.txtRectHeight.Size = new System.Drawing.Size(60, 26);
            this.txtRectHeight.TabIndex = 2;
            // 
            // txtRectWidth
            // 
            this.txtRectWidth.Location = new System.Drawing.Point(72, 22);
            this.txtRectWidth.Name = "txtRectWidth";
            this.txtRectWidth.Size = new System.Drawing.Size(60, 26);
            this.txtRectWidth.TabIndex = 1;
            // 
            // txtRectLength
            // 
            this.txtRectLength.Location = new System.Drawing.Point(6, 22);
            this.txtRectLength.Name = "txtRectLength";
            this.txtRectLength.Size = new System.Drawing.Size(60, 26);
            this.txtRectLength.TabIndex = 0;
            // 
            // lblRectLength
            // 
            this.lblRectLength.AutoSize = true;
            this.lblRectLength.Location = new System.Drawing.Point(6, 22);
            this.lblRectLength.Name = "lblRectLength";
            this.lblRectLength.Size = new System.Drawing.Size(63, 20);
            this.lblRectLength.TabIndex = 5;
            this.lblRectLength.Text = "Length:";
            // 
            // lblRectWidth
            // 
            this.lblRectWidth.AutoSize = true;
            this.lblRectWidth.Location = new System.Drawing.Point(72, 22);
            this.lblRectWidth.Name = "lblRectWidth";
            this.lblRectWidth.Size = new System.Drawing.Size(54, 20);
            this.lblRectWidth.TabIndex = 6;
            this.lblRectWidth.Text = "Width:";
            // 
            // lblRectHeight
            // 
            this.lblRectHeight.AutoSize = true;
            this.lblRectHeight.Location = new System.Drawing.Point(6, 54);
            this.lblRectHeight.Name = "lblRectHeight";
            this.lblRectHeight.Size = new System.Drawing.Size(116, 20);
            this.lblRectHeight.TabIndex = 7;
            this.lblRectHeight.Text = "Height x Width:";
            // 
            // tabTime
            // 
            this.tabTime.Controls.Add(this.btnReverseTime);
            this.tabTime.Controls.Add(this.btnConvertTime);
            this.tabTime.Controls.Add(this.cmbTimeTo);
            this.tabTime.Controls.Add(this.cmbTimeFrom);
            this.tabTime.Controls.Add(this.txtTimeResult);
            this.tabTime.Controls.Add(this.txtTimeInput);
            this.tabTime.Location = new System.Drawing.Point(4, 29);
            this.tabTime.Name = "tabTime";
            this.tabTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabTime.Size = new System.Drawing.Size(672, 317);
            this.tabTime.TabIndex = 6;
            this.tabTime.Text = "Time";
            this.tabTime.UseVisualStyleBackColor = true;
            // 
            // btnReverseTime
            // 
            this.btnReverseTime.Location = new System.Drawing.Point(250, 80);
            this.btnReverseTime.Name = "btnReverseTime";
            this.btnReverseTime.Size = new System.Drawing.Size(150, 30);
            this.btnReverseTime.TabIndex = 5;
            this.btnReverseTime.Text = "Reverse";
            this.btnReverseTime.UseVisualStyleBackColor = true;
            // 
            // btnConvertTime
            // 
            this.btnConvertTime.Location = new System.Drawing.Point(250, 40);
            this.btnConvertTime.Name = "btnConvertTime";
            this.btnConvertTime.Size = new System.Drawing.Size(150, 30);
            this.btnConvertTime.TabIndex = 4;
            this.btnConvertTime.Text = "Convert";
            this.btnConvertTime.UseVisualStyleBackColor = true;
            // 
            // cmbTimeTo
            // 
            this.cmbTimeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeTo.FormattingEnabled = true;
            this.cmbTimeTo.Location = new System.Drawing.Point(20, 120);
            this.cmbTimeTo.Name = "cmbTimeTo";
            this.cmbTimeTo.Size = new System.Drawing.Size(200, 28);
            this.cmbTimeTo.TabIndex = 3;
            // 
            // cmbTimeFrom
            // 
            this.cmbTimeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeFrom.FormattingEnabled = true;
            this.cmbTimeFrom.Location = new System.Drawing.Point(20, 80);
            this.cmbTimeFrom.Name = "cmbTimeFrom";
            this.cmbTimeFrom.Size = new System.Drawing.Size(200, 28);
            this.cmbTimeFrom.TabIndex = 2;
            // 
            // txtTimeResult
            // 
            this.txtTimeResult.Location = new System.Drawing.Point(20, 160);
            this.txtTimeResult.Name = "txtTimeResult";
            this.txtTimeResult.ReadOnly = true;
            this.txtTimeResult.Size = new System.Drawing.Size(380, 26);
            this.txtTimeResult.TabIndex = 1;
            // 
            // txtTimeInput
            // 
            this.txtTimeInput.Location = new System.Drawing.Point(20, 40);
            this.txtTimeInput.Name = "txtTimeInput";
            this.txtTimeInput.Size = new System.Drawing.Size(200, 26);
            this.txtTimeInput.TabIndex = 0;
            // 
            // tabPressure
            // 
            this.tabPressure.Controls.Add(this.btnReversePressure);
            this.tabPressure.Controls.Add(this.btnConvertPressure);
            this.tabPressure.Controls.Add(this.cmbPressureTo);
            this.tabPressure.Controls.Add(this.cmbPressureFrom);
            this.tabPressure.Controls.Add(this.txtPressureResult);
            this.tabPressure.Controls.Add(this.txtPressureInput);
            this.tabPressure.Location = new System.Drawing.Point(4, 29);
            this.tabPressure.Name = "tabPressure";
            this.tabPressure.Padding = new System.Windows.Forms.Padding(3);
            this.tabPressure.Size = new System.Drawing.Size(672, 317);
            this.tabPressure.TabIndex = 7;
            this.tabPressure.Text = "Pressure";
            this.tabPressure.UseVisualStyleBackColor = true;
            // 
            // btnReversePressure
            // 
            this.btnReversePressure.Location = new System.Drawing.Point(250, 80);
            this.btnReversePressure.Name = "btnReversePressure";
            this.btnReversePressure.Size = new System.Drawing.Size(150, 30);
            this.btnReversePressure.TabIndex = 5;
            this.btnReversePressure.Text = "Reverse";
            this.btnReversePressure.UseVisualStyleBackColor = true;
            // 
            // btnConvertPressure
            // 
            this.btnConvertPressure.Location = new System.Drawing.Point(250, 40);
            this.btnConvertPressure.Name = "btnConvertPressure";
            this.btnConvertPressure.Size = new System.Drawing.Size(150, 30);
            this.btnConvertPressure.TabIndex = 4;
            this.btnConvertPressure.Text = "Convert";
            this.btnConvertPressure.UseVisualStyleBackColor = true;
            // 
            // cmbPressureTo
            // 
            this.cmbPressureTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPressureTo.FormattingEnabled = true;
            this.cmbPressureTo.Location = new System.Drawing.Point(20, 120);
            this.cmbPressureTo.Name = "cmbPressureTo";
            this.cmbPressureTo.Size = new System.Drawing.Size(200, 28);
            this.cmbPressureTo.TabIndex = 3;
            // 
            // cmbPressureFrom
            // 
            this.cmbPressureFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPressureFrom.FormattingEnabled = true;
            this.cmbPressureFrom.Location = new System.Drawing.Point(20, 80);
            this.cmbPressureFrom.Name = "cmbPressureFrom";
            this.cmbPressureFrom.Size = new System.Drawing.Size(200, 28);
            this.cmbPressureFrom.TabIndex = 2;
            // 
            // txtPressureResult
            // 
            this.txtPressureResult.Location = new System.Drawing.Point(20, 160);
            this.txtPressureResult.Name = "txtPressureResult";
            this.txtPressureResult.ReadOnly = true;
            this.txtPressureResult.Size = new System.Drawing.Size(380, 26);
            this.txtPressureResult.TabIndex = 1;
            // 
            // txtPressureInput
            // 
            this.txtPressureInput.Location = new System.Drawing.Point(20, 40);
            this.txtPressureInput.Name = "txtPressureInput";
            this.txtPressureInput.Size = new System.Drawing.Size(200, 26);
            this.txtPressureInput.TabIndex = 0;
            // 
            // MultiPageConverterForm
            // 
            this.ClientSize = new System.Drawing.Size(683, 398);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultiPageConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Converter";
            this.tabControl1.ResumeLayout(false);
            this.tabLength.ResumeLayout(false);
            this.tabLength.PerformLayout();
            this.tabTemperature.ResumeLayout(false);
            this.tabTemperature.PerformLayout();
            this.tabArea.ResumeLayout(false);
            this.tabArea.PerformLayout();
            this.tabVolume.ResumeLayout(false);
            this.tabVolume.PerformLayout();
            this.tabWeight.ResumeLayout(false);
            this.tabWeight.PerformLayout();
            this.tabGeometry.ResumeLayout(false);
            this.groupCircle.ResumeLayout(false);
            this.groupCircle.PerformLayout();
            this.groupTriangle.ResumeLayout(false);
            this.groupTriangle.PerformLayout();
            this.groupSphere.ResumeLayout(false);
            this.groupSphere.PerformLayout();
            this.groupRectangle.ResumeLayout(false);
            this.groupRectangle.PerformLayout();
            this.tabTime.ResumeLayout(false);
            this.tabTime.PerformLayout();
            this.tabPressure.ResumeLayout(false);
            this.tabPressure.PerformLayout();
            this.ResumeLayout(false);

        }


    }
}