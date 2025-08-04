using System.Drawing;
using System.Windows.Forms;

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSize = new System.Windows.Forms.Label();
            this.cmbLWNSize = new System.Windows.Forms.ComboBox();
            this.lblLWNSchedule = new System.Windows.Forms.Label();
            this.cmbLWNSchedule = new System.Windows.Forms.ComboBox();
            this.lblLWNThickness = new System.Windows.Forms.Label();
            this.txtLWNThickness = new System.Windows.Forms.TextBox();
            this.lblLWNOD = new System.Windows.Forms.Label();
            this.txtLWNOD = new System.Windows.Forms.TextBox();
            this.lblLWNID = new System.Windows.Forms.Label();
            this.txtLWNID = new System.Windows.Forms.TextBox();
            this.lblLWNLowerMil = new System.Windows.Forms.Label();
            this.txtLWNLowerMil = new System.Windows.Forms.TextBox();
            this.lblLWNUpperMil = new System.Windows.Forms.Label();
            this.txtLWNUpperMil = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.lblSize, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbLWNSize, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLWNSchedule, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbLWNSchedule, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLWNThickness, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtLWNThickness, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblLWNOD, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtLWNOD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblLWNID, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtLWNID, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblLWNLowerMil, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtLWNLowerMil, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblLWNUpperMil, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtLWNUpperMil, 1, 7);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(722, 534);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSize.Location = new System.Drawing.Point(9, 6);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(278, 44);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size:";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLWNSize
            // 
            this.cmbLWNSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLWNSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLWNSize.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbLWNSize.FormattingEnabled = true;
            this.cmbLWNSize.Location = new System.Drawing.Point(293, 10);
            this.cmbLWNSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLWNSize.Name = "cmbLWNSize";
            this.cmbLWNSize.Size = new System.Drawing.Size(420, 36);
            this.cmbLWNSize.TabIndex = 1;
            // 
            // lblLWNSchedule
            // 
            this.lblLWNSchedule.AutoSize = true;
            this.lblLWNSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLWNSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLWNSchedule.Location = new System.Drawing.Point(9, 50);
            this.lblLWNSchedule.Name = "lblLWNSchedule";
            this.lblLWNSchedule.Size = new System.Drawing.Size(278, 44);
            this.lblLWNSchedule.TabIndex = 2;
            this.lblLWNSchedule.Text = "Schedule:";
            this.lblLWNSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLWNSchedule
            // 
            this.cmbLWNSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLWNSchedule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLWNSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cmbLWNSchedule.FormattingEnabled = true;
            this.cmbLWNSchedule.Location = new System.Drawing.Point(293, 54);
            this.cmbLWNSchedule.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLWNSchedule.Name = "cmbLWNSchedule";
            this.cmbLWNSchedule.Size = new System.Drawing.Size(420, 36);
            this.cmbLWNSchedule.TabIndex = 3;
            // 
            // lblLWNThickness
            // 
            this.lblLWNThickness.AutoSize = true;
            this.lblLWNThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLWNThickness.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLWNThickness.Location = new System.Drawing.Point(9, 150);
            this.lblLWNThickness.Name = "lblLWNThickness";
            this.lblLWNThickness.Size = new System.Drawing.Size(278, 44);
            this.lblLWNThickness.TabIndex = 5;
            this.lblLWNThickness.Text = "Nominal Thickness (in):";
            this.lblLWNThickness.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLWNThickness
            // 
            this.txtLWNThickness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLWNThickness.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLWNThickness.Location = new System.Drawing.Point(293, 154);
            this.txtLWNThickness.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLWNThickness.Name = "txtLWNThickness";
            this.txtLWNThickness.ReadOnly = true;
            this.txtLWNThickness.Size = new System.Drawing.Size(420, 33);
            this.txtLWNThickness.TabIndex = 6;
            this.txtLWNThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLWNOD
            // 
            this.lblLWNOD.AutoSize = true;
            this.lblLWNOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLWNOD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLWNOD.Location = new System.Drawing.Point(9, 194);
            this.lblLWNOD.Name = "lblLWNOD";
            this.lblLWNOD.Size = new System.Drawing.Size(278, 44);
            this.lblLWNOD.TabIndex = 7;
            this.lblLWNOD.Text = "Outside Diameter (in):";
            this.lblLWNOD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLWNOD
            // 
            this.txtLWNOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLWNOD.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLWNOD.Location = new System.Drawing.Point(293, 198);
            this.txtLWNOD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLWNOD.Name = "txtLWNOD";
            this.txtLWNOD.ReadOnly = true;
            this.txtLWNOD.Size = new System.Drawing.Size(420, 33);
            this.txtLWNOD.TabIndex = 8;
            this.txtLWNOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLWNID
            // 
            this.lblLWNID.AutoSize = true;
            this.lblLWNID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLWNID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLWNID.Location = new System.Drawing.Point(9, 238);
            this.lblLWNID.Name = "lblLWNID";
            this.lblLWNID.Size = new System.Drawing.Size(278, 44);
            this.lblLWNID.TabIndex = 9;
            this.lblLWNID.Text = "Inside Diameter (in):";
            this.lblLWNID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLWNID
            // 
            this.txtLWNID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLWNID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLWNID.Location = new System.Drawing.Point(293, 242);
            this.txtLWNID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLWNID.Name = "txtLWNID";
            this.txtLWNID.ReadOnly = true;
            this.txtLWNID.Size = new System.Drawing.Size(420, 33);
            this.txtLWNID.TabIndex = 10;
            this.txtLWNID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLWNLowerMil
            // 
            this.lblLWNLowerMil.AutoSize = true;
            this.lblLWNLowerMil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLWNLowerMil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLWNLowerMil.Location = new System.Drawing.Point(9, 282);
            this.lblLWNLowerMil.Name = "lblLWNLowerMil";
            this.lblLWNLowerMil.Size = new System.Drawing.Size(278, 44);
            this.lblLWNLowerMil.TabIndex = 11;
            this.lblLWNLowerMil.Text = "Min Thickness (in):";
            this.lblLWNLowerMil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLWNLowerMil
            // 
            this.txtLWNLowerMil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLWNLowerMil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLWNLowerMil.Location = new System.Drawing.Point(293, 286);
            this.txtLWNLowerMil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLWNLowerMil.Name = "txtLWNLowerMil";
            this.txtLWNLowerMil.ReadOnly = true;
            this.txtLWNLowerMil.Size = new System.Drawing.Size(420, 33);
            this.txtLWNLowerMil.TabIndex = 12;
            this.txtLWNLowerMil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLWNUpperMil
            // 
            this.lblLWNUpperMil.AutoSize = true;
            this.lblLWNUpperMil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLWNUpperMil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblLWNUpperMil.Location = new System.Drawing.Point(9, 326);
            this.lblLWNUpperMil.Name = "lblLWNUpperMil";
            this.lblLWNUpperMil.Size = new System.Drawing.Size(278, 44);
            this.lblLWNUpperMil.TabIndex = 13;
            this.lblLWNUpperMil.Text = "Max Thickness (in):";
            this.lblLWNUpperMil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLWNUpperMil
            // 
            this.txtLWNUpperMil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLWNUpperMil.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtLWNUpperMil.Location = new System.Drawing.Point(293, 330);
            this.txtLWNUpperMil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLWNUpperMil.Name = "txtLWNUpperMil";
            this.txtLWNUpperMil.ReadOnly = true;
            this.txtLWNUpperMil.Size = new System.Drawing.Size(420, 33);
            this.txtLWNUpperMil.TabIndex = 14;
            this.txtLWNUpperMil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // 
            // btnShowAllData
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnShowAllData, 2);
            this.btnShowAllData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowAllData.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnShowAllData.Location = new System.Drawing.Point(9, 418);
            this.btnShowAllData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllData.Name = "btnShowAllData";
            this.btnShowAllData.Size = new System.Drawing.Size(704, 106);
            this.btnShowAllData.TabIndex = 16;
            this.btnShowAllData.Text = "Show All Data";
            this.btnShowAllData.UseVisualStyleBackColor = true;
            // 
            // LWNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 558);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(504, 486);
            this.Name = "LWNForm";
            this.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LWN Thickness Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cmbLWNSize;
        private System.Windows.Forms.Label lblLWNSchedule;
        private System.Windows.Forms.ComboBox cmbLWNSchedule;
        private System.Windows.Forms.Label lblLWNThickness;
        private System.Windows.Forms.TextBox txtLWNThickness;
        private System.Windows.Forms.Label lblLWNOD;
        private System.Windows.Forms.TextBox txtLWNOD;
        private System.Windows.Forms.Label lblLWNID;
        private System.Windows.Forms.TextBox txtLWNID;
        private System.Windows.Forms.Label lblLWNLowerMil;
        private System.Windows.Forms.TextBox txtLWNLowerMil;
        private System.Windows.Forms.Label lblLWNUpperMil;
        private System.Windows.Forms.TextBox txtLWNUpperMil;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnShowAllData;
    }
}