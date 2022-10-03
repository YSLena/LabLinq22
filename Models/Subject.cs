using System;
using System.Collections.Generic;

namespace LabLinq22.Models
{
    /// <summary>
    /// Предметы
    /// </summary>
    public partial class Subject
    {
        public Subject()
        {
            Curricula = new HashSet<Curriculum>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int SubjectId { get; set; }
        /// <summary>
        /// Назва дисципліни
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// FK - Посилання на кафедру (для ф-та № 3)
        /// </summary>
        public int? ChairId { get; set; }
        /// <summary>
        /// Номер зовннішньої кафедри
        /// </summary>
        public string? ChairExternal { get; set; }

        public virtual ICollection<Curriculum> Curricula { get; set; }
    }
}
