using System;
using System.Collections.Generic;

namespace LabLinq22.Models
{
    /// <summary>
    /// Кафедры
    /// </summary>
    public partial class Chair
    {
        public Chair()
        {
            Groups = new HashSet<Group>();
            Tutors = new HashSet<Tutor>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int ChairId { get; set; }
        /// <summary>
        /// Номер кафедри
        /// </summary>
        public string? ChairNumber { get; set; }
        /// <summary>
        /// FK - Посилання на завідувача
        /// </summary>
        public int? ChairHeadId { get; set; }
        /// <summary>
        /// FK - Посилання на замдекана
        /// </summary>
        public int? DeputyDeanId { get; set; }

        public virtual Tutor? ChairHead { get; set; }
        public virtual Tutor? DeputyDean { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Tutor> Tutors { get; set; }
    }
}
