using OnlineQuizPlatform.Commands;
using OnlineQuizPlatform.Models;
using OnlineQuizPlatform.Repositorys;

namespace OnlineQuizPlatform.Service
{
    public class QuestionService
    {
        private QuestionRepository _questionRepository;

        public QuestionService()
        {
            _questionRepository = new QuestionRepository();
        }
        public void CreateQuestion(CreateQuestionCommand command)
        {
            command.Validate();

            var question = new Question
            {
                Text = command.Text,
                PossibleAnswer = command._PossibleAnswer,
                CorrectAnswer = command.CorrectAnswer,
                QuestionScore = command.QuestionScore
            };

            _questionRepository.CreateQuestion(question);

        }

        public void RemoveQuestion(Guid Id)
        {

            _questionRepository.RemoveQuestion(Id);

        }
        public Question? GetQuestionByID(Guid id)
        {
            return _questionRepository.GetQuestionByID(id);

        }

        public List<Question> GetAllQuestions()
        {
            return _questionRepository.GetAllQuestions();
        }
    }
}
