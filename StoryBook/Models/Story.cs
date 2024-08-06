using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StoryBook.Models
{
    public class Story
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = ObjectId.GenerateNewId().ToString();
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.Now;
        public string UserName {  get; set; }
    }
}
