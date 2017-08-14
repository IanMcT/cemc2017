namespace SampleWindowsForm
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
            this.btnRunLoop = new System.Windows.Forms.Button();
            this.nudNumberOfTimes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRunLoop
            // 
            this.btnRunLoop.Location = new System.Drawing.Point(13, 23);
            this.btnRunLoop.Name = "btnRunLoop";
            this.btnRunLoop.Size = new System.Drawing.Size(75, 23);
            this.btnRunLoop.TabIndex = 0;
            this.btnRunLoop.Text = "button1";
            this.btnRunLoop.UseVisualStyleBackColor = true;
            this.btnRunLoop.Click += new System.EventHandler(this.btnRunLoop_Click);
            // 
            // nudNumberOfTimes
            // 
            this.nudNumberOfTimes.Location = new System.Drawing.Point(24, 67);
            this.nudNumberOfTimes.Name = "nudNumberOfTimes";
            this.nudNumberOfTimes.Size = new System.Drawing.Size(120, 20);
            this.nudNumberOfTimes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudNumberOfTimes);
            this.Controls.Add(this.btnRunLoop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTimes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunLoop;
        private System.Windows.Forms.NumericUpDown nudNumberOfTimes;
        private System.Windows.Forms.Label label1;
    }
}

