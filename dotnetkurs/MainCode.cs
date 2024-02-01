using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace dotnetkurs
{
    public partial class MainCode : Form
    {
        //Серіалізований клас що зберігає будильники
        [Serializable]
        class Mydate
        {
            public DateTime date;
            public DateTime time;
            public DayOfWeek? dayofweek;
        }
        //Змінна що буде зберігати будильники під час роботи програми
        private List<Mydate> alarmDates = new List<Mydate>();
        //Звукові сигнали відповідно для таймеру та будильнику
        private SoundPlayer timerSound = new SoundPlayer("alarmsound.wav");
        private SoundPlayer alarmSound = new SoundPlayer("alarmsound.wav");
        public MainCode() { InitializeComponent(); }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            try
            {
                if (File.Exists("Alarm.dat"))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fileStream = new FileStream("Alarm.dat", FileMode.Open))
                    {
                        //Зчитуємо всі будильники з файлу у загальну змінну
                        alarmDates = (List<Mydate>)formatter.Deserialize(fileStream);
                        foreach (var item in alarmDates)
                        {
                            //В залежності від типу будильника відображаєм його у списку відповідним чином
                            if (item.dayofweek == null)
                                listAlarms.Items.Add($"{item.date:dd.MM.yyyy}, {item.time:HH:mm}");
                            else
                                listAlarms.Items.Add($"{item.dayofweek}, {item.time:HH:mm}");
                        }
                    }
                }
            }
            catch { }
            lateTimeTimer.Text = "";
            centerX = pictureBox1.Width / 2;
            centerY = pictureBox1.Height / 2;
            clockRadius = Math.Min(centerX, centerY) - 10;
            //Створюємо потік який буде обчислювати поточний час та перевіряти будильники
            Thread thread = new Thread(new ThreadStart(UpdateTime));
            thread.Start();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            clockWorking = false;
            stopwatchWorking = false;
            timerWorking = false;
        }
    }
}


