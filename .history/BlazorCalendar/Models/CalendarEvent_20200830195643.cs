using System;

namespace BlazorCalendar.Models
{
    public class CalendarEvent
    {
        public CalendarEvent()
        {
            
        }

        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Color { get; set; }
    }
}