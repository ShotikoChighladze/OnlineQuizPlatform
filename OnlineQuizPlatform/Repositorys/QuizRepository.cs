using OnlineQuizPlatform.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineQuizPlatform.Models;

namespace OnlineQuizPlatform.Repositorys
{
    internal class QuizRepository
    {
        public Quiz? GetById(Guid id)
        {
            return  FakeDB.Data.Quizzes.FirstOrDefault(i => i.Id == id);
        }

        public Guid AddQuiz(Quiz quiz)
        {
            FakeDB.Data.Quizzes.Add(quiz);

            FakeDB.SaveState();

            return quiz.Id;
        }

        public void SaveQuiz(Quiz quiz)
        {
            var q = GetById(quiz.Id);
            q = quiz;

            FakeDB.SaveState();

        }


    }
}
