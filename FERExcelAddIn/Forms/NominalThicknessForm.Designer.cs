namespace FERExcelAddIn
{
    partial class NominalThicknessForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbPipeSize;
        private System.Windows.Forms.ComboBox cmbSchedule;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.TextBox txtThickness;
        private System.Windows.Forms.Label lblPipeSize;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Button btnClose;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NominalThicknessForm));
            this.cmbPipeSize = new System.Windows.Forms.ComboBox();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.lblPipeSize = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblThickness = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLowerMil = new System.Windows.Forms.Label();
            this.lblUpperMil = new System.Windows.Forms.Label();
            this.txtLowerMil = new System.Windows.Forms.TextBox();
            this.txtUpperMil = new System.Windows.Forms.TextBox();
            this.lblOD = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbPipeSize
            // 
            this.cmbPipeSize.FormattingEnabled = true;
            this.cmbPipeSize.Location = new System.Drawing.Point(198, 20);
            this.cmbPipeSize.Name = "cmbPipeSize";
            this.cmbPipeSize.Size = new System.Drawing.Size(76, 28);
            this.cmbPipeSize.TabIndex = 1;
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(198, 56);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(76, 28);
            this.cmbSchedule.TabIndex = 3;
            // 
            // btnLookup
            // 
            this.btnLookup.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookup.Location = new System.Drawing.Point(45, 90);
            this.btnLookup.Margin = new System.Windows.Forms.Padding(0);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(229, 33);
            this.btnLookup.TabIndex = 4;
            this.btnLookup.Text = "Lookup Thickness";
            this.btnLookup.UseVisualStyleBackColor = false;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // txtThickness
            // 
            this.txtThickness.Location = new System.Drawing.Point(198, 133);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.ReadOnly = true;
            this.txtThickness.Size = new System.Drawing.Size(76, 26);
            this.txtThickness.TabIndex = 6;
            // 
            // lblPipeSize
            // 
            this.lblPipeSize.AutoSize = true;
            this.lblPipeSize.Location = new System.Drawing.Point(120, 28);
            this.lblPipeSize.Name = "lblPipeSize";
            this.lblPipeSize.Size = new System.Drawing.Size(79, 20);
            this.lblPipeSize.TabIndex = 0;
            this.lblPipeSize.Text = "Pipe Size:";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(119, 64);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(80, 20);
            this.lblSchedule.TabIndex = 2;
            this.lblSchedule.Text = "Schedule:";
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.Location = new System.Drawing.Point(54, 139);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(145, 20);
            this.lblThickness.TabIndex = 5;
            this.lblThickness.Text = "Nominal Thickness:";
            this.lblThickness.Click += new System.EventHandler(this.lblThickness_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(215, 335);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLowerMil
            // 
            this.lblLowerMil.AutoSize = true;
            this.lblLowerMil.Location = new System.Drawing.Point(46, 245);
            this.lblLowerMil.Name = "lblLowerMil";
            this.lblLowerMil.Size = new System.Drawing.Size(153, 20);
            this.lblLowerMil.TabIndex = 8;
            this.lblLowerMil.Text = "Lower Limit (-12.5%)";
            this.lblLowerMil.Click += new System.EventHandler(this.lblLowerMil_Click);
            // 
            // lblUpperMil
            // 
            this.lblUpperMil.AutoSize = true;
            this.lblUpperMil.Location = new System.Drawing.Point(41, 277);
            this.lblUpperMil.Name = "lblUpperMil";
            this.lblUpperMil.Size = new System.Drawing.Size(158, 20);
            this.lblUpperMil.TabIndex = 9;
            this.lblUpperMil.Text = "Upper Limit (+12.5%)";
            // 
            // txtLowerMil
            // 
            this.txtLowerMil.Location = new System.Drawing.Point(198, 239);
            this.txtLowerMil.Name = "txtLowerMil";
            this.txtLowerMil.ReadOnly = true;
            this.txtLowerMil.Size = new System.Drawing.Size(76, 26);
            this.txtLowerMil.TabIndex = 10;
            // 
            // txtUpperMil
            // 
            this.txtUpperMil.Location = new System.Drawing.Point(198, 271);
            this.txtUpperMil.Name = "txtUpperMil";
            this.txtUpperMil.ReadOnly = true;
            this.txtUpperMil.Size = new System.Drawing.Size(76, 26);
            this.txtUpperMil.TabIndex = 11;
            // 
            // lblOD
            // 
            this.lblOD.AutoSize = true;
            this.lblOD.Location = new System.Drawing.Point(62, 174);
            this.lblOD.Name = "lblOD";
            this.lblOD.Size = new System.Drawing.Size(137, 20);
            this.lblOD.TabIndex = 12;
            this.lblOD.Text = "Outside Diameter:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(74, 206);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(125, 20);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "Inside Diameter:";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // txtOD
            // 
            this.txtOD.Location = new System.Drawing.Point(198, 168);
            this.txtOD.Name = "txtOD";
            this.txtOD.ReadOnly = true;
            this.txtOD.Size = new System.Drawing.Size(76, 26);
            this.txtOD.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(198, 200);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(76, 26);
            this.txtID.TabIndex = 13;
            // 
            // NominalThicknessForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::FERExcelAddIn.Properties.Resources.FER_Logo_paint_dark_grey;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(299, 367);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtOD);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblOD);
            this.Controls.Add(this.txtUpperMil);
            this.Controls.Add(this.txtLowerMil);
            this.Controls.Add(this.lblUpperMil);
            this.Controls.Add(this.lblLowerMil);
            this.Controls.Add(this.lblPipeSize);
            this.Controls.Add(this.cmbPipeSize);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.cmbSchedule);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.lblThickness);
            this.Controls.Add(this.txtThickness);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NominalThicknessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nominal Pipe Size Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblLowerMil;
        private System.Windows.Forms.Label lblUpperMil;
        private System.Windows.Forms.TextBox txtLowerMil;
        private System.Windows.Forms.TextBox txtUpperMil;
        private System.Windows.Forms.Label lblOD;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.TextBox txtID;
    }
}