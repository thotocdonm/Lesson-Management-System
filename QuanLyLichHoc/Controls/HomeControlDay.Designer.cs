namespace QuanLyLichHoc.Controls
{
    partial class HomeControlDay
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
            this.lbDay = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.a = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDay.Location = new System.Drawing.Point(61, 19);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(25, 19);
            this.lbDay.TabIndex = 0;
            this.lbDay.Text = "00";
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.Location = new System.Drawing.Point(13, 53);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(35, 15);
            this.labelValue.TabIndex = 3;
            this.labelValue.Text = "label3";
            // 
            // HomeControlDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.lbDay);
            this.Name = "HomeControlDay";
            this.Size = new System.Drawing.Size(160, 390);
            this.Load += new System.EventHandler(this.HomeControlDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.Label labelValue;
        private System.ComponentModel.BackgroundWorker a;
    }
}
