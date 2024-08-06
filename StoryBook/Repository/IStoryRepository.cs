using StoryBook.Models;

namespace StoryBook.Repository
{
	public interface IStoryRepository
	{
		IEnumerable<Story> GetAll();
		Story Create(Story story);
	}
}
