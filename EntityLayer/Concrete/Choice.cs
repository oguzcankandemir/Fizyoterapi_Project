using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Choice
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int SurveyQuestionId { get; set; } // Foreign key to relate the choice to the survey question
        public SurveyQuestion SurveyQuestion { get; set; } // Navigation property
    }
}
