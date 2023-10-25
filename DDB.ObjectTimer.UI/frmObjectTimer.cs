using DDB.ObjectTimer.BL;

namespace DDB.ObjectTimer.UI
{
    public partial class frmObjectTimer : Form
    {
        // Create a Timer class object for the main timer
        StopWatch stopWatch = new StopWatch();

        public frmObjectTimer()
        {
            InitializeComponent();
        }

        private void btnStartClock_Click(object sender, EventArgs e)
        {
            try
            {
                // Start the clock
                stopWatch.StartClock();

                // Start the timer
                tmrClock.Enabled = true;

                // Reset all labels and Split buttons
                lblElapsedTime.Text = "00:00:00";
                lblSplit_1.Text = "00:00:00";
                lblSplit_2.Text = "00:00:00";
                lblSplit_3.Text = "00:00:00";
                btnSplit_1_Start.Enabled = true;
                btnSplit_1_Stop.Enabled = true;

                lblSplit_2.Visible = false;
                lblSplit_3.Visible = false;

                btnSplit_2_Start.Visible = false;
                btnSplit_2_Stop.Visible = false;
                btnSplit_3_Start.Visible = false;
                btnSplit_3_Stop.Visible = false;

                btnSplit_2_Start.Enabled = false;
                btnSplit_2_Stop.Enabled = false;
                btnSplit_3_Start.Enabled = false;
                btnSplit_3_Stop.Enabled = false;

                // Set display colors
                lblElapsedTime.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                // Show error message in the status strip
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            // Check if the clock is running before stopping
            try
            {
                // Stop the clock
                stopWatch.StopClock();

                // Stop the timer
                tmrClock.Enabled = false;

                // Make all split buttons un-clickable
                btnSplit_1_Start.Enabled = false;
                btnSplit_1_Stop.Enabled = false;
                btnSplit_2_Start.Enabled = false;
                btnSplit_2_Stop.Enabled = false;
                btnSplit_3_Start.Enabled = false;
                btnSplit_3_Stop.Enabled = false;

                lblElapsedTime.ForeColor = Color.Black;
                lblSplit_1.ForeColor = Color.Black;
                lblSplit_2.ForeColor = Color.Black;
                lblSplit_3.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {
                // Show error message in the status strip
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void frmObjectTimer_Load(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            //Show call duration and new split time
            stopWatch.EndTime = DateTime.Now;
            lblElapsedTime.Text = stopWatch.ElapsedTime(stopWatch.StartTime, stopWatch.EndTime);

            // Check if any splits are running and update their times
            if (stopWatch.split_1_running)
            {
                stopWatch.Split_1_End = DateTime.Now;
                lblSplit_1.Text = stopWatch.ElapsedTime(stopWatch.Split_1_Start, stopWatch.Split_1_End);
            }
            if (stopWatch.split_2_running)
            {
                stopWatch.Split_2_End = DateTime.Now;
                lblSplit_2.Text = stopWatch.ElapsedTime(stopWatch.Split_2_Start, stopWatch.Split_2_End);
            }
            if (stopWatch.split_3_running)
            {
                stopWatch.Split_3_End = DateTime.Now;
                lblSplit_3.Text = stopWatch.ElapsedTime(stopWatch.Split_3_Start, stopWatch.Split_3_End);
            }
        }

        #region "Split 1 start/Stop click events"
        private void btnSplit_1_Start_Click(object sender, EventArgs e)
        {
            try
            {
                // Start the clock
                stopWatch.StartSplit_1();

                // Split One was activated, allow for split 2 to be clicked on.
                lblSplit_2.Visible = true;
                btnSplit_2_Start.Visible = true;
                btnSplit_2_Stop.Visible = true;
                btnSplit_2_Start.Enabled = true;
                btnSplit_2_Stop.Enabled = true;

                lblSplit_1.Text = "00:00:00";
                // Set display colors
                lblSplit_1.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                // Show error message in the status strip
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSplit_1_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                // Stop the clock
                stopWatch.StopSplit_1();

                lblSplit_1.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {
                // Show error message in the status strip
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }
        #endregion


        #region "Split 2 start/Stop click events"
        private void btnSplit_2_Start_Click(object sender, EventArgs e)
        {
            try
            {
                // Start the clock
                stopWatch.StartSplit_2();

                //Split 2 was activated, allow for split 3 to be activated.
                lblSplit_3.Visible = true;
                btnSplit_3_Start.Visible = true;
                btnSplit_3_Stop.Visible = true;
                btnSplit_3_Start.Enabled = true;
                btnSplit_3_Stop.Enabled = true;

                lblSplit_2.Text = "00:00:00";
                // Set display colors
                lblSplit_2.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                // Show error message in the status strip
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSplit_2_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                // Stop the clock
                stopWatch.StopSplit_2();

                lblSplit_2.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {
                // Show error message in the status strip
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }
        #endregion


        #region "Split 3 start/Stop click events"
        private void btnSplit_3_Start_Click(object sender, EventArgs e)
        {
            try
            {
                // Start the clock
                stopWatch.StartSplit_3();


                lblSplit_3.Text = "00:00:00";
                // Set display colors
                lblSplit_3.ForeColor = Color.Green;

            }
            catch (Exception ex)
            {
                // Show error message in the status strip
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnSplit_3_Stop_Click(object sender, EventArgs e)
        {
            try
            {
                // Stop the clock
                stopWatch.StopSplit_3();

                lblSplit_3.ForeColor = Color.Black;

            }
            catch (Exception ex)
            {
                // Show error message in the status strip
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        #endregion
    }
}