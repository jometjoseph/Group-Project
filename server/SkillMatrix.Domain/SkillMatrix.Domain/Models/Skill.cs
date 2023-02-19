﻿using System;
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
    public class Skill
    {
        public int Id { get; set; }

        [Required, NotNull]
        [StringLength(100)]
        public string Name { get; set; }

<<<<<<< HEAD
        public StatusType.Status Status { get; set; }
=======
        public Status Status { get; set; }
>>>>>>> 8e5fdc9 (Server files)

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
