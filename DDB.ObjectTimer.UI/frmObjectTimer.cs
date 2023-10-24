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
            lblElapsedTime.Text = stopWatch.ElapsedTime;
        }
    }
}