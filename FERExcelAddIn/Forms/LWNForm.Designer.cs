namespace FERExcelAddIn
{
    partial class LWNForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LWNForm));
            this.lblSize = new System.Windows.Forms.Label();
            this.cmbLWNSize = new System.Windows.Forms.ComboBox();
            this.lblLWNScehule = new System.Windows.Forms.Label();
            this.cmbLWNSchedule = new System.Windows.Forms.ComboBox();
            this.txtLWNID = new System.Windows.Forms.TextBox();
            this.txtLWNOD = new System.Windows.Forms.TextBox();
            this.txtLWNThickness = new System.Windows.Forms.TextBox();
            this.lblLWNID = new System.Windows.Forms.Label();
            this.lblLWNOD = new System.Windows.Forms.Label();
            this.lblLWNThickness = new System.Windows.Forms.Label();
            this.lblLWNLowerMil = new System.Windows.Forms.Label();
            this.txtLWNLowerMil = new System.Windows.Forms.TextBox();
            this.lblLWNUpperMil = new System.Windows.Forms.Label();
            this.txtLWNUpperMil = new System.Windows.Forms.TextBox();
            this.btnLWNLookupThickness = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(12, 27);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 20);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            // 
            // cmbLWNSize
            // 
            this.cmbLWNSize.FormattingEnabled = true;
            this.cmbLWNSize.Location = new System.Drawing.Point(58, 24);
            this.cmbLWNSize.Name = "cmbLWNSize";
            this.cmbLWNSize.Size = new System.Drawing.Size(72, 28);
            this.cmbLWNSize.TabIndex = 1;
            // 
            // lblLWNScehule
            // 
            this.lblLWNScehule.AutoSize = true;
            this.lblLWNScehule.Location = new System.Drawing.Point(155, 27);
            this.lblLWNScehule.Name = "lblLWNScehule";
            this.lblLWNScehule.Size = new System.Drawing.Size(76, 20);
            this.lblLWNScehule.TabIndex = 2;
            this.lblLWNScehule.Text = "Schedule";
            // 
            // cmbLWNSchedule
            // 
            this.cmbLWNSchedule.FormattingEnabled = true;
            this.cmbLWNSchedule.Location = new System.Drawing.Point(237, 24);
            this.cmbLWNSchedule.Name = "cmbLWNSchedule";
            this.cmbLWNSchedule.Size = new System.Drawing.Size(122, 28);
            this.cmbLWNSchedule.TabIndex = 3;
            // 
            // txtLWNID
            // 
            this.txtLWNID.Location = new System.Drawing.Point(222, 180);
            this.txtLWNID.Name = "txtLWNID";
            this.txtLWNID.ReadOnly = true;
            this.txtLWNID.Size = new System.Drawing.Size(100, 26);
            this.txtLWNID.TabIndex = 4;
            // 
            // txtLWNOD
            // 
            this.txtLWNOD.Location = new System.Drawing.Point(222, 150);
            this.txtLWNOD.Name = "txtLWNOD";
            this.txtLWNOD.ReadOnly = true;
            this.txtLWNOD.Size = new System.Drawing.Size(100, 26);
            this.txtLWNOD.TabIndex = 4;
            // 
            // txtLWNThickness
            // 
            this.txtLWNThickness.Location = new System.Drawing.Point(222, 118);
            this.txtLWNThickness.Name = "txtLWNThickness";
            this.txtLWNThickness.ReadOnly = true;
            this.txtLWNThickness.Size = new System.Drawing.Size(100, 26);
            this.txtLWNThickness.TabIndex = 4;
            // 
            // lblLWNID
            // 
            this.lblLWNID.AutoSize = true;
            this.lblLWNID.Location = new System.Drawing.Point(57, 180);
            this.lblLWNID.Name = "lblLWNID";
            this.lblLWNID.Size = new System.Drawing.Size(121, 20);
            this.lblLWNID.TabIndex = 0;
            this.lblLWNID.Text = "Inside Diameter";
            // 
            // lblLWNOD
            // 
            this.lblLWNOD.AutoSize = true;
            this.lblLWNOD.Location = new System.Drawing.Point(57, 150);
            this.lblLWNOD.Name = "lblLWNOD";
            this.lblLWNOD.Size = new System.Drawing.Size(133, 20);
            this.lblLWNOD.TabIndex = 0;
            this.lblLWNOD.Text = "Outside Diameter";
            // 
            // lblLWNThickness
            // 
            this.lblLWNThickness.AutoSize = true;
            this.lblLWNThickness.Location = new System.Drawing.Point(57, 118);
            this.lblLWNThickness.Name = "lblLWNThickness";
            this.lblLWNThickness.Size = new System.Drawing.Size(141, 20);
            this.lblLWNThickness.TabIndex = 0;
            this.lblLWNThickness.Text = "Nominal Thickness";
            // 
            // lblLWNLowerMil
            // 
            this.lblLWNLowerMil.AutoSize = true;
            this.lblLWNLowerMil.Location = new System.Drawing.Point(57, 213);
            this.lblLWNLowerMil.Name = "lblLWNLowerMil";
            this.lblLWNLowerMil.Size = new System.Drawing.Size(153, 20);
            this.lblLWNLowerMil.TabIndex = 0;
            this.lblLWNLowerMil.Text = "Lower Limit (-12.5%)";
            // 
            // txtLWNLowerMil
            // 
            this.txtLWNLowerMil.Location = new System.Drawing.Point(222, 213);
            this.txtLWNLowerMil.Name = "txtLWNLowerMil";
            this.txtLWNLowerMil.ReadOnly = true;
            this.txtLWNLowerMil.Size = new System.Drawing.Size(100, 26);
            this.txtLWNLowerMil.TabIndex = 4;
            // 
            // lblLWNUpperMil
            // 
            this.lblLWNUpperMil.AutoSize = true;
            this.lblLWNUpperMil.Location = new System.Drawing.Point(57, 247);
            this.lblLWNUpperMil.Name = "lblLWNUpperMil";
            this.lblLWNUpperMil.Size = new System.Drawing.Size(158, 20);
            this.lblLWNUpperMil.TabIndex = 0;
            this.lblLWNUpperMil.Text = "Upper Limit (+12.5%)";
            // 
            // txtLWNUpperMil
            // 
            this.txtLWNUpperMil.Location = new System.Drawing.Point(222, 247);
            this.txtLWNUpperMil.Name = "txtLWNUpperMil";
            this.txtLWNUpperMil.ReadOnly = true;
            this.txtLWNUpperMil.Size = new System.Drawing.Size(100, 26);
            this.txtLWNUpperMil.TabIndex = 4;
            // 
            // btnLWNLookupThickness
            // 
            this.btnLWNLookupThickness.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLWNLookupThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLWNLookupThickness.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLWNLookupThickness.Location = new System.Drawing.Point(28, 58);
            this.btnLWNLookupThickness.Name = "btnLWNLookupThickness";
            this.btnLWNLookupThickness.Size = new System.Drawing.Size(331, 47);
            this.btnLWNLookupThickness.TabIndex = 5;
            this.btnLWNLookupThickness.Text = "Lookup Thickness";
            this.btnLWNLookupThickness.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnClose.Location = new System.Drawing.Point(354, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 33);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // LWNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::FERExcelAddIn.Properties.Resources.FER_Logo_paint_red;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 369);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLWNLookupThickness);
            this.Controls.Add(this.txtLWNUpperMil);
            this.Controls.Add(this.txtLWNLowerMil);
            this.Controls.Add(this.txtLWNThickness);
            this.Controls.Add(this.txtLWNOD);
            this.Controls.Add(this.txtLWNID);
            this.Controls.Add(this.cmbLWNSchedule);
            this.Controls.Add(this.lblLWNScehule);
            this.Controls.Add(this.cmbLWNSize);
            this.Controls.Add(this.lblLWNUpperMil);
            this.Controls.Add(this.lblLWNLowerMil);
            this.Controls.Add(this.lblLWNThickness);
            this.Controls.Add(this.lblLWNOD);
            this.Controls.Add(this.lblLWNID);
            this.Controls.Add(this.lblSize);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LWNForm";
            this.Text = "LWN Thickness";
            this.Load += new System.EventHandler(this.LWNForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cmbLWNSize;
        private System.Windows.Forms.Label lblLWNScehule;
        private System.Windows.Forms.ComboBox cmbLWNSchedule;
        private System.Windows.Forms.TextBox txtLWNID;
        private System.Windows.Forms.TextBox txtLWNOD;
        private System.Windows.Forms.TextBox txtLWNThickness;
        private System.Windows.Forms.Label lblLWNID;
        private System.Windows.Forms.Label lblLWNOD;
        private System.Windows.Forms.Label lblLWNThickness;
        private System.Windows.Forms.Label lblLWNLowerMil;
        private System.Windows.Forms.TextBox txtLWNLowerMil;
        private System.Windows.Forms.Label lblLWNUpperMil;
        private System.Windows.Forms.TextBox txtLWNUpperMil;
        private System.Windows.Forms.Button btnLWNLookupThickness;
        private System.Windows.Forms.Button btnClose;
    }
}