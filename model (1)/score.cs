using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.model
{
    internal class score
    {
        [Key]
        public int ScoreID { get; set; }

        [ForeignKey("Student")]
        public string studentId { get; set; }
        public virtual student Student { get; set; }

        [ForeignKey("Course")]
        public string courseId { get; set; }
        public virtual course Course { get; set; }

        public float studentScore { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }
    }
}
