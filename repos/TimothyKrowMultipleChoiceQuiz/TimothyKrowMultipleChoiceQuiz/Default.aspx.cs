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
        protected void Page_Load(object sender, EventArgs e)
        {
            QuizQuestion qq1 = (QuizQuestion)LoadControl("~/QuizQuestion.ascx");
            QuizQuestion qq2 = (QuizQuestion)LoadControl("~/QuizQuestion.ascx");
            QuizQuestion qq3 = (QuizQuestion)LoadControl("~/QuizQuestion.ascx");
        }
    }
}