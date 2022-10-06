using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.BookOperations.CreateBook
{
    public class CreateBookCommand
    {
        public CreateBookModel Model {get; set;}
        private readonly BookStoreDbContext dbContext;
        public CreateBookCommand(BookStoreDbContext _dbContext)
        {
            dbContext=_dbContext;
        }
        
        public void Handle()
        {
            var book =  dbContext.Books.SingleOrDefault(x=> x.Title == Model.Title);

            if (book is not null)
            {
                throw new InvalidOperationException("Kitap zaten mevcut");
            }
            book = new Book();
            book.Title=Model.Title;
            book.PublishDate=Model.PublishDate;
            book.PageCount=Model.PageCount;
            book.GenreId=Model.GenreId;
            
            dbContext.Books.Add(book);
            dbContext.SaveChanges();
        }

        public class CreateBookModel
        {
            public string Title { get; set; }
            public int GenreId { get; set; }
            public int PageCount { get; set; }
            public DateTime PublishDate { get; set; }
        }
    }
}