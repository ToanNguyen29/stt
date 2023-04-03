using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02.model
{
    internal class admin
    {
        [Key]
        public int id { get; set; }

        [Index(IsUnique = true)]
        [MaxLength(50)]
        public string email { get; set; }

        [MaxLength(20)]
        public string password { get; set; }

        [MaxLength(20)]
        public string fname { get; set; }

        [MaxLength(20)]
        public string sname { get; set; }

        [MaxLength(20)]
        public string phone { get; set; }

    }
}
