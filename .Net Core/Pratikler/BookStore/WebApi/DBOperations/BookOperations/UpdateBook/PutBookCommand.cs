using System;
using System.Collections.Generic;
using System.Linq;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.BookOperations.PutBookCommand
{
    public class PutBookCommand
    {
        public PutCommandModel Model {get; set;}
        private readonly BookStoreDbContext _dbContext;
        public PutBookCommand(BookStoreDbContext dbContext)
        {
            _dbContext=dbContext;
        }

        public void Handle(int id)
        {
            var book =  _dbContext.Books.SingleOrDefault(x => x.Id == id);
            if (book is null)
            {
                throw new InvalidOperationException("Kitap bulunamadı");
            }
            book.GenreId = Model.GenreId != default ? Model.GenreId : book.GenreId;
            book.PageCount=Model.PageCount != default ? Model.PageCount : book.PageCount;
            book.PublishDate = Model.PublishDate != default ? Model.PublishDate : book.PublishDate;
            book.Title = Model.Title != default ? Model.Title : book.Title;

            _dbContext.SaveChanges();
        }

        public class PutCommandModel
        {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
        public int GenreId { get; set; }
        }
    }

    
}