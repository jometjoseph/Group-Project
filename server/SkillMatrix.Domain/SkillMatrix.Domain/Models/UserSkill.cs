using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
=======
using SkillMatrix.Domain.Types;
>>>>>>> 8e5fdc9 (Server files)

namespace SkillMatrix.Domain.Models
{
    public class UserSkill
    {
        public int Id { get; set; }

<<<<<<< HEAD
        public StatusType.Type Type { get; set; }

        public StatusType.Proficiency Proficiency { get; set; }
=======
        public SkillType SkillType { get; set; }

        public Proficiency Proficiency { get; set; }
>>>>>>> 8e5fdc9 (Server files)

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

<<<<<<< HEAD
=======
        public string ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

>>>>>>> 8e5fdc9 (Server files)
        public int SkillId { get; set; }

        public Skill Skill { get; set; }
    }
}
