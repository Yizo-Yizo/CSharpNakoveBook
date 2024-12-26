using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class Battery
    {
        public string Model { get; set; }
        public TimeSpan IdleTime { get; set; }
        public TimeSpan HoursTalk { get; set; }
        public BatteryType TypeOfBattery { get; set; }

        public Battery(string model, TimeSpan idleTime, TimeSpan hoursTalk, BatteryType typeOfBattery)
        {
            Model = model;
            IdleTime = idleTime;
            HoursTalk = hoursTalk;
            TypeOfBattery = typeOfBattery;
        }

        public enum BatteryType
        {
            LiIon, NiMH, NiCd
        }
    }
}
