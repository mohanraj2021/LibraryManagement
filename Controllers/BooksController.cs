using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Models;
using LibraryManagement.Repositories;
using Newtonsoft.Json;
using MongoDB.Bson;

namespace LibraryManagement.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private BooksRepository _booksRepository;

        public BooksController()
        {
            this._booksRepository = new BooksRepository();
        }

        // GET api/books
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return this._booksRepository.GetBooks();
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public Book Get(string id)
        {
            return this._booksRepository.GetBook(new ObjectId(id));
        }

        // POST api/books
        [HttpPost]
        public Book Post([FromBody]dynamic bookJson)
        {
            var json = JsonConvert.SerializeObject(bookJson);
            Book book = JsonConvert.DeserializeObject<Book>(json);
            return this._booksRepository.Create(book);
        }

    }
}
