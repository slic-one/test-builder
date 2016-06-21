using System;

namespace TestClient
{
    /// <summary>
    /// Class represent an answer item for class Qestion
    /// p.s: In default constructor boolean variables:
    /// #isRight and #isSelected are set to value False
    /// </summary>
    class Answer
    {
        public string AnswerText;
        public bool isRight;
        public bool isSelected;

        //Constructors
        public Answer(string text)
        {
            AnswerText = text;
            isRight = false;
            isSelected = false;
        }

        public Answer(string text, bool isRight)
        {
            AnswerText = text;
            this.isRight = isRight;
        }

        public override string ToString()
        {
            return AnswerText;
        }
    }
}
