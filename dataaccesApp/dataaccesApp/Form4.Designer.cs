namespace dataaccesApp
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcountries = new System.Windows.Forms.ComboBox();
            this.gvcustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvcustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Country";
            // 
            // cmbcountries
            // 
            this.cmbcountries.FormattingEnabled = true;
            this.cmbcountries.Location = new System.Drawing.Point(12, 71);
            this.cmbcountries.Name = "cmbcountries";
            this.cmbcountries.Size = new System.Drawing.Size(121, 21);
            this.cmbcountries.TabIndex = 1;
            this.cmbcountries.Text = "All Countries";
            this.cmbcountries.SelectedIndexChanged += new System.EventHandler(this.cmbcountries_SelectedIndexChanged);
            // 
            // gvcustomers
            // 
            this.gvcustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvcustomers.Location = new System.Drawing.Point(150, 71);
            this.gvcustomers.Name = "gvcustomers";
            this.gvcustomers.Size = new System.Drawing.Size(689, 271);
            this.gvcustomers.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 369);
            this.Controls.Add(this.gvcustomers);
            this.Controls.Add(this.cmbcountries);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvcustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcountries;
        private System.Windows.Forms.DataGridView gvcustomers;
    }
}