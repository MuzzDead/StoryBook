using MongoDB.Driver;
using StoryBook.Models;

namespace StoryBook.Repository
{
	public class StoryRepository : IStoryRepository
	{
		private MongoClient _mongoClient = null;
        private IMongoDatabase _database = null;
        private IMongoCollection<Story> _storyTable = null;

        public StoryRepository()
        {
            _mongoClient = new MongoClient("mongodb+srv://hudaigor21:7BtzdKIX701vjgiq@cluster0.eyq7atr.mongodb.net/");
			_database = _mongoClient.GetDatabase("Cluster0");
			_storyTable = _database.GetCollection<Story>("Story");
        }

        public Story Create(Story story)
		{
			var storyObj = _storyTable.Find(x => x.Id == story.Id).FirstOrDefault();
			if (storyObj == null)
			{
				_storyTable.InsertOne(storyObj);
			}
			else
			{
				_storyTable.ReplaceOne(x => x.Id == story.Id, storyObj);
			}
			return storyObj;

		}

		public IEnumerable<Story> GetAll()
		{
			return _storyTable.Find(FilterDefinition<Story>.Empty).ToList();
		}
	}
}
