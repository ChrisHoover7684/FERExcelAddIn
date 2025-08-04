namespace FERExcelAddIn
{
    partial class NominalThicknessForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbPipeSize;
        private System.Windows.Forms.ComboBox cmbSchedule;
        private System.Windows.Forms.TextBox txtThickness;
        private System.Windows.Forms.Label lblPipeSize;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLowerMil;
        private System.Windows.Forms.Label lblUpperMil;
        private System.Windows.Forms.TextBox txtLowerMil;
        private System.Windows.Forms.TextBox txtUpperMil;
        private System.Windows.Forms.Label lblOD;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtOD;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnShowAllData;

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPipeSize = new System.Windows.Forms.Label();
            this.cmbPipeSize = new System.Windows.Forms.ComboBox();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.cmbSchedule = new System.Windows.Forms.ComboBox();
            this.lblThickness = new System.Windows.Forms.Label();
            this.txtThickness = new System.Windows.Forms.TextBox();
            this.lblOD = new System.Windows.Forms.Label();
            this.txtOD = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblLowerMil = new System.Windows.Forms.Label();
            this.txtLowerMil = new System.Windows.Forms.TextBox();
            this.lblUpperMil = new System.Windows.Forms.Label();
            this.txtUpperMil = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowAllData = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.lblPipeSize, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPipeSize, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSchedule, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbSchedule, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblThickness, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtThickness, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblOD, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtOD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblLowerMil, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtLowerMil, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblUpperMil, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtUpperMil, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnShowAllData, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 507);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPipeSize
            // 
            this.lblPipeSize.AutoSize = true;
            this.lblPipeSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPipeSize.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblPipeSize.Location = new System.Drawing.Point(9, 6);
            this.lblPipeSize.Name = "lblPipeSize";
            this.lblPipeSize.Size = new System.Drawing.Size(278, 44);
            this.lblPipeSize.TabIndex = 0;
            this.lblPipeSize.Text = "Pipe Size:";
            this.lblPipeSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPipeSize
            // 
            this.cmbPipeSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPipeSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPipeSize.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbPipeSize.FormattingEnabled = true;
            this.cmbPipeSize.Location = new System.Drawing.Point(293, 10);
            this.cmbPipeSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbPipeSize.Name = "cmbPipeSize";
            this.cmbPipeSize.Size = new System.Drawing.Size(420, 36);
            this.cmbPipeSize.TabIndex = 1;
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSchedule.Location = new System.Drawing.Point(9, 50);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(278, 44);
            this.lblSchedule.TabIndex = 2;
            this.lblSchedule.Text = "Schedule:";
            this.lblSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbSchedule
            // 
            this.cmbSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbSchedule.FormattingEnabled = true;
            this.cmbSchedule.Location = new System.Drawing.Point(293, 54);
            this.cmbSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSchedule.Name = "cmbSchedule";
            this.cmbSchedule.Size = new System.Drawing.Size(420, 36);
            this.cmbSchedule.TabIndex = 3;
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThickness.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblThickness.Location = new System.Drawing.Point(9, 150);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(278, 44);
            this.lblThickness.TabIndex = 5;
            this.lblThickness.Text = "Nominal Thickness (in):";
            this.lblThickness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtThickness
            // 
            this.txtThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThickness.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtThickness.Location = new System.Drawing.Point(293, 154);
            this.txtThickness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThickness.Name = "txtThickness";
            this.txtThickness.ReadOnly = true;
            this.txtThickness.Size = new System.Drawing.Size(420, 33);
            this.txtThickness.TabIndex = 6;
            this.txtThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOD
            // 
            this.lblOD.AutoSize = true;
            this.lblOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblOD.Location = new System.Drawing.Point(9, 194);
            this.lblOD.Name = "lblOD";
            this.lblOD.Size = new System.Drawing.Size(278, 44);
            this.lblOD.TabIndex = 7;
            this.lblOD.Text = "Outside Diameter (in):";
            this.lblOD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOD
            // 
            this.txtOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOD.Location = new System.Drawing.Point(293, 198);
            this.txtOD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOD.Name = "txtOD";
            this.txtOD.ReadOnly = true;
            this.txtOD.Size = new System.Drawing.Size(420, 33);
            this.txtOD.TabIndex = 8;
            this.txtOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblID.Location = new System.Drawing.Point(9, 238);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(278, 44);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "Inside Diameter (in):";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtID.Location = new System.Drawing.Point(293, 242);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(420, 33);
            this.txtID.TabIndex = 10;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLowerMil
            // 
            this.lblLowerMil.AutoSize = true;
            this.lblLowerMil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowerMil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLowerMil.Location = new System.Drawing.Point(9, 282);
            this.lblLowerMil.Name = "lblLowerMil";
            this.lblLowerMil.Size = new System.Drawing.Size(278, 44);
            this.lblLowerMil.TabIndex = 11;
            this.lblLowerMil.Text = "Lower Limit (-12.5%) (in):";
            this.lblLowerMil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLowerMil
            // 
            this.txtLowerMil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLowerMil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLowerMil.Location = new System.Drawing.Point(293, 286);
            this.txtLowerMil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLowerMil.Name = "txtLowerMil";
            this.txtLowerMil.ReadOnly = true;
            this.txtLowerMil.Size = new System.Drawing.Size(420, 33);
            this.txtLowerMil.TabIndex = 12;
            this.txtLowerMil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblUpperMil
            // 
            this.lblUpperMil.AutoSize = true;
            this.lblUpperMil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUpperMil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblUpperMil.Location = new System.Drawing.Point(9, 326);
            this.lblUpperMil.Name = "lblUpperMil";
            this.lblUpperMil.Size = new System.Drawing.Size(278, 44);
            this.lblUpperMil.TabIndex = 13;
            this.lblUpperMil.Text = "Upper Limit (+12.5%) (in):";
            this.lblUpperMil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUpperMil
            // 
            this.txtUpperMil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUpperMil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUpperMil.Location = new System.Drawing.Point(293, 330);
            this.txtUpperMil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUpperMil.Name = "txtUpperMil";
            this.txtUpperMil.ReadOnly = true;
            this.txtUpperMil.Size = new System.Drawing.Size(420, 33);
            this.txtUpperMil.TabIndex = 14;
            this.txtUpperMil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(577, 374);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 36);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowAllData
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnShowAllData, 2);
            this.btnShowAllData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowAllData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShowAllData.Location = new System.Drawing.Point(9, 418);
            this.btnShowAllData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllData.Name = "btnShowAllData";
            this.btnShowAllData.Size = new System.Drawing.Size(704, 79);
            this.btnShowAllData.TabIndex = 16;
            this.btnShowAllData.Text = "Show All Data";
            this.btnShowAllData.UseVisualStyleBackColor = true;
            // 
            // NominalThicknessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 531);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(504, 486);
            this.Name = "NominalThicknessForm";
            this.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nominal Pipe Size Lookup";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}