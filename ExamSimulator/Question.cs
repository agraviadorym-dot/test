using System.Collections.Generic;

namespace ExamSimulator
{
    public class Question
    {
        public string QuestionText { get; }
        public List<string> Choices { get; }
        public string CorrectAnswer { get; }

        public Question(string questionText, List<string> choices, string correctAnswer)
        {
            QuestionText = questionText;
            Choices = choices;
            CorrectAnswer = correctAnswer;
        }
    }
}
