using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using CyberBot1.Logging;
using CyberBot1.Quiz;

//Assisted by ChatGPT to refactor and improve the quiz functionality, including better feedback and score tracking.

namespace CyberBot1.Quiz
{
    //This class represents the quiz window where users can answer questions and track their score.
    public partial class QuizWindow : Window
    {
        //intializing the list of questions, current question index, score, and answered state. 
        private List<QuizQuestion> questions;
        private int currentQuestionIndex = 0;  // Current question index in the quiz
        private int score = 0;
        private bool answered = false;

        public QuizWindow()
        {
            InitializeComponent();

            // Log quiz start
            ActivityLog.Add("Quiz started");


            LoadQuestions();
            ShowQuestion();
        }

        private void LoadQuestions()
        {
            questions = QuizData.GetQuestions();
        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            var main = new MainWindow();
            main.Show();
            this.Close();
        }


        private void ShowQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                ShowFinalScore();
                return;
            }

            // Reset answered state for the new question
            answered = false;
            var question = questions[currentQuestionIndex];

            // Update UI elements with the current question and options
            QuestionText.Text = question.QuestionText;
            AnswerBtn1.Content = question.Options[0];
            AnswerBtn2.Content = question.Options[1];
            AnswerBtn3.Content = question.Options[2];
            AnswerBtn4.Content = question.Options[3];

            FeedbackText.Text = string.Empty;

            // Enable all answer buttons for the new question
            AnswerBtn1.IsEnabled = true;
            AnswerBtn2.IsEnabled = true;
            AnswerBtn3.IsEnabled = true;
            AnswerBtn4.IsEnabled = true;
        }

        private void AnswerButton_Click(object sender, RoutedEventArgs e)
        {

            //check if the question has already been answered
            if (answered)
                return;

            answered = true;
            var clickedButton = sender as Button;
            int clickedIndex = -1;

            if (clickedButton == AnswerBtn1) clickedIndex = 0;
            else if (clickedButton == AnswerBtn2) clickedIndex = 1;
            else if (clickedButton == AnswerBtn3) clickedIndex = 2;
            else if (clickedButton == AnswerBtn4) clickedIndex = 3;

            var currentQ = questions[currentQuestionIndex];

            if (clickedIndex == currentQ.CorrectAnswerIndex)
            {
                score++;
                FeedbackText.Foreground = Brushes.Green;
                FeedbackText.Text = $"{QuizHelper.GetPositiveResponse()} {currentQ.Explanation}";
            }
            else
            {
                FeedbackText.Foreground = Brushes.Red;
                FeedbackText.Text = $"{QuizHelper.GetNegativeResponse()} {currentQ.Explanation}";
            }

            UpdateScoreText();

            // Disable all answer buttons after answering
            AnswerBtn1.IsEnabled = false;
            AnswerBtn2.IsEnabled = false;
            AnswerBtn3.IsEnabled = false;
            AnswerBtn4.IsEnabled = false;

            //the timer to show the next question after a delay
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(3) };
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                currentQuestionIndex++;
                ShowQuestion();
            };
            timer.Start();
        }

        private void UpdateScoreText()
        {
            ScoreText.Text = $"Score: {score} / {questions.Count}";
        }

        private void ShowFinalScore()
        {
            QuestionText.Text = "🎉 Quiz Completed!";
            FeedbackText.Text = "";
            ScoreText.Text = $"Your final score is {score} out of {questions.Count}.\n";

            if (score >= 8)
                ScoreText.Text += "🌟 Amazing! You're a cybersecurity pro!";
            else if (score >= 7)
                ScoreText.Text += "👍 Good job! Keep learning and improving!";
            else
                ScoreText.Text += "📘 Don't worry — try again and boost your skills!";

            AnswerBtn1.Visibility = Visibility.Collapsed;
            AnswerBtn2.Visibility = Visibility.Collapsed;
            AnswerBtn3.Visibility = Visibility.Collapsed;
            AnswerBtn4.Visibility = Visibility.Collapsed;

            // Log quiz completion with score
            ActivityLog.Add($"Quiz completed: Score {score}/{questions.Count}");


            RetryButton.Visibility = Visibility.Visible;
        }
        
        private void RetryButton_Click(object sender, RoutedEventArgs e)
        {
            score = 0;
            currentQuestionIndex = 0;
            RetryButton.Visibility = Visibility.Collapsed;
            AnswerBtn1.Visibility = Visibility.Visible;
            AnswerBtn2.Visibility = Visibility.Visible;
            AnswerBtn3.Visibility = Visibility.Visible;
            AnswerBtn4.Visibility = Visibility.Visible;
            LoadQuestions();
            ShowQuestion();
        }
    }
}
