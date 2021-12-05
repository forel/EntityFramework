using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Scheduler
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [ForeignKey("GroupId")]
        public int? GroupId { get; set; }
        public Group Group { get; set; }
        [ForeignKey("TeacherId")]
        public int? TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
