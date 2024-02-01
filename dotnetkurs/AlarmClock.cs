using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace dotnetkurs
{
    public partial class MainCode : Form
    {
        //Додавання будильника
        private void AddAlarmButton_Click(object sender, EventArgs e)
        {
            //Створюємо змінну для зберігання дати будильника та зчитуємо значення з полів
            Mydate alarm = new Mydate();
            alarm.time = timePicker.Value;
            //Якщо обрали точну дату будильника
            if (tabControl2.SelectedIndex == 0)
            {
                //Заповнюємо нову змінну, додаємо до загальної змінної наш будильник щоб потім його зберегти
                alarm.date = datePicker.Value;
                alarm.dayofweek = null;
                alarmDates.Add(alarm);
                //Виводимо будильник у список
                listAlarms.Items.Add($"{alarm.date:dd.MM.yyyy}, {alarm.time:HH:mm}");
            }
            //Якщо обрали будильник на день тижня
            else
            {
                alarm.dayofweek = (DayOfWeek)int.Parse(dayPicker.SelectedIndex.ToString()) + 1;
                alarmDates.Add(alarm);
                listAlarms.Items.Add($"{alarm.dayofweek}, {alarm.time:HH:mm}");
            }
            //Зберігаємо список з новим будильником у файл
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fileStream = new FileStream("Alarm.dat", FileMode.Create))
            {
                formatter.Serialize(fileStream, alarmDates);
            }
        }

        //Видалення будильника
        private void DeleteAlarmButton_Click(object sender, EventArgs e)
        {
            //Якщо будильник обран
            if (listAlarms.SelectedIndex != -1)
            {
                //Прибираємо вказаний будильник зі списку за загальної змінни
                alarmDates.RemoveAt(listAlarms.SelectedIndex);
                listAlarms.Items.RemoveAt(listAlarms.SelectedIndex);
                //Зберігаємо оновленний список будильників у файл
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fileStream = new FileStream("Alarm.dat", FileMode.Create))
                {
                    formatter.Serialize(fileStream, alarmDates);
                }
            }
        }

        //Метод, який викликається у час настання будильників
        private void AlarmWorking(Mydate time)
        {
            //Запускаємо звуковий сигнал
            alarmSound.Play();
            //В залежності від типу будильника виводимо його текст на екран та відображаємо кнопку для його вимкнення
            if (time.dayofweek == null)
                currentAlarm.Text = $"{time.date:dd.MM.yyyy}, {time.time:HH:mm}";
            else
                currentAlarm.Text = $"{time.dayofweek}, {time.time:HH:mm}";
            panelAlarm.Visible = true;
            currentAlarm.Visible = true;
            turnOffAlarmButton.Visible = true;
        }
        //Кнопка вимикання будильника
        private void turnOffAlarmButton_Click(object sender, EventArgs e)
        {
            alarmSound.Stop();
            panelAlarm.Visible = false;
            currentAlarm.Visible = false;
            turnOffAlarmButton.Visible = false;
        }

    }
}
