using System;
using System.Collections.Generic;

namespace LabLinq22.Models
{
    /// <summary>
    /// Учебный план
    /// </summary>
    public partial class Curriculum
    {
        public Curriculum()
        {
            Schedules = new HashSet<Schedule>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int CurriculumId { get; set; }
        /// <summary>
        /// FK - Посилання на предмет
        /// </summary>
        public int? SubjectId { get; set; }
        /// <summary>
        /// FK - Посилання на препода
        /// </summary>
        public int? TutorId { get; set; }
        /// <summary>
        /// FK - Посилання на группу
        /// </summary>
        public int? GroupId { get; set; }

        public virtual Group? Group { get; set; }
        public virtual Subject? Subject { get; set; }
        public virtual Tutor? Tutor { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
