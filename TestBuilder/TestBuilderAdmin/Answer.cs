using System;

namespace TestBuilderAdmin
{
    class Answer
    {
        public Answer(bool isRightAnswer, string answer)
        {
            IsRightAnswer = isRightAnswer;
            Text = answer;
        }

        public override string ToString()
        {
            return Text;
        }

        public bool IsRightAnswer { get; private set; }
        public string Text { get; private set; }
    }
}
