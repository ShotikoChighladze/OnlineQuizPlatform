using OnlineQuizPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineQuizPlatform.DB;

namespace OnlineQuizPlatform.Repositorys
{
    internal class QuestionRepository
    {

        public Guid CreateQuestion(Question question)
        {

            FakeDB.Data.Questions.Add(question);

            FakeDB.SaveState();

            return question.ID;
        }

        public Question? GetQuestionByID(Guid id)
        {
            return FakeDB.Data.Questions.FirstOrDefault(i => i.ID == id);

        }

        public List<Question> GetAllQuestions()
        {
            return FakeDB.Data.Questions;
        }

        public void RemoveQuestion(Guid id)
        {
            var question = GetQuestionByID(id);
            if (question != null)
            {
                FakeDB.Data.Questions.Remove(question);
                FakeDB.SaveState();
            }

        }

    }
}
