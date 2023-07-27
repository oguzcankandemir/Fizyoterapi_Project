using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SurveyQuestion
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public ICollection<Choice> Choices { get; set; }
        public int? SelectedChoiceId { get; set; } // Store the selected choice ID
    }
}


