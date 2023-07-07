
using HandsOnProjectApi.Controllers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnProjectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController :ControllerBase
    {   BookRepositry br=new BookRepositry();
        [HttpGet,Route("getbook")]
        public IActionResult GetBook(int BookId)
        {   
            Book book=br.GetBook(BookId);
            return StatusCode(200, book);

        }

        [HttpDelete,Route("deletebook")]

        public ActionResult DeleteBook(int BookId)
        {

           br.DeleteBook(BookId);
            return StatusCode(200, $"succesfully deleted {BookId} ");
        }

        [HttpPost,Route("add book")]

        public ActionResult AddBook(Book book)
        {
            br.AddBooks(book);
            return StatusCode(200, "successfully added");
        }
    }
}
