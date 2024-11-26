using OnlineQuizPlatform.Models;

namespace OnlineQuizPlatform.DB
{
    internal class DBDataModel
    {
        public DBDataModel()
        {
            Questions = new List<Question>();
            Users = new List<User>();
            Tests = new List<Test>();
        }

        public List<Question> Questions { get; set; }
        public List<User> Users { get; set; }
        public List<Test> Tests { get; set; }

    }
}
