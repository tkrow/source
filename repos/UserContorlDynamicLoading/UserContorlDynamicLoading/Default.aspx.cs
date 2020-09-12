using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlDynamicLoading
{
    public partial class Default : System.Web.UI.Page
    {

        List<String[]> questionBank;
        List<QuizQuestion> quizQuestions;

        protected void Page_Load(object sender, EventArgs e)
        {
            questionBank = QuizQuestion.getQuestions();
            quizQuestions = new List<QuizQuestion>();


            // Loop through questionBank;
            // Create a new QuizQuestion for each item in questionBank
            foreach (String[] s in questionBank)
            {
                //quizQuestions.Add(new QuizQuestion());
                quizQuestions.Add((QuizQuestion)LoadControl("~/QuizQuestion.ascx"));
            }
        }

        void Page_LoadComplete(object sender, EventArgs e)
        {          
            
            // Loop through QuizQuestion list
            // assign question, choices, and answer to each question:
            int currentQuestion = 0;

            foreach (QuizQuestion quizQuestion in quizQuestions)
            {
                quizQuestion.setQuestion(questionBank[currentQuestion][0]);

                // Set other data; choices and answer
                quizQuestion.setAnswer(questionBank[currentQuestion][5]);

                // Add to Page:
                PlaceHolder1.Controls.Add(quizQuestion);

                currentQuestion++;
            }
        }
    }
}