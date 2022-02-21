using InOtherWord.Models;
using Microsoft.AspNetCore.Mvc;

namespace InOtherWord.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DictionaryController_test : ControllerBase
    {

        private readonly ILogger<DictionaryController_test> _logger;

        public DictionaryController_test(ILogger<DictionaryController_test> logger)
        {
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<Dictionary> GetDictionary()
        //{

        //}
    }
}