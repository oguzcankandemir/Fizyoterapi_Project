using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PainScoreEntry
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}
