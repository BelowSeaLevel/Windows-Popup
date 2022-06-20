using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Set_PopUp_Reminder
{
    public partial class FormPopUpReminder : Form
    {
        private string titleText;
        private string informationText;

        private System.Timers.Timer timer;

        private DateTime date;
        private int dateTimeHour;
        private int dateTimeMinute;
        
        private DateTimePicker timePicker;

        private bool textboxesValid = false;

        public FormPopUpReminder()
        {
            InitializeComponent();
            SetTimePicker();

            // If the user does not change the value's,
            // It will pick the default value's from the DateTimePicker's
            date = DateTimePicker.Value.Date;
            dateTimeHour = DateTimePickerTime.Value.Hour;
            dateTimeMinute = DateTimePickerTime.Value.Minute;
        }


        /// <summary>
        /// Sets the DateTimePicker to a TimePicker. (Will only let you select Time)
        /// </summary>
        private void SetTimePicker()
        {
            timePicker = DateTimePickerTime;
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Width = 100;
        }

        /// <summary>
        /// Button to set the reminder.
        /// </summary>
        private void ButtonSetReminder_Click(object sender, EventArgs e)
        {
            CheckTextBoxes();
            
            if(textboxesValid == true)
            {
                SetBalloon();
                TimerEvent();
                MessageBox.Show("Timer has been set.");
            }
            
        }

        /// <summary>
        /// Makes the timer tick,
        /// will fire the CheckForBalloonFireEvent every 3000 milliseconds
        /// </summary>
        private void TimerEvent()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;

            timer.Elapsed += CheckForBalloonFireEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        /// <summary>
        /// Checks or it needs to fire the ShowBalloonEvent.
        /// </summary>
        private void CheckForBalloonFireEvent(object source, EventArgs e)
        {
            if (DateTime.Now.Date == date)
            {
                if (DateTime.Now.Hour == dateTimeHour)
                {
                    if (DateTime.Now.Minute == dateTimeMinute)
                    {
                        timer.Elapsed += ShowBalloonEvent;
                    }
                }
            }

        }

        /// <summary>
        /// Set up the Balloon.
        /// </summary>
        private void SetBalloon()
        {
            notifyIcon1.Icon = SystemIcons.Exclamation;
            notifyIcon1.BalloonTipTitle = titleText;
            notifyIcon1.BalloonTipText = informationText;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            //Click += new EventHandler(ButtonSetReminder_Click);
        }


        /// <summary>
        /// Check the textboxes. And assign them to variables.
        /// </summary>
        private void CheckTextBoxes()
        {
            if(TextBoxTitle.Text != "" && TextBoxInformation.Text != "")
            {
                titleText = TextBoxTitle.Text;
                informationText = TextBoxInformation.Text;

                textboxesValid = true;
            }
            else
            {
                MessageBox.Show("A field is empty!");
                textboxesValid = false;
                TextBoxTitle.Text = null;
                TextBoxInformation.Text = null;
            }
        }

        /// <summary>
        /// Will show the balloon
        /// </summary>
        private void ShowBalloonEvent(object source, EventArgs e)
        {
            timer.Stop();


            notifyIcon1.Visible = true;
            if (TextBoxTitle.Text != "" && TextBoxInformation.Text != "")
            {
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        /// <summary>
        /// Sets the date variable to the DateTimePicker.
        /// </summary>
        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Set date to the value of the DateTimePicker.
            date = DateTimePicker.Value.Date;
        }

        /// <summary>
        /// Sets the Hour and Minute from the TimePicker.
        /// </summary>
        private void DateTimePickerTime_ValueChanged(object sender, EventArgs e)
        {
            dateTimeHour = DateTimePickerTime.Value.Hour;
            dateTimeMinute = DateTimePickerTime.Value.Minute;
        }

        private void FormPopUpReminder_Load(object sender, EventArgs e)
        {

        }
    }
}
