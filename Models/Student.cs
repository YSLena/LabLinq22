using System;
using System.Collections.Generic;

namespace LabLinq22.Models
{
    /// <summary>
    /// Студенты
    /// </summary>
    public partial class Student
    {
        public Student()
        {
            Groups = new HashSet<Group>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int StudentId { get; set; }
        /// <summary>
        /// Прізвище
        /// </summary>
        public string? Surname { get; set; }
        /// <summary>
        /// Им&apos;я
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// По батькові
        /// </summary>
        public string? Patronymic { get; set; }
        /// <summary>
        /// FK - Посилання на групу
        /// </summary>
        public int? GroupId { get; set; }
        /// <summary>
        /// Пропуски занять в годинах
        /// </summary>
        public int? Absences { get; set; }
        /// <summary>
        /// Пропуски без поваж. причин в годинах
        /// </summary>
        public int? UnreasonableAbsences { get; set; }
        /// <summary>
        /// Нездані лабораторні
        /// </summary>
        public int? UnreadyLabs { get; set; }

        public virtual Group? Group { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
