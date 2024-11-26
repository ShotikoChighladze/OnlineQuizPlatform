using OnlineQuizPlatform.DB;
using OnlineQuizPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineQuizPlatform.Repositorys
{
    internal class TestRepository
    {
        public Test? GetTestById(Guid id)
        {
            return FakeDB.Data.Tests.FirstOrDefault(i => i.Id == id);
        }

        public Guid CreateTest(Test test)
        {
            
            FakeDB.Data.Tests.Add(test);

            FakeDB.SaveState();

            return test.Id;
        }

        public List<Test> GetAllTests()
        {
            return FakeDB.Data.Tests;
        }
    }
}
