using System;
using System.Collections.Generic;

namespace LabLinq22.Models
{
    /// <summary>
    /// Преподаватели
    /// </summary>
    public partial class Tutor
    {
        public Tutor()
        {
            ChairChairHeads = new HashSet<Chair>();
            ChairDeputyDeans = new HashSet<Chair>();
            Curricula = new HashSet<Curriculum>();
            Groups = new HashSet<Group>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int TutorId { get; set; }
        /// <summary>
        /// Прізвище І.П.
        /// </summary>
        public string? NameFio { get; set; }
        /// <summary>
        /// Факультет
        /// </summary>
        public int? Faculty { get; set; }
        /// <summary>
        /// FK - Посилання на кафедру (для ф-та № 3)
        /// </summary>
        public int? ChairId { get; set; }
        /// <summary>
        /// Номер кафедри (для зовнішніх)
        /// </summary>
        public string? ChairExternal { get; set; }
        /// <summary>
        /// Посада (необов&apos;язкове)
        /// </summary>
        public string? Position { get; set; }

        public virtual Chair? Chair { get; set; }
        public virtual ICollection<Chair> ChairChairHeads { get; set; }
        public virtual ICollection<Chair> ChairDeputyDeans { get; set; }
        public virtual ICollection<Curriculum> Curricula { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
    }
}
