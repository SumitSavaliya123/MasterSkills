using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMaster.Model.DataModels
{
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        [ScaffoldColumn(false)]
        public DateTime? CreatedAt { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? UpdatedAt { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DeletedAt { get; set; }
    }
}



