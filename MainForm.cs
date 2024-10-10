
using NAudio.Wave;
using System.IO;
using System.Media;

namespace AlarmClock
{
    public partial class MainForm : Form
    {
        bool clockOn = false;

        SoundPlayer alarmSound = new SoundPlayer(Directory.GetCurrentDirectory() + @"\MV27TES-alarm.wav");



        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateClock();
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }
        private void UpdateClock()
        {

            string currentDate = DateTime.Now.ToString("HH:mm:ss");
            string[] date = currentDate.Split(':');

            lblClockHours.Text = date[0];
            lblMintues.Text = date[1];
            lblSeconds.Text = date[2];

            // if the alarm is 'off' don't need to compare hours and minutes
            if (!clockOn) return;
            if (alarmHours.Text == date[0] && date[1] == alarmMinutes.Text && date[2] == "00")
            {
                alarmSound.Play();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clockOn = !clockOn;
            updateButtonByFlag();
        }

        void updateButtonByFlag()
        {
            if (clockOn)
            {
                alarmBtn.Text = "on";
                alarmBtn.BackColor = Color.Green;
            }
            else
            {
                alarmSound.Stop();

                alarmBtn.Text = "off";
                alarmBtn.BackColor = Color.Red;
            }
        }

        private void alarmHours_TextChanged(object sender, EventArgs e)
        {
            inputValidation(alarmHours);
        }

        private void alarmMinutes_TextChanged(object sender, EventArgs e)
        {
            inputValidation(alarmMinutes);

        }

        private void inputValidation(TextBox textBox)
        {
            // Get the current text in the textbox
            string currentText = textBox.Text;

            // Try to parse the text as an integer
            if (int.TryParse(currentText, out int time))
            {
                if(textBox.Name == "alarmHours")
                {
                    // If the hour is out of range (0-23), show an error or adjust the text
                    if (time < 0 || time > 23)
                    {
                        textBox.Text = "00"; // Clear the textbox or set to a valid default
                                                     // Optionally, you can show a message to the user
                    }
                }
                else
                {
                    if (time < 0 || time > 59)
                    {
                        textBox.Text = "00";                                                      
                    }
                }
              
            }
            else
            {
                // If the input is not a valid number, clear the textbox or handle it as needed
                textBox.Text = "00"; // Clear the textbox or set to a valid default
            }

            // Optionally, set the caret to the end of the text
            textBox.SelectionStart = textBox.Text.Length;
        }


    }

}