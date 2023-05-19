using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMaster.Model.DataModels
{
    public class Skill: AuditableEntity<long>
    {
        [Key]
        public long SkillId { get; set; }
        public string? SkillName { get; set; }
        public string? Status { get; set; }
       
    }
}
