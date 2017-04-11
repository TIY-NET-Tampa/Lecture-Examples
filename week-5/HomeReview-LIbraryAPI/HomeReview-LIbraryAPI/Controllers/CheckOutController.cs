using HomeReview_LIbraryAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeReview_LIbraryAPI.Controllers
{
    public class CheckOutController : ApiController
    {
        // Keep the controller skinny
        IBookService bookService = new BookService();

        [HttpPost]
        public IHttpActionResult CheckOutBook(int id)
        {
            try
            {
                var vm = this.bookService.CheckOutBook(id);
                return Ok(vm);
            }
            catch (Exception)
            {
                return BadRequest("THere was an error");
            }

        }
    }
}
