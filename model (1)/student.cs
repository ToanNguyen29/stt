using Day02.model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class student
    {
        [Key, Column(TypeName = "varchar"), MaxLength(10)]
        public string mssv { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string email { get; set; }

        [MaxLength(50)]
        public string password { get; set; }

        [MaxLength(20)]
        public string firstName { get; set; }

        [MaxLength(20)]
        public string lastName { get; set; }

        [MaxLength(20)]
        public string phone { get; set; }

        [MaxLength(50)]
        public string address { get; set; }

        public DateTime birthDay { get; set; }

        [MaxLength(10)]
        public string gender { get; set; }

        public byte[] pirture { get; set; }

        [MaxLength(50)]
        public string country { get; set; }

        [MaxLength(50)]
        public string faculty { get; set; }

        [MaxLength(50)]
        public string major { get; set; }

        public virtual ICollection<score> Scores { get; set; }

    }
}
