using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillMaster.Model.DataModels
{
    public interface IAuditableEntity
    {
        DateTime? CreatedAt { get; set; }
        DateTime? UpdatedAt { get; set; }
        DateTime? DeletedAt { get; set; }
    }
}


public interface IAuditableEntity
{
    DateTime CreatedDate { get; set; }

    string CreatedBy { get; set; }

    DateTime UpdatedDate { get; set; }

    string UpdatedBy { get; set; }
}