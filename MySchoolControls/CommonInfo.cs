using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MySchoolControls
{
    public partial class CommonInfo : UserControl
    {
        public CommonInfo()
        {
            InitializeComponent();
        }
        public class CustomPropertyChangedEventArgs
        {
            public string Name { get; set; }
            public object Value { get; set; }
            public CustomPropertyChangedEventArgs(string name = "null", object value = null)
            {
                Name = name; Value = value;
            }
        }
        public delegate void CustomPropertyChangedEventHandler(object sender, CustomPropertyChangedEventArgs e);
        public event CustomPropertyChangedEventHandler OnPropertyChanged;
        #region Свойства игровых часов
        [Description("Используемая дата и время на игровых часах")]
        [Category("Игровые часы")]
        public DateTime Date
        {
            /*get
            {
            	string dt = String.Format("{0}:{1} {2} {3}, {4}", Hours, Minutes, DayAndMonth, Year, DayOfTheWeek);
                return DateTime.ParseExact(dt, "H:mm d MMMM yyyy, dddd", null);
            }*/
            set
            {
                Hours = value.Hour; Minutes = value.Minute;
                DayOfTheWeek = DateTimeFormatInfo.CurrentInfo.GetDayName(value.DayOfWeek);
                DayAndMonth = value.ToString("d MMMM");
            }
        }
        [Description("Число часов на игровых часах.")]
        [Category("Игровые часы")]
        [DefaultValue("10")]
        private int Hours
        {
            get
            {
                return int.Parse(hoursLabel.Text);
            }
            set
            {
                if (OnPropertyChanged != null) OnPropertyChanged(this, new CustomPropertyChangedEventArgs("Hours", value));
                hoursLabel.Text = value.ToString();
            }
        }
        [Description("Число минут на игровых часах.")]
        [Category("Игровые часы")]
        [DefaultValue("15")]
        private int Minutes
        {
            get
            {
                return int.Parse(minutesLabel.Text);
            }
            set
            {
                if (OnPropertyChanged != null) OnPropertyChanged(this, new CustomPropertyChangedEventArgs("Minutes", value));
                if (value < 10) minutesLabel.Text = "0" + value.ToString();
                else minutesLabel.Text = value.ToString();
            }
        }
        [Description("День недели на игровых часах.")]
        [Category("Игровые часы")]
        [DefaultValue("понедельник")]
        private string DayOfTheWeek
        {
            get
            {
                return dayOfTheWeekLabel.Text;
            }
            set
            {
                if (OnPropertyChanged != null) OnPropertyChanged(this, new CustomPropertyChangedEventArgs("DayOfTheWeek", value));
                dayOfTheWeekLabel.Text = value;
            }
        }
        [Description("Число и месяц на игровых часах.")]
        [Category("Игровые часы")]
        [DefaultValue("1 сентября")]
        private string DayAndMonth
        {
            get
            {
                return dayAndMonthLabel.Text;
            }
            set
            {
                if (OnPropertyChanged != null) OnPropertyChanged(this, new CustomPropertyChangedEventArgs("DayAndMonth", value));
                dayAndMonthLabel.Text = value;
            }
        }
        [Description("Год на игровых часах.")]
        [Category("Игровые часы")]
        [DefaultValue("2021")]
        private int Year
        {
            get
            {
                return int.Parse(yearLabel.Text.Replace(" год", ""));
            }
            set
            {
                if (OnPropertyChanged != null) OnPropertyChanged(this, new CustomPropertyChangedEventArgs("Year", value));
                yearLabel.Text = value.ToString() + " год";
            }
        }
        #endregion
        #region Остальные свойства
        [Description("Число денег на счету школы.")]
        [Category("Остальное")]
        [DefaultValue("1000000")]
        public int Balance
        {
            get
            {
                //string val = balanceLabel.Text.Replace(" ", "").Replace(",", "").Replace("₽", "");
                return int.Parse(balanceLabel.Text, NumberStyles.Any);
            }
            set
            {
                if (OnPropertyChanged != null) OnPropertyChanged(this, new CustomPropertyChangedEventArgs("Balance", value));
                balanceLabel.Text = value.ToString("#,# ₽");
            }
        }
        [Description("Количество звёзд рейтинга.")]
        [Category("Остальное")]
        [DefaultValue("1")]
        public int Rating
        {
            get
            {
                return 5 - ratingLabel.Text.Replace("★", "").Length;
            }

            set
            {
                if (this.OnPropertyChanged != null) { this.OnPropertyChanged(this, new CustomPropertyChangedEventArgs("Rating", value)); }
                this.ratingLabel.Text = new string('★', value) + new string('☆', 5 - value);
            }
        }
        #endregion
    }
}
