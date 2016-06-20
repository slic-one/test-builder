using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBuilderAdmin
{
    /// <summary>
    /// Qestion class is a container
    /// with 2 public fields: QuestionText and answers(List)
    /// </summary>
    class Question
    {
        public string QestionText { get; set; }
        public List<Answer> Answers = new List<Answer>();
    }
}
