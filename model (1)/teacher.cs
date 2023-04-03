using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.model
{
    internal class teacher
    {
        [Key]
        public int teacherID { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string email { get; set; }

        [MaxLength(20)]
        public string password { get; set; }

        [MaxLength(20)]
        public string fname { get; set; }

        [MaxLength(20)]
        public string sname { get; set; }

        public string phone { get; set; }

        [MaxLength(50)]
        public string address { get; set; }

        public DateTime birthDay { get; set; }

        [MaxLength(10)]
        public string gender { get; set; }

        public byte[] pirture { get; set; }

        [MaxLength(50)]
        public string country { get; set; }

        public virtual ICollection<course> Courses { get; set; }

    }
}
