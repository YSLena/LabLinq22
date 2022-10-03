using System;
using System.Collections.Generic;

namespace LabLinq22.Models
{
    /// <summary>
    /// Группы
    /// </summary>
    public partial class Group
    {
        public Group()
        {
            Curricula = new HashSet<Curriculum>();
            Students = new HashSet<Student>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Номер группы
        /// </summary>
        public string GroupNumber { get; set; } = null!;
        /// <summary>
        /// FK - Посилання на кафедру
        /// </summary>
        public int? ChairId { get; set; }
        /// <summary>
        /// FK - Посилання на куратора
        /// </summary>
        public int? CuratorId { get; set; }
        /// <summary>
        /// FK - Посилання на старосту
        /// </summary>
        public int? SeniorStudentId { get; set; }
        /// <summary>
        /// Обсяг занять в годинах
        /// </summary>
        public int? StudyHours { get; set; }
        /// <summary>
        /// Кількість лаб
        /// </summary>
        public int? LabStudies { get; set; }
        /// <summary>
        /// Кількість практик
        /// </summary>
        public int? PractStudies { get; set; }

        public virtual Chair? Chair { get; set; }
        public virtual Tutor? Curator { get; set; }
        public virtual Student? SeniorStudent { get; set; }
        public virtual ICollection<Curriculum> Curricula { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
