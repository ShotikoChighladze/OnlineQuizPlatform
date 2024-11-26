using OnlineQuizPlatform.Commands;
using OnlineQuizPlatform.DB;
using OnlineQuizPlatform.Models;
using OnlineQuizPlatform.Repositorys;

namespace OnlineQuizPlatform.Service
{
    internal class TestService
    {
        private TestRepository _testRepository;
        public TestService()
        {
            _testRepository = new TestRepository();
        }
        public void CreateTest(CreateTestCommand command)
        {
            command.Validate();

            var test = new Test()
            {
                Duration = command.Duration,
                QuestionIds = command.QuestionIds,
                Title = command.Title
            };


            _testRepository.CreateTest(test);

        }

        public Test? GetTestById(Guid id)
        {
            return _testRepository.GetTestById(id);
        }

        public List<Test> GetAllTests()
        {
            return _testRepository.GetAllTests();
        }

    }
}
