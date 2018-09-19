namespace Multi_Thread_Example
{
    partial class frmMain
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
            this.btnStartThreads = new System.Windows.Forms.Button();
            this.nudNumberOfThreads = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfThreds = new System.Windows.Forms.Label();
            this.btnStartThread = new System.Windows.Forms.Button();
            this.btnStopThread = new System.Windows.Forms.Button();
            this.nudThreadToStop = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfThreads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadToStop)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartThreads
            // 
            this.btnStartThreads.Location = new System.Drawing.Point(12, 12);
            this.btnStartThreads.Name = "btnStartThreads";
            this.btnStartThreads.Size = new System.Drawing.Size(79, 30);
            this.btnStartThreads.TabIndex = 0;
            this.btnStartThreads.Text = "Start Threads";
            this.btnStartThreads.UseVisualStyleBackColor = true;
            this.btnStartThreads.Click += new System.EventHandler(this.btnStartThreads_Click);
            // 
            // nudNumberOfThreads
            // 
            this.nudNumberOfThreads.Location = new System.Drawing.Point(112, 81);
            this.nudNumberOfThreads.Name = "nudNumberOfThreads";
            this.nudNumberOfThreads.Size = new System.Drawing.Size(67, 20);
            this.nudNumberOfThreads.TabIndex = 1;
            this.nudNumberOfThreads.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblNumberOfThreds
            // 
            this.lblNumberOfThreds.AutoSize = true;
            this.lblNumberOfThreds.Location = new System.Drawing.Point(12, 83);
            this.lblNumberOfThreds.Name = "lblNumberOfThreds";
            this.lblNumberOfThreds.Size = new System.Drawing.Size(94, 13);
            this.lblNumberOfThreds.TabIndex = 2;
            this.lblNumberOfThreds.Text = "Number Of Threds";
            // 
            // btnStopThread
            // 
            this.btnStopThread.Location = new System.Drawing.Point(15, 155);
            this.btnStopThread.Name = "btnStopThread";
            this.btnStopThread.Size = new System.Drawing.Size(79, 30);
            this.btnStopThread.TabIndex = 3;
            this.btnStopThread.Text = "Stop Thread";
            this.btnStopThread.UseVisualStyleBackColor = true;
            this.btnStopThread.Click += new System.EventHandler(this.btnStopThread_Click);
            //
            // btnStartThread
            // 
            this.btnStartThread.Location = new System.Drawing.Point(15, 205);
            this.btnStartThread.Name = "btnStartThread";
            this.btnStartThread.Size = new System.Drawing.Size(79, 30);
            this.btnStartThread.TabIndex = 3;
            this.btnStartThread.Text = "Start Thread";
            this.btnStartThread.UseVisualStyleBackColor = true;
            this.btnStartThread.Click += new System.EventHandler(this.btnStartThread_Click);
            // 
            // nudThreadToStop
            // 
            this.nudThreadToStop.Location = new System.Drawing.Point(112, 162);
            this.nudThreadToStop.Name = "nudThreadToStop";
            this.nudThreadToStop.Size = new System.Drawing.Size(67, 20);
            this.nudThreadToStop.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.nudThreadToStop);
            this.Controls.Add(this.btnStopThread);
            this.Controls.Add(this.btnStartThread);
            this.Controls.Add(this.lblNumberOfThreds);
            this.Controls.Add(this.nudNumberOfThreads);
            this.Controls.Add(this.btnStartThreads);
            this.Name = "frmMain";
            this.Text = "Multi Thread Tester";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfThreads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadToStop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartThreads;
        private System.Windows.Forms.NumericUpDown nudNumberOfThreads;
        private System.Windows.Forms.Label lblNumberOfThreds;
        private System.Windows.Forms.Button btnStopThread;
        private System.Windows.Forms.Button btnStartThread;
        private System.Windows.Forms.NumericUpDown nudThreadToStop;
    }
}

