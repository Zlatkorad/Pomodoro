using System;
using System.Collections.Generic;
using System.Text;

namespace Pomodoro
{
    public class TimeKeeper
    {
        private DateTime _startTime;
        private DateTime _endTime;

        public TimeKeeper(TimeSpan timeSpan)
        {
            _startTime = DateTime.UtcNow;
            _endTime = DateTime.UtcNow + timeSpan;
        }

        public IEnumerable<TimeData> TimeData()
        {
            while (true)
            {
                var elapsed = DateTime.UtcNow - _startTime;
                var remaining = _endTime - DateTime.UtcNow;
                yield return new TimeData(elapsed.TotalMilliseconds, remaining.TotalMilliseconds);
            }
        }
    }
}
