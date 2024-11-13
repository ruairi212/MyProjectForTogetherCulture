namespace member_space
{
    partial class InteractiveCalendar
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
            this.Monday = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Location = new System.Drawing.Point(131, 53);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(45, 13);
            this.Monday.TabIndex = 0;
            this.Monday.Text = "Monday";
            this.Monday.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1245, 566);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // InteractiveCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 666);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "InteractiveCalendar";
            this.Text = "Form14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Monday;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}