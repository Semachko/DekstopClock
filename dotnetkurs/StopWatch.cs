using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace dotnetkurs
{
    public partial class MainCode : Form
    {
        Pen stopwatchPen = new Pen(Color.White, 4);
        //Змінна для працювання секундоміра
        private bool stopwatchWorking = false;
        private DateTime startTime;
        private TimeSpan timeElapsed;
        private void tabPage2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // 17/2 - радіус точки у центрі
            int dotX = pictureBox2.Location.X + centerX - 17 / 2;
            int dotY = pictureBox2.Location.Y + centerY - 17 / 2;
            //Малюється основа секундоміра
            g.FillEllipse(new SolidBrush(Color.FromArgb(255, 30, 30, 30)), pictureBox2.Location.X + centerX - clockRadius, pictureBox2.Location.Y + centerY - clockRadius, 2 * clockRadius, 2 * clockRadius);
            //Малюється точка у центрі
            g.FillEllipse(new SolidBrush(Color.White), dotX - 1, dotY, 17, 17);
            //Малюємо оправу секундоміра
            g.DrawEllipse(new Pen(Color.FromArgb(255, 244, 0), 8), pictureBox2.Location.X + centerX - clockRadius, pictureBox2.Location.Y + centerY - clockRadius, 2 * clockRadius, 2 * clockRadius);
            //Шрифт для малювання чисел
            Font numberFont = new Font(Font.FontFamily, 20, FontStyle.Regular);
            for (int i = 1; i <= 60; i++)
            {
                // На годиннику всього 60 міток, відстань між ними 360/60=6 градусів
                double angleRadians = i * 6 * Math.PI / 180;
                int markX = pictureBox2.Location.X + centerX + (int)((clockRadius - 20) * Math.Sin(angleRadians));
                int markY = pictureBox2.Location.Y + centerY - (int)((clockRadius - 20) * Math.Cos(angleRadians));
                //Малювання більших міток навпроти чисел секундоміра (відстань між числами = 30 градусів, тобто кожну 5у ітерацію)
                int endRadius = (i % 5 == 0) ? clockRadius - 35 : clockRadius - 30;
                int endX = pictureBox2.Location.X + centerX + (int)(endRadius * Math.Sin(angleRadians));
                int endY = pictureBox2.Location.Y + centerY - (int)(endRadius * Math.Cos(angleRadians));

                g.DrawLine(new Pen(Color.FromArgb(255, 244, 0), 3), markX, markY, endX, endY);

                if (i % 5 == 0)
                {
                    //Отримуэмо дані про число яке будемо малювати, щоб потім корректно його розмістити
                    SizeF numberSize = g.MeasureString(i.ToString(), numberFont);
                    float numberX = pictureBox2.Location.X + centerX + (int)((clockRadius - 57) * Math.Sin(angleRadians)) - numberSize.Width / 2;
                    float numberY = pictureBox2.Location.Y + centerY - (int)((clockRadius - 57) * Math.Cos(angleRadians)) - numberSize.Height / 2;
                    g.DrawString(i.ToString(), numberFont, Brushes.White, numberX, numberY);
                }
            }
        }
        //Кнопка старту секундоміра
        private void StartStopButton_Click(object sender, EventArgs e)
        {
            //Якщо секундомір вже працює
            if (stopwatchWorking)
            {
                //Змінюємо назву кнопки та призупиняємо роботу секундоміра
                StartStopButton.Text = "Продовжити";
                stopwatchWorking = false;
            }
            //Якщо секундомір не працював або на паузі
            else
            {
                //Визначаємо початковий час. Якщо секундомір був на паузі, то початковий час визначемо через різницю поточного та часу що пройшов
                startTime = DateTime.Now - timeElapsed;
                //Вмикаємо кнопку скидання часу та змінюємо текст поточної кнопки
                RefreshButton.Enabled = true;
                RefreshButton.BackColor = Color.White;
                StartStopButton.Text = "Стоп";
                //Вмикаємо змінну для працювання секундоміра та створюємо потік для його роботи
                stopwatchWorking = true;
                Thread thread = new Thread(new ThreadStart(StopWatch));
                thread.Start();
            }
        }
        // Кнопка скидання роботи секундоміра
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            //Зупиняємо роботу секундоміра, встановлюємо початковий текст для кнопок та скидаємо час що пройшов
            stopwatchWorking = false;
            StartStopButton.Text = "Старт";
            stopwatchTime.Text = "00:00:000";
            timeElapsed = new TimeSpan();
            RefreshButton.Enabled = false;
            RefreshButton.BackColor = Color.LightGray;
            //Оновлюємо стрілку секундоміра
            pictureBox2.Invalidate();
        }
        private void StopWatch()
        {
            try
            {
                while (stopwatchWorking)
                {
                    //Викликаємо головний потік щоб внести зміни на форму
                    Invoke(new Action(() =>
                    {
                        //Дізнаємося час що пройшов з початку роботи секундоміра, встановлюємо відповідний текст та оновлюємо стрілки секундоміра
                        timeElapsed = DateTime.Now - startTime;
                        stopwatchTime.Text = $"{timeElapsed.TotalMinutes:00}:{timeElapsed.Seconds:00}:{timeElapsed.Milliseconds:000}";
                        pictureBox2.Invalidate();
                    }));
                    //Призупиняємо потік на 10 мілісекунд
                    Thread.Sleep(10);
                }
            }
            catch (Exception) { }
        }
        // Малювання стрілки секундоміра
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // У секундомірі 60 міток, тому знаходимо модуль від часу що пройшов та множимо на 6,
            double angleDegrees = timeElapsed.TotalSeconds % 60 * 6;
            int endX = centerX + (int)((clockRadius - 40) * Math.Sin(angleDegrees * Math.PI / 180));
            int endY = centerY - (int)((clockRadius - 40) * Math.Cos(angleDegrees * Math.PI / 180));
            int tailX = centerX + (int)(30 * Math.Sin((angleDegrees + 180) * Math.PI / 180));
            int tailY = centerY - (int)(30 * Math.Cos((angleDegrees + 180) * Math.PI / 180));
            //Малюємо стрілку з хвостиком
            g.DrawLine(stopwatchPen, tailX, tailY, endX, endY);
        }

    }
}
