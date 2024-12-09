namespace member_space
{
    partial class CompanyOutcomes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCompanyOutcomes = new System.Windows.Forms.DataGridView();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyOutcomes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompanyOutcomes
            // 
            this.dgvCompanyOutcomes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvCompanyOutcomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyOutcomes.Location = new System.Drawing.Point(127, 35);
            this.dgvCompanyOutcomes.Name = "dgvCompanyOutcomes";
            this.dgvCompanyOutcomes.Size = new System.Drawing.Size(519, 298);
            this.dgvCompanyOutcomes.TabIndex = 0;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(127, 355);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(446, 355);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(548, 411);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "button1";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(-4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 452);
            this.panel1.TabIndex = 4;
            // 
            // CompanyOutcomes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dgvCompanyOutcomes);
            this.Name = "CompanyOutcomes";
            this.Text = "CompanyOutcomes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyOutcomes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompanyOutcomes;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel panel1;
    }
}