using System;
using System.Windows.Forms;

namespace Digitalclock
{
    public partial class Form1 : Form
    {
        private readonly DigitalClockFunctions _digitalClockFunctions;
        private readonly Timer _timer;

        public Form1()
        {
            InitializeComponent();

            // Initialize timer for regular updates
            _timer = new Timer
            {
                Interval = 1000 // 1 second interval
            };
            _timer.Tick += Timer_Tick;

            // Initialize digital clock functions
            _digitalClockFunctions = new DigitalClockFunctions(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Start timer and initial updates
            _timer.Start();
            UpdateCityTimes();
            _digitalClockFunctions.GreetingText();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update city times every timer tick
            UpdateCityTimes();
        }

        private void UpdateCityTimes()
        {
            string selectedCity = citylist.SelectedItem?.ToString();
            if (selectedCity != null)
            {
                _digitalClockFunctions.UpdateTimeForCity(selectedCity); // Update time based on selected city
                placaname.Text = selectedCity; // Update place name label
            }
            else
            {
                // Default to update local time for Lagos if no city is selected (initial load)
                _digitalClockFunctions.UpdateTimeForCity("Lagos (Local Clock)");
                placaname.Text = "Lagos (Local Clock)";
            }
        }

        private void Citylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update city times when ComboBox selection changes
            UpdateCityTimes();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
}
