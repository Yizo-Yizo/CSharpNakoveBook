using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    public class GSMCallHistoryTest
    {
       public void PrintCallHistory()
        {
            GSM gsm = new GSM();

            // Create some call records
            Call call1 = new Call(DateTime.Now.Date, DateTime.Now.Subtract(TimeSpan.FromMinutes(30)), TimeSpan.FromMinutes(10));
            Call call2 = new Call(DateTime.Now.Subtract(TimeSpan.FromDays(1)), DateTime.Now.Subtract(TimeSpan.FromMinutes(30)), TimeSpan.FromMinutes(20));
            Call call3 = new Call(DateTime.Now.Subtract(TimeSpan.FromDays(2)), DateTime.Now.Subtract(TimeSpan.FromMinutes(30)), TimeSpan.FromMinutes(30));

            // Add calls to the GSM call history
            gsm.AddCall(call1);
            gsm.AddCall(call2);
            gsm.AddCall(call3);

            // Display information about each call
            Console.WriteLine(gsm.CallInfo(call1));
            Console.WriteLine(gsm.CallInfo(call2));
            Console.WriteLine(gsm.CallInfo(call3));

            // Calculate and display the total cost of all calls
            double pricePerMinute = 0.37d;
            Console.WriteLine("Total cost of calls: {0:F2}", gsm.CalculateTotalAmount(pricePerMinute));

            // Remove the longest call and recalculate the total cost
            gsm.RemoveLongestCall();
            Console.WriteLine("\nLongest call removed.");
            Console.WriteLine("Total cost of calls after removal: {0:F2}", gsm.CalculateTotalAmount(pricePerMinute));

            // Clear the call history
            gsm.ClearCallHistory();
            Console.WriteLine("\nCall history cleared.");
            Console.WriteLine("Total cost of calls after clearing: {0:F2}", gsm.CalculateTotalAmount(pricePerMinute));


        }
        
    }
}
