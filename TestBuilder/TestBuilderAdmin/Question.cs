using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBuilderAdmin
{
    class Question
    {
        public Question(string text, List<Answer> answer)
        {
            Text = text;
            Answers = answer;
        }

        public override string ToString()
        {
            return Text;
        }

        public List<Answer> Answers { get; private set; }
        public string Text { get; private set; }
    }
}
