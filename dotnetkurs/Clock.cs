using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace dotnetkurs
{
    public partial class MainCode : Form
    {
        int centerX;
        int centerY;
        int clockRadius;
        Pen hourPen = new Pen(Color.White, 9);
        Pen minPen = new Pen(Color.White, 7);
        Pen secPen = new Pen(Color.White, 4);
        private bool clockWorking = true;

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // 23/2 - радіус точки у центрі годинника
            int dotX = pictureBox1.Location.X + centerX - 23 / 2;
            int dotY = pictureBox1.Location.Y + centerY - 23 / 2;
            //Малюється основа годинника темним кольором
            g.FillEllipse(new SolidBrush(Color.FromArgb(255, 30, 30, 30)), pictureBox1.Location.X + centerX - clockRadius, pictureBox1.Location.Y + centerY - clockRadius, 2 * clockRadius, 2 * clockRadius);
            //Малюємо центральну точку
            g.FillEllipse(Brushes.White, dotX - 1, dotY, 23, 23);
            //Малюємо оправу годинника
            g.DrawEllipse(new Pen(Color.White, 10), pictureBox1.Location.X + centerX - clockRadius, pictureBox1.Location.Y + centerY - clockRadius, 2 * clockRadius, 2 * clockRadius);
            //Малюємо смужки годин
            for (int i = 0; i < 12; i++)
            {
                // 360/12=30, знаходимо кут кожної смужки та переводимо цей кут у радіани
                double angleRadians = i * 30 * Math.PI / 180;
                int markX = pictureBox1.Location.X + centerX + (int)((clockRadius - 70) * Math.Sin(angleRadians));
                int markY = pictureBox1.Location.Y + centerY - (int)((clockRadius - 70) * Math.Cos(angleRadians));
                int endX = pictureBox1.Location.X + centerX + (int)((clockRadius - 60) * Math.Sin(angleRadians));
                int endY = pictureBox1.Location.Y + centerY - (int)((clockRadius - 60) * Math.Cos(angleRadians));

                g.DrawLine(secPen, markX, markY, endX, endY);
            }
        }
        private void UpdateTime()
        {
            try
            {
                while (clockWorking)
                {
                    DateTime currentTime = DateTime.Now;
                    //Викликаємо головний потік щоб внести зміни на форму
                    Invoke(new Action(() =>
                    {
                        //Встановлюємо поточну дату та час
                        date.Text = currentTime.ToString("D", new CultureInfo("uk-UA"));
                        defaultTime.Text = currentTime.ToString("HH:mm:ss");
                        //Викликаємо перемалювання годинникових стрілок
                        pictureBox1.Invalidate();

                        //Цикл що перевіряє чи настав час кожного годинника
                        foreach (var item in alarmDates)
                        {
                            //Якщо поточний час та дата співпадає з якимось будильником, то викликаємо метод зі звуковим сигналом
                            if (currentTime.ToString("hh:mm:ss") == item.time.ToString("hh:mm:ss"))
                                if (item.dayofweek == null && (currentTime.ToString("dd.MM.yyyy") == item.date.ToString("dd.MM.yyyy") || currentTime.DayOfWeek == item.dayofweek))
                                    AlarmWorking(item);
                        }

                    }));
                    //Призупиняємо потік на 1 секунду
                    Thread.Sleep(1000);
                }
            }
            catch (Exception) { }
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            DateTime currentTime = DateTime.Now;
            int hours = currentTime.Hour % 12;
            int minutes = currentTime.Minute;
            int seconds = currentTime.Second;
            //Знаходиму поточний кут стрілок. (Кожна година знаходиться через 30 градусів, додаємо додаткові хвилини (оскільки між годинами 30 градусів, то ділимо хвилини навпіл))
            int hourAngle = hours * 30 + minutes / 2;
            DrawClockHand(g, centerX, centerY, hourAngle, clockRadius - 100, hourPen);
            //У відстані між малими смужками годинника = 6 градусів
            int minuteAngle = minutes * 6;
            DrawClockHand(g, centerX, centerY, minuteAngle, clockRadius - 78, minPen);
            int secondAngle = seconds * 6;
            DrawClockHand(g, centerX, centerY, secondAngle, clockRadius - 70, secPen);
        }
        private void DrawClockHand(Graphics g, int centerX, int centerY, int angleDegrees, int length, Pen pen)
        {
            //Переводиму градуси у радіани
            double angleRadians = angleDegrees * Math.PI / 180;
            int handX = centerX + (int)(length * Math.Sin(angleRadians));
            int handY = centerY - (int)(length * Math.Cos(angleRadians));
            g.DrawLine(pen, centerX, centerY, handX, handY);
        }
    }
}
