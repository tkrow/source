using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            lblDebug.Text += "Page_LoadComplete called...";

            // Set the overall number of questions in a hidden field:
            HiddenField1.Value = QuizQuestion.numberOfQuestions.ToString();

            // Reset number of questions
            QuizQuestion.numberOfQuestions = 0;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            // First time load
            if (!Page.IsPostBack) {


            lblDebug.Text += "Page_Load called...";

            // Control set methods/properties
            QuizQuestion1.getRadioButtonList().Items[0].Text = "Michael Jordan";
            QuizQuestion1.getRadioButtonList().Items[1].Text = "Charles Barkley";
            QuizQuestion1.getRadioButtonList().Items[2].Text = "LeBron James";
            QuizQuestion1.getRadioButtonList().Items[3].Text = "Kareem Abdul-Jabbar";
            QuizQuestion1.GetQuestionLabel().Text = "Who is the best basketball player of all time?";
            // Data member set methods/properties
            QuizQuestion1.setAnswer("Michael Jordan");


            QuizQuestion2.getRadioButtonList().Items[0].Text = "A";
            QuizQuestion2.getRadioButtonList().Items[1].Text = "B";
            QuizQuestion2.getRadioButtonList().Items[2].Text = "C";
            QuizQuestion2.getRadioButtonList().Items[3].Text = "D";
            QuizQuestion2.GetQuestionLabel().Text = "What is the first letter of the alphabet?";
            // Data member set methods/properties
            QuizQuestion2.setAnswer("A");


            // Question 3 - loaded dynamically
            //QuizQuestion qq3 = new QuizQuestion();    // Not with the framework
            //PlaceHolder1.Controls.Add(qq3);

            QuizQuestion qq3 = (QuizQuestion)LoadControl("~/QuizQuestion.ascx");

            // Set data members
            qq3.setQuestion("Who is the man?");
            qq3.setAnswer("Shaft");
            // Set each choice:
            qq3.getRadioButtonList().Items[0].Text = "Shaft";
            qq3.getRadioButtonList().Items[1].Text = "Steve McQueen";
            qq3.getRadioButtonList().Items[2].Text = "Your boss";
            qq3.getRadioButtonList().Items[3].Text = "George Bush";

            // Set user control (QuizQuestion) data:
            qq3.GetQuestionLabel().Text = qq3.getQuestion();

            // Add user control to Default.aspx
            PlaceHolder1.Controls.Add(qq3);

                qq3.GetQuestionLabel().Text()j
            }
            else
            {

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            something.Text = QuizQuestion.GetQuizResults();
        }
    }
}