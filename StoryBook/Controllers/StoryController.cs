using Microsoft.AspNetCore.Mvc;
using StoryBook.Models;
using StoryBook.Repository;

namespace StoryBook.Controllers
{
    public class StoryController : Controller
    {
        private IStoryRepository _storyRepository = null;

        public StoryController(IStoryRepository storyRepository)
        {
            _storyRepository = storyRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetStories()
        {
            var stories = _storyRepository.GetAll();
            return Json(stories);
        }

        public IActionResult Create(Story story)
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }

    }
}
