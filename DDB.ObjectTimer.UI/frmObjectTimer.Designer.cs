namespace DDB.ObjectTimer.UI
{
    partial class frmObjectTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblElapsedTime = new Label();
            btnStartClock = new Button();
            btnStopTimer = new Button();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            btnExit = new Button();
            tmrClock = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.AutoSize = true;
            lblElapsedTime.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblElapsedTime.Location = new Point(81, 59);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(136, 45);
            lblElapsedTime.TabIndex = 0;
            lblElapsedTime.Text = "00:00:00";
            // 
            // btnStartClock
            // 
            btnStartClock.Location = new Point(33, 152);
            btnStartClock.Name = "btnStartClock";
            btnStartClock.Size = new Size(96, 39);
            btnStartClock.TabIndex = 1;
            btnStartClock.Text = "Start";
            btnStartClock.UseVisualStyleBackColor = true;
            btnStartClock.Click += btnStartClock_Click;
            // 
            // btnStopTimer
            // 
            btnStopTimer.Location = new Point(177, 152);
            btnStopTimer.Name = "btnStopTimer";
            btnStopTimer.Size = new Size(96, 39);
            btnStopTimer.TabIndex = 2;
            btnStopTimer.Text = "Stop";
            btnStopTimer.UseVisualStyleBackColor = true;
            btnStopTimer.Click += btnStopTimer_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 280);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(307, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 17);
            lblStatus.Text = "Status";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(177, 238);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 39);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmObjectTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 302);
            Controls.Add(btnExit);
            Controls.Add(statusStrip1);
            Controls.Add(btnStopTimer);
            Controls.Add(btnStartClock);
            Controls.Add(lblElapsedTime);
            Name = "frmObjectTimer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Object Timer";
            Load += frmObjectTimer_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblElapsedTime;
        private Button btnStartClock;
        private Button btnStopTimer;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private Button btnExit;
        private System.Windows.Forms.Timer tmrClock;
    }
}