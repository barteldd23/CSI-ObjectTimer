using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDB.ObjectTimer.BL
{
    public class StopWatch
    {
		private DateTime startTime;

		public DateTime StartTime
		{
			get { return startTime; }
			set { startTime = value; }
		}

		private DateTime endTime;

		public DateTime EndTime
		{
			get { return endTime; }
			set { endTime = value; }
		}

		private bool isRunning;

		public bool IsRunning
		{
			get { return isRunning; }
			set { isRunning = value; }
		}

        public string ElapsedTime
        {
            get
            {
                return (EndTime.Hour - StartTime.Hour).ToString() + ":" + (EndTime.Minute - StartTime.Minute).ToString()
					   + ":" + (EndTime.Second - StartTime.Second).ToString();
            }
        }
    }
}
