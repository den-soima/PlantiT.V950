namespace PlantiT.Forms.Host
{
    partial class HostMvaLineChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {            
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.mvaLineChart1 = new PlantiT.Forms.Host.MvaLineChart();
            ((System.ComponentModel.ISupportInitialize)(this.formLocalizer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProvider)).BeginInit();
            this.SuspendLayout();
            // Hinweis: Die Zuweisungen von Icons an Controls durch PDesignImageSupport wurde vor dem speichern rückgägnig gemacht.
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(10);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(1134, 752);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.mvaLineChart1;
            // 
            // HostMvaLineChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.elementHost1);
            this.Name = "HostMvaLineChart";
            this.Size = new System.Drawing.Size(1134, 752);
            ((System.ComponentModel.ISupportInitialize)(this.formLocalizer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private MvaLineChart mvaLineChart1;
    }
}
