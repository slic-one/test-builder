using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace TestBuilderAdmin
{
    class QuestionsBank
    {
        //file location with qestions
        public string xmlFileLocation;

        // main qestions theme like: "c++", "biology"...
        public string Topic { get; set; }
        public List<Question> Questions;

        public QuestionsBank()
        {
            Questions = new List<Question>();
            Topic = null;
        }

        //returns an instance of this class with filled questions from xml
        public static QuestionsBank LoadFromXml(string fileLocation)
        {
            var resultQuestionBank = new QuestionsBank();

            XDocument taskData = XDocument.Load(fileLocation);
            XElement el = taskData.Root; // access root element <Questions>

            resultQuestionBank.Topic = el.Attribute("topic").Value;

            IEnumerable<XElement> els = el.Descendants("Question"); // returns all <Question> nodes

            foreach (var e in els)
            {
                var q = new Question();
                // question have only one text qestion, so take the first
                var t = e.Descendants("QuestionText").First();
                q.QuestionText = t.Value;

                // get parent of <Answer> nodes (p.s <Answers> is a container)
                var a = e.Descendants("Answers").First();

                //looping throught answers
                foreach (var an in a.Descendants())
                {
                    string answerValue = an.Value; // text of answer
                    bool right = Convert.ToBoolean(an.Attribute("right").Value); //if is correct

                    var answerItem = new Answer(answerValue, right);
                    q.Answers.Add(answerItem);
                }

                resultQuestionBank.Questions.Add(q);
            }

            return resultQuestionBank;
        }

        //saves current data by moving it to xml format
        public void SaveToXml(string fileLocation)
        {
            XDocument xmlDocument = new XDocument(new XDeclaration("1.1", "utf-8", "yes"));
            XElement xQuestions = new XElement("Questions", new XAttribute("topic", Topic));

            foreach (var q in Questions)
            {
                var xQuestion = new XElement("Question");
                xQuestion.Add(new XElement("QuestionText"), q.QuestionText); // root <Questions>

                var xAnswers = new XElement("Answers"); // container <Answers> for <Answer> 

                foreach (var a in q.Answers)
                {
                    var xAnswer = new XElement("Answer", new XAttribute("right", a.isRight));
                    xAnswer.Add(a.AnswerText); // put text of answer inside  <Answer> here answer</Answer>
                    xAnswers.Add(xAnswer); // add <Answer> into <Answers> tag
                }

                xQuestion.Add(xAnswers);
            }

            xmlDocument.Save(fileLocation);
        }

    }
}
