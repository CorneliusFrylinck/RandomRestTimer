namespace RandomRestTimer
{
    public partial class Form1 : Form
    {
        private TimeOnly totalTime = new TimeOnly();
        private TimeOnly intervalTime = new TimeOnly();

        private int intervalRestTime = 0;
        private int restIntervals = 0;
        private int restIntervalMin = 0;
        private int restIntervalMax = 0;
        private int timeLeft = 0;
        private int intervalTimeStart = 0;
        private int intervalTimeLeft = 0;
        private int totalTimeLeft = 0;
        private int timeToRestIndex = 0;
        private int chillTimeIndex = 0;

        private State currentState = State.INTERVAL;

        /// <summary>
        /// Times in seconds to rest.
        /// </summary>
        private List<int> restTimes = new List<int>();
        /// <summary>
        /// Duration to rest for each rest time
        /// </summary>
        private List<int> chillTimes = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            lblTotalTimeLeft.Text = tbxTotal.Text;
            lblIntervalTimeLeft.Text = tbxIntervalTime.Text;

            string[] times = tbxTotal.Text.Split(':');
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            if (times.Length > 0)
            {
                hours = int.Parse(times[0]);
            }
            if (times.Length > 1)
            {
                minutes = int.Parse(times[1]);
            }
            if (times.Length > 2)
            {
                seconds = int.Parse(times[2]);
            }

            totalTime = new TimeOnly(hours, minutes, seconds);
            totalTimeLeft = hours * 3600 + minutes * 60 + seconds;
            lblTotalTimeLeft.Text = $"{totalTime.Hour.ToString("D2")}:{totalTime.Minute.ToString("D2")}:{totalTime.Second.ToString("D2")}";

            times = tbxIntervalTime.Text.Split(':');
            hours = 0;
            minutes = 0;
            seconds = 0;

            if (times.Length > 0)
            {
                hours = int.Parse(times[0]);
            }
            if (times.Length > 1)
            {
                minutes = int.Parse(times[1]);
            }
            if (times.Length > 2)
            {
                seconds = int.Parse(times[2]);
            }

            intervalTime = new TimeOnly(hours, minutes, seconds);
            lblIntervalTimeLeft.Text = $"{intervalTime.Hour.ToString("D2")}:{intervalTime.Minute.ToString("D2")}:{intervalTime.Second.ToString("D2")}";

            intervalRestTime = Convert.ToInt32(tbxIntervalRestTime.Text);
            restIntervals = Convert.ToInt32(tbxRestIntervals.Text);

            string[] intervalTimes = tbxIntervalRange.Text.Split("-");
            restIntervalMin = 0; restIntervalMax = 0;

            if (intervalTimes.Length > 1)
            {
                restIntervalMin = int.Parse(intervalTimes[0]);
                restIntervalMax = int.Parse(intervalTimes[1]);
            }
            else if (times.Length > 0)
            {
                restIntervalMax = int.Parse(intervalTimes[0]);
            }

            int totalIntervalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;
            intervalTimeLeft = totalIntervalTimeInSeconds;
            intervalTimeStart = intervalTimeLeft;
            int totalTimePassed = 0;
            int totalTimeChilled = 0;

            var rand = new Random();

            for (int i = 0; i < restIntervals; i++)
            {
                if (i == restIntervals - 1)
                {
                    restTimes.Add(totalIntervalTimeInSeconds - totalTimePassed - totalTimeChilled);
                    redDisplay.AppendText($"Time before long rest: {SecondsToTimeString(totalIntervalTimeInSeconds - totalTimePassed - totalTimeChilled)}\n");
                    break;
                }
                int baseTime = totalIntervalTimeInSeconds / restIntervals;
                int chillTime = rand.Next(restIntervalMin, restIntervalMax + 1);
                chillTimes.Add(chillTime);
                totalTimeChilled += chillTime;
                int timeBeforeChill = Math.Max(baseTime / 2, baseTime - rand.Next(baseTime / 2, Convert.ToInt32(baseTime * 1.5)));
                restTimes.Add(timeBeforeChill);
                totalTimePassed += timeBeforeChill;
                redDisplay.AppendText($"Time before chill: {SecondsToTimeString(timeBeforeChill)}\n");
                redDisplay.AppendText($"Chill time: {SecondsToTimeString(chillTime)}\n\n");
            }

            tmrChillTimer.Interval = 1000;
            timeLeft = restTimes[timeToRestIndex++];
            lblIntervalTimeLeft.Text = restTimes[0].ToString();
            lblCurrentState.Text = currentState.ToString();
            tmrChillTimer.Start();
        }

        private void Reset()
        {
            btnStart.Enabled = true;
            tmrChillTimer.Stop();
            lblTotalTimeLeft.Text = "00:00";
            lblIntervalTimeLeft.Text = "00:00";
            lblCurrentTime.Text = "00:00";
            lblCurrentState.Text = "NONE";
            tbxTotal.Text = "8";
            tbxIntervalTime.Text = "1";
            tbxIntervalRestTime.Text = "10";
            tbxRestIntervals.Text = "30";
            tbxIntervalRange.Text = "15-25";
            cbxIncludeRest.Checked = true;
            redDisplay.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void tmrChillTimer_Tick(object sender, EventArgs e)
        {
            if (totalTimeLeft <= 0)
            {
                tmrChillTimer.Stop();
                Reset();
                return;
            }

            timeLeft--;
            switch (currentState)
            {
                case State.INTERVAL_REST:
                    if (cbxIncludeRest.Checked)
                    {
                        intervalTimeLeft--;
                        totalTimeLeft--;

                        if (timeLeft <= 0)
                        {
                            intervalTimeLeft -= timeLeft;
                            totalTimeLeft -= timeLeft;
                        }
                    }
                    if (timeLeft <= 0)
                    {
                        tmrChillTimer.Stop();
                        timeToRestIndex = 0;
                        timeLeft = restTimes[timeToRestIndex++];
                        intervalTimeLeft = intervalTimeStart;
                        currentState = State.INTERVAL;
                        lblCurrentState.Text = currentState.ToString();
                        tmrChillTimer.Start();
                    }
                    break;
                case State.INTERVAL:
                    intervalTimeLeft--;
                    totalTimeLeft--;
                    if (totalTimeLeft <= 0)
                    {
                        tmrChillTimer.Stop();
                        intervalTimeLeft -= timeLeft;
                        totalTimeLeft -= timeLeft;
                        timeLeft = intervalRestTime;
                        intervalTimeLeft = intervalRestTime;
                        currentState = State.INTERVAL_REST;
                        lblCurrentState.Text = currentState.ToString();
                        tmrChillTimer.Start();
                    }
                    else if (timeLeft <= 0)
                    {
                        tmrChillTimer.Stop();
                        currentState = State.RANDOM_REST;
                        timeLeft = chillTimes[chillTimeIndex++];
                        lblCurrentState.Text = currentState.ToString();
                        tmrChillTimer.Start();
                    }
                    break;
                case State.RANDOM_REST:
                    intervalTimeLeft--;
                    totalTimeLeft--;
                    if (timeLeft <= 0)
                    {
                        tmrChillTimer.Stop();
                        intervalTimeLeft -= timeLeft;
                        totalTimeLeft -= timeLeft;
                        timeLeft = restTimes[timeToRestIndex++];
                        currentState = State.INTERVAL;
                        lblCurrentState.Text = currentState.ToString();
                        tmrChillTimer.Start();
                    }
                    break;
            }

            lblIntervalTimeLeft.Text = SecondsToTimeString(intervalTimeLeft);
            lblTotalTimeLeft.Text = SecondsToTimeString(totalTimeLeft);
            lblCurrentTime.Text = SecondsToTimeString(timeLeft);

            if (timeLeft <= 0)
            {
                timeLeft = 0;
                tmrChillTimer.Stop();
            }
        }

        private static string SecondsToTimeString(int seconds)
        {
            if (seconds > 3600)
            {
                int total = seconds;
                int h = (int)(total / 3600);
                total = seconds - (h * 3600);
                int m = (int)(total / 60);
                total -= (m * 60);
                int s = total;

                return $"{h.ToString("D2")}:{m.ToString("D2")}:{s.ToString("D2")}";
            }
            if (seconds > 60)
            {
                int total = seconds;
                int m = (int)(total / 60);
                total -= (m * 60);
                int s = total;

                return $"{m.ToString("D2")}:{s.ToString("D2")}";
            }
            return seconds.ToString("D2");
        }
    }

    public enum State
    {
        INTERVAL = 1,
        INTERVAL_REST = 2,
        RANDOM_REST = 3
    }
}