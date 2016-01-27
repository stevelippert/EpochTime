namespace EpochTime
{
    partial class Form1
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
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime2Output = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTime1Output = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime3Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2.Location = new System.Drawing.Point(12, 59);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(130, 22);
            this.lblTime2.TabIndex = 2;
            this.lblTime2.Text = "Central Time";
            // 
            // lblTime2Output
            // 
            this.lblTime2Output.AutoSize = true;
            this.lblTime2Output.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime2Output.Location = new System.Drawing.Point(12, 90);
            this.lblTime2Output.Name = "lblTime2Output";
            this.lblTime2Output.Size = new System.Drawing.Size(0, 22);
            this.lblTime2Output.TabIndex = 3;
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1.Location = new System.Drawing.Point(12, 9);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(130, 22);
            this.lblTime1.TabIndex = 4;
            this.lblTime1.Text = "Eastern Time";
            // 
            // lblTime1Output
            // 
            this.lblTime1Output.AutoSize = true;
            this.lblTime1Output.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime1Output.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime1Output.Location = new System.Drawing.Point(12, 31);
            this.lblTime1Output.Name = "lblTime1Output";
            this.lblTime1Output.Size = new System.Drawing.Size(0, 22);
            this.lblTime1Output.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pacific Time";
            // 
            // lblTime3Output
            // 
            this.lblTime3Output.AutoSize = true;
            this.lblTime3Output.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime3Output.Location = new System.Drawing.Point(15, 142);
            this.lblTime3Output.Name = "lblTime3Output";
            this.lblTime3Output.Size = new System.Drawing.Size(0, 22);
            this.lblTime3Output.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 208);
            this.Controls.Add(this.lblTime3Output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime1Output);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.lblTime2Output);
            this.Controls.Add(this.lblTime2);
            this.Name = "Form1";
            this.Text = "Epoch Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime2Output;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblTime1Output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime3Output;
    }
}

