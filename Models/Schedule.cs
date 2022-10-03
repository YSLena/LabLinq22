using System;
using System.Collections.Generic;

namespace LabLinq22.Models
{
    public partial class Schedule
    {
        /// <summary>
        /// PK
        /// </summary>
        public int ScheduleId { get; set; }
        /// <summary>
        /// FK - Посилання на пункт навч. плану
        /// </summary>
        public int? CurriculumId { get; set; }
        /// <summary>
        /// Дата заняття
        /// </summary>
        public DateTime? LessonDate { get; set; }
        /// <summary>
        /// Пара за розкладом
        /// </summary>
        public byte? Pair { get; set; }
        /// <summary>
        /// Час початку
        /// </summary>
        public TimeSpan? LessonStart { get; set; }
        /// <summary>
        /// Час закінчення
        /// </summary>
        public TimeSpan? LessonFinish { get; set; }

        public virtual Curriculum? Curriculum { get; set; }
    }
}
