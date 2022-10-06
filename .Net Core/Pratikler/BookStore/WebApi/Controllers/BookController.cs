using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.GetBooks;
using WebApi.BookOperations.GetByIdQuery;
using WebApi.BookOperations.PutBookCommand;
using WebApi.DBOperations;
using static WebApi.BookOperations.CreateBook.CreateBookCommand;
using static WebApi.BookOperations.PutBookCommand.PutBookCommand;

namespace WebApi.AddControllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController:ControllerBase
    {
        private readonly BookStoreDbContext _context;

        public BookController (BookStoreDbContext context)
        { 
            _context = context;
        }
        
        //Http requestleri yakalayacak metotlar

        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBooksQuery query = new GetBooksQuery(_context);
            var result = query.Handle();
            return Ok(result);
        }   

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            BookOperations.GetByIdQuery.BooksViewModel result;
            GetByIdQuery query = new GetByIdQuery(_context,id);
            result=query.Handle();
            return Ok(result);
        }  

        // [HttpGet]
        // public Book Get([FromQuery] string id)
        // {
        //     var book =  _context.Books.Where(x => x.Id==Convert.ToInt32(id)).SingleOrDefault();
        //     return book;  
        // } 

        //post

        [HttpPost]
        public IActionResult AddBook([FromBody] CreateBookModel model)
        {
            CreateBookCommand command = new CreateBookCommand(_context);
            try
            {
                command.Model=model;
                command.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        //put

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id,[FromBody] PutCommandModel updatedBook)
        {
            PutBookCommand command = new PutBookCommand(_context);
            try
            {
                command.Model=updatedBook;
                command.Handle(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        //Delete
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book =  _context.Books.SingleOrDefault(x => x.Id == id);
            if (book is null)
            {
                return BadRequest();
            }
             _context.Books.Remove(book);
             _context.SaveChanges();
            return Ok();
        }
    }
}