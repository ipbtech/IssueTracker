﻿using System.ComponentModel.DataAnnotations;

namespace TaskManager.ViewModels
{
    public abstract class WorkTaskVM
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "Not more 150 letters")]
        public string Title { get; set; }

        [MaxLength(255, ErrorMessage = "Not more 255 letters")]
        public string Description { get; set; }
    }
    
    public class WorkTaskGetVM : WorkTaskVM
    {
        public WorkTaskStatusGetVM Status { get; set; }
        public string Author { get; set; }

        public string CreatedDateTimeUTC { get; set; }
        public string ClosedDateTimeUTC { get; set; }
        public string PlannedDateTimeUTC { get; set; }
        public string FactedTimeSpan { get; set; }
    }

    public class WorkTaskCreateVM : WorkTaskVM
    {
        [Required]
        public int StatusId { get; set; }

        [Required]
        public int UserId { get; set; }

        public DateTime? PlannedDateTime { get; set; }
        public TimeSpan? FactedTimeSpan { get; set; }
    }
}