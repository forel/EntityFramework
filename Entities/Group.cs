using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Group
    {
        [Key]
        public int Id { get; set; }    
        [Required]
        [MaxLength(100)]
        public string Number { get; set; }
        [Required]
        [MaxLength(250)]
        public string Course { get; set; }
        public DateTime CreateDT { get; set; }
        public List<Scheduler> Schedulers { get; set; }
        public List<Student> Students { get; set; }
    }
}
