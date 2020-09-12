using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlDynamicLoading
{
    public partial class QuizQuestion : System.Web.UI.UserControl
    {
        // Static data that will be used to populate questions
        public static List<string[]> questionBank = new List<String[]>();
        public static int numberOfQuestions = 0;
        private static int numberOfCorrectAnswers = 0;

        private string answer;
        private string question;

        protected void Page_Load(object sender, EventArgs e)
        {
            questionBank.Add(new string[] { "Question 1", "Choice A", "Choice B", "Choice C", "Choice D" });

            // Increase for each question:
            numberOfQuestions++;
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {

        }

        /*
        public QuizQuestion()
        {
            numberOfQuestions++;
        }
        */

        public void setQuestionText(
            string question,
            string answerAText,
            string answerBText,
            string answerCText,
            string answerDText,
            string answer)
        {
            // Set question text
            //lblQuestion.Text = question;

            // Set the answer
            //this.answer = answer;

            // Set each answer
            //RadioButtonList1.Items[0].Text = answerAText;
            // RadioButtonList1.Items[1].Text = answerBText;
            //RadioButtonList1.Items[2].Text = answerCText;
            //RadioButtonList1.Items[3].Text = answerDText;
        }

        // Controls get/set
        public Label GetQuestionLabel()
        {
            return lblQuestion;
        }

        public RadioButtonList getRadioButtonList()
        {
            return RadioButtonList1;
        }

        //Data members get/set

        public void setAnswer(string answer)
        {
            this.answer = answer;
            // throw new NotImplementedException
        }


        public void setQuestion(string question)
        {
            this.question = question;
            // throw new NotImplementedException
        }

        public string getQuestion()
        {
            return question;
        }


        public void CheckAnswer()
        {
            if (RadioButtonList1.SelectedItem.ToString() == this.answer)
            {
                lblResult.Text += "Correct!";
                numberOfCorrectAnswers++;
            }
            else
            {
                lblResult.Text += "Incorrect!";
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResult.Text += "RadioButtonList1_SelectedIndexChanged() called: ";
            CheckAnswer();
        }

        public static string GetQuizResults()
        {
            string text = "You scored " + numberOfCorrectAnswers + " out of " + numberOfQuestions;

            // reset count
            numberOfCorrectAnswers = 0;

            return text;
        }
    }
}