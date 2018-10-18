using System;
using System.Collections.Generic;
using System.Text;

namespace Pomodoro.Util
{
    public class Configuration
    {
        public static TimeSpan WorkTime { get; private set; }
        public static TimeSpan PauseTime { get; private set; }

        static Configuration()
        {
            WorkTime = TimeSpan.FromMinutes(25);
            PauseTime = TimeSpan.FromMinutes(5);
        }
        
    }
}
