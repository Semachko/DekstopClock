using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace dotnetkurs
{
    public partial class MainCode : Form
    {
        //Змінні для працювання таймера та працювання звукового сигналу
        private bool timerWorking = false;
        private bool doesAlarmSound = false;
        Pen timerPen = new Pen(Color.White, 2);
        //Змінні для підрахунку часу
        private DateTime totalTime = DateTime.Now;
        private TimeSpan totalduration = new TimeSpan(0, 0, 1);
        private TimeSpan currentTime;
        //Малювання таймера
        private void tabPage3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int dotX = pictureBox3.Location.X + centerX - 17 / 2;
            int dotY = pictureBox3.Location.Y + centerY - 17 / 2;
            g.FillEllipse(new SolidBrush(Color.FromArgb(255, 30, 30, 30)), pictureBox3.Location.X + centerX - clockRadius, pictureBox3.Location.Y + centerY - clockRadius, 2 * clockRadius, 2 * clockRadius);
            g.FillEllipse(new SolidBrush(Color.White), dotX - 1, dotY, 17, 17);
            g.DrawEllipse(new Pen(Color.FromArgb(48, 213, 200), 8), pictureBox3.Location.X + centerX - clockRadius, pictureBox3.Location.Y + centerY - clockRadius, 2 * clockRadius, 2 * clockRadius);
            for (int i = 1; i <= 60; i++)
            {
                //Малювання міток
                double angleRadians = i * 6 * Math.PI / 180;
                int markX = pictureBox3.Location.X + centerX + (int)((clockRadius - 30) * Math.Sin(angleRadians));
                int markY = pictureBox3.Location.Y + centerY - (int)((clockRadius - 30) * Math.Cos(angleRadians));
                int endX = pictureBox3.Location.X + centerX + (int)((clockRadius - 20) * Math.Sin(angleRadians));
                int endY = pictureBox3.Location.Y + centerY - (int)((clockRadius - 20) * Math.Cos(angleRadians));

                g.DrawLine(new Pen(Color.FromArgb(48, 213, 200), 2), markX, markY, endX, endY);
            }
            //Малювання числа 0
            Font numberFont = new Font(Font.FontFamily, 24, FontStyle.Regular);
            SizeF numberSize = g.MeasureString(0.ToString(), numberFont);
            float numberX = pictureBox3.Location.X + centerX + (int)((clockRadius - 55) * Math.Sin(60 * 6 * Math.PI / 180)) - numberSize.Width / 2;
            float numberY = pictureBox3.Location.Y + centerY - (int)((clockRadius - 55) * Math.Cos(60 * 6 * Math.PI / 180)) - numberSize.Height / 2;
            g.DrawString(0.ToString(), numberFont, Brushes.White, numberX, numberY);
        }

        //Кнопка запуску таймера
        private void StartStopTimer_Click(object sender, EventArgs e)
        {
            //Якщо таймер вже працює
            if (timerWorking)
            {
                //Якщо звуковий сигнал працює, то зупиняємо його
                if (doesAlarmSound)
                    timerSound.Stop();
                //Встанововлюємо новий текст кнопки та зупиняємо таймер
                StartStopTimer.Text = "Продовжити";
                timerWorking = false;
            }
            //Якщо таймер не працює або він зупинений
            else
            {
                try
                {
                    //Якщо таймер не працював (У початковому стані поля для вводу часу доступні)
                    if (hourText.ReadOnly == false)
                    {
                        //Зчитуємо час, скидаємо звуковий сигнал та зберігаємо засіченний час
                        TimeSpan.TryParse(hourText.Text + ":" + minuteText.Text + ":" + secondText.Text, out currentTime);
                        totalduration = currentTime;
                        doesAlarmSound = false;
                    }
                    //Відповідно змінюємо вигляд кнопок
                    StartStopTimer.Text = "Стоп";
                    refreshTimerButton.Enabled = true;
                    refreshTimerButton.BackColor = Color.White;
                    //Запускаємо таймер, та встановлюємо до якого часу повинен працювати таймер
                    timerWorking = true;
                    totalTime = DateTime.Now + currentTime;
                    hourText.ReadOnly = true;
                    minuteText.ReadOnly = true;
                    secondText.ReadOnly = true;
                    Thread thread = new Thread(() => StartTimer());
                    thread.Start();
                }
                catch { MessageBox.Show("Введіть коректний час."); }
            }
        }
        private void refreshTimerButton_Click(object sender, EventArgs e)
        {
            if (doesAlarmSound)
                timerSound.Stop();
            timerWorking = false;
            refreshTimerButton.Enabled = false;
            refreshTimerButton.BackColor = Color.LightGray;
            hourText.Text = "00";
            minuteText.Text = "00";
            secondText.Text = "00";
            lateTimeTimer.Text = "";
            StartStopTimer.Text = "Старт";
            hourText.ReadOnly = false;
            minuteText.ReadOnly = false;
            secondText.ReadOnly = false;
            totalduration = new TimeSpan(0, 0, 1);
            currentTime = new TimeSpan(0, 0, 0);
            pictureBox3.Invalidate();
        }

        private void StartTimer()
        {
            try
            {
                while (timerWorking)
                {
                    Invoke(new Action(() =>
                    {
                        if (timerWorking)
                        {
                            //Взнаємо скільки таймеру залишилось працювати
                            currentTime = totalTime - DateTime.Now;
                            if (currentTime.TotalMilliseconds > 0)
                            {
                                //Оновлюємо значення таймера та перемалювуємо стрілку
                                hourText.Text = $"{currentTime.TotalHours:00}";
                                minuteText.Text = $"{currentTime.TotalMinutes:00}";
                                secondText.Text = $"{currentTime.Seconds:00}";
                                pictureBox3.Invalidate();
                            }
                            //Якщо таймер закінчився, то відображаємо червоний таймер, та один раз запускаємо звуковий сигнал
                            else
                            {
                                if (!doesAlarmSound)
                                {
                                    doesAlarmSound = true;
                                    timerSound.Play();
                                }
                                lateTimeTimer.Text = $"- {Math.Abs(currentTime.Hours):00}:{Math.Abs(currentTime.Minutes):00}:{Math.Abs(currentTime.Seconds):00}";
                            }
                        }
                    }));
                    Thread.Sleep(10);
                }
            }
            catch (Exception) { }
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Знаходимо частку від ділення часу що залишилось на весь час що ми повинні пройти. Оскільки йдемо за год. стрілкою, то віднімаємо від 1
            double angleDegrees = (1 - (currentTime.TotalSeconds / totalduration.TotalSeconds)) * 360;

            int endX = centerX + (int)((clockRadius - 35) * Math.Sin(angleDegrees * Math.PI / 180));
            int endY = centerY - (int)((clockRadius - 35) * Math.Cos(angleDegrees * Math.PI / 180));
            int tailX = centerX + (int)(30 * Math.Sin((angleDegrees + 180) * Math.PI / 180));
            int tailY = centerY - (int)(30 * Math.Cos((angleDegrees + 180) * Math.PI / 180));

            g.DrawLine(timerPen, tailX, tailY, endX, endY);
        }
    }
}
