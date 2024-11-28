using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using OnlineQuizPlatform.Commands;
using OnlineQuizPlatform.DB;
using OnlineQuizPlatform.Models;
using OnlineQuizPlatform.Repositorys;
using static System.Net.Mime.MediaTypeNames;

namespace OnlineQuizPlatform.Service
{
    public class QuizService
    {
        private readonly TestRepository _testRepository = new TestRepository();
        private readonly UserRepository _userRepository = new UserRepository();
        private readonly QuestionRepository _questionRepository = new QuestionRepository();
        private readonly QuizRepository _quizRepository = new QuizRepository();

        public Guid StartQuiz(StartQuizzCommand commad)
        {
            commad.Validate();

            var quiz = new Quiz(commad.UserId, commad.TestId);

            _quizRepository.AddQuiz(quiz);

            return quiz.Id;
        }

        public AskNextQuestionResponse AskNextQuestion(AskNextQuestionCommand command)
        {
            var quiz = _quizRepository.GetById(command.QuizId);

            var test = _testRepository.GetTestById(quiz.TestId);

            var questions = _questionRepository.GetQuestionByID(test.QuestionIds[quiz.CurrentQuestionIndex]);

            return new AskNextQuestionResponse()
            {
                AllowsMultipleAnswers = questions.AllowsMultipleAnswers,
                ID = questions.ID,
                QuestionScore = questions.QuestionScore,
                PossibleAnswer = questions.PossibleAnswer,
                Text = questions.Text
            };

        }
        public AnswerQuestionResponse AnswerQuestion(AnswerQuestionCommand command)
        {
            var quiz = _quizRepository.GetById(command.quizId);
            
            if (DateTime.Now - quiz.StartTime > quiz.Duration)
            {
                quiz.EndTime = DateTime.Now;
                quiz.IsFinished = true;

                _quizRepository.SaveQuiz(quiz);

                return new AnswerQuestionResponse()
                {
                    IsFinnished = false,
                    Score = quiz.Score.GetValueOrDefault(0),
                    QuizId = quiz.Id,
                    TimeOut = true
                };
            }

            quiz.CostumerAnswers.Add(command.costumerAnswers);
            quiz.CurrentQuestionIndex += 1;
            quiz.Score += CalculateScore(command.costumerAnswers);

            var test = _testRepository.GetTestById(quiz.TestId);
            if (test.QuestionIds.Count > quiz.CurrentQuestionIndex)
            {
                quiz.IsFinished = true;
            }

            _quizRepository.SaveQuiz(quiz);

            
            return new AnswerQuestionResponse()
            {
                IsFinnished = quiz.IsFinished,
                Score = quiz.Score.GetValueOrDefault(0),
                QuizId = quiz.Id,
                TimeOut = false
            };
        }

        private int CalculateScore(CostumerAnswer costumerAnswer)
        {
            var question = _questionRepository.GetQuestionByID(costumerAnswer.QuestionId);
            if (costumerAnswer.Answers.Count != question.CorrectAnswer.Count)
            {
                return 0;
            }

            foreach (var costumerAnswerAnswer in costumerAnswer.Answers)
            {

                if (!question.CorrectAnswer.Any(i => i.ID == costumerAnswerAnswer.ID))
                {
                    return 0;
                }

            }
            return question.QuestionScore;
        }
    }
}
