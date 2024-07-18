using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitalclock
{
    public class DigitalClockFunctions
    {
        private readonly Form1 _form;

        // Constructor accepting Form1 instance
        public DigitalClockFunctions(Form1 form)
        {
            _form = form;
        }
        //function to display appropriate greeting text to user based on the time
        public void GreetingText()
        {
            DateTime now = DateTime.Now;
            DateTime noon = new DateTime(now.Year, now.Month, now.Day, 12, 0, 0);
            DateTime evening = new DateTime(now.Year, now.Month, now.Day, 18, 0, 0);

            if (now < noon)
            {
                _form.Greetingtxt.Text = "Good Morning";
            }
            else if (now < evening)
            {
                _form.Greetingtxt.Text = "Good Afternoon";
            }
            else
            {
                _form.Greetingtxt.Text = "Good Evening";
            }
        }
        public void UpdateTimeForCity(string cityName)
        {
            DateTime cityTime;

            // Convert local time to the selected city's time zone
            switch (cityName)
            {
                case "Lagos (Local Clock)":
                    cityTime = DateTime.Now; // Replace with correct timezone ID
                    break;
                case "Paris":
                    cityTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time")); // Replace with correct timezone ID
                    break;
                case "Vietnam":
                    cityTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time")); // Replace with correct timezone ID for Vietnam
                    break;
                case "Los Angeles":
                    cityTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time")); // Replace with correct timezone ID
                    break;
                case "Hong Kong":
                    cityTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("China Standard Time")); // Replace with correct timezone ID
                    break;
                default:
                    cityTime = DateTime.Now; // Default to local time if city is not found
                    break;
            }

            // Update the main time display in Form1
            _form.timetxt.Text = cityTime.ToString("hh:mm:ss tt");
        }
    }
}
