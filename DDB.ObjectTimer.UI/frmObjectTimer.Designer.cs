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
            lblSplit_1 = new Label();
            btnSplit_1_Start = new Button();
            btnSplit_1_Stop = new Button();
            btnSplit_2_Stop = new Button();
            btnSplit_2_Start = new Button();
            lblSplit_2 = new Label();
            btnSplit_3_Stop = new Button();
            btnSplit_3_Start = new Button();
            lblSplit_3 = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.AutoSize = true;
            lblElapsedTime.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblElapsedTime.Location = new Point(79, 9);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(136, 45);
            lblElapsedTime.TabIndex = 0;
            lblElapsedTime.Text = "00:00:00";
            // 
            // btnStartClock
            // 
            btnStartClock.Location = new Point(30, 185);
            btnStartClock.Name = "btnStartClock";
            btnStartClock.Size = new Size(96, 39);
            btnStartClock.TabIndex = 1;
            btnStartClock.Text = "Start";
            btnStartClock.UseVisualStyleBackColor = true;
            btnStartClock.Click += btnStartClock_Click;
            // 
            // btnStopTimer
            // 
            btnStopTimer.Location = new Point(177, 185);
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
            // tmrClock
            // 
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // lblSplit_1
            // 
            lblSplit_1.AutoSize = true;
            lblSplit_1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblSplit_1.Location = new Point(136, 54);
            lblSplit_1.Name = "lblSplit_1";
            lblSplit_1.Size = new Size(70, 21);
            lblSplit_1.TabIndex = 5;
            lblSplit_1.Text = "00:00:00";
            // 
            // btnSplit_1_Start
            // 
            btnSplit_1_Start.Enabled = false;
            btnSplit_1_Start.Location = new Point(212, 54);
            btnSplit_1_Start.Name = "btnSplit_1_Start";
            btnSplit_1_Start.Size = new Size(43, 25);
            btnSplit_1_Start.TabIndex = 6;
            btnSplit_1_Start.Text = "Start";
            btnSplit_1_Start.UseVisualStyleBackColor = true;
            btnSplit_1_Start.Click += btnSplit_1_Start_Click;
            // 
            // btnSplit_1_Stop
            // 
            btnSplit_1_Stop.Enabled = false;
            btnSplit_1_Stop.Location = new Point(261, 54);
            btnSplit_1_Stop.Name = "btnSplit_1_Stop";
            btnSplit_1_Stop.Size = new Size(43, 25);
            btnSplit_1_Stop.TabIndex = 7;
            btnSplit_1_Stop.Text = "Stop";
            btnSplit_1_Stop.UseVisualStyleBackColor = true;
            btnSplit_1_Stop.Click += btnSplit_1_Stop_Click;
            // 
            // btnSplit_2_Stop
            // 
            btnSplit_2_Stop.Location = new Point(261, 84);
            btnSplit_2_Stop.Name = "btnSplit_2_Stop";
            btnSplit_2_Stop.Size = new Size(43, 25);
            btnSplit_2_Stop.TabIndex = 10;
            btnSplit_2_Stop.Text = "Stop";
            btnSplit_2_Stop.UseVisualStyleBackColor = true;
            btnSplit_2_Stop.Visible = false;
            btnSplit_2_Stop.Click += btnSplit_2_Stop_Click;
            // 
            // btnSplit_2_Start
            // 
            btnSplit_2_Start.Location = new Point(212, 84);
            btnSplit_2_Start.Name = "btnSplit_2_Start";
            btnSplit_2_Start.Size = new Size(43, 25);
            btnSplit_2_Start.TabIndex = 9;
            btnSplit_2_Start.Text = "Start";
            btnSplit_2_Start.UseVisualStyleBackColor = true;
            btnSplit_2_Start.Visible = false;
            btnSplit_2_Start.Click += btnSplit_2_Start_Click;
            // 
            // lblSplit_2
            // 
            lblSplit_2.AutoSize = true;
            lblSplit_2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblSplit_2.Location = new Point(136, 84);
            lblSplit_2.Name = "lblSplit_2";
            lblSplit_2.Size = new Size(70, 21);
            lblSplit_2.TabIndex = 8;
            lblSplit_2.Text = "00:00:00";
            lblSplit_2.Visible = false;
            // 
            // btnSplit_3_Stop
            // 
            btnSplit_3_Stop.Location = new Point(261, 114);
            btnSplit_3_Stop.Name = "btnSplit_3_Stop";
            btnSplit_3_Stop.Size = new Size(43, 25);
            btnSplit_3_Stop.TabIndex = 13;
            btnSplit_3_Stop.Text = "Stop";
            btnSplit_3_Stop.UseVisualStyleBackColor = true;
            btnSplit_3_Stop.Visible = false;
            btnSplit_3_Stop.Click += btnSplit_3_Stop_Click;
            // 
            // btnSplit_3_Start
            // 
            btnSplit_3_Start.Location = new Point(212, 114);
            btnSplit_3_Start.Name = "btnSplit_3_Start";
            btnSplit_3_Start.Size = new Size(43, 25);
            btnSplit_3_Start.TabIndex = 12;
            btnSplit_3_Start.Text = "Start";
            btnSplit_3_Start.UseVisualStyleBackColor = true;
            btnSplit_3_Start.Visible = false;
            btnSplit_3_Start.Click += btnSplit_3_Start_Click;
            // 
            // lblSplit_3
            // 
            lblSplit_3.AutoSize = true;
            lblSplit_3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            lblSplit_3.Location = new Point(136, 114);
            lblSplit_3.Name = "lblSplit_3";
            lblSplit_3.Size = new Size(70, 21);
            lblSplit_3.TabIndex = 11;
            lblSplit_3.Text = "00:00:00";
            lblSplit_3.Visible = false;
            // 
            // frmObjectTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 302);
            Controls.Add(btnSplit_3_Stop);
            Controls.Add(btnSplit_3_Start);
            Controls.Add(lblSplit_3);
            Controls.Add(btnSplit_2_Stop);
            Controls.Add(btnSplit_2_Start);
            Controls.Add(lblSplit_2);
            Controls.Add(btnSplit_1_Stop);
            Controls.Add(btnSplit_1_Start);
            Controls.Add(lblSplit_1);
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
        private Label lblSplit_1;
        private Button btnSplit_1_Start;
        private Button btnSplit_1_Stop;
        private Button btnSplit_2_Stop;
        private Button btnSplit_2_Start;
        private Label lblSplit_2;
        private Button btnSplit_3_Stop;
        private Button btnSplit_3_Start;
        private Label lblSplit_3;
    }
}