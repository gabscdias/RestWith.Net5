using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWith.Net5.Business;
using RestWith.Net5.Model;

namespace RestWith.Net5.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BooksController : ControllerBase
    {
        private readonly ILogger<BooksController> _logger;
        private IBooksBusiness _booksBusiness;

        public BooksController(ILogger<BooksController> logger, IBooksBusiness booksBusiness)
        {
            _logger = logger;
            _booksBusiness = booksBusiness;
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var book = _booksBusiness.FindByID(id);
            if (book == null) return NotFound();

            return Ok(book);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_booksBusiness.FindAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Books books)
        {
            if (books == null) return BadRequest();

            return Ok(_booksBusiness.Create(books));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Books books)
        {
            if (books == null) return BadRequest();

            return Ok(_booksBusiness.Update(books));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _booksBusiness.Delete(id);
            return NoContent();
        }
    }
}