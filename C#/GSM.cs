using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class GSM
    {
        // Ch 14 No. 17
        // Property to keep the call history
        public List<Call> CallHistory { get; private set; } = new List<Call>();

        // Method to add a call to the call history
        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        // Method to delete a specific call from the call history
        public void DeleteCall(Call call)
        {
            CallHistory.Remove(call);
        }

        // Method to clear all calls from the call history
        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        // Ch 14 No. 18
        public double CalculateTotalAmount(double pricePerMinute)
        {
            double totalAmount = 0;

            foreach (var call in CallHistory)
            {
                totalAmount += (call.Duration.TotalMinutes * pricePerMinute);
            }

            return totalAmount;
        }

        public void RemoveLongestCall()
        {
            if (CallHistory.Count == 0) return;

            Call longestCall = CallHistory[0];

            foreach (var call in CallHistory)
            {
                if (call.Duration > longestCall.Duration)
                {
                    longestCall = call;
                }
            }

            DeleteCall(longestCall);
        }
        // Ch 14 No. 19
        public string CallInfo(Call call)
        {
            return string.Format("Date: \t{0}\n" +
                "Start time: \t{1}\n" +
                "Duration: \t{2}", call.Date, call.StartTime, call.Duration);

        }
        // Ch 14 No. 12
        public string MobilePhoneInfo(MobilePhone phone)
        {
            return string.Format("Model: \t{0}\n" +
                "Manufacturer: \t{1}\n" +
                "Price: \t{2}\n" +
                "Owner: \t{3}\n" +
                "Battery model: \t{4}\n" +
                "Battery idle time: \t{5}\n" +
                "Batter hours talk: \t{6}\n" +
                "Screen size: \t{7}\n" +
                "Screen color: \t{8}", phone?.Model, phone?.Manufacturer, phone?.Price, phone?.Owner,phone?.BatteryFeatures?.Model, phone?.BatteryFeatures?.IdleTime,
                phone?.BatteryFeatures?.HoursTalk, phone?.DispalyFeatures?.Size, phone?.DispalyFeatures?.Color);

        }
    }
}
