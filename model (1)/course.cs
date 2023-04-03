using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.model
{
    class course
    {
        [Key, Column(TypeName = "varchar"), MaxLength(15)]
        public String IDcourse { get; set; }

        [MaxLength(50)]
        public string label { get; set; }

        public int period { get; set; }

        [MaxLength(50)]
        public string semester { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        public virtual ICollection<score> Scores { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }
        public virtual teacher Teacher { get; set; }

    }
}
