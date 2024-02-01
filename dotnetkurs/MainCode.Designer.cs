using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace dotnetkurs
{
    partial class MainCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.date = new System.Windows.Forms.Label();
            this.defaultTime = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stopwatchTime = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.refreshTimerButton = new System.Windows.Forms.Button();
            this.lateTimeTimer = new System.Windows.Forms.Label();
            this.secondText = new System.Windows.Forms.TextBox();
            this.minuteText = new System.Windows.Forms.TextBox();
            this.StartStopTimer = new System.Windows.Forms.Button();
            this.hourText = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panelAlarm = new System.Windows.Forms.Panel();
            this.turnOffAlarmButton = new System.Windows.Forms.Button();
            this.currentAlarm = new System.Windows.Forms.Label();
            this.DeleteAlarmButton = new System.Windows.Forms.Button();
            this.AddAlarmButton = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dayPicker = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.listAlarms = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panelAlarm.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(33, 17);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(895, 606);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.date);
            this.tabPage1.Controls.Add(this.defaultTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 82);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(887, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Годинник";
            this.tabPage1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage1_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(100, 297);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 35);
            this.label12.TabIndex = 14;
            this.label12.Text = "8";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(150, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 35);
            this.label11.TabIndex = 13;
            this.label11.Text = "7";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(92, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 35);
            this.label10.TabIndex = 12;
            this.label10.Text = "10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(142, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 35);
            this.label9.TabIndex = 11;
            this.label9.Text = "11";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(297, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 35);
            this.label8.TabIndex = 10;
            this.label8.Text = "1";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(353, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 35);
            this.label7.TabIndex = 9;
            this.label7.Text = "2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(297, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 35);
            this.label6.TabIndex = 8;
            this.label6.Text = "5";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(353, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "4";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(79, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "9";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(372, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(224, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "6";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(215, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "12";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(54, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 370);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.date.Location = new System.Drawing.Point(454, 289);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(98, 45);
            this.date.TabIndex = 1;
            this.date.Text = "date";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // defaultTime
            // 
            this.defaultTime.AutoSize = true;
            this.defaultTime.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold);
            this.defaultTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.defaultTime.Location = new System.Drawing.Point(474, 115);
            this.defaultTime.Name = "defaultTime";
            this.defaultTime.Size = new System.Drawing.Size(204, 93);
            this.defaultTime.TabIndex = 0;
            this.defaultTime.Text = "time";
            this.defaultTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.stopwatchTime);
            this.tabPage2.Controls.Add(this.RefreshButton);
            this.tabPage2.Controls.Add(this.StartStopButton);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 82);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(887, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Секундомір";
            this.tabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage2_Paint);
            // 
            // stopwatchTime
            // 
            this.stopwatchTime.AutoSize = true;
            this.stopwatchTime.BackColor = System.Drawing.Color.Transparent;
            this.stopwatchTime.Font = new System.Drawing.Font("Arial", 40F);
            this.stopwatchTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stopwatchTime.Location = new System.Drawing.Point(112, 425);
            this.stopwatchTime.Name = "stopwatchTime";
            this.stopwatchTime.Size = new System.Drawing.Size(267, 61);
            this.stopwatchTime.TabIndex = 29;
            this.stopwatchTime.Text = "00:00:000";
            this.stopwatchTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.LightGray;
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.Enabled = false;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RefreshButton.FlatAppearance.BorderSize = 8;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RefreshButton.Location = new System.Drawing.Point(528, 258);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(255, 87);
            this.RefreshButton.TabIndex = 28;
            this.RefreshButton.Text = "Скинути";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // StartStopButton
            // 
            this.StartStopButton.BackColor = System.Drawing.Color.White;
            this.StartStopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartStopButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.StartStopButton.FlatAppearance.BorderSize = 7;
            this.StartStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStopButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StartStopButton.Location = new System.Drawing.Point(528, 125);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(255, 87);
            this.StartStopButton.TabIndex = 27;
            this.StartStopButton.Text = "Старт";
            this.StartStopButton.UseVisualStyleBackColor = false;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(52, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(370, 370);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Controls.Add(this.refreshTimerButton);
            this.tabPage3.Controls.Add(this.lateTimeTimer);
            this.tabPage3.Controls.Add(this.secondText);
            this.tabPage3.Controls.Add(this.minuteText);
            this.tabPage3.Controls.Add(this.StartStopTimer);
            this.tabPage3.Controls.Add(this.hourText);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Location = new System.Drawing.Point(4, 82);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(887, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Таймер";
            this.tabPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPage3_Paint);
            // 
            // refreshTimerButton
            // 
            this.refreshTimerButton.BackColor = System.Drawing.Color.LightGray;
            this.refreshTimerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshTimerButton.Enabled = false;
            this.refreshTimerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.refreshTimerButton.FlatAppearance.BorderSize = 8;
            this.refreshTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshTimerButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.refreshTimerButton.Location = new System.Drawing.Point(526, 368);
            this.refreshTimerButton.Name = "refreshTimerButton";
            this.refreshTimerButton.Size = new System.Drawing.Size(252, 71);
            this.refreshTimerButton.TabIndex = 37;
            this.refreshTimerButton.Text = "Скинути";
            this.refreshTimerButton.UseVisualStyleBackColor = false;
            this.refreshTimerButton.Click += new System.EventHandler(this.refreshTimerButton_Click);
            // 
            // lateTimeTimer
            // 
            this.lateTimeTimer.AutoSize = true;
            this.lateTimeTimer.BackColor = System.Drawing.Color.Transparent;
            this.lateTimeTimer.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Italic);
            this.lateTimeTimer.ForeColor = System.Drawing.Color.Red;
            this.lateTimeTimer.Location = new System.Drawing.Point(137, 41);
            this.lateTimeTimer.Name = "lateTimeTimer";
            this.lateTimeTimer.Size = new System.Drawing.Size(174, 44);
            this.lateTimeTimer.TabIndex = 31;
            this.lateTimeTimer.Text = "lateTimer";
            this.lateTimeTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondText
            // 
            this.secondText.BackColor = System.Drawing.Color.White;
            this.secondText.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.secondText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.secondText.Location = new System.Drawing.Point(739, 119);
            this.secondText.Name = "secondText";
            this.secondText.Size = new System.Drawing.Size(75, 69);
            this.secondText.TabIndex = 30;
            this.secondText.Text = "00";
            this.secondText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minuteText
            // 
            this.minuteText.BackColor = System.Drawing.Color.White;
            this.minuteText.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.minuteText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.minuteText.Location = new System.Drawing.Point(617, 119);
            this.minuteText.Name = "minuteText";
            this.minuteText.Size = new System.Drawing.Size(75, 69);
            this.minuteText.TabIndex = 29;
            this.minuteText.Text = "00";
            this.minuteText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartStopTimer
            // 
            this.StartStopTimer.BackColor = System.Drawing.Color.White;
            this.StartStopTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartStopTimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.StartStopTimer.FlatAppearance.BorderSize = 7;
            this.StartStopTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStopTimer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.StartStopTimer.Location = new System.Drawing.Point(526, 265);
            this.StartStopTimer.Name = "StartStopTimer";
            this.StartStopTimer.Size = new System.Drawing.Size(252, 71);
            this.StartStopTimer.TabIndex = 28;
            this.StartStopTimer.Text = "Старт";
            this.StartStopTimer.UseVisualStyleBackColor = true;
            this.StartStopTimer.Click += new System.EventHandler(this.StartStopTimer_Click);
            // 
            // hourText
            // 
            this.hourText.BackColor = System.Drawing.Color.White;
            this.hourText.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.hourText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.hourText.Location = new System.Drawing.Point(490, 119);
            this.hourText.Name = "hourText";
            this.hourText.Size = new System.Drawing.Size(75, 69);
            this.hourText.TabIndex = 5;
            this.hourText.Text = "00";
            this.hourText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(50, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(370, 370);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(483, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 82);
            this.panel1.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(610, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 82);
            this.panel2.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(571, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 63);
            this.label13.TabIndex = 32;
            this.label13.Text = ":";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(732, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(89, 82);
            this.panel3.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 40F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(695, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 63);
            this.label14.TabIndex = 33;
            this.label14.Text = ":";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage4.Controls.Add(this.panelAlarm);
            this.tabPage4.Controls.Add(this.DeleteAlarmButton);
            this.tabPage4.Controls.Add(this.AddAlarmButton);
            this.tabPage4.Controls.Add(this.tabControl2);
            this.tabPage4.Controls.Add(this.listAlarms);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 82);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(887, 520);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Будильник";
            // 
            // panelAlarm
            // 
            this.panelAlarm.Controls.Add(this.turnOffAlarmButton);
            this.panelAlarm.Controls.Add(this.currentAlarm);
            this.panelAlarm.Location = new System.Drawing.Point(438, 26);
            this.panelAlarm.Name = "panelAlarm";
            this.panelAlarm.Size = new System.Drawing.Size(422, 467);
            this.panelAlarm.TabIndex = 41;
            this.panelAlarm.Visible = false;
            // 
            // turnOffAlarmButton
            // 
            this.turnOffAlarmButton.BackColor = System.Drawing.Color.White;
            this.turnOffAlarmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turnOffAlarmButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.turnOffAlarmButton.FlatAppearance.BorderSize = 7;
            this.turnOffAlarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnOffAlarmButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.turnOffAlarmButton.Location = new System.Drawing.Point(101, 243);
            this.turnOffAlarmButton.Name = "turnOffAlarmButton";
            this.turnOffAlarmButton.Size = new System.Drawing.Size(229, 71);
            this.turnOffAlarmButton.TabIndex = 42;
            this.turnOffAlarmButton.Text = "Вимкнути";
            this.turnOffAlarmButton.UseVisualStyleBackColor = false;
            this.turnOffAlarmButton.Visible = false;
            this.turnOffAlarmButton.Click += new System.EventHandler(this.turnOffAlarmButton_Click);
            // 
            // currentAlarm
            // 
            this.currentAlarm.AutoSize = true;
            this.currentAlarm.BackColor = System.Drawing.Color.Transparent;
            this.currentAlarm.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentAlarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.currentAlarm.Location = new System.Drawing.Point(12, 163);
            this.currentAlarm.Name = "currentAlarm";
            this.currentAlarm.Size = new System.Drawing.Size(114, 55);
            this.currentAlarm.TabIndex = 42;
            this.currentAlarm.Text = "label";
            this.currentAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.currentAlarm.Visible = false;
            // 
            // DeleteAlarmButton
            // 
            this.DeleteAlarmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteAlarmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAlarmButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DeleteAlarmButton.FlatAppearance.BorderSize = 7;
            this.DeleteAlarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAlarmButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DeleteAlarmButton.Location = new System.Drawing.Point(100, 394);
            this.DeleteAlarmButton.Name = "DeleteAlarmButton";
            this.DeleteAlarmButton.Size = new System.Drawing.Size(229, 71);
            this.DeleteAlarmButton.TabIndex = 40;
            this.DeleteAlarmButton.Text = "Видалити";
            this.DeleteAlarmButton.UseVisualStyleBackColor = false;
            this.DeleteAlarmButton.Click += new System.EventHandler(this.DeleteAlarmButton_Click);
            // 
            // AddAlarmButton
            // 
            this.AddAlarmButton.BackColor = System.Drawing.Color.PaleGreen;
            this.AddAlarmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAlarmButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AddAlarmButton.FlatAppearance.BorderSize = 7;
            this.AddAlarmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAlarmButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AddAlarmButton.Location = new System.Drawing.Point(100, 304);
            this.AddAlarmButton.Name = "AddAlarmButton";
            this.AddAlarmButton.Size = new System.Drawing.Size(229, 71);
            this.AddAlarmButton.TabIndex = 29;
            this.AddAlarmButton.Text = "Зберегти";
            this.AddAlarmButton.UseVisualStyleBackColor = false;
            this.AddAlarmButton.Click += new System.EventHandler(this.AddAlarmButton_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Font = new System.Drawing.Font("Comic Sans MS", 19F, System.Drawing.FontStyle.Bold);
            this.tabControl2.Location = new System.Drawing.Point(96, 26);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(241, 118);
            this.tabControl2.TabIndex = 12;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage5.Controls.Add(this.datePicker);
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 44);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(233, 70);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Дата";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(7, 8);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(220, 54);
            this.datePicker.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(244, 70);
            this.panel5.TabIndex = 40;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage6.Controls.Add(this.dayPicker);
            this.tabPage6.Controls.Add(this.panel6);
            this.tabPage6.Location = new System.Drawing.Point(4, 44);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(233, 70);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "День тижня";
            // 
            // dayPicker
            // 
            this.dayPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayPicker.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold);
            this.dayPicker.FormattingEnabled = true;
            this.dayPicker.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.dayPicker.Location = new System.Drawing.Point(7, 8);
            this.dayPicker.Name = "dayPicker";
            this.dayPicker.Size = new System.Drawing.Size(220, 53);
            this.dayPicker.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(245, 70);
            this.panel6.TabIndex = 41;
            // 
            // listAlarms
            // 
            this.listAlarms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listAlarms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listAlarms.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Bold);
            this.listAlarms.ForeColor = System.Drawing.Color.White;
            this.listAlarms.FormattingEnabled = true;
            this.listAlarms.ItemHeight = 55;
            this.listAlarms.Location = new System.Drawing.Point(438, 36);
            this.listAlarms.Name = "listAlarms";
            this.listAlarms.Size = new System.Drawing.Size(409, 440);
            this.listAlarms.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.timePicker);
            this.panel4.Location = new System.Drawing.Point(142, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 70);
            this.panel4.TabIndex = 39;
            // 
            // timePicker
            // 
            this.timePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timePicker.CalendarFont = new System.Drawing.Font("Comic Sans MS", 60F, System.Drawing.FontStyle.Bold);
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold);
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(8, 8);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(134, 54);
            this.timePicker.TabIndex = 6;
            // 
            // MainCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(895, 606);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Годинник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panelAlarm.ResumeLayout(false);
            this.panelAlarm.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label defaultTime;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private PictureBox pictureBox2;
        private Button RefreshButton;
        private Button StartStopButton;
        private Label stopwatchTime;
        private PictureBox pictureBox3;
        private DateTimePicker timePicker;
        private TextBox hourText;
        private TextBox secondText;
        private TextBox minuteText;
        private Button StartStopTimer;
        private Label lateTimeTimer;
        private Label label13;
        private Label label14;
        private Button refreshTimerButton;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ListBox listAlarms;
        private DateTimePicker datePicker;
        private ComboBox dayPicker;
        private TabControl tabControl2;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private Button AddAlarmButton;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button DeleteAlarmButton;
        private Panel panelAlarm;
        private Label currentAlarm;
        private Button turnOffAlarmButton;
    }
}

