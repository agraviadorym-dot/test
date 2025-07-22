using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExamSimulator
{
    public partial class Form1 : Form
    {
        private List<Question> questionsList = new List<Question>();
        private int currentQuestionIndex = 0;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            string filePath = @"questions.txt"; // Path to your text file

            try
            {
                var fileText = File.ReadAllText(filePath);
                questionsList = ParseQuestions(fileText);
                DisplayQuestion();  // Display the first question
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The question file was not found.");
            }
        }

        private List<Question> ParseQuestions(string text)
        {
            List<Question> questions = new List<Question>();

            // Regex to capture the question, correct answer, and the choices
            var questionRegex = new Regex(@"(\d+\..*?\?)\s+Ans:\s*(.*?)\s*\n((?:.|\n)*?)(?=\d+\.|\z)", RegexOptions.Singleline);
            var matches = questionRegex.Matches(text);

            foreach (Match match in matches)
            {
                string questionText = match.Groups[1].Value.Trim();
                string correctAnswer = match.Groups[2].Value.Trim();
                string choicesText = match.Groups[3].Value.Trim();

                // Extract choices, split by newlines, and clean up extra spaces
                var choicesList = choicesText.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries)
                                             .Select(choice => choice.Trim())
                                             .ToList();

                // Add the correct answer to the list of choices
                if (!choicesList.Contains(correctAnswer))
                {
                    choicesList.Add(correctAnswer);
                }

                // Add the question with its choices and correct answer to the list
                questions.Add(new Question(questionText, choicesList, correctAnswer));
            }

            return questions;
        }




        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questionsList.Count)
            {
                var currentQuestion = questionsList[currentQuestionIndex];
                lblQuestion.Text = currentQuestion.QuestionText;

                // Display choices without shuffling, ensuring empty choices are handled properly
                rbtnChoice1.Text = currentQuestion.Choices.ElementAtOrDefault(0) ?? "";
                rbtnChoice2.Text = currentQuestion.Choices.ElementAtOrDefault(1) ?? "";
                rbtnChoice3.Text = currentQuestion.Choices.ElementAtOrDefault(2) ?? "";
                rbtnChoice4.Text = currentQuestion.Choices.ElementAtOrDefault(3) ?? "";

                // Ensure radio buttons are cleared before showing a new question
                rbtnChoice1.Checked = false;
                rbtnChoice2.Checked = false;
                rbtnChoice3.Checked = false;
                rbtnChoice4.Checked = false;

                btnSubmit.Enabled = true; // Enable Submit button after each question
            }
            else
            {
                MessageBox.Show($"Quiz Over! Your Score: {score}");
                btnSubmit.Enabled = false; // Disable Submit button when quiz ends
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var currentQuestion = questionsList[currentQuestionIndex];
            string selectedAnswer = "";

            // Check which radio button is selected and trim extra spaces
            if (rbtnChoice1.Checked) selectedAnswer = rbtnChoice1.Text.Trim();
            if (rbtnChoice2.Checked) selectedAnswer = rbtnChoice2.Text.Trim();
            if (rbtnChoice3.Checked) selectedAnswer = rbtnChoice3.Text.Trim();
            if (rbtnChoice4.Checked) selectedAnswer = rbtnChoice4.Text.Trim();

            // Check if the selected answer matches the correct answer (ignoring case and spaces)
            if (string.Equals(selectedAnswer, currentQuestion.CorrectAnswer.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Correct!");
                score++;  // Increment score
                btnNext.Enabled = true;
            }
            else
            {
                MessageBox.Show($"Incorrect! The correct answer is: {currentQuestion.CorrectAnswer}");
            }

            lblScore.Text = $"Score: {score}"; // Update the score label
        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            if (currentQuestionIndex < questionsList.Count)
            {
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show("You've reached the end of the quiz!");
                btnNext.Enabled = false;
                btnSubmit.Enabled = false;
            }
            btnNext.Enabled = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestion();
            }
        }

    }

}
