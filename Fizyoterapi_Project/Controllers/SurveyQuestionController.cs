using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fizyoterapi_Project.Controllers
{
    public class SurveyQuestionController : Controller
    {
        private readonly Context _dbContext;

        public SurveyQuestionController(Context dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var survey = new SurveyQuestion
            {
                Question = "How satisfied are you with our service?",
                Choices = new List<Choice>
            {
                new Choice { Text = "Very Satisfied" },
                new Choice { Text = "Satisfied" },
                new Choice { Text = "Neutral" },
                new Choice { Text = "Dissatisfied" },
                new Choice { Text = "Very Dissatisfied" }
            }
            };

            return View(survey);
        }

        [HttpPost]
        public IActionResult Index(SurveyQuestion survey)
        {
            if (ModelState.IsValid)
            {
                // Save the survey question and its choices to the database
                _dbContext.surveyQuestions.Add(survey);
                _dbContext.SaveChanges();
                return RedirectToAction("ThankYou");
            }

            // If the model state is not valid, redisplay the form with validation errors
            return View(survey);
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}

