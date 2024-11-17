﻿namespace TaskManager.Entities.Views
{
    public class WorkTaskView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDateTimeUTC { get; set; }
        public DateTime? ClosedDateTimeUTC { get; set; }
        public TimeSpan? FactedTimeSpan { get; set; }
    }
}