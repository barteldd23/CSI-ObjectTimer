using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDB.ObjectTimer.BL
{
	public class StartException : Exception
	{
		public StartException() : base("Stopwatch is already started.")
		{ 
		}

		public StartException(string message) : base(message)
		{
		}
	}

	public class StopException : Exception
	{
		public StopException() : base("Stopwatch is already stopped.") 
		{
		}

		public StopException(string message) : base(message)
		{
		}

	}

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

        public DateTime Split_1_Start { get; set; }
        public DateTime Split_1_End { get; set; }
        public DateTime Split_2_Start { get; set; }
        public DateTime Split_2_End { get; set; }
        public DateTime Split_3_Start { get; set; }
        public DateTime Split_3_End { get; set; }
        public bool split_1_running { get; set; }
        public bool split_2_running { get; set; }
        public bool split_3_running { get; set; }

        public string ElapsedTime (DateTime start, DateTime end)
        {
            return (end.Hour - start.Hour).ToString("d2") + ":" + (end.Minute - start.Minute).ToString("d2")
					   + ":" + (end.Second - start.Second).ToString("d2");
            
        }

		public void StartClock()
		{
			if (IsRunning)
			{
				throw new StartException();
			}
			else
			{
                startTime = DateTime.Now;
				this.IsRunning = true;
            }
		}
		public void StopClock()
		{
			if (!isRunning)
			{
				throw new StopException();
			}
			else
			{
                endTime = DateTime.Now;
				this.IsRunning = false;
                if (split_1_running)
                {
                    split_1_running = false;
                    Split_1_End = DateTime.Now;
                }
                if (split_2_running)
                {
                    split_2_running = false;
                    Split_2_End = DateTime.Now;
                }
                if (split_3_running)
                {
                    split_3_running = false;
                    Split_3_End = DateTime.Now;
                }
            }
			
		}

        public void StartSplit_1()
        {
            if (split_1_running)
            {
                throw new StartException("Split 1 is already running.");
            }
            else
            {
                Split_1_Start = DateTime.Now;
                this.split_1_running = true;
            }
        }

        public void StartSplit_2()
        {
            if (split_2_running)
            {
                throw new StartException("Split 2 is already running.");
            }
            else
            {
                Split_2_Start = DateTime.Now;
                this.split_2_running = true;
            }
        }

        public void StartSplit_3()
        {
            if (split_3_running)
            {
                throw new StartException("Split 3 is already running.");
            }
            else
            {
                Split_3_Start = DateTime.Now;
                this.split_3_running = true;
            }
        }

		public void StopSplit_1()
		{
            if (!split_1_running)
            {
                throw new StopException("Split 1 is not running.");
            }
            else
            {
                Split_1_End = DateTime.Now;
                this.split_1_running = false;
            }
        }
        public void StopSplit_2()
        {
            if (!split_2_running)
            {
                throw new StopException("Split 2 is not running.");
            }
            else
            {
                Split_2_End = DateTime.Now;
                this.split_2_running = false;
            }
        }

        public void StopSplit_3()
        {
            if (!split_3_running)
            {
                throw new StopException("Split 3 is not running.");
            }
            else
            {
                Split_3_End = DateTime.Now;
                this.split_3_running = false;
            }
        }
    }
}
